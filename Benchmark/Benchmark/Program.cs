using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

namespace Benchmark
{
  public class Config : ManualConfig
  {
    public Config()
    {
      var dc = DefaultConfig.Instance;
      AddExporter(CsvMeasurementsExporter.Default);
      AddExporter(RPlotExporter.Default);
      foreach (var x in dc.GetExporters())
      {
        AddExporter(x);
      }

      foreach (var x in dc.GetJobs())
      {
        AddJob(x);
      }

      foreach (var x in dc.GetHardwareCounters())
      {
        AddHardwareCounters(x);
      }

      foreach (var x in dc.GetFilters())
      {
        AddFilter(x);
      }

      foreach (var x in dc.GetDiagnosers())
      {
        AddDiagnoser(x);
      }

      foreach (var x in dc.GetLoggers())
      {
        AddLogger(x);
      }
      foreach (var cp in dc.GetColumnProviders())
      {
        AddColumnProvider(cp);
      }
    }
  }

  class Program
  {

    public static void DoubleToLongBits(double argument)
    {
      long longValue = BitConverter.DoubleToInt64Bits(argument);
      string bits = Convert.ToString(longValue, 2);
      string sign = bits.Substring(0, 1);
      string exponent = bits.Substring(1, 11);
      string matissa = bits.Substring(12, bits.Length-12);
      Console.WriteLine($"{argument}");
      Console.WriteLine($"{bits.Length}");
      Console.WriteLine($"{bits}");
      Console.WriteLine($"{sign} {exponent} {matissa}\n");
    }

    public static double ConvertMtoCM(double meter) => meter * 100;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1481:Unused local variables should be removed", Justification = "<Pending>")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
    static void Main(string[] args)
    {
      var summary1 = BenchmarkRunner.Run<BenchmarkIntegral>(new Config());
      //var summary2 = BenchmarkRunner.Run<BenchmarkSort>(new Config());
     // var summary3 = BenchmarkRunner.Run<BenchmarkInitlist>(new Config());
      //var summary4 = BenchmarkRunner.Run<BenchmarkMethodsQuantities>(new Config());
      //var summary5 = BenchmarkRunner.Run<BenchmarkMethodsUnitsNet>(new Config());
      //var summary6 = BenchmarkRunner.Run<BenchmarkMethodsDouble>();
      //var summary7 = BenchmarkRunner.Run<BenchmarkMonteCarlo>();

      //new BenchmarkMonteCarloRayQuantities().CalcPi();

      //var test = UnitsNet.Length.FromCentimeters(1) / UnitsNet.Length.FromCentimeters(2);

      //var value1 = 2.56;
      //var value2 = 2.56;
      //var value3 = 0.1;
      //var value4 = value1 * value2 * value3;
      //var value5 = (value4 / value3) / value2;
      //DoubleToLongBits(value1);
      //DoubleToLongBits(value2);
      //DoubleToLongBits(value3);
      //DoubleToLongBits(value4);
      //DoubleToLongBits(value5);

      //Console.WriteLine(l1*l2);
      //Console.WriteLine(l3*l4);
      //Console.WriteLine(l1*l2 == l3*l4);
      //Console.WriteLine(0.01*300 == 3);


      //      // Ways to construct an UnitsNet.Length (more units exists)
      //      //var un_length1 = UnitsNet.Length.FromCentimeters(1);
      //      //var un_length2 = UnitsNet.Length.FromMeters(1);
      //      var un_length3 = UnitsNet.Length.Parse("1 cm");
      //      var un_length4 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Centimeter);
      //
      //
      //      // Ways to construct a RayQuantities.Length (more units exists)
      //      //var rq_length1 = RayQuantities.Length.FromCentimeters(1);
      //      //var rq_length2 = RayQuantities.Length.FromMeters(1);
      //
      //
      //      // Some ways to construct a length using doubles
      //      //var d_length1 = 1.0; // centimeter
      //      var d_length2_in_meters = 1.0;
      //      var d_length3 = ConvertMtoCM(1.0);
      //
      //      // Ways to export UnitsNet.Length to a double (more units exists)
      //      //var un_length1 = UnitsNet.Length.FromCentimeters(1);
      //      var un_length2 = UnitsNet.Length.FromMeters(1);
      //      double un_length1_as_double = un_length1.Centimeters;   // 1
      //      double un_length2_as_double = un_length2.Meters;        // 1
      //      double un_length21_as_double = un_length2.Centimeters;  // 100
      //      double un_length11_as_double = un_length1.Value;        // 1 (Centimeter)
      //      double un_length22_as_double = un_length2.Value;        // 1 (Meter)
      //
      //
      //      // Ways to export RayQuantities.Length to a double (more units exists)
      //      //var rq_length1 = RayQuantities.Length.FromCentimeters(1);
      //      var rq_length2 = RayQuantities.Length.FromMeters(1);
      //      double rq_length1_as_double = rq_length1.GetValueInCentimeters();   // 1
      //      double rq_length2_as_double = rq_length2.GetValueInMeters();        // 1
      //      double rq_length21_as_double = rq_length2.GetValueInCentimeters();  // 100
      //
      //
      //
      //
      //      // Calculate the force using RayQuantities
      //      RayQuantities.Length rq_length1 = RayQuantities.Length.FromCentimeters(1);
      //      RayQuantities.Mass rq_mass1 = RayQuantities.Mass.FromKilograms(1);
      //      RayQuantities.Time rq_time1 = RayQuantities.Time.FromSeconds(2);
      //      RayQuantities.Speed rq_speed1 = rq_length1 / rq_time1;
      //      RayQuantities.Acceleration rq_acceleration1 = rq_speed1 / rq_time1;
      //      
      //      // Mass / Acceleration
      //      RayQuantities.Force rq_force1 = rq_mass1 * rq_acceleration1;
      //      // LengtMassPerTime / Time
      //      RayQuantities.Force rq_force2 = (rq_mass1 * rq_speed1) / rq_time1; 
      //      // (LengthMass / Time) / Time
      //      RayQuantities.Force rq_force3 = ((rq_mass1 * rq_length1) / rq_time1) / rq_time1; 
      //      // LengthMass / PerTimeSqr
      //      RayQuantities.Force rq_force4 = (rq_mass1 * rq_length1) / (rq_time1 * rq_time1);
      //
      //
      //      // Calculate the force using UnitsNet
      //      UnitsNet.Length un_length1 = UnitsNet.Length.FromCentimeters(1);
      //      UnitsNet.Mass un_mass1 = UnitsNet.Mass.FromKilograms(1);
      //      UnitsNet.Duration un_time1 = UnitsNet.Duration.FromSeconds(2);
      //      UnitsNet.Speed un_speed1 = un_length1 / un_time1;
      //      UnitsNet.Acceleration un_acceleration1 = un_speed1 / un_time1;
      //
      //      // Mass / Acceleration
      //      UnitsNet.Force un_force1 = un_mass1 * un_acceleration1;
      //      // Mass / ((Length / Time) / Time)
      //      UnitsNet.Force un_force2 = un_mass1 * ((un_length1 / un_time1) / un_time1);
      //
      //
      //      // Calculate the force using doubles
      //      double d_length1 = 1;
      //      double d_mass1 = 1;
      //      double d_time1 = 2;
      //      double d_speed1 = d_length1 / d_time1;
      //      double d_acceleration1 = d_speed1 / d_time1;
      //
      //      double d_force1 = d_mass1 / d_acceleration1;
      //      double d_force2 = ((d_mass1 * d_length1) / d_time1) / d_time1;
    }
  }
}
