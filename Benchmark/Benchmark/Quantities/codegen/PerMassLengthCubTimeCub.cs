
// GENERATE FILE! (27/05/2020 08:55:49)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassLengthCubTimeCub : Quantity, IEquatable<PerMassLengthCubTimeCub>, IComparable
  {  
    internal PerMassLengthCubTimeCub(double value) : base(value, 2)
    {
      PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassLengthCubTimeCub(PerMassLengthCubTimeCub other) : base(other)
    {
      PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthCubTimeCub"))
    {
      switch(FakeDatabase.Units["PerMassLengthCubTimeCub"])
      {
        case "perkilogramcentimetercubsecondcub": displayUnit_ = perkilogramcentimetercubsecondcub_; break;
        case "perkilogrammillimetercubsecondcub": displayUnit_ = perkilogrammillimetercubsecondcub_; break;
        case "perkilogrammetercubsecondcub": displayUnit_ = perkilogrammetercubsecondcub_; break;
        case "perkilograminchcubsecondcub": displayUnit_ = perkilograminchcubsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramcentimetercubsecondcub_ = new Unit_("PerKilogramCentimeterCubSecondCub", "/kg cm³ s³", 1.0, 0);
  private static Unit_ perkilogrammillimetercubsecondcub_ = new Unit_("PerKilogramMillimeterCubSecondCub", "/kg mm³ s³", 999.9999999999998, 0);
  private static Unit_ perkilogrammetercubsecondcub_ = new Unit_("PerKilogramMeterCubSecondCub", "/kg m³ s³", 1e-06, 0);
  private static Unit_ perkilograminchcubsecondcub_ = new Unit_("PerKilogramInchCubSecondCub", "/kg in³ s³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = perkilogramcentimetercubsecondcub_;
  private static Unit_ displayUnit_ = perkilogramcentimetercubsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassLengthCubTimeCub other && Equals(other);
  public bool Equals(PerMassLengthCubTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassLengthCubTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassLengthCubTimeCub other)) throw new ArgumentException("Object is not a PerMassLengthCubTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => !(l1 == l2);
  public static bool operator <(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassLengthCubTimeCub FromPerKilogramCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub((value + perkilogramcentimetercubsecondcub_.Offset) * perkilogramcentimetercubsecondcub_.Factor, minValue * perkilogramcentimetercubsecondcub_.Factor, maxValue * perkilogramcentimetercubsecondcub_.Factor);
  public static PerMassLengthCubTimeCub FromPerKilogramCentimeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub((value + perkilogramcentimetercubsecondcub_.Offset) * perkilogramcentimetercubsecondcub_.Factor);
  public double GetValueInPerKilogramCentimeterCubSecondCubs() => (Value_ - perkilogramcentimetercubsecondcub_.Offset) / perkilogramcentimetercubsecondcub_.Factor;
  public static PerMassLengthCubTimeCub FromPerKilogramMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub((value + perkilogrammillimetercubsecondcub_.Offset) * perkilogrammillimetercubsecondcub_.Factor, minValue * perkilogrammillimetercubsecondcub_.Factor, maxValue * perkilogrammillimetercubsecondcub_.Factor);
  public static PerMassLengthCubTimeCub FromPerKilogramMillimeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub((value + perkilogrammillimetercubsecondcub_.Offset) * perkilogrammillimetercubsecondcub_.Factor);
  public double GetValueInPerKilogramMillimeterCubSecondCubs() => (Value_ - perkilogrammillimetercubsecondcub_.Offset) / perkilogrammillimetercubsecondcub_.Factor;
  public static PerMassLengthCubTimeCub FromPerKilogramMeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub((value + perkilogrammetercubsecondcub_.Offset) * perkilogrammetercubsecondcub_.Factor, minValue * perkilogrammetercubsecondcub_.Factor, maxValue * perkilogrammetercubsecondcub_.Factor);
  public static PerMassLengthCubTimeCub FromPerKilogramMeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub((value + perkilogrammetercubsecondcub_.Offset) * perkilogrammetercubsecondcub_.Factor);
  public double GetValueInPerKilogramMeterCubSecondCubs() => (Value_ - perkilogrammetercubsecondcub_.Offset) / perkilogrammetercubsecondcub_.Factor;
  public static PerMassLengthCubTimeCub FromPerKilogramInchCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub((value + perkilograminchcubsecondcub_.Offset) * perkilograminchcubsecondcub_.Factor, minValue * perkilograminchcubsecondcub_.Factor, maxValue * perkilograminchcubsecondcub_.Factor);
  public static PerMassLengthCubTimeCub FromPerKilogramInchCubSecondCubs(double value) => new PerMassLengthCubTimeCub((value + perkilograminchcubsecondcub_.Offset) * perkilograminchcubsecondcub_.Factor);
  public double GetValueInPerKilogramInchCubSecondCubs() => (Value_ - perkilograminchcubsecondcub_.Offset) / perkilograminchcubsecondcub_.Factor;

#endregion

#region arithmetic
  public static PerMassLengthCubTimeCub operator+(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ + o2.Value_);
  public static PerMassLengthCubTimeCub operator-(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerMassLengthCubTimeCub o1, LengthCubTimeCubMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubTimeCubMass o1, PerMassLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
#endregion

#region rules

  public double MinValue { get; }
  public double MaxValue { get; }
  public bool HasMinValue { get; }
  public bool HasMaxValue { get; }
  public bool ValidateRules(bool throwOnFail=true)
  {
    bool fail = false;
    if (this.HasMinValue && this.Value_ < this.MinValue)
    {
      fail = true;
    }  
    if (this.HasMaxValue && this.Value_ > this.MaxValue)
    {
      fail = true;
    }  
    if (fail && throwOnFail)
    {
      throw new System.ArgumentException("PerMassLengthCubTimeCub is outside its bounds.");
    }
    else if (fail)
    {
      return false;
    }  
    return true;
  }

#endregion

	}
}
    