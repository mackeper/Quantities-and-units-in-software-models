
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrMassPerLengthCub : Quantity, IEquatable<TimeSqrMassPerLengthCub>, IComparable
  {  
    internal TimeSqrMassPerLengthCub(double value) : base(value, 2)
    {
      TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrMassPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrMassPerLengthCub(TimeSqrMassPerLengthCub other) : base(other)
    {
      TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrMassPerLengthCub"))
    {
      switch(FakeDatabase.Units["TimeSqrMassPerLengthCub"])
      {
        case "secondsqrkilogrampercentimetercub": displayUnit_ = secondsqrkilogrampercentimetercub_; break;
        case "secondsqrkilogrampermillimetercub": displayUnit_ = secondsqrkilogrampermillimetercub_; break;
        case "secondsqrkilogrampermetercub": displayUnit_ = secondsqrkilogrampermetercub_; break;
        case "secondsqrkilogramperinchcub": displayUnit_ = secondsqrkilogramperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrkilogrampercentimetercub_ = new Unit_("SecondSqrKilogramPerCentimeterCub", "s² kg/cm³", 1.0, 0);
  private static Unit_ secondsqrkilogrampermillimetercub_ = new Unit_("SecondSqrKilogramPerMillimeterCub", "s² kg/mm³", 999.9999999999998, 0);
  private static Unit_ secondsqrkilogrampermetercub_ = new Unit_("SecondSqrKilogramPerMeterCub", "s² kg/m³", 1e-06, 0);
  private static Unit_ secondsqrkilogramperinchcub_ = new Unit_("SecondSqrKilogramPerInchCub", "s² kg/in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondsqrkilogrampercentimetercub_;
  private static Unit_ displayUnit_ = secondsqrkilogrampercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrMassPerLengthCub other && Equals(other);
  public bool Equals(TimeSqrMassPerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrMassPerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrMassPerLengthCub other)) throw new ArgumentException("Object is not a TimeSqrMassPerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampercentimetercub_.Offset) * secondsqrkilogrampercentimetercub_.Factor, minValue * secondsqrkilogrampercentimetercub_.Factor, maxValue * secondsqrkilogrampercentimetercub_.Factor);
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerCentimeterCubs(double value) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampercentimetercub_.Offset) * secondsqrkilogrampercentimetercub_.Factor);
  public double GetValueInSecondSqrKilogramPerCentimeterCubs() => (Value_ - secondsqrkilogrampercentimetercub_.Offset) / secondsqrkilogrampercentimetercub_.Factor;
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampermillimetercub_.Offset) * secondsqrkilogrampermillimetercub_.Factor, minValue * secondsqrkilogrampermillimetercub_.Factor, maxValue * secondsqrkilogrampermillimetercub_.Factor);
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMillimeterCubs(double value) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampermillimetercub_.Offset) * secondsqrkilogrampermillimetercub_.Factor);
  public double GetValueInSecondSqrKilogramPerMillimeterCubs() => (Value_ - secondsqrkilogrampermillimetercub_.Offset) / secondsqrkilogrampermillimetercub_.Factor;
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampermetercub_.Offset) * secondsqrkilogrampermetercub_.Factor, minValue * secondsqrkilogrampermetercub_.Factor, maxValue * secondsqrkilogrampermetercub_.Factor);
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMeterCubs(double value) => new TimeSqrMassPerLengthCub((value + secondsqrkilogrampermetercub_.Offset) * secondsqrkilogrampermetercub_.Factor);
  public double GetValueInSecondSqrKilogramPerMeterCubs() => (Value_ - secondsqrkilogrampermetercub_.Offset) / secondsqrkilogrampermetercub_.Factor;
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerInchCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub((value + secondsqrkilogramperinchcub_.Offset) * secondsqrkilogramperinchcub_.Factor, minValue * secondsqrkilogramperinchcub_.Factor, maxValue * secondsqrkilogramperinchcub_.Factor);
  public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerInchCubs(double value) => new TimeSqrMassPerLengthCub((value + secondsqrkilogramperinchcub_.Offset) * secondsqrkilogramperinchcub_.Factor);
  public double GetValueInSecondSqrKilogramPerInchCubs() => (Value_ - secondsqrkilogramperinchcub_.Offset) / secondsqrkilogramperinchcub_.Factor;

#endregion

#region arithmetic
  public static TimeSqrMassPerLengthCub operator+(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ + o2.Value_);
  public static TimeSqrMassPerLengthCub operator-(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrMassPerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubMassPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerMassTimeSqr o1, TimeSqrMassPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(TimeSqrMassPerLengthCub o1, LengthCubPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubPerTimeCub o1, TimeSqrMassPerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubPerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrMassPerLengthCub is outside its bounds.");
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
    