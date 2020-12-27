using System;

namespace AnnotationOverhead
{
  class VitalsDouble : IVitals
  {
    private readonly Double height_;
    private readonly Double weight_;
    private const string formula_ = "Mosteller";

    public VitalsDouble(Double height, Double weight)
    {
      height_ = height;
      weight_ = weight;
    }

    public string BodyMassIndexString() => $"{CalcBMI().ToString("0." + new String('#', 2))} kg / m²".ToString();

    public string BodySurfaceAreaString() => $"{CalcBSA(formula_).ToString("0." + new String('#', 2))} m²";

    public string HeightString() =>  $"{height_.ToString("0." + new String('#', 2))} cm";

    public string WeightString() => $"{weight_.ToString("0." + new String('#', 2))}  kg";

    private double CalcBMI() => weight_ / ((height_ * height_)/10000);

    public double CalcBSA(string formula)
    {
      //Formulas from Redlarski, Grzegorz, Aleksander Palkowski, and Marek Krawczuk.
      //"Body surface area formulae: an alarming ambiguity." Scientific reports 6 (2016): 27966. https://doi.org/10.1038/srep27966
      switch (formula)
      {
        case "Mosteller":
          return Math.Sqrt(weight_ * height_ / 3600.0);
        case "Du Bois":
          return 0.007184 * Math.Pow(weight_, 0.425) * Math.Pow(height_, 0.725);
        case "Haycock":
          return 0.024265 * Math.Pow(weight_, 0.5378) * Math.Pow(height_, 0.3964);
        case "Gehan and George":
          return 0.0235 * Math.Pow(weight_, 0.51456) * Math.Pow(height_, 0.42246);
        default:
          throw new System.ArgumentException("Unknown BSA caculation fomula");
      }
    }
  }
}
