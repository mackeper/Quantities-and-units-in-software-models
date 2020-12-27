
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
  [MemoryDiagnoser]
  public class BenchmarkMethodsDouble
  {
    private double length1 = 3.0;
    private double Length2 = 5.0;

    [Benchmark]
    public double FromMethod() => 3.0;

    [Benchmark]
    public double GetValueMethod() => length1;

    [Benchmark]
    public string ToStringTest() => length1.ToString();



    [Benchmark]
    public double operatorAdd() => length1 + Length2;

    [Benchmark]
    public double operatorSub() => length1 - Length2;

    [Benchmark]
    public double operatorMul() => length1 * Length2;

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
