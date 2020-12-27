
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthPerMassTimeCub : Quantity, IEquatable<LengthPerMassTimeCub>, IComparable
  {  
    internal LengthPerMassTimeCub(double value) : base(value, 2)
    {
      LengthPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthPerMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthPerMassTimeCub(LengthPerMassTimeCub other) : base(other)
    {
      LengthPerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthPerMassTimeCub"))
    {
      switch(FakeDatabase.Units["LengthPerMassTimeCub"])
      {
        case "centimeterperkilogramsecondcub": displayUnit_ = centimeterperkilogramsecondcub_; break;
        case "millimeterperkilogramsecondcub": displayUnit_ = millimeterperkilogramsecondcub_; break;
        case "meterperkilogramsecondcub": displayUnit_ = meterperkilogramsecondcub_; break;
        case "inchperkilogramsecondcub": displayUnit_ = inchperkilogramsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterperkilogramsecondcub_ = new Unit_("CentimeterPerKilogramSecondCub", "cm/kg s�", 1.0, 0);
  private static Unit_ millimeterperkilogramsecondcub_ = new Unit_("MillimeterPerKilogramSecondCub", "mm/kg s�", 0.1, 0);
  private static Unit_ meterperkilogramsecondcub_ = new Unit_("MeterPerKilogramSecondCub", "m/kg s�", 100.0, 0);
  private static Unit_ inchperkilogramsecondcub_ = new Unit_("InchPerKilogramSecondCub", "in/kg s�", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterperkilogramsecondcub_;
  private static Unit_ displayUnit_ = centimeterperkilogramsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthPerMassTimeCub other && Equals(other);
  public bool Equals(LengthPerMassTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthPerMassTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthPerMassTimeCub other)) throw new ArgumentException("Object is not a LengthPerMassTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthPerMassTimeCub l1, LengthPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthPerMassTimeCub FromCentimeterPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthPerMassTimeCub((value + centimeterperkilogramsecondcub_.Offset) * centimeterperkilogramsecondcub_.Factor, minValue * centimeterperkilogramsecondcub_.Factor, maxValue * centimeterperkilogramsecondcub_.Factor);
  public static LengthPerMassTimeCub FromCentimeterPerKilogramSecondCubs(double value) => new LengthPerMassTimeCub((value + centimeterperkilogramsecondcub_.Offset) * centimeterperkilogramsecondcub_.Factor);
  public double GetValueInCentimeterPerKilogramSecondCubs() => (Value_ - centimeterperkilogramsecondcub_.Offset) / centimeterperkilogramsecondcub_.Factor;
  public static LengthPerMassTimeCub FromMillimeterPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthPerMassTimeCub((value + millimeterperkilogramsecondcub_.Offset) * millimeterperkilogramsecondcub_.Factor, minValue * millimeterperkilogramsecondcub_.Factor, maxValue * millimeterperkilogramsecondcub_.Factor);
  public static LengthPerMassTimeCub FromMillimeterPerKilogramSecondCubs(double value) => new LengthPerMassTimeCub((value + millimeterperkilogramsecondcub_.Offset) * millimeterperkilogramsecondcub_.Factor);
  public double GetValueInMillimeterPerKilogramSecondCubs() => (Value_ - millimeterperkilogramsecondcub_.Offset) / millimeterperkilogramsecondcub_.Factor;
  public static LengthPerMassTimeCub FromMeterPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthPerMassTimeCub((value + meterperkilogramsecondcub_.Offset) * meterperkilogramsecondcub_.Factor, minValue * meterperkilogramsecondcub_.Factor, maxValue * meterperkilogramsecondcub_.Factor);
  public static LengthPerMassTimeCub FromMeterPerKilogramSecondCubs(double value) => new LengthPerMassTimeCub((value + meterperkilogramsecondcub_.Offset) * meterperkilogramsecondcub_.Factor);
  public double GetValueInMeterPerKilogramSecondCubs() => (Value_ - meterperkilogramsecondcub_.Offset) / meterperkilogramsecondcub_.Factor;
  public static LengthPerMassTimeCub FromInchPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthPerMassTimeCub((value + inchperkilogramsecondcub_.Offset) * inchperkilogramsecondcub_.Factor, minValue * inchperkilogramsecondcub_.Factor, maxValue * inchperkilogramsecondcub_.Factor);
  public static LengthPerMassTimeCub FromInchPerKilogramSecondCubs(double value) => new LengthPerMassTimeCub((value + inchperkilogramsecondcub_.Offset) * inchperkilogramsecondcub_.Factor);
  public double GetValueInInchPerKilogramSecondCubs() => (Value_ - inchperkilogramsecondcub_.Offset) / inchperkilogramsecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthPerMassTimeCub operator+(LengthPerMassTimeCub o1, LengthPerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ + o2.Value_);
  public static LengthPerMassTimeCub operator-(LengthPerMassTimeCub o1, LengthPerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthPerMassTimeCub o1, LengthPerMassTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Area operator*(LengthPerMassTimeCub o1, TimeCubLengthMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(TimeCubLengthMass o1, LengthPerMassTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthPerMassTimeCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrPerMassTimeSqr o1, LengthPerMassTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthPerMassTimeCub o1, LengthSqrPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrPerTimeCub o1, LengthPerMassTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthPerMassTimeCub o1, TimeCubLengthSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(TimeCubLengthSqr o1, LengthPerMassTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator*(LengthPerMassTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrTimeSqrMass o1, LengthPerMassTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthPerMassTimeCub o1, LengthCubPerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubPerMassTime o1, LengthPerMassTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthPerMassTimeCub o1, LengthCubPerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubPerTimeSqr o1, LengthPerMassTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthPerMassTimeCub o1, TimeCubPerLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeCubPerLengthCub o1, LengthPerMassTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthPerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthPerMassTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthPerMassTimeCub o1, PerMassLengthSqrTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassLengthSqrTimeCub o1, LengthPerMassTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthPerMassTimeCub o1, TimeCubMassPerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubMassPerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthPerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrPerMassTimeCub o1, LengthPerMassTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthPerMassTimeCub o1, TimeCubLengthSqrMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(TimeCubLengthSqrMass o1, LengthPerMassTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthPerMassTimeCub o1, LengthCubPerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubPerMassTimeSqr o1, LengthPerMassTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthPerMassTimeCub o1, LengthCubPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubPerTimeCub o1, LengthPerMassTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(LengthPerMassTimeCub o1, TimeCubMassPerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeCubMassPerLengthCub o1, LengthPerMassTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(LengthPerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerMassTimeCub o1, LengthPerMassTimeCub o2) => new Area(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthPerMassTimeCub is outside its bounds.");
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
    