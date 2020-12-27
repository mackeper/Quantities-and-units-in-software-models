
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassLengthSqr : Quantity, IEquatable<PerMassLengthSqr>, IComparable
  {  
    internal PerMassLengthSqr(double value) : base(value, 2)
    {
      PerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassLengthSqr(PerMassLengthSqr other) : base(other)
    {
      PerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthSqr"))
    {
      switch(FakeDatabase.Units["PerMassLengthSqr"])
      {
        case "perkilogramcentimetersqr": displayUnit_ = perkilogramcentimetersqr_; break;
        case "perkilogrammillimetersqr": displayUnit_ = perkilogrammillimetersqr_; break;
        case "perkilogrammetersqr": displayUnit_ = perkilogrammetersqr_; break;
        case "perkilograminchsqr": displayUnit_ = perkilograminchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramcentimetersqr_ = new Unit_("PerKilogramCentimeterSqr", "/kg cm²", 1.0, 0);
  private static Unit_ perkilogrammillimetersqr_ = new Unit_("PerKilogramMillimeterSqr", "/kg mm²", 99.99999999999999, 0);
  private static Unit_ perkilogrammetersqr_ = new Unit_("PerKilogramMeterSqr", "/kg m²", 0.0001, 0);
  private static Unit_ perkilograminchsqr_ = new Unit_("PerKilogramInchSqr", "/kg in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = perkilogramcentimetersqr_;
  private static Unit_ displayUnit_ = perkilogramcentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassLengthSqr other && Equals(other);
  public bool Equals(PerMassLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassLengthSqr other)) throw new ArgumentException("Object is not a PerMassLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassLengthSqr l1, PerMassLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassLengthSqr l1, PerMassLengthSqr l2) => !(l1 == l2);
  public static bool operator <(PerMassLengthSqr l1, PerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassLengthSqr l1, PerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassLengthSqr l1, PerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassLengthSqr l1, PerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassLengthSqr FromPerKilogramCentimeterSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqr((value + perkilogramcentimetersqr_.Offset) * perkilogramcentimetersqr_.Factor, minValue * perkilogramcentimetersqr_.Factor, maxValue * perkilogramcentimetersqr_.Factor);
  public static PerMassLengthSqr FromPerKilogramCentimeterSqrs(double value) => new PerMassLengthSqr((value + perkilogramcentimetersqr_.Offset) * perkilogramcentimetersqr_.Factor);
  public double GetValueInPerKilogramCentimeterSqrs() => (Value_ - perkilogramcentimetersqr_.Offset) / perkilogramcentimetersqr_.Factor;
  public static PerMassLengthSqr FromPerKilogramMillimeterSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqr((value + perkilogrammillimetersqr_.Offset) * perkilogrammillimetersqr_.Factor, minValue * perkilogrammillimetersqr_.Factor, maxValue * perkilogrammillimetersqr_.Factor);
  public static PerMassLengthSqr FromPerKilogramMillimeterSqrs(double value) => new PerMassLengthSqr((value + perkilogrammillimetersqr_.Offset) * perkilogrammillimetersqr_.Factor);
  public double GetValueInPerKilogramMillimeterSqrs() => (Value_ - perkilogrammillimetersqr_.Offset) / perkilogrammillimetersqr_.Factor;
  public static PerMassLengthSqr FromPerKilogramMeterSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqr((value + perkilogrammetersqr_.Offset) * perkilogrammetersqr_.Factor, minValue * perkilogrammetersqr_.Factor, maxValue * perkilogrammetersqr_.Factor);
  public static PerMassLengthSqr FromPerKilogramMeterSqrs(double value) => new PerMassLengthSqr((value + perkilogrammetersqr_.Offset) * perkilogrammetersqr_.Factor);
  public double GetValueInPerKilogramMeterSqrs() => (Value_ - perkilogrammetersqr_.Offset) / perkilogrammetersqr_.Factor;
  public static PerMassLengthSqr FromPerKilogramInchSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqr((value + perkilograminchsqr_.Offset) * perkilograminchsqr_.Factor, minValue * perkilograminchsqr_.Factor, maxValue * perkilograminchsqr_.Factor);
  public static PerMassLengthSqr FromPerKilogramInchSqrs(double value) => new PerMassLengthSqr((value + perkilograminchsqr_.Offset) * perkilograminchsqr_.Factor);
  public double GetValueInPerKilogramInchSqrs() => (Value_ - perkilograminchsqr_.Offset) / perkilograminchsqr_.Factor;

#endregion

#region arithmetic
  public static PerMassLengthSqr operator+(PerMassLengthSqr o1, PerMassLengthSqr o2) => new PerMassLengthSqr(o1.Value_ + o2.Value_);
  public static PerMassLengthSqr operator-(PerMassLengthSqr o1, PerMassLengthSqr o2) => new PerMassLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassLengthSqr o1, PerMassLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerMassLengthSqr o1, PerTimeLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerTimeLengthSqr o1, PerMassLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(PerMassLengthSqr o1, TimePerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimePerLengthSqr o1, PerMassLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(PerMassLengthSqr o1, PerLengthMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerLengthMassTime o1, PerMassLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(PerMassLengthSqr o1, TimePerLengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimePerLengthMass o1, PerMassLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(PerMassLengthSqr o1, PerLengthTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerLengthTimeSqr o1, PerMassLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(PerMassLengthSqr o1, PerLengthTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(PerLengthTimeSqr o1, PerMassLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(PerMassLengthSqr o1, TimeSqrPerLength o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeSqrPerLength o1, PerMassLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeSqrPerLength o1, PerMassLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(PerMassLengthSqr o1, MassPerLengthTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassPerLengthTime o1, PerMassLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(PerMassLengthSqr o1, MassTimePerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(MassTimePerLength o1, PerMassLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerMassLengthSqr o1, PerMassTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(PerMassTimeSqr o1, PerMassLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeSqrPerMass o1, PerMassLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(PerMassLengthSqr o1, PerTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerTimeCub o1, PerMassLengthSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(PerMassLengthSqr o1, PerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(PerTimeCub o1, PerMassLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(PerMassLengthSqr o1, TimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCub o1, PerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassLengthSqr o1, TimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeCub o1, PerMassLengthSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(PerMassLengthSqr o1, MassPerTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerTimeSqr o1, PerMassLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerMassLengthSqr o1, TimeSqrMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrMass o1, PerMassLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerMassLengthSqr o1, LengthPerMassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthPerMassTime o1, PerMassLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(PerMassLengthSqr o1, LengthTimePerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthTimePerMass o1, PerMassLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(PerMassLengthSqr o1, Acceleration o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(Acceleration o1, PerMassLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(PerMassLengthSqr o1, Acceleration o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(Acceleration o1, PerMassLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerMassLengthSqr o1, TimeSqrLength o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrLength o1, PerMassLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerMassLengthSqr o1, TimeSqrLength o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeSqrLength o1, PerMassLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(PerMassLengthSqr o1, LengthMassPerTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthMassPerTime o1, PerMassLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(PerMassLengthSqr o1, LengthMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(LengthMassTime o1, PerMassLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(PerMassLengthSqr o1, LengthSqrPerTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrPerTime o1, PerMassLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(PerMassLengthSqr o1, LengthSqrTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthSqrTime o1, PerMassLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerMassLengthSqr o1, LengthSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrMass o1, PerMassLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(PerMassLengthSqr o1, Volume o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(Volume o1, PerMassLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Length operator/(PerMassLengthSqr o1, PerMassLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerMassLengthCub o1, PerMassLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(PerMassLengthSqr o1, PerTimeLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(PerTimeLengthCub o1, PerMassLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(PerMassLengthSqr o1, TimePerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimePerLengthCub o1, PerMassLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static Time operator/(PerMassLengthSqr o1, PerMassTimeLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerMassTimeLengthSqr o1, PerMassLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(PerMassLengthSqr o1, TimePerMassLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimePerMassLengthSqr o1, PerMassLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(PerMassLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(PerLengthSqrTimeSqr o1, PerMassLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrPerLengthSqr o1, PerMassLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(PerMassLengthSqr o1, PerLengthMassTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerLengthMassTimeSqr o1, PerMassLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrPerLengthMass o1, PerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerMassLengthSqr o1, PerLengthTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerLengthTimeCub o1, PerMassLengthSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(PerMassLengthSqr o1, PerLengthTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(PerLengthTimeCub o1, PerMassLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(PerMassLengthSqr o1, TimeCubPerLength o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeCubPerLength o1, PerMassLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassLengthSqr o1, TimeCubPerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCubPerLength o1, PerMassLengthSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerMassLengthSqr o1, MassPerLengthTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(MassPerLengthTimeSqr o1, PerMassLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(PerMassLengthSqr o1, TimeSqrMassPerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeSqrMassPerLength o1, PerMassLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(PerMassLengthSqr o1, PerMassTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(PerMassTimeCub o1, PerMassLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(PerMassLengthSqr o1, TimeCubPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubPerMass o1, PerMassLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerMassLengthSqr o1, MassPerTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerTimeCub o1, PerMassLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(PerMassLengthSqr o1, TimeCubMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubMass o1, PerMassLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(PerMassLengthSqr o1, LengthPerMassTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthPerMassTimeSqr o1, PerMassLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(PerMassLengthSqr o1, TimeSqrLengthPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeSqrLengthPerMass o1, PerMassLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(PerMassLengthSqr o1, LengthPerTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(LengthPerTimeCub o1, PerMassLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(PerMassLengthSqr o1, LengthPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthPerTimeCub o1, PerMassLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(PerMassLengthSqr o1, TimeCubLength o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubLength o1, PerMassLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassLengthSqr o1, TimeCubLength o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(TimeCubLength o1, PerMassLengthSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(PerMassLengthSqr o1, Force o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(Force o1, PerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(PerMassLengthSqr o1, TimeSqrLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrLengthMass o1, PerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(PerMassLengthSqr o1, QDose o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(QDose o1, PerMassLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(PerMassLengthSqr o1, LengthSqrTimeSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthSqrTimeSqr o1, PerMassLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(PerMassLengthSqr o1, LengthSqrMassPerTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrMassPerTime o1, PerMassLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerMassLengthSqr o1, LengthSqrMassTime o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthSqrMassTime o1, PerMassLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(PerMassLengthSqr o1, LengthCubPerTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubPerTime o1, PerMassLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(PerMassLengthSqr o1, LengthCubTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthCubTime o1, PerMassLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerMassLengthSqr o1, LengthCubMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubMass o1, PerMassLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthTime operator/(PerMassLengthSqr o1, PerMassTimeLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerMassTimeLengthCub o1, PerMassLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static Speed operator/(PerMassLengthSqr o1, TimePerMassLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimePerMassLengthCub o1, PerMassLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(PerMassLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(PerTimeSqrLengthCub o1, PerMassLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrPerLengthCub o1, PerMassLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(PerMassLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerMassLengthSqrTimeSqr o1, PerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(PerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrPerMassLengthSqr o1, PerMassLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(PerMassLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(PerLengthSqrTimeCub o1, PerMassLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(PerMassLengthSqr o1, TimeCubPerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubPerLengthSqr o1, PerMassLengthSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(PerMassLengthSqr o1, PerLengthMassTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthMassTimeCub o1, PerMassLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerMassLengthSqr o1, TimeCubPerLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubPerLengthMass o1, PerMassLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerMassLengthSqr o1, MassPerLengthTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(MassPerLengthTimeCub o1, PerMassLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(PerMassLengthSqr o1, TimeCubMassPerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCubMassPerLength o1, PerMassLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(PerMassLengthSqr o1, LengthPerMassTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthPerMassTimeCub o1, PerMassLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerMassLengthSqr o1, TimeCubLengthPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(TimeCubLengthPerMass o1, PerMassLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(PerMassLengthSqr o1, LengthMassPerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(LengthMassPerTimeCub o1, PerMassLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(PerMassLengthSqr o1, TimeCubLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubLengthMass o1, PerMassLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(PerMassLengthSqr o1, LengthSqrPerTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthSqrPerTimeCub o1, PerMassLengthSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(PerMassLengthSqr o1, TimeCubLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubLengthSqr o1, PerMassLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(PerMassLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrMassPerTimeSqr o1, PerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(PerMassLengthSqr o1, LengthSqrTimeSqrMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthSqrTimeSqrMass o1, PerMassLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerMassLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthCubPerTimeSqr o1, PerMassLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(PerMassLengthSqr o1, LengthCubTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthCubTimeSqr o1, PerMassLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerMassLengthSqr o1, LengthCubMassPerTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubMassPerTime o1, PerMassLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(PerMassLengthSqr o1, LengthCubMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubMassTime o1, PerMassLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(PerMassLengthSqr o1, PerMassTimeSqrLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(PerMassLengthSqr o1, TimeSqrPerMassLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrPerMassLengthCub o1, PerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(PerMassLengthSqr o1, PerLengthCubTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(PerLengthCubTimeCub o1, PerMassLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator/(PerMassLengthSqr o1, TimeCubPerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubPerLengthCub o1, PerMassLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(PerMassLengthSqr o1, PerMassLengthSqrTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerMassLengthSqrTimeCub o1, PerMassLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(PerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubPerMassLengthSqr o1, PerMassLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(PerMassLengthSqr o1, LengthSqrMassPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthSqrMassPerTimeCub o1, PerMassLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(PerMassLengthSqr o1, TimeCubLengthSqrMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubLengthSqrMass o1, PerMassLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(PerMassLengthSqr o1, LengthCubPerTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(LengthCubPerTimeCub o1, PerMassLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(PerMassLengthSqr o1, LengthCubTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthCubTimeCub o1, PerMassLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(PerMassLengthSqr o1, LengthCubMassPerTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubMassPerTimeSqr o1, PerMassLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(PerMassLengthSqr o1, LengthCubTimeSqrMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubTimeSqrMass o1, PerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(PerMassLengthSqr o1, PerMassLengthCubTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerMassLengthCubTimeCub o1, PerMassLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(PerMassLengthSqr o1, TimeCubPerMassLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubPerMassLengthCub o1, PerMassLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(PerMassLengthSqr o1, LengthCubMassPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthCubMassPerTimeCub o1, PerMassLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(PerMassLengthSqr o1, LengthCubTimeCubMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTimeCubMass o1, PerMassLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassLengthSqr is outside its bounds.");
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
    