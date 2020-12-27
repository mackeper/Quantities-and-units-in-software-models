
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerMassTimeCub : Quantity, IEquatable<PerMassTimeCub>, IComparable
  {  
    internal PerMassTimeCub(double value) : base(value, 2)
    {
      PerMassTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerMassTimeCub(PerMassTimeCub other) : base(other)
    {
      PerMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeCub"))
    {
      switch(FakeDatabase.Units["PerMassTimeCub"])
      {
        case "perkilogramsecondcub": displayUnit_ = perkilogramsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkilogramsecondcub_ = new Unit_("PerKilogramSecondCub", "/kg s³", 1.0, 0);
  private static Unit_ platformUnit_ = perkilogramsecondcub_;
  private static Unit_ displayUnit_ = perkilogramsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerMassTimeCub other && Equals(other);
  public bool Equals(PerMassTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerMassTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerMassTimeCub other)) throw new ArgumentException("Object is not a PerMassTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerMassTimeCub l1, PerMassTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerMassTimeCub l1, PerMassTimeCub l2) => !(l1 == l2);
  public static bool operator <(PerMassTimeCub l1, PerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerMassTimeCub l1, PerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerMassTimeCub l1, PerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerMassTimeCub l1, PerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerMassTimeCub FromPerKilogramSecondCubs(double value, double minValue, double maxValue) => new PerMassTimeCub((value + perkilogramsecondcub_.Offset) * perkilogramsecondcub_.Factor, minValue * perkilogramsecondcub_.Factor, maxValue * perkilogramsecondcub_.Factor);
  public static PerMassTimeCub FromPerKilogramSecondCubs(double value) => new PerMassTimeCub((value + perkilogramsecondcub_.Offset) * perkilogramsecondcub_.Factor);
  public double GetValueInPerKilogramSecondCubs() => (Value_ - perkilogramsecondcub_.Offset) / perkilogramsecondcub_.Factor;

#endregion

#region arithmetic
  public static PerMassTimeCub operator+(PerMassTimeCub o1, PerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ + o2.Value_);
  public static PerMassTimeCub operator-(PerMassTimeCub o1, PerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerMassTimeCub o1, PerMassTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerMassTimeCub o1, TimeCubMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeCubMass o1, PerMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(PerMassTimeCub o1, LengthPerMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthPerMassTimeSqr o1, PerMassTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(PerMassTimeCub o1, LengthPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthPerTimeCub o1, PerMassTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerMassTimeCub o1, TimeCubLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(TimeCubLength o1, PerMassTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerMassTimeCub o1, TimeSqrLengthMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(TimeSqrLengthMass o1, PerMassTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(PerMassTimeCub o1, LengthSqrPerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthSqrPerMassTime o1, PerMassTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(PerMassTimeCub o1, QDose o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(QDose o1, PerMassTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(PerMassTimeCub o1, LengthSqrTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthSqrTimeSqr o1, PerMassTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static QDose operator*(PerMassTimeCub o1, LengthSqrMassTime o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthSqrMassTime o1, PerMassTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static PerLengthCubTimeCub operator/(PerMassTimeCub o1, LengthCubPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthCubPerMass o1, PerMassTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator/(PerMassTimeCub o1, LengthCubPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthCubPerTime o1, PerMassTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(PerMassTimeCub o1, LengthCubTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthCubTime o1, PerMassTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeCub operator*(PerMassTimeCub o1, LengthCubMass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthCubMass o1, PerMassTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(PerMassTimeCub o1, PerMassTimeLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(PerMassTimeLengthCub o1, PerMassTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator/(PerMassTimeCub o1, PerTimeSqrLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(PerTimeSqrLengthCub o1, PerMassTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(PerMassTimeCub o1, TimeSqrPerLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(TimeSqrPerLengthCub o1, PerMassTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(PerMassTimeCub o1, MassTimePerLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(MassTimePerLengthCub o1, PerMassTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(PerMassTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(PerMassLengthSqrTimeSqr o1, PerMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator/(PerMassTimeCub o1, PerLengthSqrTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(PerLengthSqrTimeCub o1, PerMassTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(PerMassTimeCub o1, TimeCubPerLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeCubPerLengthSqr o1, PerMassTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(PerMassTimeCub o1, TimeSqrMassPerLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimeSqrMassPerLengthSqr o1, PerMassTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static Length operator/(PerMassTimeCub o1, PerLengthMassTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerLengthMassTimeCub o1, PerMassTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(PerMassTimeCub o1, TimeCubMassPerLength o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubMassPerLength o1, PerMassTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(PerMassTimeCub o1, LengthPerMassTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthPerMassTimeCub o1, PerMassTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Length operator*(PerMassTimeCub o1, TimeCubLengthMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(TimeCubLengthMass o1, PerMassTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(PerMassTimeCub o1, LengthSqrPerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthSqrPerMassTimeSqr o1, PerMassTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(PerMassTimeCub o1, LengthSqrPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthSqrPerTimeCub o1, PerMassTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(PerMassTimeCub o1, TimeCubLengthSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(TimeCubLengthSqr o1, PerMassTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(PerMassTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthSqrTimeSqrMass o1, PerMassTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(PerMassTimeCub o1, LengthCubPerMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthCubPerMassTime o1, PerMassTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator/(PerMassTimeCub o1, LengthCubPerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthCubPerTimeSqr o1, PerMassTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(PerMassTimeCub o1, LengthCubTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthCubTimeSqr o1, PerMassTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(PerMassTimeCub o1, LengthCubMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthCubMassTime o1, PerMassTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator/(PerMassTimeCub o1, PerMassTimeSqrLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(PerMassTimeSqrLengthCub o1, PerMassTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator/(PerMassTimeCub o1, PerLengthCubTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(PerLengthCubTimeCub o1, PerMassTimeCub o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(PerMassTimeCub o1, TimeCubPerLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(TimeCubPerLengthCub o1, PerMassTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator*(PerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(TimeSqrMassPerLengthCub o1, PerMassTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static Area operator/(PerMassTimeCub o1, PerMassLengthSqrTimeCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerMassLengthSqrTimeCub o1, PerMassTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(PerMassTimeCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeCubMassPerLengthSqr o1, PerMassTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(PerMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthSqrPerMassTimeCub o1, PerMassTimeCub o2) => new Area(o1.Value_ / o2.Value_);
  
  public static Area operator*(PerMassTimeCub o1, TimeCubLengthSqrMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(TimeCubLengthSqrMass o1, PerMassTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(PerMassTimeCub o1, LengthCubPerMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthCubPerMassTimeSqr o1, PerMassTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator/(PerMassTimeCub o1, LengthCubPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthCubPerTimeCub o1, PerMassTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(PerMassTimeCub o1, LengthCubTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthCubTimeCub o1, PerMassTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator*(PerMassTimeCub o1, LengthCubTimeSqrMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthCubTimeSqrMass o1, PerMassTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static Volume operator/(PerMassTimeCub o1, PerMassLengthCubTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassLengthCubTimeCub o1, PerMassTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(PerMassTimeCub o1, TimeCubMassPerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimeCubMassPerLengthCub o1, PerMassTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(PerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubPerMassTimeCub o1, PerMassTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static Volume operator*(PerMassTimeCub o1, LengthCubTimeCubMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubTimeCubMass o1, PerMassTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerMassTimeCub is outside its bounds.");
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
    