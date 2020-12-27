
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkMethodsQuantities
  {
    private RayQuantities.Length length1 = RayQuantities.Length.FromCentimeters(3.0);
    private RayQuantities.Length Length2 = RayQuantities.Length.FromCentimeters(5.0);
    
    [Benchmark]
    public UnitsNet.Length FromMethod() => UnitsNet.Length.FromCentimeters(3.0);

    [Benchmark]
    public double GetValueMethod() => length1.GetValueInCentimeters();

    [Benchmark]
    public string ToStringTest() => length1.ToString();



    [Benchmark]
    public RayQuantities.Length operatorAdd() => length1 + Length2;

    [Benchmark]
    public RayQuantities.Length operatorSub() => length1 - Length2;

    [Benchmark]
    public RayQuantities.Area operatorMul() => length1 * Length2;

    [Benchmark]
    public RayQuantities.Dimensionless operatorDiv() => length1 / Length2;



    [Benchmark]
    public bool operatorEq() => length1 == Length2;

    [Benchmark]
    public bool operatorNeq() => length1 != Length2;

    [Benchmark]
    public bool operatorGt() => length1 > Length2;

    [Benchmark]
    public bool operatorGoet() => length1 >= Length2;

    [Benchmark]
    public bool operatorLt() => length1 < Length2;

    [Benchmark]
    public bool operatorLoet() => length1 <= Length2;
    


    [Benchmark]
    public int compareTo() => length1.CompareTo(Length2);

    [Benchmark]
    public int compareToObj() => length1.CompareTo((object)Length2);
  }
}
