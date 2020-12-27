
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubPerLength : Quantity, IEquatable<TimeCubPerLength>, IComparable
  {  
    internal TimeCubPerLength(double value) : base(value, 2)
    {
      TimeCubPerLength.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubPerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubPerLength(TimeCubPerLength other) : base(other)
    {
      TimeCubPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerLength"))
    {
      switch(FakeDatabase.Units["TimeCubPerLength"])
      {
        case "secondcubpercentimeter": displayUnit_ = secondcubpercentimeter_; break;
        case "secondcubpermillimeter": displayUnit_ = secondcubpermillimeter_; break;
        case "secondcubpermeter": displayUnit_ = secondcubpermeter_; break;
        case "secondcubperinch": displayUnit_ = secondcubperinch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubpercentimeter_ = new Unit_("SecondCubPerCentimeter", "s³/cm", 1.0, 0);
  private static Unit_ secondcubpermillimeter_ = new Unit_("SecondCubPerMillimeter", "s³/mm", 10.0, 0);
  private static Unit_ secondcubpermeter_ = new Unit_("SecondCubPerMeter", "s³/m", 0.01, 0);
  private static Unit_ secondcubperinch_ = new Unit_("SecondCubPerInch", "s³/in", 0.390625, 0);
  private static Unit_ platformUnit_ = secondcubpercentimeter_;
  private static Unit_ displayUnit_ = secondcubpercentimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubPerLength other && Equals(other);
  public bool Equals(TimeCubPerLength other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubPerLength other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubPerLength other)) throw new ArgumentException("Object is not a TimeCubPerLength.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubPerLength l1, TimeCubPerLength l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubPerLength l1, TimeCubPerLength l2) => !(l1 == l2);
  public static bool operator <(TimeCubPerLength l1, TimeCubPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubPerLength l1, TimeCubPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubPerLength l1, TimeCubPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubPerLength l1, TimeCubPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubPerLength FromSecondCubPerCentimeters(double value, double minValue, double maxValue) => new TimeCubPerLength((value + secondcubpercentimeter_.Offset) * secondcubpercentimeter_.Factor, minValue * secondcubpercentimeter_.Factor, maxValue * secondcubpercentimeter_.Factor);
  public static TimeCubPerLength FromSecondCubPerCentimeters(double value) => new TimeCubPerLength((value + secondcubpercentimeter_.Offset) * secondcubpercentimeter_.Factor);
  public double GetValueInSecondCubPerCentimeters() => (Value_ - secondcubpercentimeter_.Offset) / secondcubpercentimeter_.Factor;
  public static TimeCubPerLength FromSecondCubPerMillimeters(double value, double minValue, double maxValue) => new TimeCubPerLength((value + secondcubpermillimeter_.Offset) * secondcubpermillimeter_.Factor, minValue * secondcubpermillimeter_.Factor, maxValue * secondcubpermillimeter_.Factor);
  public static TimeCubPerLength FromSecondCubPerMillimeters(double value) => new TimeCubPerLength((value + secondcubpermillimeter_.Offset) * secondcubpermillimeter_.Factor);
  public double GetValueInSecondCubPerMillimeters() => (Value_ - secondcubpermillimeter_.Offset) / secondcubpermillimeter_.Factor;
  public static TimeCubPerLength FromSecondCubPerMeters(double value, double minValue, double maxValue) => new TimeCubPerLength((value + secondcubpermeter_.Offset) * secondcubpermeter_.Factor, minValue * secondcubpermeter_.Factor, maxValue * secondcubpermeter_.Factor);
  public static TimeCubPerLength FromSecondCubPerMeters(double value) => new TimeCubPerLength((value + secondcubpermeter_.Offset) * secondcubpermeter_.Factor);
  public double GetValueInSecondCubPerMeters() => (Value_ - secondcubpermeter_.Offset) / secondcubpermeter_.Factor;
  public static TimeCubPerLength FromSecondCubPerInchs(double value, double minValue, double maxValue) => new TimeCubPerLength((value + secondcubperinch_.Offset) * secondcubperinch_.Factor, minValue * secondcubperinch_.Factor, maxValue * secondcubperinch_.Factor);
  public static TimeCubPerLength FromSecondCubPerInchs(double value) => new TimeCubPerLength((value + secondcubperinch_.Offset) * secondcubperinch_.Factor);
  public double GetValueInSecondCubPerInchs() => (Value_ - secondcubperinch_.Offset) / secondcubperinch_.Factor;

#endregion

#region arithmetic
  public static TimeCubPerLength operator+(TimeCubPerLength o1, TimeCubPerLength o2) => new TimeCubPerLength(o1.Value_ + o2.Value_);
  public static TimeCubPerLength operator-(TimeCubPerLength o1, TimeCubPerLength o2) => new TimeCubPerLength(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubPerLength o1, TimeCubPerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(TimeCubPerLength o1, MassPerLengthTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassPerLengthTimeSqr o1, TimeCubPerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator/(TimeCubPerLength o1, TimeSqrMassPerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(TimeSqrMassPerLength o1, TimeCubPerLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeCubPerLength o1, PerMassTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassTimeCub o1, TimeCubPerLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeCubPerLength o1, TimeCubPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubPerMass o1, TimeCubPerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeCubPerLength o1, MassPerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerTimeCub o1, TimeCubPerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeCubPerLength o1, TimeCubMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubMass o1, TimeCubPerLength o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimeCubPerLength o1, LengthPerMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthPerMassTimeSqr o1, TimeCubPerLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeCubPerLength o1, TimeSqrLengthPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(TimeSqrLengthPerMass o1, TimeCubPerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeCubPerLength o1, LengthPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthPerTimeCub o1, TimeCubPerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubPerLength o1, TimeCubLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeCubLength o1, TimeCubPerLength o2) => new Area(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(TimeCubPerLength o1, Force o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(Force o1, TimeCubPerLength o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeCubPerLength o1, TimeSqrLengthMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(TimeSqrLengthMass o1, TimeCubPerLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimeCubPerLength o1, LengthSqrPerMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthSqrPerMassTime o1, TimeCubPerLength o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(TimeCubPerLength o1, LengthSqrTimePerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthSqrTimePerMass o1, TimeCubPerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeCubPerLength o1, QDose o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(QDose o1, TimeCubPerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(TimeCubPerLength o1, LengthSqrTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrTimeSqr o1, TimeCubPerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimeCubPerLength o1, LengthSqrMassPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthSqrMassPerTime o1, TimeCubPerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator/(TimeCubPerLength o1, LengthSqrMassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthSqrMassTime o1, TimeCubPerLength o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(TimeCubPerLength o1, LengthCubPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthCubPerMass o1, TimeCubPerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeCubPerLength o1, LengthCubPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubPerTime o1, TimeCubPerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(TimeCubPerLength o1, LengthCubMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(LengthCubMass o1, TimeCubPerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(TimeCubPerLength o1, TimePerMassLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimeCubPerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimeSqrPerLengthCub o1, TimeCubPerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(TimeCubPerLength o1, MassTimePerLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassTimePerLengthCub o1, TimeCubPerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(TimeCubPerLength o1, PerMassLengthSqrTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(PerMassLengthSqrTimeSqr o1, TimeCubPerLength o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(TimeCubPerLength o1, TimeSqrPerMassLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeCubPerLength o1, PerLengthSqrTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerLengthSqrTimeCub o1, TimeCubPerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCubPerLength o1, TimeCubPerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubPerLengthSqr o1, TimeCubPerLength o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(TimeCubPerLength o1, MassPerLengthSqrTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(MassPerLengthSqrTimeSqr o1, TimeCubPerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator/(TimeCubPerLength o1, TimeSqrMassPerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(TimeSqrMassPerLengthSqr o1, TimeCubPerLength o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeCubPerLength o1, PerLengthMassTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthMassTimeCub o1, TimeCubPerLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeCubPerLength o1, TimeCubPerLengthMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeCubPerLengthMass o1, TimeCubPerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeCubPerLength o1, MassPerLengthTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerLengthTimeCub o1, TimeCubPerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(TimeCubPerLength o1, TimeCubMassPerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeCubMassPerLength o1, TimeCubPerLength o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeCubPerLength o1, LengthPerMassTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthPerMassTimeCub o1, TimeCubPerLength o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeCubPerLength o1, TimeCubLengthPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(TimeCubLengthPerMass o1, TimeCubPerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Mass operator*(TimeCubPerLength o1, LengthMassPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthMassPerTimeCub o1, TimeCubPerLength o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeCubPerLength o1, TimeCubLengthMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(TimeCubLengthMass o1, TimeCubPerLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(TimeCubPerLength o1, LengthSqrPerMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrPerMassTimeSqr o1, TimeCubPerLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator/(TimeCubPerLength o1, LengthSqrTimeSqrPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubPerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCubPerLength o1, LengthSqrPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrPerTimeCub o1, TimeCubPerLength o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeCubPerLength o1, TimeCubLengthSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(TimeCubLengthSqr o1, TimeCubPerLength o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(TimeCubPerLength o1, LengthSqrMassPerTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthCub operator/(TimeCubPerLength o1, LengthSqrTimeSqrMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrTimeSqrMass o1, TimeCubPerLength o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(TimeCubPerLength o1, LengthCubPerMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubPerMassTime o1, TimeCubPerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(TimeCubPerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubPerTimeSqr o1, TimeCubPerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(TimeCubPerLength o1, LengthCubMassPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthCubMassPerTime o1, TimeCubPerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(TimeCubPerLength o1, TimeSqrPerMassLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimeCubPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(TimeCubPerLength o1, TimeCubPerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeCubPerLengthCub o1, TimeCubPerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(TimeCubPerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(TimeSqrMassPerLengthCub o1, TimeCubPerLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeCubPerLength o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerMassLengthSqrTimeCub o1, TimeCubPerLength o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(TimeCubPerLength o1, TimeCubPerMassLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimeCubPerMassLengthSqr o1, TimeCubPerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimeCubPerLength o1, MassPerLengthSqrTimeCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthSqrTimeCub o1, TimeCubPerLength o2) => new Density(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator/(TimeCubPerLength o1, TimeCubMassPerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(TimeCubMassPerLengthSqr o1, TimeCubPerLength o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeCubPerLength o1, LengthSqrPerMassTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrPerMassTimeCub o1, TimeCubPerLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeCubPerLength o1, TimeCubLengthSqrPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(TimeCubLengthSqrPerMass o1, TimeCubPerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(TimeCubPerLength o1, LengthSqrMassPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrMassPerTimeCub o1, TimeCubPerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeCubPerLength o1, TimeCubLengthSqrMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(TimeCubLengthSqrMass o1, TimeCubPerLength o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimeCubPerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubPerMassTimeSqr o1, TimeCubPerLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(TimeCubPerLength o1, LengthCubPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubPerTimeCub o1, TimeCubPerLength o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeCubPerLength o1, LengthCubMassPerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeCubPerLength o1, TimeCubPerMassLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeCubPerMassLengthCub o1, TimeCubPerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeCubPerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeCubMassPerLengthCub o1, TimeCubPerLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeCubPerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubPerMassTimeCub o1, TimeCubPerLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(TimeCubPerLength o1, LengthCubMassPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubMassPerTimeCub o1, TimeCubPerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubPerLength is outside its bounds.");
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
    