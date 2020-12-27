
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthTime : Quantity, IEquatable<PerLengthTime>, IComparable
  {  
    internal PerLengthTime(double value) : base(value, 2)
    {
      PerLengthTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthTime(PerLengthTime other) : base(other)
    {
      PerLengthTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthTime"))
    {
      switch(FakeDatabase.Units["PerLengthTime"])
      {
        case "percentimetersecond": displayUnit_ = percentimetersecond_; break;
        case "permillimetersecond": displayUnit_ = permillimetersecond_; break;
        case "permetersecond": displayUnit_ = permetersecond_; break;
        case "perinchsecond": displayUnit_ = perinchsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimetersecond_ = new Unit_("PerCentimeterSecond", "/cm s", 1.0, 0);
  private static Unit_ permillimetersecond_ = new Unit_("PerMillimeterSecond", "/mm s", 0.1, 0);
  private static Unit_ permetersecond_ = new Unit_("PerMeterSecond", "/m s", 100.0, 0);
  private static Unit_ perinchsecond_ = new Unit_("PerInchSecond", "/in s", 2.56, 0);
  private static Unit_ platformUnit_ = percentimetersecond_;
  private static Unit_ displayUnit_ = percentimetersecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthTime other && Equals(other);
  public bool Equals(PerLengthTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthTime other)) throw new ArgumentException("Object is not a PerLengthTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthTime l1, PerLengthTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthTime l1, PerLengthTime l2) => !(l1 == l2);
  public static bool operator <(PerLengthTime l1, PerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthTime l1, PerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthTime l1, PerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthTime l1, PerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthTime FromPerCentimeterSeconds(double value, double minValue, double maxValue) => new PerLengthTime((value + percentimetersecond_.Offset) * percentimetersecond_.Factor, minValue * percentimetersecond_.Factor, maxValue * percentimetersecond_.Factor);
  public static PerLengthTime FromPerCentimeterSeconds(double value) => new PerLengthTime((value + percentimetersecond_.Offset) * percentimetersecond_.Factor);
  public double GetValueInPerCentimeterSeconds() => (Value_ - percentimetersecond_.Offset) / percentimetersecond_.Factor;
  public static PerLengthTime FromPerMillimeterSeconds(double value, double minValue, double maxValue) => new PerLengthTime((value + permillimetersecond_.Offset) * permillimetersecond_.Factor, minValue * permillimetersecond_.Factor, maxValue * permillimetersecond_.Factor);
  public static PerLengthTime FromPerMillimeterSeconds(double value) => new PerLengthTime((value + permillimetersecond_.Offset) * permillimetersecond_.Factor);
  public double GetValueInPerMillimeterSeconds() => (Value_ - permillimetersecond_.Offset) / permillimetersecond_.Factor;
  public static PerLengthTime FromPerMeterSeconds(double value, double minValue, double maxValue) => new PerLengthTime((value + permetersecond_.Offset) * permetersecond_.Factor, minValue * permetersecond_.Factor, maxValue * permetersecond_.Factor);
  public static PerLengthTime FromPerMeterSeconds(double value) => new PerLengthTime((value + permetersecond_.Offset) * permetersecond_.Factor);
  public double GetValueInPerMeterSeconds() => (Value_ - permetersecond_.Offset) / permetersecond_.Factor;
  public static PerLengthTime FromPerInchSeconds(double value, double minValue, double maxValue) => new PerLengthTime((value + perinchsecond_.Offset) * perinchsecond_.Factor, minValue * perinchsecond_.Factor, maxValue * perinchsecond_.Factor);
  public static PerLengthTime FromPerInchSeconds(double value) => new PerLengthTime((value + perinchsecond_.Offset) * perinchsecond_.Factor);
  public double GetValueInPerInchSeconds() => (Value_ - perinchsecond_.Offset) / perinchsecond_.Factor;

#endregion

#region arithmetic
  public static PerLengthTime operator+(PerLengthTime o1, PerLengthTime o2) => new PerLengthTime(o1.Value_ + o2.Value_);
  public static PerLengthTime operator-(PerLengthTime o1, PerLengthTime o2) => new PerLengthTime(o1.Value_ - o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerLengthTime o1, PerLengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static Dimensionless operator/(PerLengthTime o1, PerLengthTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(PerLengthTime o1, TimePerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimePerLength o1, PerLengthTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator/(PerLengthTime o1, TimePerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimePerLength o1, PerLengthTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(PerLengthTime o1, MassPerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerLength o1, PerLengthTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(PerLengthTime o1, MassPerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassPerLength o1, PerLengthTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(PerLengthTime o1, PerMassTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassTime o1, PerLengthTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(PerLengthTime o1, PerMassTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(PerMassTime o1, PerLengthTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(PerLengthTime o1, TimePerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimePerMass o1, PerLengthTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(PerLengthTime o1, TimePerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimePerMass o1, PerLengthTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(PerLengthTime o1, PerTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerTimeSqr o1, PerLengthTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLength operator/(PerLengthTime o1, PerTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerTimeSqr o1, PerLengthTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(PerLengthTime o1, TimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqr o1, PerLengthTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator/(PerLengthTime o1, TimeSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeSqr o1, PerLengthTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(PerLengthTime o1, MassPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerTime o1, PerLengthTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(PerLengthTime o1, MassPerTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassPerTime o1, PerLengthTime o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(PerLengthTime o1, MassTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassTime o1, PerLengthTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthTime o1, MassTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(MassTime o1, PerLengthTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(PerLengthTime o1, LengthPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthPerMass o1, PerLengthTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(PerLengthTime o1, LengthPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthPerMass o1, PerLengthTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(PerLengthTime o1, Speed o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(Speed o1, PerLengthTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator/(PerLengthTime o1, Speed o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(Speed o1, PerLengthTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerLengthTime o1, LengthTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthTime o1, PerLengthTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthTime o1, LengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthTime o1, PerLengthTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(PerLengthTime o1, LengthMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthMass o1, PerLengthTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthTime o1, LengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthMass o1, PerLengthTime o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static Speed operator*(PerLengthTime o1, Area o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(Area o1, PerLengthTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator/(PerLengthTime o1, Area o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(Area o1, PerLengthTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(PerLengthTime o1, PerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(PerLengthCub o1, PerLengthTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(PerLengthTime o1, PerMassLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerMassLengthSqr o1, PerLengthTime o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(PerLengthTime o1, PerMassLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(PerMassLengthSqr o1, PerLengthTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerLengthTime o1, PerTimeLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerTimeLengthSqr o1, PerLengthTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static Length operator/(PerLengthTime o1, PerTimeLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerTimeLengthSqr o1, PerLengthTime o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(PerLengthTime o1, TimePerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimePerLengthSqr o1, PerLengthTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static Acceleration operator/(PerLengthTime o1, TimePerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimePerLengthSqr o1, PerLengthTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(PerLengthTime o1, MassPerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerLengthSqr o1, PerLengthTime o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(PerLengthTime o1, MassPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(MassPerLengthSqr o1, PerLengthTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(PerLengthTime o1, PerLengthMassTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerLengthMassTime o1, PerLengthTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static Mass operator/(PerLengthTime o1, PerLengthMassTime o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerLengthMassTime o1, PerLengthTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(PerLengthTime o1, TimePerLengthMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimePerLengthMass o1, PerLengthTime o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator/(PerLengthTime o1, TimePerLengthMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimePerLengthMass o1, PerLengthTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerLengthTime o1, PerLengthTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerLengthTimeSqr o1, PerLengthTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static Time operator/(PerLengthTime o1, PerLengthTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerLengthTimeSqr o1, PerLengthTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(PerLengthTime o1, TimeSqrPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeSqrPerLength o1, PerLengthTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeCub operator/(PerLengthTime o1, TimeSqrPerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrPerLength o1, PerLengthTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(PerLengthTime o1, MassPerLengthTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerLengthTime o1, PerLengthTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMass operator/(PerLengthTime o1, MassPerLengthTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassPerLengthTime o1, PerLengthTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(PerLengthTime o1, MassTimePerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassTimePerLength o1, PerLengthTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthTime o1, MassTimePerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(MassTimePerLength o1, PerLengthTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(PerLengthTime o1, PerMassTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerMassTimeSqr o1, PerLengthTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(PerLengthTime o1, PerMassTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(PerMassTimeSqr o1, PerLengthTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(PerLengthTime o1, TimeSqrPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeSqrPerMass o1, PerLengthTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(PerLengthTime o1, TimeSqrPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeSqrPerMass o1, PerLengthTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(PerLengthTime o1, PerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerTimeCub o1, PerLengthTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(PerLengthTime o1, TimeCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCub o1, PerLengthTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(PerLengthTime o1, MassPerTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerTimeSqr o1, PerLengthTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(PerLengthTime o1, MassPerTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(MassPerTimeSqr o1, PerLengthTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(PerLengthTime o1, TimeSqrMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeSqrMass o1, PerLengthTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(PerLengthTime o1, TimeSqrMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeSqrMass o1, PerLengthTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(PerLengthTime o1, LengthPerMassTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthPerMassTime o1, PerLengthTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator/(PerLengthTime o1, LengthPerMassTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthPerMassTime o1, PerLengthTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(PerLengthTime o1, LengthTimePerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthTimePerMass o1, PerLengthTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(PerLengthTime o1, LengthTimePerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthTimePerMass o1, PerLengthTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(PerLengthTime o1, Acceleration o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(Acceleration o1, PerLengthTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator/(PerLengthTime o1, Acceleration o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(Acceleration o1, PerLengthTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(PerLengthTime o1, TimeSqrLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrLength o1, PerLengthTime o2) => new Time(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthTime o1, TimeSqrLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeSqrLength o1, PerLengthTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator*(PerLengthTime o1, LengthMassPerTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthMassPerTime o1, PerLengthTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator/(PerLengthTime o1, LengthMassPerTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthMassPerTime o1, PerLengthTime o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static Mass operator*(PerLengthTime o1, LengthMassTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthMassTime o1, PerLengthTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthTime o1, LengthMassTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthMassTime o1, PerLengthTime o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(PerLengthTime o1, LengthSqrPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthSqrPerMass o1, PerLengthTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(PerLengthTime o1, LengthSqrPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(LengthSqrPerMass o1, PerLengthTime o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(PerLengthTime o1, LengthSqrPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthSqrPerTime o1, PerLengthTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static PerLengthCub operator/(PerLengthTime o1, LengthSqrPerTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrPerTime o1, PerLengthTime o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static Length operator*(PerLengthTime o1, LengthSqrTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrTime o1, PerLengthTime o2) => new Length(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerLengthTime o1, LengthSqrTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthSqrTime o1, PerLengthTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(PerLengthTime o1, LengthSqrMass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthSqrMass o1, PerLengthTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(PerLengthTime o1, LengthSqrMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthSqrMass o1, PerLengthTime o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(PerLengthTime o1, Volume o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(Volume o1, PerLengthTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator/(PerLengthTime o1, PerMassLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(PerMassLengthCub o1, PerLengthTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(PerLengthTime o1, PerTimeLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerTimeLengthCub o1, PerLengthTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(PerLengthTime o1, TimePerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimePerLengthCub o1, PerLengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator/(PerLengthTime o1, Density o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(Density o1, PerLengthTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(PerLengthTime o1, PerMassTimeLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerMassTimeLengthSqr o1, PerLengthTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthMass operator/(PerLengthTime o1, PerMassTimeLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(PerMassTimeLengthSqr o1, PerLengthTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(PerLengthTime o1, TimePerMassLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(TimePerMassLengthSqr o1, PerLengthTime o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static Force operator/(PerLengthTime o1, TimePerMassLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimePerMassLengthSqr o1, PerLengthTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerLengthTime o1, PerLengthSqrTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerLengthSqrTimeSqr o1, PerLengthTime o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthTime operator/(PerLengthTime o1, PerLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerLengthSqrTimeSqr o1, PerLengthTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(PerLengthTime o1, TimeSqrPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthTime o1, TimeSqrPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeSqrPerLengthSqr o1, PerLengthTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(PerLengthTime o1, MassPerTimeLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerTimeLengthSqr o1, PerLengthTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMass operator/(PerLengthTime o1, MassPerTimeLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassPerTimeLengthSqr o1, PerLengthTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static Density operator*(PerLengthTime o1, MassTimePerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassTimePerLengthSqr o1, PerLengthTime o2) => new Density(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerLengthTime o1, MassTimePerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(MassTimePerLengthSqr o1, PerLengthTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(PerLengthTime o1, PerLengthMassTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerLengthMassTimeSqr o1, PerLengthTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassTime operator/(PerLengthTime o1, PerLengthMassTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(PerLengthMassTimeSqr o1, PerLengthTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthTime o1, TimeSqrPerLengthMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeSqrPerLengthMass o1, PerLengthTime o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator/(PerLengthTime o1, TimeSqrPerLengthMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeSqrPerLengthMass o1, PerLengthTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(PerLengthTime o1, PerLengthTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerLengthTimeCub o1, PerLengthTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerLengthTime o1, TimeCubPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubPerLength o1, PerLengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(PerLengthTime o1, MassPerLengthTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(MassPerLengthTimeSqr o1, PerLengthTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(PerLengthTime o1, MassPerLengthTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerLengthTimeSqr o1, PerLengthTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(PerLengthTime o1, TimeSqrMassPerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(PerLengthTime o1, TimeSqrMassPerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeSqrMassPerLength o1, PerLengthTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(PerLengthTime o1, PerMassTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerMassTimeCub o1, PerLengthTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerLengthTime o1, TimeCubPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeCubPerMass o1, PerLengthTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(PerLengthTime o1, MassPerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(MassPerTimeCub o1, PerLengthTime o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(PerLengthTime o1, TimeCubMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeCubMass o1, PerLengthTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(PerLengthTime o1, LengthPerMassTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthPerMassTimeSqr o1, PerLengthTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(PerLengthTime o1, LengthPerMassTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthPerMassTimeSqr o1, PerLengthTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerLengthTime o1, TimeSqrLengthPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeSqrLengthPerMass o1, PerLengthTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(PerLengthTime o1, TimeSqrLengthPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(TimeSqrLengthPerMass o1, PerLengthTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerLengthTime o1, LengthPerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthPerTimeCub o1, PerLengthTime o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(PerLengthTime o1, TimeCubLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubLength o1, PerLengthTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(PerLengthTime o1, Force o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(Force o1, PerLengthTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(PerLengthTime o1, Force o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(Force o1, PerLengthTime o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(PerLengthTime o1, TimeSqrLengthMass o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeSqrLengthMass o1, PerLengthTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthTime o1, TimeSqrLengthMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeSqrLengthMass o1, PerLengthTime o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerLengthTime o1, LengthSqrPerMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthSqrPerMassTime o1, PerLengthTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static Density operator/(PerLengthTime o1, LengthSqrPerMassTime o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthSqrPerMassTime o1, PerLengthTime o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerLengthTime o1, LengthSqrTimePerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrTimePerMass o1, PerLengthTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(PerLengthTime o1, LengthSqrTimePerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthSqrTimePerMass o1, PerLengthTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(PerLengthTime o1, QDose o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(QDose o1, PerLengthTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator/(PerLengthTime o1, QDose o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(QDose o1, PerLengthTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(PerLengthTime o1, LengthSqrTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrTimeSqr o1, PerLengthTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthTime o1, LengthSqrTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthSqrTimeSqr o1, PerLengthTime o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static Force operator*(PerLengthTime o1, LengthSqrMassPerTime o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthSqrMassPerTime o1, PerLengthTime o2) => new Force(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(PerLengthTime o1, LengthSqrMassPerTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthSqrMassPerTime o1, PerLengthTime o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(PerLengthTime o1, LengthSqrMassTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrMassTime o1, PerLengthTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthTime o1, LengthSqrMassTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthSqrMassTime o1, PerLengthTime o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerLengthTime o1, LengthCubPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubPerMass o1, PerLengthTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static QDose operator*(PerLengthTime o1, LengthCubPerTime o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubPerTime o1, PerLengthTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static Area operator*(PerLengthTime o1, LengthCubTime o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubTime o1, PerLengthTime o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator*(PerLengthTime o1, LengthCubMass o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthCubMass o1, PerLengthTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(PerLengthTime o1, PerMassTimeLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(PerLengthTime o1, TimePerMassLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimePerMassLengthCub o1, PerLengthTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(PerLengthTime o1, PerTimeSqrLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(PerLengthTime o1, TimeSqrPerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeSqrPerLengthCub o1, PerLengthTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerLengthTime o1, MassPerTimeLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassPerTimeLengthCub o1, PerLengthTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(PerLengthTime o1, MassTimePerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(MassTimePerLengthCub o1, PerLengthTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerLengthTime o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerMassLengthSqrTimeSqr o1, PerLengthTime o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(PerLengthTime o1, PerMassLengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassLengthSqrTimeSqr o1, PerLengthTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerLengthTime o1, TimeSqrPerMassLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimeSqrPerMassLengthSqr o1, PerLengthTime o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(PerLengthTime o1, TimeSqrPerMassLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeSqrPerMassLengthSqr o1, PerLengthTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(PerLengthTime o1, PerLengthSqrTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerLengthSqrTimeCub o1, PerLengthTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(PerLengthTime o1, TimeCubPerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(PerLengthTime o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(MassPerLengthSqrTimeSqr o1, PerLengthTime o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(PerLengthTime o1, MassPerLengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerLengthSqrTimeSqr o1, PerLengthTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(PerLengthTime o1, TimeSqrMassPerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthTime o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(PerLengthTime o1, TimeSqrMassPerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeSqrMassPerLengthSqr o1, PerLengthTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(PerLengthTime o1, PerLengthMassTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthMassTimeCub o1, PerLengthTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(PerLengthTime o1, TimeCubPerLengthMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeCubPerLengthMass o1, PerLengthTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator/(PerLengthTime o1, MassPerLengthTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerLengthTimeCub o1, PerLengthTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(PerLengthTime o1, TimeCubMassPerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(PerLengthTime o1, LengthPerMassTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthPerMassTimeCub o1, PerLengthTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(PerLengthTime o1, TimeCubLengthPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubLengthPerMass o1, PerLengthTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(PerLengthTime o1, LengthMassPerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthMassPerTimeCub o1, PerLengthTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(PerLengthTime o1, TimeCubLengthMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeCubLengthMass o1, PerLengthTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(PerLengthTime o1, LengthSqrPerMassTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(LengthSqrPerMassTimeSqr o1, PerLengthTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(PerLengthTime o1, LengthSqrPerMassTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrPerMassTimeSqr o1, PerLengthTime o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerLengthTime o1, LengthSqrTimeSqrPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrTimeSqrPerMass o1, PerLengthTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(PerLengthTime o1, LengthSqrTimeSqrPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthSqrTimeSqrPerMass o1, PerLengthTime o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(PerLengthTime o1, LengthSqrPerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthSqrPerTimeCub o1, PerLengthTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(PerLengthTime o1, TimeCubLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubLengthSqr o1, PerLengthTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(PerLengthTime o1, LengthSqrMassPerTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerLengthTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(PerLengthTime o1, LengthSqrMassPerTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrMassPerTimeSqr o1, PerLengthTime o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(PerLengthTime o1, LengthSqrTimeSqrMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthSqrTimeSqrMass o1, PerLengthTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthTime o1, LengthSqrTimeSqrMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthSqrTimeSqrMass o1, PerLengthTime o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(PerLengthTime o1, LengthCubPerMassTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthCubPerMassTime o1, PerLengthTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator*(PerLengthTime o1, LengthCubTimePerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubTimePerMass o1, PerLengthTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(PerLengthTime o1, LengthCubPerTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthCubPerTimeSqr o1, PerLengthTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(PerLengthTime o1, LengthCubTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubTimeSqr o1, PerLengthTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(PerLengthTime o1, LengthCubMassPerTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthCubMassPerTime o1, PerLengthTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(PerLengthTime o1, LengthCubMassTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubMassTime o1, PerLengthTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(PerLengthTime o1, PerMassTimeSqrLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator/(PerLengthTime o1, TimeSqrPerMassLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeSqrPerMassLengthCub o1, PerLengthTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator/(PerLengthTime o1, PerLengthCubTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthCubTimeCub o1, PerLengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(PerLengthTime o1, MassPerTimeSqrLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassPerTimeSqrLengthCub o1, PerLengthTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator/(PerLengthTime o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeSqrMassPerLengthCub o1, PerLengthTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator/(PerLengthTime o1, PerMassLengthSqrTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerLengthTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(PerLengthTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeCubPerMassLengthSqr o1, PerLengthTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(PerLengthTime o1, MassPerLengthSqrTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerLengthSqrTimeCub o1, PerLengthTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(PerLengthTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(PerLengthTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthSqrPerMassTimeCub o1, PerLengthTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(PerLengthTime o1, TimeCubLengthSqrPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator/(PerLengthTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthSqrMassPerTimeCub o1, PerLengthTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(PerLengthTime o1, TimeCubLengthSqrMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeCubLengthSqrMass o1, PerLengthTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(PerLengthTime o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthCubPerMassTimeSqr o1, PerLengthTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator*(PerLengthTime o1, LengthCubTimeSqrPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubTimeSqrPerMass o1, PerLengthTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(PerLengthTime o1, LengthCubTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubTimeCub o1, PerLengthTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(PerLengthTime o1, LengthCubMassPerTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerLengthTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(PerLengthTime o1, LengthCubTimeSqrMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubTimeSqrMass o1, PerLengthTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(PerLengthTime o1, PerMassLengthCubTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassLengthCubTimeCub o1, PerLengthTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(PerLengthTime o1, MassPerLengthCubTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerLengthCubTimeCub o1, PerLengthTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(PerLengthTime o1, LengthCubTimeCubPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubTimeCubPerMass o1, PerLengthTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(PerLengthTime o1, LengthCubTimeCubMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthCubTimeCubMass o1, PerLengthTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthTime is outside its bounds.");
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
    