
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassTimeLengthCub : Quantity, IEquatable<PerMassTimeLengthCub>, IComparable
  {  
    internal PerMassTimeLengthCub(double value) : base(value, 2)
    {
      PerMassTimeLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassTimeLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassTimeLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassTimeLengthCub(PerMassTimeLengthCub other) : base(other)
    {
      PerMassTimeLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeLengthCub"))
    {
      switch(FakeDatabase.Units["PerMassTimeLengthCub"])
      {
        case "perkilogramsecondcentimetercub": displayUnit_ = perkilogramsecondcentimetercub_; break;
        case "perkilogramsecondmillimetercub": displayUnit_ = perkilogramsecondmillimetercub_; break;
        case "perkilogramsecondmetercub": displayUnit_ = perkilogramsecondmetercub_; break;
        case "perkilogramsecondinchcub": displayUnit_ = perkilogramsecondinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramsecondcentimetercub_ = new Unit_("PerKilogramSecondCentimeterCub", "/kg s cm�", 1.0, 0);
  private static Unit_ perkilogramsecondmillimetercub_ = new Unit_("PerKilogramSecondMillimeterCub", "/kg s mm�", 999.9999999999998, 0);
  private static Unit_ perkilogramsecondmetercub_ = new Unit_("PerKilogramSecondMeterCub", "/kg s m�", 1e-06, 0);
  private static Unit_ perkilogramsecondinchcub_ = new Unit_("PerKilogramSecondInchCub", "/kg s in�", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = perkilogramsecondcentimetercub_;
  private static Unit_ displayUnit_ = perkilogramsecondcentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassTimeLengthCub other && Equals(other);
  public bool Equals(PerMassTimeLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassTimeLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassTimeLengthCub other)) throw new ArgumentException("Object is not a PerMassTimeLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => !(l1 == l2);
  public static bool operator <(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassTimeLengthCub l1, PerMassTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassTimeLengthCub FromPerKilogramSecondCentimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeLengthCub((value + perkilogramsecondcentimetercub_.Offset) * perkilogramsecondcentimetercub_.Factor, minValue * perkilogramsecondcentimetercub_.Factor, maxValue * perkilogramsecondcentimetercub_.Factor);
  public static PerMassTimeLengthCub FromPerKilogramSecondCentimeterCubs(double value) => new PerMassTimeLengthCub((value + perkilogramsecondcentimetercub_.Offset) * perkilogramsecondcentimetercub_.Factor);
  public double GetValueInPerKilogramSecondCentimeterCubs() => (Value_ - perkilogramsecondcentimetercub_.Offset) / perkilogramsecondcentimetercub_.Factor;
  public static PerMassTimeLengthCub FromPerKilogramSecondMillimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeLengthCub((value + perkilogramsecondmillimetercub_.Offset) * perkilogramsecondmillimetercub_.Factor, minValue * perkilogramsecondmillimetercub_.Factor, maxValue * perkilogramsecondmillimetercub_.Factor);
  public static PerMassTimeLengthCub FromPerKilogramSecondMillimeterCubs(double value) => new PerMassTimeLengthCub((value + perkilogramsecondmillimetercub_.Offset) * perkilogramsecondmillimetercub_.Factor);
  public double GetValueInPerKilogramSecondMillimeterCubs() => (Value_ - perkilogramsecondmillimetercub_.Offset) / perkilogramsecondmillimetercub_.Factor;
  public static PerMassTimeLengthCub FromPerKilogramSecondMeterCubs(double value, double minValue, double maxValue) => new PerMassTimeLengthCub((value + perkilogramsecondmetercub_.Offset) * perkilogramsecondmetercub_.Factor, minValue * perkilogramsecondmetercub_.Factor, maxValue * perkilogramsecondmetercub_.Factor);
  public static PerMassTimeLengthCub FromPerKilogramSecondMeterCubs(double value) => new PerMassTimeLengthCub((value + perkilogramsecondmetercub_.Offset) * perkilogramsecondmetercub_.Factor);
  public double GetValueInPerKilogramSecondMeterCubs() => (Value_ - perkilogramsecondmetercub_.Offset) / perkilogramsecondmetercub_.Factor;
  public static PerMassTimeLengthCub FromPerKilogramSecondInchCubs(double value, double minValue, double maxValue) => new PerMassTimeLengthCub((value + perkilogramsecondinchcub_.Offset) * perkilogramsecondinchcub_.Factor, minValue * perkilogramsecondinchcub_.Factor, maxValue * perkilogramsecondinchcub_.Factor);
  public static PerMassTimeLengthCub FromPerKilogramSecondInchCubs(double value) => new PerMassTimeLengthCub((value + perkilogramsecondinchcub_.Offset) * perkilogramsecondinchcub_.Factor);
  public double GetValueInPerKilogramSecondInchCubs() => (Value_ - perkilogramsecondinchcub_.Offset) / perkilogramsecondinchcub_.Factor;

#endregion

#region arithmetic
  public static PerMassTimeLengthCub operator+(PerMassTimeLengthCub o1, PerMassTimeLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ + o2.Value_);
  public static PerMassTimeLengthCub operator-(PerMassTimeLengthCub o1, PerMassTimeLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassTimeLengthCub o1, PerMassTimeLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(PerMassTimeLengthCub o1, TimePerMassLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimePerMassLengthCub o1, PerMassTimeLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerMassTimeLengthCub o1, PerTimeSqrLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerTimeSqrLengthCub o1, PerMassTimeLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeSqrPerLengthCub o1, PerMassTimeLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(PerMassTimeLengthCub o1, PerMassLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerMassLengthSqrTimeSqr o1, PerMassTimeLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerMassLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeSqrPerMassLengthSqr o1, PerMassTimeLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(PerMassTimeLengthCub o1, PerLengthSqrTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(PerLengthSqrTimeCub o1, PerMassTimeLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthMassTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(PerLengthMassTimeCub o1, PerMassTimeLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(PerMassTimeLengthCub o1, TimeCubLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubLengthMass o1, PerMassTimeLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(PerMassTimeLengthCub o1, TimeCubLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeCubLengthSqr o1, PerMassTimeLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(PerMassTimeLengthCub o1, LengthSqrMassPerTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerMassTimeLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(PerMassTimeLengthCub o1, LengthSqrTimeSqrMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(LengthSqrTimeSqrMass o1, PerMassTimeLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(PerMassTimeLengthCub o1, LengthCubPerTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(LengthCubPerTimeSqr o1, PerMassTimeLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(PerMassTimeLengthCub o1, LengthCubTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubTimeSqr o1, PerMassTimeLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(PerMassTimeLengthCub o1, LengthCubMassPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthCubMassPerTime o1, PerMassTimeLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerMassTimeLengthCub o1, LengthCubMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubMassTime o1, PerMassTimeLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerMassTimeLengthCub o1, PerMassTimeSqrLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerMassTimeSqrLengthCub o1, PerMassTimeLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerMassLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrPerMassLengthCub o1, PerMassTimeLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(PerMassTimeLengthCub o1, PerLengthCubTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(PerLengthCubTimeCub o1, PerMassTimeLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(PerMassTimeLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(PerMassLengthSqrTimeCub o1, PerMassTimeLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(PerMassTimeLengthCub o1, TimeCubLengthSqrMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubLengthSqrMass o1, PerMassTimeLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(PerMassTimeLengthCub o1, LengthCubTimeCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthCubTimeCub o1, PerMassTimeLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(PerMassTimeLengthCub o1, LengthCubMassPerTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerMassTimeLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(PerMassTimeLengthCub o1, LengthCubTimeSqrMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthCubTimeSqrMass o1, PerMassTimeLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(PerMassTimeLengthCub o1, PerMassLengthCubTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerMassLengthCubTimeCub o1, PerMassTimeLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(PerMassTimeLengthCub o1, LengthCubTimeCubMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthCubTimeCubMass o1, PerMassTimeLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassTimeLengthCub is outside its bounds.");
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
    