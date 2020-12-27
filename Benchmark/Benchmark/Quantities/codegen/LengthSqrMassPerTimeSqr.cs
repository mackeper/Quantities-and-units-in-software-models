
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrMassPerTimeSqr : Quantity, IEquatable<LengthSqrMassPerTimeSqr>, IComparable
  {  
    internal LengthSqrMassPerTimeSqr(double value) : base(value, 2)
    {
      LengthSqrMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrMassPerTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrMassPerTimeSqr(LengthSqrMassPerTimeSqr other) : base(other)
    {
      LengthSqrMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrMassPerTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthSqrMassPerTimeSqr"])
      {
        case "centimetersqrkilogrampersecondsqr": displayUnit_ = centimetersqrkilogrampersecondsqr_; break;
        case "millimetersqrkilogrampersecondsqr": displayUnit_ = millimetersqrkilogrampersecondsqr_; break;
        case "metersqrkilogrampersecondsqr": displayUnit_ = metersqrkilogrampersecondsqr_; break;
        case "inchsqrkilogrampersecondsqr": displayUnit_ = inchsqrkilogrampersecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrkilogrampersecondsqr_ = new Unit_("CentimeterSqrKilogramPerSecondSqr", "cm² kg/s²", 1.0, 0);
  private static Unit_ millimetersqrkilogrampersecondsqr_ = new Unit_("MillimeterSqrKilogramPerSecondSqr", "mm² kg/s²", 0.010000000000000002, 0);
  private static Unit_ metersqrkilogrampersecondsqr_ = new Unit_("MeterSqrKilogramPerSecondSqr", "m² kg/s²", 10000.0, 0);
  private static Unit_ inchsqrkilogrampersecondsqr_ = new Unit_("InchSqrKilogramPerSecondSqr", "in² kg/s²", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrkilogrampersecondsqr_;
  private static Unit_ displayUnit_ = centimetersqrkilogrampersecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrMassPerTimeSqr other && Equals(other);
  public bool Equals(LengthSqrMassPerTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrMassPerTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrMassPerTimeSqr other)) throw new ArgumentException("Object is not a LengthSqrMassPerTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrMassPerTimeSqr l1, LengthSqrMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrMassPerTimeSqr FromCentimeterSqrKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeSqr((value + centimetersqrkilogrampersecondsqr_.Offset) * centimetersqrkilogrampersecondsqr_.Factor, minValue * centimetersqrkilogrampersecondsqr_.Factor, maxValue * centimetersqrkilogrampersecondsqr_.Factor);
  public static LengthSqrMassPerTimeSqr FromCentimeterSqrKilogramPerSecondSqrs(double value) => new LengthSqrMassPerTimeSqr((value + centimetersqrkilogrampersecondsqr_.Offset) * centimetersqrkilogrampersecondsqr_.Factor);
  public double GetValueInCentimeterSqrKilogramPerSecondSqrs() => (Value_ - centimetersqrkilogrampersecondsqr_.Offset) / centimetersqrkilogrampersecondsqr_.Factor;
  public static LengthSqrMassPerTimeSqr FromMillimeterSqrKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeSqr((value + millimetersqrkilogrampersecondsqr_.Offset) * millimetersqrkilogrampersecondsqr_.Factor, minValue * millimetersqrkilogrampersecondsqr_.Factor, maxValue * millimetersqrkilogrampersecondsqr_.Factor);
  public static LengthSqrMassPerTimeSqr FromMillimeterSqrKilogramPerSecondSqrs(double value) => new LengthSqrMassPerTimeSqr((value + millimetersqrkilogrampersecondsqr_.Offset) * millimetersqrkilogrampersecondsqr_.Factor);
  public double GetValueInMillimeterSqrKilogramPerSecondSqrs() => (Value_ - millimetersqrkilogrampersecondsqr_.Offset) / millimetersqrkilogrampersecondsqr_.Factor;
  public static LengthSqrMassPerTimeSqr FromMeterSqrKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeSqr((value + metersqrkilogrampersecondsqr_.Offset) * metersqrkilogrampersecondsqr_.Factor, minValue * metersqrkilogrampersecondsqr_.Factor, maxValue * metersqrkilogrampersecondsqr_.Factor);
  public static LengthSqrMassPerTimeSqr FromMeterSqrKilogramPerSecondSqrs(double value) => new LengthSqrMassPerTimeSqr((value + metersqrkilogrampersecondsqr_.Offset) * metersqrkilogrampersecondsqr_.Factor);
  public double GetValueInMeterSqrKilogramPerSecondSqrs() => (Value_ - metersqrkilogrampersecondsqr_.Offset) / metersqrkilogrampersecondsqr_.Factor;
  public static LengthSqrMassPerTimeSqr FromInchSqrKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrMassPerTimeSqr((value + inchsqrkilogrampersecondsqr_.Offset) * inchsqrkilogrampersecondsqr_.Factor, minValue * inchsqrkilogrampersecondsqr_.Factor, maxValue * inchsqrkilogrampersecondsqr_.Factor);
  public static LengthSqrMassPerTimeSqr FromInchSqrKilogramPerSecondSqrs(double value) => new LengthSqrMassPerTimeSqr((value + inchsqrkilogrampersecondsqr_.Offset) * inchsqrkilogrampersecondsqr_.Factor);
  public double GetValueInInchSqrKilogramPerSecondSqrs() => (Value_ - inchsqrkilogrampersecondsqr_.Offset) / inchsqrkilogrampersecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthSqrMassPerTimeSqr operator+(LengthSqrMassPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ + o2.Value_);
  public static LengthSqrMassPerTimeSqr operator-(LengthSqrMassPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrMassPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrMassPerTimeSqr o1, LengthCubPerTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrMassPerTimeSqr o1, LengthCubMassPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubMassPerTime o1, LengthSqrMassPerTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthCubMassTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubMassTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerMassLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrPerMassLengthCub o1, LengthSqrMassPerTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeCubPerLengthCub o1, LengthSqrMassPerTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerMassLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubPerMassLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthSqrMassPerTimeSqr o1, LengthSqrMassPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthSqrMassPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(LengthSqrMassPerTimeSqr o1, LengthCubPerTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthCubPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrMassPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubMassPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerMassLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubPerMassLengthCub o1, LengthSqrMassPerTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthSqrMassPerTimeSqr o1, LengthCubMassPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubMassPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrMassPerTimeSqr is outside its bounds.");
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
    