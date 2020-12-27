
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerLengthMass : Quantity, IEquatable<TimeSqrPerLengthMass>, IComparable
  {  
    internal TimeSqrPerLengthMass(double value) : base(value, 2)
    {
      TimeSqrPerLengthMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerLengthMass(TimeSqrPerLengthMass other) : base(other)
    {
      TimeSqrPerLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerLengthMass"))
    {
      switch(FakeDatabase.Units["TimeSqrPerLengthMass"])
      {
        case "secondsqrpercentimeterkilogram": displayUnit_ = secondsqrpercentimeterkilogram_; break;
        case "secondsqrpermillimeterkilogram": displayUnit_ = secondsqrpermillimeterkilogram_; break;
        case "secondsqrpermeterkilogram": displayUnit_ = secondsqrpermeterkilogram_; break;
        case "secondsqrperinchkilogram": displayUnit_ = secondsqrperinchkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrpercentimeterkilogram_ = new Unit_("SecondSqrPerCentimeterKilogram", "s²/cm kg", 1.0, 0);
  private static Unit_ secondsqrpermillimeterkilogram_ = new Unit_("SecondSqrPerMillimeterKilogram", "s²/mm kg", 10.0, 0);
  private static Unit_ secondsqrpermeterkilogram_ = new Unit_("SecondSqrPerMeterKilogram", "s²/m kg", 0.01, 0);
  private static Unit_ secondsqrperinchkilogram_ = new Unit_("SecondSqrPerInchKilogram", "s²/in kg", 0.390625, 0);
  private static Unit_ platformUnit_ = secondsqrpercentimeterkilogram_;
  private static Unit_ displayUnit_ = secondsqrpercentimeterkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerLengthMass other && Equals(other);
  public bool Equals(TimeSqrPerLengthMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerLengthMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerLengthMass other)) throw new ArgumentException("Object is not a TimeSqrPerLengthMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerLengthMass l1, TimeSqrPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerLengthMass FromSecondSqrPerCentimeterKilograms(double value, double minValue, double maxValue) => new TimeSqrPerLengthMass((value + secondsqrpercentimeterkilogram_.Offset) * secondsqrpercentimeterkilogram_.Factor, minValue * secondsqrpercentimeterkilogram_.Factor, maxValue * secondsqrpercentimeterkilogram_.Factor);
  public static TimeSqrPerLengthMass FromSecondSqrPerCentimeterKilograms(double value) => new TimeSqrPerLengthMass((value + secondsqrpercentimeterkilogram_.Offset) * secondsqrpercentimeterkilogram_.Factor);
  public double GetValueInSecondSqrPerCentimeterKilograms() => (Value_ - secondsqrpercentimeterkilogram_.Offset) / secondsqrpercentimeterkilogram_.Factor;
  public static TimeSqrPerLengthMass FromSecondSqrPerMillimeterKilograms(double value, double minValue, double maxValue) => new TimeSqrPerLengthMass((value + secondsqrpermillimeterkilogram_.Offset) * secondsqrpermillimeterkilogram_.Factor, minValue * secondsqrpermillimeterkilogram_.Factor, maxValue * secondsqrpermillimeterkilogram_.Factor);
  public static TimeSqrPerLengthMass FromSecondSqrPerMillimeterKilograms(double value) => new TimeSqrPerLengthMass((value + secondsqrpermillimeterkilogram_.Offset) * secondsqrpermillimeterkilogram_.Factor);
  public double GetValueInSecondSqrPerMillimeterKilograms() => (Value_ - secondsqrpermillimeterkilogram_.Offset) / secondsqrpermillimeterkilogram_.Factor;
  public static TimeSqrPerLengthMass FromSecondSqrPerMeterKilograms(double value, double minValue, double maxValue) => new TimeSqrPerLengthMass((value + secondsqrpermeterkilogram_.Offset) * secondsqrpermeterkilogram_.Factor, minValue * secondsqrpermeterkilogram_.Factor, maxValue * secondsqrpermeterkilogram_.Factor);
  public static TimeSqrPerLengthMass FromSecondSqrPerMeterKilograms(double value) => new TimeSqrPerLengthMass((value + secondsqrpermeterkilogram_.Offset) * secondsqrpermeterkilogram_.Factor);
  public double GetValueInSecondSqrPerMeterKilograms() => (Value_ - secondsqrpermeterkilogram_.Offset) / secondsqrpermeterkilogram_.Factor;
  public static TimeSqrPerLengthMass FromSecondSqrPerInchKilograms(double value, double minValue, double maxValue) => new TimeSqrPerLengthMass((value + secondsqrperinchkilogram_.Offset) * secondsqrperinchkilogram_.Factor, minValue * secondsqrperinchkilogram_.Factor, maxValue * secondsqrperinchkilogram_.Factor);
  public static TimeSqrPerLengthMass FromSecondSqrPerInchKilograms(double value) => new TimeSqrPerLengthMass((value + secondsqrperinchkilogram_.Offset) * secondsqrperinchkilogram_.Factor);
  public double GetValueInSecondSqrPerInchKilograms() => (Value_ - secondsqrperinchkilogram_.Offset) / secondsqrperinchkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerLengthMass operator+(TimeSqrPerLengthMass o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ + o2.Value_);
  public static TimeSqrPerLengthMass operator-(TimeSqrPerLengthMass o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerLengthMass o1, TimeSqrPerLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrPerLengthMass o1, PerLengthTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerLengthTimeCub o1, TimeSqrPerLengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerLengthMass o1, TimeCubPerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubPerLength o1, TimeSqrPerLengthMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeSqrPerLengthMass o1, MassPerLengthTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerLengthTimeSqr o1, TimeSqrPerLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerLengthMass o1, TimeCubPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubPerMass o1, TimeSqrPerLengthMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerLengthMass o1, MassPerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerTimeCub o1, TimeSqrPerLengthMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeSqrPerLengthMass o1, TimeSqrLengthPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeSqrLengthPerMass o1, TimeSqrPerLengthMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerLengthMass o1, LengthPerTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthPerTimeCub o1, TimeSqrPerLengthMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrPerLengthMass o1, TimeCubLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeCubLength o1, TimeSqrPerLengthMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerLengthMass o1, Force o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Force o1, TimeSqrPerLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrPerMassTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthSqrPerMassTime o1, TimeSqrPerLengthMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrTimePerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrTimePerMass o1, TimeSqrPerLengthMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeSqrPerLengthMass o1, QDose o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(QDose o1, TimeSqrPerLengthMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthSqrTimeSqr o1, TimeSqrPerLengthMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeSqrPerLengthMass o1, LengthSqrMassPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrMassPerTime o1, TimeSqrPerLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(TimeSqrPerLengthMass o1, LengthSqrMassTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthSqrMassTime o1, TimeSqrPerLengthMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimeSqrPerLengthMass o1, LengthCubPerTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthCubPerTime o1, TimeSqrPerLengthMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(TimeSqrPerLengthMass o1, LengthCubTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(LengthCubTime o1, TimeSqrPerLengthMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeSqrPerLengthMass o1, LengthCubMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubMass o1, TimeSqrPerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(TimeSqrPerLengthMass o1, PerMassTimeLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimeSqrPerLengthMass o1, TimePerMassLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimePerMassLengthCub o1, TimeSqrPerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeSqrPerLengthMass o1, TimeSqrPerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeSqrPerLengthCub o1, TimeSqrPerLengthMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(TimeSqrPerLengthMass o1, TimeSqrPerMassLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerLengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(TimeSqrPerLengthMass o1, PerLengthSqrTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerLengthSqrTimeCub o1, TimeSqrPerLengthMass o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator/(TimeSqrPerLengthMass o1, TimeCubPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubPerLengthSqr o1, TimeSqrPerLengthMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeSqrPerLengthMass o1, MassPerLengthSqrTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(MassPerLengthSqrTimeSqr o1, TimeSqrPerLengthMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrPerLengthMass o1, TimeCubPerLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerLengthMass o1, TimeSqrPerLengthMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimeSqrPerLengthMass o1, MassPerLengthTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassPerLengthTimeCub o1, TimeSqrPerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(TimeSqrPerLengthMass o1, TimeCubLengthPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(TimeCubLengthPerMass o1, TimeSqrPerLengthMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrPerLengthMass o1, LengthMassPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthMassPerTimeCub o1, TimeSqrPerLengthMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrTimeSqrPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrTimeSqrPerMass o1, TimeSqrPerLengthMass o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(TimeSqrPerLengthMass o1, LengthSqrPerTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerLengthMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthCub operator/(TimeSqrPerLengthMass o1, TimeCubLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(TimeCubLengthSqr o1, TimeSqrPerLengthMass o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeSqrPerLengthMass o1, LengthSqrMassPerTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerLengthMass o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeSqrPerLengthMass o1, LengthCubPerTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthCubPerTimeSqr o1, TimeSqrPerLengthMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(TimeSqrPerLengthMass o1, LengthCubMassPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubMassPerTime o1, TimeSqrPerLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(TimeSqrPerLengthMass o1, LengthCubMassTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(LengthCubMassTime o1, TimeSqrPerLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static Area operator/(TimeSqrPerLengthMass o1, TimeSqrPerMassLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator/(TimeSqrPerLengthMass o1, TimeCubPerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeCubPerLengthCub o1, TimeSqrPerLengthMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Speed operator/(TimeSqrPerLengthMass o1, TimeCubPerMassLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerLengthMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimeSqrPerLengthMass o1, MassPerLengthSqrTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassPerLengthSqrTimeCub o1, TimeSqrPerLengthMass o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(TimeSqrPerLengthMass o1, TimeCubLengthSqrPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeCubLengthSqrPerMass o1, TimeSqrPerLengthMass o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static Speed operator*(TimeSqrPerLengthMass o1, LengthSqrMassPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerLengthMass o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTime operator*(TimeSqrPerLengthMass o1, LengthCubPerTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthCubPerTimeCub o1, TimeSqrPerLengthMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static Area operator*(TimeSqrPerLengthMass o1, LengthCubMassPerTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerLengthMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(TimeSqrPerLengthMass o1, TimeCubPerMassLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeCubPerMassLengthCub o1, TimeSqrPerLengthMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(TimeSqrPerLengthMass o1, LengthCubMassPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerLengthMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerLengthMass is outside its bounds.");
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
    