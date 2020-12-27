
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerTimeLengthSqr : Quantity, IEquatable<MassPerTimeLengthSqr>, IComparable
  {  
    internal MassPerTimeLengthSqr(double value) : base(value, 2)
    {
      MassPerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerTimeLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerTimeLengthSqr(MassPerTimeLengthSqr other) : base(other)
    {
      MassPerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerTimeLengthSqr"))
    {
      switch(FakeDatabase.Units["MassPerTimeLengthSqr"])
      {
        case "kilogrampersecondcentimetersqr": displayUnit_ = kilogrampersecondcentimetersqr_; break;
        case "kilogrampersecondmillimetersqr": displayUnit_ = kilogrampersecondmillimetersqr_; break;
        case "kilogrampersecondmetersqr": displayUnit_ = kilogrampersecondmetersqr_; break;
        case "kilogrampersecondinchsqr": displayUnit_ = kilogrampersecondinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampersecondcentimetersqr_ = new Unit_("KilogramPerSecondCentimeterSqr", "kg/s cm²", 1.0, 0);
  private static Unit_ kilogrampersecondmillimetersqr_ = new Unit_("KilogramPerSecondMillimeterSqr", "kg/s mm²", 99.99999999999999, 0);
  private static Unit_ kilogrampersecondmetersqr_ = new Unit_("KilogramPerSecondMeterSqr", "kg/s m²", 0.0001, 0);
  private static Unit_ kilogrampersecondinchsqr_ = new Unit_("KilogramPerSecondInchSqr", "kg/s in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = kilogrampersecondcentimetersqr_;
  private static Unit_ displayUnit_ = kilogrampersecondcentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerTimeLengthSqr other && Equals(other);
  public bool Equals(MassPerTimeLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerTimeLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerTimeLengthSqr other)) throw new ArgumentException("Object is not a MassPerTimeLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => !(l1 == l2);
  public static bool operator <(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerTimeLengthSqr l1, MassPerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerTimeLengthSqr FromKilogramPerSecondCentimeterSqrs(double value, double minValue, double maxValue) => new MassPerTimeLengthSqr((value + kilogrampersecondcentimetersqr_.Offset) * kilogrampersecondcentimetersqr_.Factor, minValue * kilogrampersecondcentimetersqr_.Factor, maxValue * kilogrampersecondcentimetersqr_.Factor);
  public static MassPerTimeLengthSqr FromKilogramPerSecondCentimeterSqrs(double value) => new MassPerTimeLengthSqr((value + kilogrampersecondcentimetersqr_.Offset) * kilogrampersecondcentimetersqr_.Factor);
  public double GetValueInKilogramPerSecondCentimeterSqrs() => (Value_ - kilogrampersecondcentimetersqr_.Offset) / kilogrampersecondcentimetersqr_.Factor;
  public static MassPerTimeLengthSqr FromKilogramPerSecondMillimeterSqrs(double value, double minValue, double maxValue) => new MassPerTimeLengthSqr((value + kilogrampersecondmillimetersqr_.Offset) * kilogrampersecondmillimetersqr_.Factor, minValue * kilogrampersecondmillimetersqr_.Factor, maxValue * kilogrampersecondmillimetersqr_.Factor);
  public static MassPerTimeLengthSqr FromKilogramPerSecondMillimeterSqrs(double value) => new MassPerTimeLengthSqr((value + kilogrampersecondmillimetersqr_.Offset) * kilogrampersecondmillimetersqr_.Factor);
  public double GetValueInKilogramPerSecondMillimeterSqrs() => (Value_ - kilogrampersecondmillimetersqr_.Offset) / kilogrampersecondmillimetersqr_.Factor;
  public static MassPerTimeLengthSqr FromKilogramPerSecondMeterSqrs(double value, double minValue, double maxValue) => new MassPerTimeLengthSqr((value + kilogrampersecondmetersqr_.Offset) * kilogrampersecondmetersqr_.Factor, minValue * kilogrampersecondmetersqr_.Factor, maxValue * kilogrampersecondmetersqr_.Factor);
  public static MassPerTimeLengthSqr FromKilogramPerSecondMeterSqrs(double value) => new MassPerTimeLengthSqr((value + kilogrampersecondmetersqr_.Offset) * kilogrampersecondmetersqr_.Factor);
  public double GetValueInKilogramPerSecondMeterSqrs() => (Value_ - kilogrampersecondmetersqr_.Offset) / kilogrampersecondmetersqr_.Factor;
  public static MassPerTimeLengthSqr FromKilogramPerSecondInchSqrs(double value, double minValue, double maxValue) => new MassPerTimeLengthSqr((value + kilogrampersecondinchsqr_.Offset) * kilogrampersecondinchsqr_.Factor, minValue * kilogrampersecondinchsqr_.Factor, maxValue * kilogrampersecondinchsqr_.Factor);
  public static MassPerTimeLengthSqr FromKilogramPerSecondInchSqrs(double value) => new MassPerTimeLengthSqr((value + kilogrampersecondinchsqr_.Offset) * kilogrampersecondinchsqr_.Factor);
  public double GetValueInKilogramPerSecondInchSqrs() => (Value_ - kilogrampersecondinchsqr_.Offset) / kilogrampersecondinchsqr_.Factor;

#endregion

#region arithmetic
  public static MassPerTimeLengthSqr operator+(MassPerTimeLengthSqr o1, MassPerTimeLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ + o2.Value_);
  public static MassPerTimeLengthSqr operator-(MassPerTimeLengthSqr o1, MassPerTimeLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerTimeLengthSqr o1, MassPerTimeLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(MassPerTimeLengthSqr o1, MassTimePerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(MassTimePerLengthSqr o1, MassPerTimeLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(MassPerTimeLengthSqr o1, PerLengthMassTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerLengthMassTimeSqr o1, MassPerTimeLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(MassPerTimeLengthSqr o1, TimeSqrPerLengthMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeSqrPerLengthMass o1, MassPerTimeLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator/(MassPerTimeLengthSqr o1, PerLengthTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerLengthTimeCub o1, MassPerTimeLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(MassPerTimeLengthSqr o1, TimeCubPerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeCubPerLength o1, MassPerTimeLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(MassPerTimeLengthSqr o1, MassPerLengthTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(MassPerLengthTimeSqr o1, MassPerTimeLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeSqrMassPerLength o1, MassPerTimeLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(MassPerTimeLengthSqr o1, TimeCubPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubPerMass o1, MassPerTimeLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(MassPerTimeLengthSqr o1, MassPerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(MassPerTimeCub o1, MassPerTimeLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(MassPerTimeLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(LengthPerMassTimeSqr o1, MassPerTimeLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(MassPerTimeLengthSqr o1, TimeSqrLengthPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqrLengthPerMass o1, MassPerTimeLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(MassPerTimeLengthSqr o1, LengthPerTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthPerTimeCub o1, MassPerTimeLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(MassPerTimeLengthSqr o1, TimeCubLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeCubLength o1, MassPerTimeLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(MassPerTimeLengthSqr o1, Force o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(Force o1, MassPerTimeLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrLengthMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(TimeSqrLengthMass o1, MassPerTimeLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(MassPerTimeLengthSqr o1, LengthSqrPerMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrPerMassTime o1, MassPerTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(MassPerTimeLengthSqr o1, LengthSqrTimePerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrTimePerMass o1, MassPerTimeLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(MassPerTimeLengthSqr o1, QDose o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(QDose o1, MassPerTimeLengthSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(MassPerTimeLengthSqr o1, LengthSqrTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthSqrTimeSqr o1, MassPerTimeLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassPerTimeLengthSqr o1, LengthCubPerMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubPerMass o1, MassPerTimeLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Force operator*(MassPerTimeLengthSqr o1, LengthCubPerTime o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubPerTime o1, MassPerTimeLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(MassPerTimeLengthSqr o1, LengthCubTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubTime o1, MassPerTimeLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(MassPerTimeLengthSqr o1, PerTimeSqrLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerTimeSqrLengthCub o1, MassPerTimeLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeSqrPerLengthCub o1, MassPerTimeLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(MassPerTimeLengthSqr o1, MassPerTimeLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerTimeLengthCub o1, MassPerTimeLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(MassPerTimeLengthSqr o1, MassTimePerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(MassTimePerLengthCub o1, MassPerTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(MassPerTimeLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthSqrTimeCub o1, MassPerTimeLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Time operator/(MassPerTimeLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerLengthSqrTimeSqr o1, MassPerTimeLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrMassPerLengthSqr o1, MassPerTimeLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(MassPerTimeLengthSqr o1, TimeCubPerLengthMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeCubPerLengthMass o1, MassPerTimeLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(MassPerTimeLengthSqr o1, MassPerLengthTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(MassPerLengthTimeCub o1, MassPerTimeLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(MassPerTimeLengthSqr o1, TimeCubLengthPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubLengthPerMass o1, MassPerTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(MassPerTimeLengthSqr o1, LengthMassPerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthMassPerTimeCub o1, MassPerTimeLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(MassPerTimeLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthSqrPerMassTimeSqr o1, MassPerTimeLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(MassPerTimeLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthSqrTimeSqrPerMass o1, MassPerTimeLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(MassPerTimeLengthSqr o1, TimeCubLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeCubLengthSqr o1, MassPerTimeLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(MassPerTimeLengthSqr o1, LengthCubPerMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubPerMassTime o1, MassPerTimeLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Length operator*(MassPerTimeLengthSqr o1, LengthCubTimePerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimePerMass o1, MassPerTimeLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(MassPerTimeLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthCubPerTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(MassPerTimeLengthSqr o1, LengthCubTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(MassPerTimeLengthSqr o1, PerLengthCubTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthCubTimeCub o1, MassPerTimeLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(MassPerTimeLengthSqr o1, MassPerTimeSqrLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerTimeSqrLengthCub o1, MassPerTimeLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeSqrMassPerLengthCub o1, MassPerTimeLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(MassPerTimeLengthSqr o1, MassPerLengthSqrTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(MassPerLengthSqrTimeCub o1, MassPerTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(MassPerTimeLengthSqr o1, TimeCubLengthSqrPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubLengthSqrPerMass o1, MassPerTimeLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(MassPerTimeLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthCubPerMassTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(MassPerTimeLengthSqr o1, LengthCubTimeSqrPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubTimeSqrPerMass o1, MassPerTimeLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(MassPerTimeLengthSqr o1, LengthCubTimeCub o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubTimeCub o1, MassPerTimeLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(MassPerTimeLengthSqr o1, MassPerLengthCubTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerLengthCubTimeCub o1, MassPerTimeLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(MassPerTimeLengthSqr o1, LengthCubTimeCubPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubTimeCubPerMass o1, MassPerTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerTimeLengthSqr is outside its bounds.");
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
    