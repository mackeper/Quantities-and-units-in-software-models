
// GENERATED FILE! (20/10/2020 20:11:32)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubMassPerTimeSqr : Quantity, IEquatable<LengthCubMassPerTimeSqr>, IComparable
  {  
    internal LengthCubMassPerTimeSqr(double value) : base(value, 2)
    {
      LengthCubMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubMassPerTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubMassPerTimeSqr(LengthCubMassPerTimeSqr other) : base(other)
    {
      LengthCubMassPerTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubMassPerTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthCubMassPerTimeSqr"])
      {
        case "centimetercubkilogrampersecondsqr": displayUnit_ = centimetercubkilogrampersecondsqr_; break;
        case "millimetercubkilogrampersecondsqr": displayUnit_ = millimetercubkilogrampersecondsqr_; break;
        case "metercubkilogrampersecondsqr": displayUnit_ = metercubkilogrampersecondsqr_; break;
        case "inchcubkilogrampersecondsqr": displayUnit_ = inchcubkilogrampersecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubkilogrampersecondsqr_ = new Unit_("CentimeterCubKilogramPerSecondSqr", "cm³ kg/s²", 1.0, 0);
  private static Unit_ millimetercubkilogrampersecondsqr_ = new Unit_("MillimeterCubKilogramPerSecondSqr", "mm³ kg/s²", 0.0010000000000000002, 0);
  private static Unit_ metercubkilogrampersecondsqr_ = new Unit_("MeterCubKilogramPerSecondSqr", "m³ kg/s²", 1000000.0, 0);
  private static Unit_ inchcubkilogrampersecondsqr_ = new Unit_("InchCubKilogramPerSecondSqr", "in³ kg/s²", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubkilogrampersecondsqr_;
  private static Unit_ displayUnit_ = centimetercubkilogrampersecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubMassPerTimeSqr other && Equals(other);
  public bool Equals(LengthCubMassPerTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubMassPerTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubMassPerTimeSqr other)) throw new ArgumentException("Object is not a LengthCubMassPerTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubMassPerTimeSqr l1, LengthCubMassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubMassPerTimeSqr FromCentimeterCubKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeSqr((value + centimetercubkilogrampersecondsqr_.Offset) * centimetercubkilogrampersecondsqr_.Factor, minValue * centimetercubkilogrampersecondsqr_.Factor, maxValue * centimetercubkilogrampersecondsqr_.Factor);
  public static LengthCubMassPerTimeSqr FromCentimeterCubKilogramPerSecondSqrs(double value) => new LengthCubMassPerTimeSqr((value + centimetercubkilogrampersecondsqr_.Offset) * centimetercubkilogrampersecondsqr_.Factor);
  public double GetValueInCentimeterCubKilogramPerSecondSqrs() => (Value_ - centimetercubkilogrampersecondsqr_.Offset) / centimetercubkilogrampersecondsqr_.Factor;
  public static LengthCubMassPerTimeSqr FromMillimeterCubKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeSqr((value + millimetercubkilogrampersecondsqr_.Offset) * millimetercubkilogrampersecondsqr_.Factor, minValue * millimetercubkilogrampersecondsqr_.Factor, maxValue * millimetercubkilogrampersecondsqr_.Factor);
  public static LengthCubMassPerTimeSqr FromMillimeterCubKilogramPerSecondSqrs(double value) => new LengthCubMassPerTimeSqr((value + millimetercubkilogrampersecondsqr_.Offset) * millimetercubkilogrampersecondsqr_.Factor);
  public double GetValueInMillimeterCubKilogramPerSecondSqrs() => (Value_ - millimetercubkilogrampersecondsqr_.Offset) / millimetercubkilogrampersecondsqr_.Factor;
  public static LengthCubMassPerTimeSqr FromMeterCubKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeSqr((value + metercubkilogrampersecondsqr_.Offset) * metercubkilogrampersecondsqr_.Factor, minValue * metercubkilogrampersecondsqr_.Factor, maxValue * metercubkilogrampersecondsqr_.Factor);
  public static LengthCubMassPerTimeSqr FromMeterCubKilogramPerSecondSqrs(double value) => new LengthCubMassPerTimeSqr((value + metercubkilogrampersecondsqr_.Offset) * metercubkilogrampersecondsqr_.Factor);
  public double GetValueInMeterCubKilogramPerSecondSqrs() => (Value_ - metercubkilogrampersecondsqr_.Offset) / metercubkilogrampersecondsqr_.Factor;
  public static LengthCubMassPerTimeSqr FromInchCubKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeSqr((value + inchcubkilogrampersecondsqr_.Offset) * inchcubkilogrampersecondsqr_.Factor, minValue * inchcubkilogrampersecondsqr_.Factor, maxValue * inchcubkilogrampersecondsqr_.Factor);
  public static LengthCubMassPerTimeSqr FromInchCubKilogramPerSecondSqrs(double value) => new LengthCubMassPerTimeSqr((value + inchcubkilogrampersecondsqr_.Offset) * inchcubkilogrampersecondsqr_.Factor);
  public double GetValueInInchCubKilogramPerSecondSqrs() => (Value_ - inchcubkilogrampersecondsqr_.Offset) / inchcubkilogrampersecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthCubMassPerTimeSqr operator+(LengthCubMassPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ + o2.Value_);
  public static LengthCubMassPerTimeSqr operator-(LengthCubMassPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubMassPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Time operator*(LengthCubMassPerTimeSqr o1, TimeCubPerMassLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubPerMassLengthCub o1, LengthCubMassPerTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthCubMassPerTimeSqr o1, LengthCubMassPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthCubMassPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubMassPerTimeSqr is outside its bounds.");
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
    