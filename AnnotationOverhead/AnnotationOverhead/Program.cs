using System;
using System.Collections.Generic;

namespace AnnotationOverhead
{
  class Program
  {
    static void Main(string[] args)
    {
      var height = 180;
      var weight = 75;
      var vitals = new List<IVitals>();
      vitals.Add(new VitalsDouble(height, weight));
      vitals.Add(new VitalsQuantities(RaySearch.CorePlatform.Framework.Length.FromCentimeters(height), RaySearch.CorePlatform.Framework.Mass.FromKilograms(weight)));
      vitals.Add(new VitalsUnitsNet(UnitsNet.Length.FromCentimeters(height), UnitsNet.Mass.FromKilograms(weight)));

      foreach (var vital in vitals)
      {
        Console.WriteLine(vital.GetType());
        Console.WriteLine("Height:" + vital.HeightString());
        Console.WriteLine("Weight:" + vital.WeightString());
        Console.WriteLine("BMI:" + vital.BodyMassIndexString());
        Console.WriteLine("BSA:" + vital.BodySurfaceAreaString());
        Console.WriteLine();
      }


      Console.WriteLine(UnitsNet.Length.FromMeters(1).Value);
      Console.WriteLine(UnitsNet.Length.FromCentimeters(1).Value);

    }
  }
}
