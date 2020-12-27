
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubPerTime : Quantity, IEquatable<LengthCubPerTime>, IComparable
  {  
    internal LengthCubPerTime(double value) : base(value, 2)
    {
      LengthCubPerTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubPerTime(LengthCubPerTime other) : base(other)
    {
      LengthCubPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerTime"))
    {
      switch(FakeDatabase.Units["LengthCubPerTime"])
      {
        case "centimetercubpersecond": displayUnit_ = centimetercubpersecond_; break;
        case "millimetercubpersecond": displayUnit_ = millimetercubpersecond_; break;
        case "metercubpersecond": displayUnit_ = metercubpersecond_; break;
        case "inchcubpersecond": displayUnit_ = inchcubpersecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubpersecond_ = new Unit_("CentimeterCubPerSecond", "cm³/s", 1.0, 0);
  private static Unit_ millimetercubpersecond_ = new Unit_("MillimeterCubPerSecond", "mm³/s", 0.0010000000000000002, 0);
  private static Unit_ metercubpersecond_ = new Unit_("MeterCubPerSecond", "m³/s", 1000000.0, 0);
  private static Unit_ inchcubpersecond_ = new Unit_("InchCubPerSecond", "in³/s", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubpersecond_;
  private static Unit_ displayUnit_ = centimetercubpersecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubPerTime other && Equals(other);
  public bool Equals(LengthCubPerTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubPerTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubPerTime other)) throw new ArgumentException("Object is not a LengthCubPerTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubPerTime l1, LengthCubPerTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubPerTime l1, LengthCubPerTime l2) => !(l1 == l2);
  public static bool operator <(LengthCubPerTime l1, LengthCubPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubPerTime l1, LengthCubPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubPerTime l1, LengthCubPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubPerTime l1, LengthCubPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubPerTime FromCentimeterCubPerSeconds(double value, double minValue, double maxValue) => new LengthCubPerTime((value + centimetercubpersecond_.Offset) * centimetercubpersecond_.Factor, minValue * centimetercubpersecond_.Factor, maxValue * centimetercubpersecond_.Factor);
  public static LengthCubPerTime FromCentimeterCubPerSeconds(double value) => new LengthCubPerTime((value + centimetercubpersecond_.Offset) * centimetercubpersecond_.Factor);
  public double GetValueInCentimeterCubPerSeconds() => (Value_ - centimetercubpersecond_.Offset) / centimetercubpersecond_.Factor;
  public static LengthCubPerTime FromMillimeterCubPerSeconds(double value, double minValue, double maxValue) => new LengthCubPerTime((value + millimetercubpersecond_.Offset) * millimetercubpersecond_.Factor, minValue * millimetercubpersecond_.Factor, maxValue * millimetercubpersecond_.Factor);
  public static LengthCubPerTime FromMillimeterCubPerSeconds(double value) => new LengthCubPerTime((value + millimetercubpersecond_.Offset) * millimetercubpersecond_.Factor);
  public double GetValueInMillimeterCubPerSeconds() => (Value_ - millimetercubpersecond_.Offset) / millimetercubpersecond_.Factor;
  public static LengthCubPerTime FromMeterCubPerSeconds(double value, double minValue, double maxValue) => new LengthCubPerTime((value + metercubpersecond_.Offset) * metercubpersecond_.Factor, minValue * metercubpersecond_.Factor, maxValue * metercubpersecond_.Factor);
  public static LengthCubPerTime FromMeterCubPerSeconds(double value) => new LengthCubPerTime((value + metercubpersecond_.Offset) * metercubpersecond_.Factor);
  public double GetValueInMeterCubPerSeconds() => (Value_ - metercubpersecond_.Offset) / metercubpersecond_.Factor;
  public static LengthCubPerTime FromInchCubPerSeconds(double value, double minValue, double maxValue) => new LengthCubPerTime((value + inchcubpersecond_.Offset) * inchcubpersecond_.Factor, minValue * inchcubpersecond_.Factor, maxValue * inchcubpersecond_.Factor);
  public static LengthCubPerTime FromInchCubPerSeconds(double value) => new LengthCubPerTime((value + inchcubpersecond_.Offset) * inchcubpersecond_.Factor);
  public double GetValueInInchCubPerSeconds() => (Value_ - inchcubpersecond_.Offset) / inchcubpersecond_.Factor;

#endregion

#region arithmetic
  public static LengthCubPerTime operator+(LengthCubPerTime o1, LengthCubPerTime o2) => new LengthCubPerTime(o1.Value_ + o2.Value_);
  public static LengthCubPerTime operator-(LengthCubPerTime o1, LengthCubPerTime o2) => new LengthCubPerTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubPerTime o1, LengthCubPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthCubPerTime o1, LengthCubTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthCubTime o1, LengthCubPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthCubPerTime o1, LengthCubMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthCubMass o1, LengthCubPerTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthCubPerTime o1, PerMassTimeLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassTimeLengthCub o1, LengthCubPerTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(LengthCubPerTime o1, TimePerMassLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimePerMassLengthCub o1, LengthCubPerTime o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthCubPerTime o1, PerTimeSqrLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerTimeSqrLengthCub o1, LengthCubPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthCubPerTime o1, TimeSqrPerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrPerLengthCub o1, LengthCubPerTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthCubPerTime o1, MassPerTimeLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerTimeLengthCub o1, LengthCubPerTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthCubPerTime o1, MassTimePerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassTimePerLengthCub o1, LengthCubPerTime o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(LengthCubPerTime o1, PerMassLengthSqrTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerMassLengthSqrTimeSqr o1, LengthCubPerTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(LengthCubPerTime o1, TimeSqrPerMassLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimeSqrPerMassLengthSqr o1, LengthCubPerTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthCubPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubPerLengthSqr o1, LengthCubPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(LengthCubPerTime o1, MassPerLengthSqrTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(MassPerLengthSqrTimeSqr o1, LengthCubPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(LengthCubPerTime o1, TimeSqrMassPerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(LengthCubPerTime o1, TimeCubPerLengthMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeCubPerLengthMass o1, LengthCubPerTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(LengthCubPerTime o1, TimeCubMassPerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeCubMassPerLength o1, LengthCubPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(LengthCubPerTime o1, LengthPerMassTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(LengthPerMassTimeCub o1, LengthCubPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(LengthCubPerTime o1, LengthMassPerTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(LengthMassPerTimeCub o1, LengthCubPerTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator/(LengthCubPerTime o1, LengthSqrPerMassTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator/(LengthCubPerTime o1, LengthSqrTimeSqrPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(LengthSqrTimeSqrPerMass o1, LengthCubPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(LengthCubPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(LengthSqrPerTimeCub o1, LengthCubPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(LengthCubPerTime o1, LengthSqrMassPerTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(LengthSqrMassPerTimeSqr o1, LengthCubPerTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator/(LengthCubPerTime o1, LengthSqrTimeSqrMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(LengthSqrTimeSqrMass o1, LengthCubPerTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(LengthCubPerTime o1, LengthCubPerMassTime o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthCubPerMassTime o1, LengthCubPerTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthCubPerTime o1, LengthCubTimePerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthCubTimePerMass o1, LengthCubPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(LengthCubPerTime o1, LengthCubPerTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthCubPerTimeSqr o1, LengthCubPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthCubPerTime o1, LengthCubTimeSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(LengthCubTimeSqr o1, LengthCubPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthCubPerTime o1, LengthCubMassPerTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthCubMassPerTime o1, LengthCubPerTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthCubPerTime o1, LengthCubMassTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthCubMassTime o1, LengthCubPerTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(LengthCubPerTime o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerMassTimeSqrLengthCub o1, LengthCubPerTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(LengthCubPerTime o1, TimeSqrPerMassLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeSqrPerMassLengthCub o1, LengthCubPerTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthCubPerTime o1, TimeCubPerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubPerLengthCub o1, LengthCubPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(LengthCubPerTime o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerTimeSqrLengthCub o1, LengthCubPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(LengthCubPerTime o1, TimeSqrMassPerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeSqrMassPerLengthCub o1, LengthCubPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(LengthCubPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeCubPerMassLengthSqr o1, LengthCubPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(LengthCubPerTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeCubMassPerLengthSqr o1, LengthCubPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(LengthCubPerTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthSqrPerMassTimeCub o1, LengthCubPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(LengthCubPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(LengthSqrMassPerTimeCub o1, LengthCubPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassTime operator/(LengthCubPerTime o1, LengthCubPerMassTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthCubPerMassTimeSqr o1, LengthCubPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(LengthCubPerTime o1, LengthCubTimeSqrPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(LengthCubTimeSqrPerMass o1, LengthCubPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(LengthCubPerTime o1, LengthCubPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthCubPerTimeCub o1, LengthCubPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthCubPerTime o1, LengthCubMassPerTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubMassPerTimeSqr o1, LengthCubPerTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(LengthCubPerTime o1, LengthCubTimeSqrMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(LengthCubTimeSqrMass o1, LengthCubPerTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthCubPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubPerMassLengthCub o1, LengthCubPerTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(LengthCubPerTime o1, TimeCubMassPerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeCubMassPerLengthCub o1, LengthCubPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator/(LengthCubPerTime o1, LengthCubPerMassTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthCubPerMassTimeCub o1, LengthCubPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthCubPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthCubMassPerTimeCub o1, LengthCubPerTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubPerTime is outside its bounds.");
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
    