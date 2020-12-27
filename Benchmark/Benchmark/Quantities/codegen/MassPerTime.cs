
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerTime : Quantity, IEquatable<MassPerTime>, IComparable
  {  
    internal MassPerTime(double value) : base(value, 2)
    {
      MassPerTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerTime(MassPerTime other) : base(other)
    {
      MassPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerTime"))
    {
      switch(FakeDatabase.Units["MassPerTime"])
      {
        case "kilogrampersecond": displayUnit_ = kilogrampersecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampersecond_ = new Unit_("KilogramPerSecond", "kg/s", 1.0, 0);
  private static Unit_ platformUnit_ = kilogrampersecond_;
  private static Unit_ displayUnit_ = kilogrampersecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerTime other && Equals(other);
  public bool Equals(MassPerTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerTime other)) throw new ArgumentException("Object is not a MassPerTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerTime l1, MassPerTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerTime l1, MassPerTime l2) => !(l1 == l2);
  public static bool operator <(MassPerTime l1, MassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerTime l1, MassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerTime l1, MassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerTime l1, MassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerTime FromKilogramPerSeconds(double value, double minValue, double maxValue) => new MassPerTime((value + kilogrampersecond_.Offset) * kilogrampersecond_.Factor, minValue * kilogrampersecond_.Factor, maxValue * kilogrampersecond_.Factor);
  public static MassPerTime FromKilogramPerSeconds(double value) => new MassPerTime((value + kilogrampersecond_.Offset) * kilogrampersecond_.Factor);
  public double GetValueInKilogramPerSeconds() => (Value_ - kilogrampersecond_.Offset) / kilogrampersecond_.Factor;

#endregion

#region arithmetic
  public static MassPerTime operator+(MassPerTime o1, MassPerTime o2) => new MassPerTime(o1.Value_ + o2.Value_);
  public static MassPerTime operator-(MassPerTime o1, MassPerTime o2) => new MassPerTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerTime o1, MassPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(MassPerTime o1, MassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(MassTime o1, MassPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static Speed operator*(MassPerTime o1, LengthPerMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthPerMass o1, MassPerTime o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Force operator*(MassPerTime o1, Speed o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(Speed o1, MassPerTime o2) => new Force(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(MassPerTime o1, Speed o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(Speed o1, MassPerTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(MassPerTime o1, LengthTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthTime o1, MassPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerTime o1, LengthTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthTime o1, MassPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(MassPerTime o1, LengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthMass o1, MassPerTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(MassPerTime o1, Area o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(Area o1, MassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassPerTime o1, Area o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(Area o1, MassPerTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(MassPerTime o1, PerLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(PerLengthCub o1, MassPerTime o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(MassPerTime o1, PerLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(PerLengthCub o1, MassPerTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(MassPerTime o1, PerMassLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerMassLengthSqr o1, MassPerTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(MassPerTime o1, PerTimeLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(PerTimeLengthSqr o1, MassPerTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator/(MassPerTime o1, PerTimeLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerTimeLengthSqr o1, MassPerTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(MassPerTime o1, TimePerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(TimePerLengthSqr o1, MassPerTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(MassPerTime o1, TimePerLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimePerLengthSqr o1, MassPerTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(MassPerTime o1, MassPerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(MassPerLengthSqr o1, MassPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(MassPerTime o1, PerLengthMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthMassTime o1, MassPerTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(MassPerTime o1, TimePerLengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimePerLengthMass o1, MassPerTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(MassPerTime o1, PerLengthTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(PerLengthTimeSqr o1, MassPerTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(MassPerTime o1, PerLengthTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerLengthTimeSqr o1, MassPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(MassPerTime o1, TimeSqrPerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeSqrPerLength o1, MassPerTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(MassPerTime o1, TimeSqrPerLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeSqrPerLength o1, MassPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(MassPerTime o1, MassPerLengthTime o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerLengthTime o1, MassPerTime o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(MassPerTime o1, MassTimePerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(MassTimePerLength o1, MassPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(MassPerTime o1, PerMassTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerMassTimeSqr o1, MassPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(MassPerTime o1, TimeSqrPerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrPerMass o1, MassPerTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator/(MassPerTime o1, PerTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerTimeCub o1, MassPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(MassPerTime o1, TimeCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeCub o1, MassPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static Time operator/(MassPerTime o1, MassPerTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerTimeSqr o1, MassPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(MassPerTime o1, TimeSqrMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrMass o1, MassPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(MassPerTime o1, LengthPerMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthPerMassTime o1, MassPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Length operator*(MassPerTime o1, LengthTimePerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthTimePerMass o1, MassPerTime o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(MassPerTime o1, Acceleration o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(Acceleration o1, MassPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(MassPerTime o1, Acceleration o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(Acceleration o1, MassPerTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(MassPerTime o1, TimeSqrLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(TimeSqrLength o1, MassPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTime o1, TimeSqrLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeSqrLength o1, MassPerTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(MassPerTime o1, LengthMassPerTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthMassPerTime o1, MassPerTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(MassPerTime o1, LengthMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthMassTime o1, MassPerTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(MassPerTime o1, LengthSqrPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthSqrPerMass o1, MassPerTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(MassPerTime o1, LengthSqrPerTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthSqrPerTime o1, MassPerTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator/(MassPerTime o1, LengthSqrPerTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthSqrPerTime o1, MassPerTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(MassPerTime o1, LengthSqrTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthSqrTime o1, MassPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerTime o1, LengthSqrTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthSqrTime o1, MassPerTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(MassPerTime o1, LengthSqrMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthSqrMass o1, MassPerTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(MassPerTime o1, Volume o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(Volume o1, MassPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerTime o1, Volume o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(Volume o1, MassPerTime o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(MassPerTime o1, PerMassLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerMassLengthCub o1, MassPerTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(MassPerTime o1, PerTimeLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(PerTimeLengthCub o1, MassPerTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMass operator/(MassPerTime o1, PerTimeLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerTimeLengthCub o1, MassPerTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Density operator*(MassPerTime o1, TimePerLengthCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(TimePerLengthCub o1, MassPerTime o2) => new Density(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(MassPerTime o1, TimePerLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimePerLengthCub o1, MassPerTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(MassPerTime o1, Density o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(Density o1, MassPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(MassPerTime o1, PerMassTimeLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassTimeLengthSqr o1, MassPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(MassPerTime o1, TimePerMassLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimePerMassLengthSqr o1, MassPerTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(MassPerTime o1, PerLengthSqrTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(PerLengthSqrTimeSqr o1, MassPerTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator/(MassPerTime o1, PerLengthSqrTimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthSqrTimeSqr o1, MassPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(MassPerTime o1, TimeSqrPerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimeSqrPerLengthSqr o1, MassPerTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(MassPerTime o1, TimeSqrPerLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeSqrPerLengthSqr o1, MassPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(MassPerTime o1, MassPerTimeLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(MassPerTimeLengthSqr o1, MassPerTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(MassPerTime o1, MassTimePerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(MassTimePerLengthSqr o1, MassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(MassPerTime o1, PerLengthMassTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerLengthMassTimeSqr o1, MassPerTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(MassPerTime o1, TimeSqrPerLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqrPerLengthMass o1, MassPerTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(MassPerTime o1, PerLengthTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthTimeCub o1, MassPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(MassPerTime o1, TimeCubPerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeCubPerLength o1, MassPerTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static LengthTime operator/(MassPerTime o1, MassPerLengthTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerLengthTimeSqr o1, MassPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(MassPerTime o1, TimeSqrMassPerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeSqrMassPerLength o1, MassPerTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(MassPerTime o1, TimeCubPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubPerMass o1, MassPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(MassPerTime o1, MassPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(MassPerTimeCub o1, MassPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(MassPerTime o1, LengthPerMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthPerMassTimeSqr o1, MassPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(MassPerTime o1, TimeSqrLengthPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(TimeSqrLengthPerMass o1, MassPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator/(MassPerTime o1, LengthPerTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthPerTimeCub o1, MassPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(MassPerTime o1, TimeCubLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeCubLength o1, MassPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(MassPerTime o1, Force o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(Force o1, MassPerTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(MassPerTime o1, TimeSqrLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeSqrLengthMass o1, MassPerTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static QDose operator*(MassPerTime o1, LengthSqrPerMassTime o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthSqrPerMassTime o1, MassPerTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static Area operator*(MassPerTime o1, LengthSqrTimePerMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrTimePerMass o1, MassPerTime o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(MassPerTime o1, QDose o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(QDose o1, MassPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(MassPerTime o1, QDose o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(QDose o1, MassPerTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(MassPerTime o1, LengthSqrTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthSqrTimeSqr o1, MassPerTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerTime o1, LengthSqrTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthSqrTimeSqr o1, MassPerTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(MassPerTime o1, LengthSqrMassPerTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthSqrMassPerTime o1, MassPerTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(MassPerTime o1, LengthSqrMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthSqrMassTime o1, MassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(MassPerTime o1, LengthCubPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthCubPerMass o1, MassPerTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(MassPerTime o1, LengthCubPerTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthCubPerTime o1, MassPerTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static Density operator/(MassPerTime o1, LengthCubPerTime o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthCubPerTime o1, MassPerTime o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(MassPerTime o1, LengthCubTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthCubTime o1, MassPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerTime o1, LengthCubTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthCubTime o1, MassPerTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(MassPerTime o1, LengthCubMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthCubMass o1, MassPerTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(MassPerTime o1, PerMassTimeLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerMassTimeLengthCub o1, MassPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator*(MassPerTime o1, TimePerMassLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimePerMassLengthCub o1, MassPerTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(MassPerTime o1, PerTimeSqrLengthCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(PerTimeSqrLengthCub o1, MassPerTime o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(MassPerTime o1, PerTimeSqrLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerTimeSqrLengthCub o1, MassPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(MassPerTime o1, TimeSqrPerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(TimeSqrPerLengthCub o1, MassPerTime o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(MassPerTime o1, TimeSqrPerLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeSqrPerLengthCub o1, MassPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(MassPerTime o1, MassPerTimeLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(MassPerTimeLengthCub o1, MassPerTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(MassPerTime o1, MassTimePerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(MassTimePerLengthCub o1, MassPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(MassPerTime o1, PerMassLengthSqrTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerMassLengthSqrTimeSqr o1, MassPerTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(MassPerTime o1, TimeSqrPerMassLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeSqrPerMassLengthSqr o1, MassPerTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(MassPerTime o1, PerLengthSqrTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthSqrTimeCub o1, MassPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(MassPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeCubPerLengthSqr o1, MassPerTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(MassPerTime o1, MassPerLengthSqrTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(MassPerLengthSqrTimeSqr o1, MassPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(MassPerTime o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, MassPerTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(MassPerTime o1, TimeCubPerLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubPerLengthMass o1, MassPerTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(MassPerTime o1, MassPerLengthTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerLengthTimeCub o1, MassPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(MassPerTime o1, TimeCubLengthPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubLengthPerMass o1, MassPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(MassPerTime o1, LengthMassPerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthMassPerTimeCub o1, MassPerTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(MassPerTime o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthSqrPerMassTimeSqr o1, MassPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(MassPerTime o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthSqrTimeSqrPerMass o1, MassPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(MassPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthSqrPerTimeCub o1, MassPerTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(MassPerTime o1, TimeCubLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeCubLengthSqr o1, MassPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(MassPerTime o1, LengthSqrMassPerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrMassPerTimeSqr o1, MassPerTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(MassPerTime o1, LengthSqrTimeSqrMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthSqrTimeSqrMass o1, MassPerTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(MassPerTime o1, LengthCubPerMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthCubPerMassTime o1, MassPerTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator*(MassPerTime o1, LengthCubTimePerMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubTimePerMass o1, MassPerTime o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(MassPerTime o1, LengthCubPerTimeSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthCubPerTimeSqr o1, MassPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(MassPerTime o1, LengthCubPerTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthCubPerTimeSqr o1, MassPerTime o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(MassPerTime o1, LengthCubTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthCubTimeSqr o1, MassPerTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerTime o1, LengthCubTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthCubTimeSqr o1, MassPerTime o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator/(MassPerTime o1, LengthCubMassPerTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubMassPerTime o1, MassPerTime o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(MassPerTime o1, LengthCubMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthCubMassTime o1, MassPerTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(MassPerTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerMassTimeSqrLengthCub o1, MassPerTime o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(MassPerTime o1, TimeSqrPerMassLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeSqrPerMassLengthCub o1, MassPerTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrMass operator/(MassPerTime o1, PerLengthCubTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthCubTimeCub o1, MassPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(MassPerTime o1, TimeCubPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeCubPerLengthCub o1, MassPerTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(MassPerTime o1, MassPerTimeSqrLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(MassPerTimeSqrLengthCub o1, MassPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(MassPerTime o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeSqrMassPerLengthCub o1, MassPerTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(MassPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubPerMassLengthSqr o1, MassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator/(MassPerTime o1, MassPerLengthSqrTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(MassPerLengthSqrTimeCub o1, MassPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(MassPerTime o1, TimeCubLengthSqrPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(TimeCubLengthSqrPerMass o1, MassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(MassPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthSqrMassPerTimeCub o1, MassPerTime o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(MassPerTime o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthCubPerMassTimeSqr o1, MassPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator*(MassPerTime o1, LengthCubTimeSqrPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubTimeSqrPerMass o1, MassPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(MassPerTime o1, LengthCubPerTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthCubPerTimeCub o1, MassPerTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(MassPerTime o1, LengthCubTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthCubTimeCub o1, MassPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(MassPerTime o1, LengthCubMassPerTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubMassPerTimeSqr o1, MassPerTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(MassPerTime o1, LengthCubTimeSqrMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthCubTimeSqrMass o1, MassPerTime o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(MassPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeCubPerMassLengthCub o1, MassPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(MassPerTime o1, MassPerLengthCubTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassPerLengthCubTimeCub o1, MassPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(MassPerTime o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubTimeCubPerMass o1, MassPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(MassPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubMassPerTimeCub o1, MassPerTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("MassPerTime is outside its bounds.");
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
    