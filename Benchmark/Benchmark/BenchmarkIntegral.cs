using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkIntegral
  {
    private List<double> Dlist_;
    private List<RayQuantities.Length> Qlist_;
    private List<UnitsNet.Length> UNlist_;

    [Params(10, 100, 1000, 10000, 100000, 1000000, 10000000)]
    public int N;
    private double DELTA_X;
    private double a = -50;
    private double b = 50;

    public BenchmarkIntegral()
    {
      UNlist_ = new List<UnitsNet.Length>();
      Dlist_ = new List<double>();
      Qlist_ = new List<RayQuantities.Length>();
    }

    private double f(double d) => d * d;

    [IterationSetup]
    public void Setup()
    {
      DELTA_X = (b - a) / N;
      for (var x = a; x <= b; x += DELTA_X)
      {
        Dlist_.Add(f(x));
        Qlist_.Add(RayQuantities.Length.FromCentimeters(f(x)));
        UNlist_.Add(UnitsNet.Length.FromCentimeters(f(x)));
      }
    }

    [IterationCleanup]
    public void Cleanup()
    {
      Dlist_.Clear();
      Qlist_.Clear();
      UNlist_.Clear();
    }

    public double integral(Func<double, double> f) {
      double sum = 0.0; 
      for (var x_k = a; x_k <= b; x_k += DELTA_X) {
          sum += f(x_k) * DELTA_X;
      }
      return sum;
    }

    [Benchmark]
    public RayQuantities.Area testQuantities()
    {
      var sum = RayQuantities.Area.FromCentimeterSqrs(0);
      var d = RayQuantities.Length.FromCentimeters(DELTA_X);
      for (int i = 0; i < N; i++)
      {
        sum += Qlist_[i] * d;
      }
      return sum;
    }

    [Benchmark]
    public UnitsNet.Area testUnitsNet()
    {
      var sum = UnitsNet.Area.FromSquareCentimeters(0);
      var d = UnitsNet.Length.FromCentimeters(DELTA_X);
      for (int i = 0; i < N; i++)
      {
        sum += UNlist_[i] * d;
      }
      return sum;
    }

    [Benchmark]
    public double testDouble()
    {
      var sum = 0.0;
      for (int i = 0; i < N; i++)
      {
        sum += Dlist_[i] * DELTA_X;
      }
      return sum;
    }
  }
}
