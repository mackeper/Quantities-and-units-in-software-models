
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthMass : Quantity, IEquatable<PerLengthMass>, IComparable
  {  
    internal PerLengthMass(double value) : base(value, 2)
    {
      PerLengthMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthMass(PerLengthMass other) : base(other)
    {
      PerLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMass"))
    {
      switch(FakeDatabase.Units["PerLengthMass"])
      {
        case "percentimeterkilogram": displayUnit_ = percentimeterkilogram_; break;
        case "permillimeterkilogram": displayUnit_ = permillimeterkilogram_; break;
        case "permeterkilogram": displayUnit_ = permeterkilogram_; break;
        case "perinchkilogram": displayUnit_ = perinchkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimeterkilogram_ = new Unit_("PerCentimeterKilogram", "/cm kg", 1.0, 0);
  private static Unit_ permillimeterkilogram_ = new Unit_("PerMillimeterKilogram", "/mm kg", 0.1, 0);
  private static Unit_ permeterkilogram_ = new Unit_("PerMeterKilogram", "/m kg", 100.0, 0);
  private static Unit_ perinchkilogram_ = new Unit_("PerInchKilogram", "/in kg", 2.56, 0);
  private static Unit_ platformUnit_ = percentimeterkilogram_;
  private static Unit_ displayUnit_ = percentimeterkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthMass other && Equals(other);
  public bool Equals(PerLengthMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthMass other)) throw new ArgumentException("Object is not a PerLengthMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthMass l1, PerLengthMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthMass l1, PerLengthMass l2) => !(l1 == l2);
  public static bool operator <(PerLengthMass l1, PerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthMass l1, PerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthMass l1, PerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthMass l1, PerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthMass FromPerCentimeterKilograms(double value, double minValue, double maxValue) => new PerLengthMass((value + percentimeterkilogram_.Offset) * percentimeterkilogram_.Factor, minValue * percentimeterkilogram_.Factor, maxValue * percentimeterkilogram_.Factor);
  public static PerLengthMass FromPerCentimeterKilograms(double value) => new PerLengthMass((value + percentimeterkilogram_.Offset) * percentimeterkilogram_.Factor);
  public double GetValueInPerCentimeterKilograms() => (Value_ - percentimeterkilogram_.Offset) / percentimeterkilogram_.Factor;
  public static PerLengthMass FromPerMillimeterKilograms(double value, double minValue, double maxValue) => new PerLengthMass((value + permillimeterkilogram_.Offset) * permillimeterkilogram_.Factor, minValue * permillimeterkilogram_.Factor, maxValue * permillimeterkilogram_.Factor);
  public static PerLengthMass FromPerMillimeterKilograms(double value) => new PerLengthMass((value + permillimeterkilogram_.Offset) * permillimeterkilogram_.Factor);
  public double GetValueInPerMillimeterKilograms() => (Value_ - permillimeterkilogram_.Offset) / permillimeterkilogram_.Factor;
  public static PerLengthMass FromPerMeterKilograms(double value, double minValue, double maxValue) => new PerLengthMass((value + permeterkilogram_.Offset) * permeterkilogram_.Factor, minValue * permeterkilogram_.Factor, maxValue * permeterkilogram_.Factor);
  public static PerLengthMass FromPerMeterKilograms(double value) => new PerLengthMass((value + permeterkilogram_.Offset) * permeterkilogram_.Factor);
  public double GetValueInPerMeterKilograms() => (Value_ - permeterkilogram_.Offset) / permeterkilogram_.Factor;
  public static PerLengthMass FromPerInchKilograms(double value, double minValue, double maxValue) => new PerLengthMass((value + perinchkilogram_.Offset) * perinchkilogram_.Factor, minValue * perinchkilogram_.Factor, maxValue * perinchkilogram_.Factor);
  public static PerLengthMass FromPerInchKilograms(double value) => new PerLengthMass((value + perinchkilogram_.Offset) * perinchkilogram_.Factor);
  public double GetValueInPerInchKilograms() => (Value_ - perinchkilogram_.Offset) / perinchkilogram_.Factor;

#endregion

#region arithmetic
  public static PerLengthMass operator+(PerLengthMass o1, PerLengthMass o2) => new PerLengthMass(o1.Value_ + o2.Value_);
  public static PerLengthMass operator-(PerLengthMass o1, PerLengthMass o2) => new PerLengthMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthMass o1, PerLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(PerLengthMass o1, PerLengthTime o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerLengthTime o1, PerLengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(PerLengthMass o1, PerLengthTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerLengthTime o1, PerLengthMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(PerLengthMass o1, TimePerLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimePerLength o1, PerLengthMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(PerLengthMass o1, TimePerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimePerLength o1, PerLengthMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(PerLengthMass o1, MassPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerLength o1, PerLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(PerLengthMass o1, PerMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerMassTime o1, PerLengthMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(PerLengthMass o1, TimePerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimePerMass o1, PerLengthMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(PerLengthMass o1, PerTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerTimeSqr o1, PerLengthMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(PerLengthMass o1, PerTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(PerTimeSqr o1, PerLengthMass o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerLengthMass o1, TimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqr o1, PerLengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthMass o1, TimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeSqr o1, PerLengthMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(PerLengthMass o1, MassPerTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerTime o1, PerLengthMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(PerLengthMass o1, MassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(MassTime o1, PerLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(PerLengthMass o1, LengthPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthPerMass o1, PerLengthMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(PerLengthMass o1, Speed o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(Speed o1, PerLengthMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(PerLengthMass o1, Speed o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(Speed o1, PerLengthMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(PerLengthMass o1, LengthTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthTime o1, PerLengthMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthMass o1, LengthTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthTime o1, PerLengthMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerLengthMass o1, LengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthMass o1, PerLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(PerLengthMass o1, Area o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(Area o1, PerLengthMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(PerLengthMass o1, Area o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(Area o1, PerLengthMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerLengthMass o1, PerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(PerLengthCub o1, PerLengthMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(PerLengthMass o1, PerMassLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerMassLengthSqr o1, PerLengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(PerLengthMass o1, PerTimeLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerTimeLengthSqr o1, PerLengthMass o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(PerLengthMass o1, PerTimeLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(PerTimeLengthSqr o1, PerLengthMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(PerLengthMass o1, TimePerLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimePerLengthSqr o1, PerLengthMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(PerLengthMass o1, TimePerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimePerLengthSqr o1, PerLengthMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(PerLengthMass o1, MassPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(MassPerLengthSqr o1, PerLengthMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerLengthMass o1, PerLengthMassTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerLengthMassTime o1, PerLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(PerLengthMass o1, TimePerLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimePerLengthMass o1, PerLengthMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(PerLengthMass o1, PerLengthTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerLengthTimeSqr o1, PerLengthMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(PerLengthMass o1, PerLengthTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(PerLengthTimeSqr o1, PerLengthMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(PerLengthMass o1, TimeSqrPerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerLength o1, PerLengthMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator/(PerLengthMass o1, TimeSqrPerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrPerLength o1, PerLengthMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(PerLengthMass o1, MassPerLengthTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassPerLengthTime o1, PerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(PerLengthMass o1, MassTimePerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(MassTimePerLength o1, PerLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(PerLengthMass o1, PerMassTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerMassTimeSqr o1, PerLengthMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(PerLengthMass o1, TimeSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrPerMass o1, PerLengthMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(PerLengthMass o1, PerTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerTimeCub o1, PerLengthMass o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(PerLengthMass o1, PerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(PerTimeCub o1, PerLengthMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(PerLengthMass o1, TimeCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCub o1, PerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(PerLengthMass o1, TimeCub o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCub o1, PerLengthMass o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(PerLengthMass o1, MassPerTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerTimeSqr o1, PerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(PerLengthMass o1, TimeSqrMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrMass o1, PerLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(PerLengthMass o1, LengthPerMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthPerMassTime o1, PerLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(PerLengthMass o1, LengthTimePerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthTimePerMass o1, PerLengthMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(PerLengthMass o1, Acceleration o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(Acceleration o1, PerLengthMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(PerLengthMass o1, Acceleration o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(Acceleration o1, PerLengthMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(PerLengthMass o1, TimeSqrLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrLength o1, PerLengthMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthMass o1, TimeSqrLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(TimeSqrLength o1, PerLengthMass o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(PerLengthMass o1, LengthMassPerTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthMassPerTime o1, PerLengthMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerLengthMass o1, LengthMassTime o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthMassTime o1, PerLengthMass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(PerLengthMass o1, LengthSqrPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrPerMass o1, PerLengthMass o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(PerLengthMass o1, LengthSqrPerTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthSqrPerTime o1, PerLengthMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(PerLengthMass o1, LengthSqrPerTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthSqrPerTime o1, PerLengthMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(PerLengthMass o1, LengthSqrTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthSqrTime o1, PerLengthMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(PerLengthMass o1, LengthSqrTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthSqrTime o1, PerLengthMass o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(PerLengthMass o1, LengthSqrMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrMass o1, PerLengthMass o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator*(PerLengthMass o1, Volume o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(Volume o1, PerLengthMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static Area operator/(PerLengthMass o1, PerMassLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerMassLengthCub o1, PerLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator/(PerLengthMass o1, PerTimeLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(PerTimeLengthCub o1, PerLengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator/(PerLengthMass o1, TimePerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimePerLengthCub o1, PerLengthMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(PerLengthMass o1, PerMassTimeLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerMassTimeLengthSqr o1, PerLengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static Speed operator/(PerLengthMass o1, TimePerMassLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimePerMassLengthSqr o1, PerLengthMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(PerLengthMass o1, PerLengthSqrTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerLengthSqrTimeSqr o1, PerLengthMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator/(PerLengthMass o1, PerLengthSqrTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(PerLengthSqrTimeSqr o1, PerLengthMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(PerLengthMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrPerLengthSqr o1, PerLengthMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(PerLengthMass o1, MassPerTimeLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassPerTimeLengthSqr o1, PerLengthMass o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(PerLengthMass o1, MassTimePerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(MassTimePerLengthSqr o1, PerLengthMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(PerLengthMass o1, PerLengthMassTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerLengthMassTimeSqr o1, PerLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(PerLengthMass o1, TimeSqrPerLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrPerLengthMass o1, PerLengthMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(PerLengthMass o1, PerLengthTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerLengthTimeCub o1, PerLengthMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(PerLengthMass o1, PerLengthTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(PerLengthTimeCub o1, PerLengthMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(PerLengthMass o1, TimeCubPerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCubPerLength o1, PerLengthMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(PerLengthMass o1, TimeCubPerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubPerLength o1, PerLengthMass o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(PerLengthMass o1, MassPerLengthTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerLengthTimeSqr o1, PerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerLengthMass o1, TimeSqrMassPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(PerLengthMass o1, PerMassTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerMassTimeCub o1, PerLengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerLengthMass o1, TimeCubPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubPerMass o1, PerLengthMass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(PerLengthMass o1, MassPerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(MassPerTimeCub o1, PerLengthMass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(PerLengthMass o1, TimeCubMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubMass o1, PerLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerLengthMass o1, LengthPerMassTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthPerMassTimeSqr o1, PerLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerLengthMass o1, TimeSqrLengthPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeSqrLengthPerMass o1, PerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(PerLengthMass o1, LengthPerTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthPerTimeCub o1, PerLengthMass o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(PerLengthMass o1, LengthPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthPerTimeCub o1, PerLengthMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(PerLengthMass o1, TimeCubLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubLength o1, PerLengthMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthMass o1, TimeCubLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeCubLength o1, PerLengthMass o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(PerLengthMass o1, Force o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(Force o1, PerLengthMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(PerLengthMass o1, TimeSqrLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrLengthMass o1, PerLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(PerLengthMass o1, LengthSqrPerMassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrPerMassTime o1, PerLengthMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(PerLengthMass o1, LengthSqrTimePerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthSqrTimePerMass o1, PerLengthMass o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerLengthMass o1, QDose o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(QDose o1, PerLengthMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(PerLengthMass o1, QDose o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(QDose o1, PerLengthMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(PerLengthMass o1, LengthSqrTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthSqrTimeSqr o1, PerLengthMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthMass o1, LengthSqrTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthSqrTimeSqr o1, PerLengthMass o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static Speed operator*(PerLengthMass o1, LengthSqrMassPerTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrMassPerTime o1, PerLengthMass o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(PerLengthMass o1, LengthSqrMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrMassTime o1, PerLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerLengthMass o1, LengthCubPerTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubPerTime o1, PerLengthMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator*(PerLengthMass o1, LengthCubTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubTime o1, PerLengthMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(PerLengthMass o1, LengthCubMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubMass o1, PerLengthMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(PerLengthMass o1, PerMassTimeLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(PerLengthMass o1, TimePerMassLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimePerMassLengthCub o1, PerLengthMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(PerLengthMass o1, PerTimeSqrLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(PerTimeSqrLengthCub o1, PerLengthMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(PerLengthMass o1, TimeSqrPerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrPerLengthCub o1, PerLengthMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(PerLengthMass o1, PerMassLengthSqrTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassLengthSqrTimeSqr o1, PerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(PerLengthMass o1, TimeSqrPerMassLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrPerMassLengthSqr o1, PerLengthMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(PerLengthMass o1, PerLengthSqrTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerLengthSqrTimeCub o1, PerLengthMass o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(PerLengthMass o1, PerLengthSqrTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(PerLengthSqrTimeCub o1, PerLengthMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(PerLengthMass o1, TimeCubPerLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(PerLengthMass o1, TimeCubPerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubPerLengthSqr o1, PerLengthMass o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerLengthMass o1, MassPerLengthSqrTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(MassPerLengthSqrTimeSqr o1, PerLengthMass o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(PerLengthMass o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(PerLengthMass o1, PerLengthMassTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerLengthMassTimeCub o1, PerLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(PerLengthMass o1, TimeCubPerLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubPerLengthMass o1, PerLengthMass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(PerLengthMass o1, MassPerLengthTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerLengthTimeCub o1, PerLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(PerLengthMass o1, TimeCubMassPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(PerLengthMass o1, LengthPerMassTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthPerMassTimeCub o1, PerLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(PerLengthMass o1, TimeCubLengthPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubLengthPerMass o1, PerLengthMass o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(PerLengthMass o1, LengthMassPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthMassPerTimeCub o1, PerLengthMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(PerLengthMass o1, TimeCubLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubLengthMass o1, PerLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(PerLengthMass o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthSqrPerMassTimeSqr o1, PerLengthMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(PerLengthMass o1, LengthSqrTimeSqrPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthSqrTimeSqrPerMass o1, PerLengthMass o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(PerLengthMass o1, LengthSqrPerTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(LengthSqrPerTimeCub o1, PerLengthMass o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(PerLengthMass o1, LengthSqrPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthSqrPerTimeCub o1, PerLengthMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(PerLengthMass o1, TimeCubLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubLengthSqr o1, PerLengthMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthMass o1, TimeCubLengthSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(TimeCubLengthSqr o1, PerLengthMass o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(PerLengthMass o1, LengthSqrMassPerTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthSqrMassPerTimeSqr o1, PerLengthMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(PerLengthMass o1, LengthSqrTimeSqrMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthSqrTimeSqrMass o1, PerLengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(PerLengthMass o1, LengthCubPerTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthCubPerTimeSqr o1, PerLengthMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(PerLengthMass o1, LengthCubTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthCubTimeSqr o1, PerLengthMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(PerLengthMass o1, LengthCubMassPerTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubMassPerTime o1, PerLengthMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(PerLengthMass o1, LengthCubMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubMassTime o1, PerLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator/(PerLengthMass o1, PerMassTimeSqrLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(PerLengthMass o1, TimeSqrPerMassLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrPerMassLengthCub o1, PerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator/(PerLengthMass o1, PerLengthCubTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(PerLengthCubTimeCub o1, PerLengthMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator/(PerLengthMass o1, TimeCubPerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubPerLengthCub o1, PerLengthMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator/(PerLengthMass o1, PerMassLengthSqrTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerMassLengthSqrTimeCub o1, PerLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(PerLengthMass o1, TimeCubPerMassLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubPerMassLengthSqr o1, PerLengthMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(PerLengthMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(MassPerLengthSqrTimeCub o1, PerLengthMass o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(PerLengthMass o1, TimeCubMassPerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(PerLengthMass o1, LengthSqrPerMassTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthSqrPerMassTimeCub o1, PerLengthMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerLengthMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(TimeCubLengthSqrPerMass o1, PerLengthMass o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(PerLengthMass o1, LengthSqrMassPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthSqrMassPerTimeCub o1, PerLengthMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(PerLengthMass o1, TimeCubLengthSqrMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubLengthSqrMass o1, PerLengthMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(PerLengthMass o1, LengthCubPerTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthCubPerTimeCub o1, PerLengthMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(PerLengthMass o1, LengthCubTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthCubTimeCub o1, PerLengthMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static QDose operator*(PerLengthMass o1, LengthCubMassPerTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubMassPerTimeSqr o1, PerLengthMass o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(PerLengthMass o1, LengthCubTimeSqrMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubTimeSqrMass o1, PerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(PerLengthMass o1, PerMassLengthCubTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerMassLengthCubTimeCub o1, PerLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(PerLengthMass o1, TimeCubPerMassLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubPerMassLengthCub o1, PerLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(PerLengthMass o1, LengthCubMassPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthCubMassPerTimeCub o1, PerLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(PerLengthMass o1, LengthCubTimeCubMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(LengthCubTimeCubMass o1, PerLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthMass is outside its bounds.");
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
    