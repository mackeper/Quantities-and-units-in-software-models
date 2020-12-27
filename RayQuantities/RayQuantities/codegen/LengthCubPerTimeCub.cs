
// GENERATED FILE! (20/10/2020 20:11:32)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubPerTimeCub : Quantity, IEquatable<LengthCubPerTimeCub>, IComparable
  {  
    internal LengthCubPerTimeCub(double value) : base(value, 2)
    {
      LengthCubPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubPerTimeCub(LengthCubPerTimeCub other) : base(other)
    {
      LengthCubPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthCubPerTimeCub"])
      {
        case "centimetercubpersecondcub": displayUnit_ = centimetercubpersecondcub_; break;
        case "millimetercubpersecondcub": displayUnit_ = millimetercubpersecondcub_; break;
        case "metercubpersecondcub": displayUnit_ = metercubpersecondcub_; break;
        case "inchcubpersecondcub": displayUnit_ = inchcubpersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubpersecondcub_ = new Unit_("CentimeterCubPerSecondCub", "cm³/s³", 1.0, 0);
  private static Unit_ millimetercubpersecondcub_ = new Unit_("MillimeterCubPerSecondCub", "mm³/s³", 0.0010000000000000002, 0);
  private static Unit_ metercubpersecondcub_ = new Unit_("MeterCubPerSecondCub", "m³/s³", 1000000.0, 0);
  private static Unit_ inchcubpersecondcub_ = new Unit_("InchCubPerSecondCub", "in³/s³", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubpersecondcub_;
  private static Unit_ displayUnit_ = centimetercubpersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubPerTimeCub other && Equals(other);
  public bool Equals(LengthCubPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubPerTimeCub other)) throw new ArgumentException("Object is not a LengthCubPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubPerTimeCub l1, LengthCubPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubPerTimeCub FromCentimeterCubPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerTimeCub((value + centimetercubpersecondcub_.Offset) * centimetercubpersecondcub_.Factor, minValue * centimetercubpersecondcub_.Factor, maxValue * centimetercubpersecondcub_.Factor);
  public static LengthCubPerTimeCub FromCentimeterCubPerSecondCubs(double value) => new LengthCubPerTimeCub((value + centimetercubpersecondcub_.Offset) * centimetercubpersecondcub_.Factor);
  public double GetValueInCentimeterCubPerSecondCubs() => (Value_ - centimetercubpersecondcub_.Offset) / centimetercubpersecondcub_.Factor;
  public static LengthCubPerTimeCub FromMillimeterCubPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerTimeCub((value + millimetercubpersecondcub_.Offset) * millimetercubpersecondcub_.Factor, minValue * millimetercubpersecondcub_.Factor, maxValue * millimetercubpersecondcub_.Factor);
  public static LengthCubPerTimeCub FromMillimeterCubPerSecondCubs(double value) => new LengthCubPerTimeCub((value + millimetercubpersecondcub_.Offset) * millimetercubpersecondcub_.Factor);
  public double GetValueInMillimeterCubPerSecondCubs() => (Value_ - millimetercubpersecondcub_.Offset) / millimetercubpersecondcub_.Factor;
  public static LengthCubPerTimeCub FromMeterCubPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerTimeCub((value + metercubpersecondcub_.Offset) * metercubpersecondcub_.Factor, minValue * metercubpersecondcub_.Factor, maxValue * metercubpersecondcub_.Factor);
  public static LengthCubPerTimeCub FromMeterCubPerSecondCubs(double value) => new LengthCubPerTimeCub((value + metercubpersecondcub_.Offset) * metercubpersecondcub_.Factor);
  public double GetValueInMeterCubPerSecondCubs() => (Value_ - metercubpersecondcub_.Offset) / metercubpersecondcub_.Factor;
  public static LengthCubPerTimeCub FromInchCubPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerTimeCub((value + inchcubpersecondcub_.Offset) * inchcubpersecondcub_.Factor, minValue * inchcubpersecondcub_.Factor, maxValue * inchcubpersecondcub_.Factor);
  public static LengthCubPerTimeCub FromInchCubPerSecondCubs(double value) => new LengthCubPerTimeCub((value + inchcubpersecondcub_.Offset) * inchcubpersecondcub_.Factor);
  public double GetValueInInchCubPerSecondCubs() => (Value_ - inchcubpersecondcub_.Offset) / inchcubpersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthCubPerTimeCub operator+(LengthCubPerTimeCub o1, LengthCubPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthCubPerTimeCub operator-(LengthCubPerTimeCub o1, LengthCubPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubPerTimeCub o1, LengthCubPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthCubPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthCubMassPerTimeSqr o1, LengthCubPerTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(LengthCubPerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimeCubPerMassLengthCub o1, LengthCubPerTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthCubPerTimeCub o1, TimeCubMassPerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(TimeCubMassPerLengthCub o1, LengthCubPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(LengthCubPerTimeCub o1, LengthCubPerMassTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthCubPerMassTimeCub o1, LengthCubPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthCubPerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthCubMassPerTimeCub o1, LengthCubPerTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubPerTimeCub is outside its bounds.");
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
    