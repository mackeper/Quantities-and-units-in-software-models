
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthCubTimeCub : Quantity, IEquatable<PerLengthCubTimeCub>, IComparable
  {  
    internal PerLengthCubTimeCub(double value) : base(value, 2)
    {
      PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthCubTimeCub(PerLengthCubTimeCub other) : base(other)
    {
      PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthCubTimeCub"))
    {
      switch(FakeDatabase.Units["PerLengthCubTimeCub"])
      {
        case "percentimetercubsecondcub": displayUnit_ = percentimetercubsecondcub_; break;
        case "permillimetercubsecondcub": displayUnit_ = permillimetercubsecondcub_; break;
        case "permetercubsecondcub": displayUnit_ = permetercubsecondcub_; break;
        case "perinchcubsecondcub": displayUnit_ = perinchcubsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimetercubsecondcub_ = new Unit_("PerCentimeterCubSecondCub", "/cm³ s³", 1.0, 0);
  private static Unit_ permillimetercubsecondcub_ = new Unit_("PerMillimeterCubSecondCub", "/mm³ s³", 0.001, 0);
  private static Unit_ permetercubsecondcub_ = new Unit_("PerMeterCubSecondCub", "/m³ s³", 1000000.0, 0);
  private static Unit_ perinchcubsecondcub_ = new Unit_("PerInchCubSecondCub", "/in³ s³", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = percentimetercubsecondcub_;
  private static Unit_ displayUnit_ = percentimetercubsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthCubTimeCub other && Equals(other);
  public bool Equals(PerLengthCubTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthCubTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthCubTimeCub other)) throw new ArgumentException("Object is not a PerLengthCubTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => !(l1 == l2);
  public static bool operator <(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthCubTimeCub FromPerCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub((value + percentimetercubsecondcub_.Offset) * percentimetercubsecondcub_.Factor, minValue * percentimetercubsecondcub_.Factor, maxValue * percentimetercubsecondcub_.Factor);
  public static PerLengthCubTimeCub FromPerCentimeterCubSecondCubs(double value) => new PerLengthCubTimeCub((value + percentimetercubsecondcub_.Offset) * percentimetercubsecondcub_.Factor);
  public double GetValueInPerCentimeterCubSecondCubs() => (Value_ - percentimetercubsecondcub_.Offset) / percentimetercubsecondcub_.Factor;
  public static PerLengthCubTimeCub FromPerMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub((value + permillimetercubsecondcub_.Offset) * permillimetercubsecondcub_.Factor, minValue * permillimetercubsecondcub_.Factor, maxValue * permillimetercubsecondcub_.Factor);
  public static PerLengthCubTimeCub FromPerMillimeterCubSecondCubs(double value) => new PerLengthCubTimeCub((value + permillimetercubsecondcub_.Offset) * permillimetercubsecondcub_.Factor);
  public double GetValueInPerMillimeterCubSecondCubs() => (Value_ - permillimetercubsecondcub_.Offset) / permillimetercubsecondcub_.Factor;
  public static PerLengthCubTimeCub FromPerMeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub((value + permetercubsecondcub_.Offset) * permetercubsecondcub_.Factor, minValue * permetercubsecondcub_.Factor, maxValue * permetercubsecondcub_.Factor);
  public static PerLengthCubTimeCub FromPerMeterCubSecondCubs(double value) => new PerLengthCubTimeCub((value + permetercubsecondcub_.Offset) * permetercubsecondcub_.Factor);
  public double GetValueInPerMeterCubSecondCubs() => (Value_ - permetercubsecondcub_.Offset) / permetercubsecondcub_.Factor;
  public static PerLengthCubTimeCub FromPerInchCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub((value + perinchcubsecondcub_.Offset) * perinchcubsecondcub_.Factor, minValue * perinchcubsecondcub_.Factor, maxValue * perinchcubsecondcub_.Factor);
  public static PerLengthCubTimeCub FromPerInchCubSecondCubs(double value) => new PerLengthCubTimeCub((value + perinchcubsecondcub_.Offset) * perinchcubsecondcub_.Factor);
  public double GetValueInPerInchCubSecondCubs() => (Value_ - perinchcubsecondcub_.Offset) / perinchcubsecondcub_.Factor;

#endregion

#region arithmetic
  public static PerLengthCubTimeCub operator+(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ + o2.Value_);
  public static PerLengthCubTimeCub operator-(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(PerLengthCubTimeCub o1, MassPerTimeSqrLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassPerTimeSqrLengthCub o1, PerLengthCubTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(PerLengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(PerMassLengthSqrTimeCub o1, PerLengthCubTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(PerLengthCubTimeCub o1, MassPerLengthSqrTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassPerLengthSqrTimeCub o1, PerLengthCubTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(PerLengthCubTimeCub o1, TimeCubLengthSqrPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeCubLengthSqrPerMass o1, PerLengthCubTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(PerLengthCubTimeCub o1, TimeCubLengthSqrMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeCubLengthSqrMass o1, PerLengthCubTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(PerLengthCubTimeCub o1, LengthCubTimeSqrPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubTimeSqrPerMass o1, PerLengthCubTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthCubTimeCub o1, LengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(PerLengthCubTimeCub o1, LengthCubTimeSqrMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubTimeSqrMass o1, PerLengthCubTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static Mass operator/(PerLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerMassLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(PerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassPerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(PerLengthCubTimeCub o1, LengthCubTimeCubPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthCubTimeCubPerMass o1, PerLengthCubTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(PerLengthCubTimeCub o1, LengthCubTimeCubMass o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthCubTimeCubMass o1, PerLengthCubTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthCubTimeCub is outside its bounds.");
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
    