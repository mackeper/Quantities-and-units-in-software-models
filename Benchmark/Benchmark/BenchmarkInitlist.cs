using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkInitlist
  {
    [Params(10, 100, 1000, 10000, 100000, 1000000, 10000000)]
    public int N;

    [IterationSetup]
    private void Setup()
    {
    }

    [IterationCleanup]
    private void Cleanup()
    {
    }

    [Benchmark]
    public void testQuantities()
    {
      List<RayQuantities.Length> Qlist = new List<RayQuantities.Length>();
      Random rand = new Random(7);
      for (int i = 0; i < N; i++)
      {
        var y_value = rand.NextDouble();
        Qlist.Add(RayQuantities.Length.FromCentimeters(y_value));
      }
    }

    [Benchmark]
    public void testUnitsNet()
    {
      List<UnitsNet.Length> UNlist = new List<UnitsNet.Length>();
      Random rand = new Random(7);
      for (int i = 0; i < N; i++)
      {
        var y_value = rand.NextDouble();
        UNlist.Add(UnitsNet.Length.FromCentimeters(y_value));
      }
    }

    [Benchmark]
    public void testDouble()
    {
      List<double> Dlist = new List<double>();
      Random rand = new Random(7);
      for (int i = 0; i < N; i++)
      {
        var y_value = rand.NextDouble();
        Dlist.Add(y_value);
      }
    }
  }
}
