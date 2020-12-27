
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthMassPerTimeCub : Quantity, IEquatable<LengthMassPerTimeCub>, IComparable
  {  
    internal LengthMassPerTimeCub(double value) : base(value, 2)
    {
      LengthMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthMassPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthMassPerTimeCub(LengthMassPerTimeCub other) : base(other)
    {
      LengthMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthMassPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthMassPerTimeCub"])
      {
        case "centimeterkilogrampersecondcub": displayUnit_ = centimeterkilogrampersecondcub_; break;
        case "millimeterkilogrampersecondcub": displayUnit_ = millimeterkilogrampersecondcub_; break;
        case "meterkilogrampersecondcub": displayUnit_ = meterkilogrampersecondcub_; break;
        case "inchkilogrampersecondcub": displayUnit_ = inchkilogrampersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterkilogrampersecondcub_ = new Unit_("CentimeterKilogramPerSecondCub", "cm kg/s�", 1.0, 0);
  private static Unit_ millimeterkilogrampersecondcub_ = new Unit_("MillimeterKilogramPerSecondCub", "mm kg/s�", 0.1, 0);
  private static Unit_ meterkilogrampersecondcub_ = new Unit_("MeterKilogramPerSecondCub", "m kg/s�", 100.0, 0);
  private static Unit_ inchkilogrampersecondcub_ = new Unit_("InchKilogramPerSecondCub", "in kg/s�", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterkilogrampersecondcub_;
  private static Unit_ displayUnit_ = centimeterkilogrampersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthMassPerTimeCub other && Equals(other);
  public bool Equals(LengthMassPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthMassPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthMassPerTimeCub other)) throw new ArgumentException("Object is not a LengthMassPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthMassPerTimeCub l1, LengthMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthMassPerTimeCub FromCentimeterKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthMassPerTimeCub((value + centimeterkilogrampersecondcub_.Offset) * centimeterkilogrampersecondcub_.Factor, minValue * centimeterkilogrampersecondcub_.Factor, maxValue * centimeterkilogrampersecondcub_.Factor);
  public static LengthMassPerTimeCub FromCentimeterKilogramPerSecondCubs(double value) => new LengthMassPerTimeCub((value + centimeterkilogrampersecondcub_.Offset) * centimeterkilogrampersecondcub_.Factor);
  public double GetValueInCentimeterKilogramPerSecondCubs() => (Value_ - centimeterkilogrampersecondcub_.Offset) / centimeterkilogrampersecondcub_.Factor;
  public static LengthMassPerTimeCub FromMillimeterKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthMassPerTimeCub((value + millimeterkilogrampersecondcub_.Offset) * millimeterkilogrampersecondcub_.Factor, minValue * millimeterkilogrampersecondcub_.Factor, maxValue * millimeterkilogrampersecondcub_.Factor);
  public static LengthMassPerTimeCub FromMillimeterKilogramPerSecondCubs(double value) => new LengthMassPerTimeCub((value + millimeterkilogrampersecondcub_.Offset) * millimeterkilogrampersecondcub_.Factor);
  public double GetValueInMillimeterKilogramPerSecondCubs() => (Value_ - millimeterkilogrampersecondcub_.Offset) / millimeterkilogrampersecondcub_.Factor;
  public static LengthMassPerTimeCub FromMeterKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthMassPerTimeCub((value + meterkilogrampersecondcub_.Offset) * meterkilogrampersecondcub_.Factor, minValue * meterkilogrampersecondcub_.Factor, maxValue * meterkilogrampersecondcub_.Factor);
  public static LengthMassPerTimeCub FromMeterKilogramPerSecondCubs(double value) => new LengthMassPerTimeCub((value + meterkilogrampersecondcub_.Offset) * meterkilogrampersecondcub_.Factor);
  public double GetValueInMeterKilogramPerSecondCubs() => (Value_ - meterkilogrampersecondcub_.Offset) / meterkilogrampersecondcub_.Factor;
  public static LengthMassPerTimeCub FromInchKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthMassPerTimeCub((value + inchkilogrampersecondcub_.Offset) * inchkilogrampersecondcub_.Factor, minValue * inchkilogrampersecondcub_.Factor, maxValue * inchkilogrampersecondcub_.Factor);
  public static LengthMassPerTimeCub FromInchKilogramPerSecondCubs(double value) => new LengthMassPerTimeCub((value + inchkilogrampersecondcub_.Offset) * inchkilogrampersecondcub_.Factor);
  public double GetValueInInchKilogramPerSecondCubs() => (Value_ - inchkilogrampersecondcub_.Offset) / inchkilogrampersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthMassPerTimeCub operator+(LengthMassPerTimeCub o1, LengthMassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthMassPerTimeCub operator-(LengthMassPerTimeCub o1, LengthMassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthMassPerTimeCub o1, LengthMassPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthMassPerTimeCub o1, LengthSqrTimeSqrPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrTimeSqrPerMass o1, LengthMassPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(LengthMassPerTimeCub o1, LengthSqrPerTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrPerTimeCub o1, LengthMassPerTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(LengthMassPerTimeCub o1, TimeCubLengthSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(TimeCubLengthSqr o1, LengthMassPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthMassPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrMassPerTimeSqr o1, LengthMassPerTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(LengthMassPerTimeCub o1, LengthCubPerTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubPerTimeSqr o1, LengthMassPerTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthMassPerTimeCub o1, LengthCubMassPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubMassPerTime o1, LengthMassPerTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthMassPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthMassPerTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(LengthMassPerTimeCub o1, TimeCubPerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(TimeCubPerLengthCub o1, LengthMassPerTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthMassPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubPerMassLengthSqr o1, LengthMassPerTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthMassPerTimeCub o1, MassPerLengthSqrTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(MassPerLengthSqrTimeCub o1, LengthMassPerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthMassPerTimeCub o1, TimeCubLengthSqrPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(TimeCubLengthSqrPerMass o1, LengthMassPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthMassPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrMassPerTimeCub o1, LengthMassPerTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(LengthMassPerTimeCub o1, LengthCubPerTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubPerTimeCub o1, LengthMassPerTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthMassPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubMassPerTimeSqr o1, LengthMassPerTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(LengthMassPerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeCubPerMassLengthCub o1, LengthMassPerTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(LengthMassPerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubMassPerTimeCub o1, LengthMassPerTimeCub o2) => new Area(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthMassPerTimeCub is outside its bounds.");
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
    