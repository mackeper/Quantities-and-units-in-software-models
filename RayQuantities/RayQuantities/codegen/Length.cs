
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Length : Quantity, IEquatable<Length>, IComparable
  {  
    internal Length(double value) : base(value, 2)
    {
      Length.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Length(double value, double minValue, double maxValue) : base(value, 2)
    {
      Length.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Length(Length other) : base(other)
    {
      Length.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Length"))
    {
      switch(FakeDatabase.Units["Length"])
      {
        case "centimeter": displayUnit_ = centimeter_; break;
        case "millimeter": displayUnit_ = millimeter_; break;
        case "meter": displayUnit_ = meter_; break;
        case "inch": displayUnit_ = inch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeter_ = new Unit_("Centimeter", "cm", 1, 0);
  private static Unit_ millimeter_ = new Unit_("Millimeter", "mm", 0.1, 0);
  private static Unit_ meter_ = new Unit_("Meter", "m", 100, 0);
  private static Unit_ inch_ = new Unit_("Inch", "in", 2.56, 0);
  private static Unit_ platformUnit_ = centimeter_;
  private static Unit_ displayUnit_ = centimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Length other && Equals(other);
  public bool Equals(Length other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Length other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Length other)) throw new ArgumentException("Object is not a Length.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Length l1, Length l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Length l1, Length l2) => !(l1 == l2);
  public static bool operator <(Length l1, Length l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Length l1, Length l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Length l1, Length l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Length l1, Length l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Length FromCentimeters(double value, double minValue, double maxValue) => new Length((value + centimeter_.Offset) * centimeter_.Factor, minValue * centimeter_.Factor, maxValue * centimeter_.Factor);
  public static Length FromCentimeters(double value) => new Length((value + centimeter_.Offset) * centimeter_.Factor);
  public double GetValueInCentimeters() => (Value_ - centimeter_.Offset) / centimeter_.Factor;
  public static Length FromMillimeters(double value, double minValue, double maxValue) => new Length((value + millimeter_.Offset) * millimeter_.Factor, minValue * millimeter_.Factor, maxValue * millimeter_.Factor);
  public static Length FromMillimeters(double value) => new Length((value + millimeter_.Offset) * millimeter_.Factor);
  public double GetValueInMillimeters() => (Value_ - millimeter_.Offset) / millimeter_.Factor;
  public static Length FromMeters(double value, double minValue, double maxValue) => new Length((value + meter_.Offset) * meter_.Factor, minValue * meter_.Factor, maxValue * meter_.Factor);
  public static Length FromMeters(double value) => new Length((value + meter_.Offset) * meter_.Factor);
  public double GetValueInMeters() => (Value_ - meter_.Offset) / meter_.Factor;
  public static Length FromInchs(double value, double minValue, double maxValue) => new Length((value + inch_.Offset) * inch_.Factor, minValue * inch_.Factor, maxValue * inch_.Factor);
  public static Length FromInchs(double value) => new Length((value + inch_.Offset) * inch_.Factor);
  public double GetValueInInchs() => (Value_ - inch_.Offset) / inch_.Factor;

#endregion

#region arithmetic
  public static Length operator+(Length o1, Length o2) => new Length(o1.Value_ + o2.Value_);
  public static Length operator-(Length o1, Length o2) => new Length(o1.Value_ - o2.Value_);
  public static Area operator*(Length o1, Length o2) => new Area(o1.Value_ * o2.Value_);
  public static Dimensionless operator/(Length o1, Length o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(Length o1, PerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthSqr o1, Length o2) => new PerLength(o1.Value_ * o2.Value_);
  public static Volume operator/(Length o1, PerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerLengthSqr o1, Length o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(Length o1, PerLengthMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerLengthMass o1, Length o2) => new PerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator/(Length o1, PerLengthMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerLengthMass o1, Length o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(Length o1, PerLengthTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthTime o1, Length o2) => new PerTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator/(Length o1, PerLengthTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthTime o1, Length o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Time operator*(Length o1, TimePerLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerLength o1, Length o2) => new Time(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator/(Length o1, TimePerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimePerLength o1, Length o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator*(Length o1, MassPerLength o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerLength o1, Length o2) => new Mass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator/(Length o1, MassPerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassPerLength o1, Length o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(Length o1, PerMassTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassTime o1, Length o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(Length o1, PerMassTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerMassTime o1, Length o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(Length o1, TimePerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimePerMass o1, Length o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(Length o1, TimePerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimePerMass o1, Length o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(Length o1, PerTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerTimeSqr o1, Length o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator/(Length o1, PerTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerTimeSqr o1, Length o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(Length o1, TimeSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqr o1, Length o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static Acceleration operator/(Length o1, TimeSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqr o1, Length o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(Length o1, MassPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerTime o1, Length o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(Length o1, MassPerTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerTime o1, Length o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(Length o1, MassTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(MassTime o1, Length o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(Length o1, MassTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(MassTime o1, Length o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(Length o1, LengthPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthPerMass o1, Length o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static Mass operator/(Length o1, LengthPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthPerMass o1, Length o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(Length o1, Speed o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(Speed o1, Length o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static Time operator/(Length o1, Speed o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(Speed o1, Length o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(Length o1, LengthTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthTime o1, Length o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static PerTime operator/(Length o1, LengthTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthTime o1, Length o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(Length o1, LengthMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthMass o1, Length o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static PerMass operator/(Length o1, LengthMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthMass o1, Length o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static Volume operator*(Length o1, Area o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(Area o1, Length o2) => new Volume(o1.Value_ * o2.Value_);
  public static PerLength operator/(Length o1, Area o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(Area o1, Length o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(Length o1, PerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerLengthCub o1, Length o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(Length o1, PerMassLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassLengthSqr o1, Length o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator/(Length o1, PerMassLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerMassLengthSqr o1, Length o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(Length o1, PerTimeLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerTimeLengthSqr o1, Length o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator/(Length o1, PerTimeLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerTimeLengthSqr o1, Length o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(Length o1, TimePerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerLengthSqr o1, Length o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator/(Length o1, TimePerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimePerLengthSqr o1, Length o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(Length o1, MassPerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerLengthSqr o1, Length o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator/(Length o1, MassPerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(MassPerLengthSqr o1, Length o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(Length o1, PerLengthMassTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerLengthMassTime o1, Length o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator/(Length o1, PerLengthMassTime o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthMassTime o1, Length o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(Length o1, TimePerLengthMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimePerLengthMass o1, Length o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator/(Length o1, TimePerLengthMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimePerLengthMass o1, Length o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(Length o1, PerLengthTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthTimeSqr o1, Length o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator/(Length o1, PerLengthTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthTimeSqr o1, Length o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(Length o1, TimeSqrPerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerLength o1, Length o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static QDose operator/(Length o1, TimeSqrPerLength o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrPerLength o1, Length o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(Length o1, MassPerLengthTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerLengthTime o1, Length o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator/(Length o1, MassPerLengthTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassPerLengthTime o1, Length o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(Length o1, MassTimePerLength o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(MassTimePerLength o1, Length o2) => new MassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator/(Length o1, MassTimePerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(MassTimePerLength o1, Length o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(Length o1, PerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerMassTimeSqr o1, Length o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator/(Length o1, PerMassTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerMassTimeSqr o1, Length o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(Length o1, TimeSqrPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeSqrPerMass o1, Length o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static Force operator/(Length o1, TimeSqrPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrPerMass o1, Length o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(Length o1, PerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(PerTimeCub o1, Length o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLength operator/(Length o1, PerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerTimeCub o1, Length o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator*(Length o1, TimeCub o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCub o1, Length o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator/(Length o1, TimeCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCub o1, Length o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static Force operator*(Length o1, MassPerTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerTimeSqr o1, Length o2) => new Force(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator/(Length o1, MassPerTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerTimeSqr o1, Length o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(Length o1, TimeSqrMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeSqrMass o1, Length o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator/(Length o1, TimeSqrMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrMass o1, Length o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(Length o1, LengthPerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthPerMassTime o1, Length o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static MassTime operator/(Length o1, LengthPerMassTime o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthPerMassTime o1, Length o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(Length o1, LengthTimePerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthTimePerMass o1, Length o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerTime operator/(Length o1, LengthTimePerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthTimePerMass o1, Length o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(Length o1, Acceleration o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(Acceleration o1, Length o2) => new QDose(o1.Value_ * o2.Value_);
  public static TimeSqr operator/(Length o1, Acceleration o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(Acceleration o1, Length o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(Length o1, TimeSqrLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(TimeSqrLength o1, Length o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator/(Length o1, TimeSqrLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrLength o1, Length o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(Length o1, LengthMassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthMassPerTime o1, Length o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(Length o1, LengthMassPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthMassPerTime o1, Length o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(Length o1, LengthMassTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthMassTime o1, Length o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(Length o1, LengthMassTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthMassTime o1, Length o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(Length o1, LengthSqrPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrPerMass o1, Length o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(Length o1, LengthSqrPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrPerMass o1, Length o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(Length o1, LengthSqrPerTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrPerTime o1, Length o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static TimePerLength operator/(Length o1, LengthSqrPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerTime o1, Length o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(Length o1, LengthSqrTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrTime o1, Length o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(Length o1, LengthSqrTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrTime o1, Length o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(Length o1, LengthSqrMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrMass o1, Length o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(Length o1, LengthSqrMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrMass o1, Length o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(Length o1, Volume o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(Volume o1, Length o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(Length o1, PerMassLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerMassLengthCub o1, Length o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(Length o1, PerTimeLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerTimeLengthCub o1, Length o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(Length o1, TimePerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimePerLengthCub o1, Length o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(Length o1, Density o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(Density o1, Length o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator*(Length o1, PerMassTimeLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassTimeLengthSqr o1, Length o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(Length o1, PerMassTimeLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerMassTimeLengthSqr o1, Length o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(Length o1, TimePerMassLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimePerMassLengthSqr o1, Length o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(Length o1, TimePerMassLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerMassLengthSqr o1, Length o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(Length o1, PerLengthSqrTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthSqrTimeSqr o1, Length o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator/(Length o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerLengthSqrTimeSqr o1, Length o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(Length o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerLengthSqr o1, Length o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator/(Length o1, TimeSqrPerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrPerLengthSqr o1, Length o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(Length o1, MassPerTimeLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerTimeLengthSqr o1, Length o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(Length o1, MassPerTimeLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerTimeLengthSqr o1, Length o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(Length o1, MassTimePerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassTimePerLengthSqr o1, Length o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(Length o1, MassTimePerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(MassTimePerLengthSqr o1, Length o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(Length o1, PerLengthMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthMassTimeSqr o1, Length o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(Length o1, PerLengthMassTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthMassTimeSqr o1, Length o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(Length o1, TimeSqrPerLengthMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerLengthMass o1, Length o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(Length o1, TimeSqrPerLengthMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerLengthMass o1, Length o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(Length o1, PerLengthTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerLengthTimeCub o1, Length o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator/(Length o1, PerLengthTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthTimeCub o1, Length o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCub operator*(Length o1, TimeCubPerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerLength o1, Length o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator/(Length o1, TimeCubPerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubPerLength o1, Length o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator*(Length o1, MassPerLengthTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerLengthTimeSqr o1, Length o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(Length o1, MassPerLengthTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerLengthTimeSqr o1, Length o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(Length o1, TimeSqrMassPerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrMassPerLength o1, Length o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(Length o1, TimeSqrMassPerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrMassPerLength o1, Length o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(Length o1, PerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerMassTimeCub o1, Length o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(Length o1, PerMassTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerMassTimeCub o1, Length o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(Length o1, TimeCubPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubPerMass o1, Length o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(Length o1, TimeCubPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubPerMass o1, Length o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator*(Length o1, MassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(MassPerTimeCub o1, Length o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(Length o1, MassPerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerTimeCub o1, Length o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(Length o1, TimeCubMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubMass o1, Length o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(Length o1, TimeCubMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubMass o1, Length o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(Length o1, LengthPerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthPerMassTimeSqr o1, Length o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(Length o1, LengthPerMassTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthPerMassTimeSqr o1, Length o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(Length o1, TimeSqrLengthPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeSqrLengthPerMass o1, Length o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator/(Length o1, TimeSqrLengthPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqrLengthPerMass o1, Length o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(Length o1, LengthPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthPerTimeCub o1, Length o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator/(Length o1, LengthPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthPerTimeCub o1, Length o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator*(Length o1, TimeCubLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubLength o1, Length o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeCub operator/(Length o1, TimeCubLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLength o1, Length o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(Length o1, Force o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(Force o1, Length o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(Length o1, Force o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(Force o1, Length o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(Length o1, TimeSqrLengthMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeSqrLengthMass o1, Length o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator/(Length o1, TimeSqrLengthMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrLengthMass o1, Length o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(Length o1, LengthSqrPerMassTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrPerMassTime o1, Length o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(Length o1, LengthSqrPerMassTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrPerMassTime o1, Length o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(Length o1, LengthSqrTimePerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthSqrTimePerMass o1, Length o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(Length o1, LengthSqrTimePerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrTimePerMass o1, Length o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(Length o1, QDose o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(QDose o1, Length o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator/(Length o1, QDose o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(QDose o1, Length o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(Length o1, LengthSqrTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrTimeSqr o1, Length o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator/(Length o1, LengthSqrTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthSqrTimeSqr o1, Length o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(Length o1, LengthSqrMassPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrMassPerTime o1, Length o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(Length o1, LengthSqrMassPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrMassPerTime o1, Length o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Length o1, LengthSqrMassTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthSqrMassTime o1, Length o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(Length o1, LengthSqrMassTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrMassTime o1, Length o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(Length o1, LengthCubPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubPerMass o1, Length o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(Length o1, LengthCubPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerTime o1, Length o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(Length o1, LengthCubTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTime o1, Length o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(Length o1, LengthCubMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubMass o1, Length o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(Length o1, PerMassTimeLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassTimeLengthCub o1, Length o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator*(Length o1, TimePerMassLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimePerMassLengthCub o1, Length o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(Length o1, PerTimeSqrLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerTimeSqrLengthCub o1, Length o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(Length o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrPerLengthCub o1, Length o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(Length o1, MassPerTimeLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerTimeLengthCub o1, Length o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(Length o1, MassTimePerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassTimePerLengthCub o1, Length o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(Length o1, PerMassLengthSqrTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassLengthSqrTimeSqr o1, Length o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(Length o1, PerMassLengthSqrTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerMassLengthSqrTimeSqr o1, Length o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(Length o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrPerMassLengthSqr o1, Length o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(Length o1, TimeSqrPerMassLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerMassLengthSqr o1, Length o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(Length o1, PerLengthSqrTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerLengthSqrTimeCub o1, Length o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator/(Length o1, PerLengthSqrTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthSqrTimeCub o1, Length o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator*(Length o1, TimeCubPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerLengthSqr o1, Length o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator/(Length o1, TimeCubPerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubPerLengthSqr o1, Length o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(Length o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerLengthSqrTimeSqr o1, Length o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(Length o1, MassPerLengthSqrTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerLengthSqrTimeSqr o1, Length o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(Length o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrMassPerLengthSqr o1, Length o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(Length o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeSqrMassPerLengthSqr o1, Length o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(Length o1, PerLengthMassTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerLengthMassTimeCub o1, Length o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(Length o1, PerLengthMassTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthMassTimeCub o1, Length o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(Length o1, TimeCubPerLengthMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerLengthMass o1, Length o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(Length o1, TimeCubPerLengthMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubPerLengthMass o1, Length o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator*(Length o1, MassPerLengthTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerLengthTimeCub o1, Length o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(Length o1, MassPerLengthTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerLengthTimeCub o1, Length o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(Length o1, TimeCubMassPerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubMassPerLength o1, Length o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(Length o1, TimeCubMassPerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubMassPerLength o1, Length o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(Length o1, LengthPerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthPerMassTimeCub o1, Length o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(Length o1, LengthPerMassTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthPerMassTimeCub o1, Length o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(Length o1, TimeCubLengthPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeCubLengthPerMass o1, Length o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator/(Length o1, TimeCubLengthPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubLengthPerMass o1, Length o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Length o1, LengthMassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthMassPerTimeCub o1, Length o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(Length o1, LengthMassPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthMassPerTimeCub o1, Length o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(Length o1, TimeCubLengthMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubLengthMass o1, Length o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(Length o1, TimeCubLengthMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubLengthMass o1, Length o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(Length o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrPerMassTimeSqr o1, Length o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(Length o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthSqrPerMassTimeSqr o1, Length o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(Length o1, LengthSqrTimeSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthSqrTimeSqrPerMass o1, Length o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(Length o1, LengthSqrTimeSqrPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthSqrTimeSqrPerMass o1, Length o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Length o1, LengthSqrPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrPerTimeCub o1, Length o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(Length o1, LengthSqrPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrPerTimeCub o1, Length o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(Length o1, TimeCubLengthSqr o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLengthSqr o1, Length o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator/(Length o1, TimeCubLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubLengthSqr o1, Length o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(Length o1, LengthSqrMassPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthSqrMassPerTimeSqr o1, Length o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(Length o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthSqrMassPerTimeSqr o1, Length o2) => new Force(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(Length o1, LengthSqrTimeSqrMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthSqrTimeSqrMass o1, Length o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(Length o1, LengthSqrTimeSqrMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthSqrTimeSqrMass o1, Length o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(Length o1, LengthCubPerMassTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubPerMassTime o1, Length o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(Length o1, LengthCubTimePerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTimePerMass o1, Length o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(Length o1, LengthCubPerTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerTimeSqr o1, Length o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(Length o1, LengthCubTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeSqr o1, Length o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(Length o1, LengthCubMassPerTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubMassPerTime o1, Length o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(Length o1, LengthCubMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubMassTime o1, Length o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(Length o1, PerMassTimeSqrLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerMassTimeSqrLengthCub o1, Length o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(Length o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerMassLengthCub o1, Length o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(Length o1, PerLengthCubTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerLengthCubTimeCub o1, Length o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(Length o1, TimeCubPerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubPerLengthCub o1, Length o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(Length o1, MassPerTimeSqrLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerTimeSqrLengthCub o1, Length o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(Length o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrMassPerLengthCub o1, Length o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeCub operator*(Length o1, PerMassLengthSqrTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerMassLengthSqrTimeCub o1, Length o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(Length o1, PerMassLengthSqrTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassLengthSqrTimeCub o1, Length o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(Length o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubPerMassLengthSqr o1, Length o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Length o1, TimeCubPerMassLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerMassLengthSqr o1, Length o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator*(Length o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerLengthSqrTimeCub o1, Length o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(Length o1, MassPerLengthSqrTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthSqrTimeCub o1, Length o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(Length o1, TimeCubMassPerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubMassPerLengthSqr o1, Length o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(Length o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubMassPerLengthSqr o1, Length o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(Length o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthSqrPerMassTimeCub o1, Length o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(Length o1, LengthSqrPerMassTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerMassTimeCub o1, Length o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(Length o1, TimeCubLengthSqrPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeCubLengthSqrPerMass o1, Length o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(Length o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubLengthSqrPerMass o1, Length o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Length o1, LengthSqrMassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthSqrMassPerTimeCub o1, Length o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(Length o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrMassPerTimeCub o1, Length o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(Length o1, TimeCubLengthSqrMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeCubLengthSqrMass o1, Length o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(Length o1, TimeCubLengthSqrMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCubLengthSqrMass o1, Length o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(Length o1, LengthCubPerMassTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthCubPerMassTimeSqr o1, Length o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(Length o1, LengthCubTimeSqrPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubTimeSqrPerMass o1, Length o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(Length o1, LengthCubPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerTimeCub o1, Length o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(Length o1, LengthCubTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTimeCub o1, Length o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(Length o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubMassPerTimeSqr o1, Length o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(Length o1, LengthCubTimeSqrMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubTimeSqrMass o1, Length o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(Length o1, PerMassLengthCubTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerMassLengthCubTimeCub o1, Length o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(Length o1, TimeCubPerMassLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCubPerMassLengthCub o1, Length o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(Length o1, MassPerLengthCubTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(MassPerLengthCubTimeCub o1, Length o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(Length o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCubMassPerLengthCub o1, Length o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(Length o1, LengthCubPerMassTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerMassTimeCub o1, Length o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(Length o1, LengthCubTimeCubPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthCubTimeCubPerMass o1, Length o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(Length o1, LengthCubMassPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubMassPerTimeCub o1, Length o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(Length o1, LengthCubTimeCubMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubTimeCubMass o1, Length o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Length is outside its bounds.");
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
    