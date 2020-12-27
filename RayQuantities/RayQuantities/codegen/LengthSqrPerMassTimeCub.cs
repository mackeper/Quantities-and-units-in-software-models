
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrPerMassTimeCub : Quantity, IEquatable<LengthSqrPerMassTimeCub>, IComparable
  {  
    internal LengthSqrPerMassTimeCub(double value) : base(value, 2)
    {
      LengthSqrPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrPerMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrPerMassTimeCub(LengthSqrPerMassTimeCub other) : base(other)
    {
      LengthSqrPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerMassTimeCub"))
    {
      switch(FakeDatabase.Units["LengthSqrPerMassTimeCub"])
      {
        case "centimetersqrperkilogramsecondcub": displayUnit_ = centimetersqrperkilogramsecondcub_; break;
        case "millimetersqrperkilogramsecondcub": displayUnit_ = millimetersqrperkilogramsecondcub_; break;
        case "metersqrperkilogramsecondcub": displayUnit_ = metersqrperkilogramsecondcub_; break;
        case "inchsqrperkilogramsecondcub": displayUnit_ = inchsqrperkilogramsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrperkilogramsecondcub_ = new Unit_("CentimeterSqrPerKilogramSecondCub", "cm²/kg s³", 1.0, 0);
  private static Unit_ millimetersqrperkilogramsecondcub_ = new Unit_("MillimeterSqrPerKilogramSecondCub", "mm²/kg s³", 0.010000000000000002, 0);
  private static Unit_ metersqrperkilogramsecondcub_ = new Unit_("MeterSqrPerKilogramSecondCub", "m²/kg s³", 10000.0, 0);
  private static Unit_ inchsqrperkilogramsecondcub_ = new Unit_("InchSqrPerKilogramSecondCub", "in²/kg s³", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrperkilogramsecondcub_;
  private static Unit_ displayUnit_ = centimetersqrperkilogramsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrPerMassTimeCub other && Equals(other);
  public bool Equals(LengthSqrPerMassTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrPerMassTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrPerMassTimeCub other)) throw new ArgumentException("Object is not a LengthSqrPerMassTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrPerMassTimeCub l1, LengthSqrPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrPerMassTimeCub FromCentimeterSqrPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeCub((value + centimetersqrperkilogramsecondcub_.Offset) * centimetersqrperkilogramsecondcub_.Factor, minValue * centimetersqrperkilogramsecondcub_.Factor, maxValue * centimetersqrperkilogramsecondcub_.Factor);
  public static LengthSqrPerMassTimeCub FromCentimeterSqrPerKilogramSecondCubs(double value) => new LengthSqrPerMassTimeCub((value + centimetersqrperkilogramsecondcub_.Offset) * centimetersqrperkilogramsecondcub_.Factor);
  public double GetValueInCentimeterSqrPerKilogramSecondCubs() => (Value_ - centimetersqrperkilogramsecondcub_.Offset) / centimetersqrperkilogramsecondcub_.Factor;
  public static LengthSqrPerMassTimeCub FromMillimeterSqrPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeCub((value + millimetersqrperkilogramsecondcub_.Offset) * millimetersqrperkilogramsecondcub_.Factor, minValue * millimetersqrperkilogramsecondcub_.Factor, maxValue * millimetersqrperkilogramsecondcub_.Factor);
  public static LengthSqrPerMassTimeCub FromMillimeterSqrPerKilogramSecondCubs(double value) => new LengthSqrPerMassTimeCub((value + millimetersqrperkilogramsecondcub_.Offset) * millimetersqrperkilogramsecondcub_.Factor);
  public double GetValueInMillimeterSqrPerKilogramSecondCubs() => (Value_ - millimetersqrperkilogramsecondcub_.Offset) / millimetersqrperkilogramsecondcub_.Factor;
  public static LengthSqrPerMassTimeCub FromMeterSqrPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeCub((value + metersqrperkilogramsecondcub_.Offset) * metersqrperkilogramsecondcub_.Factor, minValue * metersqrperkilogramsecondcub_.Factor, maxValue * metersqrperkilogramsecondcub_.Factor);
  public static LengthSqrPerMassTimeCub FromMeterSqrPerKilogramSecondCubs(double value) => new LengthSqrPerMassTimeCub((value + metersqrperkilogramsecondcub_.Offset) * metersqrperkilogramsecondcub_.Factor);
  public double GetValueInMeterSqrPerKilogramSecondCubs() => (Value_ - metersqrperkilogramsecondcub_.Offset) / metersqrperkilogramsecondcub_.Factor;
  public static LengthSqrPerMassTimeCub FromInchSqrPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeCub((value + inchsqrperkilogramsecondcub_.Offset) * inchsqrperkilogramsecondcub_.Factor, minValue * inchsqrperkilogramsecondcub_.Factor, maxValue * inchsqrperkilogramsecondcub_.Factor);
  public static LengthSqrPerMassTimeCub FromInchSqrPerKilogramSecondCubs(double value) => new LengthSqrPerMassTimeCub((value + inchsqrperkilogramsecondcub_.Offset) * inchsqrperkilogramsecondcub_.Factor);
  public double GetValueInInchSqrPerKilogramSecondCubs() => (Value_ - inchsqrperkilogramsecondcub_.Offset) / inchsqrperkilogramsecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthSqrPerMassTimeCub operator+(LengthSqrPerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ + o2.Value_);
  public static LengthSqrPerMassTimeCub operator-(LengthSqrPerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrPerMassTimeCub o1, LengthCubPerMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrPerMassTimeCub o1, LengthCubPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubPerTimeCub o1, LengthSqrPerMassTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrPerMassTimeCub o1, TimeCubMassPerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthSqrPerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubPerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrPerMassTimeCub is outside its bounds.");
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
    