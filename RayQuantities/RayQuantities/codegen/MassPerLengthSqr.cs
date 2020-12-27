
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerLengthSqr : Quantity, IEquatable<MassPerLengthSqr>, IComparable
  {  
    internal MassPerLengthSqr(double value) : base(value, 2)
    {
      MassPerLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerLengthSqr(MassPerLengthSqr other) : base(other)
    {
      MassPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthSqr"))
    {
      switch(FakeDatabase.Units["MassPerLengthSqr"])
      {
        case "kilogrampercentimetersqr": displayUnit_ = kilogrampercentimetersqr_; break;
        case "kilogrampermillimetersqr": displayUnit_ = kilogrampermillimetersqr_; break;
        case "kilogrampermetersqr": displayUnit_ = kilogrampermetersqr_; break;
        case "kilogramperinchsqr": displayUnit_ = kilogramperinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampercentimetersqr_ = new Unit_("KilogramPerCentimeterSqr", "kg/cm²", 1.0, 0);
  private static Unit_ kilogrampermillimetersqr_ = new Unit_("KilogramPerMillimeterSqr", "kg/mm²", 99.99999999999999, 0);
  private static Unit_ kilogrampermetersqr_ = new Unit_("KilogramPerMeterSqr", "kg/m²", 0.0001, 0);
  private static Unit_ kilogramperinchsqr_ = new Unit_("KilogramPerInchSqr", "kg/in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = kilogrampercentimetersqr_;
  private static Unit_ displayUnit_ = kilogrampercentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerLengthSqr other && Equals(other);
  public bool Equals(MassPerLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerLengthSqr other)) throw new ArgumentException("Object is not a MassPerLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerLengthSqr l1, MassPerLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerLengthSqr l1, MassPerLengthSqr l2) => !(l1 == l2);
  public static bool operator <(MassPerLengthSqr l1, MassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerLengthSqr l1, MassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerLengthSqr l1, MassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerLengthSqr l1, MassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerLengthSqr FromKilogramPerCentimeterSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqr((value + kilogrampercentimetersqr_.Offset) * kilogrampercentimetersqr_.Factor, minValue * kilogrampercentimetersqr_.Factor, maxValue * kilogrampercentimetersqr_.Factor);
  public static MassPerLengthSqr FromKilogramPerCentimeterSqrs(double value) => new MassPerLengthSqr((value + kilogrampercentimetersqr_.Offset) * kilogrampercentimetersqr_.Factor);
  public double GetValueInKilogramPerCentimeterSqrs() => (Value_ - kilogrampercentimetersqr_.Offset) / kilogrampercentimetersqr_.Factor;
  public static MassPerLengthSqr FromKilogramPerMillimeterSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqr((value + kilogrampermillimetersqr_.Offset) * kilogrampermillimetersqr_.Factor, minValue * kilogrampermillimetersqr_.Factor, maxValue * kilogrampermillimetersqr_.Factor);
  public static MassPerLengthSqr FromKilogramPerMillimeterSqrs(double value) => new MassPerLengthSqr((value + kilogrampermillimetersqr_.Offset) * kilogrampermillimetersqr_.Factor);
  public double GetValueInKilogramPerMillimeterSqrs() => (Value_ - kilogrampermillimetersqr_.Offset) / kilogrampermillimetersqr_.Factor;
  public static MassPerLengthSqr FromKilogramPerMeterSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqr((value + kilogrampermetersqr_.Offset) * kilogrampermetersqr_.Factor, minValue * kilogrampermetersqr_.Factor, maxValue * kilogrampermetersqr_.Factor);
  public static MassPerLengthSqr FromKilogramPerMeterSqrs(double value) => new MassPerLengthSqr((value + kilogrampermetersqr_.Offset) * kilogrampermetersqr_.Factor);
  public double GetValueInKilogramPerMeterSqrs() => (Value_ - kilogrampermetersqr_.Offset) / kilogrampermetersqr_.Factor;
  public static MassPerLengthSqr FromKilogramPerInchSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqr((value + kilogramperinchsqr_.Offset) * kilogramperinchsqr_.Factor, minValue * kilogramperinchsqr_.Factor, maxValue * kilogramperinchsqr_.Factor);
  public static MassPerLengthSqr FromKilogramPerInchSqrs(double value) => new MassPerLengthSqr((value + kilogramperinchsqr_.Offset) * kilogramperinchsqr_.Factor);
  public double GetValueInKilogramPerInchSqrs() => (Value_ - kilogramperinchsqr_.Offset) / kilogramperinchsqr_.Factor;

#endregion

#region arithmetic
  public static MassPerLengthSqr operator+(MassPerLengthSqr o1, MassPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ + o2.Value_);
  public static MassPerLengthSqr operator-(MassPerLengthSqr o1, MassPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerLengthSqr o1, MassPerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(MassPerLengthSqr o1, PerLengthMassTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthMassTime o1, MassPerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(MassPerLengthSqr o1, TimePerLengthMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimePerLengthMass o1, MassPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(MassPerLengthSqr o1, PerLengthTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(PerLengthTimeSqr o1, MassPerLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(MassPerLengthSqr o1, PerLengthTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerLengthTimeSqr o1, MassPerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(MassPerLengthSqr o1, TimeSqrPerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeSqrPerLength o1, MassPerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerLengthSqr o1, TimeSqrPerLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeSqrPerLength o1, MassPerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(MassPerLengthSqr o1, MassPerLengthTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(MassPerLengthTime o1, MassPerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(MassPerLengthSqr o1, MassTimePerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(MassTimePerLength o1, MassPerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(MassPerLengthSqr o1, PerMassTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassTimeSqr o1, MassPerLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(MassPerLengthSqr o1, TimeSqrPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrPerMass o1, MassPerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(MassPerLengthSqr o1, PerTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(PerTimeCub o1, MassPerLengthSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(MassPerLengthSqr o1, PerTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(PerTimeCub o1, MassPerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(MassPerLengthSqr o1, TimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCub o1, MassPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerLengthSqr o1, TimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(TimeCub o1, MassPerLengthSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(MassPerLengthSqr o1, MassPerTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(MassPerTimeSqr o1, MassPerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(MassPerLengthSqr o1, TimeSqrMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeSqrMass o1, MassPerLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(MassPerLengthSqr o1, LengthPerMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthPerMassTime o1, MassPerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(MassPerLengthSqr o1, LengthTimePerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(LengthTimePerMass o1, MassPerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(MassPerLengthSqr o1, Acceleration o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(Acceleration o1, MassPerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(MassPerLengthSqr o1, Acceleration o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(Acceleration o1, MassPerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(MassPerLengthSqr o1, TimeSqrLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrLength o1, MassPerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerLengthSqr o1, TimeSqrLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeSqrLength o1, MassPerLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator/(MassPerLengthSqr o1, LengthMassPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthMassPerTime o1, MassPerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(MassPerLengthSqr o1, LengthMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthMassTime o1, MassPerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassPerLengthSqr o1, LengthSqrPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrPerMass o1, MassPerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(MassPerLengthSqr o1, LengthSqrPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthSqrPerTime o1, MassPerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(MassPerLengthSqr o1, LengthSqrTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthSqrTime o1, MassPerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(MassPerLengthSqr o1, Volume o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(Volume o1, MassPerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(MassPerLengthSqr o1, PerTimeLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerTimeLengthCub o1, MassPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator/(MassPerLengthSqr o1, TimePerLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimePerLengthCub o1, MassPerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(MassPerLengthSqr o1, Density o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(Density o1, MassPerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(MassPerLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthSqrTimeSqr o1, MassPerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(MassPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqrPerLengthSqr o1, MassPerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(MassPerLengthSqr o1, MassPerTimeLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerTimeLengthSqr o1, MassPerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(MassPerLengthSqr o1, MassTimePerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(MassTimePerLengthSqr o1, MassPerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(MassPerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerLengthMassTimeSqr o1, MassPerLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(MassPerLengthSqr o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeSqrPerLengthMass o1, MassPerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(MassPerLengthSqr o1, PerLengthTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(PerLengthTimeCub o1, MassPerLengthSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(MassPerLengthSqr o1, PerLengthTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(PerLengthTimeCub o1, MassPerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(MassPerLengthSqr o1, TimeCubPerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeCubPerLength o1, MassPerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerLengthSqr o1, TimeCubPerLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubPerLength o1, MassPerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(MassPerLengthSqr o1, MassPerLengthTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(MassPerLengthTimeSqr o1, MassPerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(MassPerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrMassPerLength o1, MassPerLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(MassPerLengthSqr o1, PerMassTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerMassTimeCub o1, MassPerLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(MassPerLengthSqr o1, TimeCubPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubPerMass o1, MassPerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(MassPerLengthSqr o1, MassPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(MassPerTimeCub o1, MassPerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(MassPerLengthSqr o1, TimeCubMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubMass o1, MassPerLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(MassPerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthPerMassTimeSqr o1, MassPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(MassPerLengthSqr o1, TimeSqrLengthPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrLengthPerMass o1, MassPerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(MassPerLengthSqr o1, LengthPerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(LengthPerTimeCub o1, MassPerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(MassPerLengthSqr o1, LengthPerTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthPerTimeCub o1, MassPerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(MassPerLengthSqr o1, TimeCubLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubLength o1, MassPerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthSqr o1, TimeCubLength o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(TimeCubLength o1, MassPerLengthSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(MassPerLengthSqr o1, Force o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(Force o1, MassPerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(MassPerLengthSqr o1, TimeSqrLengthMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeSqrLengthMass o1, MassPerLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(MassPerLengthSqr o1, LengthSqrPerMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrPerMassTime o1, MassPerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(MassPerLengthSqr o1, LengthSqrTimePerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthSqrTimePerMass o1, MassPerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(MassPerLengthSqr o1, QDose o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(QDose o1, MassPerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(MassPerLengthSqr o1, LengthSqrTimeSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(LengthSqrTimeSqr o1, MassPerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(MassPerLengthSqr o1, LengthCubPerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubPerMass o1, MassPerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(MassPerLengthSqr o1, LengthCubPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubPerTime o1, MassPerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(MassPerLengthSqr o1, LengthCubTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubTime o1, MassPerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(MassPerLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerTimeSqrLengthCub o1, MassPerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Force operator/(MassPerLengthSqr o1, TimeSqrPerLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrPerLengthCub o1, MassPerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(MassPerLengthSqr o1, MassPerTimeLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerTimeLengthCub o1, MassPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static Speed operator/(MassPerLengthSqr o1, MassTimePerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(MassTimePerLengthCub o1, MassPerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator/(MassPerLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerLengthSqrTimeCub o1, MassPerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(MassPerLengthSqr o1, TimeCubPerLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubPerLengthSqr o1, MassPerLengthSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(MassPerLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(MassPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrMassPerLengthSqr o1, MassPerLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(MassPerLengthSqr o1, PerLengthMassTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerLengthMassTimeCub o1, MassPerLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(MassPerLengthSqr o1, TimeCubPerLengthMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCubPerLengthMass o1, MassPerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(MassPerLengthSqr o1, MassPerLengthTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(MassPerLengthTimeCub o1, MassPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(MassPerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubMassPerLength o1, MassPerLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(MassPerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(LengthPerMassTimeCub o1, MassPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(MassPerLengthSqr o1, TimeCubLengthPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubLengthPerMass o1, MassPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(MassPerLengthSqr o1, LengthMassPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthMassPerTimeCub o1, MassPerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(MassPerLengthSqr o1, TimeCubLengthMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(TimeCubLengthMass o1, MassPerLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(MassPerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrPerMassTimeSqr o1, MassPerLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(MassPerLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(MassPerLengthSqr o1, LengthSqrPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(LengthSqrPerTimeCub o1, MassPerLengthSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(MassPerLengthSqr o1, TimeCubLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubLengthSqr o1, MassPerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassPerLengthSqr o1, LengthCubPerMassTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubPerMassTime o1, MassPerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(MassPerLengthSqr o1, LengthCubTimePerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubTimePerMass o1, MassPerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static Force operator*(MassPerLengthSqr o1, LengthCubPerTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubPerTimeSqr o1, MassPerLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(MassPerLengthSqr o1, LengthCubTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubTimeSqr o1, MassPerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator/(MassPerLengthSqr o1, PerLengthCubTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerLengthCubTimeCub o1, MassPerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator/(MassPerLengthSqr o1, TimeCubPerLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubPerLengthCub o1, MassPerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(MassPerLengthSqr o1, MassPerTimeSqrLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerTimeSqrLengthCub o1, MassPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(MassPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrMassPerLengthCub o1, MassPerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(MassPerLengthSqr o1, MassPerLengthSqrTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(MassPerLengthSqrTimeCub o1, MassPerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(MassPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubMassPerLengthSqr o1, MassPerLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(MassPerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthSqrPerMassTimeCub o1, MassPerLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(MassPerLengthSqr o1, TimeCubLengthSqrPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubLengthSqrPerMass o1, MassPerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(MassPerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubPerMassTimeSqr o1, MassPerLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(MassPerLengthSqr o1, LengthCubTimeSqrPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubTimeSqrPerMass o1, MassPerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(MassPerLengthSqr o1, LengthCubPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthCubPerTimeCub o1, MassPerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(MassPerLengthSqr o1, LengthCubTimeCub o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthCubTimeCub o1, MassPerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(MassPerLengthSqr o1, MassPerLengthCubTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(MassPerLengthCubTimeCub o1, MassPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(MassPerLengthSqr o1, TimeCubMassPerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubMassPerLengthCub o1, MassPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(MassPerLengthSqr o1, LengthCubPerMassTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthCubPerMassTimeCub o1, MassPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(MassPerLengthSqr o1, LengthCubTimeCubPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTimeCubPerMass o1, MassPerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerLengthSqr is outside its bounds.");
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
    