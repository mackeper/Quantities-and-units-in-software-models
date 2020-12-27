
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrTimeSqrMass : Quantity, IEquatable<LengthSqrTimeSqrMass>, IComparable
  {  
    internal LengthSqrTimeSqrMass(double value) : base(value, 2)
    {
      LengthSqrTimeSqrMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrTimeSqrMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrTimeSqrMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrTimeSqrMass(LengthSqrTimeSqrMass other) : base(other)
    {
      LengthSqrTimeSqrMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrTimeSqrMass"))
    {
      switch(FakeDatabase.Units["LengthSqrTimeSqrMass"])
      {
        case "centimetersqrsecondsqrkilogram": displayUnit_ = centimetersqrsecondsqrkilogram_; break;
        case "millimetersqrsecondsqrkilogram": displayUnit_ = millimetersqrsecondsqrkilogram_; break;
        case "metersqrsecondsqrkilogram": displayUnit_ = metersqrsecondsqrkilogram_; break;
        case "inchsqrsecondsqrkilogram": displayUnit_ = inchsqrsecondsqrkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrsecondsqrkilogram_ = new Unit_("CentimeterSqrSecondSqrKilogram", "cm² s² kg", 1, 0);
  private static Unit_ millimetersqrsecondsqrkilogram_ = new Unit_("MillimeterSqrSecondSqrKilogram", "mm² s² kg", 0.010000000000000002, 0);
  private static Unit_ metersqrsecondsqrkilogram_ = new Unit_("MeterSqrSecondSqrKilogram", "m² s² kg", 10000, 0);
  private static Unit_ inchsqrsecondsqrkilogram_ = new Unit_("InchSqrSecondSqrKilogram", "in² s² kg", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrsecondsqrkilogram_;
  private static Unit_ displayUnit_ = centimetersqrsecondsqrkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrTimeSqrMass other && Equals(other);
  public bool Equals(LengthSqrTimeSqrMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrTimeSqrMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrTimeSqrMass other)) throw new ArgumentException("Object is not a LengthSqrTimeSqrMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => !(l1 == l2);
  public static bool operator <(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrTimeSqrMass l1, LengthSqrTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrTimeSqrMass FromCentimeterSqrSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrMass((value + centimetersqrsecondsqrkilogram_.Offset) * centimetersqrsecondsqrkilogram_.Factor, minValue * centimetersqrsecondsqrkilogram_.Factor, maxValue * centimetersqrsecondsqrkilogram_.Factor);
  public static LengthSqrTimeSqrMass FromCentimeterSqrSecondSqrKilograms(double value) => new LengthSqrTimeSqrMass((value + centimetersqrsecondsqrkilogram_.Offset) * centimetersqrsecondsqrkilogram_.Factor);
  public double GetValueInCentimeterSqrSecondSqrKilograms() => (Value_ - centimetersqrsecondsqrkilogram_.Offset) / centimetersqrsecondsqrkilogram_.Factor;
  public static LengthSqrTimeSqrMass FromMillimeterSqrSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrMass((value + millimetersqrsecondsqrkilogram_.Offset) * millimetersqrsecondsqrkilogram_.Factor, minValue * millimetersqrsecondsqrkilogram_.Factor, maxValue * millimetersqrsecondsqrkilogram_.Factor);
  public static LengthSqrTimeSqrMass FromMillimeterSqrSecondSqrKilograms(double value) => new LengthSqrTimeSqrMass((value + millimetersqrsecondsqrkilogram_.Offset) * millimetersqrsecondsqrkilogram_.Factor);
  public double GetValueInMillimeterSqrSecondSqrKilograms() => (Value_ - millimetersqrsecondsqrkilogram_.Offset) / millimetersqrsecondsqrkilogram_.Factor;
  public static LengthSqrTimeSqrMass FromMeterSqrSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrMass((value + metersqrsecondsqrkilogram_.Offset) * metersqrsecondsqrkilogram_.Factor, minValue * metersqrsecondsqrkilogram_.Factor, maxValue * metersqrsecondsqrkilogram_.Factor);
  public static LengthSqrTimeSqrMass FromMeterSqrSecondSqrKilograms(double value) => new LengthSqrTimeSqrMass((value + metersqrsecondsqrkilogram_.Offset) * metersqrsecondsqrkilogram_.Factor);
  public double GetValueInMeterSqrSecondSqrKilograms() => (Value_ - metersqrsecondsqrkilogram_.Offset) / metersqrsecondsqrkilogram_.Factor;
  public static LengthSqrTimeSqrMass FromInchSqrSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrTimeSqrMass((value + inchsqrsecondsqrkilogram_.Offset) * inchsqrsecondsqrkilogram_.Factor, minValue * inchsqrsecondsqrkilogram_.Factor, maxValue * inchsqrsecondsqrkilogram_.Factor);
  public static LengthSqrTimeSqrMass FromInchSqrSecondSqrKilograms(double value) => new LengthSqrTimeSqrMass((value + inchsqrsecondsqrkilogram_.Offset) * inchsqrsecondsqrkilogram_.Factor);
  public double GetValueInInchSqrSecondSqrKilograms() => (Value_ - inchsqrsecondsqrkilogram_.Offset) / inchsqrsecondsqrkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthSqrTimeSqrMass operator+(LengthSqrTimeSqrMass o1, LengthSqrTimeSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ + o2.Value_);
  public static LengthSqrTimeSqrMass operator-(LengthSqrTimeSqrMass o1, LengthSqrTimeSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrTimeSqrMass o1, LengthSqrTimeSqrMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrTimeSqrMass o1, LengthCubTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubTimeSqr o1, LengthSqrTimeSqrMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrTimeSqrMass o1, LengthCubMassPerTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubMassPerTime o1, LengthSqrTimeSqrMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrTimeSqrMass o1, LengthCubMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubMassTime o1, LengthSqrTimeSqrMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrTimeSqrMass o1, PerMassTimeSqrLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassTimeSqrLengthCub o1, LengthSqrTimeSqrMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrTimeSqrMass o1, PerLengthCubTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerLengthCubTimeCub o1, LengthSqrTimeSqrMass o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrTimeSqrMass o1, PerMassLengthSqrTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerMassLengthSqrTimeCub o1, LengthSqrTimeSqrMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(LengthSqrTimeSqrMass o1, TimeCubLengthSqrMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubLengthSqrMass o1, LengthSqrTimeSqrMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrTimeSqrMass o1, LengthCubTimeCub o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrTimeSqrMass o1, LengthCubTimeSqrMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubTimeSqrMass o1, LengthSqrTimeSqrMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrTimeSqrMass o1, PerMassLengthCubTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassLengthCubTimeCub o1, LengthSqrTimeSqrMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrTimeSqrMass o1, LengthCubTimeCubMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimeCubMass o1, LengthSqrTimeSqrMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrTimeSqrMass is outside its bounds.");
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
    