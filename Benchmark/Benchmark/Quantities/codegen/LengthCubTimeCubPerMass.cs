
// GENERATE FILE! (27/05/2020 08:55:49)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthCubTimeCubPerMass : Quantity, IEquatable<LengthCubTimeCubPerMass>, IComparable
  {  
    internal LengthCubTimeCubPerMass(double value) : base(value, 2)
    {
      LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthCubTimeCubPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthCubTimeCubPerMass(LengthCubTimeCubPerMass other) : base(other)
    {
      LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeCubPerMass"))
    {
      switch(FakeDatabase.Units["LengthCubTimeCubPerMass"])
      {
        case "centimetercubsecondcubperkilogram": displayUnit_ = centimetercubsecondcubperkilogram_; break;
        case "millimetercubsecondcubperkilogram": displayUnit_ = millimetercubsecondcubperkilogram_; break;
        case "metercubsecondcubperkilogram": displayUnit_ = metercubsecondcubperkilogram_; break;
        case "inchcubsecondcubperkilogram": displayUnit_ = inchcubsecondcubperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercubsecondcubperkilogram_ = new Unit_("CentimeterCubSecondCubPerKilogram", "cm³ s³/kg", 1.0, 0);
  private static Unit_ millimetercubsecondcubperkilogram_ = new Unit_("MillimeterCubSecondCubPerKilogram", "mm³ s³/kg", 0.0010000000000000002, 0);
  private static Unit_ metercubsecondcubperkilogram_ = new Unit_("MeterCubSecondCubPerKilogram", "m³ s³/kg", 1000000.0, 0);
  private static Unit_ inchcubsecondcubperkilogram_ = new Unit_("InchCubSecondCubPerKilogram", "in³ s³/kg", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercubsecondcubperkilogram_;
  private static Unit_ displayUnit_ = centimetercubsecondcubperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthCubTimeCubPerMass other && Equals(other);
  public bool Equals(LengthCubTimeCubPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthCubTimeCubPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthCubTimeCubPerMass other)) throw new ArgumentException("Object is not a LengthCubTimeCubPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => !(l1 == l2);
  public static bool operator <(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthCubTimeCubPerMass FromCentimeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass((value + centimetercubsecondcubperkilogram_.Offset) * centimetercubsecondcubperkilogram_.Factor, minValue * centimetercubsecondcubperkilogram_.Factor, maxValue * centimetercubsecondcubperkilogram_.Factor);
  public static LengthCubTimeCubPerMass FromCentimeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass((value + centimetercubsecondcubperkilogram_.Offset) * centimetercubsecondcubperkilogram_.Factor);
  public double GetValueInCentimeterCubSecondCubPerKilograms() => (Value_ - centimetercubsecondcubperkilogram_.Offset) / centimetercubsecondcubperkilogram_.Factor;
  public static LengthCubTimeCubPerMass FromMillimeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass((value + millimetercubsecondcubperkilogram_.Offset) * millimetercubsecondcubperkilogram_.Factor, minValue * millimetercubsecondcubperkilogram_.Factor, maxValue * millimetercubsecondcubperkilogram_.Factor);
  public static LengthCubTimeCubPerMass FromMillimeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass((value + millimetercubsecondcubperkilogram_.Offset) * millimetercubsecondcubperkilogram_.Factor);
  public double GetValueInMillimeterCubSecondCubPerKilograms() => (Value_ - millimetercubsecondcubperkilogram_.Offset) / millimetercubsecondcubperkilogram_.Factor;
  public static LengthCubTimeCubPerMass FromMeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass((value + metercubsecondcubperkilogram_.Offset) * metercubsecondcubperkilogram_.Factor, minValue * metercubsecondcubperkilogram_.Factor, maxValue * metercubsecondcubperkilogram_.Factor);
  public static LengthCubTimeCubPerMass FromMeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass((value + metercubsecondcubperkilogram_.Offset) * metercubsecondcubperkilogram_.Factor);
  public double GetValueInMeterCubSecondCubPerKilograms() => (Value_ - metercubsecondcubperkilogram_.Offset) / metercubsecondcubperkilogram_.Factor;
  public static LengthCubTimeCubPerMass FromInchCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass((value + inchcubsecondcubperkilogram_.Offset) * inchcubsecondcubperkilogram_.Factor, minValue * inchcubsecondcubperkilogram_.Factor, maxValue * inchcubsecondcubperkilogram_.Factor);
  public static LengthCubTimeCubPerMass FromInchCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass((value + inchcubsecondcubperkilogram_.Offset) * inchcubsecondcubperkilogram_.Factor);
  public double GetValueInInchCubSecondCubPerKilograms() => (Value_ - inchcubsecondcubperkilogram_.Offset) / inchcubsecondcubperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthCubTimeCubPerMass operator+(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ + o2.Value_);
  public static LengthCubTimeCubPerMass operator-(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthCubTimeCubPerMass is outside its bounds.");
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
    