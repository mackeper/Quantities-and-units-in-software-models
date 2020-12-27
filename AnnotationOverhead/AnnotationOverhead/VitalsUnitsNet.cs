using System;
using UnitsNet;

namespace AnnotationOverhead
{
  class VitalsUnitsNet : IVitals
  {
    private readonly Length height_;
    private readonly Mass weight_;
    private const string formula_ = "Mosteller";

    public VitalsUnitsNet(Length height, Mass weight)
    {
      height_ = height;
      weight_ = weight;
    }

    public string BodyMassIndexString() => $"{CalcBMI().ToString("0." + new String('#', 2))} kg / m²";

    public string BodySurfaceAreaString() => Area.FromSquareMeters(CalcBSA(formula_)).ToString();

    public string HeightString() => height_.ToString();

    public string WeightString() => weight_.ToString();

    private double CalcBMI() => weight_.Kilograms / (height_.Meters * height_.Meters);

    public double CalcBSA(string formula)
    {
      //Formulas from Redlarski, Grzegorz, Aleksander Palkowski, and Marek Krawczuk.
      //"Body surface area formulae: an alarming ambiguity." Scientific reports 6 (2016): 27966. https://doi.org/10.1038/srep27966
      switch (formula)
      {
        case "Mosteller":
          return Math.Sqrt(weight_.Kilograms * height_.Centimeters / 3600.0);
        case "Du Bois":
          return 0.007184 * Math.Pow(weight_.Kilograms, 0.425) * Math.Pow(height_.Centimeters, 0.725);
        case "Haycock":
          return 0.024265 * Math.Pow(weight_.Kilograms, 0.5378) * Math.Pow(height_.Centimeters, 0.3964);
        case "Gehan and George":
          return 0.0235 * Math.Pow(weight_.Kilograms, 0.51456) * Math.Pow(height_.Centimeters, 0.42246);
        default:
          throw new System.ArgumentException("Unknown BSA caculation fomula");
      }
    }
  }
}
