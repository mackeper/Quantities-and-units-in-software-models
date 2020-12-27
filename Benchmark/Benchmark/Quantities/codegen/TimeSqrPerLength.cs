
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerLength : Quantity, IEquatable<TimeSqrPerLength>, IComparable
  {  
    internal TimeSqrPerLength(double value) : base(value, 2)
    {
      TimeSqrPerLength.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerLength(TimeSqrPerLength other) : base(other)
    {
      TimeSqrPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerLength"))
    {
      switch(FakeDatabase.Units["TimeSqrPerLength"])
      {
        case "secondsqrpercentimeter": displayUnit_ = secondsqrpercentimeter_; break;
        case "secondsqrpermillimeter": displayUnit_ = secondsqrpermillimeter_; break;
        case "secondsqrpermeter": displayUnit_ = secondsqrpermeter_; break;
        case "secondsqrperinch": displayUnit_ = secondsqrperinch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrpercentimeter_ = new Unit_("SecondSqrPerCentimeter", "s²/cm", 1.0, 0);
  private static Unit_ secondsqrpermillimeter_ = new Unit_("SecondSqrPerMillimeter", "s²/mm", 10.0, 0);
  private static Unit_ secondsqrpermeter_ = new Unit_("SecondSqrPerMeter", "s²/m", 0.01, 0);
  private static Unit_ secondsqrperinch_ = new Unit_("SecondSqrPerInch", "s²/in", 0.390625, 0);
  private static Unit_ platformUnit_ = secondsqrpercentimeter_;
  private static Unit_ displayUnit_ = secondsqrpercentimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerLength other && Equals(other);
  public bool Equals(TimeSqrPerLength other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerLength other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerLength other)) throw new ArgumentException("Object is not a TimeSqrPerLength.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerLength l1, TimeSqrPerLength l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerLength l1, TimeSqrPerLength l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerLength l1, TimeSqrPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerLength l1, TimeSqrPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerLength l1, TimeSqrPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerLength l1, TimeSqrPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerLength FromSecondSqrPerCentimeters(double value, double minValue, double maxValue) => new TimeSqrPerLength((value + secondsqrpercentimeter_.Offset) * secondsqrpercentimeter_.Factor, minValue * secondsqrpercentimeter_.Factor, maxValue * secondsqrpercentimeter_.Factor);
  public static TimeSqrPerLength FromSecondSqrPerCentimeters(double value) => new TimeSqrPerLength((value + secondsqrpercentimeter_.Offset) * secondsqrpercentimeter_.Factor);
  public double GetValueInSecondSqrPerCentimeters() => (Value_ - secondsqrpercentimeter_.Offset) / secondsqrpercentimeter_.Factor;
  public static TimeSqrPerLength FromSecondSqrPerMillimeters(double value, double minValue, double maxValue) => new TimeSqrPerLength((value + secondsqrpermillimeter_.Offset) * secondsqrpermillimeter_.Factor, minValue * secondsqrpermillimeter_.Factor, maxValue * secondsqrpermillimeter_.Factor);
  public static TimeSqrPerLength FromSecondSqrPerMillimeters(double value) => new TimeSqrPerLength((value + secondsqrpermillimeter_.Offset) * secondsqrpermillimeter_.Factor);
  public double GetValueInSecondSqrPerMillimeters() => (Value_ - secondsqrpermillimeter_.Offset) / secondsqrpermillimeter_.Factor;
  public static TimeSqrPerLength FromSecondSqrPerMeters(double value, double minValue, double maxValue) => new TimeSqrPerLength((value + secondsqrpermeter_.Offset) * secondsqrpermeter_.Factor, minValue * secondsqrpermeter_.Factor, maxValue * secondsqrpermeter_.Factor);
  public static TimeSqrPerLength FromSecondSqrPerMeters(double value) => new TimeSqrPerLength((value + secondsqrpermeter_.Offset) * secondsqrpermeter_.Factor);
  public double GetValueInSecondSqrPerMeters() => (Value_ - secondsqrpermeter_.Offset) / secondsqrpermeter_.Factor;
  public static TimeSqrPerLength FromSecondSqrPerInchs(double value, double minValue, double maxValue) => new TimeSqrPerLength((value + secondsqrperinch_.Offset) * secondsqrperinch_.Factor, minValue * secondsqrperinch_.Factor, maxValue * secondsqrperinch_.Factor);
  public static TimeSqrPerLength FromSecondSqrPerInchs(double value) => new TimeSqrPerLength((value + secondsqrperinch_.Offset) * secondsqrperinch_.Factor);
  public double GetValueInSecondSqrPerInchs() => (Value_ - secondsqrperinch_.Offset) / secondsqrperinch_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerLength operator+(TimeSqrPerLength o1, TimeSqrPerLength o2) => new TimeSqrPerLength(o1.Value_ + o2.Value_);
  public static TimeSqrPerLength operator-(TimeSqrPerLength o1, TimeSqrPerLength o2) => new TimeSqrPerLength(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerLength o1, TimeSqrPerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(TimeSqrPerLength o1, MassPerLengthTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassPerLengthTime o1, TimeSqrPerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(TimeSqrPerLength o1, MassPerLengthTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerLengthTime o1, TimeSqrPerLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(TimeSqrPerLength o1, MassTimePerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(MassTimePerLength o1, TimeSqrPerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(TimeSqrPerLength o1, MassTimePerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassTimePerLength o1, TimeSqrPerLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeSqrPerLength o1, PerMassTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassTimeSqr o1, TimeSqrPerLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeSqrPerLength o1, TimeSqrPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeSqrPerMass o1, TimeSqrPerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerLength o1, PerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerTimeCub o1, TimeSqrPerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerLength o1, TimeCub o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCub o1, TimeSqrPerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeSqrPerLength o1, MassPerTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerTimeSqr o1, TimeSqrPerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeSqrPerLength o1, TimeSqrMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeSqrMass o1, TimeSqrPerLength o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimeSqrPerLength o1, LengthPerMassTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthPerMassTime o1, TimeSqrPerLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeSqrPerLength o1, LengthPerMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthPerMassTime o1, TimeSqrPerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(TimeSqrPerLength o1, LengthTimePerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthTimePerMass o1, TimeSqrPerLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeSqrPerLength o1, LengthTimePerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthTimePerMass o1, TimeSqrPerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerLength o1, Acceleration o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Acceleration o1, TimeSqrPerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeSqrPerLength o1, TimeSqrLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeSqrLength o1, TimeSqrPerLength o2) => new Area(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(TimeSqrPerLength o1, LengthMassPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthMassPerTime o1, TimeSqrPerLength o2) => new MassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeSqrPerLength o1, LengthMassPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthMassPerTime o1, TimeSqrPerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(TimeSqrPerLength o1, LengthMassTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthMassTime o1, TimeSqrPerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(TimeSqrPerLength o1, LengthMassTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthMassTime o1, TimeSqrPerLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimeSqrPerLength o1, LengthSqrPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthSqrPerMass o1, TimeSqrPerLength o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeSqrPerLength o1, LengthSqrPerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthSqrPerMass o1, TimeSqrPerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeSqrPerLength o1, LengthSqrPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrPerTime o1, TimeSqrPerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeSqrPerLength o1, LengthSqrPerTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthSqrPerTime o1, TimeSqrPerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator*(TimeSqrPerLength o1, LengthSqrTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthSqrTime o1, TimeSqrPerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator/(TimeSqrPerLength o1, LengthSqrTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrTime o1, TimeSqrPerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimeSqrPerLength o1, LengthSqrMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthSqrMass o1, TimeSqrPerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerLength o1, LengthSqrMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthSqrMass o1, TimeSqrPerLength o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeSqrPerLength o1, Volume o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(Volume o1, TimeSqrPerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(TimeSqrPerLength o1, PerMassLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator/(TimeSqrPerLength o1, PerTimeLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimeSqrPerLength o1, TimePerLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimePerLengthCub o1, TimeSqrPerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(TimeSqrPerLength o1, Density o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(Density o1, TimeSqrPerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(TimeSqrPerLength o1, PerMassTimeLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(PerMassTimeLengthSqr o1, TimeSqrPerLength o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(TimeSqrPerLength o1, PerMassTimeLengthSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(TimeSqrPerLength o1, TimePerMassLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimePerMassLengthSqr o1, TimeSqrPerLength o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(TimeSqrPerLength o1, TimePerMassLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(TimePerMassLengthSqr o1, TimeSqrPerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeSqrPerLength o1, PerLengthSqrTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerLengthSqrTimeSqr o1, TimeSqrPerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeSqrPerLength o1, TimeSqrPerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeSqrPerLengthSqr o1, TimeSqrPerLength o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(TimeSqrPerLength o1, MassPerTimeLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(MassPerTimeLengthSqr o1, TimeSqrPerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeSqrPerLength o1, MassPerTimeLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrPerLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(TimeSqrPerLength o1, MassTimePerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(MassTimePerLengthSqr o1, TimeSqrPerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(TimeSqrPerLength o1, MassTimePerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassTimePerLengthSqr o1, TimeSqrPerLength o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeSqrPerLength o1, PerLengthMassTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthMassTimeSqr o1, TimeSqrPerLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeSqrPerLength o1, TimeSqrPerLengthMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeSqrPerLengthMass o1, TimeSqrPerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimeSqrPerLength o1, PerLengthTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerLengthTimeCub o1, TimeSqrPerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrPerLength o1, TimeCubPerLength o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerLength o1, TimeSqrPerLength o2) => new Time(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeSqrPerLength o1, MassPerLengthTimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerLengthTimeSqr o1, TimeSqrPerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(TimeSqrPerLength o1, TimeSqrMassPerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeSqrMassPerLength o1, TimeSqrPerLength o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimeSqrPerLength o1, PerMassTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassTimeCub o1, TimeSqrPerLength o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator/(TimeSqrPerLength o1, TimeCubPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeCubPerMass o1, TimeSqrPerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(TimeSqrPerLength o1, MassPerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerTimeCub o1, TimeSqrPerLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator/(TimeSqrPerLength o1, TimeCubMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeCubMass o1, TimeSqrPerLength o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeSqrPerLength o1, LengthPerMassTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthPerMassTimeSqr o1, TimeSqrPerLength o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeSqrPerLength o1, TimeSqrLengthPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(TimeSqrLengthPerMass o1, TimeSqrPerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrPerLength o1, LengthPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthPerTimeCub o1, TimeSqrPerLength o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(TimeSqrPerLength o1, TimeCubLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(TimeCubLength o1, TimeSqrPerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static Mass operator*(TimeSqrPerLength o1, Force o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(Force o1, TimeSqrPerLength o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeSqrPerLength o1, TimeSqrLengthMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(TimeSqrLengthMass o1, TimeSqrPerLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(TimeSqrPerLength o1, LengthSqrPerMassTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrPerMassTime o1, TimeSqrPerLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeSqrPerLength o1, LengthSqrPerMassTime o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthSqrPerMassTime o1, TimeSqrPerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(TimeSqrPerLength o1, LengthSqrTimePerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthSqrTimePerMass o1, TimeSqrPerLength o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(TimeSqrPerLength o1, LengthSqrTimePerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrTimePerMass o1, TimeSqrPerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeSqrPerLength o1, QDose o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(QDose o1, TimeSqrPerLength o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeSqrPerLength o1, LengthSqrTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrTimeSqr o1, TimeSqrPerLength o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(TimeSqrPerLength o1, LengthSqrMassPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthSqrMassPerTime o1, TimeSqrPerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeSqrPerLength o1, LengthSqrMassPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthSqrMassPerTime o1, TimeSqrPerLength o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(TimeSqrPerLength o1, LengthSqrMassTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthSqrMassTime o1, TimeSqrPerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(TimeSqrPerLength o1, LengthSqrMassTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrMassTime o1, TimeSqrPerLength o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(TimeSqrPerLength o1, LengthCubPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubPerMass o1, TimeSqrPerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(TimeSqrPerLength o1, LengthCubPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubPerTime o1, TimeSqrPerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(TimeSqrPerLength o1, LengthCubTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(LengthCubTime o1, TimeSqrPerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(TimeSqrPerLength o1, LengthCubMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthCubMass o1, TimeSqrPerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator/(TimeSqrPerLength o1, PerMassTimeLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator/(TimeSqrPerLength o1, TimePerMassLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(TimePerMassLengthCub o1, TimeSqrPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(TimeSqrPerLength o1, TimeSqrPerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeSqrPerLengthCub o1, TimeSqrPerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator/(TimeSqrPerLength o1, MassPerTimeLengthCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrPerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(TimeSqrPerLength o1, MassTimePerLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassTimePerLengthCub o1, TimeSqrPerLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeSqrPerLength o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerMassLengthSqrTimeSqr o1, TimeSqrPerLength o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(TimeSqrPerLength o1, TimeSqrPerMassLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimeSqrPerLength o1, PerLengthSqrTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthSqrTimeCub o1, TimeSqrPerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static Speed operator/(TimeSqrPerLength o1, TimeCubPerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeCubPerLengthSqr o1, TimeSqrPerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimeSqrPerLength o1, MassPerLengthSqrTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthSqrTimeSqr o1, TimeSqrPerLength o2) => new Density(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator/(TimeSqrPerLength o1, TimeSqrMassPerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(TimeSqrMassPerLengthSqr o1, TimeSqrPerLength o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrPerLength o1, PerLengthMassTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerLengthMassTimeCub o1, TimeSqrPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator/(TimeSqrPerLength o1, TimeCubPerLengthMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeCubPerLengthMass o1, TimeSqrPerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimeSqrPerLength o1, MassPerLengthTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerLengthTimeCub o1, TimeSqrPerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerLength o1, TimeCubMassPerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubMassPerLength o1, TimeSqrPerLength o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerLength o1, LengthPerMassTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthPerMassTimeCub o1, TimeSqrPerLength o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimeSqrPerLength o1, TimeCubLengthPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeCubLengthPerMass o1, TimeSqrPerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(TimeSqrPerLength o1, LengthMassPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthMassPerTimeCub o1, TimeSqrPerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrPerLength o1, TimeCubLengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeCubLengthMass o1, TimeSqrPerLength o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeSqrPerLength o1, LengthSqrPerMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrPerMassTimeSqr o1, TimeSqrPerLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeSqrPerLength o1, LengthSqrTimeSqrPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthSqrTimeSqrPerMass o1, TimeSqrPerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static Speed operator*(TimeSqrPerLength o1, LengthSqrPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrPerTimeCub o1, TimeSqrPerLength o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(TimeSqrPerLength o1, TimeCubLengthSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeCubLengthSqr o1, TimeSqrPerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(TimeSqrPerLength o1, LengthSqrMassPerTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeSqrPerLength o1, LengthSqrTimeSqrMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthSqrTimeSqrMass o1, TimeSqrPerLength o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimeSqrPerLength o1, LengthCubPerMassTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubPerMassTime o1, TimeSqrPerLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(TimeSqrPerLength o1, LengthCubTimePerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthCubTimePerMass o1, TimeSqrPerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(TimeSqrPerLength o1, LengthCubPerTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubPerTimeSqr o1, TimeSqrPerLength o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeSqrPerLength o1, LengthCubMassPerTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubMassPerTime o1, TimeSqrPerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(TimeSqrPerLength o1, LengthCubMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(LengthCubMassTime o1, TimeSqrPerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeSqrPerLength o1, TimeSqrPerMassLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(TimeSqrPerLength o1, TimeCubPerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeCubPerLengthCub o1, TimeSqrPerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeSqrPerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeSqrMassPerLengthCub o1, TimeSqrPerLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(TimeSqrPerLength o1, PerMassLengthSqrTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerMassLengthSqrTimeCub o1, TimeSqrPerLength o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(TimeSqrPerLength o1, TimeCubPerMassLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(TimeSqrPerLength o1, MassPerLengthSqrTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerLengthSqrTimeCub o1, TimeSqrPerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator/(TimeSqrPerLength o1, TimeCubMassPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubMassPerLengthSqr o1, TimeSqrPerLength o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(TimeSqrPerLength o1, LengthSqrPerMassTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrPerLength o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthCub operator/(TimeSqrPerLength o1, TimeCubLengthSqrPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(TimeCubLengthSqrPerMass o1, TimeSqrPerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(TimeSqrPerLength o1, LengthSqrMassPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthCub operator/(TimeSqrPerLength o1, TimeCubLengthSqrMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(TimeCubLengthSqrMass o1, TimeSqrPerLength o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeSqrPerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubPerMassTimeSqr o1, TimeSqrPerLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(TimeSqrPerLength o1, LengthCubPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubPerTimeCub o1, TimeSqrPerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(TimeSqrPerLength o1, LengthCubMassPerTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator/(TimeSqrPerLength o1, TimeCubPerMassLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimeCubPerMassLengthCub o1, TimeSqrPerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator/(TimeSqrPerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeCubMassPerLengthCub o1, TimeSqrPerLength o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(TimeSqrPerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubPerMassTimeCub o1, TimeSqrPerLength o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator*(TimeSqrPerLength o1, LengthCubMassPerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerLength is outside its bounds.");
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
    