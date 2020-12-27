
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrMassTime : Quantity, IEquatable<LengthSqrMassTime>, IComparable
  {  
    internal LengthSqrMassTime(double value) : base(value, 2)
    {
      LengthSqrMassTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrMassTime(LengthSqrMassTime other) : base(other)
    {
      LengthSqrMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrMassTime"))
    {
      switch(FakeDatabase.Units["LengthSqrMassTime"])
      {
        case "centimetersqrkilogramsecond": displayUnit_ = centimetersqrkilogramsecond_; break;
        case "millimetersqrkilogramsecond": displayUnit_ = millimetersqrkilogramsecond_; break;
        case "metersqrkilogramsecond": displayUnit_ = metersqrkilogramsecond_; break;
        case "inchsqrkilogramsecond": displayUnit_ = inchsqrkilogramsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrkilogramsecond_ = new Unit_("CentimeterSqrKilogramSecond", "cm� kg s", 1, 0);
  private static Unit_ millimetersqrkilogramsecond_ = new Unit_("MillimeterSqrKilogramSecond", "mm� kg s", 0.010000000000000002, 0);
  private static Unit_ metersqrkilogramsecond_ = new Unit_("MeterSqrKilogramSecond", "m� kg s", 10000, 0);
  private static Unit_ inchsqrkilogramsecond_ = new Unit_("InchSqrKilogramSecond", "in� kg s", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrkilogramsecond_;
  private static Unit_ displayUnit_ = centimetersqrkilogramsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrMassTime other && Equals(other);
  public bool Equals(LengthSqrMassTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrMassTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrMassTime other)) throw new ArgumentException("Object is not a LengthSqrMassTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrMassTime l1, LengthSqrMassTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrMassTime l1, LengthSqrMassTime l2) => !(l1 == l2);
  public static bool operator <(LengthSqrMassTime l1, LengthSqrMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrMassTime l1, LengthSqrMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrMassTime l1, LengthSqrMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrMassTime l1, LengthSqrMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrMassTime FromCentimeterSqrKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrMassTime((value + centimetersqrkilogramsecond_.Offset) * centimetersqrkilogramsecond_.Factor, minValue * centimetersqrkilogramsecond_.Factor, maxValue * centimetersqrkilogramsecond_.Factor);
  public static LengthSqrMassTime FromCentimeterSqrKilogramSeconds(double value) => new LengthSqrMassTime((value + centimetersqrkilogramsecond_.Offset) * centimetersqrkilogramsecond_.Factor);
  public double GetValueInCentimeterSqrKilogramSeconds() => (Value_ - centimetersqrkilogramsecond_.Offset) / centimetersqrkilogramsecond_.Factor;
  public static LengthSqrMassTime FromMillimeterSqrKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrMassTime((value + millimetersqrkilogramsecond_.Offset) * millimetersqrkilogramsecond_.Factor, minValue * millimetersqrkilogramsecond_.Factor, maxValue * millimetersqrkilogramsecond_.Factor);
  public static LengthSqrMassTime FromMillimeterSqrKilogramSeconds(double value) => new LengthSqrMassTime((value + millimetersqrkilogramsecond_.Offset) * millimetersqrkilogramsecond_.Factor);
  public double GetValueInMillimeterSqrKilogramSeconds() => (Value_ - millimetersqrkilogramsecond_.Offset) / millimetersqrkilogramsecond_.Factor;
  public static LengthSqrMassTime FromMeterSqrKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrMassTime((value + metersqrkilogramsecond_.Offset) * metersqrkilogramsecond_.Factor, minValue * metersqrkilogramsecond_.Factor, maxValue * metersqrkilogramsecond_.Factor);
  public static LengthSqrMassTime FromMeterSqrKilogramSeconds(double value) => new LengthSqrMassTime((value + metersqrkilogramsecond_.Offset) * metersqrkilogramsecond_.Factor);
  public double GetValueInMeterSqrKilogramSeconds() => (Value_ - metersqrkilogramsecond_.Offset) / metersqrkilogramsecond_.Factor;
  public static LengthSqrMassTime FromInchSqrKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrMassTime((value + inchsqrkilogramsecond_.Offset) * inchsqrkilogramsecond_.Factor, minValue * inchsqrkilogramsecond_.Factor, maxValue * inchsqrkilogramsecond_.Factor);
  public static LengthSqrMassTime FromInchSqrKilogramSeconds(double value) => new LengthSqrMassTime((value + inchsqrkilogramsecond_.Offset) * inchsqrkilogramsecond_.Factor);
  public double GetValueInInchSqrKilogramSeconds() => (Value_ - inchsqrkilogramsecond_.Offset) / inchsqrkilogramsecond_.Factor;

#endregion

#region arithmetic
  public static LengthSqrMassTime operator+(LengthSqrMassTime o1, LengthSqrMassTime o2) => new LengthSqrMassTime(o1.Value_ + o2.Value_);
  public static LengthSqrMassTime operator-(LengthSqrMassTime o1, LengthSqrMassTime o2) => new LengthSqrMassTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrMassTime o1, LengthSqrMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(LengthSqrMassTime o1, LengthCubPerTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthCubPerTime o1, LengthSqrMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrMassTime o1, LengthCubTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubTime o1, LengthSqrMassTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrMassTime o1, LengthCubMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubMass o1, LengthSqrMassTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrMassTime o1, PerMassTimeLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassTimeLengthCub o1, LengthSqrMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrMassTime o1, TimePerMassLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimePerMassLengthCub o1, LengthSqrMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrMassTime o1, PerTimeSqrLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerTimeSqrLengthCub o1, LengthSqrMassTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthSqrMassTime o1, TimeSqrPerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrPerLengthCub o1, LengthSqrMassTime o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrMassTime o1, PerMassLengthSqrTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerMassLengthSqrTimeSqr o1, LengthSqrMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthSqrMassTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrPerMassLengthSqr o1, LengthSqrMassTime o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthSqrMassTime o1, PerLengthSqrTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(PerLengthSqrTimeCub o1, LengthSqrMassTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(LengthSqrMassTime o1, PerLengthMassTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthMassTimeCub o1, LengthSqrMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthSqrMassTime o1, TimeCubMassPerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubMassPerLength o1, LengthSqrMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthSqrMassTime o1, LengthPerMassTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthPerMassTimeCub o1, LengthSqrMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthSqrMassTime o1, TimeCubLengthMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubLengthMass o1, LengthSqrMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthSqrMassTime o1, TimeCubLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubLengthSqr o1, LengthSqrMassTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(LengthSqrMassTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthSqrMassTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthSqrMassTime o1, LengthSqrTimeSqrMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrTimeSqrMass o1, LengthSqrMassTime o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator/(LengthSqrMassTime o1, LengthCubPerTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthCubPerTimeSqr o1, LengthSqrMassTime o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrMassTime o1, LengthCubTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubTimeSqr o1, LengthSqrMassTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrMassTime o1, LengthCubMassPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubMassPerTime o1, LengthSqrMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrMassTime o1, LengthCubMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubMassTime o1, LengthSqrMassTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrMassTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassTimeSqrLengthCub o1, LengthSqrMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthSqrMassTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrPerMassLengthCub o1, LengthSqrMassTime o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthSqrMassTime o1, PerLengthCubTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(PerLengthCubTimeCub o1, LengthSqrMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthSqrMassTime o1, PerMassLengthSqrTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerMassLengthSqrTimeCub o1, LengthSqrMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrMassTime o1, TimeCubLengthSqrMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLengthSqrMass o1, LengthSqrMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthSqrMassTime o1, LengthCubTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubTimeCub o1, LengthSqrMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrMassTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthSqrMassTime o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrMassTime o1, LengthCubTimeSqrMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimeSqrMass o1, LengthSqrMassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrMassTime o1, PerMassLengthCubTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthSqrMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrMassTime o1, LengthCubTimeCubMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeCubMass o1, LengthSqrMassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrMassTime is outside its bounds.");
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
    