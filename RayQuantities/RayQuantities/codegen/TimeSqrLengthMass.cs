
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrLengthMass : Quantity, IEquatable<TimeSqrLengthMass>, IComparable
  {  
    internal TimeSqrLengthMass(double value) : base(value, 2)
    {
      TimeSqrLengthMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrLengthMass(TimeSqrLengthMass other) : base(other)
    {
      TimeSqrLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrLengthMass"))
    {
      switch(FakeDatabase.Units["TimeSqrLengthMass"])
      {
        case "secondsqrcentimeterkilogram": displayUnit_ = secondsqrcentimeterkilogram_; break;
        case "secondsqrmillimeterkilogram": displayUnit_ = secondsqrmillimeterkilogram_; break;
        case "secondsqrmeterkilogram": displayUnit_ = secondsqrmeterkilogram_; break;
        case "secondsqrinchkilogram": displayUnit_ = secondsqrinchkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrcentimeterkilogram_ = new Unit_("SecondSqrCentimeterKilogram", "s� cm kg", 1, 0);
  private static Unit_ secondsqrmillimeterkilogram_ = new Unit_("SecondSqrMillimeterKilogram", "s� mm kg", 0.1, 0);
  private static Unit_ secondsqrmeterkilogram_ = new Unit_("SecondSqrMeterKilogram", "s� m kg", 100, 0);
  private static Unit_ secondsqrinchkilogram_ = new Unit_("SecondSqrInchKilogram", "s� in kg", 2.56, 0);
  private static Unit_ platformUnit_ = secondsqrcentimeterkilogram_;
  private static Unit_ displayUnit_ = secondsqrcentimeterkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrLengthMass other && Equals(other);
  public bool Equals(TimeSqrLengthMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrLengthMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrLengthMass other)) throw new ArgumentException("Object is not a TimeSqrLengthMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => !(l1 == l2);
  public static bool operator <(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrLengthMass l1, TimeSqrLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrLengthMass FromSecondSqrCentimeterKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthMass((value + secondsqrcentimeterkilogram_.Offset) * secondsqrcentimeterkilogram_.Factor, minValue * secondsqrcentimeterkilogram_.Factor, maxValue * secondsqrcentimeterkilogram_.Factor);
  public static TimeSqrLengthMass FromSecondSqrCentimeterKilograms(double value) => new TimeSqrLengthMass((value + secondsqrcentimeterkilogram_.Offset) * secondsqrcentimeterkilogram_.Factor);
  public double GetValueInSecondSqrCentimeterKilograms() => (Value_ - secondsqrcentimeterkilogram_.Offset) / secondsqrcentimeterkilogram_.Factor;
  public static TimeSqrLengthMass FromSecondSqrMillimeterKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthMass((value + secondsqrmillimeterkilogram_.Offset) * secondsqrmillimeterkilogram_.Factor, minValue * secondsqrmillimeterkilogram_.Factor, maxValue * secondsqrmillimeterkilogram_.Factor);
  public static TimeSqrLengthMass FromSecondSqrMillimeterKilograms(double value) => new TimeSqrLengthMass((value + secondsqrmillimeterkilogram_.Offset) * secondsqrmillimeterkilogram_.Factor);
  public double GetValueInSecondSqrMillimeterKilograms() => (Value_ - secondsqrmillimeterkilogram_.Offset) / secondsqrmillimeterkilogram_.Factor;
  public static TimeSqrLengthMass FromSecondSqrMeterKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthMass((value + secondsqrmeterkilogram_.Offset) * secondsqrmeterkilogram_.Factor, minValue * secondsqrmeterkilogram_.Factor, maxValue * secondsqrmeterkilogram_.Factor);
  public static TimeSqrLengthMass FromSecondSqrMeterKilograms(double value) => new TimeSqrLengthMass((value + secondsqrmeterkilogram_.Offset) * secondsqrmeterkilogram_.Factor);
  public double GetValueInSecondSqrMeterKilograms() => (Value_ - secondsqrmeterkilogram_.Offset) / secondsqrmeterkilogram_.Factor;
  public static TimeSqrLengthMass FromSecondSqrInchKilograms(double value, double minValue, double maxValue) => new TimeSqrLengthMass((value + secondsqrinchkilogram_.Offset) * secondsqrinchkilogram_.Factor, minValue * secondsqrinchkilogram_.Factor, maxValue * secondsqrinchkilogram_.Factor);
  public static TimeSqrLengthMass FromSecondSqrInchKilograms(double value) => new TimeSqrLengthMass((value + secondsqrinchkilogram_.Offset) * secondsqrinchkilogram_.Factor);
  public double GetValueInSecondSqrInchKilograms() => (Value_ - secondsqrinchkilogram_.Offset) / secondsqrinchkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeSqrLengthMass operator+(TimeSqrLengthMass o1, TimeSqrLengthMass o2) => new TimeSqrLengthMass(o1.Value_ + o2.Value_);
  public static TimeSqrLengthMass operator-(TimeSqrLengthMass o1, TimeSqrLengthMass o2) => new TimeSqrLengthMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrLengthMass o1, TimeSqrLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeSqrLengthMass o1, LengthSqrPerMassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrPerMassTime o1, TimeSqrLengthMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeSqrLengthMass o1, LengthSqrTimePerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrTimePerMass o1, TimeSqrLengthMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator*(TimeSqrLengthMass o1, QDose o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(QDose o1, TimeSqrLengthMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeSqrLengthMass o1, LengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrTimeSqr o1, TimeSqrLengthMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(TimeSqrLengthMass o1, LengthSqrMassPerTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrMassPerTime o1, TimeSqrLengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(TimeSqrLengthMass o1, LengthSqrMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrMassTime o1, TimeSqrLengthMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubPerTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerTime o1, TimeSqrLengthMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubTime o1, TimeSqrLengthMass o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubMass o1, TimeSqrLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeSqrLengthMass o1, PerMassTimeLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerMassTimeLengthCub o1, TimeSqrLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(TimeSqrLengthMass o1, TimePerMassLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimePerMassLengthCub o1, TimeSqrLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeSqrLengthMass o1, PerTimeSqrLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerTimeSqrLengthCub o1, TimeSqrLengthMass o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(TimeSqrLengthMass o1, PerMassLengthSqrTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassLengthSqrTimeSqr o1, TimeSqrLengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(TimeSqrLengthMass o1, PerLengthSqrTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerLengthSqrTimeCub o1, TimeSqrLengthMass o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator/(TimeSqrLengthMass o1, TimeCubPerLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimeCubPerLengthSqr o1, TimeSqrLengthMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(TimeSqrLengthMass o1, TimeSqrMassPerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeSqrMassPerLengthSqr o1, TimeSqrLengthMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrLengthMass o1, PerLengthMassTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthMassTimeCub o1, TimeSqrLengthMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(TimeSqrLengthMass o1, TimeCubMassPerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeCubMassPerLength o1, TimeSqrLengthMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(TimeSqrLengthMass o1, LengthPerMassTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthPerMassTimeCub o1, TimeSqrLengthMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrLengthMass o1, TimeCubLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubLengthMass o1, TimeSqrLengthMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeSqrLengthMass o1, LengthSqrPerMassTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrPerMassTimeSqr o1, TimeSqrLengthMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator*(TimeSqrLengthMass o1, LengthSqrPerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrPerTimeCub o1, TimeSqrLengthMass o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator/(TimeSqrLengthMass o1, TimeCubLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeCubLengthSqr o1, TimeSqrLengthMass o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(TimeSqrLengthMass o1, LengthSqrTimeSqrMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrTimeSqrMass o1, TimeSqrLengthMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubTimeSqr o1, TimeSqrLengthMass o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubMassPerTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubMassPerTime o1, TimeSqrLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubMassTime o1, TimeSqrLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeSqrLengthMass o1, PerMassTimeSqrLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassTimeSqrLengthCub o1, TimeSqrLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimeSqrLengthMass o1, PerLengthCubTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(PerLengthCubTimeCub o1, TimeSqrLengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrLengthMass o1, PerMassLengthSqrTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassLengthSqrTimeCub o1, TimeSqrLengthMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator/(TimeSqrLengthMass o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeCubMassPerLengthSqr o1, TimeSqrLengthMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(TimeSqrLengthMass o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrLengthMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrLengthMass o1, TimeCubLengthSqrMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubLengthSqrMass o1, TimeSqrLengthMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimeSqrLengthMass o1, LengthCubTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTimeCub o1, TimeSqrLengthMass o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(TimeSqrLengthMass o1, LengthCubTimeSqrMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimeSqrMass o1, TimeSqrLengthMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimeSqrLengthMass o1, PerMassLengthCubTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerMassLengthCubTimeCub o1, TimeSqrLengthMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(TimeSqrLengthMass o1, LengthCubTimeCubMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeCubMass o1, TimeSqrLengthMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrLengthMass is outside its bounds.");
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
    