
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubTime : Quantity, IEquatable<LengthCubTime>, IComparable
  {  
    internal LengthCubTime(double value) : base(value, 2)
    {
      LengthCubTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubTime(LengthCubTime other) : base(other)
    {
      LengthCubTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTime"))
    {
      switch(FakeDatabase.Units["LengthCubTime"])
      {
        case "centimetercubsecond": displayUnit_ = centimetercubsecond_; break;
        case "millimetercubsecond": displayUnit_ = millimetercubsecond_; break;
        case "metercubsecond": displayUnit_ = metercubsecond_; break;
        case "inchcubsecond": displayUnit_ = inchcubsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubsecond_ = new Unit_("CentimeterCubSecond", "cm³ s", 1, 0);
  private static Unit_ millimetercubsecond_ = new Unit_("MillimeterCubSecond", "mm³ s", 0.0010000000000000002, 0);
  private static Unit_ metercubsecond_ = new Unit_("MeterCubSecond", "m³ s", 1000000, 0);
  private static Unit_ inchcubsecond_ = new Unit_("InchCubSecond", "in³ s", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubsecond_;
  private static Unit_ displayUnit_ = centimetercubsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubTime other && Equals(other);
  public bool Equals(LengthCubTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubTime other)) throw new ArgumentException("Object is not a LengthCubTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubTime l1, LengthCubTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubTime l1, LengthCubTime l2) => !(l1 == l2);
  public static bool operator <(LengthCubTime l1, LengthCubTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubTime l1, LengthCubTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubTime l1, LengthCubTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubTime l1, LengthCubTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubTime FromCentimeterCubSeconds(double value, double minValue, double maxValue) => new LengthCubTime((value + centimetercubsecond_.Offset) * centimetercubsecond_.Factor, minValue * centimetercubsecond_.Factor, maxValue * centimetercubsecond_.Factor);
  public static LengthCubTime FromCentimeterCubSeconds(double value) => new LengthCubTime((value + centimetercubsecond_.Offset) * centimetercubsecond_.Factor);
  public double GetValueInCentimeterCubSeconds() => (Value_ - centimetercubsecond_.Offset) / centimetercubsecond_.Factor;
  public static LengthCubTime FromMillimeterCubSeconds(double value, double minValue, double maxValue) => new LengthCubTime((value + millimetercubsecond_.Offset) * millimetercubsecond_.Factor, minValue * millimetercubsecond_.Factor, maxValue * millimetercubsecond_.Factor);
  public static LengthCubTime FromMillimeterCubSeconds(double value) => new LengthCubTime((value + millimetercubsecond_.Offset) * millimetercubsecond_.Factor);
  public double GetValueInMillimeterCubSeconds() => (Value_ - millimetercubsecond_.Offset) / millimetercubsecond_.Factor;
  public static LengthCubTime FromMeterCubSeconds(double value, double minValue, double maxValue) => new LengthCubTime((value + metercubsecond_.Offset) * metercubsecond_.Factor, minValue * metercubsecond_.Factor, maxValue * metercubsecond_.Factor);
  public static LengthCubTime FromMeterCubSeconds(double value) => new LengthCubTime((value + metercubsecond_.Offset) * metercubsecond_.Factor);
  public double GetValueInMeterCubSeconds() => (Value_ - metercubsecond_.Offset) / metercubsecond_.Factor;
  public static LengthCubTime FromInchCubSeconds(double value, double minValue, double maxValue) => new LengthCubTime((value + inchcubsecond_.Offset) * inchcubsecond_.Factor, minValue * inchcubsecond_.Factor, maxValue * inchcubsecond_.Factor);
  public static LengthCubTime FromInchCubSeconds(double value) => new LengthCubTime((value + inchcubsecond_.Offset) * inchcubsecond_.Factor);
  public double GetValueInInchCubSeconds() => (Value_ - inchcubsecond_.Offset) / inchcubsecond_.Factor;

#endregion

#region arithmetic
  public static LengthCubTime operator+(LengthCubTime o1, LengthCubTime o2) => new LengthCubTime(o1.Value_ + o2.Value_);
  public static LengthCubTime operator-(LengthCubTime o1, LengthCubTime o2) => new LengthCubTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubTime o1, LengthCubTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthCubTime o1, LengthCubMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubMass o1, LengthCubTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(LengthCubTime o1, PerMassTimeLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassTimeLengthCub o1, LengthCubTime o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthCubTime o1, TimePerMassLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimePerMassLengthCub o1, LengthCubTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthCubTime o1, PerTimeSqrLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerTimeSqrLengthCub o1, LengthCubTime o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthCubTime o1, TimeSqrPerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrPerLengthCub o1, LengthCubTime o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthCubTime o1, MassPerTimeLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerTimeLengthCub o1, LengthCubTime o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(LengthCubTime o1, MassTimePerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(MassTimePerLengthCub o1, LengthCubTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(LengthCubTime o1, PerMassLengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassLengthSqrTimeSqr o1, LengthCubTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(LengthCubTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeSqrPerMassLengthSqr o1, LengthCubTime o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(LengthCubTime o1, PerLengthSqrTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthSqrTimeCub o1, LengthCubTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(LengthCubTime o1, MassPerLengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerLengthSqrTimeSqr o1, LengthCubTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(LengthCubTime o1, TimeSqrMassPerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeSqrMassPerLengthSqr o1, LengthCubTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(LengthCubTime o1, PerLengthMassTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(PerLengthMassTimeCub o1, LengthCubTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(LengthCubTime o1, MassPerLengthTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(MassPerLengthTimeCub o1, LengthCubTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(LengthCubTime o1, TimeCubLengthPerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(LengthCubTime o1, TimeCubLengthMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeCubLengthMass o1, LengthCubTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator/(LengthCubTime o1, LengthSqrPerMassTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthCubTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator/(LengthCubTime o1, LengthSqrTimeSqrPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(LengthSqrTimeSqrPerMass o1, LengthCubTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(LengthCubTime o1, TimeCubLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubLengthSqr o1, LengthCubTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(LengthCubTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthCubTime o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(LengthCubTime o1, LengthSqrTimeSqrMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(LengthSqrTimeSqrMass o1, LengthCubTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(LengthCubTime o1, LengthCubPerMassTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthCubPerMassTime o1, LengthCubTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator/(LengthCubTime o1, LengthCubTimePerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthCubTimePerMass o1, LengthCubTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(LengthCubTime o1, LengthCubPerTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthCubPerTimeSqr o1, LengthCubTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthCubTime o1, LengthCubTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthCubTimeSqr o1, LengthCubTime o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthCubTime o1, LengthCubMassPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthCubMassPerTime o1, LengthCubTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthCubTime o1, LengthCubMassTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthCubMassTime o1, LengthCubTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(LengthCubTime o1, PerMassTimeSqrLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassTimeSqrLengthCub o1, LengthCubTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(LengthCubTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeSqrPerMassLengthCub o1, LengthCubTime o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthCubTime o1, PerLengthCubTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthCubTimeCub o1, LengthCubTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(LengthCubTime o1, MassPerTimeSqrLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerTimeSqrLengthCub o1, LengthCubTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(LengthCubTime o1, TimeSqrMassPerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeSqrMassPerLengthCub o1, LengthCubTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(LengthCubTime o1, PerMassLengthSqrTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerMassLengthSqrTimeCub o1, LengthCubTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Force operator*(LengthCubTime o1, MassPerLengthSqrTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerLengthSqrTimeCub o1, LengthCubTime o2) => new Force(o1.Value_ * o2.Value_);
  
  public static Force operator/(LengthCubTime o1, TimeCubLengthSqrPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubLengthSqrPerMass o1, LengthCubTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(LengthCubTime o1, TimeCubLengthSqrMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubLengthSqrMass o1, LengthCubTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator/(LengthCubTime o1, LengthCubPerMassTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthCubTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(LengthCubTime o1, LengthCubTimeSqrPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthCubTimeSqrPerMass o1, LengthCubTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthCubTime o1, LengthCubTimeCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthCubTimeCub o1, LengthCubTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(LengthCubTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthCubTime o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthCubTime o1, LengthCubTimeSqrMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthCubTimeSqrMass o1, LengthCubTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthCubTime o1, PerMassLengthCubTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthCubTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthCubTime o1, MassPerLengthCubTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthCubTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthCubTime o1, LengthCubTimeCubPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthCubTimeCubPerMass o1, LengthCubTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthCubTime o1, LengthCubTimeCubMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthCubTimeCubMass o1, LengthCubTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubTime is outside its bounds.");
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
    