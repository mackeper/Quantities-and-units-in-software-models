
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubLengthSqrPerMass : Quantity, IEquatable<TimeCubLengthSqrPerMass>, IComparable
  {  
    internal TimeCubLengthSqrPerMass(double value) : base(value, 2)
    {
      TimeCubLengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubLengthSqrPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubLengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubLengthSqrPerMass(TimeCubLengthSqrPerMass other) : base(other)
    {
      TimeCubLengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLengthSqrPerMass"))
    {
      switch(FakeDatabase.Units["TimeCubLengthSqrPerMass"])
      {
        case "secondcubcentimetersqrperkilogram": displayUnit_ = secondcubcentimetersqrperkilogram_; break;
        case "secondcubmillimetersqrperkilogram": displayUnit_ = secondcubmillimetersqrperkilogram_; break;
        case "secondcubmetersqrperkilogram": displayUnit_ = secondcubmetersqrperkilogram_; break;
        case "secondcubinchsqrperkilogram": displayUnit_ = secondcubinchsqrperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubcentimetersqrperkilogram_ = new Unit_("SecondCubCentimeterSqrPerKilogram", "s³ cm²/kg", 1.0, 0);
  private static Unit_ secondcubmillimetersqrperkilogram_ = new Unit_("SecondCubMillimeterSqrPerKilogram", "s³ mm²/kg", 0.010000000000000002, 0);
  private static Unit_ secondcubmetersqrperkilogram_ = new Unit_("SecondCubMeterSqrPerKilogram", "s³ m²/kg", 10000.0, 0);
  private static Unit_ secondcubinchsqrperkilogram_ = new Unit_("SecondCubInchSqrPerKilogram", "s³ in²/kg", 6.5536, 0);
  private static Unit_ platformUnit_ = secondcubcentimetersqrperkilogram_;
  private static Unit_ displayUnit_ = secondcubcentimetersqrperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubLengthSqrPerMass other && Equals(other);
  public bool Equals(TimeCubLengthSqrPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubLengthSqrPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubLengthSqrPerMass other)) throw new ArgumentException("Object is not a TimeCubLengthSqrPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => !(l1 == l2);
  public static bool operator <(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubLengthSqrPerMass l1, TimeCubLengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubLengthSqrPerMass FromSecondCubCentimeterSqrPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrPerMass((value + secondcubcentimetersqrperkilogram_.Offset) * secondcubcentimetersqrperkilogram_.Factor, minValue * secondcubcentimetersqrperkilogram_.Factor, maxValue * secondcubcentimetersqrperkilogram_.Factor);
  public static TimeCubLengthSqrPerMass FromSecondCubCentimeterSqrPerKilograms(double value) => new TimeCubLengthSqrPerMass((value + secondcubcentimetersqrperkilogram_.Offset) * secondcubcentimetersqrperkilogram_.Factor);
  public double GetValueInSecondCubCentimeterSqrPerKilograms() => (Value_ - secondcubcentimetersqrperkilogram_.Offset) / secondcubcentimetersqrperkilogram_.Factor;
  public static TimeCubLengthSqrPerMass FromSecondCubMillimeterSqrPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrPerMass((value + secondcubmillimetersqrperkilogram_.Offset) * secondcubmillimetersqrperkilogram_.Factor, minValue * secondcubmillimetersqrperkilogram_.Factor, maxValue * secondcubmillimetersqrperkilogram_.Factor);
  public static TimeCubLengthSqrPerMass FromSecondCubMillimeterSqrPerKilograms(double value) => new TimeCubLengthSqrPerMass((value + secondcubmillimetersqrperkilogram_.Offset) * secondcubmillimetersqrperkilogram_.Factor);
  public double GetValueInSecondCubMillimeterSqrPerKilograms() => (Value_ - secondcubmillimetersqrperkilogram_.Offset) / secondcubmillimetersqrperkilogram_.Factor;
  public static TimeCubLengthSqrPerMass FromSecondCubMeterSqrPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrPerMass((value + secondcubmetersqrperkilogram_.Offset) * secondcubmetersqrperkilogram_.Factor, minValue * secondcubmetersqrperkilogram_.Factor, maxValue * secondcubmetersqrperkilogram_.Factor);
  public static TimeCubLengthSqrPerMass FromSecondCubMeterSqrPerKilograms(double value) => new TimeCubLengthSqrPerMass((value + secondcubmetersqrperkilogram_.Offset) * secondcubmetersqrperkilogram_.Factor);
  public double GetValueInSecondCubMeterSqrPerKilograms() => (Value_ - secondcubmetersqrperkilogram_.Offset) / secondcubmetersqrperkilogram_.Factor;
  public static TimeCubLengthSqrPerMass FromSecondCubInchSqrPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrPerMass((value + secondcubinchsqrperkilogram_.Offset) * secondcubinchsqrperkilogram_.Factor, minValue * secondcubinchsqrperkilogram_.Factor, maxValue * secondcubinchsqrperkilogram_.Factor);
  public static TimeCubLengthSqrPerMass FromSecondCubInchSqrPerKilograms(double value) => new TimeCubLengthSqrPerMass((value + secondcubinchsqrperkilogram_.Offset) * secondcubinchsqrperkilogram_.Factor);
  public double GetValueInSecondCubInchSqrPerKilograms() => (Value_ - secondcubinchsqrperkilogram_.Offset) / secondcubinchsqrperkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeCubLengthSqrPerMass operator+(TimeCubLengthSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ + o2.Value_);
  public static TimeCubLengthSqrPerMass operator-(TimeCubLengthSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubLengthSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(TimeCubLengthSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubTimeSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(TimeCubLengthSqrPerMass o1, LengthCubTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubTimeCub o1, TimeCubLengthSqrPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeCubLengthSqrPerMass o1, MassPerLengthCubTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerLengthCubTimeCub o1, TimeCubLengthSqrPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCubLengthSqrPerMass o1, LengthCubTimeCubPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubTimeCubPerMass o1, TimeCubLengthSqrPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubLengthSqrPerMass is outside its bounds.");
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
    