
// GENERATED FILE! (20/10/2020 20:11:32)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubMassPerLengthCub : Quantity, IEquatable<TimeCubMassPerLengthCub>, IComparable
  {  
    internal TimeCubMassPerLengthCub(double value) : base(value, 2)
    {
      TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubMassPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubMassPerLengthCub(TimeCubMassPerLengthCub other) : base(other)
    {
      TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubMassPerLengthCub"))
    {
      switch(FakeDatabase.Units["TimeCubMassPerLengthCub"])
      {
        case "secondcubkilogrampercentimetercub": displayUnit_ = secondcubkilogrampercentimetercub_; break;
        case "secondcubkilogrampermillimetercub": displayUnit_ = secondcubkilogrampermillimetercub_; break;
        case "secondcubkilogrampermetercub": displayUnit_ = secondcubkilogrampermetercub_; break;
        case "secondcubkilogramperinchcub": displayUnit_ = secondcubkilogramperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubkilogrampercentimetercub_ = new Unit_("SecondCubKilogramPerCentimeterCub", "s³ kg/cm³", 1.0, 0);
  private static Unit_ secondcubkilogrampermillimetercub_ = new Unit_("SecondCubKilogramPerMillimeterCub", "s³ kg/mm³", 999.9999999999998, 0);
  private static Unit_ secondcubkilogrampermetercub_ = new Unit_("SecondCubKilogramPerMeterCub", "s³ kg/m³", 1e-06, 0);
  private static Unit_ secondcubkilogramperinchcub_ = new Unit_("SecondCubKilogramPerInchCub", "s³ kg/in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondcubkilogrampercentimetercub_;
  private static Unit_ displayUnit_ = secondcubkilogrampercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubMassPerLengthCub other && Equals(other);
  public bool Equals(TimeCubMassPerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubMassPerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubMassPerLengthCub other)) throw new ArgumentException("Object is not a TimeCubMassPerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub((value + secondcubkilogrampercentimetercub_.Offset) * secondcubkilogrampercentimetercub_.Factor, minValue * secondcubkilogrampercentimetercub_.Factor, maxValue * secondcubkilogrampercentimetercub_.Factor);
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerCentimeterCubs(double value) => new TimeCubMassPerLengthCub((value + secondcubkilogrampercentimetercub_.Offset) * secondcubkilogrampercentimetercub_.Factor);
  public double GetValueInSecondCubKilogramPerCentimeterCubs() => (Value_ - secondcubkilogrampercentimetercub_.Offset) / secondcubkilogrampercentimetercub_.Factor;
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub((value + secondcubkilogrampermillimetercub_.Offset) * secondcubkilogrampermillimetercub_.Factor, minValue * secondcubkilogrampermillimetercub_.Factor, maxValue * secondcubkilogrampermillimetercub_.Factor);
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMillimeterCubs(double value) => new TimeCubMassPerLengthCub((value + secondcubkilogrampermillimetercub_.Offset) * secondcubkilogrampermillimetercub_.Factor);
  public double GetValueInSecondCubKilogramPerMillimeterCubs() => (Value_ - secondcubkilogrampermillimetercub_.Offset) / secondcubkilogrampermillimetercub_.Factor;
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub((value + secondcubkilogrampermetercub_.Offset) * secondcubkilogrampermetercub_.Factor, minValue * secondcubkilogrampermetercub_.Factor, maxValue * secondcubkilogrampermetercub_.Factor);
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMeterCubs(double value) => new TimeCubMassPerLengthCub((value + secondcubkilogrampermetercub_.Offset) * secondcubkilogrampermetercub_.Factor);
  public double GetValueInSecondCubKilogramPerMeterCubs() => (Value_ - secondcubkilogrampermetercub_.Offset) / secondcubkilogrampermetercub_.Factor;
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerInchCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub((value + secondcubkilogramperinchcub_.Offset) * secondcubkilogramperinchcub_.Factor, minValue * secondcubkilogramperinchcub_.Factor, maxValue * secondcubkilogramperinchcub_.Factor);
  public static TimeCubMassPerLengthCub FromSecondCubKilogramPerInchCubs(double value) => new TimeCubMassPerLengthCub((value + secondcubkilogramperinchcub_.Offset) * secondcubkilogramperinchcub_.Factor);
  public double GetValueInSecondCubKilogramPerInchCubs() => (Value_ - secondcubkilogramperinchcub_.Offset) / secondcubkilogramperinchcub_.Factor;

#endregion

#region arithmetic
  public static TimeCubMassPerLengthCub operator+(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ + o2.Value_);
  public static TimeCubMassPerLengthCub operator-(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeCubMassPerLengthCub o1, LengthCubPerMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerMassTimeCub o1, TimeCubMassPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubMassPerLengthCub is outside its bounds.");
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
    