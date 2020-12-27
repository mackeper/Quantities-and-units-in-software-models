
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassTimeSqr : Quantity, IEquatable<PerMassTimeSqr>, IComparable
  {  
    internal PerMassTimeSqr(double value) : base(value, 2)
    {
      PerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassTimeSqr(PerMassTimeSqr other) : base(other)
    {
      PerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeSqr"))
    {
      switch(FakeDatabase.Units["PerMassTimeSqr"])
      {
        case "perkilogramsecondsqr": displayUnit_ = perkilogramsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramsecondsqr_ = new Unit_("PerKilogramSecondSqr", "/kg s²", 1.0, 0);
  private static Unit_ platformUnit_ = perkilogramsecondsqr_;
  private static Unit_ displayUnit_ = perkilogramsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassTimeSqr other && Equals(other);
  public bool Equals(PerMassTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassTimeSqr other)) throw new ArgumentException("Object is not a PerMassTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassTimeSqr l1, PerMassTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassTimeSqr l1, PerMassTimeSqr l2) => !(l1 == l2);
  public static bool operator <(PerMassTimeSqr l1, PerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassTimeSqr l1, PerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassTimeSqr l1, PerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassTimeSqr l1, PerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassTimeSqr FromPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerMassTimeSqr((value + perkilogramsecondsqr_.Offset) * perkilogramsecondsqr_.Factor, minValue * perkilogramsecondsqr_.Factor, maxValue * perkilogramsecondsqr_.Factor);
  public static PerMassTimeSqr FromPerKilogramSecondSqrs(double value) => new PerMassTimeSqr((value + perkilogramsecondsqr_.Offset) * perkilogramsecondsqr_.Factor);
  public double GetValueInPerKilogramSecondSqrs() => (Value_ - perkilogramsecondsqr_.Offset) / perkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
  public static PerMassTimeSqr operator+(PerMassTimeSqr o1, PerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ + o2.Value_);
  public static PerMassTimeSqr operator-(PerMassTimeSqr o1, PerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassTimeSqr o1, PerMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerMassTimeSqr o1, PerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerTimeCub o1, PerMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerMassTimeSqr o1, TimeCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeCub o1, PerMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerMassTimeSqr o1, TimeSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeSqrMass o1, PerMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(PerMassTimeSqr o1, LengthPerMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthPerMassTime o1, PerMassTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerMassTimeSqr o1, LengthTimePerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthTimePerMass o1, PerMassTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(PerMassTimeSqr o1, Acceleration o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(Acceleration o1, PerMassTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerMassTimeSqr o1, TimeSqrLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(TimeSqrLength o1, PerMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(PerMassTimeSqr o1, LengthMassPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthMassPerTime o1, PerMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerMassTimeSqr o1, LengthMassTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthMassTime o1, PerMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerMassTimeSqr o1, LengthSqrPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthSqrPerMass o1, PerMassTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(PerMassTimeSqr o1, LengthSqrPerTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthSqrPerTime o1, PerMassTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerMassTimeSqr o1, LengthSqrPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthSqrPerTime o1, PerMassTimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerMassTimeSqr o1, LengthSqrTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthSqrTime o1, PerMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassTimeSqr o1, LengthSqrTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthSqrTime o1, PerMassTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(PerMassTimeSqr o1, LengthSqrMass o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthSqrMass o1, PerMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(PerMassTimeSqr o1, Volume o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(Volume o1, PerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerMassTimeSqr o1, Volume o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(Volume o1, PerMassTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(PerMassTimeSqr o1, PerMassLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(PerMassLengthCub o1, PerMassTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerMassTimeSqr o1, PerTimeLengthCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerTimeLengthCub o1, PerMassTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(PerMassTimeSqr o1, PerTimeLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(PerTimeLengthCub o1, PerMassTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(PerMassTimeSqr o1, TimePerLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(TimePerLengthCub o1, PerMassTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(PerMassTimeSqr o1, TimePerLengthCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimePerLengthCub o1, PerMassTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerMassTimeSqr o1, Density o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(Density o1, PerMassTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(PerMassTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(PerMassTimeLengthSqr o1, PerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(PerMassTimeSqr o1, TimePerMassLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimePerMassLengthSqr o1, PerMassTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerMassTimeSqr o1, PerLengthSqrTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(PerLengthSqrTimeSqr o1, PerMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(PerMassTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeSqrPerLengthSqr o1, PerMassTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerMassTimeSqr o1, MassPerTimeLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerTimeLengthSqr o1, PerMassTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(PerMassTimeSqr o1, MassTimePerLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassTimePerLengthSqr o1, PerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static Length operator/(PerMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerLengthMassTimeSqr o1, PerMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(PerMassTimeSqr o1, PerLengthTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(PerLengthTimeCub o1, PerMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(PerMassTimeSqr o1, TimeCubPerLength o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeCubPerLength o1, PerMassTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(PerMassTimeSqr o1, TimeSqrMassPerLength o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrMassPerLength o1, PerMassTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerMassTimeSqr o1, PerMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerMassTimeCub o1, PerMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(PerMassTimeSqr o1, TimeCubMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubMass o1, PerMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(PerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthPerMassTimeSqr o1, PerMassTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(PerMassTimeSqr o1, LengthPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthPerTimeCub o1, PerMassTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerMassTimeSqr o1, TimeCubLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimeCubLength o1, PerMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerMassTimeSqr o1, TimeSqrLengthMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(TimeSqrLengthMass o1, PerMassTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(PerMassTimeSqr o1, LengthSqrPerMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthSqrPerMassTime o1, PerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(PerMassTimeSqr o1, LengthSqrTimePerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthSqrTimePerMass o1, PerMassTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(PerMassTimeSqr o1, QDose o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(QDose o1, PerMassTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(PerMassTimeSqr o1, LengthSqrTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthSqrTimeSqr o1, PerMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(PerMassTimeSqr o1, LengthSqrMassPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthSqrMassPerTime o1, PerMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(PerMassTimeSqr o1, LengthSqrMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthSqrMassTime o1, PerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(PerMassTimeSqr o1, LengthCubPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthCubPerMass o1, PerMassTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(PerMassTimeSqr o1, LengthCubPerTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthCubPerTime o1, PerMassTimeSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(PerMassTimeSqr o1, LengthCubPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthCubPerTime o1, PerMassTimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(PerMassTimeSqr o1, LengthCubTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthCubTime o1, PerMassTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassTimeSqr o1, LengthCubTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthCubTime o1, PerMassTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(PerMassTimeSqr o1, LengthCubMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthCubMass o1, PerMassTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator/(PerMassTimeSqr o1, PerMassTimeLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(PerMassTimeLengthCub o1, PerMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(PerMassTimeSqr o1, TimePerMassLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimePerMassLengthCub o1, PerMassTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator/(PerMassTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(PerTimeSqrLengthCub o1, PerMassTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(PerMassTimeSqr o1, TimeSqrPerLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(TimeSqrPerLengthCub o1, PerMassTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerMassTimeSqr o1, MassPerTimeLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(MassPerTimeLengthCub o1, PerMassTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator*(PerMassTimeSqr o1, MassTimePerLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassTimePerLengthCub o1, PerMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static Area operator/(PerMassTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerMassLengthSqrTimeSqr o1, PerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(PerMassTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(PerLengthSqrTimeCub o1, PerMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerMassTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeCubPerLengthSqr o1, PerMassTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(PerMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeSqrMassPerLengthSqr o1, PerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthTime operator/(PerMassTimeSqr o1, PerLengthMassTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerLengthMassTimeCub o1, PerMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(PerMassTimeSqr o1, TimeCubMassPerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubMassPerLength o1, PerMassTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(PerMassTimeSqr o1, LengthPerMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthPerMassTimeCub o1, PerMassTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(PerMassTimeSqr o1, TimeCubLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(TimeCubLengthMass o1, PerMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(PerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthSqrPerMassTimeSqr o1, PerMassTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(PerMassTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthSqrPerTimeCub o1, PerMassTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(PerMassTimeSqr o1, TimeCubLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(TimeCubLengthSqr o1, PerMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(PerMassTimeSqr o1, LengthSqrTimeSqrMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrTimeSqrMass o1, PerMassTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(PerMassTimeSqr o1, LengthCubPerMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthCubPerMassTime o1, PerMassTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerMassTimeSqr o1, LengthCubTimePerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthCubTimePerMass o1, PerMassTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator/(PerMassTimeSqr o1, LengthCubPerTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthCubPerTimeSqr o1, PerMassTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(PerMassTimeSqr o1, LengthCubTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthCubTimeSqr o1, PerMassTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeCub operator*(PerMassTimeSqr o1, LengthCubMassPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthCubMassPerTime o1, PerMassTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator*(PerMassTimeSqr o1, LengthCubMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthCubMassTime o1, PerMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static Volume operator/(PerMassTimeSqr o1, PerMassTimeSqrLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassTimeSqrLengthCub o1, PerMassTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator/(PerMassTimeSqr o1, PerLengthCubTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(PerLengthCubTimeCub o1, PerMassTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerMassTimeSqr o1, TimeCubPerLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimeCubPerLengthCub o1, PerMassTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator*(PerMassTimeSqr o1, TimeSqrMassPerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimeSqrMassPerLengthCub o1, PerMassTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(PerMassTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerMassLengthSqrTimeCub o1, PerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(PerMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubMassPerLengthSqr o1, PerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(PerMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrPerMassTimeCub o1, PerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(PerMassTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(TimeCubLengthSqrMass o1, PerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(PerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubPerMassTimeSqr o1, PerMassTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator/(PerMassTimeSqr o1, LengthCubPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthCubPerTimeCub o1, PerMassTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(PerMassTimeSqr o1, LengthCubTimeCub o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthCubTimeCub o1, PerMassTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  
  public static Volume operator*(PerMassTimeSqr o1, LengthCubTimeSqrMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubTimeSqrMass o1, PerMassTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(PerMassTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerMassLengthCubTimeCub o1, PerMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(PerMassTimeSqr o1, TimeCubMassPerLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeCubMassPerLengthCub o1, PerMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerMassTimeSqr o1, LengthCubPerMassTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubPerMassTimeCub o1, PerMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(PerMassTimeSqr o1, LengthCubTimeCubMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubTimeCubMass o1, PerMassTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassTimeSqr is outside its bounds.");
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
    