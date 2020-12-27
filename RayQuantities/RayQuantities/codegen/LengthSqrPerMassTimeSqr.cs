
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrPerMassTimeSqr : Quantity, IEquatable<LengthSqrPerMassTimeSqr>, IComparable
  {  
    internal LengthSqrPerMassTimeSqr(double value) : base(value, 2)
    {
      LengthSqrPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrPerMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrPerMassTimeSqr(LengthSqrPerMassTimeSqr other) : base(other)
    {
      LengthSqrPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerMassTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthSqrPerMassTimeSqr"])
      {
        case "centimetersqrperkilogramsecondsqr": displayUnit_ = centimetersqrperkilogramsecondsqr_; break;
        case "millimetersqrperkilogramsecondsqr": displayUnit_ = millimetersqrperkilogramsecondsqr_; break;
        case "metersqrperkilogramsecondsqr": displayUnit_ = metersqrperkilogramsecondsqr_; break;
        case "inchsqrperkilogramsecondsqr": displayUnit_ = inchsqrperkilogramsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrperkilogramsecondsqr_ = new Unit_("CentimeterSqrPerKilogramSecondSqr", "cm²/kg s²", 1.0, 0);
  private static Unit_ millimetersqrperkilogramsecondsqr_ = new Unit_("MillimeterSqrPerKilogramSecondSqr", "mm²/kg s²", 0.010000000000000002, 0);
  private static Unit_ metersqrperkilogramsecondsqr_ = new Unit_("MeterSqrPerKilogramSecondSqr", "m²/kg s²", 10000.0, 0);
  private static Unit_ inchsqrperkilogramsecondsqr_ = new Unit_("InchSqrPerKilogramSecondSqr", "in²/kg s²", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrperkilogramsecondsqr_;
  private static Unit_ displayUnit_ = centimetersqrperkilogramsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrPerMassTimeSqr other && Equals(other);
  public bool Equals(LengthSqrPerMassTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrPerMassTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrPerMassTimeSqr other)) throw new ArgumentException("Object is not a LengthSqrPerMassTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrPerMassTimeSqr l1, LengthSqrPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrPerMassTimeSqr FromCentimeterSqrPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeSqr((value + centimetersqrperkilogramsecondsqr_.Offset) * centimetersqrperkilogramsecondsqr_.Factor, minValue * centimetersqrperkilogramsecondsqr_.Factor, maxValue * centimetersqrperkilogramsecondsqr_.Factor);
  public static LengthSqrPerMassTimeSqr FromCentimeterSqrPerKilogramSecondSqrs(double value) => new LengthSqrPerMassTimeSqr((value + centimetersqrperkilogramsecondsqr_.Offset) * centimetersqrperkilogramsecondsqr_.Factor);
  public double GetValueInCentimeterSqrPerKilogramSecondSqrs() => (Value_ - centimetersqrperkilogramsecondsqr_.Offset) / centimetersqrperkilogramsecondsqr_.Factor;
  public static LengthSqrPerMassTimeSqr FromMillimeterSqrPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeSqr((value + millimetersqrperkilogramsecondsqr_.Offset) * millimetersqrperkilogramsecondsqr_.Factor, minValue * millimetersqrperkilogramsecondsqr_.Factor, maxValue * millimetersqrperkilogramsecondsqr_.Factor);
  public static LengthSqrPerMassTimeSqr FromMillimeterSqrPerKilogramSecondSqrs(double value) => new LengthSqrPerMassTimeSqr((value + millimetersqrperkilogramsecondsqr_.Offset) * millimetersqrperkilogramsecondsqr_.Factor);
  public double GetValueInMillimeterSqrPerKilogramSecondSqrs() => (Value_ - millimetersqrperkilogramsecondsqr_.Offset) / millimetersqrperkilogramsecondsqr_.Factor;
  public static LengthSqrPerMassTimeSqr FromMeterSqrPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeSqr((value + metersqrperkilogramsecondsqr_.Offset) * metersqrperkilogramsecondsqr_.Factor, minValue * metersqrperkilogramsecondsqr_.Factor, maxValue * metersqrperkilogramsecondsqr_.Factor);
  public static LengthSqrPerMassTimeSqr FromMeterSqrPerKilogramSecondSqrs(double value) => new LengthSqrPerMassTimeSqr((value + metersqrperkilogramsecondsqr_.Offset) * metersqrperkilogramsecondsqr_.Factor);
  public double GetValueInMeterSqrPerKilogramSecondSqrs() => (Value_ - metersqrperkilogramsecondsqr_.Offset) / metersqrperkilogramsecondsqr_.Factor;
  public static LengthSqrPerMassTimeSqr FromInchSqrPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrPerMassTimeSqr((value + inchsqrperkilogramsecondsqr_.Offset) * inchsqrperkilogramsecondsqr_.Factor, minValue * inchsqrperkilogramsecondsqr_.Factor, maxValue * inchsqrperkilogramsecondsqr_.Factor);
  public static LengthSqrPerMassTimeSqr FromInchSqrPerKilogramSecondSqrs(double value) => new LengthSqrPerMassTimeSqr((value + inchsqrperkilogramsecondsqr_.Offset) * inchsqrperkilogramsecondsqr_.Factor);
  public double GetValueInInchSqrPerKilogramSecondSqrs() => (Value_ - inchsqrperkilogramsecondsqr_.Offset) / inchsqrperkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthSqrPerMassTimeSqr operator+(LengthSqrPerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ + o2.Value_);
  public static LengthSqrPerMassTimeSqr operator-(LengthSqrPerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthSqrPerTimeCub o1, LengthSqrPerMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubPerMassTime o1, LengthSqrPerMassTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthCubTimePerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubTimePerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubPerTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(LengthSqrPerMassTimeSqr o1, TimeCubPerLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeCubPerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrPerMassTimeSqr o1, TimeSqrMassPerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthSqrPerMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthCubPerTimeCub o1, LengthSqrPerMassTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(LengthSqrPerMassTimeSqr o1, TimeCubMassPerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubPerMassTimeCub o1, LengthSqrPerMassTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrPerMassTimeSqr is outside its bounds.");
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
    