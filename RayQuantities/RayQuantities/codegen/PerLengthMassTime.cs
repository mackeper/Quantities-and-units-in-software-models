
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthMassTime : Quantity, IEquatable<PerLengthMassTime>, IComparable
  {  
    internal PerLengthMassTime(double value) : base(value, 2)
    {
      PerLengthMassTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthMassTime(PerLengthMassTime other) : base(other)
    {
      PerLengthMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMassTime"))
    {
      switch(FakeDatabase.Units["PerLengthMassTime"])
      {
        case "percentimeterkilogramsecond": displayUnit_ = percentimeterkilogramsecond_; break;
        case "permillimeterkilogramsecond": displayUnit_ = permillimeterkilogramsecond_; break;
        case "permeterkilogramsecond": displayUnit_ = permeterkilogramsecond_; break;
        case "perinchkilogramsecond": displayUnit_ = perinchkilogramsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimeterkilogramsecond_ = new Unit_("PerCentimeterKilogramSecond", "/cm kg s", 1.0, 0);
  private static Unit_ permillimeterkilogramsecond_ = new Unit_("PerMillimeterKilogramSecond", "/mm kg s", 0.1, 0);
  private static Unit_ permeterkilogramsecond_ = new Unit_("PerMeterKilogramSecond", "/m kg s", 100.0, 0);
  private static Unit_ perinchkilogramsecond_ = new Unit_("PerInchKilogramSecond", "/in kg s", 2.56, 0);
  private static Unit_ platformUnit_ = percentimeterkilogramsecond_;
  private static Unit_ displayUnit_ = percentimeterkilogramsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthMassTime other && Equals(other);
  public bool Equals(PerLengthMassTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthMassTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthMassTime other)) throw new ArgumentException("Object is not a PerLengthMassTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthMassTime l1, PerLengthMassTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthMassTime l1, PerLengthMassTime l2) => !(l1 == l2);
  public static bool operator <(PerLengthMassTime l1, PerLengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthMassTime l1, PerLengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthMassTime l1, PerLengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthMassTime l1, PerLengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthMassTime FromPerCentimeterKilogramSeconds(double value, double minValue, double maxValue) => new PerLengthMassTime((value + percentimeterkilogramsecond_.Offset) * percentimeterkilogramsecond_.Factor, minValue * percentimeterkilogramsecond_.Factor, maxValue * percentimeterkilogramsecond_.Factor);
  public static PerLengthMassTime FromPerCentimeterKilogramSeconds(double value) => new PerLengthMassTime((value + percentimeterkilogramsecond_.Offset) * percentimeterkilogramsecond_.Factor);
  public double GetValueInPerCentimeterKilogramSeconds() => (Value_ - percentimeterkilogramsecond_.Offset) / percentimeterkilogramsecond_.Factor;
  public static PerLengthMassTime FromPerMillimeterKilogramSeconds(double value, double minValue, double maxValue) => new PerLengthMassTime((value + permillimeterkilogramsecond_.Offset) * permillimeterkilogramsecond_.Factor, minValue * permillimeterkilogramsecond_.Factor, maxValue * permillimeterkilogramsecond_.Factor);
  public static PerLengthMassTime FromPerMillimeterKilogramSeconds(double value) => new PerLengthMassTime((value + permillimeterkilogramsecond_.Offset) * permillimeterkilogramsecond_.Factor);
  public double GetValueInPerMillimeterKilogramSeconds() => (Value_ - permillimeterkilogramsecond_.Offset) / permillimeterkilogramsecond_.Factor;
  public static PerLengthMassTime FromPerMeterKilogramSeconds(double value, double minValue, double maxValue) => new PerLengthMassTime((value + permeterkilogramsecond_.Offset) * permeterkilogramsecond_.Factor, minValue * permeterkilogramsecond_.Factor, maxValue * permeterkilogramsecond_.Factor);
  public static PerLengthMassTime FromPerMeterKilogramSeconds(double value) => new PerLengthMassTime((value + permeterkilogramsecond_.Offset) * permeterkilogramsecond_.Factor);
  public double GetValueInPerMeterKilogramSeconds() => (Value_ - permeterkilogramsecond_.Offset) / permeterkilogramsecond_.Factor;
  public static PerLengthMassTime FromPerInchKilogramSeconds(double value, double minValue, double maxValue) => new PerLengthMassTime((value + perinchkilogramsecond_.Offset) * perinchkilogramsecond_.Factor, minValue * perinchkilogramsecond_.Factor, maxValue * perinchkilogramsecond_.Factor);
  public static PerLengthMassTime FromPerInchKilogramSeconds(double value) => new PerLengthMassTime((value + perinchkilogramsecond_.Offset) * perinchkilogramsecond_.Factor);
  public double GetValueInPerInchKilogramSeconds() => (Value_ - perinchkilogramsecond_.Offset) / perinchkilogramsecond_.Factor;

#endregion

#region arithmetic
  public static PerLengthMassTime operator+(PerLengthMassTime o1, PerLengthMassTime o2) => new PerLengthMassTime(o1.Value_ + o2.Value_);
  public static PerLengthMassTime operator-(PerLengthMassTime o1, PerLengthMassTime o2) => new PerLengthMassTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthMassTime o1, PerLengthMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(PerLengthMassTime o1, TimePerLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimePerLengthMass o1, PerLengthMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(PerLengthMassTime o1, PerLengthTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerLengthTimeSqr o1, PerLengthMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(PerLengthMassTime o1, PerLengthTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerLengthTimeSqr o1, PerLengthMassTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthMassTime o1, TimeSqrPerLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeSqrPerLength o1, PerLengthMassTime o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(PerLengthMassTime o1, TimeSqrPerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeSqrPerLength o1, PerLengthMassTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(PerLengthMassTime o1, MassPerLengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerLengthTime o1, PerLengthMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(PerLengthMassTime o1, MassTimePerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassTimePerLength o1, PerLengthMassTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(PerLengthMassTime o1, PerMassTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerMassTimeSqr o1, PerLengthMassTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerLengthMassTime o1, TimeSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeSqrPerMass o1, PerLengthMassTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(PerLengthMassTime o1, PerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(PerTimeCub o1, PerLengthMassTime o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerLengthMassTime o1, TimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeCub o1, PerLengthMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(PerLengthMassTime o1, MassPerTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(MassPerTimeSqr o1, PerLengthMassTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(PerLengthMassTime o1, TimeSqrMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqrMass o1, PerLengthMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(PerLengthMassTime o1, LengthPerMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthPerMassTime o1, PerLengthMassTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerLengthMassTime o1, LengthTimePerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthTimePerMass o1, PerLengthMassTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(PerLengthMassTime o1, Acceleration o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(Acceleration o1, PerLengthMassTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(PerLengthMassTime o1, Acceleration o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(Acceleration o1, PerLengthMassTime o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerLengthMassTime o1, TimeSqrLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeSqrLength o1, PerLengthMassTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthMassTime o1, TimeSqrLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeSqrLength o1, PerLengthMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(PerLengthMassTime o1, LengthMassPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthMassPerTime o1, PerLengthMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthMassTime o1, LengthMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthMassTime o1, PerLengthMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(PerLengthMassTime o1, LengthSqrPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthSqrPerMass o1, PerLengthMassTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerLengthMassTime o1, LengthSqrPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthSqrPerTime o1, PerLengthMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(PerLengthMassTime o1, LengthSqrPerTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthSqrPerTime o1, PerLengthMassTime o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerLengthMassTime o1, LengthSqrTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrTime o1, PerLengthMassTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthMassTime o1, LengthSqrTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthSqrTime o1, PerLengthMassTime o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static Speed operator*(PerLengthMassTime o1, LengthSqrMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrMass o1, PerLengthMassTime o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerLengthMassTime o1, Volume o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(Volume o1, PerLengthMassTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(PerLengthMassTime o1, PerMassLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(PerMassLengthCub o1, PerLengthMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerLengthMassTime o1, PerTimeLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(PerTimeLengthCub o1, PerLengthMassTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(PerLengthMassTime o1, TimePerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimePerLengthCub o1, PerLengthMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(PerLengthMassTime o1, PerMassTimeLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerMassTimeLengthSqr o1, PerLengthMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(PerLengthMassTime o1, TimePerMassLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimePerMassLengthSqr o1, PerLengthMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerLengthMassTime o1, PerLengthSqrTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerLengthSqrTimeSqr o1, PerLengthMassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(PerLengthMassTime o1, PerLengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(PerLengthSqrTimeSqr o1, PerLengthMassTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerLengthMassTime o1, TimeSqrPerLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthMassTime o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(PerLengthMassTime o1, TimeSqrPerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeSqrPerLengthSqr o1, PerLengthMassTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerLengthMassTime o1, MassPerTimeLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(MassPerTimeLengthSqr o1, PerLengthMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator*(PerLengthMassTime o1, MassTimePerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(MassTimePerLengthSqr o1, PerLengthMassTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerLengthMassTime o1, PerLengthMassTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerLengthMassTimeSqr o1, PerLengthMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(PerLengthMassTime o1, TimeSqrPerLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrPerLengthMass o1, PerLengthMassTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(PerLengthMassTime o1, PerLengthTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(PerLengthTimeCub o1, PerLengthMassTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(PerLengthMassTime o1, TimeCubPerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeCubPerLength o1, PerLengthMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerLengthMassTime o1, MassPerLengthTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerLengthTimeSqr o1, PerLengthMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(PerLengthMassTime o1, TimeSqrMassPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthMassTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(PerLengthMassTime o1, PerMassTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerMassTimeCub o1, PerLengthMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(PerLengthMassTime o1, TimeCubMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubMass o1, PerLengthMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(PerLengthMassTime o1, LengthPerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthPerMassTimeSqr o1, PerLengthMassTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(PerLengthMassTime o1, TimeSqrLengthPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeSqrLengthPerMass o1, PerLengthMassTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(PerLengthMassTime o1, LengthPerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthPerTimeCub o1, PerLengthMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(PerLengthMassTime o1, TimeCubLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubLength o1, PerLengthMassTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(PerLengthMassTime o1, Force o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(Force o1, PerLengthMassTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerLengthMassTime o1, TimeSqrLengthMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrLengthMass o1, PerLengthMassTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(PerLengthMassTime o1, LengthSqrPerMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrPerMassTime o1, PerLengthMassTime o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(PerLengthMassTime o1, LengthSqrTimePerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthSqrTimePerMass o1, PerLengthMassTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(PerLengthMassTime o1, QDose o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(QDose o1, PerLengthMassTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(PerLengthMassTime o1, QDose o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(QDose o1, PerLengthMassTime o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerLengthMassTime o1, LengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrTimeSqr o1, PerLengthMassTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthMassTime o1, LengthSqrTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthSqrTimeSqr o1, PerLengthMassTime o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(PerLengthMassTime o1, LengthSqrMassPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthSqrMassPerTime o1, PerLengthMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerLengthMassTime o1, LengthSqrMassTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrMassTime o1, PerLengthMassTime o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(PerLengthMassTime o1, LengthCubPerTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthCubPerTime o1, PerLengthMassTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator*(PerLengthMassTime o1, LengthCubTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubTime o1, PerLengthMassTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(PerLengthMassTime o1, LengthCubMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubMass o1, PerLengthMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static Area operator/(PerLengthMassTime o1, PerMassTimeLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(PerLengthMassTime o1, TimePerMassLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimePerMassLengthCub o1, PerLengthMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(PerLengthMassTime o1, PerTimeSqrLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator/(PerLengthMassTime o1, TimeSqrPerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeSqrPerLengthCub o1, PerLengthMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(PerLengthMassTime o1, PerMassLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerMassLengthSqrTimeSqr o1, PerLengthMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(PerLengthMassTime o1, TimeSqrPerMassLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeSqrPerMassLengthSqr o1, PerLengthMassTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(PerLengthMassTime o1, PerLengthSqrTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(PerLengthSqrTimeCub o1, PerLengthMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(PerLengthMassTime o1, TimeCubPerLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthMassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerLengthMassTime o1, MassPerLengthSqrTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(MassPerLengthSqrTimeSqr o1, PerLengthMassTime o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(PerLengthMassTime o1, TimeSqrMassPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthMassTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(PerLengthMassTime o1, PerLengthMassTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerLengthMassTimeCub o1, PerLengthMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerLengthMassTime o1, TimeCubMassPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerLengthMassTime o1, LengthPerMassTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthPerMassTimeCub o1, PerLengthMassTime o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(PerLengthMassTime o1, TimeCubLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubLengthMass o1, PerLengthMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerLengthMassTime o1, LengthSqrPerMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrPerMassTimeSqr o1, PerLengthMassTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerLengthMassTime o1, LengthSqrTimeSqrPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthSqrTimeSqrPerMass o1, PerLengthMassTime o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator/(PerLengthMassTime o1, LengthSqrPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthSqrPerTimeCub o1, PerLengthMassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(PerLengthMassTime o1, TimeCubLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeCubLengthSqr o1, PerLengthMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(PerLengthMassTime o1, LengthSqrMassPerTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerLengthMassTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(PerLengthMassTime o1, LengthSqrTimeSqrMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrTimeSqrMass o1, PerLengthMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(PerLengthMassTime o1, LengthCubPerTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthCubPerTimeSqr o1, PerLengthMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator*(PerLengthMassTime o1, LengthCubTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubTimeSqr o1, PerLengthMassTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static QDose operator*(PerLengthMassTime o1, LengthCubMassPerTime o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubMassPerTime o1, PerLengthMassTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static Area operator*(PerLengthMassTime o1, LengthCubMassTime o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubMassTime o1, PerLengthMassTime o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(PerLengthMassTime o1, PerMassTimeSqrLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(PerLengthMassTime o1, TimeSqrPerMassLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeSqrPerMassLengthCub o1, PerLengthMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(PerLengthMassTime o1, PerLengthCubTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(PerLengthCubTimeCub o1, PerLengthMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(PerLengthMassTime o1, PerMassLengthSqrTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerLengthMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(PerLengthMassTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(PerLengthMassTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthSqrPerMassTimeCub o1, PerLengthMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(PerLengthMassTime o1, TimeCubLengthSqrMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubLengthSqrMass o1, PerLengthMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(PerLengthMassTime o1, LengthCubTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubTimeCub o1, PerLengthMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(PerLengthMassTime o1, LengthCubMassPerTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerLengthMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(PerLengthMassTime o1, LengthCubTimeSqrMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubTimeSqrMass o1, PerLengthMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator/(PerLengthMassTime o1, PerMassLengthCubTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerMassLengthCubTimeCub o1, PerLengthMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(PerLengthMassTime o1, LengthCubTimeCubMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubTimeCubMass o1, PerLengthMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthMassTime is outside its bounds.");
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
    