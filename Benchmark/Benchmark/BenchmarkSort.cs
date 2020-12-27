using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkSort
  {
    private double[] DlistA_;
    private RayQuantities.Length[] QlistA_;
    private UnitsNet.Length[] UNlistA_;
    [Params(10, 100, 1000, 10000, 100000, 1000000, 10000000)]
    public int N;

    [IterationSetup]
    public void initLists()
    {
      DlistA_ = new double[N];
      QlistA_ = new RayQuantities.Length[N];
      UNlistA_ = new UnitsNet.Length[N];
      Random rand = new Random(7);
      for (int i = 0; i < N; i++)
      {
        var y_value = rand.NextDouble();
        DlistA_[i] = y_value;
        QlistA_[i] = RayQuantities.Length.FromCentimeters(y_value);
        UNlistA_[i] = UnitsNet.Length.FromCentimeters(y_value);
      }
    }

    [Benchmark]
    public void testQuantities() => Array.Sort(QlistA_);

    [Benchmark]
    public void testUnitsNet() => Array.Sort(UNlistA_);

    [Benchmark]
    public void testDouble() => Array.Sort(DlistA_);
  }
}
