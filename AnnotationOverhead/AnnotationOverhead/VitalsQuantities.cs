using System;
using RaySearch.CorePlatform.Framework;

namespace AnnotationOverhead
{
  class VitalsQuantities : IVitals
  {
    private readonly Length height_;
    private readonly Mass weight_;
    private const string formula_ = "Mosteller";

    public VitalsQuantities(Length height, Mass weight)
    {
      height_ = height;
      weight_ = weight;
    }

    public string BodyMassIndexString() => CalcBMI().ToString();

    public string BodySurfaceAreaString() => Area.FromMeterSqrs(CalcBSA(formula_)).ToString();

    public string HeightString() => height_.ToString();

    public string WeightString() => weight_.ToString();

    private MassPerLengthSqr CalcBMI() => weight_ / (height_ * height_);

    public double CalcBSA(string formula)
    {
      //Formulas from Redlarski, Grzegorz, Aleksander Palkowski, and Marek Krawczuk.
      //"Body surface area formulae: an alarming ambiguity." Scientific reports 6 (2016): 27966. https://doi.org/10.1038/srep27966
      switch (formula)
      {
        case "Mosteller":
          return Math.Sqrt(weight_.GetValueInKilograms() * height_.GetValueInCentimeters() / 3600.0);
        case "Du Bois":
          return 0.007184 * Math.Pow(weight_.GetValueInKilograms(), 0.425) * Math.Pow(height_.GetValueInCentimeters(), 0.725);
        case "Haycock":
          return 0.024265 * Math.Pow(weight_.GetValueInKilograms(), 0.5378) * Math.Pow(height_.GetValueInCentimeters(), 0.3964);
        case "Gehan and George":
          return 0.0235 * Math.Pow(weight_.GetValueInKilograms(), 0.51456) * Math.Pow(height_.GetValueInCentimeters(), 0.42246);
        default:
          throw new System.ArgumentException("Unknown BSA caculation fomula");
      }
    }
  }
}
