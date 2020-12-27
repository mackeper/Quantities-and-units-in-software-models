
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrPerTimeCub : Quantity, IEquatable<LengthSqrPerTimeCub>, IComparable
  {  
    internal LengthSqrPerTimeCub(double value) : base(value, 2)
    {
      LengthSqrPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrPerTimeCub(LengthSqrPerTimeCub other) : base(other)
    {
      LengthSqrPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthSqrPerTimeCub"])
      {
        case "centimetersqrpersecondcub": displayUnit_ = centimetersqrpersecondcub_; break;
        case "millimetersqrpersecondcub": displayUnit_ = millimetersqrpersecondcub_; break;
        case "metersqrpersecondcub": displayUnit_ = metersqrpersecondcub_; break;
        case "inchsqrpersecondcub": displayUnit_ = inchsqrpersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrpersecondcub_ = new Unit_("CentimeterSqrPerSecondCub", "cm²/s³", 1.0, 0);
  private static Unit_ millimetersqrpersecondcub_ = new Unit_("MillimeterSqrPerSecondCub", "mm²/s³", 0.010000000000000002, 0);
  private static Unit_ metersqrpersecondcub_ = new Unit_("MeterSqrPerSecondCub", "m²/s³", 10000.0, 0);
  private static Unit_ inchsqrpersecondcub_ = new Unit_("InchSqrPerSecondCub", "in²/s³", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrpersecondcub_;
  private static Unit_ displayUnit_ = centimetersqrpersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrPerTimeCub other && Equals(other);
  public bool Equals(LengthSqrPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrPerTimeCub other)) throw new ArgumentException("Object is not a LengthSqrPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrPerTimeCub l1, LengthSqrPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrPerTimeCub FromCentimeterSqrPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerTimeCub((value + centimetersqrpersecondcub_.Offset) * centimetersqrpersecondcub_.Factor, minValue * centimetersqrpersecondcub_.Factor, maxValue * centimetersqrpersecondcub_.Factor);
  public static LengthSqrPerTimeCub FromCentimeterSqrPerSecondCubs(double value) => new LengthSqrPerTimeCub((value + centimetersqrpersecondcub_.Offset) * centimetersqrpersecondcub_.Factor);
  public double GetValueInCentimeterSqrPerSecondCubs() => (Value_ - centimetersqrpersecondcub_.Offset) / centimetersqrpersecondcub_.Factor;
  public static LengthSqrPerTimeCub FromMillimeterSqrPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerTimeCub((value + millimetersqrpersecondcub_.Offset) * millimetersqrpersecondcub_.Factor, minValue * millimetersqrpersecondcub_.Factor, maxValue * millimetersqrpersecondcub_.Factor);
  public static LengthSqrPerTimeCub FromMillimeterSqrPerSecondCubs(double value) => new LengthSqrPerTimeCub((value + millimetersqrpersecondcub_.Offset) * millimetersqrpersecondcub_.Factor);
  public double GetValueInMillimeterSqrPerSecondCubs() => (Value_ - millimetersqrpersecondcub_.Offset) / millimetersqrpersecondcub_.Factor;
  public static LengthSqrPerTimeCub FromMeterSqrPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerTimeCub((value + metersqrpersecondcub_.Offset) * metersqrpersecondcub_.Factor, minValue * metersqrpersecondcub_.Factor, maxValue * metersqrpersecondcub_.Factor);
  public static LengthSqrPerTimeCub FromMeterSqrPerSecondCubs(double value) => new LengthSqrPerTimeCub((value + metersqrpersecondcub_.Offset) * metersqrpersecondcub_.Factor);
  public double GetValueInMeterSqrPerSecondCubs() => (Value_ - metersqrpersecondcub_.Offset) / metersqrpersecondcub_.Factor;
  public static LengthSqrPerTimeCub FromInchSqrPerSecondCubs(double value, double minValue, double maxValue) => new LengthSqrPerTimeCub((value + inchsqrpersecondcub_.Offset) * inchsqrpersecondcub_.Factor, minValue * inchsqrpersecondcub_.Factor, maxValue * inchsqrpersecondcub_.Factor);
  public static LengthSqrPerTimeCub FromInchSqrPerSecondCubs(double value) => new LengthSqrPerTimeCub((value + inchsqrpersecondcub_.Offset) * inchsqrpersecondcub_.Factor);
  public double GetValueInInchSqrPerSecondCubs() => (Value_ - inchsqrpersecondcub_.Offset) / inchsqrpersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthSqrPerTimeCub operator+(LengthSqrPerTimeCub o1, LengthSqrPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthSqrPerTimeCub operator-(LengthSqrPerTimeCub o1, LengthSqrPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrPerTimeCub o1, LengthSqrPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrMassPerTimeSqr o1, LengthSqrPerTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthSqrPerTimeCub o1, LengthCubPerMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubPerMassTime o1, LengthSqrPerTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrPerTimeCub o1, LengthCubPerTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubPerTimeSqr o1, LengthSqrPerTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthSqrPerTimeCub o1, LengthCubMassPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubMassPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(TimeSqrPerMassLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrPerTimeCub o1, TimeCubPerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubPerLengthCub o1, LengthSqrPerTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrPerTimeCub o1, TimeSqrMassPerLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(LengthSqrPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimeCubPerMassLengthSqr o1, LengthSqrPerTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthSqrPerTimeCub o1, TimeCubMassPerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(LengthSqrPerTimeCub o1, LengthSqrPerMassTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthSqrPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthSqrMassPerTimeCub o1, LengthSqrPerTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrPerTimeCub o1, LengthCubPerMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrPerTimeCub o1, LengthCubPerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubPerTimeCub o1, LengthSqrPerTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubMassPerTimeSqr o1, LengthSqrPerTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(LengthSqrPerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeCubPerMassLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(LengthSqrPerTimeCub o1, TimeCubMassPerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(LengthSqrPerTimeCub o1, LengthCubPerMassTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubPerMassTimeCub o1, LengthSqrPerTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrPerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubMassPerTimeCub o1, LengthSqrPerTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrPerTimeCub is outside its bounds.");
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
    