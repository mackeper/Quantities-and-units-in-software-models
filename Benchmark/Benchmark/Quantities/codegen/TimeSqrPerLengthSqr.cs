
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerLengthSqr : Quantity, IEquatable<TimeSqrPerLengthSqr>, IComparable
  {  
    internal TimeSqrPerLengthSqr(double value) : base(value, 2)
    {
      TimeSqrPerLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerLengthSqr(TimeSqrPerLengthSqr other) : base(other)
    {
      TimeSqrPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerLengthSqr"))
    {
      switch(FakeDatabase.Units["TimeSqrPerLengthSqr"])
      {
        case "secondsqrpercentimetersqr": displayUnit_ = secondsqrpercentimetersqr_; break;
        case "secondsqrpermillimetersqr": displayUnit_ = secondsqrpermillimetersqr_; break;
        case "secondsqrpermetersqr": displayUnit_ = secondsqrpermetersqr_; break;
        case "secondsqrperinchsqr": displayUnit_ = secondsqrperinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrpercentimetersqr_ = new Unit_("SecondSqrPerCentimeterSqr", "s²/cm²", 1.0, 0);
  private static Unit_ secondsqrpermillimetersqr_ = new Unit_("SecondSqrPerMillimeterSqr", "s²/mm²", 99.99999999999999, 0);
  private static Unit_ secondsqrpermetersqr_ = new Unit_("SecondSqrPerMeterSqr", "s²/m²", 0.0001, 0);
  private static Unit_ secondsqrperinchsqr_ = new Unit_("SecondSqrPerInchSqr", "s²/in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondsqrpercentimetersqr_;
  private static Unit_ displayUnit_ = secondsqrpercentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerLengthSqr other && Equals(other);
  public bool Equals(TimeSqrPerLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerLengthSqr other)) throw new ArgumentException("Object is not a TimeSqrPerLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerLengthSqr l1, TimeSqrPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerLengthSqr FromSecondSqrPerCentimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerLengthSqr((value + secondsqrpercentimetersqr_.Offset) * secondsqrpercentimetersqr_.Factor, minValue * secondsqrpercentimetersqr_.Factor, maxValue * secondsqrpercentimetersqr_.Factor);
  public static TimeSqrPerLengthSqr FromSecondSqrPerCentimeterSqrs(double value) => new TimeSqrPerLengthSqr((value + secondsqrpercentimetersqr_.Offset) * secondsqrpercentimetersqr_.Factor);
  public double GetValueInSecondSqrPerCentimeterSqrs() => (Value_ - secondsqrpercentimetersqr_.Offset) / secondsqrpercentimetersqr_.Factor;
  public static TimeSqrPerLengthSqr FromSecondSqrPerMillimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerLengthSqr((value + secondsqrpermillimetersqr_.Offset) * secondsqrpermillimetersqr_.Factor, minValue * secondsqrpermillimetersqr_.Factor, maxValue * secondsqrpermillimetersqr_.Factor);
  public static TimeSqrPerLengthSqr FromSecondSqrPerMillimeterSqrs(double value) => new TimeSqrPerLengthSqr((value + secondsqrpermillimetersqr_.Offset) * secondsqrpermillimetersqr_.Factor);
  public double GetValueInSecondSqrPerMillimeterSqrs() => (Value_ - secondsqrpermillimetersqr_.Offset) / secondsqrpermillimetersqr_.Factor;
  public static TimeSqrPerLengthSqr FromSecondSqrPerMeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerLengthSqr((value + secondsqrpermetersqr_.Offset) * secondsqrpermetersqr_.Factor, minValue * secondsqrpermetersqr_.Factor, maxValue * secondsqrpermetersqr_.Factor);
  public static TimeSqrPerLengthSqr FromSecondSqrPerMeterSqrs(double value) => new TimeSqrPerLengthSqr((value + secondsqrpermetersqr_.Offset) * secondsqrpermetersqr_.Factor);
  public double GetValueInSecondSqrPerMeterSqrs() => (Value_ - secondsqrpermetersqr_.Offset) / secondsqrpermetersqr_.Factor;
  public static TimeSqrPerLengthSqr FromSecondSqrPerInchSqrs(double value, double minValue, double maxValue) => new TimeSqrPerLengthSqr((value + secondsqrperinchsqr_.Offset) * secondsqrperinchsqr_.Factor, minValue * secondsqrperinchsqr_.Factor, maxValue * secondsqrperinchsqr_.Factor);
  public static TimeSqrPerLengthSqr FromSecondSqrPerInchSqrs(double value) => new TimeSqrPerLengthSqr((value + secondsqrperinchsqr_.Offset) * secondsqrperinchsqr_.Factor);
  public double GetValueInSecondSqrPerInchSqrs() => (Value_ - secondsqrperinchsqr_.Offset) / secondsqrperinchsqr_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerLengthSqr operator+(TimeSqrPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ + o2.Value_);
  public static TimeSqrPerLengthSqr operator-(TimeSqrPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimeSqrPerLengthSqr o1, MassPerTimeLengthSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrPerLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimeSqrPerLengthSqr o1, MassTimePerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassTimePerLengthSqr o1, TimeSqrPerLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerLengthMassTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeSqrPerLengthSqr o1, TimeSqrPerLengthMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeSqrPerLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthTimeCub o1, TimeSqrPerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerLengthSqr o1, TimeCubPerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubPerLength o1, TimeSqrPerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimeSqrPerLengthSqr o1, MassPerLengthTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthTimeSqr o1, TimeSqrPerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeSqrPerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeSqrMassPerLength o1, TimeSqrPerLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrPerLengthSqr o1, PerMassTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassTimeCub o1, TimeSqrPerLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimeSqrPerLengthSqr o1, TimeCubPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeCubPerMass o1, TimeSqrPerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimeSqrPerLengthSqr o1, MassPerTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerTimeCub o1, TimeSqrPerLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrPerLengthSqr o1, TimeCubMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeCubMass o1, TimeSqrPerLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeSqrPerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthPerMassTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeSqrPerLengthSqr o1, TimeSqrLengthPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(TimeSqrLengthPerMass o1, TimeSqrPerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerLengthSqr o1, LengthPerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthPerTimeCub o1, TimeSqrPerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(TimeSqrPerLengthSqr o1, TimeCubLength o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeCubLength o1, TimeSqrPerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeSqrPerLengthSqr o1, Force o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(Force o1, TimeSqrPerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeSqrPerLengthSqr o1, TimeSqrLengthMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(TimeSqrLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimeSqrPerLengthSqr o1, LengthSqrPerMassTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthSqrPerMassTime o1, TimeSqrPerLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimeSqrPerLengthSqr o1, LengthSqrTimePerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthSqrTimePerMass o1, TimeSqrPerLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerLengthSqr o1, QDose o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(QDose o1, TimeSqrPerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimeSqrPerLengthSqr o1, LengthSqrMassPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthSqrMassPerTime o1, TimeSqrPerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(TimeSqrPerLengthSqr o1, LengthSqrMassTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthSqrMassTime o1, TimeSqrPerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimeSqrPerLengthSqr o1, LengthCubPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthCubPerMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimeSqrPerLengthSqr o1, LengthCubPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubPerTime o1, TimeSqrPerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(TimeSqrPerLengthSqr o1, LengthCubTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTime o1, TimeSqrPerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimeSqrPerLengthSqr o1, LengthCubMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator/(TimeSqrPerLengthSqr o1, PerMassTimeLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator/(TimeSqrPerLengthSqr o1, TimePerMassLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(TimePerMassLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator/(TimeSqrPerLengthSqr o1, TimeSqrPerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeSqrPerLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(TimeSqrPerLengthSqr o1, MassPerTimeLengthCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrPerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(TimeSqrPerLengthSqr o1, MassTimePerLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassTimePerLengthCub o1, TimeSqrPerLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static Mass operator/(TimeSqrPerLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimeSqrPerLengthSqr o1, TimeCubPerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimeSqrPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeSqrMassPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthMassTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerLengthMassTimeCub o1, TimeSqrPerLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator/(TimeSqrPerLengthSqr o1, TimeCubPerLengthMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeCubPerLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(TimeSqrPerLengthSqr o1, MassPerLengthTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerLengthTimeCub o1, TimeSqrPerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator/(TimeSqrPerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeCubMassPerLength o1, TimeSqrPerLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimeSqrPerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(LengthPerMassTimeCub o1, TimeSqrPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthCub operator/(TimeSqrPerLengthSqr o1, TimeCubLengthPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(TimeCubLengthPerMass o1, TimeSqrPerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(TimeSqrPerLengthSqr o1, LengthMassPerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(LengthMassPerTimeCub o1, TimeSqrPerLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthCub operator/(TimeSqrPerLengthSqr o1, TimeCubLengthMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(TimeCubLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeSqrPerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthSqrPerMassTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimeSqrPerLengthSqr o1, LengthSqrPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimeSqrPerLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(TimeSqrPerLengthSqr o1, LengthCubPerMassTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthCubPerMassTime o1, TimeSqrPerLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(TimeSqrPerLengthSqr o1, LengthCubTimePerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthCubTimePerMass o1, TimeSqrPerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(TimeSqrPerLengthSqr o1, LengthCubPerTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubPerTimeSqr o1, TimeSqrPerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(TimeSqrPerLengthSqr o1, LengthCubMassPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubMassPerTime o1, TimeSqrPerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(TimeSqrPerLengthSqr o1, LengthCubMassTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthCubMassTime o1, TimeSqrPerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(TimeSqrPerLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static Speed operator/(TimeSqrPerLengthSqr o1, TimeCubPerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeCubPerLengthCub o1, TimeSqrPerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator/(TimeSqrPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(TimeSqrMassPerLengthCub o1, TimeSqrPerLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(TimeSqrPerLengthSqr o1, TimeCubPerMassLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubMassPerLengthSqr o1, TimeSqrPerLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrPerLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(TimeSqrPerLengthSqr o1, LengthSqrMassPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(TimeSqrPerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerMassTimeSqr o1, TimeSqrPerLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(TimeSqrPerLengthSqr o1, LengthCubPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubPerTimeCub o1, TimeSqrPerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(TimeSqrPerLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(TimeSqrPerLengthSqr o1, TimeCubPerMassLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeCubPerMassLengthCub o1, TimeSqrPerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(TimeSqrPerLengthSqr o1, TimeCubMassPerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubMassPerLengthCub o1, TimeSqrPerLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(TimeSqrPerLengthSqr o1, LengthCubPerMassTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubPerMassTimeCub o1, TimeSqrPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(TimeSqrPerLengthSqr o1, LengthCubMassPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerLengthSqr is outside its bounds.");
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
    