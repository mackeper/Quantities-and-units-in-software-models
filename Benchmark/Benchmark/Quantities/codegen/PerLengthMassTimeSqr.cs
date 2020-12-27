
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthMassTimeSqr : Quantity, IEquatable<PerLengthMassTimeSqr>, IComparable
  {  
    internal PerLengthMassTimeSqr(double value) : base(value, 2)
    {
      PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthMassTimeSqr(PerLengthMassTimeSqr other) : base(other)
    {
      PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMassTimeSqr"))
    {
      switch(FakeDatabase.Units["PerLengthMassTimeSqr"])
      {
        case "percentimeterkilogramsecondsqr": displayUnit_ = percentimeterkilogramsecondsqr_; break;
        case "permillimeterkilogramsecondsqr": displayUnit_ = permillimeterkilogramsecondsqr_; break;
        case "permeterkilogramsecondsqr": displayUnit_ = permeterkilogramsecondsqr_; break;
        case "perinchkilogramsecondsqr": displayUnit_ = perinchkilogramsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimeterkilogramsecondsqr_ = new Unit_("PerCentimeterKilogramSecondSqr", "/cm kg s²", 1.0, 0);
  private static Unit_ permillimeterkilogramsecondsqr_ = new Unit_("PerMillimeterKilogramSecondSqr", "/mm kg s²", 0.1, 0);
  private static Unit_ permeterkilogramsecondsqr_ = new Unit_("PerMeterKilogramSecondSqr", "/m kg s²", 100.0, 0);
  private static Unit_ perinchkilogramsecondsqr_ = new Unit_("PerInchKilogramSecondSqr", "/in kg s²", 2.56, 0);
  private static Unit_ platformUnit_ = percentimeterkilogramsecondsqr_;
  private static Unit_ displayUnit_ = percentimeterkilogramsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthMassTimeSqr other && Equals(other);
  public bool Equals(PerLengthMassTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthMassTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthMassTimeSqr other)) throw new ArgumentException("Object is not a PerLengthMassTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => !(l1 == l2);
  public static bool operator <(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthMassTimeSqr FromPerCentimeterKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr((value + percentimeterkilogramsecondsqr_.Offset) * percentimeterkilogramsecondsqr_.Factor, minValue * percentimeterkilogramsecondsqr_.Factor, maxValue * percentimeterkilogramsecondsqr_.Factor);
  public static PerLengthMassTimeSqr FromPerCentimeterKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr((value + percentimeterkilogramsecondsqr_.Offset) * percentimeterkilogramsecondsqr_.Factor);
  public double GetValueInPerCentimeterKilogramSecondSqrs() => (Value_ - percentimeterkilogramsecondsqr_.Offset) / percentimeterkilogramsecondsqr_.Factor;
  public static PerLengthMassTimeSqr FromPerMillimeterKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr((value + permillimeterkilogramsecondsqr_.Offset) * permillimeterkilogramsecondsqr_.Factor, minValue * permillimeterkilogramsecondsqr_.Factor, maxValue * permillimeterkilogramsecondsqr_.Factor);
  public static PerLengthMassTimeSqr FromPerMillimeterKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr((value + permillimeterkilogramsecondsqr_.Offset) * permillimeterkilogramsecondsqr_.Factor);
  public double GetValueInPerMillimeterKilogramSecondSqrs() => (Value_ - permillimeterkilogramsecondsqr_.Offset) / permillimeterkilogramsecondsqr_.Factor;
  public static PerLengthMassTimeSqr FromPerMeterKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr((value + permeterkilogramsecondsqr_.Offset) * permeterkilogramsecondsqr_.Factor, minValue * permeterkilogramsecondsqr_.Factor, maxValue * permeterkilogramsecondsqr_.Factor);
  public static PerLengthMassTimeSqr FromPerMeterKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr((value + permeterkilogramsecondsqr_.Offset) * permeterkilogramsecondsqr_.Factor);
  public double GetValueInPerMeterKilogramSecondSqrs() => (Value_ - permeterkilogramsecondsqr_.Offset) / permeterkilogramsecondsqr_.Factor;
  public static PerLengthMassTimeSqr FromPerInchKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr((value + perinchkilogramsecondsqr_.Offset) * perinchkilogramsecondsqr_.Factor, minValue * perinchkilogramsecondsqr_.Factor, maxValue * perinchkilogramsecondsqr_.Factor);
  public static PerLengthMassTimeSqr FromPerInchKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr((value + perinchkilogramsecondsqr_.Offset) * perinchkilogramsecondsqr_.Factor);
  public double GetValueInPerInchKilogramSecondSqrs() => (Value_ - perinchkilogramsecondsqr_.Offset) / perinchkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
  public static PerLengthMassTimeSqr operator+(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ + o2.Value_);
  public static PerLengthMassTimeSqr operator-(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerLengthTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthMassTimeSqr o1, TimeCubPerLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeCubPerLength o1, PerLengthMassTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(PerLengthMassTimeSqr o1, TimeSqrMassPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthMassTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(PerLengthMassTimeSqr o1, PerMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerMassTimeCub o1, PerLengthMassTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(PerLengthMassTimeSqr o1, TimeCubMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubMass o1, PerLengthMassTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthPerMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthPerTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerLengthMassTimeSqr o1, TimeCubLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeCubLength o1, PerLengthMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthMassTimeSqr o1, TimeSqrLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeSqrLengthMass o1, PerLengthMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthSqrPerMassTime o1, PerLengthMassTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerLengthMassTimeSqr o1, LengthSqrTimePerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthSqrTimePerMass o1, PerLengthMassTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator/(PerLengthMassTimeSqr o1, QDose o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(QDose o1, PerLengthMassTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerLengthMassTimeSqr o1, LengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrTimeSqr o1, PerLengthMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(PerLengthMassTimeSqr o1, LengthSqrMassPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthSqrMassPerTime o1, PerLengthMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerLengthMassTimeSqr o1, LengthSqrMassTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrMassTime o1, PerLengthMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(PerLengthMassTimeSqr o1, LengthCubPerTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthCubPerTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerLengthMassTimeSqr o1, LengthCubTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static QDose operator*(PerLengthMassTimeSqr o1, LengthCubMass o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubMass o1, PerLengthMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(PerLengthMassTimeSqr o1, PerMassTimeLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(PerLengthMassTimeSqr o1, TimePerMassLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimePerMassLengthCub o1, PerLengthMassTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerLengthMassTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(PerLengthMassTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerMassLengthSqrTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(PerLengthSqrTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerLengthMassTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator*(PerLengthMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerLengthMassTimeSqr o1, PerLengthMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerLengthMassTimeCub o1, PerLengthMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(PerLengthMassTimeSqr o1, TimeCubMassPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthPerMassTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(PerLengthMassTimeSqr o1, TimeCubLengthMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubLengthMass o1, PerLengthMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrPerMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrPerTimeCub o1, PerLengthMassTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerLengthMassTimeSqr o1, TimeCubLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimeCubLengthSqr o1, PerLengthMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerLengthMassTimeSqr o1, LengthSqrTimeSqrMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrTimeSqrMass o1, PerLengthMassTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator*(PerLengthMassTimeSqr o1, LengthCubTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubTimeSqr o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(PerLengthMassTimeSqr o1, LengthCubMassPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthCubMassPerTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(PerLengthMassTimeSqr o1, LengthCubMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubMassTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static Area operator/(PerLengthMassTimeSqr o1, PerMassTimeSqrLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthCubTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(PerLengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(PerLengthMassTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerMassLengthSqrTimeCub o1, PerLengthMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(PerLengthMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrPerMassTimeCub o1, PerLengthMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(PerLengthMassTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(TimeCubLengthSqrMass o1, PerLengthMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator*(PerLengthMassTimeSqr o1, LengthCubTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(PerLengthMassTimeSqr o1, LengthCubTimeSqrMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubTimeSqrMass o1, PerLengthMassTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(PerLengthMassTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerMassLengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(PerLengthMassTimeSqr o1, LengthCubTimeCubMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubTimeCubMass o1, PerLengthMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthMassTimeSqr is outside its bounds.");
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
    