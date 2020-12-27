using System;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkMonteCarlo
  {
    [Params(10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000)]
    public int N;

    private readonly Func<RayQuantities.Length, RayQuantities.Length, RayQuantities.Length> RQH =
      (x, y) => (x * x + y * y <= RayQuantities.Area.FromCentimeterSqrs(1)) ? RayQuantities.Length.FromCentimeters(1) : RayQuantities.Length.FromCentimeters(0);
    private readonly RayQuantities.Length[] RQfrom = { RayQuantities.Length.FromCentimeters(-1), RayQuantities.Length.FromCentimeters(-1) };
    private readonly RayQuantities.Length[] RQto = { RayQuantities.Length.FromCentimeters(+1), RayQuantities.Length.FromCentimeters(+1) };

    private readonly Func<UnitsNet.Length, UnitsNet.Length, UnitsNet.Length> UNH =
      (x, y) => (x * x + y * y <= UnitsNet.Area.FromSquareCentimeters(1)) ? UnitsNet.Length.FromCentimeters(1) : UnitsNet.Length.FromCentimeters(0);
    private readonly UnitsNet.Length[] UNfrom = { UnitsNet.Length.FromCentimeters(-1), UnitsNet.Length.FromCentimeters(-1) };
    private readonly UnitsNet.Length[] UNto = { UnitsNet.Length.FromCentimeters(+1), UnitsNet.Length.FromCentimeters(+1) };

    private readonly Func<double, double, double> DH = (x, y) => (x * x + y * y <= 1) ? 1 : 0;
    private readonly double[] Dfrom = { -1, -1 };
    private readonly double[] Dto = { +1, +1 };

    [Benchmark]
    public RayQuantities.Area CalcPiRayQuantities()
    {
      return MonteCarloRayQuantities.Integrate(x => RQH(x[0], x[1]), RQfrom, RQto, N);
    }

    [Benchmark]
    public UnitsNet.Area CalcPiUnitsNet()
    {
      return MonteCarloUnitsNet.Integrate(x => UNH(x[0], x[1]), UNfrom, UNto, N);
    }

    [Benchmark]
    public double CalcPiDouble()
    {
      return MonteCarloDouble.Integrate(x => DH(x[0], x[1]), Dfrom, Dto, N);
    }
  }
}
