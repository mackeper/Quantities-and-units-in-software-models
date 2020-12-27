
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrLengthPerMass : Quantity, IEquatable<TimeSqrLengthPerMass>, IComparable
  {  
    internal TimeSqrLengthPerMass(double value) : base(value, 2)
    {
      TimeSqrLengthPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrLengthPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrLengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrLengthPerMass(TimeSqrLengthPerMass other) : base(other)
    {
      TimeSqrLengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrLengthPerMass"))
    {
      switch(FakeDatabase.Units["TimeSqrLengthPerMass"])
      {
        case "secondsqrcentimeterperkilogram": displayUnit_ = secondsqrcentimeterperkilogram_; break;
        case "secondsqrmillimeterperkilogram": displayUnit_ = secondsqrmillimeterperkilogram_; break;
        case "secondsqrmeterperkilogram": displayUnit_ = secondsqrmeterperkilogram_; break;
        case "secondsqrinchperkilogram": displayUnit_ = secondsqrinchperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrcentimeterperkilogram_ = new Unit_("SecondSqrCentimeterPerKilogram", "s� cm/kg", 1.0, 0);
  private static Unit_ secondsqrmillimeterperkilogram_ = new Unit_("SecondSqrMillimeterPerKilogram", "s� mm/kg", 0.1, 0);
  private static Unit_ secondsqrmeterperkilogram_ = new Unit_("SecondSqrMeterPerKilogram", "s� m/kg", 100.0, 0);
  private static Unit_ secondsqrinchperkilogram_ = new Unit_("SecondSqrInchPerKilogram", "s� in/kg", 2.56, 0);
  private static Unit_ platformUnit_ = secondsqrcentimeterperkilogram_;
  private static Unit_ displayUnit_ = secondsqrcentimeterperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrLengthPerMass other && Equals(other);
  public bool Equals(TimeSqrLengthPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrLengthPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrLengthPerMass other)) throw new ArgumentException("Object is not a TimeSqrLengthPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => !(l1 == l2);
  public static bool operator <(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrLengthPerMass l1, TimeSqrLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrLengthPerMass FromSecondSqrCentimeterPerKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthPerMass((value + secondsqrcentimeterperkilogram_.Offset) * secondsqrcentimeterperkilogram_.Factor, minValue * secondsqrcentimeterperkilogram_.Factor, maxValue * secondsqrcentimeterperkilogram_.Factor);
  public static TimeSqrLengthPerMass FromSecondSqrCentimeterPerKilograms(double value) => new TimeSqrLengthPerMass((value + secondsqrcentimeterperkilogram_.Offset) * secondsqrcentimeterperkilogram_.Factor);
  public double GetValueInSecondSqrCentimeterPerKilograms() => (Value_ - secondsqrcentimeterperkilogram_.Offset) / secondsqrcentimeterperkilogram_.Factor;
  public static TimeSqrLengthPerMass FromSecondSqrMillimeterPerKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthPerMass((value + secondsqrmillimeterperkilogram_.Offset) * secondsqrmillimeterperkilogram_.Factor, minValue * secondsqrmillimeterperkilogram_.Factor, maxValue * secondsqrmillimeterperkilogram_.Factor);
  public static TimeSqrLengthPerMass FromSecondSqrMillimeterPerKilograms(double value) => new TimeSqrLengthPerMass((value + secondsqrmillimeterperkilogram_.Offset) * secondsqrmillimeterperkilogram_.Factor);
  public double GetValueInSecondSqrMillimeterPerKilograms() => (Value_ - secondsqrmillimeterperkilogram_.Offset) / secondsqrmillimeterperkilogram_.Factor;
  public static TimeSqrLengthPerMass FromSecondSqrMeterPerKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthPerMass((value + secondsqrmeterperkilogram_.Offset) * secondsqrmeterperkilogram_.Factor, minValue * secondsqrmeterperkilogram_.Factor, maxValue * secondsqrmeterperkilogram_.Factor);
  public static TimeSqrLengthPerMass FromSecondSqrMeterPerKilograms(double value) => new TimeSqrLengthPerMass((value + secondsqrmeterperkilogram_.Offset) * secondsqrmeterperkilogram_.Factor);
  public double GetValueInSecondSqrMeterPerKilograms() => (Value_ - secondsqrmeterperkilogram_.Offset) / secondsqrmeterperkilogram_.Factor;
  public static TimeSqrLengthPerMass FromSecondSqrInchPerKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthPerMass((value + secondsqrinchperkilogram_.Offset) * secondsqrinchperkilogram_.Factor, minValue * secondsqrinchperkilogram_.Factor, maxValue * secondsqrinchperkilogram_.Factor);
  public static TimeSqrLengthPerMass FromSecondSqrInchPerKilograms(double value) => new TimeSqrLengthPerMass((value + secondsqrinchperkilogram_.Offset) * secondsqrinchperkilogram_.Factor);
  public double GetValueInSecondSqrInchPerKilograms() => (Value_ - secondsqrinchperkilogram_.Offset) / secondsqrinchperkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeSqrLengthPerMass operator+(TimeSqrLengthPerMass o1, TimeSqrLengthPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ + o2.Value_);
  public static TimeSqrLengthPerMass operator-(TimeSqrLengthPerMass o1, TimeSqrLengthPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrLengthPerMass o1, TimeSqrLengthPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(TimeSqrLengthPerMass o1, LengthPerTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthPerTimeCub o1, TimeSqrLengthPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator/(TimeSqrLengthPerMass o1, TimeCubLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubLength o1, TimeSqrLengthPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeSqrLengthPerMass o1, Force o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(Force o1, TimeSqrLengthPerMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(TimeSqrLengthPerMass o1, LengthSqrPerMassTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrPerMassTime o1, TimeSqrLengthPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(TimeSqrLengthPerMass o1, LengthSqrTimePerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrTimePerMass o1, TimeSqrLengthPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(TimeSqrLengthPerMass o1, QDose o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(QDose o1, TimeSqrLengthPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeSqrLengthPerMass o1, LengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrTimeSqr o1, TimeSqrLengthPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeSqrLengthPerMass o1, LengthSqrMassPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrMassPerTime o1, TimeSqrLengthPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeSqrLengthPerMass o1, LengthSqrMassTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrMassTime o1, TimeSqrLengthPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerMass o1, TimeSqrLengthPerMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubPerTime o1, TimeSqrLengthPerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubTime o1, TimeSqrLengthPerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeSqrLengthPerMass o1, PerTimeSqrLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerTimeSqrLengthCub o1, TimeSqrLengthPerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeSqrLengthPerMass o1, MassPerTimeLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(MassPerTimeLengthCub o1, TimeSqrLengthPerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(TimeSqrLengthPerMass o1, MassTimePerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(MassTimePerLengthCub o1, TimeSqrLengthPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeSqrLengthPerMass o1, TimeSqrPerMassLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeSqrPerMassLengthSqr o1, TimeSqrLengthPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimeSqrLengthPerMass o1, PerLengthSqrTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerLengthSqrTimeCub o1, TimeSqrLengthPerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTime operator/(TimeSqrLengthPerMass o1, TimeCubPerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimeCubPerLengthSqr o1, TimeSqrLengthPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeSqrLengthPerMass o1, MassPerLengthSqrTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerLengthSqrTimeSqr o1, TimeSqrLengthPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(TimeSqrLengthPerMass o1, TimeCubPerLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeCubPerLengthMass o1, TimeSqrLengthPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrLengthPerMass o1, MassPerLengthTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerLengthTimeCub o1, TimeSqrLengthPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrLengthPerMass o1, TimeCubLengthPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubLengthPerMass o1, TimeSqrLengthPerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(TimeSqrLengthPerMass o1, LengthMassPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthMassPerTimeCub o1, TimeSqrLengthPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeSqrLengthPerMass o1, LengthSqrTimeSqrPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrTimeSqrPerMass o1, TimeSqrLengthPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(TimeSqrLengthPerMass o1, LengthSqrPerTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrPerTimeCub o1, TimeSqrLengthPerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator/(TimeSqrLengthPerMass o1, TimeCubLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeCubLengthSqr o1, TimeSqrLengthPerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeSqrLengthPerMass o1, LengthSqrMassPerTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrMassPerTimeSqr o1, TimeSqrLengthPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubPerMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerMassTime o1, TimeSqrLengthPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTimePerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubTimePerMass o1, TimeSqrLengthPerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubTimeSqr o1, TimeSqrLengthPerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrLengthPerMass o1, PerLengthCubTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerLengthCubTimeCub o1, TimeSqrLengthPerMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(TimeSqrLengthPerMass o1, MassPerTimeSqrLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerTimeSqrLengthCub o1, TimeSqrLengthPerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator/(TimeSqrLengthPerMass o1, TimeCubPerMassLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeCubPerMassLengthSqr o1, TimeSqrLengthPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrLengthPerMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerLengthSqrTimeCub o1, TimeSqrLengthPerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrLengthPerMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubLengthSqrPerMass o1, TimeSqrLengthPerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(TimeSqrLengthPerMass o1, LengthSqrMassPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrLengthPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTimeSqrPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimeSqrPerMass o1, TimeSqrLengthPerMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubTimeCub o1, TimeSqrLengthPerMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimeSqrLengthPerMass o1, MassPerLengthCubTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassPerLengthCubTimeCub o1, TimeSqrLengthPerMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(TimeSqrLengthPerMass o1, LengthCubTimeCubPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeCubPerMass o1, TimeSqrLengthPerMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrLengthPerMass is outside its bounds.");
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
    