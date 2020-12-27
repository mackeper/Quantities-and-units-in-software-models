
// GENERATE FILE! (27/05/2020 08:55:49)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubMassPerTimeCub : Quantity, IEquatable<LengthCubMassPerTimeCub>, IComparable
  {  
    internal LengthCubMassPerTimeCub(double value) : base(value, 2)
    {
      LengthCubMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubMassPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubMassPerTimeCub(LengthCubMassPerTimeCub other) : base(other)
    {
      LengthCubMassPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubMassPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthCubMassPerTimeCub"])
      {
        case "centimetercubkilogrampersecondcub": displayUnit_ = centimetercubkilogrampersecondcub_; break;
        case "millimetercubkilogrampersecondcub": displayUnit_ = millimetercubkilogrampersecondcub_; break;
        case "metercubkilogrampersecondcub": displayUnit_ = metercubkilogrampersecondcub_; break;
        case "inchcubkilogrampersecondcub": displayUnit_ = inchcubkilogrampersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubkilogrampersecondcub_ = new Unit_("CentimeterCubKilogramPerSecondCub", "cm³ kg/s³", 1.0, 0);
  private static Unit_ millimetercubkilogrampersecondcub_ = new Unit_("MillimeterCubKilogramPerSecondCub", "mm³ kg/s³", 0.0010000000000000002, 0);
  private static Unit_ metercubkilogrampersecondcub_ = new Unit_("MeterCubKilogramPerSecondCub", "m³ kg/s³", 1000000.0, 0);
  private static Unit_ inchcubkilogrampersecondcub_ = new Unit_("InchCubKilogramPerSecondCub", "in³ kg/s³", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubkilogrampersecondcub_;
  private static Unit_ displayUnit_ = centimetercubkilogrampersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubMassPerTimeCub other && Equals(other);
  public bool Equals(LengthCubMassPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubMassPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubMassPerTimeCub other)) throw new ArgumentException("Object is not a LengthCubMassPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubMassPerTimeCub l1, LengthCubMassPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubMassPerTimeCub FromCentimeterCubKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeCub((value + centimetercubkilogrampersecondcub_.Offset) * centimetercubkilogrampersecondcub_.Factor, minValue * centimetercubkilogrampersecondcub_.Factor, maxValue * centimetercubkilogrampersecondcub_.Factor);
  public static LengthCubMassPerTimeCub FromCentimeterCubKilogramPerSecondCubs(double value) => new LengthCubMassPerTimeCub((value + centimetercubkilogrampersecondcub_.Offset) * centimetercubkilogrampersecondcub_.Factor);
  public double GetValueInCentimeterCubKilogramPerSecondCubs() => (Value_ - centimetercubkilogrampersecondcub_.Offset) / centimetercubkilogrampersecondcub_.Factor;
  public static LengthCubMassPerTimeCub FromMillimeterCubKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeCub((value + millimetercubkilogrampersecondcub_.Offset) * millimetercubkilogrampersecondcub_.Factor, minValue * millimetercubkilogrampersecondcub_.Factor, maxValue * millimetercubkilogrampersecondcub_.Factor);
  public static LengthCubMassPerTimeCub FromMillimeterCubKilogramPerSecondCubs(double value) => new LengthCubMassPerTimeCub((value + millimetercubkilogrampersecondcub_.Offset) * millimetercubkilogrampersecondcub_.Factor);
  public double GetValueInMillimeterCubKilogramPerSecondCubs() => (Value_ - millimetercubkilogrampersecondcub_.Offset) / millimetercubkilogrampersecondcub_.Factor;
  public static LengthCubMassPerTimeCub FromMeterCubKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeCub((value + metercubkilogrampersecondcub_.Offset) * metercubkilogrampersecondcub_.Factor, minValue * metercubkilogrampersecondcub_.Factor, maxValue * metercubkilogrampersecondcub_.Factor);
  public static LengthCubMassPerTimeCub FromMeterCubKilogramPerSecondCubs(double value) => new LengthCubMassPerTimeCub((value + metercubkilogrampersecondcub_.Offset) * metercubkilogrampersecondcub_.Factor);
  public double GetValueInMeterCubKilogramPerSecondCubs() => (Value_ - metercubkilogrampersecondcub_.Offset) / metercubkilogrampersecondcub_.Factor;
  public static LengthCubMassPerTimeCub FromInchCubKilogramPerSecondCubs(double value, double minValue, double maxValue) => new LengthCubMassPerTimeCub((value + inchcubkilogrampersecondcub_.Offset) * inchcubkilogrampersecondcub_.Factor, minValue * inchcubkilogrampersecondcub_.Factor, maxValue * inchcubkilogrampersecondcub_.Factor);
  public static LengthCubMassPerTimeCub FromInchCubKilogramPerSecondCubs(double value) => new LengthCubMassPerTimeCub((value + inchcubkilogrampersecondcub_.Offset) * inchcubkilogrampersecondcub_.Factor);
  public double GetValueInInchCubKilogramPerSecondCubs() => (Value_ - inchcubkilogrampersecondcub_.Offset) / inchcubkilogrampersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthCubMassPerTimeCub operator+(LengthCubMassPerTimeCub o1, LengthCubMassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthCubMassPerTimeCub operator-(LengthCubMassPerTimeCub o1, LengthCubMassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubMassPerTimeCub o1, LengthCubMassPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubMassPerTimeCub is outside its bounds.");
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
    