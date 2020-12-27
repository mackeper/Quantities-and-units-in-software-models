
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimePerMassLengthSqr : Quantity, IEquatable<TimePerMassLengthSqr>, IComparable
  {  
    internal TimePerMassLengthSqr(double value) : base(value, 2)
    {
      TimePerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimePerMassLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimePerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimePerMassLengthSqr(TimePerMassLengthSqr other) : base(other)
    {
      TimePerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerMassLengthSqr"))
    {
      switch(FakeDatabase.Units["TimePerMassLengthSqr"])
      {
        case "secondperkilogramcentimetersqr": displayUnit_ = secondperkilogramcentimetersqr_; break;
        case "secondperkilogrammillimetersqr": displayUnit_ = secondperkilogrammillimetersqr_; break;
        case "secondperkilogrammetersqr": displayUnit_ = secondperkilogrammetersqr_; break;
        case "secondperkilograminchsqr": displayUnit_ = secondperkilograminchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondperkilogramcentimetersqr_ = new Unit_("SecondPerKilogramCentimeterSqr", "s/kg cm²", 1.0, 0);
  private static Unit_ secondperkilogrammillimetersqr_ = new Unit_("SecondPerKilogramMillimeterSqr", "s/kg mm²", 99.99999999999999, 0);
  private static Unit_ secondperkilogrammetersqr_ = new Unit_("SecondPerKilogramMeterSqr", "s/kg m²", 0.0001, 0);
  private static Unit_ secondperkilograminchsqr_ = new Unit_("SecondPerKilogramInchSqr", "s/kg in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondperkilogramcentimetersqr_;
  private static Unit_ displayUnit_ = secondperkilogramcentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimePerMassLengthSqr other && Equals(other);
  public bool Equals(TimePerMassLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimePerMassLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimePerMassLengthSqr other)) throw new ArgumentException("Object is not a TimePerMassLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimePerMassLengthSqr l1, TimePerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimePerMassLengthSqr FromSecondPerKilogramCentimeterSqrs(double value, double minValue, double maxValue) => new TimePerMassLengthSqr((value + secondperkilogramcentimetersqr_.Offset) * secondperkilogramcentimetersqr_.Factor, minValue * secondperkilogramcentimetersqr_.Factor, maxValue * secondperkilogramcentimetersqr_.Factor);
  public static TimePerMassLengthSqr FromSecondPerKilogramCentimeterSqrs(double value) => new TimePerMassLengthSqr((value + secondperkilogramcentimetersqr_.Offset) * secondperkilogramcentimetersqr_.Factor);
  public double GetValueInSecondPerKilogramCentimeterSqrs() => (Value_ - secondperkilogramcentimetersqr_.Offset) / secondperkilogramcentimetersqr_.Factor;
  public static TimePerMassLengthSqr FromSecondPerKilogramMillimeterSqrs(double value, double minValue, double maxValue) => new TimePerMassLengthSqr((value + secondperkilogrammillimetersqr_.Offset) * secondperkilogrammillimetersqr_.Factor, minValue * secondperkilogrammillimetersqr_.Factor, maxValue * secondperkilogrammillimetersqr_.Factor);
  public static TimePerMassLengthSqr FromSecondPerKilogramMillimeterSqrs(double value) => new TimePerMassLengthSqr((value + secondperkilogrammillimetersqr_.Offset) * secondperkilogrammillimetersqr_.Factor);
  public double GetValueInSecondPerKilogramMillimeterSqrs() => (Value_ - secondperkilogrammillimetersqr_.Offset) / secondperkilogrammillimetersqr_.Factor;
  public static TimePerMassLengthSqr FromSecondPerKilogramMeterSqrs(double value, double minValue, double maxValue) => new TimePerMassLengthSqr((value + secondperkilogrammetersqr_.Offset) * secondperkilogrammetersqr_.Factor, minValue * secondperkilogrammetersqr_.Factor, maxValue * secondperkilogrammetersqr_.Factor);
  public static TimePerMassLengthSqr FromSecondPerKilogramMeterSqrs(double value) => new TimePerMassLengthSqr((value + secondperkilogrammetersqr_.Offset) * secondperkilogrammetersqr_.Factor);
  public double GetValueInSecondPerKilogramMeterSqrs() => (Value_ - secondperkilogrammetersqr_.Offset) / secondperkilogrammetersqr_.Factor;
  public static TimePerMassLengthSqr FromSecondPerKilogramInchSqrs(double value, double minValue, double maxValue) => new TimePerMassLengthSqr((value + secondperkilograminchsqr_.Offset) * secondperkilograminchsqr_.Factor, minValue * secondperkilograminchsqr_.Factor, maxValue * secondperkilograminchsqr_.Factor);
  public static TimePerMassLengthSqr FromSecondPerKilogramInchSqrs(double value) => new TimePerMassLengthSqr((value + secondperkilograminchsqr_.Offset) * secondperkilograminchsqr_.Factor);
  public double GetValueInSecondPerKilogramInchSqrs() => (Value_ - secondperkilograminchsqr_.Offset) / secondperkilograminchsqr_.Factor;

#endregion

#region arithmetic
  public static TimePerMassLengthSqr operator+(TimePerMassLengthSqr o1, TimePerMassLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ + o2.Value_);
  public static TimePerMassLengthSqr operator-(TimePerMassLengthSqr o1, TimePerMassLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimePerMassLengthSqr o1, TimePerMassLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimePerMassLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerMassLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimePerMassLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrPerLengthSqr o1, TimePerMassLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(TimePerMassLengthSqr o1, PerLengthMassTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthMassTimeSqr o1, TimePerMassLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimePerMassLengthSqr o1, TimeSqrPerLengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrPerLengthMass o1, TimePerMassLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(TimePerMassLengthSqr o1, PerLengthTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerLengthTimeCub o1, TimePerMassLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubPerLength o1, TimePerMassLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimePerMassLengthSqr o1, MassPerLengthTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassPerLengthTimeSqr o1, TimePerMassLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(TimePerMassLengthSqr o1, TimeSqrMassPerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeSqrMassPerLength o1, TimePerMassLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubPerMass o1, TimePerMassLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(TimePerMassLengthSqr o1, MassPerTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerTimeCub o1, TimePerMassLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(TimePerMassLengthSqr o1, LengthPerMassTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthPerMassTimeSqr o1, TimePerMassLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(TimePerMassLengthSqr o1, TimeSqrLengthPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeSqrLengthPerMass o1, TimePerMassLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(TimePerMassLengthSqr o1, LengthPerTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(LengthPerTimeCub o1, TimePerMassLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator/(TimePerMassLengthSqr o1, TimeCubLength o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeCubLength o1, TimePerMassLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimePerMassLengthSqr o1, Force o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(Force o1, TimePerMassLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(TimePerMassLengthSqr o1, TimeSqrLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrLengthMass o1, TimePerMassLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(TimePerMassLengthSqr o1, QDose o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(QDose o1, TimePerMassLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimePerMassLengthSqr o1, LengthSqrTimeSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthSqrTimeSqr o1, TimePerMassLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimePerMassLengthSqr o1, LengthSqrMassPerTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrMassPerTime o1, TimePerMassLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(TimePerMassLengthSqr o1, LengthSqrMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthSqrMassTime o1, TimePerMassLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(TimePerMassLengthSqr o1, LengthCubPerTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerTime o1, TimePerMassLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimePerMassLengthSqr o1, LengthCubTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthCubTime o1, TimePerMassLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimePerMassLengthSqr o1, LengthCubMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubMass o1, TimePerMassLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(TimePerMassLengthSqr o1, PerMassTimeLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassTimeLengthCub o1, TimePerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(TimePerMassLengthSqr o1, TimePerMassLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimePerMassLengthCub o1, TimePerMassLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(TimePerMassLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(PerTimeSqrLengthCub o1, TimePerMassLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(TimePerMassLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeSqrPerLengthCub o1, TimePerMassLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(TimePerMassLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerMassLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimePerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrPerMassLengthSqr o1, TimePerMassLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubPerLengthSqr o1, TimePerMassLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubPerLengthMass o1, TimePerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(TimePerMassLengthSqr o1, MassPerLengthTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(MassPerLengthTimeCub o1, TimePerMassLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(TimePerMassLengthSqr o1, TimeCubLengthPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeCubLengthPerMass o1, TimePerMassLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(TimePerMassLengthSqr o1, LengthMassPerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthMassPerTimeCub o1, TimePerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(TimePerMassLengthSqr o1, LengthSqrPerTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthSqrPerTimeCub o1, TimePerMassLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimePerMassLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrMassPerTimeSqr o1, TimePerMassLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(TimePerMassLengthSqr o1, LengthSqrTimeSqrMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthSqrTimeSqrMass o1, TimePerMassLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(TimePerMassLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubPerTimeSqr o1, TimePerMassLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(TimePerMassLengthSqr o1, LengthCubTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthCubTimeSqr o1, TimePerMassLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(TimePerMassLengthSqr o1, LengthCubMassPerTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubMassPerTime o1, TimePerMassLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(TimePerMassLengthSqr o1, LengthCubMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubMassTime o1, TimePerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(TimePerMassLengthSqr o1, PerMassTimeSqrLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerMassLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static Speed operator/(TimePerMassLengthSqr o1, TimeSqrPerMassLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeSqrPerMassLengthCub o1, TimePerMassLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubPerLengthCub o1, TimePerMassLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(TimePerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubPerMassLengthSqr o1, TimePerMassLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(TimePerMassLengthSqr o1, LengthSqrMassPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrMassPerTimeCub o1, TimePerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(TimePerMassLengthSqr o1, LengthCubPerTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthCubPerTimeCub o1, TimePerMassLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Speed operator*(TimePerMassLengthSqr o1, LengthCubMassPerTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubMassPerTimeSqr o1, TimePerMassLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(TimePerMassLengthSqr o1, LengthCubTimeSqrMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTimeSqrMass o1, TimePerMassLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(TimePerMassLengthSqr o1, TimeCubPerMassLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubPerMassLengthCub o1, TimePerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(TimePerMassLengthSqr o1, LengthCubMassPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubMassPerTimeCub o1, TimePerMassLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimePerMassLengthSqr is outside its bounds.");
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
    