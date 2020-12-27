
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Acceleration : Quantity, IEquatable<Acceleration>, IComparable
  {  
    internal Acceleration(double value) : base(value, 2)
    {
      Acceleration.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Acceleration(double value, double minValue, double maxValue) : base(value, 2)
    {
      Acceleration.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Acceleration(Acceleration other) : base(other)
    {
      Acceleration.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Acceleration"))
    {
      switch(FakeDatabase.Units["Acceleration"])
      {
        case "centimeterpersecondsqr": displayUnit_ = centimeterpersecondsqr_; break;
        case "millimeterpersecondsqr": displayUnit_ = millimeterpersecondsqr_; break;
        case "meterpersecondsqr": displayUnit_ = meterpersecondsqr_; break;
        case "inchpersecondsqr": displayUnit_ = inchpersecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterpersecondsqr_ = new Unit_("CentimeterPerSecondSqr", "cm/s²", 1.0, 0);
  private static Unit_ millimeterpersecondsqr_ = new Unit_("MillimeterPerSecondSqr", "mm/s²", 0.1, 0);
  private static Unit_ meterpersecondsqr_ = new Unit_("MeterPerSecondSqr", "m/s²", 100.0, 0);
  private static Unit_ inchpersecondsqr_ = new Unit_("InchPerSecondSqr", "in/s²", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterpersecondsqr_;
  private static Unit_ displayUnit_ = centimeterpersecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Acceleration other && Equals(other);
  public bool Equals(Acceleration other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Acceleration other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Acceleration other)) throw new ArgumentException("Object is not a Acceleration.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Acceleration l1, Acceleration l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Acceleration l1, Acceleration l2) => !(l1 == l2);
  public static bool operator <(Acceleration l1, Acceleration l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Acceleration l1, Acceleration l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Acceleration l1, Acceleration l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Acceleration l1, Acceleration l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Acceleration FromCentimeterPerSecondSqrs(double value, double minValue, double maxValue) => new Acceleration((value + centimeterpersecondsqr_.Offset) * centimeterpersecondsqr_.Factor, minValue * centimeterpersecondsqr_.Factor, maxValue * centimeterpersecondsqr_.Factor);
  public static Acceleration FromCentimeterPerSecondSqrs(double value) => new Acceleration((value + centimeterpersecondsqr_.Offset) * centimeterpersecondsqr_.Factor);
  public double GetValueInCentimeterPerSecondSqrs() => (Value_ - centimeterpersecondsqr_.Offset) / centimeterpersecondsqr_.Factor;
  public static Acceleration FromMillimeterPerSecondSqrs(double value, double minValue, double maxValue) => new Acceleration((value + millimeterpersecondsqr_.Offset) * millimeterpersecondsqr_.Factor, minValue * millimeterpersecondsqr_.Factor, maxValue * millimeterpersecondsqr_.Factor);
  public static Acceleration FromMillimeterPerSecondSqrs(double value) => new Acceleration((value + millimeterpersecondsqr_.Offset) * millimeterpersecondsqr_.Factor);
  public double GetValueInMillimeterPerSecondSqrs() => (Value_ - millimeterpersecondsqr_.Offset) / millimeterpersecondsqr_.Factor;
  public static Acceleration FromMeterPerSecondSqrs(double value, double minValue, double maxValue) => new Acceleration((value + meterpersecondsqr_.Offset) * meterpersecondsqr_.Factor, minValue * meterpersecondsqr_.Factor, maxValue * meterpersecondsqr_.Factor);
  public static Acceleration FromMeterPerSecondSqrs(double value) => new Acceleration((value + meterpersecondsqr_.Offset) * meterpersecondsqr_.Factor);
  public double GetValueInMeterPerSecondSqrs() => (Value_ - meterpersecondsqr_.Offset) / meterpersecondsqr_.Factor;
  public static Acceleration FromInchPerSecondSqrs(double value, double minValue, double maxValue) => new Acceleration((value + inchpersecondsqr_.Offset) * inchpersecondsqr_.Factor, minValue * inchpersecondsqr_.Factor, maxValue * inchpersecondsqr_.Factor);
  public static Acceleration FromInchPerSecondSqrs(double value) => new Acceleration((value + inchpersecondsqr_.Offset) * inchpersecondsqr_.Factor);
  public double GetValueInInchPerSecondSqrs() => (Value_ - inchpersecondsqr_.Offset) / inchpersecondsqr_.Factor;

#endregion

#region arithmetic
  public static Acceleration operator+(Acceleration o1, Acceleration o2) => new Acceleration(o1.Value_ + o2.Value_);
  public static Acceleration operator-(Acceleration o1, Acceleration o2) => new Acceleration(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Acceleration o1, Acceleration o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Area operator*(Acceleration o1, TimeSqrLength o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(TimeSqrLength o1, Acceleration o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Acceleration o1, LengthMassPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthMassPerTime o1, Acceleration o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(Acceleration o1, LengthMassPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthMassPerTime o1, Acceleration o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(Acceleration o1, LengthMassTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthMassTime o1, Acceleration o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(Acceleration o1, LengthMassTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(LengthMassTime o1, Acceleration o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(Acceleration o1, LengthSqrPerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrPerMass o1, Acceleration o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(Acceleration o1, LengthSqrPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthSqrPerMass o1, Acceleration o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Acceleration o1, LengthSqrPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrPerTime o1, Acceleration o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(Acceleration o1, LengthSqrPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrPerTime o1, Acceleration o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(Acceleration o1, LengthSqrTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrTime o1, Acceleration o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator/(Acceleration o1, LengthSqrTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthSqrTime o1, Acceleration o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(Acceleration o1, LengthSqrMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthSqrMass o1, Acceleration o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(Acceleration o1, LengthSqrMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthSqrMass o1, Acceleration o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(Acceleration o1, Volume o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(Volume o1, Acceleration o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(Acceleration o1, PerMassLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerMassLengthCub o1, Acceleration o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(Acceleration o1, PerTimeLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerTimeLengthCub o1, Acceleration o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(Acceleration o1, TimePerLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimePerLengthCub o1, Acceleration o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(Acceleration o1, Density o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(Density o1, Acceleration o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeCub operator*(Acceleration o1, PerMassTimeLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerMassTimeLengthSqr o1, Acceleration o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(Acceleration o1, PerMassTimeLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(PerMassTimeLengthSqr o1, Acceleration o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(Acceleration o1, TimePerMassLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(TimePerMassLengthSqr o1, Acceleration o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Acceleration o1, TimePerMassLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimePerMassLengthSqr o1, Acceleration o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(Acceleration o1, PerLengthSqrTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerLengthSqrTimeSqr o1, Acceleration o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(Acceleration o1, TimeSqrPerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrPerLengthSqr o1, Acceleration o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(Acceleration o1, MassPerTimeLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerTimeLengthSqr o1, Acceleration o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(Acceleration o1, MassPerTimeLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(MassPerTimeLengthSqr o1, Acceleration o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(Acceleration o1, MassTimePerLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassTimePerLengthSqr o1, Acceleration o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(Acceleration o1, MassTimePerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(MassTimePerLengthSqr o1, Acceleration o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator/(Acceleration o1, PerLengthMassTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerLengthMassTimeSqr o1, Acceleration o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(Acceleration o1, TimeSqrPerLengthMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimeSqrPerLengthMass o1, Acceleration o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(Acceleration o1, PerLengthTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthTimeCub o1, Acceleration o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Time operator*(Acceleration o1, TimeCubPerLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubPerLength o1, Acceleration o2) => new Time(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator/(Acceleration o1, MassPerLengthTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassPerLengthTimeSqr o1, Acceleration o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator*(Acceleration o1, TimeSqrMassPerLength o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(TimeSqrMassPerLength o1, Acceleration o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(Acceleration o1, PerMassTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassTimeCub o1, Acceleration o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(Acceleration o1, TimeCubPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimeCubPerMass o1, Acceleration o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator/(Acceleration o1, MassPerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerTimeCub o1, Acceleration o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(Acceleration o1, TimeCubMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(TimeCubMass o1, Acceleration o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static Mass operator/(Acceleration o1, LengthPerMassTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthPerMassTimeSqr o1, Acceleration o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(Acceleration o1, TimeSqrLengthPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(TimeSqrLengthPerMass o1, Acceleration o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static Time operator/(Acceleration o1, LengthPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthPerTimeCub o1, Acceleration o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(Acceleration o1, TimeCubLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(TimeCubLength o1, Acceleration o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(Acceleration o1, Force o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(Force o1, Acceleration o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(Acceleration o1, TimeSqrLengthMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(TimeSqrLengthMass o1, Acceleration o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(Acceleration o1, LengthSqrPerMassTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthSqrPerMassTime o1, Acceleration o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(Acceleration o1, LengthSqrPerMassTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrPerMassTime o1, Acceleration o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(Acceleration o1, LengthSqrTimePerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrTimePerMass o1, Acceleration o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(Acceleration o1, LengthSqrTimePerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthSqrTimePerMass o1, Acceleration o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(Acceleration o1, QDose o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(QDose o1, Acceleration o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Volume operator*(Acceleration o1, LengthSqrTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrTimeSqr o1, Acceleration o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Acceleration o1, LengthSqrMassPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthSqrMassPerTime o1, Acceleration o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(Acceleration o1, LengthSqrMassPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrMassPerTime o1, Acceleration o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(Acceleration o1, LengthSqrMassTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrMassTime o1, Acceleration o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(Acceleration o1, LengthSqrMassTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(LengthSqrMassTime o1, Acceleration o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(Acceleration o1, LengthCubPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubPerMass o1, Acceleration o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(Acceleration o1, LengthCubPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubPerTime o1, Acceleration o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(Acceleration o1, LengthCubTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTime o1, Acceleration o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(Acceleration o1, LengthCubMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubMass o1, Acceleration o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(Acceleration o1, PerMassTimeLengthCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerMassTimeLengthCub o1, Acceleration o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(Acceleration o1, TimePerMassLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(TimePerMassLengthCub o1, Acceleration o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(Acceleration o1, TimeSqrPerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeSqrPerLengthCub o1, Acceleration o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(Acceleration o1, MassPerTimeLengthCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(MassPerTimeLengthCub o1, Acceleration o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(Acceleration o1, MassTimePerLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassTimePerLengthCub o1, Acceleration o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator/(Acceleration o1, PerMassLengthSqrTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerMassLengthSqrTimeSqr o1, Acceleration o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(Acceleration o1, TimeSqrPerMassLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeSqrPerMassLengthSqr o1, Acceleration o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(Acceleration o1, PerLengthSqrTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerLengthSqrTimeCub o1, Acceleration o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(Acceleration o1, TimeCubPerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubPerLengthSqr o1, Acceleration o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator/(Acceleration o1, MassPerLengthSqrTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(MassPerLengthSqrTimeSqr o1, Acceleration o2) => new Density(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(Acceleration o1, TimeSqrMassPerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeSqrMassPerLengthSqr o1, Acceleration o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(Acceleration o1, PerLengthMassTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthMassTimeCub o1, Acceleration o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(Acceleration o1, TimeCubPerLengthMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeCubPerLengthMass o1, Acceleration o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator/(Acceleration o1, MassPerLengthTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassPerLengthTimeCub o1, Acceleration o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(Acceleration o1, TimeCubMassPerLength o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeCubMassPerLength o1, Acceleration o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static MassTime operator/(Acceleration o1, LengthPerMassTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthPerMassTimeCub o1, Acceleration o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(Acceleration o1, TimeCubLengthPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(TimeCubLengthPerMass o1, Acceleration o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator/(Acceleration o1, LengthMassPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthMassPerTimeCub o1, Acceleration o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(Acceleration o1, TimeCubLengthMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(TimeCubLengthMass o1, Acceleration o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(Acceleration o1, LengthSqrPerMassTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrPerMassTimeSqr o1, Acceleration o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(Acceleration o1, LengthSqrTimeSqrPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrTimeSqrPerMass o1, Acceleration o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(Acceleration o1, LengthSqrPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerTimeCub o1, Acceleration o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(Acceleration o1, TimeCubLengthSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(TimeCubLengthSqr o1, Acceleration o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(Acceleration o1, LengthSqrMassPerTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrMassPerTimeSqr o1, Acceleration o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(Acceleration o1, LengthSqrTimeSqrMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrTimeSqrMass o1, Acceleration o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(Acceleration o1, LengthCubPerMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubPerMassTime o1, Acceleration o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(Acceleration o1, LengthCubTimePerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthCubTimePerMass o1, Acceleration o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(Acceleration o1, LengthCubPerTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerTimeSqr o1, Acceleration o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(Acceleration o1, LengthCubMassPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubMassPerTime o1, Acceleration o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(Acceleration o1, LengthCubMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubMassTime o1, Acceleration o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(Acceleration o1, TimeSqrPerMassLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeSqrPerMassLengthCub o1, Acceleration o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(Acceleration o1, TimeCubPerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubPerLengthCub o1, Acceleration o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(Acceleration o1, TimeSqrMassPerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(TimeSqrMassPerLengthCub o1, Acceleration o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassTime operator/(Acceleration o1, PerMassLengthSqrTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerMassLengthSqrTimeCub o1, Acceleration o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(Acceleration o1, TimeCubPerMassLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeCubPerMassLengthSqr o1, Acceleration o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthCubTimePerMass operator/(Acceleration o1, MassPerLengthSqrTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerLengthSqrTimeCub o1, Acceleration o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(Acceleration o1, TimeCubMassPerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeCubMassPerLengthSqr o1, Acceleration o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator/(Acceleration o1, LengthSqrPerMassTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrPerMassTimeCub o1, Acceleration o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(Acceleration o1, TimeCubLengthSqrPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(TimeCubLengthSqrPerMass o1, Acceleration o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator/(Acceleration o1, LengthSqrMassPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrMassPerTimeCub o1, Acceleration o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Acceleration o1, TimeCubLengthSqrMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(TimeCubLengthSqrMass o1, Acceleration o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(Acceleration o1, LengthCubPerMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubPerMassTimeSqr o1, Acceleration o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(Acceleration o1, LengthCubPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerTimeCub o1, Acceleration o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(Acceleration o1, LengthCubMassPerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubMassPerTimeSqr o1, Acceleration o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(Acceleration o1, TimeCubPerMassLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeCubPerMassLengthCub o1, Acceleration o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(Acceleration o1, TimeCubMassPerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimeCubMassPerLengthCub o1, Acceleration o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(Acceleration o1, LengthCubPerMassTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubPerMassTimeCub o1, Acceleration o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(Acceleration o1, LengthCubMassPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubMassPerTimeCub o1, Acceleration o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Acceleration is outside its bounds.");
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
    