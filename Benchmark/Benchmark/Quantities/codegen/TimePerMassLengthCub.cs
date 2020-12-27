
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimePerMassLengthCub : Quantity, IEquatable<TimePerMassLengthCub>, IComparable
  {  
    internal TimePerMassLengthCub(double value) : base(value, 2)
    {
      TimePerMassLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimePerMassLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimePerMassLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimePerMassLengthCub(TimePerMassLengthCub other) : base(other)
    {
      TimePerMassLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerMassLengthCub"))
    {
      switch(FakeDatabase.Units["TimePerMassLengthCub"])
      {
        case "secondperkilogramcentimetercub": displayUnit_ = secondperkilogramcentimetercub_; break;
        case "secondperkilogrammillimetercub": displayUnit_ = secondperkilogrammillimetercub_; break;
        case "secondperkilogrammetercub": displayUnit_ = secondperkilogrammetercub_; break;
        case "secondperkilograminchcub": displayUnit_ = secondperkilograminchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondperkilogramcentimetercub_ = new Unit_("SecondPerKilogramCentimeterCub", "s/kg cm�", 1.0, 0);
  private static Unit_ secondperkilogrammillimetercub_ = new Unit_("SecondPerKilogramMillimeterCub", "s/kg mm�", 999.9999999999998, 0);
  private static Unit_ secondperkilogrammetercub_ = new Unit_("SecondPerKilogramMeterCub", "s/kg m�", 1e-06, 0);
  private static Unit_ secondperkilograminchcub_ = new Unit_("SecondPerKilogramInchCub", "s/kg in�", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondperkilogramcentimetercub_;
  private static Unit_ displayUnit_ = secondperkilogramcentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimePerMassLengthCub other && Equals(other);
  public bool Equals(TimePerMassLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimePerMassLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimePerMassLengthCub other)) throw new ArgumentException("Object is not a TimePerMassLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimePerMassLengthCub l1, TimePerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimePerMassLengthCub FromSecondPerKilogramCentimeterCubs(double value, double minValue, double maxValue) => new TimePerMassLengthCub((value + secondperkilogramcentimetercub_.Offset) * secondperkilogramcentimetercub_.Factor, minValue * secondperkilogramcentimetercub_.Factor, maxValue * secondperkilogramcentimetercub_.Factor);
  public static TimePerMassLengthCub FromSecondPerKilogramCentimeterCubs(double value) => new TimePerMassLengthCub((value + secondperkilogramcentimetercub_.Offset) * secondperkilogramcentimetercub_.Factor);
  public double GetValueInSecondPerKilogramCentimeterCubs() => (Value_ - secondperkilogramcentimetercub_.Offset) / secondperkilogramcentimetercub_.Factor;
  public static TimePerMassLengthCub FromSecondPerKilogramMillimeterCubs(double value, double minValue, double maxValue) => new TimePerMassLengthCub((value + secondperkilogrammillimetercub_.Offset) * secondperkilogrammillimetercub_.Factor, minValue * secondperkilogrammillimetercub_.Factor, maxValue * secondperkilogrammillimetercub_.Factor);
  public static TimePerMassLengthCub FromSecondPerKilogramMillimeterCubs(double value) => new TimePerMassLengthCub((value + secondperkilogrammillimetercub_.Offset) * secondperkilogrammillimetercub_.Factor);
  public double GetValueInSecondPerKilogramMillimeterCubs() => (Value_ - secondperkilogrammillimetercub_.Offset) / secondperkilogrammillimetercub_.Factor;
  public static TimePerMassLengthCub FromSecondPerKilogramMeterCubs(double value, double minValue, double maxValue) => new TimePerMassLengthCub((value + secondperkilogrammetercub_.Offset) * secondperkilogrammetercub_.Factor, minValue * secondperkilogrammetercub_.Factor, maxValue * secondperkilogrammetercub_.Factor);
  public static TimePerMassLengthCub FromSecondPerKilogramMeterCubs(double value) => new TimePerMassLengthCub((value + secondperkilogrammetercub_.Offset) * secondperkilogrammetercub_.Factor);
  public double GetValueInSecondPerKilogramMeterCubs() => (Value_ - secondperkilogrammetercub_.Offset) / secondperkilogrammetercub_.Factor;
  public static TimePerMassLengthCub FromSecondPerKilogramInchCubs(double value, double minValue, double maxValue) => new TimePerMassLengthCub((value + secondperkilograminchcub_.Offset) * secondperkilograminchcub_.Factor, minValue * secondperkilograminchcub_.Factor, maxValue * secondperkilograminchcub_.Factor);
  public static TimePerMassLengthCub FromSecondPerKilogramInchCubs(double value) => new TimePerMassLengthCub((value + secondperkilograminchcub_.Offset) * secondperkilograminchcub_.Factor);
  public double GetValueInSecondPerKilogramInchCubs() => (Value_ - secondperkilograminchcub_.Offset) / secondperkilograminchcub_.Factor;

#endregion

#region arithmetic
  public static TimePerMassLengthCub operator+(TimePerMassLengthCub o1, TimePerMassLengthCub o2) => new TimePerMassLengthCub(o1.Value_ + o2.Value_);
  public static TimePerMassLengthCub operator-(TimePerMassLengthCub o1, TimePerMassLengthCub o2) => new TimePerMassLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimePerMassLengthCub o1, TimePerMassLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimePerMassLengthCub o1, PerTimeSqrLengthCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(PerTimeSqrLengthCub o1, TimePerMassLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimePerMassLengthCub o1, TimeSqrPerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrPerLengthCub o1, TimePerMassLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(TimePerMassLengthCub o1, PerMassLengthSqrTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerMassLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimePerMassLengthCub o1, TimeSqrPerMassLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrPerMassLengthSqr o1, TimePerMassLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubPerLengthSqr o1, TimePerMassLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubPerLengthMass o1, TimePerMassLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(TimePerMassLengthCub o1, LengthMassPerTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(LengthMassPerTimeCub o1, TimePerMassLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(TimePerMassLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(LengthSqrPerTimeCub o1, TimePerMassLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(TimePerMassLengthCub o1, LengthSqrMassPerTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrMassPerTimeSqr o1, TimePerMassLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(TimePerMassLengthCub o1, LengthSqrTimeSqrMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(LengthSqrTimeSqrMass o1, TimePerMassLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(TimePerMassLengthCub o1, LengthCubPerTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubPerTimeSqr o1, TimePerMassLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimePerMassLengthCub o1, LengthCubTimeSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthCubTimeSqr o1, TimePerMassLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimePerMassLengthCub o1, LengthCubMassPerTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubMassPerTime o1, TimePerMassLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(TimePerMassLengthCub o1, LengthCubMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthCubMassTime o1, TimePerMassLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(TimePerMassLengthCub o1, PerMassTimeSqrLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerMassLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimePerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrPerMassLengthCub o1, TimePerMassLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubPerLengthCub o1, TimePerMassLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubPerMassLengthSqr o1, TimePerMassLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(TimePerMassLengthCub o1, LengthSqrMassPerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthSqrMassPerTimeCub o1, TimePerMassLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(TimePerMassLengthCub o1, LengthCubPerTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthCubPerTimeCub o1, TimePerMassLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimePerMassLengthCub o1, LengthCubMassPerTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubMassPerTimeSqr o1, TimePerMassLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(TimePerMassLengthCub o1, LengthCubTimeSqrMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthCubTimeSqrMass o1, TimePerMassLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(TimePerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubPerMassLengthCub o1, TimePerMassLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(TimePerMassLengthCub o1, LengthCubMassPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthCubMassPerTimeCub o1, TimePerMassLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimePerMassLengthCub is outside its bounds.");
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
    