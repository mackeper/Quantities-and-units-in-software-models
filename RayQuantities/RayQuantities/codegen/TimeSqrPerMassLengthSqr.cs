
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerMassLengthSqr : Quantity, IEquatable<TimeSqrPerMassLengthSqr>, IComparable
  {  
    internal TimeSqrPerMassLengthSqr(double value) : base(value, 2)
    {
      TimeSqrPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerMassLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerMassLengthSqr(TimeSqrPerMassLengthSqr other) : base(other)
    {
      TimeSqrPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerMassLengthSqr"))
    {
      switch(FakeDatabase.Units["TimeSqrPerMassLengthSqr"])
      {
        case "secondsqrperkilogramcentimetersqr": displayUnit_ = secondsqrperkilogramcentimetersqr_; break;
        case "secondsqrperkilogrammillimetersqr": displayUnit_ = secondsqrperkilogrammillimetersqr_; break;
        case "secondsqrperkilogrammetersqr": displayUnit_ = secondsqrperkilogrammetersqr_; break;
        case "secondsqrperkilograminchsqr": displayUnit_ = secondsqrperkilograminchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrperkilogramcentimetersqr_ = new Unit_("SecondSqrPerKilogramCentimeterSqr", "s²/kg cm²", 1.0, 0);
  private static Unit_ secondsqrperkilogrammillimetersqr_ = new Unit_("SecondSqrPerKilogramMillimeterSqr", "s²/kg mm²", 99.99999999999999, 0);
  private static Unit_ secondsqrperkilogrammetersqr_ = new Unit_("SecondSqrPerKilogramMeterSqr", "s²/kg m²", 0.0001, 0);
  private static Unit_ secondsqrperkilograminchsqr_ = new Unit_("SecondSqrPerKilogramInchSqr", "s²/kg in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondsqrperkilogramcentimetersqr_;
  private static Unit_ displayUnit_ = secondsqrperkilogramcentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerMassLengthSqr other && Equals(other);
  public bool Equals(TimeSqrPerMassLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerMassLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerMassLengthSqr other)) throw new ArgumentException("Object is not a TimeSqrPerMassLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerMassLengthSqr l1, TimeSqrPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramCentimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogramcentimetersqr_.Offset) * secondsqrperkilogramcentimetersqr_.Factor, minValue * secondsqrperkilogramcentimetersqr_.Factor, maxValue * secondsqrperkilogramcentimetersqr_.Factor);
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramCentimeterSqrs(double value) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogramcentimetersqr_.Offset) * secondsqrperkilogramcentimetersqr_.Factor);
  public double GetValueInSecondSqrPerKilogramCentimeterSqrs() => (Value_ - secondsqrperkilogramcentimetersqr_.Offset) / secondsqrperkilogramcentimetersqr_.Factor;
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramMillimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogrammillimetersqr_.Offset) * secondsqrperkilogrammillimetersqr_.Factor, minValue * secondsqrperkilogrammillimetersqr_.Factor, maxValue * secondsqrperkilogrammillimetersqr_.Factor);
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramMillimeterSqrs(double value) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogrammillimetersqr_.Offset) * secondsqrperkilogrammillimetersqr_.Factor);
  public double GetValueInSecondSqrPerKilogramMillimeterSqrs() => (Value_ - secondsqrperkilogrammillimetersqr_.Offset) / secondsqrperkilogrammillimetersqr_.Factor;
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramMeterSqrs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogrammetersqr_.Offset) * secondsqrperkilogrammetersqr_.Factor, minValue * secondsqrperkilogrammetersqr_.Factor, maxValue * secondsqrperkilogrammetersqr_.Factor);
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramMeterSqrs(double value) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilogrammetersqr_.Offset) * secondsqrperkilogrammetersqr_.Factor);
  public double GetValueInSecondSqrPerKilogramMeterSqrs() => (Value_ - secondsqrperkilogrammetersqr_.Offset) / secondsqrperkilogrammetersqr_.Factor;
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramInchSqrs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilograminchsqr_.Offset) * secondsqrperkilograminchsqr_.Factor, minValue * secondsqrperkilograminchsqr_.Factor, maxValue * secondsqrperkilograminchsqr_.Factor);
  public static TimeSqrPerMassLengthSqr FromSecondSqrPerKilogramInchSqrs(double value) => new TimeSqrPerMassLengthSqr((value + secondsqrperkilograminchsqr_.Offset) * secondsqrperkilograminchsqr_.Factor);
  public double GetValueInSecondSqrPerKilogramInchSqrs() => (Value_ - secondsqrperkilograminchsqr_.Offset) / secondsqrperkilograminchsqr_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerMassLengthSqr operator+(TimeSqrPerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ + o2.Value_);
  public static TimeSqrPerMassLengthSqr operator-(TimeSqrPerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubPerLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerLengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubPerLengthMass o1, TimeSqrPerMassLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(TimeSqrPerMassLengthSqr o1, MassPerLengthTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(MassPerLengthTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(TimeSqrPerMassLengthSqr o1, TimeCubLengthPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeCubLengthPerMass o1, TimeSqrPerMassLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerMassLengthSqr o1, LengthMassPerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthMassPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerMassLengthSqr o1, LengthSqrPerTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerMassLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(TimeSqrPerMassLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimeSqrPerMassLengthSqr o1, LengthCubMassPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubMassPerTime o1, TimeSqrPerMassLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(TimeSqrPerMassLengthSqr o1, LengthCubMassTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubMassTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerMassLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerMassLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubPerLengthCub o1, TimeSqrPerMassLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrPerMassLengthSqr o1, LengthSqrMassPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(TimeSqrPerMassLengthSqr o1, LengthCubPerTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static Length operator*(TimeSqrPerMassLengthSqr o1, LengthCubMassPerTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static Speed operator/(TimeSqrPerMassLengthSqr o1, TimeCubPerMassLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeCubPerMassLengthCub o1, TimeSqrPerMassLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static Speed operator*(TimeSqrPerMassLengthSqr o1, LengthCubMassPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubMassPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerMassLengthSqr is outside its bounds.");
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
    