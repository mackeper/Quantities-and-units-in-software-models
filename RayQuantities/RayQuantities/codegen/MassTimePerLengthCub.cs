
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassTimePerLengthCub : Quantity, IEquatable<MassTimePerLengthCub>, IComparable
  {  
    internal MassTimePerLengthCub(double value) : base(value, 2)
    {
      MassTimePerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassTimePerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassTimePerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassTimePerLengthCub(MassTimePerLengthCub other) : base(other)
    {
      MassTimePerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassTimePerLengthCub"))
    {
      switch(FakeDatabase.Units["MassTimePerLengthCub"])
      {
        case "kilogramsecondpercentimetercub": displayUnit_ = kilogramsecondpercentimetercub_; break;
        case "kilogramsecondpermillimetercub": displayUnit_ = kilogramsecondpermillimetercub_; break;
        case "kilogramsecondpermetercub": displayUnit_ = kilogramsecondpermetercub_; break;
        case "kilogramsecondperinchcub": displayUnit_ = kilogramsecondperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogramsecondpercentimetercub_ = new Unit_("KilogramSecondPerCentimeterCub", "kg s/cm�", 1.0, 0);
  private static Unit_ kilogramsecondpermillimetercub_ = new Unit_("KilogramSecondPerMillimeterCub", "kg s/mm�", 999.9999999999998, 0);
  private static Unit_ kilogramsecondpermetercub_ = new Unit_("KilogramSecondPerMeterCub", "kg s/m�", 1e-06, 0);
  private static Unit_ kilogramsecondperinchcub_ = new Unit_("KilogramSecondPerInchCub", "kg s/in�", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = kilogramsecondpercentimetercub_;
  private static Unit_ displayUnit_ = kilogramsecondpercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassTimePerLengthCub other && Equals(other);
  public bool Equals(MassTimePerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassTimePerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassTimePerLengthCub other)) throw new ArgumentException("Object is not a MassTimePerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => !(l1 == l2);
  public static bool operator <(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassTimePerLengthCub l1, MassTimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassTimePerLengthCub FromKilogramSecondPerCentimeterCubs(double value, double minValue, double maxValue) => new MassTimePerLengthCub((value + kilogramsecondpercentimetercub_.Offset) * kilogramsecondpercentimetercub_.Factor, minValue * kilogramsecondpercentimetercub_.Factor, maxValue * kilogramsecondpercentimetercub_.Factor);
  public static MassTimePerLengthCub FromKilogramSecondPerCentimeterCubs(double value) => new MassTimePerLengthCub((value + kilogramsecondpercentimetercub_.Offset) * kilogramsecondpercentimetercub_.Factor);
  public double GetValueInKilogramSecondPerCentimeterCubs() => (Value_ - kilogramsecondpercentimetercub_.Offset) / kilogramsecondpercentimetercub_.Factor;
  public static MassTimePerLengthCub FromKilogramSecondPerMillimeterCubs(double value, double minValue, double maxValue) => new MassTimePerLengthCub((value + kilogramsecondpermillimetercub_.Offset) * kilogramsecondpermillimetercub_.Factor, minValue * kilogramsecondpermillimetercub_.Factor, maxValue * kilogramsecondpermillimetercub_.Factor);
  public static MassTimePerLengthCub FromKilogramSecondPerMillimeterCubs(double value) => new MassTimePerLengthCub((value + kilogramsecondpermillimetercub_.Offset) * kilogramsecondpermillimetercub_.Factor);
  public double GetValueInKilogramSecondPerMillimeterCubs() => (Value_ - kilogramsecondpermillimetercub_.Offset) / kilogramsecondpermillimetercub_.Factor;
  public static MassTimePerLengthCub FromKilogramSecondPerMeterCubs(double value, double minValue, double maxValue) => new MassTimePerLengthCub((value + kilogramsecondpermetercub_.Offset) * kilogramsecondpermetercub_.Factor, minValue * kilogramsecondpermetercub_.Factor, maxValue * kilogramsecondpermetercub_.Factor);
  public static MassTimePerLengthCub FromKilogramSecondPerMeterCubs(double value) => new MassTimePerLengthCub((value + kilogramsecondpermetercub_.Offset) * kilogramsecondpermetercub_.Factor);
  public double GetValueInKilogramSecondPerMeterCubs() => (Value_ - kilogramsecondpermetercub_.Offset) / kilogramsecondpermetercub_.Factor;
  public static MassTimePerLengthCub FromKilogramSecondPerInchCubs(double value, double minValue, double maxValue) => new MassTimePerLengthCub((value + kilogramsecondperinchcub_.Offset) * kilogramsecondperinchcub_.Factor, minValue * kilogramsecondperinchcub_.Factor, maxValue * kilogramsecondperinchcub_.Factor);
  public static MassTimePerLengthCub FromKilogramSecondPerInchCubs(double value) => new MassTimePerLengthCub((value + kilogramsecondperinchcub_.Offset) * kilogramsecondperinchcub_.Factor);
  public double GetValueInKilogramSecondPerInchCubs() => (Value_ - kilogramsecondperinchcub_.Offset) / kilogramsecondperinchcub_.Factor;

#endregion

#region arithmetic
  public static MassTimePerLengthCub operator+(MassTimePerLengthCub o1, MassTimePerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ + o2.Value_);
  public static MassTimePerLengthCub operator-(MassTimePerLengthCub o1, MassTimePerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassTimePerLengthCub o1, MassTimePerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(MassTimePerLengthCub o1, TimeCubPerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubPerLengthSqr o1, MassTimePerLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(MassTimePerLengthCub o1, MassPerLengthSqrTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(MassPerLengthSqrTimeSqr o1, MassTimePerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(MassTimePerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrMassPerLengthSqr o1, MassTimePerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(MassTimePerLengthCub o1, TimeCubMassPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubMassPerLength o1, MassTimePerLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(MassTimePerLengthCub o1, LengthPerMassTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(LengthPerMassTimeCub o1, MassTimePerLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(MassTimePerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrPerMassTimeSqr o1, MassTimePerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(MassTimePerLengthCub o1, LengthSqrTimeSqrPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(LengthSqrTimeSqrPerMass o1, MassTimePerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(MassTimePerLengthCub o1, LengthSqrPerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(LengthSqrPerTimeCub o1, MassTimePerLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(MassTimePerLengthCub o1, LengthCubPerMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerMassTime o1, MassTimePerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(MassTimePerLengthCub o1, LengthCubTimePerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthCubTimePerMass o1, MassTimePerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(MassTimePerLengthCub o1, LengthCubPerTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubPerTimeSqr o1, MassTimePerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(MassTimePerLengthCub o1, LengthCubTimeSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthCubTimeSqr o1, MassTimePerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(MassTimePerLengthCub o1, TimeCubPerLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubPerLengthCub o1, MassTimePerLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(MassTimePerLengthCub o1, MassPerTimeSqrLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(MassPerTimeSqrLengthCub o1, MassTimePerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(MassTimePerLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrMassPerLengthCub o1, MassTimePerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(MassTimePerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubMassPerLengthSqr o1, MassTimePerLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(MassTimePerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthSqrPerMassTimeCub o1, MassTimePerLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(MassTimePerLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubPerMassTimeSqr o1, MassTimePerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(MassTimePerLengthCub o1, LengthCubTimeSqrPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthCubTimeSqrPerMass o1, MassTimePerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(MassTimePerLengthCub o1, LengthCubPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthCubPerTimeCub o1, MassTimePerLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(MassTimePerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubMassPerLengthCub o1, MassTimePerLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(MassTimePerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthCubPerMassTimeCub o1, MassTimePerLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassTimePerLengthCub is outside its bounds.");
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
    