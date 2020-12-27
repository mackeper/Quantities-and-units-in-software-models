
// GENERATE FILE! (27/05/2020 08:55:49)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerLengthSqrTimeCub : Quantity, IEquatable<MassPerLengthSqrTimeCub>, IComparable
  {  
    internal MassPerLengthSqrTimeCub(double value) : base(value, 2)
    {
      MassPerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerLengthSqrTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerLengthSqrTimeCub(MassPerLengthSqrTimeCub other) : base(other)
    {
      MassPerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthSqrTimeCub"))
    {
      switch(FakeDatabase.Units["MassPerLengthSqrTimeCub"])
      {
        case "kilogrampercentimetersqrsecondcub": displayUnit_ = kilogrampercentimetersqrsecondcub_; break;
        case "kilogrampermillimetersqrsecondcub": displayUnit_ = kilogrampermillimetersqrsecondcub_; break;
        case "kilogrampermetersqrsecondcub": displayUnit_ = kilogrampermetersqrsecondcub_; break;
        case "kilogramperinchsqrsecondcub": displayUnit_ = kilogramperinchsqrsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampercentimetersqrsecondcub_ = new Unit_("KilogramPerCentimeterSqrSecondCub", "kg/cm² s³", 1.0, 0);
  private static Unit_ kilogrampermillimetersqrsecondcub_ = new Unit_("KilogramPerMillimeterSqrSecondCub", "kg/mm² s³", 99.99999999999999, 0);
  private static Unit_ kilogrampermetersqrsecondcub_ = new Unit_("KilogramPerMeterSqrSecondCub", "kg/m² s³", 0.0001, 0);
  private static Unit_ kilogramperinchsqrsecondcub_ = new Unit_("KilogramPerInchSqrSecondCub", "kg/in² s³", 0.152587890625, 0);
  private static Unit_ platformUnit_ = kilogrampercentimetersqrsecondcub_;
  private static Unit_ displayUnit_ = kilogrampercentimetersqrsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerLengthSqrTimeCub other && Equals(other);
  public bool Equals(MassPerLengthSqrTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerLengthSqrTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerLengthSqrTimeCub other)) throw new ArgumentException("Object is not a MassPerLengthSqrTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => !(l1 == l2);
  public static bool operator <(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerLengthSqrTimeCub l1, MassPerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerLengthSqrTimeCub FromKilogramPerCentimeterSqrSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeCub((value + kilogrampercentimetersqrsecondcub_.Offset) * kilogrampercentimetersqrsecondcub_.Factor, minValue * kilogrampercentimetersqrsecondcub_.Factor, maxValue * kilogrampercentimetersqrsecondcub_.Factor);
  public static MassPerLengthSqrTimeCub FromKilogramPerCentimeterSqrSecondCubs(double value) => new MassPerLengthSqrTimeCub((value + kilogrampercentimetersqrsecondcub_.Offset) * kilogrampercentimetersqrsecondcub_.Factor);
  public double GetValueInKilogramPerCentimeterSqrSecondCubs() => (Value_ - kilogrampercentimetersqrsecondcub_.Offset) / kilogrampercentimetersqrsecondcub_.Factor;
  public static MassPerLengthSqrTimeCub FromKilogramPerMillimeterSqrSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeCub((value + kilogrampermillimetersqrsecondcub_.Offset) * kilogrampermillimetersqrsecondcub_.Factor, minValue * kilogrampermillimetersqrsecondcub_.Factor, maxValue * kilogrampermillimetersqrsecondcub_.Factor);
  public static MassPerLengthSqrTimeCub FromKilogramPerMillimeterSqrSecondCubs(double value) => new MassPerLengthSqrTimeCub((value + kilogrampermillimetersqrsecondcub_.Offset) * kilogrampermillimetersqrsecondcub_.Factor);
  public double GetValueInKilogramPerMillimeterSqrSecondCubs() => (Value_ - kilogrampermillimetersqrsecondcub_.Offset) / kilogrampermillimetersqrsecondcub_.Factor;
  public static MassPerLengthSqrTimeCub FromKilogramPerMeterSqrSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeCub((value + kilogrampermetersqrsecondcub_.Offset) * kilogrampermetersqrsecondcub_.Factor, minValue * kilogrampermetersqrsecondcub_.Factor, maxValue * kilogrampermetersqrsecondcub_.Factor);
  public static MassPerLengthSqrTimeCub FromKilogramPerMeterSqrSecondCubs(double value) => new MassPerLengthSqrTimeCub((value + kilogrampermetersqrsecondcub_.Offset) * kilogrampermetersqrsecondcub_.Factor);
  public double GetValueInKilogramPerMeterSqrSecondCubs() => (Value_ - kilogrampermetersqrsecondcub_.Offset) / kilogrampermetersqrsecondcub_.Factor;
  public static MassPerLengthSqrTimeCub FromKilogramPerInchSqrSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeCub((value + kilogramperinchsqrsecondcub_.Offset) * kilogramperinchsqrsecondcub_.Factor, minValue * kilogramperinchsqrsecondcub_.Factor, maxValue * kilogramperinchsqrsecondcub_.Factor);
  public static MassPerLengthSqrTimeCub FromKilogramPerInchSqrSecondCubs(double value) => new MassPerLengthSqrTimeCub((value + kilogramperinchsqrsecondcub_.Offset) * kilogramperinchsqrsecondcub_.Factor);
  public double GetValueInKilogramPerInchSqrSecondCubs() => (Value_ - kilogramperinchsqrsecondcub_.Offset) / kilogramperinchsqrsecondcub_.Factor;

#endregion

#region arithmetic
  public static MassPerLengthSqrTimeCub operator+(MassPerLengthSqrTimeCub o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ + o2.Value_);
  public static MassPerLengthSqrTimeCub operator-(MassPerLengthSqrTimeCub o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerLengthSqrTimeCub o1, MassPerLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassPerLengthSqrTimeCub o1, TimeCubLengthSqrPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeCubLengthSqrPerMass o1, MassPerLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassPerLengthSqrTimeCub o1, LengthCubTimeSqrPerMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubTimeSqrPerMass o1, MassPerLengthSqrTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(MassPerLengthSqrTimeCub o1, LengthCubTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubTimeCub o1, MassPerLengthSqrTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static Length operator/(MassPerLengthSqrTimeCub o1, MassPerLengthCubTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerLengthCubTimeCub o1, MassPerLengthSqrTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Length operator*(MassPerLengthSqrTimeCub o1, LengthCubTimeCubPerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimeCubPerMass o1, MassPerLengthSqrTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerLengthSqrTimeCub is outside its bounds.");
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
    