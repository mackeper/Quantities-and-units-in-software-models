using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{

  public class BenchmarkMonteCarloUnitsNet
  {
    [Params(10, 100, 1000, 10000, 100000, 1000000)]
    public int N;
    private readonly Func<UnitsNet.Length, UnitsNet.Length, UnitsNet.Length> H = 
      (x, y) => (x * x + y * y <= UnitsNet.Area.FromSquareCentimeters(1)) ? UnitsNet.Length.FromCentimeters(1) : UnitsNet.Length.FromCentimeters(0);
    private readonly UnitsNet.Length[] from = { UnitsNet.Length.FromCentimeters(-1), UnitsNet.Length.FromCentimeters(-1) };
    private readonly UnitsNet.Length[] to = { UnitsNet.Length.FromCentimeters(+1), UnitsNet.Length.FromCentimeters(+1) };

    [Benchmark]
    public UnitsNet.Area CalcPi()
    {
      return MonteCarloUnitsNet.Integrate(x => H(x[0], x[1]), from, to, N);
    }
  }

  [MemoryDiagnoser]
  public class MonteCarloUnitsNet
  {
    private int count;
    private UnitsNet.Length sum;
    private UnitsNet.Area sum2;

    public int NumberOfParameters { get; private set; }
    public UNRange[] Range { get; private set; }
    public Func<UnitsNet.Length[], UnitsNet.Length> Function { get; set; }
    public Random Random { get; set; }
    public UnitsNet.Area Area { get; set; }
    public UnitsNet.Area Error { get; set; }
    public int Iterations { get; set; }

    public MonteCarloUnitsNet(int parameters, Func<UnitsNet.Length[], UnitsNet.Length> function)
        : this(parameters)
    {
      if (function == null)
        throw new ArgumentNullException("function");

      this.Function = function;
    }

    public MonteCarloUnitsNet(int parameters)
    {
      if (parameters <= 0)
      {
        throw new ArgumentOutOfRangeException("parameters",
            "Number of parameters must be higher than zero.");
      }

      this.NumberOfParameters = parameters;
      this.Range = new UNRange[parameters];
      this.Random = new Random();

      for (int i = 0; i < Range.Length; i++)
        Range[i].Max = UnitsNet.Length.FromCentimeters(1);

      this.Iterations = 1000;
      this.Reset();
    }

    public void Reset()
    {
      this.sum = UnitsNet.Length.FromCentimeters(0);
      this.sum2 = UnitsNet.Area.FromSquareCentimeters(0);
      this.count = 0;
      this.Area = UnitsNet.Area.FromSquareCentimeters(0);
      this.Error = UnitsNet.Area.FromSquareCentimeters(Double.MaxValue);
    }

    public bool Compute()
    {
      UnitsNet.Length[] sample = new UnitsNet.Length[NumberOfParameters];

      for (int j = 0; j < Iterations; j++)
      {
        for (int i = 0; i < sample.Length; i++)
          sample[i] = UnitsNet.Length.FromCentimeters(Random.NextDouble() * Range[i].Length.Centimeters + Range[i].Min.Centimeters);

        UnitsNet.Length f = Function(sample);

        count++ ;
        sum += f;
        sum2 += f * f;
      }

      double volume = 1;
      for (int i = 0; i < Range.Length; i++)
        volume *= Range[i].Length.Centimeters;

      double avg = sum.Centimeters / count;
      double avg2 = sum2.SquareCentimeters / count;

      Area = UnitsNet.Area.FromSquareCentimeters(volume * avg);
      Error = UnitsNet.Area.FromSquareCentimeters(volume * Math.Sqrt((avg2 - avg * avg) / count));

      return true;
    }

    public static UnitsNet.Area Integrate(Func<UnitsNet.Length[], UnitsNet.Length> func, UnitsNet.Length[] a, UnitsNet.Length[] b, int samples)
    {
      var mc = new MonteCarloUnitsNet(a.Length, func);
      for (int i = 0; i < a.Length; i++)
        mc.Range[i] = new UNRange(a[i], b[i]);
      mc.Iterations = samples;
      mc.Compute();
      return mc.Area;
    }
  }

  public struct UNRange : IRange<UnitsNet.Length>
  {
    private UnitsNet.Length min, max;

    public UnitsNet.Length Min
    {
      get { return min; }
      set { min = value; }
    }

    public UnitsNet.Length Max
    {
      get { return max; }
      set { max = value; }
    }

    public UnitsNet.Length Length
    {
      get { return max - min; }
    }

    public UNRange(UnitsNet.Length min, UnitsNet.Length max)
    {
      this.min = min;
      this.max = max;
    }
  }
}
