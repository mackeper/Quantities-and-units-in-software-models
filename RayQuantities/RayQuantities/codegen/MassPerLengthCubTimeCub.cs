
// GENERATED FILE! (20/10/2020 20:11:32)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerLengthCubTimeCub : Quantity, IEquatable<MassPerLengthCubTimeCub>, IComparable
  {  
    internal MassPerLengthCubTimeCub(double value) : base(value, 2)
    {
      MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerLengthCubTimeCub(MassPerLengthCubTimeCub other) : base(other)
    {
      MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthCubTimeCub"))
    {
      switch(FakeDatabase.Units["MassPerLengthCubTimeCub"])
      {
        case "kilogrampercentimetercubsecondcub": displayUnit_ = kilogrampercentimetercubsecondcub_; break;
        case "kilogrampermillimetercubsecondcub": displayUnit_ = kilogrampermillimetercubsecondcub_; break;
        case "kilogrampermetercubsecondcub": displayUnit_ = kilogrampermetercubsecondcub_; break;
        case "kilogramperinchcubsecondcub": displayUnit_ = kilogramperinchcubsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampercentimetercubsecondcub_ = new Unit_("KilogramPerCentimeterCubSecondCub", "kg/cm³ s³", 1.0, 0);
  private static Unit_ kilogrampermillimetercubsecondcub_ = new Unit_("KilogramPerMillimeterCubSecondCub", "kg/mm³ s³", 999.9999999999998, 0);
  private static Unit_ kilogrampermetercubsecondcub_ = new Unit_("KilogramPerMeterCubSecondCub", "kg/m³ s³", 1e-06, 0);
  private static Unit_ kilogramperinchcubsecondcub_ = new Unit_("KilogramPerInchCubSecondCub", "kg/in³ s³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = kilogrampercentimetercubsecondcub_;
  private static Unit_ displayUnit_ = kilogrampercentimetercubsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerLengthCubTimeCub other && Equals(other);
  public bool Equals(MassPerLengthCubTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerLengthCubTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerLengthCubTimeCub other)) throw new ArgumentException("Object is not a MassPerLengthCubTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => !(l1 == l2);
  public static bool operator <(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerLengthCubTimeCub FromKilogramPerCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub((value + kilogrampercentimetercubsecondcub_.Offset) * kilogrampercentimetercubsecondcub_.Factor, minValue * kilogrampercentimetercubsecondcub_.Factor, maxValue * kilogrampercentimetercubsecondcub_.Factor);
  public static MassPerLengthCubTimeCub FromKilogramPerCentimeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub((value + kilogrampercentimetercubsecondcub_.Offset) * kilogrampercentimetercubsecondcub_.Factor);
  public double GetValueInKilogramPerCentimeterCubSecondCubs() => (Value_ - kilogrampercentimetercubsecondcub_.Offset) / kilogrampercentimetercubsecondcub_.Factor;
  public static MassPerLengthCubTimeCub FromKilogramPerMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub((value + kilogrampermillimetercubsecondcub_.Offset) * kilogrampermillimetercubsecondcub_.Factor, minValue * kilogrampermillimetercubsecondcub_.Factor, maxValue * kilogrampermillimetercubsecondcub_.Factor);
  public static MassPerLengthCubTimeCub FromKilogramPerMillimeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub((value + kilogrampermillimetercubsecondcub_.Offset) * kilogrampermillimetercubsecondcub_.Factor);
  public double GetValueInKilogramPerMillimeterCubSecondCubs() => (Value_ - kilogrampermillimetercubsecondcub_.Offset) / kilogrampermillimetercubsecondcub_.Factor;
  public static MassPerLengthCubTimeCub FromKilogramPerMeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub((value + kilogrampermetercubsecondcub_.Offset) * kilogrampermetercubsecondcub_.Factor, minValue * kilogrampermetercubsecondcub_.Factor, maxValue * kilogrampermetercubsecondcub_.Factor);
  public static MassPerLengthCubTimeCub FromKilogramPerMeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub((value + kilogrampermetercubsecondcub_.Offset) * kilogrampermetercubsecondcub_.Factor);
  public double GetValueInKilogramPerMeterCubSecondCubs() => (Value_ - kilogrampermetercubsecondcub_.Offset) / kilogrampermetercubsecondcub_.Factor;
  public static MassPerLengthCubTimeCub FromKilogramPerInchCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub((value + kilogramperinchcubsecondcub_.Offset) * kilogramperinchcubsecondcub_.Factor, minValue * kilogramperinchcubsecondcub_.Factor, maxValue * kilogramperinchcubsecondcub_.Factor);
  public static MassPerLengthCubTimeCub FromKilogramPerInchCubSecondCubs(double value) => new MassPerLengthCubTimeCub((value + kilogramperinchcubsecondcub_.Offset) * kilogramperinchcubsecondcub_.Factor);
  public double GetValueInKilogramPerInchCubSecondCubs() => (Value_ - kilogramperinchcubsecondcub_.Offset) / kilogramperinchcubsecondcub_.Factor;

#endregion

#region arithmetic
  public static MassPerLengthCubTimeCub operator+(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ + o2.Value_);
  public static MassPerLengthCubTimeCub operator-(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassPerLengthCubTimeCub o1, LengthCubTimeCubPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubTimeCubPerMass o1, MassPerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerLengthCubTimeCub is outside its bounds.");
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
    