
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkMethodsUnitsNet
  {
    private UnitsNet.Length length1 = UnitsNet.Length.FromCentimeters(3.0);
    private UnitsNet.Length Length2 = UnitsNet.Length.FromCentimeters(5.0);
    
    [Benchmark]
    public UnitsNet.Length FromMethod() => UnitsNet.Length.FromCentimeters(3.0);

    [Benchmark]
    public double GetValueProperty() => length1.Centimeters;

    [Benchmark]
    public string ToStringTest() => length1.ToString();



    [Benchmark]
    public UnitsNet.Length operatorAdd() => length1 + Length2;

    [Benchmark]
    public UnitsNet.Length operatorSub() => length1 - Length2;

    [Benchmark]
    public UnitsNet.Area operatorMul() => length1 * Length2;

    [Benchmark]
    public double operatorDiv() => length1 / Length2;



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
