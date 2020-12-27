using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{

  public class BenchmarkMonteCarloRayQuantities
  {
    [Params(10, 100, 1000, 10000, 100000, 1000000)]
    public int N;
    private readonly Func<RayQuantities.Length, RayQuantities.Length, RayQuantities.Length> H = 
      (x, y) => (x * x + y * y <= RayQuantities.Area.FromCentimeterSqrs(1)) ? RayQuantities.Length.FromCentimeters(1) : RayQuantities.Length.FromCentimeters(0);
    private readonly RayQuantities.Length[] from = { RayQuantities.Length.FromCentimeters(-1), RayQuantities.Length.FromCentimeters(-1) };
    private readonly RayQuantities.Length[] to = { RayQuantities.Length.FromCentimeters(+1), RayQuantities.Length.FromCentimeters(+1) };

    [Benchmark]
    public RayQuantities.Area CalcPi()
    {
      return MonteCarloRayQuantities.Integrate(x => H(x[0], x[1]), from, to, N);
    }
  }

  [MemoryDiagnoser]
  public class MonteCarloRayQuantities
  {
    private int count;
    private RayQuantities.Length sum;
    private RayQuantities.Area sum2;

    public int NumberOfParameters { get; private set; }
    public RQRange[] Range { get; private set; }
    public Func<RayQuantities.Length[], RayQuantities.Length> Function { get; set; }
    public Random Random { get; set; }
    public RayQuantities.Area Area { get; set; }
    public RayQuantities.Area Error { get; set; }
    public int Iterations { get; set; }

    public MonteCarloRayQuantities(int parameters, Func<RayQuantities.Length[], RayQuantities.Length> function)
        : this(parameters)
    {
      if (function == null)
        throw new ArgumentNullException("function");

      this.Function = function;
    }

    public MonteCarloRayQuantities(int parameters)
    {
      if (parameters <= 0)
      {
        throw new ArgumentOutOfRangeException("parameters",
            "Number of parameters must be higher than zero.");
      }

      this.NumberOfParameters = parameters;
      this.Range = new RQRange[parameters];
      this.Random = new Random();

      for (int i = 0; i < Range.Length; i++)
        Range[i].Max = RayQuantities.Length.FromCentimeters(1);

      this.Iterations = 1000;
      this.Reset();
    }

    public void Reset()
    {
      this.sum = RayQuantities.Length.FromCentimeters(0);
      this.sum2 = RayQuantities.Area.FromCentimeterSqrs(0);
      this.count = 0;
      this.Area = RayQuantities.Area.FromCentimeterSqrs(0);
      this.Error = RayQuantities.Area.FromCentimeterSqrs(Double.MaxValue);
    }

    public bool Compute()
    {
      RayQuantities.Length[] sample = new RayQuantities.Length[NumberOfParameters];

      for (int j = 0; j < Iterations; j++)
      {
        for (int i = 0; i < sample.Length; i++)
          sample[i] = RayQuantities.Length.FromCentimeters(Random.NextDouble() * Range[i].Length.GetValueInCentimeters() + Range[i].Min.GetValueInCentimeters());

        RayQuantities.Length f = Function(sample);

        count++;
        sum += f;
        sum2 += f * f;
      }

      double volume = 1;
      for (int i = 0; i < Range.Length; i++)
        volume *= Range[i].Length.GetValueInCentimeters();

      double avg = sum.GetValueInCentimeters() / count;
      double avg2 = sum2.GetValueInCentimeterSqrs() / count;

      Area = RayQuantities.Area.FromCentimeterSqrs(volume * avg);
      Error = RayQuantities.Area.FromCentimeterSqrs(volume * Math.Sqrt((avg2 - avg * avg) / count));

      return true;
    }

    public static RayQuantities.Area Integrate(Func<RayQuantities.Length[], RayQuantities.Length> func, RayQuantities.Length[] a, RayQuantities.Length[] b, int samples)
    {
      var mc = new MonteCarloRayQuantities(a.Length, func);
      for (int i = 0; i < a.Length; i++)
        mc.Range[i] = new RQRange(a[i], b[i]);
      mc.Iterations = samples;
      mc.Compute();
      return mc.Area;
    }
  }

  public struct RQRange : IRange<RayQuantities.Length>
  {
    private RayQuantities.Length min, max;

    public RayQuantities.Length Min
    {
      get { return min; }
      set { min = value; }
    }

    public RayQuantities.Length Max
    {
      get { return max; }
      set { max = value; }
    }

    public RayQuantities.Length Length
    {
      get { return max - min; }
    }

    public RQRange(RayQuantities.Length min, RayQuantities.Length max)
    {
      this.min = min;
      this.max = max;
    }
  }
}
