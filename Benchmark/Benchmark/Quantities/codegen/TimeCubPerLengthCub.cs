
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubPerLengthCub : Quantity, IEquatable<TimeCubPerLengthCub>, IComparable
  {  
    internal TimeCubPerLengthCub(double value) : base(value, 2)
    {
      TimeCubPerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubPerLengthCub(TimeCubPerLengthCub other) : base(other)
    {
      TimeCubPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerLengthCub"))
    {
      switch(FakeDatabase.Units["TimeCubPerLengthCub"])
      {
        case "secondcubpercentimetercub": displayUnit_ = secondcubpercentimetercub_; break;
        case "secondcubpermillimetercub": displayUnit_ = secondcubpermillimetercub_; break;
        case "secondcubpermetercub": displayUnit_ = secondcubpermetercub_; break;
        case "secondcubperinchcub": displayUnit_ = secondcubperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubpercentimetercub_ = new Unit_("SecondCubPerCentimeterCub", "s³/cm³", 1.0, 0);
  private static Unit_ secondcubpermillimetercub_ = new Unit_("SecondCubPerMillimeterCub", "s³/mm³", 999.9999999999998, 0);
  private static Unit_ secondcubpermetercub_ = new Unit_("SecondCubPerMeterCub", "s³/m³", 1e-06, 0);
  private static Unit_ secondcubperinchcub_ = new Unit_("SecondCubPerInchCub", "s³/in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondcubpercentimetercub_;
  private static Unit_ displayUnit_ = secondcubpercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubPerLengthCub other && Equals(other);
  public bool Equals(TimeCubPerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubPerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubPerLengthCub other)) throw new ArgumentException("Object is not a TimeCubPerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubPerLengthCub l1, TimeCubPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubPerLengthCub FromSecondCubPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeCubPerLengthCub((value + secondcubpercentimetercub_.Offset) * secondcubpercentimetercub_.Factor, minValue * secondcubpercentimetercub_.Factor, maxValue * secondcubpercentimetercub_.Factor);
  public static TimeCubPerLengthCub FromSecondCubPerCentimeterCubs(double value) => new TimeCubPerLengthCub((value + secondcubpercentimetercub_.Offset) * secondcubpercentimetercub_.Factor);
  public double GetValueInSecondCubPerCentimeterCubs() => (Value_ - secondcubpercentimetercub_.Offset) / secondcubpercentimetercub_.Factor;
  public static TimeCubPerLengthCub FromSecondCubPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeCubPerLengthCub((value + secondcubpermillimetercub_.Offset) * secondcubpermillimetercub_.Factor, minValue * secondcubpermillimetercub_.Factor, maxValue * secondcubpermillimetercub_.Factor);
  public static TimeCubPerLengthCub FromSecondCubPerMillimeterCubs(double value) => new TimeCubPerLengthCub((value + secondcubpermillimetercub_.Offset) * secondcubpermillimetercub_.Factor);
  public double GetValueInSecondCubPerMillimeterCubs() => (Value_ - secondcubpermillimetercub_.Offset) / secondcubpermillimetercub_.Factor;
  public static TimeCubPerLengthCub FromSecondCubPerMeterCubs(double value, double minValue, double maxValue) => new TimeCubPerLengthCub((value + secondcubpermetercub_.Offset) * secondcubpermetercub_.Factor, minValue * secondcubpermetercub_.Factor, maxValue * secondcubpermetercub_.Factor);
  public static TimeCubPerLengthCub FromSecondCubPerMeterCubs(double value) => new TimeCubPerLengthCub((value + secondcubpermetercub_.Offset) * secondcubpermetercub_.Factor);
  public double GetValueInSecondCubPerMeterCubs() => (Value_ - secondcubpermetercub_.Offset) / secondcubpermetercub_.Factor;
  public static TimeCubPerLengthCub FromSecondCubPerInchCubs(double value, double minValue, double maxValue) => new TimeCubPerLengthCub((value + secondcubperinchcub_.Offset) * secondcubperinchcub_.Factor, minValue * secondcubperinchcub_.Factor, maxValue * secondcubperinchcub_.Factor);
  public static TimeCubPerLengthCub FromSecondCubPerInchCubs(double value) => new TimeCubPerLengthCub((value + secondcubperinchcub_.Offset) * secondcubperinchcub_.Factor);
  public double GetValueInSecondCubPerInchCubs() => (Value_ - secondcubperinchcub_.Offset) / secondcubperinchcub_.Factor;

#endregion

#region arithmetic
  public static TimeCubPerLengthCub operator+(TimeCubPerLengthCub o1, TimeCubPerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ + o2.Value_);
  public static TimeCubPerLengthCub operator-(TimeCubPerLengthCub o1, TimeCubPerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubPerLengthCub o1, TimeCubPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimeCubPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(TimeSqrMassPerLengthCub o1, TimeCubPerLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(TimeCubPerLengthCub o1, TimeCubPerMassLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubPerMassLengthSqr o1, TimeCubPerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(TimeCubPerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubMassPerLengthSqr o1, TimeCubPerLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeCubPerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthSqrPerMassTimeCub o1, TimeCubPerLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(TimeCubPerLengthCub o1, LengthSqrMassPerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthSqrMassPerTimeCub o1, TimeCubPerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(TimeCubPerLengthCub o1, LengthCubPerMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubPerMassTimeSqr o1, TimeCubPerLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeCubPerLengthCub o1, LengthCubPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerTimeCub o1, TimeCubPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimeCubPerLengthCub o1, LengthCubMassPerTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeCubPerLengthCub o1, TimeCubPerMassLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeCubPerMassLengthCub o1, TimeCubPerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimeCubPerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeCubMassPerLengthCub o1, TimeCubPerLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeCubPerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthCubPerMassTimeCub o1, TimeCubPerLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimeCubPerLengthCub o1, LengthCubMassPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthCubMassPerTimeCub o1, TimeCubPerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubPerLengthCub is outside its bounds.");
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
    