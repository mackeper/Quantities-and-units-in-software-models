
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrTimeSqrPerMass : Quantity, IEquatable<LengthSqrTimeSqrPerMass>, IComparable
  {  
    internal LengthSqrTimeSqrPerMass(double value) : base(value, 2)
    {
      LengthSqrTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrTimeSqrPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrTimeSqrPerMass(LengthSqrTimeSqrPerMass other) : base(other)
    {
      LengthSqrTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrTimeSqrPerMass"))
    {
      switch(FakeDatabase.Units["LengthSqrTimeSqrPerMass"])
      {
        case "centimetersqrsecondsqrperkilogram": displayUnit_ = centimetersqrsecondsqrperkilogram_; break;
        case "millimetersqrsecondsqrperkilogram": displayUnit_ = millimetersqrsecondsqrperkilogram_; break;
        case "metersqrsecondsqrperkilogram": displayUnit_ = metersqrsecondsqrperkilogram_; break;
        case "inchsqrsecondsqrperkilogram": displayUnit_ = inchsqrsecondsqrperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrsecondsqrperkilogram_ = new Unit_("CentimeterSqrSecondSqrPerKilogram", "cm² s²/kg", 1.0, 0);
  private static Unit_ millimetersqrsecondsqrperkilogram_ = new Unit_("MillimeterSqrSecondSqrPerKilogram", "mm² s²/kg", 0.010000000000000002, 0);
  private static Unit_ metersqrsecondsqrperkilogram_ = new Unit_("MeterSqrSecondSqrPerKilogram", "m² s²/kg", 10000.0, 0);
  private static Unit_ inchsqrsecondsqrperkilogram_ = new Unit_("InchSqrSecondSqrPerKilogram", "in² s²/kg", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrsecondsqrperkilogram_;
  private static Unit_ displayUnit_ = centimetersqrsecondsqrperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrTimeSqrPerMass other && Equals(other);
  public bool Equals(LengthSqrTimeSqrPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrTimeSqrPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrTimeSqrPerMass other)) throw new ArgumentException("Object is not a LengthSqrTimeSqrPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => !(l1 == l2);
  public static bool operator <(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrTimeSqrPerMass l1, LengthSqrTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrTimeSqrPerMass FromCentimeterSqrSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrPerMass((value + centimetersqrsecondsqrperkilogram_.Offset) * centimetersqrsecondsqrperkilogram_.Factor, minValue * centimetersqrsecondsqrperkilogram_.Factor, maxValue * centimetersqrsecondsqrperkilogram_.Factor);
  public static LengthSqrTimeSqrPerMass FromCentimeterSqrSecondSqrPerKilograms(double value) => new LengthSqrTimeSqrPerMass((value + centimetersqrsecondsqrperkilogram_.Offset) * centimetersqrsecondsqrperkilogram_.Factor);
  public double GetValueInCentimeterSqrSecondSqrPerKilograms() => (Value_ - centimetersqrsecondsqrperkilogram_.Offset) / centimetersqrsecondsqrperkilogram_.Factor;
  public static LengthSqrTimeSqrPerMass FromMillimeterSqrSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrPerMass((value + millimetersqrsecondsqrperkilogram_.Offset) * millimetersqrsecondsqrperkilogram_.Factor, minValue * millimetersqrsecondsqrperkilogram_.Factor, maxValue * millimetersqrsecondsqrperkilogram_.Factor);
  public static LengthSqrTimeSqrPerMass FromMillimeterSqrSecondSqrPerKilograms(double value) => new LengthSqrTimeSqrPerMass((value + millimetersqrsecondsqrperkilogram_.Offset) * millimetersqrsecondsqrperkilogram_.Factor);
  public double GetValueInMillimeterSqrSecondSqrPerKilograms() => (Value_ - millimetersqrsecondsqrperkilogram_.Offset) / millimetersqrsecondsqrperkilogram_.Factor;
  public static LengthSqrTimeSqrPerMass FromMeterSqrSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrPerMass((value + metersqrsecondsqrperkilogram_.Offset) * metersqrsecondsqrperkilogram_.Factor, minValue * metersqrsecondsqrperkilogram_.Factor, maxValue * metersqrsecondsqrperkilogram_.Factor);
  public static LengthSqrTimeSqrPerMass FromMeterSqrSecondSqrPerKilograms(double value) => new LengthSqrTimeSqrPerMass((value + metersqrsecondsqrperkilogram_.Offset) * metersqrsecondsqrperkilogram_.Factor);
  public double GetValueInMeterSqrSecondSqrPerKilograms() => (Value_ - metersqrsecondsqrperkilogram_.Offset) / metersqrsecondsqrperkilogram_.Factor;
  public static LengthSqrTimeSqrPerMass FromInchSqrSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrPerMass((value + inchsqrsecondsqrperkilogram_.Offset) * inchsqrsecondsqrperkilogram_.Factor, minValue * inchsqrsecondsqrperkilogram_.Factor, maxValue * inchsqrsecondsqrperkilogram_.Factor);
  public static LengthSqrTimeSqrPerMass FromInchSqrSecondSqrPerKilograms(double value) => new LengthSqrTimeSqrPerMass((value + inchsqrsecondsqrperkilogram_.Offset) * inchsqrsecondsqrperkilogram_.Factor);
  public double GetValueInInchSqrSecondSqrPerKilograms() => (Value_ - inchsqrsecondsqrperkilogram_.Offset) / inchsqrsecondsqrperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthSqrTimeSqrPerMass operator+(LengthSqrTimeSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ + o2.Value_);
  public static LengthSqrTimeSqrPerMass operator-(LengthSqrTimeSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrTimeSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrTimeSqrPerMass o1, LengthCubPerMassTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubPerMassTime o1, LengthSqrTimeSqrPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrTimeSqrPerMass o1, LengthCubTimePerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubTimePerMass o1, LengthSqrTimeSqrPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrTimeSqrPerMass o1, LengthCubTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrTimeSqrPerMass o1, PerLengthCubTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerLengthCubTimeCub o1, LengthSqrTimeSqrPerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrTimeSqrPerMass o1, MassPerTimeSqrLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerTimeSqrLengthCub o1, LengthSqrTimeSqrPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthSqrTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerLengthSqrTimeCub o1, LengthSqrTimeSqrPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubLengthSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrTimeSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubTimeSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrTimeSqrPerMass o1, LengthCubTimeCub o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubTimeCub o1, LengthSqrTimeSqrPerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerLengthCubTimeCub o1, LengthSqrTimeSqrPerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrTimeSqrPerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimeCubPerMass o1, LengthSqrTimeSqrPerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrTimeSqrPerMass is outside its bounds.");
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
    