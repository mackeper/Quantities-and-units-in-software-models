
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimePerLength : Quantity, IEquatable<TimePerLength>, IComparable
  {  
    internal TimePerLength(double value) : base(value, 2)
    {
      TimePerLength.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimePerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimePerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimePerLength(TimePerLength other) : base(other)
    {
      TimePerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerLength"))
    {
      switch(FakeDatabase.Units["TimePerLength"])
      {
        case "secondpercentimeter": displayUnit_ = secondpercentimeter_; break;
        case "secondpermillimeter": displayUnit_ = secondpermillimeter_; break;
        case "secondpermeter": displayUnit_ = secondpermeter_; break;
        case "secondperinch": displayUnit_ = secondperinch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondpercentimeter_ = new Unit_("SecondPerCentimeter", "s/cm", 1.0, 0);
  private static Unit_ secondpermillimeter_ = new Unit_("SecondPerMillimeter", "s/mm", 10.0, 0);
  private static Unit_ secondpermeter_ = new Unit_("SecondPerMeter", "s/m", 0.01, 0);
  private static Unit_ secondperinch_ = new Unit_("SecondPerInch", "s/in", 0.390625, 0);
  private static Unit_ platformUnit_ = secondpercentimeter_;
  private static Unit_ displayUnit_ = secondpercentimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimePerLength other && Equals(other);
  public bool Equals(TimePerLength other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimePerLength other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimePerLength other)) throw new ArgumentException("Object is not a TimePerLength.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimePerLength l1, TimePerLength l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimePerLength l1, TimePerLength l2) => !(l1 == l2);
  public static bool operator <(TimePerLength l1, TimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimePerLength l1, TimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimePerLength l1, TimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimePerLength l1, TimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimePerLength FromSecondPerCentimeters(double value, double minValue, double maxValue) => new TimePerLength((value + secondpercentimeter_.Offset) * secondpercentimeter_.Factor, minValue * secondpercentimeter_.Factor, maxValue * secondpercentimeter_.Factor);
  public static TimePerLength FromSecondPerCentimeters(double value) => new TimePerLength((value + secondpercentimeter_.Offset) * secondpercentimeter_.Factor);
  public double GetValueInSecondPerCentimeters() => (Value_ - secondpercentimeter_.Offset) / secondpercentimeter_.Factor;
  public static TimePerLength FromSecondPerMillimeters(double value, double minValue, double maxValue) => new TimePerLength((value + secondpermillimeter_.Offset) * secondpermillimeter_.Factor, minValue * secondpermillimeter_.Factor, maxValue * secondpermillimeter_.Factor);
  public static TimePerLength FromSecondPerMillimeters(double value) => new TimePerLength((value + secondpermillimeter_.Offset) * secondpermillimeter_.Factor);
  public double GetValueInSecondPerMillimeters() => (Value_ - secondpermillimeter_.Offset) / secondpermillimeter_.Factor;
  public static TimePerLength FromSecondPerMeters(double value, double minValue, double maxValue) => new TimePerLength((value + secondpermeter_.Offset) * secondpermeter_.Factor, minValue * secondpermeter_.Factor, maxValue * secondpermeter_.Factor);
  public static TimePerLength FromSecondPerMeters(double value) => new TimePerLength((value + secondpermeter_.Offset) * secondpermeter_.Factor);
  public double GetValueInSecondPerMeters() => (Value_ - secondpermeter_.Offset) / secondpermeter_.Factor;
  public static TimePerLength FromSecondPerInchs(double value, double minValue, double maxValue) => new TimePerLength((value + secondperinch_.Offset) * secondperinch_.Factor, minValue * secondperinch_.Factor, maxValue * secondperinch_.Factor);
  public static TimePerLength FromSecondPerInchs(double value) => new TimePerLength((value + secondperinch_.Offset) * secondperinch_.Factor);
  public double GetValueInSecondPerInchs() => (Value_ - secondperinch_.Offset) / secondperinch_.Factor;

#endregion

#region arithmetic
  public static TimePerLength operator+(TimePerLength o1, TimePerLength o2) => new TimePerLength(o1.Value_ + o2.Value_);
  public static TimePerLength operator-(TimePerLength o1, TimePerLength o2) => new TimePerLength(o1.Value_ - o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimePerLength o1, TimePerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static Dimensionless operator/(TimePerLength o1, TimePerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(TimePerLength o1, MassPerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassPerLength o1, TimePerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(TimePerLength o1, MassPerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerLength o1, TimePerLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimePerLength o1, PerMassTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassTime o1, TimePerLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(TimePerLength o1, PerMassTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerMassTime o1, TimePerLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(TimePerLength o1, TimePerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimePerMass o1, TimePerLength o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(TimePerLength o1, TimePerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimePerMass o1, TimePerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimePerLength o1, PerTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerTimeSqr o1, TimePerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(TimePerLength o1, PerTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerTimeSqr o1, TimePerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator*(TimePerLength o1, TimeSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqr o1, TimePerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(TimePerLength o1, TimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqr o1, TimePerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimePerLength o1, MassPerTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerTime o1, TimePerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimePerLength o1, MassPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(MassPerTime o1, TimePerLength o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(TimePerLength o1, MassTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(MassTime o1, TimePerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(TimePerLength o1, MassTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassTime o1, TimePerLength o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimePerLength o1, LengthPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthPerMass o1, TimePerLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(TimePerLength o1, LengthPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthPerMass o1, TimePerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimePerLength o1, Speed o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Speed o1, TimePerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimePerLength o1, Speed o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(Speed o1, TimePerLength o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(TimePerLength o1, LengthTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthTime o1, TimePerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator/(TimePerLength o1, LengthTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthTime o1, TimePerLength o2) => new Area(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(TimePerLength o1, LengthMass o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthMass o1, TimePerLength o2) => new MassTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(TimePerLength o1, LengthMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthMass o1, TimePerLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimePerLength o1, Area o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(Area o1, TimePerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator/(TimePerLength o1, Area o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(Area o1, TimePerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimePerLength o1, PerLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthCub o1, TimePerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(TimePerLength o1, PerMassLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(PerMassLengthSqr o1, TimePerLength o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(TimePerLength o1, PerMassLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassLengthSqr o1, TimePerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimePerLength o1, PerTimeLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerTimeLengthSqr o1, TimePerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator/(TimePerLength o1, PerTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerTimeLengthSqr o1, TimePerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(TimePerLength o1, TimePerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimePerLengthSqr o1, TimePerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static Length operator/(TimePerLength o1, TimePerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimePerLengthSqr o1, TimePerLength o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(TimePerLength o1, MassPerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(MassPerLengthSqr o1, TimePerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(TimePerLength o1, MassPerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerLengthSqr o1, TimePerLength o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimePerLength o1, PerLengthMassTime o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthMassTime o1, TimePerLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(TimePerLength o1, PerLengthMassTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthMassTime o1, TimePerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(TimePerLength o1, TimePerLengthMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimePerLengthMass o1, TimePerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static Mass operator/(TimePerLength o1, TimePerLengthMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimePerLengthMass o1, TimePerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimePerLength o1, PerLengthTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerLengthTimeSqr o1, TimePerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCub operator/(TimePerLength o1, PerLengthTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerLengthTimeSqr o1, TimePerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(TimePerLength o1, TimeSqrPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeSqrPerLength o1, TimePerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static PerTime operator/(TimePerLength o1, TimeSqrPerLength o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrPerLength o1, TimePerLength o2) => new Time(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(TimePerLength o1, MassPerLengthTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerLengthTime o1, TimePerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(TimePerLength o1, MassPerLengthTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerLengthTime o1, TimePerLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(TimePerLength o1, MassTimePerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(MassTimePerLength o1, TimePerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static PerMass operator/(TimePerLength o1, MassTimePerLength o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassTimePerLength o1, TimePerLength o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimePerLength o1, PerMassTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassTimeSqr o1, TimePerLength o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(TimePerLength o1, PerMassTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(PerMassTimeSqr o1, TimePerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(TimePerLength o1, TimeSqrPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrPerMass o1, TimePerLength o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(TimePerLength o1, TimeSqrPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeSqrPerMass o1, TimePerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(TimePerLength o1, PerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerTimeCub o1, TimePerLength o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(TimePerLength o1, TimeCub o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCub o1, TimePerLength o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(TimePerLength o1, MassPerTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerTimeSqr o1, TimePerLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(TimePerLength o1, MassPerTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(MassPerTimeSqr o1, TimePerLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(TimePerLength o1, TimeSqrMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrMass o1, TimePerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(TimePerLength o1, TimeSqrMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeSqrMass o1, TimePerLength o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimePerLength o1, LengthPerMassTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthPerMassTime o1, TimePerLength o2) => new PerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimePerLength o1, LengthPerMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthPerMassTime o1, TimePerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(TimePerLength o1, LengthTimePerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthTimePerMass o1, TimePerLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator/(TimePerLength o1, LengthTimePerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthTimePerMass o1, TimePerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimePerLength o1, Acceleration o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(Acceleration o1, TimePerLength o2) => new PerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimePerLength o1, Acceleration o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(Acceleration o1, TimePerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCub operator*(TimePerLength o1, TimeSqrLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrLength o1, TimePerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator/(TimePerLength o1, TimeSqrLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(TimeSqrLength o1, TimePerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static Mass operator*(TimePerLength o1, LengthMassPerTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthMassPerTime o1, TimePerLength o2) => new Mass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimePerLength o1, LengthMassPerTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthMassPerTime o1, TimePerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(TimePerLength o1, LengthMassTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(LengthMassTime o1, TimePerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator/(TimePerLength o1, LengthMassTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthMassTime o1, TimePerLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(TimePerLength o1, LengthSqrPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrPerMass o1, TimePerLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(TimePerLength o1, LengthSqrPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrPerMass o1, TimePerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimePerLength o1, LengthSqrPerTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrPerTime o1, TimePerLength o2) => new Length(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimePerLength o1, LengthSqrPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthSqrPerTime o1, TimePerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(TimePerLength o1, LengthSqrTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthSqrTime o1, TimePerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static PerLengthCub operator/(TimePerLength o1, LengthSqrTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrTime o1, TimePerLength o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(TimePerLength o1, LengthSqrMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthSqrMass o1, TimePerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerLength o1, LengthSqrMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrMass o1, TimePerLength o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(TimePerLength o1, Volume o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(Volume o1, TimePerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(TimePerLength o1, PerMassLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerMassLengthCub o1, TimePerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator/(TimePerLength o1, PerTimeLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerTimeLengthCub o1, TimePerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(TimePerLength o1, TimePerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimePerLengthCub o1, TimePerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(TimePerLength o1, Density o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(Density o1, TimePerLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimePerLength o1, PerMassTimeLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerMassTimeLengthSqr o1, TimePerLength o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator/(TimePerLength o1, PerMassTimeLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerMassTimeLengthSqr o1, TimePerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(TimePerLength o1, TimePerMassLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimePerMassLengthSqr o1, TimePerLength o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthMass operator/(TimePerLength o1, TimePerMassLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimePerMassLengthSqr o1, TimePerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimePerLength o1, PerLengthSqrTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthSqrTimeSqr o1, TimePerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubLength operator/(TimePerLength o1, PerLengthSqrTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator*(TimePerLength o1, TimeSqrPerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeSqrPerLengthSqr o1, TimePerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static Speed operator/(TimePerLength o1, TimeSqrPerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeSqrPerLengthSqr o1, TimePerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimePerLength o1, MassPerTimeLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerTimeLengthSqr o1, TimePerLength o2) => new Density(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimePerLength o1, MassPerTimeLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerTimeLengthSqr o1, TimePerLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(TimePerLength o1, MassTimePerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(MassTimePerLengthSqr o1, TimePerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMass operator/(TimePerLength o1, MassTimePerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassTimePerLengthSqr o1, TimePerLength o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimePerLength o1, PerLengthMassTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerLengthMassTimeSqr o1, TimePerLength o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(TimePerLength o1, PerLengthMassTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerLengthMassTimeSqr o1, TimePerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(TimePerLength o1, TimeSqrPerLengthMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeSqrPerLengthMass o1, TimePerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTime operator/(TimePerLength o1, TimeSqrPerLengthMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeSqrPerLengthMass o1, TimePerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(TimePerLength o1, PerLengthTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerLengthTimeCub o1, TimePerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(TimePerLength o1, TimeCubPerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubPerLength o1, TimePerLength o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimePerLength o1, MassPerLengthTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerLengthTimeSqr o1, TimePerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(TimePerLength o1, MassPerLengthTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerLengthTimeSqr o1, TimePerLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(TimePerLength o1, TimeSqrMassPerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeSqrMassPerLength o1, TimePerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(TimePerLength o1, TimeSqrMassPerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrMassPerLength o1, TimePerLength o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(TimePerLength o1, PerMassTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassTimeCub o1, TimePerLength o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(TimePerLength o1, TimeCubPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubPerMass o1, TimePerLength o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(TimePerLength o1, MassPerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerTimeCub o1, TimePerLength o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(TimePerLength o1, TimeCubMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubMass o1, TimePerLength o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimePerLength o1, LengthPerMassTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthPerMassTimeSqr o1, TimePerLength o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimePerLength o1, LengthPerMassTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthPerMassTimeSqr o1, TimePerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(TimePerLength o1, TimeSqrLengthPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeSqrLengthPerMass o1, TimePerLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(TimePerLength o1, TimeSqrLengthPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeSqrLengthPerMass o1, TimePerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(TimePerLength o1, LengthPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthPerTimeCub o1, TimePerLength o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(TimePerLength o1, TimeCubLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubLength o1, TimePerLength o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(TimePerLength o1, Force o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(Force o1, TimePerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimePerLength o1, Force o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(Force o1, TimePerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(TimePerLength o1, TimeSqrLengthMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeSqrLengthMass o1, TimePerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(TimePerLength o1, TimeSqrLengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeSqrLengthMass o1, TimePerLength o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimePerLength o1, LengthSqrPerMassTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthSqrPerMassTime o1, TimePerLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimePerLength o1, LengthSqrPerMassTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthSqrPerMassTime o1, TimePerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimePerLength o1, LengthSqrTimePerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthSqrTimePerMass o1, TimePerLength o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static Density operator/(TimePerLength o1, LengthSqrTimePerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthSqrTimePerMass o1, TimePerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static Speed operator*(TimePerLength o1, QDose o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(QDose o1, TimePerLength o2) => new Speed(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(TimePerLength o1, QDose o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(QDose o1, TimePerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator*(TimePerLength o1, LengthSqrTimeSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthSqrTimeSqr o1, TimePerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator/(TimePerLength o1, LengthSqrTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthSqrTimeSqr o1, TimePerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(TimePerLength o1, LengthSqrMassPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrMassPerTime o1, TimePerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimePerLength o1, LengthSqrMassPerTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthSqrMassPerTime o1, TimePerLength o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimePerLength o1, LengthSqrMassTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthSqrMassTime o1, TimePerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(TimePerLength o1, LengthSqrMassTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthSqrMassTime o1, TimePerLength o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimePerLength o1, LengthCubPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubPerMass o1, TimePerLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(TimePerLength o1, LengthCubPerTime o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubPerTime o1, TimePerLength o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimePerLength o1, LengthCubTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubTime o1, TimePerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(TimePerLength o1, LengthCubMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubMass o1, TimePerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(TimePerLength o1, PerMassTimeLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassTimeLengthCub o1, TimePerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator/(TimePerLength o1, TimePerMassLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimePerMassLengthCub o1, TimePerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator/(TimePerLength o1, PerTimeSqrLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerTimeSqrLengthCub o1, TimePerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(TimePerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeSqrPerLengthCub o1, TimePerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(TimePerLength o1, MassPerTimeLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerTimeLengthCub o1, TimePerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(TimePerLength o1, MassTimePerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassTimePerLengthCub o1, TimePerLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(TimePerLength o1, PerMassLengthSqrTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerMassLengthSqrTimeSqr o1, TimePerLength o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(TimePerLength o1, PerMassLengthSqrTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(TimePerLength o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeSqrPerMassLengthSqr o1, TimePerLength o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(TimePerLength o1, TimeSqrPerMassLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrPerMassLengthSqr o1, TimePerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(TimePerLength o1, PerLengthSqrTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerLengthSqrTimeCub o1, TimePerLength o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(TimePerLength o1, TimeCubPerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubPerLengthSqr o1, TimePerLength o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(TimePerLength o1, MassPerLengthSqrTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerLengthSqrTimeSqr o1, TimePerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(TimePerLength o1, MassPerLengthSqrTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerLengthSqrTimeSqr o1, TimePerLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(TimePerLength o1, TimeSqrMassPerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeSqrMassPerLengthSqr o1, TimePerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(TimePerLength o1, TimeSqrMassPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeSqrMassPerLengthSqr o1, TimePerLength o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(TimePerLength o1, PerLengthMassTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerLengthMassTimeCub o1, TimePerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(TimePerLength o1, TimeCubPerLengthMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubPerLengthMass o1, TimePerLength o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(TimePerLength o1, MassPerLengthTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerLengthTimeCub o1, TimePerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator/(TimePerLength o1, TimeCubMassPerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubMassPerLength o1, TimePerLength o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(TimePerLength o1, LengthPerMassTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthPerMassTimeCub o1, TimePerLength o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(TimePerLength o1, TimeCubLengthPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(TimeCubLengthPerMass o1, TimePerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator*(TimePerLength o1, LengthMassPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthMassPerTimeCub o1, TimePerLength o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(TimePerLength o1, TimeCubLengthMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(TimeCubLengthMass o1, TimePerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(TimePerLength o1, LengthSqrPerMassTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthSqrPerMassTimeSqr o1, TimePerLength o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimePerLength o1, LengthSqrPerMassTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthSqrPerMassTimeSqr o1, TimePerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(TimePerLength o1, LengthSqrTimeSqrPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(LengthSqrTimeSqrPerMass o1, TimePerLength o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(TimePerLength o1, LengthSqrTimeSqrPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(LengthSqrTimeSqrPerMass o1, TimePerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(TimePerLength o1, LengthSqrPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthSqrPerTimeCub o1, TimePerLength o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(TimePerLength o1, TimeCubLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeCubLengthSqr o1, TimePerLength o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(TimePerLength o1, LengthSqrMassPerTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthSqrMassPerTimeSqr o1, TimePerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimePerLength o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, TimePerLength o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(TimePerLength o1, LengthSqrTimeSqrMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthSqrTimeSqrMass o1, TimePerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(TimePerLength o1, LengthSqrTimeSqrMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthSqrTimeSqrMass o1, TimePerLength o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimePerLength o1, LengthCubPerMassTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubPerMassTime o1, TimePerLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(TimePerLength o1, LengthCubTimePerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubTimePerMass o1, TimePerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(TimePerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubPerTimeSqr o1, TimePerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(TimePerLength o1, LengthCubTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(LengthCubTimeSqr o1, TimePerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(TimePerLength o1, LengthCubMassPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubMassPerTime o1, TimePerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(TimePerLength o1, LengthCubMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthCubMassTime o1, TimePerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator/(TimePerLength o1, PerMassTimeSqrLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator/(TimePerLength o1, TimeSqrPerMassLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimePerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(TimePerLength o1, TimeCubPerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeCubPerLengthCub o1, TimePerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator/(TimePerLength o1, MassPerTimeSqrLengthCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerTimeSqrLengthCub o1, TimePerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator/(TimePerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeSqrMassPerLengthCub o1, TimePerLength o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(TimePerLength o1, PerMassLengthSqrTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerMassLengthSqrTimeCub o1, TimePerLength o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static Force operator/(TimePerLength o1, TimeCubPerMassLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubPerMassLengthSqr o1, TimePerLength o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(TimePerLength o1, MassPerLengthSqrTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerLengthSqrTimeCub o1, TimePerLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(TimePerLength o1, TimeCubMassPerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeCubMassPerLengthSqr o1, TimePerLength o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(TimePerLength o1, LengthSqrPerMassTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthSqrPerMassTimeCub o1, TimePerLength o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator/(TimePerLength o1, TimeCubLengthSqrPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeCubLengthSqrPerMass o1, TimePerLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Force operator*(TimePerLength o1, LengthSqrMassPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthSqrMassPerTimeCub o1, TimePerLength o2) => new Force(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator/(TimePerLength o1, TimeCubLengthSqrMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeCubLengthSqrMass o1, TimePerLength o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(TimePerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubPerMassTimeSqr o1, TimePerLength o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(TimePerLength o1, LengthCubTimeSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthCubTimeSqrPerMass o1, TimePerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static QDose operator*(TimePerLength o1, LengthCubPerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubPerTimeCub o1, TimePerLength o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator*(TimePerLength o1, LengthCubMassPerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthCubMassPerTimeSqr o1, TimePerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(TimePerLength o1, LengthCubTimeSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(LengthCubTimeSqrMass o1, TimePerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(TimePerLength o1, TimeCubPerMassLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeCubPerMassLengthCub o1, TimePerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(TimePerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeCubMassPerLengthCub o1, TimePerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(TimePerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthCubPerMassTimeCub o1, TimePerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(TimePerLength o1, LengthCubMassPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthCubMassPerTimeCub o1, TimePerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimePerLength is outside its bounds.");
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
    