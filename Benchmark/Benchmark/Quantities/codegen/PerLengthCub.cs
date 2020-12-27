
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthCub : Quantity, IEquatable<PerLengthCub>, IComparable
  {  
    internal PerLengthCub(double value) : base(value, 2)
    {
      PerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthCub(PerLengthCub other) : base(other)
    {
      PerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthCub"))
    {
      switch(FakeDatabase.Units["PerLengthCub"])
      {
        case "percentimetercub": displayUnit_ = percentimetercub_; break;
        case "permillimetercub": displayUnit_ = permillimetercub_; break;
        case "permetercub": displayUnit_ = permetercub_; break;
        case "perinchcub": displayUnit_ = perinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimetercub_ = new Unit_("PerCentimeterCub", "/cm�", 1.0, 0);
  private static Unit_ permillimetercub_ = new Unit_("PerMillimeterCub", "/mm�", 0.001, 0);
  private static Unit_ permetercub_ = new Unit_("PerMeterCub", "/m�", 1000000.0, 0);
  private static Unit_ perinchcub_ = new Unit_("PerInchCub", "/in�", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = percentimetercub_;
  private static Unit_ displayUnit_ = percentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthCub other && Equals(other);
  public bool Equals(PerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthCub other)) throw new ArgumentException("Object is not a PerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthCub l1, PerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthCub l1, PerLengthCub l2) => !(l1 == l2);
  public static bool operator <(PerLengthCub l1, PerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthCub l1, PerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthCub l1, PerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthCub l1, PerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthCub FromPerCentimeterCubs(double value, double minValue, double maxValue) => new PerLengthCub((value + percentimetercub_.Offset) * percentimetercub_.Factor, minValue * percentimetercub_.Factor, maxValue * percentimetercub_.Factor);
  public static PerLengthCub FromPerCentimeterCubs(double value) => new PerLengthCub((value + percentimetercub_.Offset) * percentimetercub_.Factor);
  public double GetValueInPerCentimeterCubs() => (Value_ - percentimetercub_.Offset) / percentimetercub_.Factor;
  public static PerLengthCub FromPerMillimeterCubs(double value, double minValue, double maxValue) => new PerLengthCub((value + permillimetercub_.Offset) * permillimetercub_.Factor, minValue * permillimetercub_.Factor, maxValue * permillimetercub_.Factor);
  public static PerLengthCub FromPerMillimeterCubs(double value) => new PerLengthCub((value + permillimetercub_.Offset) * permillimetercub_.Factor);
  public double GetValueInPerMillimeterCubs() => (Value_ - permillimetercub_.Offset) / permillimetercub_.Factor;
  public static PerLengthCub FromPerMeterCubs(double value, double minValue, double maxValue) => new PerLengthCub((value + permetercub_.Offset) * permetercub_.Factor, minValue * permetercub_.Factor, maxValue * permetercub_.Factor);
  public static PerLengthCub FromPerMeterCubs(double value) => new PerLengthCub((value + permetercub_.Offset) * permetercub_.Factor);
  public double GetValueInPerMeterCubs() => (Value_ - permetercub_.Offset) / permetercub_.Factor;
  public static PerLengthCub FromPerInchCubs(double value, double minValue, double maxValue) => new PerLengthCub((value + perinchcub_.Offset) * perinchcub_.Factor, minValue * perinchcub_.Factor, maxValue * perinchcub_.Factor);
  public static PerLengthCub FromPerInchCubs(double value) => new PerLengthCub((value + perinchcub_.Offset) * perinchcub_.Factor);
  public double GetValueInPerInchCubs() => (Value_ - perinchcub_.Offset) / perinchcub_.Factor;

#endregion

#region arithmetic
  public static PerLengthCub operator+(PerLengthCub o1, PerLengthCub o2) => new PerLengthCub(o1.Value_ + o2.Value_);
  public static PerLengthCub operator-(PerLengthCub o1, PerLengthCub o2) => new PerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthCub o1, PerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(PerLengthCub o1, PerMassLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(PerMassLengthSqr o1, PerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(PerLengthCub o1, PerTimeLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerTimeLengthSqr o1, PerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(PerLengthCub o1, TimePerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimePerLengthSqr o1, PerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(PerLengthCub o1, MassPerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassPerLengthSqr o1, PerLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(PerLengthCub o1, PerLengthMassTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(PerLengthMassTime o1, PerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(PerLengthCub o1, TimePerLengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimePerLengthMass o1, PerLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerLengthCub o1, PerLengthTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(PerLengthTimeSqr o1, PerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerLengthCub o1, TimeSqrPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeSqrPerLength o1, PerLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(PerLengthCub o1, MassPerLengthTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(MassPerLengthTime o1, PerLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(PerLengthCub o1, MassTimePerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(MassTimePerLength o1, PerLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(PerLengthCub o1, PerMassTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerMassTimeSqr o1, PerLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(PerLengthCub o1, PerMassTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(PerMassTimeSqr o1, PerLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(PerLengthCub o1, TimeSqrPerMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeSqrPerMass o1, PerLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(PerLengthCub o1, TimeSqrPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeSqrPerMass o1, PerLengthCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerLengthCub o1, PerTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerTimeCub o1, PerLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(PerLengthCub o1, PerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(PerTimeCub o1, PerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator*(PerLengthCub o1, TimeCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCub o1, PerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthCub o1, TimeCub o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(TimeCub o1, PerLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(PerLengthCub o1, MassPerTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerTimeSqr o1, PerLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(PerLengthCub o1, MassPerTimeSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(MassPerTimeSqr o1, PerLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(PerLengthCub o1, TimeSqrMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeSqrMass o1, PerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthCub o1, TimeSqrMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeSqrMass o1, PerLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(PerLengthCub o1, LengthPerMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(LengthPerMassTime o1, PerLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthCub o1, LengthTimePerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(LengthTimePerMass o1, PerLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(PerLengthCub o1, Acceleration o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(Acceleration o1, PerLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerLengthCub o1, TimeSqrLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrLength o1, PerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(PerLengthCub o1, LengthMassPerTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(LengthMassPerTime o1, PerLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(PerLengthCub o1, LengthMassTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(LengthMassTime o1, PerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(PerLengthCub o1, LengthSqrPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthSqrPerMass o1, PerLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(PerLengthCub o1, LengthSqrPerTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrPerTime o1, PerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(PerLengthCub o1, LengthSqrTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(LengthSqrTime o1, PerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(PerLengthCub o1, LengthSqrMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthSqrMass o1, PerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthCub o1, Volume o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Volume o1, PerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static Mass operator/(PerLengthCub o1, PerMassLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerMassLengthCub o1, PerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(PerLengthCub o1, PerTimeLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerTimeLengthCub o1, PerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(PerLengthCub o1, TimePerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimePerLengthCub o1, PerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(PerLengthCub o1, Density o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(Density o1, PerLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(PerLengthCub o1, PerMassTimeLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(PerMassTimeLengthSqr o1, PerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(PerLengthCub o1, TimePerMassLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimePerMassLengthSqr o1, PerLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(PerLengthCub o1, PerLengthSqrTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerLengthSqrTimeSqr o1, PerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(PerLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrPerLengthSqr o1, PerLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(PerLengthCub o1, MassPerTimeLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(MassPerTimeLengthSqr o1, PerLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(PerLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(MassTimePerLengthSqr o1, PerLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(PerLengthCub o1, PerLengthMassTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(PerLengthMassTimeSqr o1, PerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(PerLengthCub o1, TimeSqrPerLengthMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(TimeSqrPerLengthMass o1, PerLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(PerLengthCub o1, PerLengthTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(PerLengthTimeCub o1, PerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(PerLengthCub o1, TimeCubPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubPerLength o1, PerLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(PerLengthCub o1, MassPerLengthTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(MassPerLengthTimeSqr o1, PerLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(PerLengthCub o1, TimeSqrMassPerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(TimeSqrMassPerLength o1, PerLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerLengthCub o1, PerMassTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerMassTimeCub o1, PerLengthCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(PerLengthCub o1, PerMassTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(PerMassTimeCub o1, PerLengthCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(PerLengthCub o1, TimeCubPerMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeCubPerMass o1, PerLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(PerLengthCub o1, TimeCubPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(TimeCubPerMass o1, PerLengthCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(PerLengthCub o1, MassPerTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(MassPerTimeCub o1, PerLengthCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(PerLengthCub o1, MassPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(MassPerTimeCub o1, PerLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(PerLengthCub o1, TimeCubMass o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeCubMass o1, PerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthCub o1, TimeCubMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(TimeCubMass o1, PerLengthCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(PerLengthCub o1, LengthPerMassTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(LengthPerMassTimeSqr o1, PerLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(PerLengthCub o1, TimeSqrLengthPerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrLengthPerMass o1, PerLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerLengthCub o1, LengthPerTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(LengthPerTimeCub o1, PerLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(PerLengthCub o1, TimeCubLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubLength o1, PerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(PerLengthCub o1, Force o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(Force o1, PerLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(PerLengthCub o1, TimeSqrLengthMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrLengthMass o1, PerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator*(PerLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(LengthSqrPerMassTime o1, PerLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(PerLengthCub o1, LengthSqrTimePerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(LengthSqrTimePerMass o1, PerLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(PerLengthCub o1, QDose o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(QDose o1, PerLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(PerLengthCub o1, LengthSqrTimeSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(LengthSqrTimeSqr o1, PerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(PerLengthCub o1, LengthSqrMassPerTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(LengthSqrMassPerTime o1, PerLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(PerLengthCub o1, LengthSqrMassTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(LengthSqrMassTime o1, PerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(PerLengthCub o1, LengthCubPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthCubPerMass o1, PerLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(PerLengthCub o1, LengthCubPerTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubPerTime o1, PerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerLengthCub o1, LengthCubTime o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthCubTime o1, PerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Mass operator*(PerLengthCub o1, LengthCubMass o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthCubMass o1, PerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static MassTime operator/(PerLengthCub o1, PerMassTimeLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(PerMassTimeLengthCub o1, PerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(PerLengthCub o1, TimePerMassLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimePerMassLengthCub o1, PerLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(PerLengthCub o1, PerTimeSqrLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerTimeSqrLengthCub o1, PerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(PerLengthCub o1, TimeSqrPerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrPerLengthCub o1, PerLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerLengthCub o1, MassPerTimeLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerTimeLengthCub o1, PerLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(PerLengthCub o1, MassTimePerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassTimePerLengthCub o1, PerLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(PerLengthCub o1, PerMassLengthSqrTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerMassLengthSqrTimeSqr o1, PerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(PerLengthCub o1, TimeSqrPerMassLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeSqrPerMassLengthSqr o1, PerLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(PerLengthCub o1, PerLengthSqrTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthSqrTimeCub o1, PerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubPerLengthSqr o1, PerLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(PerLengthCub o1, MassPerLengthSqrTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(MassPerLengthSqrTimeSqr o1, PerLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(PerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeSqrMassPerLengthSqr o1, PerLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(PerLengthCub o1, PerLengthMassTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(PerLengthMassTimeCub o1, PerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(PerLengthCub o1, TimeCubPerLengthMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(TimeCubPerLengthMass o1, PerLengthCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(PerLengthCub o1, MassPerLengthTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(MassPerLengthTimeCub o1, PerLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(PerLengthCub o1, TimeCubMassPerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeCubMassPerLength o1, PerLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(PerLengthCub o1, LengthPerMassTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(LengthPerMassTimeCub o1, PerLengthCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(PerLengthCub o1, TimeCubLengthPerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCubLengthPerMass o1, PerLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(PerLengthCub o1, LengthMassPerTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(LengthMassPerTimeCub o1, PerLengthCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(PerLengthCub o1, TimeCubLengthMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCubLengthMass o1, PerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(PerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(LengthSqrPerMassTimeSqr o1, PerLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerLengthCub o1, LengthSqrTimeSqrPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(LengthSqrTimeSqrPerMass o1, PerLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(PerLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(LengthSqrPerTimeCub o1, PerLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(PerLengthCub o1, TimeCubLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubLengthSqr o1, PerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(PerLengthCub o1, LengthSqrMassPerTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(LengthSqrMassPerTimeSqr o1, PerLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(PerLengthCub o1, LengthSqrTimeSqrMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(LengthSqrTimeSqrMass o1, PerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(PerLengthCub o1, LengthCubPerMassTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubPerMassTime o1, PerLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(PerLengthCub o1, LengthCubTimePerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubTimePerMass o1, PerLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(PerLengthCub o1, LengthCubPerTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthCubPerTimeSqr o1, PerLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(PerLengthCub o1, LengthCubTimeSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthCubTimeSqr o1, PerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(PerLengthCub o1, LengthCubMassPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubMassPerTime o1, PerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(PerLengthCub o1, LengthCubMassTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthCubMassTime o1, PerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator/(PerLengthCub o1, PerMassTimeSqrLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(PerLengthCub o1, TimeSqrPerMassLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqrPerMassLengthCub o1, PerLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(PerLengthCub o1, PerLengthCubTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerLengthCubTimeCub o1, PerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(PerLengthCub o1, TimeCubPerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubPerLengthCub o1, PerLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(PerLengthCub o1, MassPerTimeSqrLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerTimeSqrLengthCub o1, PerLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(PerLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrMassPerLengthCub o1, PerLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator/(PerLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(PerMassLengthSqrTimeCub o1, PerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator/(PerLengthCub o1, TimeCubPerMassLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubPerMassLengthSqr o1, PerLengthCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(PerLengthCub o1, MassPerLengthSqrTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(MassPerLengthSqrTimeCub o1, PerLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator/(PerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCubMassPerLengthSqr o1, PerLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(PerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(LengthSqrPerMassTimeCub o1, PerLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(PerLengthCub o1, TimeCubLengthSqrPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubLengthSqrPerMass o1, PerLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(PerLengthCub o1, LengthSqrMassPerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(LengthSqrMassPerTimeCub o1, PerLengthCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(PerLengthCub o1, TimeCubLengthSqrMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubLengthSqrMass o1, PerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(PerLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthCubPerMassTimeSqr o1, PerLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(PerLengthCub o1, LengthCubTimeSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthCubTimeSqrPerMass o1, PerLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(PerLengthCub o1, LengthCubPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthCubPerTimeCub o1, PerLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(PerLengthCub o1, LengthCubTimeCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthCubTimeCub o1, PerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(PerLengthCub o1, LengthCubMassPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthCubMassPerTimeSqr o1, PerLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(PerLengthCub o1, LengthCubTimeSqrMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(LengthCubTimeSqrMass o1, PerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator/(PerLengthCub o1, PerMassLengthCubTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerMassLengthCubTimeCub o1, PerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(PerLengthCub o1, TimeCubPerMassLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubPerMassLengthCub o1, PerLengthCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(PerLengthCub o1, MassPerLengthCubTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerLengthCubTimeCub o1, PerLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(PerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubMassPerLengthCub o1, PerLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(PerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthCubPerMassTimeCub o1, PerLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(PerLengthCub o1, LengthCubTimeCubPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthCubTimeCubPerMass o1, PerLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(PerLengthCub o1, LengthCubMassPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(LengthCubMassPerTimeCub o1, PerLengthCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(PerLengthCub o1, LengthCubTimeCubMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthCubTimeCubMass o1, PerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthCub is outside its bounds.");
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
    