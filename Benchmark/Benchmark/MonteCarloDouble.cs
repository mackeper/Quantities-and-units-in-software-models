using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{

  public class BenchmarkMonteCarloDouble
  {
    [Params(10, 100, 1000, 10000, 100000, 1000000)]
    public int N;
    private readonly Func<double, double, double> H = (x, y) => (x * x + y * y <= 1) ? 1 : 0;
    private readonly double[] from = { -1, -1 };
    private readonly double[] to = { +1, +1 };

    [Benchmark]
    public double CalcPi()
    {
      return MonteCarloDouble.Integrate(x => H(x[0], x[1]), from, to, N);
    }
  }

  public class MonteCarloDouble
  {
    private int count;
    private double sum;
    private double sum2;

    public int NumberOfParameters { get; private set; }
    public DoubleRange[] Range { get; private set; }
    public Func<double[], double> Function { get; set; }
    public Random Random { get; set; }
    public double Area { get; set; }
    public double Error { get; set; }
    public int Iterations { get; set; }

    public MonteCarloDouble(int parameters, Func<double[], double> function)
        : this(parameters)
    {
      if (function == null)
        throw new ArgumentNullException("function");

      this.Function = function;
    }

    public MonteCarloDouble(int parameters)
    {
      if (parameters <= 0)
      {
        throw new ArgumentOutOfRangeException("parameters",
            "Number of parameters must be higher than zero.");
      }

      this.NumberOfParameters = parameters;
      this.Range = new DoubleRange[parameters];
      this.Random = new Random();

      for (int i = 0; i < Range.Length; i++)
        Range[i].Max = 1;

      this.Iterations = 1000;
      this.Reset();
    }

    public void Reset()
    {
      this.sum = 0;
      this.sum2 = 0;
      this.count = 0;
      this.Area = 0;
      this.Error = Double.MaxValue;
    }

    public bool Compute()
    {
      double[] sample = new double[NumberOfParameters];

      for (int j = 0; j < Iterations; j++)
      {
        for (int i = 0; i < sample.Length; i++)
          sample[i] = Random.NextDouble() * Range[i].Length + Range[i].Min;

        double f = Function(sample);

        count++;
        sum += f;
        sum2 += f * f;
      }

      double volume = 1;
      for (int i = 0; i < Range.Length; i++)
        volume *= Range[i].Length;

      double avg = sum / count;
      double avg2 = sum2 / count;

      Area = volume * avg;
      Error = volume * Math.Sqrt((avg2 - avg * avg) / count);

      return true;
    }

    public static double Integrate(Func<double[], double> func, double[] a, double[] b, int samples)
    {
      var mc = new MonteCarloDouble(a.Length, func);
      for (int i = 0; i < a.Length; i++)
        mc.Range[i] = new DoubleRange(a[i], b[i]);
      mc.Iterations = samples;
      mc.Compute();
      return mc.Area;
    }

  }

  public interface IRange<T>
  {
    T Min { get; set; }
    T Max { get; set; }
  }

  public struct DoubleRange : IRange<double>
  {
    private double min, max;

    public double Min
    {
      get { return min; }
      set { min = value; }
    }

    public double Max
    {
      get { return max; }
      set { max = value; }
    }

    public double Length
    {
      get { return max - min; }
    }

    public DoubleRange(double min, double max)
    {
      this.min = min;
      this.max = max;
    }
  }
}
