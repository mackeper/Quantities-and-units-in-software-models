
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassLengthSqrTimeCub : Quantity, IEquatable<PerMassLengthSqrTimeCub>, IComparable
  {  
    internal PerMassLengthSqrTimeCub(double value) : base(value, 2)
    {
      PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassLengthSqrTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassLengthSqrTimeCub(PerMassLengthSqrTimeCub other) : base(other)
    {
      PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthSqrTimeCub"))
    {
      switch(FakeDatabase.Units["PerMassLengthSqrTimeCub"])
      {
        case "perkilogramcentimetersqrsecondcub": displayUnit_ = perkilogramcentimetersqrsecondcub_; break;
        case "perkilogrammillimetersqrsecondcub": displayUnit_ = perkilogrammillimetersqrsecondcub_; break;
        case "perkilogrammetersqrsecondcub": displayUnit_ = perkilogrammetersqrsecondcub_; break;
        case "perkilograminchsqrsecondcub": displayUnit_ = perkilograminchsqrsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramcentimetersqrsecondcub_ = new Unit_("PerKilogramCentimeterSqrSecondCub", "/kg cm² s³", 1.0, 0);
  private static Unit_ perkilogrammillimetersqrsecondcub_ = new Unit_("PerKilogramMillimeterSqrSecondCub", "/kg mm² s³", 99.99999999999999, 0);
  private static Unit_ perkilogrammetersqrsecondcub_ = new Unit_("PerKilogramMeterSqrSecondCub", "/kg m² s³", 0.0001, 0);
  private static Unit_ perkilograminchsqrsecondcub_ = new Unit_("PerKilogramInchSqrSecondCub", "/kg in² s³", 0.152587890625, 0);
  private static Unit_ platformUnit_ = perkilogramcentimetersqrsecondcub_;
  private static Unit_ displayUnit_ = perkilogramcentimetersqrsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassLengthSqrTimeCub other && Equals(other);
  public bool Equals(PerMassLengthSqrTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassLengthSqrTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassLengthSqrTimeCub other)) throw new ArgumentException("Object is not a PerMassLengthSqrTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => !(l1 == l2);
  public static bool operator <(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassLengthSqrTimeCub FromPerKilogramCentimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub((value + perkilogramcentimetersqrsecondcub_.Offset) * perkilogramcentimetersqrsecondcub_.Factor, minValue * perkilogramcentimetersqrsecondcub_.Factor, maxValue * perkilogramcentimetersqrsecondcub_.Factor);
  public static PerMassLengthSqrTimeCub FromPerKilogramCentimeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub((value + perkilogramcentimetersqrsecondcub_.Offset) * perkilogramcentimetersqrsecondcub_.Factor);
  public double GetValueInPerKilogramCentimeterSqrSecondCubs() => (Value_ - perkilogramcentimetersqrsecondcub_.Offset) / perkilogramcentimetersqrsecondcub_.Factor;
  public static PerMassLengthSqrTimeCub FromPerKilogramMillimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub((value + perkilogrammillimetersqrsecondcub_.Offset) * perkilogrammillimetersqrsecondcub_.Factor, minValue * perkilogrammillimetersqrsecondcub_.Factor, maxValue * perkilogrammillimetersqrsecondcub_.Factor);
  public static PerMassLengthSqrTimeCub FromPerKilogramMillimeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub((value + perkilogrammillimetersqrsecondcub_.Offset) * perkilogrammillimetersqrsecondcub_.Factor);
  public double GetValueInPerKilogramMillimeterSqrSecondCubs() => (Value_ - perkilogrammillimetersqrsecondcub_.Offset) / perkilogrammillimetersqrsecondcub_.Factor;
  public static PerMassLengthSqrTimeCub FromPerKilogramMeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub((value + perkilogrammetersqrsecondcub_.Offset) * perkilogrammetersqrsecondcub_.Factor, minValue * perkilogrammetersqrsecondcub_.Factor, maxValue * perkilogrammetersqrsecondcub_.Factor);
  public static PerMassLengthSqrTimeCub FromPerKilogramMeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub((value + perkilogrammetersqrsecondcub_.Offset) * perkilogrammetersqrsecondcub_.Factor);
  public double GetValueInPerKilogramMeterSqrSecondCubs() => (Value_ - perkilogrammetersqrsecondcub_.Offset) / perkilogrammetersqrsecondcub_.Factor;
  public static PerMassLengthSqrTimeCub FromPerKilogramInchSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub((value + perkilograminchsqrsecondcub_.Offset) * perkilograminchsqrsecondcub_.Factor, minValue * perkilograminchsqrsecondcub_.Factor, maxValue * perkilograminchsqrsecondcub_.Factor);
  public static PerMassLengthSqrTimeCub FromPerKilogramInchSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub((value + perkilograminchsqrsecondcub_.Offset) * perkilograminchsqrsecondcub_.Factor);
  public double GetValueInPerKilogramInchSqrSecondCubs() => (Value_ - perkilograminchsqrsecondcub_.Offset) / perkilograminchsqrsecondcub_.Factor;

#endregion

#region arithmetic
  public static PerMassLengthSqrTimeCub operator+(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ + o2.Value_);
  public static PerMassLengthSqrTimeCub operator-(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerMassLengthSqrTimeCub o1, TimeCubLengthSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeCubLengthSqrMass o1, PerMassLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeSqrMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubTimeSqrMass o1, PerMassLengthSqrTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Length operator/(PerMassLengthSqrTimeCub o1, PerMassLengthCubTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerMassLengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Length operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeCubMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimeCubMass o1, PerMassLengthSqrTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassLengthSqrTimeCub is outside its bounds.");
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
    