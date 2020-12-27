
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthTime : Quantity, IEquatable<LengthTime>, IComparable
  {  
    internal LengthTime(double value) : base(value, 2)
    {
      LengthTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthTime(LengthTime other) : base(other)
    {
      LengthTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthTime"))
    {
      switch(FakeDatabase.Units["LengthTime"])
      {
        case "centimetersecond": displayUnit_ = centimetersecond_; break;
        case "millimetersecond": displayUnit_ = millimetersecond_; break;
        case "metersecond": displayUnit_ = metersecond_; break;
        case "inchsecond": displayUnit_ = inchsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersecond_ = new Unit_("CentimeterSecond", "cm s", 1, 0);
  private static Unit_ millimetersecond_ = new Unit_("MillimeterSecond", "mm s", 0.1, 0);
  private static Unit_ metersecond_ = new Unit_("MeterSecond", "m s", 100, 0);
  private static Unit_ inchsecond_ = new Unit_("InchSecond", "in s", 2.56, 0);
  private static Unit_ platformUnit_ = centimetersecond_;
  private static Unit_ displayUnit_ = centimetersecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthTime other && Equals(other);
  public bool Equals(LengthTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthTime other)) throw new ArgumentException("Object is not a LengthTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthTime l1, LengthTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthTime l1, LengthTime l2) => !(l1 == l2);
  public static bool operator <(LengthTime l1, LengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthTime l1, LengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthTime l1, LengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthTime l1, LengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthTime FromCentimeterSeconds(double value, double minValue, double maxValue) => new LengthTime((value + centimetersecond_.Offset) * centimetersecond_.Factor, minValue * centimetersecond_.Factor, maxValue * centimetersecond_.Factor);
  public static LengthTime FromCentimeterSeconds(double value) => new LengthTime((value + centimetersecond_.Offset) * centimetersecond_.Factor);
  public double GetValueInCentimeterSeconds() => (Value_ - centimetersecond_.Offset) / centimetersecond_.Factor;
  public static LengthTime FromMillimeterSeconds(double value, double minValue, double maxValue) => new LengthTime((value + millimetersecond_.Offset) * millimetersecond_.Factor, minValue * millimetersecond_.Factor, maxValue * millimetersecond_.Factor);
  public static LengthTime FromMillimeterSeconds(double value) => new LengthTime((value + millimetersecond_.Offset) * millimetersecond_.Factor);
  public double GetValueInMillimeterSeconds() => (Value_ - millimetersecond_.Offset) / millimetersecond_.Factor;
  public static LengthTime FromMeterSeconds(double value, double minValue, double maxValue) => new LengthTime((value + metersecond_.Offset) * metersecond_.Factor, minValue * metersecond_.Factor, maxValue * metersecond_.Factor);
  public static LengthTime FromMeterSeconds(double value) => new LengthTime((value + metersecond_.Offset) * metersecond_.Factor);
  public double GetValueInMeterSeconds() => (Value_ - metersecond_.Offset) / metersecond_.Factor;
  public static LengthTime FromInchSeconds(double value, double minValue, double maxValue) => new LengthTime((value + inchsecond_.Offset) * inchsecond_.Factor, minValue * inchsecond_.Factor, maxValue * inchsecond_.Factor);
  public static LengthTime FromInchSeconds(double value) => new LengthTime((value + inchsecond_.Offset) * inchsecond_.Factor);
  public double GetValueInInchSeconds() => (Value_ - inchsecond_.Offset) / inchsecond_.Factor;

#endregion

#region arithmetic
  public static LengthTime operator+(LengthTime o1, LengthTime o2) => new LengthTime(o1.Value_ + o2.Value_);
  public static LengthTime operator-(LengthTime o1, LengthTime o2) => new LengthTime(o1.Value_ - o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthTime o1, LengthTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static Dimensionless operator/(LengthTime o1, LengthTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(LengthTime o1, LengthMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthMass o1, LengthTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(LengthTime o1, LengthMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthMass o1, LengthTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(LengthTime o1, Area o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(Area o1, LengthTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static TimePerLength operator/(LengthTime o1, Area o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(Area o1, LengthTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthTime o1, PerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerLengthCub o1, LengthTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(LengthTime o1, PerMassLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(PerMassLengthSqr o1, LengthTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(LengthTime o1, PerMassLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerMassLengthSqr o1, LengthTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthTime o1, PerTimeLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerTimeLengthSqr o1, LengthTime o2) => new PerLength(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator/(LengthTime o1, PerTimeLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerTimeLengthSqr o1, LengthTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthTime o1, TimePerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimePerLengthSqr o1, LengthTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static Volume operator/(LengthTime o1, TimePerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimePerLengthSqr o1, LengthTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(LengthTime o1, MassPerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassPerLengthSqr o1, LengthTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(LengthTime o1, MassPerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerLengthSqr o1, LengthTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(LengthTime o1, PerLengthMassTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerLengthMassTime o1, LengthTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthTime o1, PerLengthMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthMassTime o1, LengthTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthTime o1, TimePerLengthMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimePerLengthMass o1, LengthTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator/(LengthTime o1, TimePerLengthMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimePerLengthMass o1, LengthTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(LengthTime o1, PerLengthTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthTimeSqr o1, LengthTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator/(LengthTime o1, PerLengthTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthTimeSqr o1, LengthTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCub operator*(LengthTime o1, TimeSqrPerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrPerLength o1, LengthTime o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator/(LengthTime o1, TimeSqrPerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeSqrPerLength o1, LengthTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator*(LengthTime o1, MassPerLengthTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerLengthTime o1, LengthTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthTime o1, MassPerLengthTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerLengthTime o1, LengthTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(LengthTime o1, MassTimePerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(MassTimePerLength o1, LengthTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator/(LengthTime o1, MassTimePerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassTimePerLength o1, LengthTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(LengthTime o1, PerMassTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassTimeSqr o1, LengthTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(LengthTime o1, PerMassTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassTimeSqr o1, LengthTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(LengthTime o1, TimeSqrPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeSqrPerMass o1, LengthTime o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(LengthTime o1, TimeSqrPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrPerMass o1, LengthTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthTime o1, PerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerTimeCub o1, LengthTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthTime o1, TimeCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCub o1, LengthTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(LengthTime o1, MassPerTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerTimeSqr o1, LengthTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthTime o1, MassPerTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTimeSqr o1, LengthTime o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(LengthTime o1, TimeSqrMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeSqrMass o1, LengthTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(LengthTime o1, TimeSqrMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeSqrMass o1, LengthTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(LengthTime o1, LengthPerMassTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthPerMassTime o1, LengthTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(LengthTime o1, LengthPerMassTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthPerMassTime o1, LengthTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(LengthTime o1, LengthTimePerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthTimePerMass o1, LengthTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static Mass operator/(LengthTime o1, LengthTimePerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthTimePerMass o1, LengthTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(LengthTime o1, Acceleration o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(Acceleration o1, LengthTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static TimeCub operator/(LengthTime o1, Acceleration o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(Acceleration o1, LengthTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthTime o1, TimeSqrLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeSqrLength o1, LengthTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static PerTime operator/(LengthTime o1, TimeSqrLength o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrLength o1, LengthTime o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(LengthTime o1, LengthMassPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthMassPerTime o1, LengthTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(LengthTime o1, LengthMassPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthMassPerTime o1, LengthTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(LengthTime o1, LengthMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthMassTime o1, LengthTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMass operator/(LengthTime o1, LengthMassTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthMassTime o1, LengthTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(LengthTime o1, LengthSqrPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthSqrPerMass o1, LengthTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(LengthTime o1, LengthSqrPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrPerMass o1, LengthTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthTime o1, LengthSqrPerTime o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrPerTime o1, LengthTime o2) => new Volume(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator/(LengthTime o1, LengthSqrPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrPerTime o1, LengthTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthTime o1, LengthSqrTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrTime o1, LengthTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static PerLength operator/(LengthTime o1, LengthSqrTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrTime o1, LengthTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(LengthTime o1, LengthSqrMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthSqrMass o1, LengthTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(LengthTime o1, LengthSqrMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrMass o1, LengthTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthTime o1, Volume o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(Volume o1, LengthTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(LengthTime o1, PerMassLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(PerMassLengthCub o1, LengthTime o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthTime o1, PerTimeLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerTimeLengthCub o1, LengthTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthTime o1, TimePerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimePerLengthCub o1, LengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(LengthTime o1, Density o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(Density o1, LengthTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(LengthTime o1, PerMassTimeLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassTimeLengthSqr o1, LengthTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthTime o1, PerMassTimeLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerMassTimeLengthSqr o1, LengthTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthTime o1, TimePerMassLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimePerMassLengthSqr o1, LengthTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator/(LengthTime o1, TimePerMassLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(TimePerMassLengthSqr o1, LengthTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthTime o1, PerLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerLengthSqrTimeSqr o1, LengthTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator/(LengthTime o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthSqrTimeSqr o1, LengthTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator*(LengthTime o1, TimeSqrPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrPerLengthSqr o1, LengthTime o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator/(LengthTime o1, TimeSqrPerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeSqrPerLengthSqr o1, LengthTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(LengthTime o1, MassPerTimeLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerTimeLengthSqr o1, LengthTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthTime o1, MassPerTimeLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerTimeLengthSqr o1, LengthTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(LengthTime o1, MassTimePerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(MassTimePerLengthSqr o1, LengthTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator/(LengthTime o1, MassTimePerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(MassTimePerLengthSqr o1, LengthTime o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(LengthTime o1, PerLengthMassTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerLengthMassTimeSqr o1, LengthTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthTime o1, PerLengthMassTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthMassTimeSqr o1, LengthTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(LengthTime o1, TimeSqrPerLengthMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeSqrPerLengthMass o1, LengthTime o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthTime o1, TimeSqrPerLengthMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimeSqrPerLengthMass o1, LengthTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(LengthTime o1, PerLengthTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthTimeCub o1, LengthTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static QDose operator/(LengthTime o1, TimeCubPerLength o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeCubPerLength o1, LengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(LengthTime o1, MassPerLengthTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerLengthTimeSqr o1, LengthTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthTime o1, MassPerLengthTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerLengthTimeSqr o1, LengthTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(LengthTime o1, TimeSqrMassPerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeSqrMassPerLength o1, LengthTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthTime o1, TimeSqrMassPerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeSqrMassPerLength o1, LengthTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(LengthTime o1, PerMassTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerMassTimeCub o1, LengthTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Force operator/(LengthTime o1, TimeCubPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubPerMass o1, LengthTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static Force operator*(LengthTime o1, MassPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerTimeCub o1, LengthTime o2) => new Force(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(LengthTime o1, TimeCubMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubMass o1, LengthTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(LengthTime o1, LengthPerMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthPerMassTimeSqr o1, LengthTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(LengthTime o1, LengthPerMassTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthPerMassTimeSqr o1, LengthTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(LengthTime o1, TimeSqrLengthPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeSqrLengthPerMass o1, LengthTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerTime operator/(LengthTime o1, TimeSqrLengthPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeSqrLengthPerMass o1, LengthTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthTime o1, LengthPerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthPerTimeCub o1, LengthTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(LengthTime o1, TimeCubLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLength o1, LengthTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(LengthTime o1, Force o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(Force o1, LengthTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(LengthTime o1, Force o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(Force o1, LengthTime o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(LengthTime o1, TimeSqrLengthMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeSqrLengthMass o1, LengthTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(LengthTime o1, TimeSqrLengthMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrLengthMass o1, LengthTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthTime o1, LengthSqrPerMassTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrPerMassTime o1, LengthTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(LengthTime o1, LengthSqrPerMassTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthSqrPerMassTime o1, LengthTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(LengthTime o1, LengthSqrTimePerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthSqrTimePerMass o1, LengthTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(LengthTime o1, LengthSqrTimePerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrTimePerMass o1, LengthTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthTime o1, QDose o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(QDose o1, LengthTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(LengthTime o1, QDose o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(QDose o1, LengthTime o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthTime o1, LengthSqrTimeSqr o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrTimeSqr o1, LengthTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(LengthTime o1, LengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrTimeSqr o1, LengthTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(LengthTime o1, LengthSqrMassPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrMassPerTime o1, LengthTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(LengthTime o1, LengthSqrMassPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthSqrMassPerTime o1, LengthTime o2) => new Force(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(LengthTime o1, LengthSqrMassTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthSqrMassTime o1, LengthTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(LengthTime o1, LengthSqrMassTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrMassTime o1, LengthTime o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(LengthTime o1, LengthCubPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubPerMass o1, LengthTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthTime o1, LengthCubPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerTime o1, LengthTime o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(LengthTime o1, LengthCubTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTime o1, LengthTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(LengthTime o1, LengthCubMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubMass o1, LengthTime o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthTime o1, PerMassTimeLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerMassTimeLengthCub o1, LengthTime o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(LengthTime o1, TimePerMassLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimePerMassLengthCub o1, LengthTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthTime o1, PerTimeSqrLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerTimeSqrLengthCub o1, LengthTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(LengthTime o1, TimeSqrPerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeSqrPerLengthCub o1, LengthTime o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(LengthTime o1, MassPerTimeLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerTimeLengthCub o1, LengthTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(LengthTime o1, MassTimePerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(MassTimePerLengthCub o1, LengthTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator*(LengthTime o1, PerMassLengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassLengthSqrTimeSqr o1, LengthTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthTime o1, PerMassLengthSqrTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassLengthSqrTimeSqr o1, LengthTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrPerMassLengthSqr o1, LengthTime o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(LengthTime o1, TimeSqrPerMassLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimeSqrPerMassLengthSqr o1, LengthTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthTime o1, PerLengthSqrTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthSqrTimeCub o1, LengthTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthTime o1, TimeCubPerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubPerLengthSqr o1, LengthTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(LengthTime o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerLengthSqrTimeSqr o1, LengthTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthTime o1, MassPerLengthSqrTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthSqrTimeSqr o1, LengthTime o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthTime o1, TimeSqrMassPerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrMassPerLengthSqr o1, LengthTime o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(LengthTime o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimeSqrMassPerLengthSqr o1, LengthTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthTime o1, PerLengthMassTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthMassTimeCub o1, LengthTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(LengthTime o1, TimeCubPerLengthMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeCubPerLengthMass o1, LengthTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthTime o1, MassPerLengthTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerLengthTimeCub o1, LengthTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(LengthTime o1, TimeCubMassPerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeCubMassPerLength o1, LengthTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(LengthTime o1, LengthPerMassTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthPerMassTimeCub o1, LengthTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthTime o1, TimeCubLengthPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubLengthPerMass o1, LengthTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(LengthTime o1, LengthMassPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthMassPerTimeCub o1, LengthTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthTime o1, TimeCubLengthMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubLengthMass o1, LengthTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(LengthTime o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrPerMassTimeSqr o1, LengthTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(LengthTime o1, LengthSqrPerMassTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthTime o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(LengthTime o1, LengthSqrTimeSqrPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(LengthSqrTimeSqrPerMass o1, LengthTime o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(LengthTime o1, LengthSqrTimeSqrPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrTimeSqrPerMass o1, LengthTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthTime o1, LengthSqrPerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrPerTimeCub o1, LengthTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthTime o1, TimeCubLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubLengthSqr o1, LengthTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(LengthTime o1, LengthSqrMassPerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrMassPerTimeSqr o1, LengthTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(LengthTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthTime o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(LengthTime o1, LengthSqrTimeSqrMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthSqrTimeSqrMass o1, LengthTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(LengthTime o1, LengthSqrTimeSqrMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrTimeSqrMass o1, LengthTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(LengthTime o1, LengthCubPerMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthCubPerMassTime o1, LengthTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(LengthTime o1, LengthCubTimePerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubTimePerMass o1, LengthTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(LengthTime o1, LengthCubPerTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerTimeSqr o1, LengthTime o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthTime o1, LengthCubTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeSqr o1, LengthTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(LengthTime o1, LengthCubMassPerTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubMassPerTime o1, LengthTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthTime o1, LengthCubMassTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubMassTime o1, LengthTime o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(LengthTime o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassTimeSqrLengthCub o1, LengthTime o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(LengthTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthTime o1, PerLengthCubTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerLengthCubTimeCub o1, LengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(LengthTime o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerTimeSqrLengthCub o1, LengthTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(LengthTime o1, TimeSqrMassPerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthTime o1, PerMassLengthSqrTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassLengthSqrTimeCub o1, LengthTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator/(LengthTime o1, TimeCubPerMassLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeCubPerMassLengthSqr o1, LengthTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthTime o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerLengthSqrTimeCub o1, LengthTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator/(LengthTime o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeCubMassPerLengthSqr o1, LengthTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthTime o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrPerMassTimeCub o1, LengthTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthTime o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubLengthSqrPerMass o1, LengthTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(LengthTime o1, LengthSqrMassPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthSqrMassPerTimeCub o1, LengthTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthTime o1, TimeCubLengthSqrMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubLengthSqrMass o1, LengthTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(LengthTime o1, LengthCubPerMassTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(LengthTime o1, LengthCubTimeSqrPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTimeSqrPerMass o1, LengthTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthTime o1, LengthCubTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeCub o1, LengthTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(LengthTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthTime o1, LengthCubTimeSqrMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubTimeSqrMass o1, LengthTime o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(LengthTime o1, PerMassLengthCubTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(LengthTime o1, MassPerLengthCubTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(LengthTime o1, LengthCubTimeCubPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubTimeCubPerMass o1, LengthTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(LengthTime o1, LengthCubTimeCubMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubTimeCubMass o1, LengthTime o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthTime is outside its bounds.");
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
    