
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrMassPerTimeCub : Quantity, IEquatable<LengthSqrMassPerTimeCub>, IComparable
  {  
    internal LengthSqrMassPerTimeCub(double value) : base(value, 2)
    {
      LengthSqrMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrMassPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrMassPerTimeCub(LengthSqrMassPerTimeCub other) : base(other)
    {
      LengthSqrMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrMassPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthSqrMassPerTimeCub"])
      {
        case "centimetersqrkilogrampersecondcub": displayUnit_ = centimetersqrkilogrampersecondcub_; break;
        case "millimetersqrkilogrampersecondcub": displayUnit_ = millimetersqrkilogrampersecondcub_; break;
        case "metersqrkilogrampersecondcub": displayUnit_ = metersqrkilogrampersecondcub_; break;
        case "inchsqrkilogrampersecondcub": displayUnit_ = inchsqrkilogrampersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrkilogrampersecondcub_ = new Unit_("CentimeterSqrKilogramPerSecondCub", "cm² kg/s³", 1.0, 0);
  private static Unit_ millimetersqrkilogrampersecondcub_ = new Unit_("MillimeterSqrKilogramPerSecondCub", "mm² kg/s³", 0.010000000000000002, 0);
  private static Unit_ metersqrkilogrampersecondcub_ = new Unit_("MeterSqrKilogramPerSecondCub", "m² kg/s³", 10000.0, 0);
  private static Unit_ inchsqrkilogrampersecondcub_ = new Unit_("InchSqrKilogramPerSecondCub", "in² kg/s³", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrkilogrampersecondcub_;
  private static Unit_ displayUnit_ = centimetersqrkilogrampersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrMassPerTimeCub other && Equals(other);
  public bool Equals(LengthSqrMassPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrMassPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrMassPerTimeCub other)) throw new ArgumentException("Object is not a LengthSqrMassPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrMassPerTimeCub l1, LengthSqrMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrMassPerTimeCub FromCentimeterSqrKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeCub((value + centimetersqrkilogrampersecondcub_.Offset) * centimetersqrkilogrampersecondcub_.Factor, minValue * centimetersqrkilogrampersecondcub_.Factor, maxValue * centimetersqrkilogrampersecondcub_.Factor);
  public static LengthSqrMassPerTimeCub FromCentimeterSqrKilogramPerSecondCubs(double value) => new LengthSqrMassPerTimeCub((value + centimetersqrkilogrampersecondcub_.Offset) * centimetersqrkilogrampersecondcub_.Factor);
  public double GetValueInCentimeterSqrKilogramPerSecondCubs() => (Value_ - centimetersqrkilogrampersecondcub_.Offset) / centimetersqrkilogrampersecondcub_.Factor;
  public static LengthSqrMassPerTimeCub FromMillimeterSqrKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeCub((value + millimetersqrkilogrampersecondcub_.Offset) * millimetersqrkilogrampersecondcub_.Factor, minValue * millimetersqrkilogrampersecondcub_.Factor, maxValue * millimetersqrkilogrampersecondcub_.Factor);
  public static LengthSqrMassPerTimeCub FromMillimeterSqrKilogramPerSecondCubs(double value) => new LengthSqrMassPerTimeCub((value + millimetersqrkilogrampersecondcub_.Offset) * millimetersqrkilogrampersecondcub_.Factor);
  public double GetValueInMillimeterSqrKilogramPerSecondCubs() => (Value_ - millimetersqrkilogrampersecondcub_.Offset) / millimetersqrkilogrampersecondcub_.Factor;
  public static LengthSqrMassPerTimeCub FromMeterSqrKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeCub((value + metersqrkilogrampersecondcub_.Offset) * metersqrkilogrampersecondcub_.Factor, minValue * metersqrkilogrampersecondcub_.Factor, maxValue * metersqrkilogrampersecondcub_.Factor);
  public static LengthSqrMassPerTimeCub FromMeterSqrKilogramPerSecondCubs(double value) => new LengthSqrMassPerTimeCub((value + metersqrkilogrampersecondcub_.Offset) * metersqrkilogrampersecondcub_.Factor);
  public double GetValueInMeterSqrKilogramPerSecondCubs() => (Value_ - metersqrkilogrampersecondcub_.Offset) / metersqrkilogrampersecondcub_.Factor;
  public static LengthSqrMassPerTimeCub FromInchSqrKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeCub((value + inchsqrkilogrampersecondcub_.Offset) * inchsqrkilogrampersecondcub_.Factor, minValue * inchsqrkilogrampersecondcub_.Factor, maxValue * inchsqrkilogrampersecondcub_.Factor);
  public static LengthSqrMassPerTimeCub FromInchSqrKilogramPerSecondCubs(double value) => new LengthSqrMassPerTimeCub((value + inchsqrkilogrampersecondcub_.Offset) * inchsqrkilogrampersecondcub_.Factor);
  public double GetValueInInchSqrKilogramPerSecondCubs() => (Value_ - inchsqrkilogrampersecondcub_.Offset) / inchsqrkilogrampersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthSqrMassPerTimeCub operator+(LengthSqrMassPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthSqrMassPerTimeCub operator-(LengthSqrMassPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrMassPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrMassPerTimeCub o1, LengthCubPerTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrMassPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubMassPerTimeSqr o1, LengthSqrMassPerTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrMassPerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubPerMassLengthCub o1, LengthSqrMassPerTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthSqrMassPerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubMassPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrMassPerTimeCub is outside its bounds.");
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
    