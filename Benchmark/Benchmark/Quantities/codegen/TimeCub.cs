
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCub : Quantity, IEquatable<TimeCub>, IComparable
  {  
    internal TimeCub(double value) : base(value, 2)
    {
      TimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCub(TimeCub other) : base(other)
    {
      TimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCub"))
    {
      switch(FakeDatabase.Units["TimeCub"])
      {
        case "secondcub": displayUnit_ = secondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcub_ = new Unit_("SecondCub", "s³", 1, 0);
  private static Unit_ platformUnit_ = secondcub_;
  private static Unit_ displayUnit_ = secondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCub other && Equals(other);
  public bool Equals(TimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCub other)) throw new ArgumentException("Object is not a TimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCub l1, TimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCub l1, TimeCub l2) => !(l1 == l2);
  public static bool operator <(TimeCub l1, TimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCub l1, TimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCub l1, TimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCub l1, TimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCub FromSecondCubs(double value, double minValue, double maxValue) => new TimeCub((value + secondcub_.Offset) * secondcub_.Factor, minValue * secondcub_.Factor, maxValue * secondcub_.Factor);
  public static TimeCub FromSecondCubs(double value) => new TimeCub((value + secondcub_.Offset) * secondcub_.Factor);
  public double GetValueInSecondCubs() => (Value_ - secondcub_.Offset) / secondcub_.Factor;

#endregion

#region arithmetic
  public static TimeCub operator+(TimeCub o1, TimeCub o2) => new TimeCub(o1.Value_ + o2.Value_);
  public static TimeCub operator-(TimeCub o1, TimeCub o2) => new TimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCub o1, TimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(TimeCub o1, MassPerTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(MassPerTimeSqr o1, TimeCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator/(TimeCub o1, TimeSqrMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(TimeSqrMass o1, TimeCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimeCub o1, LengthPerMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthPerMassTime o1, TimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator/(TimeCub o1, LengthTimePerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthTimePerMass o1, TimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeCub o1, Acceleration o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(Acceleration o1, TimeCub o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(TimeCub o1, TimeSqrLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(TimeSqrLength o1, TimeCub o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimeCub o1, LengthMassPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthMassPerTime o1, TimeCub o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(TimeCub o1, LengthMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthMassTime o1, TimeCub o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(TimeCub o1, LengthSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthSqrPerMass o1, TimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCub o1, LengthSqrPerMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthSqrPerMass o1, TimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeCub o1, LengthSqrPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthSqrPerTime o1, TimeCub o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeCub o1, LengthSqrTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthSqrTime o1, TimeCub o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(TimeCub o1, LengthSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(LengthSqrMass o1, TimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCub o1, LengthSqrMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthSqrMass o1, TimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeCub o1, Volume o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(Volume o1, TimeCub o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCub o1, Volume o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(Volume o1, TimeCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(TimeCub o1, PerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(PerMassLengthCub o1, TimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(TimeCub o1, PerMassLengthCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassLengthCub o1, TimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(TimeCub o1, PerTimeLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(PerTimeLengthCub o1, TimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(TimeCub o1, TimePerLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(TimePerLengthCub o1, TimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(TimeCub o1, Density o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(Density o1, TimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(TimeCub o1, Density o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(Density o1, TimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(TimeCub o1, PerMassTimeLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(PerMassTimeLengthSqr o1, TimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(TimeCub o1, TimePerMassLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(TimePerMassLengthSqr o1, TimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeCub o1, PerLengthSqrTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerLengthSqrTimeSqr o1, TimeCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(TimeCub o1, TimeSqrPerLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimeSqrPerLengthSqr o1, TimeCub o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(TimeCub o1, MassPerTimeLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(MassPerTimeLengthSqr o1, TimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(TimeCub o1, MassTimePerLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassTimePerLengthSqr o1, TimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(TimeCub o1, PerLengthMassTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(PerLengthMassTimeSqr o1, TimeCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(TimeCub o1, TimeSqrPerLengthMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(TimeSqrPerLengthMass o1, TimeCub o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeCub o1, PerLengthTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthTimeCub o1, TimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCub o1, TimeCubPerLength o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubPerLength o1, TimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(TimeCub o1, MassPerLengthTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassPerLengthTimeSqr o1, TimeCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator/(TimeCub o1, TimeSqrMassPerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(TimeSqrMassPerLength o1, TimeCub o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeCub o1, PerMassTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassTimeCub o1, TimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeCub o1, TimeCubPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeCubPerMass o1, TimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static Mass operator*(TimeCub o1, MassPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerTimeCub o1, TimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(TimeCub o1, TimeCubMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeCubMass o1, TimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(TimeCub o1, LengthPerMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthPerMassTimeSqr o1, TimeCub o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator/(TimeCub o1, TimeSqrLengthPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(TimeSqrLengthPerMass o1, TimeCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCub o1, LengthPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthPerTimeCub o1, TimeCub o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCub o1, TimeCubLength o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(TimeCubLength o1, TimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(TimeCub o1, Force o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(Force o1, TimeCub o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator/(TimeCub o1, TimeSqrLengthMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(TimeSqrLengthMass o1, TimeCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(TimeCub o1, LengthSqrPerMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthSqrPerMassTime o1, TimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(TimeCub o1, LengthSqrTimePerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthSqrTimePerMass o1, TimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(TimeCub o1, QDose o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(QDose o1, TimeCub o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeCub o1, LengthSqrTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrTimeSqr o1, TimeCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(TimeCub o1, LengthSqrMassPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthSqrMassPerTime o1, TimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(TimeCub o1, LengthSqrMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthSqrMassTime o1, TimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(TimeCub o1, LengthCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(LengthCubPerMass o1, TimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCub o1, LengthCubPerMass o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthCubPerMass o1, TimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(TimeCub o1, LengthCubPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubPerTime o1, TimeCub o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(TimeCub o1, LengthCubTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubTime o1, TimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(TimeCub o1, LengthCubMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthCubMass o1, TimeCub o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCub o1, LengthCubMass o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthCubMass o1, TimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(TimeCub o1, PerMassTimeLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(PerMassTimeLengthCub o1, TimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrMass operator/(TimeCub o1, TimePerMassLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(TimePerMassLengthCub o1, TimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(TimeCub o1, PerTimeSqrLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(PerTimeSqrLengthCub o1, TimeCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(TimeCub o1, TimeSqrPerLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(TimeSqrPerLengthCub o1, TimeCub o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(TimeCub o1, MassPerTimeLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(MassPerTimeLengthCub o1, TimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator/(TimeCub o1, MassTimePerLengthCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassTimePerLengthCub o1, TimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(TimeCub o1, PerMassLengthSqrTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(PerMassLengthSqrTimeSqr o1, TimeCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(TimeCub o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(TimeSqrPerMassLengthSqr o1, TimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeCub o1, PerLengthSqrTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerLengthSqrTimeCub o1, TimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Area operator/(TimeCub o1, TimeCubPerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeCubPerLengthSqr o1, TimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(TimeCub o1, MassPerLengthSqrTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassPerLengthSqrTimeSqr o1, TimeCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator/(TimeCub o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(TimeSqrMassPerLengthSqr o1, TimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeCub o1, PerLengthMassTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerLengthMassTimeCub o1, TimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(TimeCub o1, TimeCubPerLengthMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimeCubPerLengthMass o1, TimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeCub o1, MassPerLengthTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerLengthTimeCub o1, TimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator/(TimeCub o1, TimeCubMassPerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(TimeCubMassPerLength o1, TimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeCub o1, LengthPerMassTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthPerMassTimeCub o1, TimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeCub o1, TimeCubLengthPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubLengthPerMass o1, TimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(TimeCub o1, LengthMassPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthMassPerTimeCub o1, TimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeCub o1, TimeCubLengthMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubLengthMass o1, TimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimeCub o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthSqrPerMassTimeSqr o1, TimeCub o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeCub o1, LengthSqrTimeSqrPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthSqrTimeSqrPerMass o1, TimeCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeCub o1, LengthSqrPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrPerTimeCub o1, TimeCub o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCub o1, TimeCubLengthSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeCubLengthSqr o1, TimeCub o2) => new Area(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeCub o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthSqrMassPerTimeSqr o1, TimeCub o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeCub o1, LengthSqrTimeSqrMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthSqrTimeSqrMass o1, TimeCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(TimeCub o1, LengthCubPerMassTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthCubPerMassTime o1, TimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(TimeCub o1, LengthCubTimePerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthCubTimePerMass o1, TimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeCub o1, LengthCubPerTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubPerTimeSqr o1, TimeCub o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(TimeCub o1, LengthCubTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubTimeSqr o1, TimeCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(TimeCub o1, LengthCubMassPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthCubMassPerTime o1, TimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator/(TimeCub o1, LengthCubMassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthCubMassTime o1, TimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(TimeCub o1, PerMassTimeSqrLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(PerMassTimeSqrLengthCub o1, TimeCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubMassTime operator/(TimeCub o1, TimeSqrPerMassLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(TimeSqrPerMassLengthCub o1, TimeCub o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeCub o1, PerLengthCubTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerLengthCubTimeCub o1, TimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeCub o1, TimeCubPerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeCubPerLengthCub o1, TimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(TimeCub o1, MassPerTimeSqrLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(MassPerTimeSqrLengthCub o1, TimeCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimePerMass operator/(TimeCub o1, TimeSqrMassPerLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(TimeSqrMassPerLengthCub o1, TimeCub o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeCub o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerMassLengthSqrTimeCub o1, TimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeCub o1, TimeCubPerMassLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeCubPerMassLengthSqr o1, TimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeCub o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerLengthSqrTimeCub o1, TimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeCub o1, TimeCubMassPerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeCubMassPerLengthSqr o1, TimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeCub o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthSqrPerMassTimeCub o1, TimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeCub o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(TimeCubLengthSqrPerMass o1, TimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(TimeCub o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthSqrMassPerTimeCub o1, TimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeCub o1, TimeCubLengthSqrMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(TimeCubLengthSqrMass o1, TimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(TimeCub o1, LengthCubPerMassTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthCubPerMassTimeSqr o1, TimeCub o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator/(TimeCub o1, LengthCubTimeSqrPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthCubTimeSqrPerMass o1, TimeCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeCub o1, LengthCubPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubPerTimeCub o1, TimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeCub o1, LengthCubTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubTimeCub o1, TimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(TimeCub o1, LengthCubMassPerTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthCubMassPerTimeSqr o1, TimeCub o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthCub operator/(TimeCub o1, LengthCubTimeSqrMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthCubTimeSqrMass o1, TimeCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeCub o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerMassLengthCubTimeCub o1, TimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator/(TimeCub o1, TimeCubPerMassLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(TimeCubPerMassLengthCub o1, TimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimeCub o1, MassPerLengthCubTimeCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthCubTimeCub o1, TimeCub o2) => new Density(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator/(TimeCub o1, TimeCubMassPerLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(TimeCubMassPerLengthCub o1, TimeCub o2) => new Density(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(TimeCub o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthCubPerMassTimeCub o1, TimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeCub o1, LengthCubTimeCubPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthCubTimeCubPerMass o1, TimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(TimeCub o1, LengthCubMassPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthCubMassPerTimeCub o1, TimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeCub o1, LengthCubTimeCubMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthCubTimeCubMass o1, TimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeCub is outside its bounds.");
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
    