
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubPerMassLengthSqr : Quantity, IEquatable<TimeCubPerMassLengthSqr>, IComparable
  {  
    internal TimeCubPerMassLengthSqr(double value) : base(value, 2)
    {
      TimeCubPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubPerMassLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubPerMassLengthSqr(TimeCubPerMassLengthSqr other) : base(other)
    {
      TimeCubPerMassLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerMassLengthSqr"))
    {
      switch(FakeDatabase.Units["TimeCubPerMassLengthSqr"])
      {
        case "secondcubperkilogramcentimetersqr": displayUnit_ = secondcubperkilogramcentimetersqr_; break;
        case "secondcubperkilogrammillimetersqr": displayUnit_ = secondcubperkilogrammillimetersqr_; break;
        case "secondcubperkilogrammetersqr": displayUnit_ = secondcubperkilogrammetersqr_; break;
        case "secondcubperkilograminchsqr": displayUnit_ = secondcubperkilograminchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubperkilogramcentimetersqr_ = new Unit_("SecondCubPerKilogramCentimeterSqr", "s³/kg cm²", 1.0, 0);
  private static Unit_ secondcubperkilogrammillimetersqr_ = new Unit_("SecondCubPerKilogramMillimeterSqr", "s³/kg mm²", 99.99999999999999, 0);
  private static Unit_ secondcubperkilogrammetersqr_ = new Unit_("SecondCubPerKilogramMeterSqr", "s³/kg m²", 0.0001, 0);
  private static Unit_ secondcubperkilograminchsqr_ = new Unit_("SecondCubPerKilogramInchSqr", "s³/kg in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondcubperkilogramcentimetersqr_;
  private static Unit_ displayUnit_ = secondcubperkilogramcentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubPerMassLengthSqr other && Equals(other);
  public bool Equals(TimeCubPerMassLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubPerMassLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubPerMassLengthSqr other)) throw new ArgumentException("Object is not a TimeCubPerMassLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubPerMassLengthSqr l1, TimeCubPerMassLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramCentimeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthSqr((value + secondcubperkilogramcentimetersqr_.Offset) * secondcubperkilogramcentimetersqr_.Factor, minValue * secondcubperkilogramcentimetersqr_.Factor, maxValue * secondcubperkilogramcentimetersqr_.Factor);
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramCentimeterSqrs(double value) => new TimeCubPerMassLengthSqr((value + secondcubperkilogramcentimetersqr_.Offset) * secondcubperkilogramcentimetersqr_.Factor);
  public double GetValueInSecondCubPerKilogramCentimeterSqrs() => (Value_ - secondcubperkilogramcentimetersqr_.Offset) / secondcubperkilogramcentimetersqr_.Factor;
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramMillimeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthSqr((value + secondcubperkilogrammillimetersqr_.Offset) * secondcubperkilogrammillimetersqr_.Factor, minValue * secondcubperkilogrammillimetersqr_.Factor, maxValue * secondcubperkilogrammillimetersqr_.Factor);
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramMillimeterSqrs(double value) => new TimeCubPerMassLengthSqr((value + secondcubperkilogrammillimetersqr_.Offset) * secondcubperkilogrammillimetersqr_.Factor);
  public double GetValueInSecondCubPerKilogramMillimeterSqrs() => (Value_ - secondcubperkilogrammillimetersqr_.Offset) / secondcubperkilogrammillimetersqr_.Factor;
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramMeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthSqr((value + secondcubperkilogrammetersqr_.Offset) * secondcubperkilogrammetersqr_.Factor, minValue * secondcubperkilogrammetersqr_.Factor, maxValue * secondcubperkilogrammetersqr_.Factor);
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramMeterSqrs(double value) => new TimeCubPerMassLengthSqr((value + secondcubperkilogrammetersqr_.Offset) * secondcubperkilogrammetersqr_.Factor);
  public double GetValueInSecondCubPerKilogramMeterSqrs() => (Value_ - secondcubperkilogrammetersqr_.Offset) / secondcubperkilogrammetersqr_.Factor;
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramInchSqrs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthSqr((value + secondcubperkilograminchsqr_.Offset) * secondcubperkilograminchsqr_.Factor, minValue * secondcubperkilograminchsqr_.Factor, maxValue * secondcubperkilograminchsqr_.Factor);
  public static TimeCubPerMassLengthSqr FromSecondCubPerKilogramInchSqrs(double value) => new TimeCubPerMassLengthSqr((value + secondcubperkilograminchsqr_.Offset) * secondcubperkilograminchsqr_.Factor);
  public double GetValueInSecondCubPerKilogramInchSqrs() => (Value_ - secondcubperkilograminchsqr_.Offset) / secondcubperkilograminchsqr_.Factor;

#endregion

#region arithmetic
  public static TimeCubPerMassLengthSqr operator+(TimeCubPerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ + o2.Value_);
  public static TimeCubPerMassLengthSqr operator-(TimeCubPerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubPerMassLengthSqr o1, TimeCubPerMassLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeCubPerMassLengthSqr o1, LengthSqrMassPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrMassPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static LengthPerMass operator*(TimeCubPerMassLengthSqr o1, LengthCubPerTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimeCubPerMassLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerMassLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCubPerMassLengthSqr o1, TimeCubPerMassLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubPerMassLengthCub o1, TimeCubPerMassLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCubPerMassLengthSqr o1, LengthCubMassPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubMassPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubPerMassLengthSqr is outside its bounds.");
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
    