
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubMass : Quantity, IEquatable<TimeCubMass>, IComparable
  {  
    internal TimeCubMass(double value) : base(value, 2)
    {
      TimeCubMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubMass(TimeCubMass other) : base(other)
    {
      TimeCubMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubMass"))
    {
      switch(FakeDatabase.Units["TimeCubMass"])
      {
        case "secondcubkilogram": displayUnit_ = secondcubkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubkilogram_ = new Unit_("SecondCubKilogram", "s� kg", 1, 0);
  private static Unit_ platformUnit_ = secondcubkilogram_;
  private static Unit_ displayUnit_ = secondcubkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubMass other && Equals(other);
  public bool Equals(TimeCubMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubMass other)) throw new ArgumentException("Object is not a TimeCubMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubMass l1, TimeCubMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubMass l1, TimeCubMass l2) => !(l1 == l2);
  public static bool operator <(TimeCubMass l1, TimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubMass l1, TimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubMass l1, TimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubMass l1, TimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubMass FromSecondCubKilograms(double value, double minValue, double maxValue) => new TimeCubMass((value + secondcubkilogram_.Offset) * secondcubkilogram_.Factor, minValue * secondcubkilogram_.Factor, maxValue * secondcubkilogram_.Factor);
  public static TimeCubMass FromSecondCubKilograms(double value) => new TimeCubMass((value + secondcubkilogram_.Offset) * secondcubkilogram_.Factor);
  public double GetValueInSecondCubKilograms() => (Value_ - secondcubkilogram_.Offset) / secondcubkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeCubMass operator+(TimeCubMass o1, TimeCubMass o2) => new TimeCubMass(o1.Value_ + o2.Value_);
  public static TimeCubMass operator-(TimeCubMass o1, TimeCubMass o2) => new TimeCubMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubMass o1, TimeCubMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeCubMass o1, LengthPerMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthPerMassTimeSqr o1, TimeCubMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(TimeCubMass o1, LengthPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthPerTimeCub o1, TimeCubMass o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeCubMass o1, TimeCubLength o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubLength o1, TimeCubMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(TimeCubMass o1, TimeSqrLengthMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(TimeSqrLengthMass o1, TimeCubMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeCubMass o1, LengthSqrPerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthSqrPerMassTime o1, TimeCubMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeCubMass o1, QDose o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(QDose o1, TimeCubMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeCubMass o1, LengthSqrTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthSqrTimeSqr o1, TimeCubMass o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeCubMass o1, LengthSqrMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthSqrMassTime o1, TimeCubMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeCubMass o1, LengthCubPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthCubPerMass o1, TimeCubMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(TimeCubMass o1, LengthCubPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthCubPerTime o1, TimeCubMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator/(TimeCubMass o1, LengthCubTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthCubTime o1, TimeCubMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator/(TimeCubMass o1, LengthCubMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthCubMass o1, TimeCubMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(TimeCubMass o1, PerMassTimeLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(PerMassTimeLengthCub o1, TimeCubMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator*(TimeCubMass o1, PerTimeSqrLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(PerTimeSqrLengthCub o1, TimeCubMass o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubMassTime operator/(TimeCubMass o1, TimeSqrPerLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(TimeSqrPerLengthCub o1, TimeCubMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(TimeCubMass o1, MassTimePerLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassTimePerLengthCub o1, TimeCubMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeCubMass o1, PerMassLengthSqrTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerMassLengthSqrTimeSqr o1, TimeCubMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeCubMass o1, PerLengthSqrTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerLengthSqrTimeCub o1, TimeCubMass o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeCubMass o1, TimeCubPerLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeCubPerLengthSqr o1, TimeCubMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimeCubMass o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimeSqrMassPerLengthSqr o1, TimeCubMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeCubMass o1, PerLengthMassTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthMassTimeCub o1, TimeCubMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCubMass o1, TimeCubMassPerLength o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubMassPerLength o1, TimeCubMass o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCubMass o1, LengthPerMassTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthPerMassTimeCub o1, TimeCubMass o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCubMass o1, TimeCubLengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(TimeCubLengthMass o1, TimeCubMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(TimeCubMass o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthSqrPerMassTimeSqr o1, TimeCubMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(TimeCubMass o1, LengthSqrPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthSqrPerTimeCub o1, TimeCubMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeCubMass o1, TimeCubLengthSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(TimeCubLengthSqr o1, TimeCubMass o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeCubMass o1, LengthSqrTimeSqrMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrTimeSqrMass o1, TimeCubMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(TimeCubMass o1, LengthCubPerMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubPerMassTime o1, TimeCubMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassTime operator*(TimeCubMass o1, LengthCubPerTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthCubPerTimeSqr o1, TimeCubMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator/(TimeCubMass o1, LengthCubTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthCubTimeSqr o1, TimeCubMass o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(TimeCubMass o1, LengthCubMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubMassTime o1, TimeCubMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(TimeCubMass o1, PerMassTimeSqrLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(PerMassTimeSqrLengthCub o1, TimeCubMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static Density operator*(TimeCubMass o1, PerLengthCubTimeCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(PerLengthCubTimeCub o1, TimeCubMass o2) => new Density(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator/(TimeCubMass o1, TimeCubPerLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(TimeCubPerLengthCub o1, TimeCubMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator/(TimeCubMass o1, TimeSqrMassPerLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(TimeSqrMassPerLengthCub o1, TimeCubMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeCubMass o1, PerMassLengthSqrTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassLengthSqrTimeCub o1, TimeCubMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Area operator/(TimeCubMass o1, TimeCubMassPerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeCubMassPerLengthSqr o1, TimeCubMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeCubMass o1, LengthSqrPerMassTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrPerMassTimeCub o1, TimeCubMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubMass o1, TimeCubLengthSqrMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeCubLengthSqrMass o1, TimeCubMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeCubMass o1, LengthCubPerMassTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubPerMassTimeSqr o1, TimeCubMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator*(TimeCubMass o1, LengthCubPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthCubPerTimeCub o1, TimeCubMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeCubMass o1, LengthCubTimeCub o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthCubTimeCub o1, TimeCubMass o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator/(TimeCubMass o1, LengthCubTimeSqrMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubTimeSqrMass o1, TimeCubMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeCubMass o1, PerMassLengthCubTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerMassLengthCubTimeCub o1, TimeCubMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeCubMass o1, TimeCubMassPerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeCubMassPerLengthCub o1, TimeCubMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeCubMass o1, LengthCubPerMassTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubPerMassTimeCub o1, TimeCubMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeCubMass o1, LengthCubTimeCubMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubTimeCubMass o1, TimeCubMass o2) => new Volume(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubMass is outside its bounds.");
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
    