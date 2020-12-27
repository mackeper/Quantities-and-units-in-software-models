
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthSqrTimeSqr : Quantity, IEquatable<PerLengthSqrTimeSqr>, IComparable
  {  
    internal PerLengthSqrTimeSqr(double value) : base(value, 2)
    {
      PerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthSqrTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthSqrTimeSqr(PerLengthSqrTimeSqr other) : base(other)
    {
      PerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthSqrTimeSqr"))
    {
      switch(FakeDatabase.Units["PerLengthSqrTimeSqr"])
      {
        case "percentimetersqrsecondsqr": displayUnit_ = percentimetersqrsecondsqr_; break;
        case "permillimetersqrsecondsqr": displayUnit_ = permillimetersqrsecondsqr_; break;
        case "permetersqrsecondsqr": displayUnit_ = permetersqrsecondsqr_; break;
        case "perinchsqrsecondsqr": displayUnit_ = perinchsqrsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimetersqrsecondsqr_ = new Unit_("PerCentimeterSqrSecondSqr", "/cm² s²", 1.0, 0);
  private static Unit_ permillimetersqrsecondsqr_ = new Unit_("PerMillimeterSqrSecondSqr", "/mm² s²", 0.010000000000000002, 0);
  private static Unit_ permetersqrsecondsqr_ = new Unit_("PerMeterSqrSecondSqr", "/m² s²", 10000.0, 0);
  private static Unit_ perinchsqrsecondsqr_ = new Unit_("PerInchSqrSecondSqr", "/in² s²", 6.5536, 0);
  private static Unit_ platformUnit_ = percentimetersqrsecondsqr_;
  private static Unit_ displayUnit_ = percentimetersqrsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthSqrTimeSqr other && Equals(other);
  public bool Equals(PerLengthSqrTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthSqrTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthSqrTimeSqr other)) throw new ArgumentException("Object is not a PerLengthSqrTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => !(l1 == l2);
  public static bool operator <(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthSqrTimeSqr l1, PerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthSqrTimeSqr FromPerCentimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerLengthSqrTimeSqr((value + percentimetersqrsecondsqr_.Offset) * percentimetersqrsecondsqr_.Factor, minValue * percentimetersqrsecondsqr_.Factor, maxValue * percentimetersqrsecondsqr_.Factor);
  public static PerLengthSqrTimeSqr FromPerCentimeterSqrSecondSqrs(double value) => new PerLengthSqrTimeSqr((value + percentimetersqrsecondsqr_.Offset) * percentimetersqrsecondsqr_.Factor);
  public double GetValueInPerCentimeterSqrSecondSqrs() => (Value_ - percentimetersqrsecondsqr_.Offset) / percentimetersqrsecondsqr_.Factor;
  public static PerLengthSqrTimeSqr FromPerMillimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerLengthSqrTimeSqr((value + permillimetersqrsecondsqr_.Offset) * permillimetersqrsecondsqr_.Factor, minValue * permillimetersqrsecondsqr_.Factor, maxValue * permillimetersqrsecondsqr_.Factor);
  public static PerLengthSqrTimeSqr FromPerMillimeterSqrSecondSqrs(double value) => new PerLengthSqrTimeSqr((value + permillimetersqrsecondsqr_.Offset) * permillimetersqrsecondsqr_.Factor);
  public double GetValueInPerMillimeterSqrSecondSqrs() => (Value_ - permillimetersqrsecondsqr_.Offset) / permillimetersqrsecondsqr_.Factor;
  public static PerLengthSqrTimeSqr FromPerMeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerLengthSqrTimeSqr((value + permetersqrsecondsqr_.Offset) * permetersqrsecondsqr_.Factor, minValue * permetersqrsecondsqr_.Factor, maxValue * permetersqrsecondsqr_.Factor);
  public static PerLengthSqrTimeSqr FromPerMeterSqrSecondSqrs(double value) => new PerLengthSqrTimeSqr((value + permetersqrsecondsqr_.Offset) * permetersqrsecondsqr_.Factor);
  public double GetValueInPerMeterSqrSecondSqrs() => (Value_ - permetersqrsecondsqr_.Offset) / permetersqrsecondsqr_.Factor;
  public static PerLengthSqrTimeSqr FromPerInchSqrSecondSqrs(double value, double minValue, double maxValue) => new PerLengthSqrTimeSqr((value + perinchsqrsecondsqr_.Offset) * perinchsqrsecondsqr_.Factor, minValue * perinchsqrsecondsqr_.Factor, maxValue * perinchsqrsecondsqr_.Factor);
  public static PerLengthSqrTimeSqr FromPerInchSqrSecondSqrs(double value) => new PerLengthSqrTimeSqr((value + perinchsqrsecondsqr_.Offset) * perinchsqrsecondsqr_.Factor);
  public double GetValueInPerInchSqrSecondSqrs() => (Value_ - perinchsqrsecondsqr_.Offset) / perinchsqrsecondsqr_.Factor;

#endregion

#region arithmetic
  public static PerLengthSqrTimeSqr operator+(PerLengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ + o2.Value_);
  public static PerLengthSqrTimeSqr operator-(PerLengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(PerLengthSqrTimeSqr o1, MassPerTimeLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassPerTimeLengthSqr o1, PerLengthSqrTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(PerLengthSqrTimeSqr o1, MassTimePerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(MassTimePerLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(PerLengthSqrTimeSqr o1, PerLengthMassTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(PerLengthMassTimeSqr o1, PerLengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(PerLengthSqrTimeSqr o1, TimeSqrPerLengthMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(TimeSqrPerLengthMass o1, PerLengthSqrTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(PerLengthSqrTimeSqr o1, PerLengthTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerLengthTimeCub o1, PerLengthSqrTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(PerLengthSqrTimeSqr o1, TimeCubPerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeCubPerLength o1, PerLengthSqrTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(PerLengthSqrTimeSqr o1, MassPerLengthTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassPerLengthTimeSqr o1, PerLengthSqrTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static Density operator*(PerLengthSqrTimeSqr o1, TimeSqrMassPerLength o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(TimeSqrMassPerLength o1, PerLengthSqrTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(PerLengthSqrTimeSqr o1, PerMassTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(PerMassTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthSqrTimeSqr o1, TimeCubPerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeCubPerMass o1, PerLengthSqrTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator/(PerLengthSqrTimeSqr o1, MassPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(MassPerTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(PerLengthSqrTimeSqr o1, TimeCubMass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimeCubMass o1, PerLengthSqrTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Density operator/(PerLengthSqrTimeSqr o1, LengthPerMassTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthPerMassTimeSqr o1, PerLengthSqrTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(PerLengthSqrTimeSqr o1, TimeSqrLengthPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeSqrLengthPerMass o1, PerLengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerLengthSqrTimeSqr o1, LengthPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthPerTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(PerLengthSqrTimeSqr o1, TimeCubLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubLength o1, PerLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(PerLengthSqrTimeSqr o1, Force o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(Force o1, PerLengthSqrTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(PerLengthSqrTimeSqr o1, TimeSqrLengthMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeSqrLengthMass o1, PerLengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(PerLengthSqrTimeSqr o1, LengthSqrPerMassTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthSqrPerMassTime o1, PerLengthSqrTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(PerLengthSqrTimeSqr o1, LengthSqrTimePerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrTimePerMass o1, PerLengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(PerLengthSqrTimeSqr o1, LengthSqrMassPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(LengthSqrMassPerTime o1, PerLengthSqrTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(PerLengthSqrTimeSqr o1, LengthSqrMassTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthSqrMassTime o1, PerLengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerLengthSqrTimeSqr o1, LengthCubPerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthCubPerMass o1, PerLengthSqrTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(PerLengthSqrTimeSqr o1, LengthCubPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthCubPerTime o1, PerLengthSqrTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerLengthSqrTimeSqr o1, LengthCubTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubTime o1, PerLengthSqrTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Force operator*(PerLengthSqrTimeSqr o1, LengthCubMass o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubMass o1, PerLengthSqrTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(PerLengthSqrTimeSqr o1, PerMassTimeLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(PerMassTimeLengthCub o1, PerLengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerMassLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimePerMassLengthCub o1, PerLengthSqrTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(PerLengthSqrTimeSqr o1, PerTimeSqrLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerTimeSqrLengthCub o1, PerLengthSqrTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(PerLengthSqrTimeSqr o1, MassPerTimeLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(MassPerTimeLengthCub o1, PerLengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator/(PerLengthSqrTimeSqr o1, MassTimePerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(MassTimePerLengthCub o1, PerLengthSqrTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(PerLengthSqrTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerMassLengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(PerLengthSqrTimeSqr o1, PerLengthSqrTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerLengthSqrTimeCub o1, PerLengthSqrTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(PerLengthSqrTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassPerLengthSqrTimeSqr o1, PerLengthSqrTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(PerLengthSqrTimeSqr o1, PerLengthMassTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(PerLengthMassTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerLengthSqrTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimeCubPerLengthMass o1, PerLengthSqrTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator/(PerLengthSqrTimeSqr o1, MassPerLengthTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(MassPerLengthTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(PerLengthSqrTimeSqr o1, TimeCubMassPerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(TimeCubMassPerLength o1, PerLengthSqrTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator/(PerLengthSqrTimeSqr o1, LengthPerMassTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthPerMassTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(PerLengthSqrTimeSqr o1, TimeCubLengthPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeCubLengthPerMass o1, PerLengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthCub operator/(PerLengthSqrTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthMassPerTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(PerLengthSqrTimeSqr o1, TimeCubLengthMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeCubLengthMass o1, PerLengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(PerLengthSqrTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthSqrTimeSqrPerMass o1, PerLengthSqrTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerLengthSqrTimeSqr o1, TimeCubLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubLengthSqr o1, PerLengthSqrTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Mass operator*(PerLengthSqrTimeSqr o1, LengthSqrTimeSqrMass o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthSqrTimeSqrMass o1, PerLengthSqrTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(PerLengthSqrTimeSqr o1, LengthCubPerMassTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(LengthCubPerMassTime o1, PerLengthSqrTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(PerLengthSqrTimeSqr o1, LengthCubTimePerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubTimePerMass o1, PerLengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerLengthSqrTimeSqr o1, LengthCubTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimeSqr o1, PerLengthSqrTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(PerLengthSqrTimeSqr o1, LengthCubMassPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthCubMassPerTime o1, PerLengthSqrTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(PerLengthSqrTimeSqr o1, LengthCubMassTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubMassTime o1, PerLengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(PerLengthSqrTimeSqr o1, PerMassTimeSqrLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(PerMassTimeSqrLengthCub o1, PerLengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(PerLengthSqrTimeSqr o1, PerLengthCubTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerLengthCubTimeCub o1, PerLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator/(PerLengthSqrTimeSqr o1, MassPerTimeSqrLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassPerTimeSqrLengthCub o1, PerLengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static MassTime operator/(PerLengthSqrTimeSqr o1, PerMassLengthSqrTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(PerMassLengthSqrTimeCub o1, PerLengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerLengthSqrTimeSqr o1, MassPerLengthSqrTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerLengthSqrTimeCub o1, PerLengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerLengthSqrTimeSqr o1, TimeCubLengthSqrPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(PerLengthSqrTimeSqr o1, TimeCubLengthSqrMass o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeCubLengthSqrMass o1, PerLengthSqrTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(PerLengthSqrTimeSqr o1, LengthCubTimeSqrPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubTimeSqrPerMass o1, PerLengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(PerLengthSqrTimeSqr o1, LengthCubTimeCub o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(PerLengthSqrTimeSqr o1, LengthCubTimeSqrMass o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubTimeSqrMass o1, PerLengthSqrTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(PerLengthSqrTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassLengthCubTimeCub o1, PerLengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(PerLengthSqrTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerLengthCubTimeCub o1, PerLengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerLengthSqrTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthCubTimeCubPerMass o1, PerLengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(PerLengthSqrTimeSqr o1, LengthCubTimeCubMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubTimeCubMass o1, PerLengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthSqrTimeSqr is outside its bounds.");
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
    