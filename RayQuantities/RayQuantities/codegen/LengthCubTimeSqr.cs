
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubTimeSqr : Quantity, IEquatable<LengthCubTimeSqr>, IComparable
  {  
    internal LengthCubTimeSqr(double value) : base(value, 2)
    {
      LengthCubTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubTimeSqr(LengthCubTimeSqr other) : base(other)
    {
      LengthCubTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthCubTimeSqr"])
      {
        case "centimetercubsecondsqr": displayUnit_ = centimetercubsecondsqr_; break;
        case "millimetercubsecondsqr": displayUnit_ = millimetercubsecondsqr_; break;
        case "metercubsecondsqr": displayUnit_ = metercubsecondsqr_; break;
        case "inchcubsecondsqr": displayUnit_ = inchcubsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubsecondsqr_ = new Unit_("CentimeterCubSecondSqr", "cm³ s²", 1, 0);
  private static Unit_ millimetercubsecondsqr_ = new Unit_("MillimeterCubSecondSqr", "mm³ s²", 0.0010000000000000002, 0);
  private static Unit_ metercubsecondsqr_ = new Unit_("MeterCubSecondSqr", "m³ s²", 1000000, 0);
  private static Unit_ inchcubsecondsqr_ = new Unit_("InchCubSecondSqr", "in³ s²", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubsecondsqr_;
  private static Unit_ displayUnit_ = centimetercubsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubTimeSqr other && Equals(other);
  public bool Equals(LengthCubTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubTimeSqr other)) throw new ArgumentException("Object is not a LengthCubTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubTimeSqr l1, LengthCubTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubTimeSqr FromCentimeterCubSecondSqrs(double value, double minValue, double maxValue) => new LengthCubTimeSqr((value + centimetercubsecondsqr_.Offset) * centimetercubsecondsqr_.Factor, minValue * centimetercubsecondsqr_.Factor, maxValue * centimetercubsecondsqr_.Factor);
  public static LengthCubTimeSqr FromCentimeterCubSecondSqrs(double value) => new LengthCubTimeSqr((value + centimetercubsecondsqr_.Offset) * centimetercubsecondsqr_.Factor);
  public double GetValueInCentimeterCubSecondSqrs() => (Value_ - centimetercubsecondsqr_.Offset) / centimetercubsecondsqr_.Factor;
  public static LengthCubTimeSqr FromMillimeterCubSecondSqrs(double value, double minValue, double maxValue) => new LengthCubTimeSqr((value + millimetercubsecondsqr_.Offset) * millimetercubsecondsqr_.Factor, minValue * millimetercubsecondsqr_.Factor, maxValue * millimetercubsecondsqr_.Factor);
  public static LengthCubTimeSqr FromMillimeterCubSecondSqrs(double value) => new LengthCubTimeSqr((value + millimetercubsecondsqr_.Offset) * millimetercubsecondsqr_.Factor);
  public double GetValueInMillimeterCubSecondSqrs() => (Value_ - millimetercubsecondsqr_.Offset) / millimetercubsecondsqr_.Factor;
  public static LengthCubTimeSqr FromMeterCubSecondSqrs(double value, double minValue, double maxValue) => new LengthCubTimeSqr((value + metercubsecondsqr_.Offset) * metercubsecondsqr_.Factor, minValue * metercubsecondsqr_.Factor, maxValue * metercubsecondsqr_.Factor);
  public static LengthCubTimeSqr FromMeterCubSecondSqrs(double value) => new LengthCubTimeSqr((value + metercubsecondsqr_.Offset) * metercubsecondsqr_.Factor);
  public double GetValueInMeterCubSecondSqrs() => (Value_ - metercubsecondsqr_.Offset) / metercubsecondsqr_.Factor;
  public static LengthCubTimeSqr FromInchCubSecondSqrs(double value, double minValue, double maxValue) => new LengthCubTimeSqr((value + inchcubsecondsqr_.Offset) * inchcubsecondsqr_.Factor, minValue * inchcubsecondsqr_.Factor, maxValue * inchcubsecondsqr_.Factor);
  public static LengthCubTimeSqr FromInchCubSecondSqrs(double value) => new LengthCubTimeSqr((value + inchcubsecondsqr_.Offset) * inchcubsecondsqr_.Factor);
  public double GetValueInInchCubSecondSqrs() => (Value_ - inchcubsecondsqr_.Offset) / inchcubsecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthCubTimeSqr operator+(LengthCubTimeSqr o1, LengthCubTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ + o2.Value_);
  public static LengthCubTimeSqr operator-(LengthCubTimeSqr o1, LengthCubTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubTimeSqr o1, LengthCubTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(LengthCubTimeSqr o1, LengthCubMassPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthCubMassPerTime o1, LengthCubTimeSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthCubTimeSqr o1, LengthCubMassTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubMassTime o1, LengthCubTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(LengthCubTimeSqr o1, PerMassTimeSqrLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthCubTimeSqr o1, PerLengthCubTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthCubTimeCub o1, LengthCubTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthCubTimeSqr o1, MassPerTimeSqrLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerTimeSqrLengthCub o1, LengthCubTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(LengthCubTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(LengthCubTimeSqr o1, MassPerLengthSqrTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerLengthSqrTimeCub o1, LengthCubTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(LengthCubTimeSqr o1, TimeCubLengthSqrPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeCubLengthSqrPerMass o1, LengthCubTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(LengthCubTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubLengthSqrMass o1, LengthCubTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(LengthCubTimeSqr o1, LengthCubTimeSqrPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthCubTimeSqrPerMass o1, LengthCubTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthCubTimeSqr o1, LengthCubTimeCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthCubTimeCub o1, LengthCubTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthCubTimeSqr o1, LengthCubTimeSqrMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthCubTimeSqrMass o1, LengthCubTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(LengthCubTimeSqr o1, PerMassLengthCubTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassLengthCubTimeCub o1, LengthCubTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(LengthCubTimeSqr o1, MassPerLengthCubTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerLengthCubTimeCub o1, LengthCubTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator/(LengthCubTimeSqr o1, LengthCubTimeCubPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthCubTimeCubPerMass o1, LengthCubTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthCubTimeSqr o1, LengthCubTimeCubMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthCubTimeCubMass o1, LengthCubTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubTimeSqr is outside its bounds.");
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
    