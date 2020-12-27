
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrTime : Quantity, IEquatable<LengthSqrTime>, IComparable
  {  
    internal LengthSqrTime(double value) : base(value, 2)
    {
      LengthSqrTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrTime(LengthSqrTime other) : base(other)
    {
      LengthSqrTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrTime"))
    {
      switch(FakeDatabase.Units["LengthSqrTime"])
      {
        case "centimetersqrsecond": displayUnit_ = centimetersqrsecond_; break;
        case "millimetersqrsecond": displayUnit_ = millimetersqrsecond_; break;
        case "metersqrsecond": displayUnit_ = metersqrsecond_; break;
        case "inchsqrsecond": displayUnit_ = inchsqrsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrsecond_ = new Unit_("CentimeterSqrSecond", "cm� s", 1, 0);
  private static Unit_ millimetersqrsecond_ = new Unit_("MillimeterSqrSecond", "mm� s", 0.010000000000000002, 0);
  private static Unit_ metersqrsecond_ = new Unit_("MeterSqrSecond", "m� s", 10000, 0);
  private static Unit_ inchsqrsecond_ = new Unit_("InchSqrSecond", "in� s", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrsecond_;
  private static Unit_ displayUnit_ = centimetersqrsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrTime other && Equals(other);
  public bool Equals(LengthSqrTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrTime other)) throw new ArgumentException("Object is not a LengthSqrTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrTime l1, LengthSqrTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrTime l1, LengthSqrTime l2) => !(l1 == l2);
  public static bool operator <(LengthSqrTime l1, LengthSqrTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrTime l1, LengthSqrTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrTime l1, LengthSqrTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrTime l1, LengthSqrTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrTime FromCentimeterSqrSeconds(double value, double minValue, double maxValue) => new LengthSqrTime((value + centimetersqrsecond_.Offset) * centimetersqrsecond_.Factor, minValue * centimetersqrsecond_.Factor, maxValue * centimetersqrsecond_.Factor);
  public static LengthSqrTime FromCentimeterSqrSeconds(double value) => new LengthSqrTime((value + centimetersqrsecond_.Offset) * centimetersqrsecond_.Factor);
  public double GetValueInCentimeterSqrSeconds() => (Value_ - centimetersqrsecond_.Offset) / centimetersqrsecond_.Factor;
  public static LengthSqrTime FromMillimeterSqrSeconds(double value, double minValue, double maxValue) => new LengthSqrTime((value + millimetersqrsecond_.Offset) * millimetersqrsecond_.Factor, minValue * millimetersqrsecond_.Factor, maxValue * millimetersqrsecond_.Factor);
  public static LengthSqrTime FromMillimeterSqrSeconds(double value) => new LengthSqrTime((value + millimetersqrsecond_.Offset) * millimetersqrsecond_.Factor);
  public double GetValueInMillimeterSqrSeconds() => (Value_ - millimetersqrsecond_.Offset) / millimetersqrsecond_.Factor;
  public static LengthSqrTime FromMeterSqrSeconds(double value, double minValue, double maxValue) => new LengthSqrTime((value + metersqrsecond_.Offset) * metersqrsecond_.Factor, minValue * metersqrsecond_.Factor, maxValue * metersqrsecond_.Factor);
  public static LengthSqrTime FromMeterSqrSeconds(double value) => new LengthSqrTime((value + metersqrsecond_.Offset) * metersqrsecond_.Factor);
  public double GetValueInMeterSqrSeconds() => (Value_ - metersqrsecond_.Offset) / metersqrsecond_.Factor;
  public static LengthSqrTime FromInchSqrSeconds(double value, double minValue, double maxValue) => new LengthSqrTime((value + inchsqrsecond_.Offset) * inchsqrsecond_.Factor, minValue * inchsqrsecond_.Factor, maxValue * inchsqrsecond_.Factor);
  public static LengthSqrTime FromInchSqrSeconds(double value) => new LengthSqrTime((value + inchsqrsecond_.Offset) * inchsqrsecond_.Factor);
  public double GetValueInInchSqrSeconds() => (Value_ - inchsqrsecond_.Offset) / inchsqrsecond_.Factor;

#endregion

#region arithmetic
  public static LengthSqrTime operator+(LengthSqrTime o1, LengthSqrTime o2) => new LengthSqrTime(o1.Value_ + o2.Value_);
  public static LengthSqrTime operator-(LengthSqrTime o1, LengthSqrTime o2) => new LengthSqrTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrTime o1, LengthSqrTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthSqrTime o1, LengthSqrMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthSqrMass o1, LengthSqrTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrTime o1, Volume o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(Volume o1, LengthSqrTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(LengthSqrTime o1, PerMassLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(PerMassLengthCub o1, LengthSqrTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrTime o1, PerTimeLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerTimeLengthCub o1, LengthSqrTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrTime o1, TimePerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimePerLengthCub o1, LengthSqrTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(LengthSqrTime o1, Density o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(Density o1, LengthSqrTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(LengthSqrTime o1, PerMassTimeLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassTimeLengthSqr o1, LengthSqrTime o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthSqrTime o1, TimePerMassLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimePerMassLengthSqr o1, LengthSqrTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrTime o1, PerLengthSqrTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthSqrTimeSqr o1, LengthSqrTime o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthSqrTime o1, TimeSqrPerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrPerLengthSqr o1, LengthSqrTime o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthSqrTime o1, MassPerTimeLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerTimeLengthSqr o1, LengthSqrTime o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(LengthSqrTime o1, MassTimePerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(MassTimePerLengthSqr o1, LengthSqrTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(LengthSqrTime o1, PerLengthMassTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerLengthMassTimeSqr o1, LengthSqrTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthSqrTime o1, PerLengthMassTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthMassTimeSqr o1, LengthSqrTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(LengthSqrTime o1, TimeSqrPerLengthMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeSqrPerLengthMass o1, LengthSqrTime o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrTime o1, TimeSqrPerLengthMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthSqrTime o1, PerLengthTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthTimeCub o1, LengthSqrTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthSqrTime o1, TimeCubPerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubPerLength o1, LengthSqrTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(LengthSqrTime o1, MassPerLengthTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerLengthTimeSqr o1, LengthSqrTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthSqrTime o1, MassPerLengthTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthTimeSqr o1, LengthSqrTime o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(LengthSqrTime o1, TimeSqrMassPerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeSqrMassPerLength o1, LengthSqrTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrTime o1, TimeSqrMassPerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(LengthSqrTime o1, PerMassTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(PerMassTimeCub o1, LengthSqrTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(LengthSqrTime o1, TimeCubPerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeCubPerMass o1, LengthSqrTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(LengthSqrTime o1, MassPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(MassPerTimeCub o1, LengthSqrTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(LengthSqrTime o1, TimeCubMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeCubMass o1, LengthSqrTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(LengthSqrTime o1, LengthPerMassTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthPerMassTimeSqr o1, LengthSqrTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(LengthSqrTime o1, LengthPerMassTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthPerMassTimeSqr o1, LengthSqrTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(LengthSqrTime o1, TimeSqrLengthPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeSqrLengthPerMass o1, LengthSqrTime o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrTime o1, TimeSqrLengthPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrLengthPerMass o1, LengthSqrTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthSqrTime o1, LengthPerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthPerTimeCub o1, LengthSqrTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthSqrTime o1, TimeCubLength o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubLength o1, LengthSqrTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(LengthSqrTime o1, Force o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(Force o1, LengthSqrTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthSqrTime o1, Force o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(Force o1, LengthSqrTime o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(LengthSqrTime o1, TimeSqrLengthMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeSqrLengthMass o1, LengthSqrTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrTime o1, TimeSqrLengthMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeSqrLengthMass o1, LengthSqrTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(LengthSqrTime o1, LengthSqrPerMassTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthSqrPerMassTime o1, LengthSqrTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator/(LengthSqrTime o1, LengthSqrTimePerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthSqrTimePerMass o1, LengthSqrTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(LengthSqrTime o1, QDose o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(QDose o1, LengthSqrTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthSqrTime o1, LengthSqrTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrTimeSqr o1, LengthSqrTime o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthSqrTime o1, LengthSqrMassPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthSqrMassPerTime o1, LengthSqrTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthSqrTime o1, LengthSqrMassTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthSqrMassTime o1, LengthSqrTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(LengthSqrTime o1, LengthCubPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthCubPerMass o1, LengthSqrTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrTime o1, LengthCubPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubPerTime o1, LengthSqrTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrTime o1, LengthCubTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubTime o1, LengthSqrTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(LengthSqrTime o1, LengthCubMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthCubMass o1, LengthSqrTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(LengthSqrTime o1, PerMassTimeLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassTimeLengthCub o1, LengthSqrTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthSqrTime o1, TimePerMassLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimePerMassLengthCub o1, LengthSqrTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrTime o1, PerTimeSqrLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerTimeSqrLengthCub o1, LengthSqrTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthSqrTime o1, TimeSqrPerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrPerLengthCub o1, LengthSqrTime o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(LengthSqrTime o1, MassPerTimeLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerTimeLengthCub o1, LengthSqrTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(LengthSqrTime o1, MassTimePerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(MassTimePerLengthCub o1, LengthSqrTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(LengthSqrTime o1, PerMassLengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassLengthSqrTimeSqr o1, LengthSqrTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(LengthSqrTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeSqrPerMassLengthSqr o1, LengthSqrTime o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthSqrTime o1, PerLengthSqrTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthSqrTimeCub o1, LengthSqrTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(LengthSqrTime o1, MassPerLengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerLengthSqrTimeSqr o1, LengthSqrTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(LengthSqrTime o1, TimeSqrMassPerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeSqrMassPerLengthSqr o1, LengthSqrTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(LengthSqrTime o1, PerLengthMassTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerLengthMassTimeCub o1, LengthSqrTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator/(LengthSqrTime o1, TimeCubPerLengthMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeCubPerLengthMass o1, LengthSqrTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Force operator*(LengthSqrTime o1, MassPerLengthTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerLengthTimeCub o1, LengthSqrTime o2) => new Force(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator/(LengthSqrTime o1, TimeCubMassPerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeCubMassPerLength o1, LengthSqrTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthSqrTime o1, LengthPerMassTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthPerMassTimeCub o1, LengthSqrTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Force operator/(LengthSqrTime o1, TimeCubLengthPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubLengthPerMass o1, LengthSqrTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(LengthSqrTime o1, LengthMassPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthMassPerTimeCub o1, LengthSqrTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(LengthSqrTime o1, TimeCubLengthMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubLengthMass o1, LengthSqrTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator/(LengthSqrTime o1, LengthSqrPerMassTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthSqrTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(LengthSqrTime o1, LengthSqrTimeSqrPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthSqrTimeSqrPerMass o1, LengthSqrTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrTime o1, TimeCubLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLengthSqr o1, LengthSqrTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(LengthSqrTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthSqrTime o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrTime o1, LengthSqrTimeSqrMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrTimeSqrMass o1, LengthSqrTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(LengthSqrTime o1, LengthCubPerMassTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthCubPerMassTime o1, LengthSqrTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrTime o1, LengthCubTimePerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubTimePerMass o1, LengthSqrTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrTime o1, LengthCubPerTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubPerTimeSqr o1, LengthSqrTime o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrTime o1, LengthCubTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimeSqr o1, LengthSqrTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(LengthSqrTime o1, LengthCubMassPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthCubMassPerTime o1, LengthSqrTime o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrTime o1, LengthCubMassTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubMassTime o1, LengthSqrTime o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassTimeSqrLengthCub o1, LengthSqrTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthSqrTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrPerMassLengthCub o1, LengthSqrTime o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrTime o1, PerLengthCubTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthCubTimeCub o1, LengthSqrTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrTime o1, MassPerTimeSqrLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerTimeSqrLengthCub o1, LengthSqrTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthSqrTime o1, TimeSqrMassPerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrTime o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthSqrTime o1, PerMassLengthSqrTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassLengthSqrTimeCub o1, LengthSqrTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthSqrTime o1, MassPerLengthSqrTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerLengthSqrTimeCub o1, LengthSqrTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthSqrTime o1, TimeCubLengthSqrPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubLengthSqrPerMass o1, LengthSqrTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthSqrTime o1, TimeCubLengthSqrMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubLengthSqrMass o1, LengthSqrTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator/(LengthSqrTime o1, LengthCubPerMassTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthSqrTime o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrTime o1, LengthCubTimeSqrPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubTimeSqrPerMass o1, LengthSqrTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrTime o1, LengthCubTimeCub o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeCub o1, LengthSqrTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(LengthSqrTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthSqrTime o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrTime o1, LengthCubTimeSqrMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubTimeSqrMass o1, LengthSqrTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthSqrTime o1, PerMassLengthCubTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthSqrTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthSqrTime o1, MassPerLengthCubTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthSqrTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthSqrTime o1, LengthCubTimeCubPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubTimeCubPerMass o1, LengthSqrTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthSqrTime o1, LengthCubTimeCubMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubTimeCubMass o1, LengthSqrTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrTime is outside its bounds.");
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
    