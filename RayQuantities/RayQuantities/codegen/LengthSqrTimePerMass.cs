
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrTimePerMass : Quantity, IEquatable<LengthSqrTimePerMass>, IComparable
  {  
    internal LengthSqrTimePerMass(double value) : base(value, 2)
    {
      LengthSqrTimePerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrTimePerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrTimePerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrTimePerMass(LengthSqrTimePerMass other) : base(other)
    {
      LengthSqrTimePerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrTimePerMass"))
    {
      switch(FakeDatabase.Units["LengthSqrTimePerMass"])
      {
        case "centimetersqrsecondperkilogram": displayUnit_ = centimetersqrsecondperkilogram_; break;
        case "millimetersqrsecondperkilogram": displayUnit_ = millimetersqrsecondperkilogram_; break;
        case "metersqrsecondperkilogram": displayUnit_ = metersqrsecondperkilogram_; break;
        case "inchsqrsecondperkilogram": displayUnit_ = inchsqrsecondperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrsecondperkilogram_ = new Unit_("CentimeterSqrSecondPerKilogram", "cm� s/kg", 1.0, 0);
  private static Unit_ millimetersqrsecondperkilogram_ = new Unit_("MillimeterSqrSecondPerKilogram", "mm� s/kg", 0.010000000000000002, 0);
  private static Unit_ metersqrsecondperkilogram_ = new Unit_("MeterSqrSecondPerKilogram", "m� s/kg", 10000.0, 0);
  private static Unit_ inchsqrsecondperkilogram_ = new Unit_("InchSqrSecondPerKilogram", "in� s/kg", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrsecondperkilogram_;
  private static Unit_ displayUnit_ = centimetersqrsecondperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrTimePerMass other && Equals(other);
  public bool Equals(LengthSqrTimePerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrTimePerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrTimePerMass other)) throw new ArgumentException("Object is not a LengthSqrTimePerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => !(l1 == l2);
  public static bool operator <(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrTimePerMass l1, LengthSqrTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrTimePerMass FromCentimeterSqrSecondPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimePerMass((value + centimetersqrsecondperkilogram_.Offset) * centimetersqrsecondperkilogram_.Factor, minValue * centimetersqrsecondperkilogram_.Factor, maxValue * centimetersqrsecondperkilogram_.Factor);
  public static LengthSqrTimePerMass FromCentimeterSqrSecondPerKilograms(double value) => new LengthSqrTimePerMass((value + centimetersqrsecondperkilogram_.Offset) * centimetersqrsecondperkilogram_.Factor);
  public double GetValueInCentimeterSqrSecondPerKilograms() => (Value_ - centimetersqrsecondperkilogram_.Offset) / centimetersqrsecondperkilogram_.Factor;
  public static LengthSqrTimePerMass FromMillimeterSqrSecondPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimePerMass((value + millimetersqrsecondperkilogram_.Offset) * millimetersqrsecondperkilogram_.Factor, minValue * millimetersqrsecondperkilogram_.Factor, maxValue * millimetersqrsecondperkilogram_.Factor);
  public static LengthSqrTimePerMass FromMillimeterSqrSecondPerKilograms(double value) => new LengthSqrTimePerMass((value + millimetersqrsecondperkilogram_.Offset) * millimetersqrsecondperkilogram_.Factor);
  public double GetValueInMillimeterSqrSecondPerKilograms() => (Value_ - millimetersqrsecondperkilogram_.Offset) / millimetersqrsecondperkilogram_.Factor;
  public static LengthSqrTimePerMass FromMeterSqrSecondPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimePerMass((value + metersqrsecondperkilogram_.Offset) * metersqrsecondperkilogram_.Factor, minValue * metersqrsecondperkilogram_.Factor, maxValue * metersqrsecondperkilogram_.Factor);
  public static LengthSqrTimePerMass FromMeterSqrSecondPerKilograms(double value) => new LengthSqrTimePerMass((value + metersqrsecondperkilogram_.Offset) * metersqrsecondperkilogram_.Factor);
  public double GetValueInMeterSqrSecondPerKilograms() => (Value_ - metersqrsecondperkilogram_.Offset) / metersqrsecondperkilogram_.Factor;
  public static LengthSqrTimePerMass FromInchSqrSecondPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimePerMass((value + inchsqrsecondperkilogram_.Offset) * inchsqrsecondperkilogram_.Factor, minValue * inchsqrsecondperkilogram_.Factor, maxValue * inchsqrsecondperkilogram_.Factor);
  public static LengthSqrTimePerMass FromInchSqrSecondPerKilograms(double value) => new LengthSqrTimePerMass((value + inchsqrsecondperkilogram_.Offset) * inchsqrsecondperkilogram_.Factor);
  public double GetValueInInchSqrSecondPerKilograms() => (Value_ - inchsqrsecondperkilogram_.Offset) / inchsqrsecondperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthSqrTimePerMass operator+(LengthSqrTimePerMass o1, LengthSqrTimePerMass o2) => new LengthSqrTimePerMass(o1.Value_ + o2.Value_);
  public static LengthSqrTimePerMass operator-(LengthSqrTimePerMass o1, LengthSqrTimePerMass o2) => new LengthSqrTimePerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrTimePerMass o1, LengthSqrTimePerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(LengthSqrTimePerMass o1, QDose o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(QDose o1, LengthSqrTimePerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrTimePerMass o1, LengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrTimeSqr o1, LengthSqrTimePerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrTimePerMass o1, LengthCubPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubPerMass o1, LengthSqrTimePerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(LengthSqrTimePerMass o1, LengthCubPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthCubPerTime o1, LengthSqrTimePerMass o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrTimePerMass o1, LengthCubTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubTime o1, LengthSqrTimePerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrTimePerMass o1, PerTimeSqrLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerTimeSqrLengthCub o1, LengthSqrTimePerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthSqrTimePerMass o1, TimeSqrPerLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrPerLengthCub o1, LengthSqrTimePerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrTimePerMass o1, MassPerTimeLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerTimeLengthCub o1, LengthSqrTimePerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrTimePerMass o1, MassTimePerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(MassTimePerLengthCub o1, LengthSqrTimePerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthSqrTimePerMass o1, PerLengthSqrTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthSqrTimeCub o1, LengthSqrTimePerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrTimePerMass o1, MassPerLengthSqrTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerLengthSqrTimeSqr o1, LengthSqrTimePerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthSqrTimePerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrMassPerLengthSqr o1, LengthSqrTimePerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthSqrTimePerMass o1, TimeCubPerLengthMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubPerLengthMass o1, LengthSqrTimePerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthSqrTimePerMass o1, MassPerLengthTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(MassPerLengthTimeCub o1, LengthSqrTimePerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthSqrTimePerMass o1, TimeCubLengthPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubLengthPerMass o1, LengthSqrTimePerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthSqrTimePerMass o1, LengthMassPerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthMassPerTimeCub o1, LengthSqrTimePerMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthSqrTimePerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthSqrTimePerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthSqrTimePerMass o1, LengthSqrTimeSqrPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrTimeSqrPerMass o1, LengthSqrTimePerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthSqrTimePerMass o1, TimeCubLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubLengthSqr o1, LengthSqrTimePerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrTimePerMass o1, LengthCubPerMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubPerMassTime o1, LengthSqrTimePerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrTimePerMass o1, LengthCubTimePerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubTimePerMass o1, LengthSqrTimePerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(LengthSqrTimePerMass o1, LengthCubPerTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthCubPerTimeSqr o1, LengthSqrTimePerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrTimePerMass o1, LengthCubTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubTimeSqr o1, LengthSqrTimePerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthSqrTimePerMass o1, PerLengthCubTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerLengthCubTimeCub o1, LengthSqrTimePerMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrTimePerMass o1, MassPerTimeSqrLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerTimeSqrLengthCub o1, LengthSqrTimePerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthSqrTimePerMass o1, TimeSqrMassPerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrTimePerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthSqrTimePerMass o1, MassPerLengthSqrTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(MassPerLengthSqrTimeCub o1, LengthSqrTimePerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrTimePerMass o1, TimeCubLengthSqrPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLengthSqrPerMass o1, LengthSqrTimePerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrTimePerMass o1, LengthCubPerMassTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthSqrTimePerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrTimePerMass o1, LengthCubTimeSqrPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimeSqrPerMass o1, LengthSqrTimePerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthSqrTimePerMass o1, LengthCubTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubTimeCub o1, LengthSqrTimePerMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrTimePerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthSqrTimePerMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrTimePerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeCubPerMass o1, LengthSqrTimePerMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrTimePerMass is outside its bounds.");
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
    