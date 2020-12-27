
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimePerLengthSqr : Quantity, IEquatable<TimePerLengthSqr>, IComparable
  {  
    internal TimePerLengthSqr(double value) : base(value, 2)
    {
      TimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimePerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimePerLengthSqr(TimePerLengthSqr other) : base(other)
    {
      TimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerLengthSqr"))
    {
      switch(FakeDatabase.Units["TimePerLengthSqr"])
      {
        case "secondpercentimetersqr": displayUnit_ = secondpercentimetersqr_; break;
        case "secondpermillimetersqr": displayUnit_ = secondpermillimetersqr_; break;
        case "secondpermetersqr": displayUnit_ = secondpermetersqr_; break;
        case "secondperinchsqr": displayUnit_ = secondperinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondpercentimetersqr_ = new Unit_("SecondPerCentimeterSqr", "s/cm²", 1.0, 0);
  private static Unit_ secondpermillimetersqr_ = new Unit_("SecondPerMillimeterSqr", "s/mm²", 99.99999999999999, 0);
  private static Unit_ secondpermetersqr_ = new Unit_("SecondPerMeterSqr", "s/m²", 0.0001, 0);
  private static Unit_ secondperinchsqr_ = new Unit_("SecondPerInchSqr", "s/in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondpercentimetersqr_;
  private static Unit_ displayUnit_ = secondpercentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimePerLengthSqr other && Equals(other);
  public bool Equals(TimePerLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimePerLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimePerLengthSqr other)) throw new ArgumentException("Object is not a TimePerLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimePerLengthSqr l1, TimePerLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimePerLengthSqr l1, TimePerLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimePerLengthSqr l1, TimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimePerLengthSqr l1, TimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimePerLengthSqr l1, TimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimePerLengthSqr l1, TimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimePerLengthSqr FromSecondPerCentimeterSqrs(double value, double minValue, double maxValue) => new TimePerLengthSqr((value + secondpercentimetersqr_.Offset) * secondpercentimetersqr_.Factor, minValue * secondpercentimetersqr_.Factor, maxValue * secondpercentimetersqr_.Factor);
  public static TimePerLengthSqr FromSecondPerCentimeterSqrs(double value) => new TimePerLengthSqr((value + secondpercentimetersqr_.Offset) * secondpercentimetersqr_.Factor);
  public double GetValueInSecondPerCentimeterSqrs() => (Value_ - secondpercentimetersqr_.Offset) / secondpercentimetersqr_.Factor;
  public static TimePerLengthSqr FromSecondPerMillimeterSqrs(double value, double minValue, double maxValue) => new TimePerLengthSqr((value + secondpermillimetersqr_.Offset) * secondpermillimetersqr_.Factor, minValue * secondpermillimetersqr_.Factor, maxValue * secondpermillimetersqr_.Factor);
  public static TimePerLengthSqr FromSecondPerMillimeterSqrs(double value) => new TimePerLengthSqr((value + secondpermillimetersqr_.Offset) * secondpermillimetersqr_.Factor);
  public double GetValueInSecondPerMillimeterSqrs() => (Value_ - secondpermillimetersqr_.Offset) / secondpermillimetersqr_.Factor;
  public static TimePerLengthSqr FromSecondPerMeterSqrs(double value, double minValue, double maxValue) => new TimePerLengthSqr((value + secondpermetersqr_.Offset) * secondpermetersqr_.Factor, minValue * secondpermetersqr_.Factor, maxValue * secondpermetersqr_.Factor);
  public static TimePerLengthSqr FromSecondPerMeterSqrs(double value) => new TimePerLengthSqr((value + secondpermetersqr_.Offset) * secondpermetersqr_.Factor);
  public double GetValueInSecondPerMeterSqrs() => (Value_ - secondpermetersqr_.Offset) / secondpermetersqr_.Factor;
  public static TimePerLengthSqr FromSecondPerInchSqrs(double value, double minValue, double maxValue) => new TimePerLengthSqr((value + secondperinchsqr_.Offset) * secondperinchsqr_.Factor, minValue * secondperinchsqr_.Factor, maxValue * secondperinchsqr_.Factor);
  public static TimePerLengthSqr FromSecondPerInchSqrs(double value) => new TimePerLengthSqr((value + secondperinchsqr_.Offset) * secondperinchsqr_.Factor);
  public double GetValueInSecondPerInchSqrs() => (Value_ - secondperinchsqr_.Offset) / secondperinchsqr_.Factor;

#endregion

#region arithmetic
  public static TimePerLengthSqr operator+(TimePerLengthSqr o1, TimePerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ + o2.Value_);
  public static TimePerLengthSqr operator-(TimePerLengthSqr o1, TimePerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimePerLengthSqr o1, TimePerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimePerLengthSqr o1, MassPerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerLengthSqr o1, TimePerLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimePerLengthSqr o1, PerLengthMassTime o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerLengthMassTime o1, TimePerLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(TimePerLengthSqr o1, PerLengthMassTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerLengthMassTime o1, TimePerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(TimePerLengthSqr o1, TimePerLengthMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimePerLengthMass o1, TimePerLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(TimePerLengthSqr o1, TimePerLengthMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimePerLengthMass o1, TimePerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimePerLengthSqr o1, PerLengthTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthTimeSqr o1, TimePerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(TimePerLengthSqr o1, PerLengthTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthTimeSqr o1, TimePerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator*(TimePerLengthSqr o1, TimeSqrPerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeSqrPerLength o1, TimePerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(TimePerLengthSqr o1, TimeSqrPerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrPerLength o1, TimePerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimePerLengthSqr o1, MassPerLengthTime o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthTime o1, TimePerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimePerLengthSqr o1, MassPerLengthTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(MassPerLengthTime o1, TimePerLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(TimePerLengthSqr o1, MassTimePerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(MassTimePerLength o1, TimePerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(TimePerLengthSqr o1, MassTimePerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassTimePerLength o1, TimePerLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimePerLengthSqr o1, PerMassTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassTimeSqr o1, TimePerLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimePerLengthSqr o1, PerMassTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(PerMassTimeSqr o1, TimePerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(TimePerLengthSqr o1, TimeSqrPerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeSqrPerMass o1, TimePerLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(TimePerLengthSqr o1, TimeSqrPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeSqrPerMass o1, TimePerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(TimePerLengthSqr o1, PerTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerTimeCub o1, TimePerLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(TimePerLengthSqr o1, TimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCub o1, TimePerLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimePerLengthSqr o1, MassPerTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerTimeSqr o1, TimePerLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimePerLengthSqr o1, MassPerTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(MassPerTimeSqr o1, TimePerLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(TimePerLengthSqr o1, TimeSqrMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeSqrMass o1, TimePerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(TimePerLengthSqr o1, TimeSqrMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeSqrMass o1, TimePerLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimePerLengthSqr o1, LengthPerMassTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthPerMassTime o1, TimePerLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimePerLengthSqr o1, LengthPerMassTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthPerMassTime o1, TimePerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(TimePerLengthSqr o1, LengthTimePerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(LengthTimePerMass o1, TimePerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static Density operator/(TimePerLengthSqr o1, LengthTimePerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthTimePerMass o1, TimePerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimePerLengthSqr o1, Acceleration o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(Acceleration o1, TimePerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(TimePerLengthSqr o1, Acceleration o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(Acceleration o1, TimePerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator*(TimePerLengthSqr o1, TimeSqrLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrLength o1, TimePerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator/(TimePerLengthSqr o1, TimeSqrLength o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeSqrLength o1, TimePerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimePerLengthSqr o1, LengthMassPerTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthMassPerTime o1, TimePerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimePerLengthSqr o1, LengthMassPerTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthMassPerTime o1, TimePerLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(TimePerLengthSqr o1, LengthMassTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(LengthMassTime o1, TimePerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(TimePerLengthSqr o1, LengthMassTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthMassTime o1, TimePerLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimePerLengthSqr o1, LengthSqrPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthSqrPerMass o1, TimePerLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimePerLengthSqr o1, LengthSqrPerTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrPerTime o1, TimePerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(TimePerLengthSqr o1, LengthSqrTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthSqrTime o1, TimePerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimePerLengthSqr o1, LengthSqrMass o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthSqrMass o1, TimePerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimePerLengthSqr o1, Volume o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(Volume o1, TimePerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(TimePerLengthSqr o1, PerMassLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassLengthCub o1, TimePerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(TimePerLengthSqr o1, PerTimeLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerTimeLengthCub o1, TimePerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(TimePerLengthSqr o1, TimePerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimePerLengthCub o1, TimePerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(TimePerLengthSqr o1, Density o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(Density o1, TimePerLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(TimePerLengthSqr o1, PerMassTimeLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerMassTimeLengthSqr o1, TimePerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator/(TimePerLengthSqr o1, TimePerMassLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimePerMassLengthSqr o1, TimePerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(TimePerLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimePerLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrPerLengthSqr o1, TimePerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(TimePerLengthSqr o1, MassPerTimeLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerTimeLengthSqr o1, TimePerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimePerLengthSqr o1, MassTimePerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassTimePerLengthSqr o1, TimePerLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(TimePerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerLengthMassTimeSqr o1, TimePerLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(TimePerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(PerLengthMassTimeSqr o1, TimePerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(TimePerLengthSqr o1, TimeSqrPerLengthMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeSqrPerLengthMass o1, TimePerLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(TimePerLengthSqr o1, TimeSqrPerLengthMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeSqrPerLengthMass o1, TimePerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(TimePerLengthSqr o1, PerLengthTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerLengthTimeCub o1, TimePerLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(TimePerLengthSqr o1, TimeCubPerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubPerLength o1, TimePerLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(TimePerLengthSqr o1, MassPerLengthTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerLengthTimeSqr o1, TimePerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(TimePerLengthSqr o1, MassPerLengthTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(MassPerLengthTimeSqr o1, TimePerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(TimePerLengthSqr o1, TimeSqrMassPerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeSqrMassPerLength o1, TimePerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(TimePerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeSqrMassPerLength o1, TimePerLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(TimePerLengthSqr o1, PerMassTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerMassTimeCub o1, TimePerLengthSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(TimePerLengthSqr o1, TimeCubPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(TimeCubPerMass o1, TimePerLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(TimePerLengthSqr o1, MassPerTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerTimeCub o1, TimePerLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(TimePerLengthSqr o1, TimeCubMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(TimeCubMass o1, TimePerLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimePerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(LengthPerMassTimeSqr o1, TimePerLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimePerLengthSqr o1, LengthPerMassTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthPerMassTimeSqr o1, TimePerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(TimePerLengthSqr o1, TimeSqrLengthPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrLengthPerMass o1, TimePerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(TimePerLengthSqr o1, TimeSqrLengthPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(TimeSqrLengthPerMass o1, TimePerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(TimePerLengthSqr o1, LengthPerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthPerTimeCub o1, TimePerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(TimePerLengthSqr o1, TimeCubLength o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeCubLength o1, TimePerLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(TimePerLengthSqr o1, Force o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(Force o1, TimePerLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimePerLengthSqr o1, Force o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Force o1, TimePerLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(TimePerLengthSqr o1, TimeSqrLengthMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrLengthMass o1, TimePerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(TimePerLengthSqr o1, TimeSqrLengthMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(TimeSqrLengthMass o1, TimePerLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimePerLengthSqr o1, LengthSqrPerMassTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthSqrPerMassTime o1, TimePerLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(TimePerLengthSqr o1, LengthSqrTimePerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthSqrTimePerMass o1, TimePerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimePerLengthSqr o1, QDose o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(QDose o1, TimePerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(TimePerLengthSqr o1, LengthSqrTimeSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthSqrTimeSqr o1, TimePerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimePerLengthSqr o1, LengthSqrMassPerTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthSqrMassPerTime o1, TimePerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(TimePerLengthSqr o1, LengthSqrMassTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(LengthSqrMassTime o1, TimePerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(TimePerLengthSqr o1, LengthCubPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthCubPerMass o1, TimePerLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(TimePerLengthSqr o1, LengthCubPerTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubPerTime o1, TimePerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(TimePerLengthSqr o1, LengthCubTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubTime o1, TimePerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(TimePerLengthSqr o1, LengthCubMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubMass o1, TimePerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(TimePerLengthSqr o1, PerMassTimeLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerMassTimeLengthCub o1, TimePerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthMass operator/(TimePerLengthSqr o1, TimePerMassLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimePerMassLengthCub o1, TimePerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator/(TimePerLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerTimeSqrLengthCub o1, TimePerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static Speed operator/(TimePerLengthSqr o1, TimeSqrPerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeSqrPerLengthCub o1, TimePerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(TimePerLengthSqr o1, MassPerTimeLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerTimeLengthCub o1, TimePerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator/(TimePerLengthSqr o1, MassTimePerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassTimePerLengthCub o1, TimePerLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator/(TimePerLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(TimePerLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeSqrPerMassLengthSqr o1, TimePerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(TimePerLengthSqr o1, TimeCubPerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubPerLengthSqr o1, TimePerLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimePerLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerLengthSqrTimeSqr o1, TimePerLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimePerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrMassPerLengthSqr o1, TimePerLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(TimePerLengthSqr o1, PerLengthMassTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerLengthMassTimeCub o1, TimePerLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(TimePerLengthSqr o1, TimeCubPerLengthMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubPerLengthMass o1, TimePerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(TimePerLengthSqr o1, MassPerLengthTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerLengthTimeCub o1, TimePerLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(TimePerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubMassPerLength o1, TimePerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(TimePerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(LengthPerMassTimeCub o1, TimePerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator/(TimePerLengthSqr o1, TimeCubLengthPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeCubLengthPerMass o1, TimePerLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(TimePerLengthSqr o1, LengthMassPerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(LengthMassPerTimeCub o1, TimePerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator/(TimePerLengthSqr o1, TimeCubLengthMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeCubLengthMass o1, TimePerLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimePerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrPerMassTimeSqr o1, TimePerLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimePerLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthSqrTimeSqrPerMass o1, TimePerLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(TimePerLengthSqr o1, LengthSqrPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrPerTimeCub o1, TimePerLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(TimePerLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthSqrMassPerTimeSqr o1, TimePerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(TimePerLengthSqr o1, LengthSqrTimeSqrMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthSqrTimeSqrMass o1, TimePerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(TimePerLengthSqr o1, LengthCubPerMassTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerMassTime o1, TimePerLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimePerLengthSqr o1, LengthCubTimePerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthCubTimePerMass o1, TimePerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(TimePerLengthSqr o1, LengthCubPerTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubPerTimeSqr o1, TimePerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(TimePerLengthSqr o1, LengthCubTimeSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTimeSqr o1, TimePerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(TimePerLengthSqr o1, LengthCubMassPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubMassPerTime o1, TimePerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimePerLengthSqr o1, LengthCubMassTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubMassTime o1, TimePerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator/(TimePerLengthSqr o1, PerMassTimeSqrLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator/(TimePerLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrPerMassLengthCub o1, TimePerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(TimePerLengthSqr o1, TimeCubPerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubPerLengthCub o1, TimePerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(TimePerLengthSqr o1, MassPerTimeSqrLengthCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTimeSqrLengthCub o1, TimePerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(TimePerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeSqrMassPerLengthCub o1, TimePerLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(TimePerLengthSqr o1, TimeCubPerMassLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubPerMassLengthSqr o1, TimePerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(TimePerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubMassPerLengthSqr o1, TimePerLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(TimePerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthSqrPerMassTimeCub o1, TimePerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(TimePerLengthSqr o1, LengthSqrMassPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthSqrMassPerTimeCub o1, TimePerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(TimePerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubPerMassTimeSqr o1, TimePerLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(TimePerLengthSqr o1, LengthCubTimeSqrPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthCubTimeSqrPerMass o1, TimePerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(TimePerLengthSqr o1, LengthCubPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubPerTimeCub o1, TimePerLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(TimePerLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubMassPerTimeSqr o1, TimePerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(TimePerLengthSqr o1, LengthCubTimeSqrMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthCubTimeSqrMass o1, TimePerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static Force operator/(TimePerLengthSqr o1, TimeCubPerMassLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubPerMassLengthCub o1, TimePerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(TimePerLengthSqr o1, TimeCubMassPerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubMassPerLengthCub o1, TimePerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(TimePerLengthSqr o1, LengthCubPerMassTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthCubPerMassTimeCub o1, TimePerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Force operator*(TimePerLengthSqr o1, LengthCubMassPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubMassPerTimeCub o1, TimePerLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimePerLengthSqr is outside its bounds.");
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
    