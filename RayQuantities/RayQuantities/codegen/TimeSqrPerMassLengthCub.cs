
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerMassLengthCub : Quantity, IEquatable<TimeSqrPerMassLengthCub>, IComparable
  {  
    internal TimeSqrPerMassLengthCub(double value) : base(value, 2)
    {
      TimeSqrPerMassLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerMassLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerMassLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerMassLengthCub(TimeSqrPerMassLengthCub other) : base(other)
    {
      TimeSqrPerMassLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerMassLengthCub"))
    {
      switch(FakeDatabase.Units["TimeSqrPerMassLengthCub"])
      {
        case "secondsqrperkilogramcentimetercub": displayUnit_ = secondsqrperkilogramcentimetercub_; break;
        case "secondsqrperkilogrammillimetercub": displayUnit_ = secondsqrperkilogrammillimetercub_; break;
        case "secondsqrperkilogrammetercub": displayUnit_ = secondsqrperkilogrammetercub_; break;
        case "secondsqrperkilograminchcub": displayUnit_ = secondsqrperkilograminchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrperkilogramcentimetercub_ = new Unit_("SecondSqrPerKilogramCentimeterCub", "s²/kg cm³", 1.0, 0);
  private static Unit_ secondsqrperkilogrammillimetercub_ = new Unit_("SecondSqrPerKilogramMillimeterCub", "s²/kg mm³", 999.9999999999998, 0);
  private static Unit_ secondsqrperkilogrammetercub_ = new Unit_("SecondSqrPerKilogramMeterCub", "s²/kg m³", 1e-06, 0);
  private static Unit_ secondsqrperkilograminchcub_ = new Unit_("SecondSqrPerKilogramInchCub", "s²/kg in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondsqrperkilogramcentimetercub_;
  private static Unit_ displayUnit_ = secondsqrperkilogramcentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerMassLengthCub other && Equals(other);
  public bool Equals(TimeSqrPerMassLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerMassLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerMassLengthCub other)) throw new ArgumentException("Object is not a TimeSqrPerMassLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerMassLengthCub l1, TimeSqrPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramCentimeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogramcentimetercub_.Offset) * secondsqrperkilogramcentimetercub_.Factor, minValue * secondsqrperkilogramcentimetercub_.Factor, maxValue * secondsqrperkilogramcentimetercub_.Factor);
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramCentimeterCubs(double value) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogramcentimetercub_.Offset) * secondsqrperkilogramcentimetercub_.Factor);
  public double GetValueInSecondSqrPerKilogramCentimeterCubs() => (Value_ - secondsqrperkilogramcentimetercub_.Offset) / secondsqrperkilogramcentimetercub_.Factor;
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramMillimeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogrammillimetercub_.Offset) * secondsqrperkilogrammillimetercub_.Factor, minValue * secondsqrperkilogrammillimetercub_.Factor, maxValue * secondsqrperkilogrammillimetercub_.Factor);
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramMillimeterCubs(double value) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogrammillimetercub_.Offset) * secondsqrperkilogrammillimetercub_.Factor);
  public double GetValueInSecondSqrPerKilogramMillimeterCubs() => (Value_ - secondsqrperkilogrammillimetercub_.Offset) / secondsqrperkilogrammillimetercub_.Factor;
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramMeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogrammetercub_.Offset) * secondsqrperkilogrammetercub_.Factor, minValue * secondsqrperkilogrammetercub_.Factor, maxValue * secondsqrperkilogrammetercub_.Factor);
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramMeterCubs(double value) => new TimeSqrPerMassLengthCub((value + secondsqrperkilogrammetercub_.Offset) * secondsqrperkilogrammetercub_.Factor);
  public double GetValueInSecondSqrPerKilogramMeterCubs() => (Value_ - secondsqrperkilogrammetercub_.Offset) / secondsqrperkilogrammetercub_.Factor;
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramInchCubs(double value, double minValue, double maxValue) => new TimeSqrPerMassLengthCub((value + secondsqrperkilograminchcub_.Offset) * secondsqrperkilograminchcub_.Factor, minValue * secondsqrperkilograminchcub_.Factor, maxValue * secondsqrperkilograminchcub_.Factor);
  public static TimeSqrPerMassLengthCub FromSecondSqrPerKilogramInchCubs(double value) => new TimeSqrPerMassLengthCub((value + secondsqrperkilograminchcub_.Offset) * secondsqrperkilograminchcub_.Factor);
  public double GetValueInSecondSqrPerKilogramInchCubs() => (Value_ - secondsqrperkilograminchcub_.Offset) / secondsqrperkilograminchcub_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerMassLengthCub operator+(TimeSqrPerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ + o2.Value_);
  public static TimeSqrPerMassLengthCub operator-(TimeSqrPerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerMassLengthCub o1, TimeCubPerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubPerLengthCub o1, TimeSqrPerMassLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerMassLengthCub o1, TimeCubPerMassLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerMassLengthCub o1, LengthSqrMassPerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerMassLengthCub o1, LengthCubPerTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerMassLengthCub o1, LengthCubMassPerTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerMassLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrPerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrPerMassLengthCub o1, LengthCubMassPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerMassLengthCub is outside its bounds.");
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
    