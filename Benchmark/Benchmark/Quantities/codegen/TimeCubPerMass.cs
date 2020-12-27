
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubPerMass : Quantity, IEquatable<TimeCubPerMass>, IComparable
  {  
    internal TimeCubPerMass(double value) : base(value, 2)
    {
      TimeCubPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubPerMass(TimeCubPerMass other) : base(other)
    {
      TimeCubPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerMass"))
    {
      switch(FakeDatabase.Units["TimeCubPerMass"])
      {
        case "secondcubperkilogram": displayUnit_ = secondcubperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubperkilogram_ = new Unit_("SecondCubPerKilogram", "s³/kg", 1.0, 0);
  private static Unit_ platformUnit_ = secondcubperkilogram_;
  private static Unit_ displayUnit_ = secondcubperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubPerMass other && Equals(other);
  public bool Equals(TimeCubPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubPerMass other)) throw new ArgumentException("Object is not a TimeCubPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubPerMass l1, TimeCubPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubPerMass l1, TimeCubPerMass l2) => !(l1 == l2);
  public static bool operator <(TimeCubPerMass l1, TimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubPerMass l1, TimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubPerMass l1, TimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubPerMass l1, TimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubPerMass FromSecondCubPerKilograms(double value, double minValue, double maxValue) => new TimeCubPerMass((value + secondcubperkilogram_.Offset) * secondcubperkilogram_.Factor, minValue * secondcubperkilogram_.Factor, maxValue * secondcubperkilogram_.Factor);
  public static TimeCubPerMass FromSecondCubPerKilograms(double value) => new TimeCubPerMass((value + secondcubperkilogram_.Offset) * secondcubperkilogram_.Factor);
  public double GetValueInSecondCubPerKilograms() => (Value_ - secondcubperkilogram_.Offset) / secondcubperkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeCubPerMass operator+(TimeCubPerMass o1, TimeCubPerMass o2) => new TimeCubPerMass(o1.Value_ + o2.Value_);
  public static TimeCubPerMass operator-(TimeCubPerMass o1, TimeCubPerMass o2) => new TimeCubPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubPerMass o1, TimeCubPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeCubPerMass o1, MassPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(MassPerTimeCub o1, TimeCubPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(TimeCubPerMass o1, TimeSqrLengthPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(TimeSqrLengthPerMass o1, TimeCubPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeCubPerMass o1, LengthPerTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthPerTimeCub o1, TimeCubPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeCubPerMass o1, TimeCubLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubLength o1, TimeCubPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeCubPerMass o1, Force o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(Force o1, TimeCubPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeCubPerMass o1, LengthSqrTimePerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthSqrTimePerMass o1, TimeCubPerMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(TimeCubPerMass o1, QDose o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(QDose o1, TimeCubPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeCubPerMass o1, LengthSqrTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthSqrTimeSqr o1, TimeCubPerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeCubPerMass o1, LengthSqrMassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthSqrMassPerTime o1, TimeCubPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(TimeCubPerMass o1, LengthCubPerMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthCubPerMass o1, TimeCubPerMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(TimeCubPerMass o1, LengthCubPerTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthCubPerTime o1, TimeCubPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator/(TimeCubPerMass o1, LengthCubTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthCubTime o1, TimeCubPerMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeCubPerMass o1, LengthCubMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthCubMass o1, TimeCubPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(TimeCubPerMass o1, TimePerMassLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(TimePerMassLengthCub o1, TimeCubPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(TimeCubPerMass o1, PerTimeSqrLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(PerTimeSqrLengthCub o1, TimeCubPerMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimePerMass operator/(TimeCubPerMass o1, TimeSqrPerLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(TimeSqrPerLengthCub o1, TimeCubPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(TimeCubPerMass o1, MassPerTimeLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(MassPerTimeLengthCub o1, TimeCubPerMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(TimeCubPerMass o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeCubPerMass o1, PerLengthSqrTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthSqrTimeCub o1, TimeCubPerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeCubPerMass o1, TimeCubPerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeCubPerLengthSqr o1, TimeCubPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeCubPerMass o1, MassPerLengthSqrTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(MassPerLengthSqrTimeSqr o1, TimeCubPerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCubPerMass o1, TimeCubPerLengthMass o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubPerLengthMass o1, TimeCubPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeCubPerMass o1, MassPerLengthTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerLengthTimeCub o1, TimeCubPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCubPerMass o1, TimeCubLengthPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(TimeCubLengthPerMass o1, TimeCubPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCubPerMass o1, LengthMassPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthMassPerTimeCub o1, TimeCubPerMass o2) => new Length(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeCubPerMass o1, LengthSqrTimeSqrPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubPerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeCubPerMass o1, LengthSqrPerTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthSqrPerTimeCub o1, TimeCubPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeCubPerMass o1, TimeCubLengthSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(TimeCubLengthSqr o1, TimeCubPerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(TimeCubPerMass o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(TimeCubPerMass o1, LengthCubTimePerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubTimePerMass o1, TimeCubPerMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(TimeCubPerMass o1, LengthCubPerTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthCubPerTimeSqr o1, TimeCubPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthCub operator/(TimeCubPerMass o1, LengthCubTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthCubTimeSqr o1, TimeCubPerMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(TimeCubPerMass o1, LengthCubMassPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubMassPerTime o1, TimeCubPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(TimeCubPerMass o1, TimeSqrPerMassLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(TimeSqrPerMassLengthCub o1, TimeCubPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeCubPerMass o1, PerLengthCubTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerLengthCubTimeCub o1, TimeCubPerMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator/(TimeCubPerMass o1, TimeCubPerLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(TimeCubPerLengthCub o1, TimeCubPerMass o2) => new Density(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(TimeCubPerMass o1, MassPerTimeSqrLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(MassPerTimeSqrLengthCub o1, TimeCubPerMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static Area operator/(TimeCubPerMass o1, TimeCubPerMassLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeCubPerMassLengthSqr o1, TimeCubPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeCubPerMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerLengthSqrTimeCub o1, TimeCubPerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubPerMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeCubLengthSqrPerMass o1, TimeCubPerMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeCubPerMass o1, LengthSqrMassPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrMassPerTimeCub o1, TimeCubPerMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(TimeCubPerMass o1, LengthCubTimeSqrPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubTimeSqrPerMass o1, TimeCubPerMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(TimeCubPerMass o1, LengthCubPerTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthCubPerTimeCub o1, TimeCubPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeCubPerMass o1, LengthCubTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthCubTimeCub o1, TimeCubPerMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeCubPerMass o1, LengthCubMassPerTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeCubPerMass o1, TimeCubPerMassLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeCubPerMassLengthCub o1, TimeCubPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeCubPerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(MassPerLengthCubTimeCub o1, TimeCubPerMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubTimeCubPerMass o1, TimeCubPerMass o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeCubPerMass o1, LengthCubMassPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubMassPerTimeCub o1, TimeCubPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubPerMass is outside its bounds.");
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
    