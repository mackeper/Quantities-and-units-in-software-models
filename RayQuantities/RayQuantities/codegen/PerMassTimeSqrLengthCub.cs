
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassTimeSqrLengthCub : Quantity, IEquatable<PerMassTimeSqrLengthCub>, IComparable
  {  
    internal PerMassTimeSqrLengthCub(double value) : base(value, 2)
    {
      PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassTimeSqrLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassTimeSqrLengthCub(PerMassTimeSqrLengthCub other) : base(other)
    {
      PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeSqrLengthCub"))
    {
      switch(FakeDatabase.Units["PerMassTimeSqrLengthCub"])
      {
        case "perkilogramsecondsqrcentimetercub": displayUnit_ = perkilogramsecondsqrcentimetercub_; break;
        case "perkilogramsecondsqrmillimetercub": displayUnit_ = perkilogramsecondsqrmillimetercub_; break;
        case "perkilogramsecondsqrmetercub": displayUnit_ = perkilogramsecondsqrmetercub_; break;
        case "perkilogramsecondsqrinchcub": displayUnit_ = perkilogramsecondsqrinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramsecondsqrcentimetercub_ = new Unit_("PerKilogramSecondSqrCentimeterCub", "/kg s² cm³", 1.0, 0);
  private static Unit_ perkilogramsecondsqrmillimetercub_ = new Unit_("PerKilogramSecondSqrMillimeterCub", "/kg s² mm³", 999.9999999999998, 0);
  private static Unit_ perkilogramsecondsqrmetercub_ = new Unit_("PerKilogramSecondSqrMeterCub", "/kg s² m³", 1e-06, 0);
  private static Unit_ perkilogramsecondsqrinchcub_ = new Unit_("PerKilogramSecondSqrInchCub", "/kg s² in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = perkilogramsecondsqrcentimetercub_;
  private static Unit_ displayUnit_ = perkilogramsecondsqrcentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassTimeSqrLengthCub other && Equals(other);
  public bool Equals(PerMassTimeSqrLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassTimeSqrLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassTimeSqrLengthCub other)) throw new ArgumentException("Object is not a PerMassTimeSqrLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => !(l1 == l2);
  public static bool operator <(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrCentimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrcentimetercub_.Offset) * perkilogramsecondsqrcentimetercub_.Factor, minValue * perkilogramsecondsqrcentimetercub_.Factor, maxValue * perkilogramsecondsqrcentimetercub_.Factor);
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrCentimeterCubs(double value) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrcentimetercub_.Offset) * perkilogramsecondsqrcentimetercub_.Factor);
  public double GetValueInPerKilogramSecondSqrCentimeterCubs() => (Value_ - perkilogramsecondsqrcentimetercub_.Offset) / perkilogramsecondsqrcentimetercub_.Factor;
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrMillimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrmillimetercub_.Offset) * perkilogramsecondsqrmillimetercub_.Factor, minValue * perkilogramsecondsqrmillimetercub_.Factor, maxValue * perkilogramsecondsqrmillimetercub_.Factor);
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrMillimeterCubs(double value) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrmillimetercub_.Offset) * perkilogramsecondsqrmillimetercub_.Factor);
  public double GetValueInPerKilogramSecondSqrMillimeterCubs() => (Value_ - perkilogramsecondsqrmillimetercub_.Offset) / perkilogramsecondsqrmillimetercub_.Factor;
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrMeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrmetercub_.Offset) * perkilogramsecondsqrmetercub_.Factor, minValue * perkilogramsecondsqrmetercub_.Factor, maxValue * perkilogramsecondsqrmetercub_.Factor);
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrMeterCubs(double value) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrmetercub_.Offset) * perkilogramsecondsqrmetercub_.Factor);
  public double GetValueInPerKilogramSecondSqrMeterCubs() => (Value_ - perkilogramsecondsqrmetercub_.Offset) / perkilogramsecondsqrmetercub_.Factor;
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrInchCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrinchcub_.Offset) * perkilogramsecondsqrinchcub_.Factor, minValue * perkilogramsecondsqrinchcub_.Factor, maxValue * perkilogramsecondsqrinchcub_.Factor);
  public static PerMassTimeSqrLengthCub FromPerKilogramSecondSqrInchCubs(double value) => new PerMassTimeSqrLengthCub((value + perkilogramsecondsqrinchcub_.Offset) * perkilogramsecondsqrinchcub_.Factor);
  public double GetValueInPerKilogramSecondSqrInchCubs() => (Value_ - perkilogramsecondsqrinchcub_.Offset) / perkilogramsecondsqrinchcub_.Factor;

#endregion

#region arithmetic
  public static PerMassTimeSqrLengthCub operator+(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ + o2.Value_);
  public static PerMassTimeSqrLengthCub operator-(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(PerMassTimeSqrLengthCub o1, PerLengthCubTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(PerLengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(PerMassTimeSqrLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(PerMassLengthSqrTimeCub o1, PerMassTimeSqrLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(PerMassTimeSqrLengthCub o1, TimeCubLengthSqrMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubLengthSqrMass o1, PerMassTimeSqrLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubTimeSqrMass o1, PerMassTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static Time operator/(PerMassTimeSqrLengthCub o1, PerMassLengthCubTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerMassLengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeCubMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthCubTimeCubMass o1, PerMassTimeSqrLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassTimeSqrLengthCub is outside its bounds.");
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
    