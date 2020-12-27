
// GENERATE FILE! (27/05/2020 08:55:49)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubPerMassTimeSqr : Quantity, IEquatable<LengthCubPerMassTimeSqr>, IComparable
  {  
    internal LengthCubPerMassTimeSqr(double value) : base(value, 2)
    {
      LengthCubPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubPerMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubPerMassTimeSqr(LengthCubPerMassTimeSqr other) : base(other)
    {
      LengthCubPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerMassTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthCubPerMassTimeSqr"])
      {
        case "centimetercubperkilogramsecondsqr": displayUnit_ = centimetercubperkilogramsecondsqr_; break;
        case "millimetercubperkilogramsecondsqr": displayUnit_ = millimetercubperkilogramsecondsqr_; break;
        case "metercubperkilogramsecondsqr": displayUnit_ = metercubperkilogramsecondsqr_; break;
        case "inchcubperkilogramsecondsqr": displayUnit_ = inchcubperkilogramsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubperkilogramsecondsqr_ = new Unit_("CentimeterCubPerKilogramSecondSqr", "cm³/kg s²", 1.0, 0);
  private static Unit_ millimetercubperkilogramsecondsqr_ = new Unit_("MillimeterCubPerKilogramSecondSqr", "mm³/kg s²", 0.0010000000000000002, 0);
  private static Unit_ metercubperkilogramsecondsqr_ = new Unit_("MeterCubPerKilogramSecondSqr", "m³/kg s²", 1000000.0, 0);
  private static Unit_ inchcubperkilogramsecondsqr_ = new Unit_("InchCubPerKilogramSecondSqr", "in³/kg s²", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubperkilogramsecondsqr_;
  private static Unit_ displayUnit_ = centimetercubperkilogramsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubPerMassTimeSqr other && Equals(other);
  public bool Equals(LengthCubPerMassTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubPerMassTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubPerMassTimeSqr other)) throw new ArgumentException("Object is not a LengthCubPerMassTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubPerMassTimeSqr l1, LengthCubPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubPerMassTimeSqr FromCentimeterCubPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeSqr((value + centimetercubperkilogramsecondsqr_.Offset) * centimetercubperkilogramsecondsqr_.Factor, minValue * centimetercubperkilogramsecondsqr_.Factor, maxValue * centimetercubperkilogramsecondsqr_.Factor);
  public static LengthCubPerMassTimeSqr FromCentimeterCubPerKilogramSecondSqrs(double value) => new LengthCubPerMassTimeSqr((value + centimetercubperkilogramsecondsqr_.Offset) * centimetercubperkilogramsecondsqr_.Factor);
  public double GetValueInCentimeterCubPerKilogramSecondSqrs() => (Value_ - centimetercubperkilogramsecondsqr_.Offset) / centimetercubperkilogramsecondsqr_.Factor;
  public static LengthCubPerMassTimeSqr FromMillimeterCubPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeSqr((value + millimetercubperkilogramsecondsqr_.Offset) * millimetercubperkilogramsecondsqr_.Factor, minValue * millimetercubperkilogramsecondsqr_.Factor, maxValue * millimetercubperkilogramsecondsqr_.Factor);
  public static LengthCubPerMassTimeSqr FromMillimeterCubPerKilogramSecondSqrs(double value) => new LengthCubPerMassTimeSqr((value + millimetercubperkilogramsecondsqr_.Offset) * millimetercubperkilogramsecondsqr_.Factor);
  public double GetValueInMillimeterCubPerKilogramSecondSqrs() => (Value_ - millimetercubperkilogramsecondsqr_.Offset) / millimetercubperkilogramsecondsqr_.Factor;
  public static LengthCubPerMassTimeSqr FromMeterCubPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeSqr((value + metercubperkilogramsecondsqr_.Offset) * metercubperkilogramsecondsqr_.Factor, minValue * metercubperkilogramsecondsqr_.Factor, maxValue * metercubperkilogramsecondsqr_.Factor);
  public static LengthCubPerMassTimeSqr FromMeterCubPerKilogramSecondSqrs(double value) => new LengthCubPerMassTimeSqr((value + metercubperkilogramsecondsqr_.Offset) * metercubperkilogramsecondsqr_.Factor);
  public double GetValueInMeterCubPerKilogramSecondSqrs() => (Value_ - metercubperkilogramsecondsqr_.Offset) / metercubperkilogramsecondsqr_.Factor;
  public static LengthCubPerMassTimeSqr FromInchCubPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeSqr((value + inchcubperkilogramsecondsqr_.Offset) * inchcubperkilogramsecondsqr_.Factor, minValue * inchcubperkilogramsecondsqr_.Factor, maxValue * inchcubperkilogramsecondsqr_.Factor);
  public static LengthCubPerMassTimeSqr FromInchCubPerKilogramSecondSqrs(double value) => new LengthCubPerMassTimeSqr((value + inchcubperkilogramsecondsqr_.Offset) * inchcubperkilogramsecondsqr_.Factor);
  public double GetValueInInchCubPerKilogramSecondSqrs() => (Value_ - inchcubperkilogramsecondsqr_.Offset) / inchcubperkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthCubPerMassTimeSqr operator+(LengthCubPerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ + o2.Value_);
  public static LengthCubPerMassTimeSqr operator-(LengthCubPerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubPerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthCubPerMassTimeSqr o1, LengthCubPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubPerTimeCub o1, LengthCubPerMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(LengthCubPerMassTimeSqr o1, TimeCubMassPerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubMassPerLengthCub o1, LengthCubPerMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthCubPerMassTimeSqr o1, LengthCubPerMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthCubPerMassTimeCub o1, LengthCubPerMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubPerMassTimeSqr is outside its bounds.");
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
    