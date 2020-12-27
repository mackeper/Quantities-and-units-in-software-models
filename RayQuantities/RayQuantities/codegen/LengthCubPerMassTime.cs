
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubPerMassTime : Quantity, IEquatable<LengthCubPerMassTime>, IComparable
  {  
    internal LengthCubPerMassTime(double value) : base(value, 2)
    {
      LengthCubPerMassTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubPerMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubPerMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubPerMassTime(LengthCubPerMassTime other) : base(other)
    {
      LengthCubPerMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerMassTime"))
    {
      switch(FakeDatabase.Units["LengthCubPerMassTime"])
      {
        case "centimetercubperkilogramsecond": displayUnit_ = centimetercubperkilogramsecond_; break;
        case "millimetercubperkilogramsecond": displayUnit_ = millimetercubperkilogramsecond_; break;
        case "metercubperkilogramsecond": displayUnit_ = metercubperkilogramsecond_; break;
        case "inchcubperkilogramsecond": displayUnit_ = inchcubperkilogramsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubperkilogramsecond_ = new Unit_("CentimeterCubPerKilogramSecond", "cm³/kg s", 1.0, 0);
  private static Unit_ millimetercubperkilogramsecond_ = new Unit_("MillimeterCubPerKilogramSecond", "mm³/kg s", 0.0010000000000000002, 0);
  private static Unit_ metercubperkilogramsecond_ = new Unit_("MeterCubPerKilogramSecond", "m³/kg s", 1000000.0, 0);
  private static Unit_ inchcubperkilogramsecond_ = new Unit_("InchCubPerKilogramSecond", "in³/kg s", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubperkilogramsecond_;
  private static Unit_ displayUnit_ = centimetercubperkilogramsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubPerMassTime other && Equals(other);
  public bool Equals(LengthCubPerMassTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubPerMassTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubPerMassTime other)) throw new ArgumentException("Object is not a LengthCubPerMassTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => !(l1 == l2);
  public static bool operator <(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubPerMassTime l1, LengthCubPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubPerMassTime FromCentimeterCubPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubPerMassTime((value + centimetercubperkilogramsecond_.Offset) * centimetercubperkilogramsecond_.Factor, minValue * centimetercubperkilogramsecond_.Factor, maxValue * centimetercubperkilogramsecond_.Factor);
  public static LengthCubPerMassTime FromCentimeterCubPerKilogramSeconds(double value) => new LengthCubPerMassTime((value + centimetercubperkilogramsecond_.Offset) * centimetercubperkilogramsecond_.Factor);
  public double GetValueInCentimeterCubPerKilogramSeconds() => (Value_ - centimetercubperkilogramsecond_.Offset) / centimetercubperkilogramsecond_.Factor;
  public static LengthCubPerMassTime FromMillimeterCubPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubPerMassTime((value + millimetercubperkilogramsecond_.Offset) * millimetercubperkilogramsecond_.Factor, minValue * millimetercubperkilogramsecond_.Factor, maxValue * millimetercubperkilogramsecond_.Factor);
  public static LengthCubPerMassTime FromMillimeterCubPerKilogramSeconds(double value) => new LengthCubPerMassTime((value + millimetercubperkilogramsecond_.Offset) * millimetercubperkilogramsecond_.Factor);
  public double GetValueInMillimeterCubPerKilogramSeconds() => (Value_ - millimetercubperkilogramsecond_.Offset) / millimetercubperkilogramsecond_.Factor;
  public static LengthCubPerMassTime FromMeterCubPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubPerMassTime((value + metercubperkilogramsecond_.Offset) * metercubperkilogramsecond_.Factor, minValue * metercubperkilogramsecond_.Factor, maxValue * metercubperkilogramsecond_.Factor);
  public static LengthCubPerMassTime FromMeterCubPerKilogramSeconds(double value) => new LengthCubPerMassTime((value + metercubperkilogramsecond_.Offset) * metercubperkilogramsecond_.Factor);
  public double GetValueInMeterCubPerKilogramSeconds() => (Value_ - metercubperkilogramsecond_.Offset) / metercubperkilogramsecond_.Factor;
  public static LengthCubPerMassTime FromInchCubPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubPerMassTime((value + inchcubperkilogramsecond_.Offset) * inchcubperkilogramsecond_.Factor, minValue * inchcubperkilogramsecond_.Factor, maxValue * inchcubperkilogramsecond_.Factor);
  public static LengthCubPerMassTime FromInchCubPerKilogramSeconds(double value) => new LengthCubPerMassTime((value + inchcubperkilogramsecond_.Offset) * inchcubperkilogramsecond_.Factor);
  public double GetValueInInchCubPerKilogramSeconds() => (Value_ - inchcubperkilogramsecond_.Offset) / inchcubperkilogramsecond_.Factor;

#endregion

#region arithmetic
  public static LengthCubPerMassTime operator+(LengthCubPerMassTime o1, LengthCubPerMassTime o2) => new LengthCubPerMassTime(o1.Value_ + o2.Value_);
  public static LengthCubPerMassTime operator-(LengthCubPerMassTime o1, LengthCubPerMassTime o2) => new LengthCubPerMassTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubPerMassTime o1, LengthCubPerMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthCubPerMassTime o1, LengthCubTimePerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthCubTimePerMass o1, LengthCubPerMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthCubPerMassTime o1, LengthCubPerTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubPerTimeSqr o1, LengthCubPerMassTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(LengthCubPerMassTime o1, LengthCubTimeSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(LengthCubTimeSqr o1, LengthCubPerMassTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthCubPerMassTime o1, TimeCubPerLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubPerLengthCub o1, LengthCubPerMassTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthCubPerMassTime o1, MassPerTimeSqrLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(MassPerTimeSqrLengthCub o1, LengthCubPerMassTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthCubPerMassTime o1, TimeSqrMassPerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMassTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthCubPerMassTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubMassPerLengthSqr o1, LengthCubPerMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(LengthCubPerMassTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(LengthSqrPerMassTimeCub o1, LengthCubPerMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Time operator/(LengthCubPerMassTime o1, LengthCubPerMassTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthCubPerMassTimeSqr o1, LengthCubPerMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthCubPerMassTime o1, LengthCubTimeSqrPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(LengthCubTimeSqrPerMass o1, LengthCubPerMassTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthCubPerMassTime o1, LengthCubPerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthCubPerTimeCub o1, LengthCubPerMassTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(LengthCubPerMassTime o1, TimeCubMassPerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubMassPerLengthCub o1, LengthCubPerMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(LengthCubPerMassTime o1, LengthCubPerMassTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthCubPerMassTimeCub o1, LengthCubPerMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubPerMassTime is outside its bounds.");
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
    