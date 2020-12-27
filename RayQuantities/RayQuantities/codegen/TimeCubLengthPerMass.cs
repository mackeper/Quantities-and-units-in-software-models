
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubLengthPerMass : Quantity, IEquatable<TimeCubLengthPerMass>, IComparable
  {  
    internal TimeCubLengthPerMass(double value) : base(value, 2)
    {
      TimeCubLengthPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubLengthPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubLengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubLengthPerMass(TimeCubLengthPerMass other) : base(other)
    {
      TimeCubLengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLengthPerMass"))
    {
      switch(FakeDatabase.Units["TimeCubLengthPerMass"])
      {
        case "secondcubcentimeterperkilogram": displayUnit_ = secondcubcentimeterperkilogram_; break;
        case "secondcubmillimeterperkilogram": displayUnit_ = secondcubmillimeterperkilogram_; break;
        case "secondcubmeterperkilogram": displayUnit_ = secondcubmeterperkilogram_; break;
        case "secondcubinchperkilogram": displayUnit_ = secondcubinchperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubcentimeterperkilogram_ = new Unit_("SecondCubCentimeterPerKilogram", "s³ cm/kg", 1.0, 0);
  private static Unit_ secondcubmillimeterperkilogram_ = new Unit_("SecondCubMillimeterPerKilogram", "s³ mm/kg", 0.1, 0);
  private static Unit_ secondcubmeterperkilogram_ = new Unit_("SecondCubMeterPerKilogram", "s³ m/kg", 100.0, 0);
  private static Unit_ secondcubinchperkilogram_ = new Unit_("SecondCubInchPerKilogram", "s³ in/kg", 2.56, 0);
  private static Unit_ platformUnit_ = secondcubcentimeterperkilogram_;
  private static Unit_ displayUnit_ = secondcubcentimeterperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubLengthPerMass other && Equals(other);
  public bool Equals(TimeCubLengthPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubLengthPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubLengthPerMass other)) throw new ArgumentException("Object is not a TimeCubLengthPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => !(l1 == l2);
  public static bool operator <(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubLengthPerMass l1, TimeCubLengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubLengthPerMass FromSecondCubCentimeterPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthPerMass((value + secondcubcentimeterperkilogram_.Offset) * secondcubcentimeterperkilogram_.Factor, minValue * secondcubcentimeterperkilogram_.Factor, maxValue * secondcubcentimeterperkilogram_.Factor);
  public static TimeCubLengthPerMass FromSecondCubCentimeterPerKilograms(double value) => new TimeCubLengthPerMass((value + secondcubcentimeterperkilogram_.Offset) * secondcubcentimeterperkilogram_.Factor);
  public double GetValueInSecondCubCentimeterPerKilograms() => (Value_ - secondcubcentimeterperkilogram_.Offset) / secondcubcentimeterperkilogram_.Factor;
  public static TimeCubLengthPerMass FromSecondCubMillimeterPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthPerMass((value + secondcubmillimeterperkilogram_.Offset) * secondcubmillimeterperkilogram_.Factor, minValue * secondcubmillimeterperkilogram_.Factor, maxValue * secondcubmillimeterperkilogram_.Factor);
  public static TimeCubLengthPerMass FromSecondCubMillimeterPerKilograms(double value) => new TimeCubLengthPerMass((value + secondcubmillimeterperkilogram_.Offset) * secondcubmillimeterperkilogram_.Factor);
  public double GetValueInSecondCubMillimeterPerKilograms() => (Value_ - secondcubmillimeterperkilogram_.Offset) / secondcubmillimeterperkilogram_.Factor;
  public static TimeCubLengthPerMass FromSecondCubMeterPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthPerMass((value + secondcubmeterperkilogram_.Offset) * secondcubmeterperkilogram_.Factor, minValue * secondcubmeterperkilogram_.Factor, maxValue * secondcubmeterperkilogram_.Factor);
  public static TimeCubLengthPerMass FromSecondCubMeterPerKilograms(double value) => new TimeCubLengthPerMass((value + secondcubmeterperkilogram_.Offset) * secondcubmeterperkilogram_.Factor);
  public double GetValueInSecondCubMeterPerKilograms() => (Value_ - secondcubmeterperkilogram_.Offset) / secondcubmeterperkilogram_.Factor;
  public static TimeCubLengthPerMass FromSecondCubInchPerKilograms(double value, double minValue, double maxValue) => new TimeCubLengthPerMass((value + secondcubinchperkilogram_.Offset) * secondcubinchperkilogram_.Factor, minValue * secondcubinchperkilogram_.Factor, maxValue * secondcubinchperkilogram_.Factor);
  public static TimeCubLengthPerMass FromSecondCubInchPerKilograms(double value) => new TimeCubLengthPerMass((value + secondcubinchperkilogram_.Offset) * secondcubinchperkilogram_.Factor);
  public double GetValueInSecondCubInchPerKilograms() => (Value_ - secondcubinchperkilogram_.Offset) / secondcubinchperkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeCubLengthPerMass operator+(TimeCubLengthPerMass o1, TimeCubLengthPerMass o2) => new TimeCubLengthPerMass(o1.Value_ + o2.Value_);
  public static TimeCubLengthPerMass operator-(TimeCubLengthPerMass o1, TimeCubLengthPerMass o2) => new TimeCubLengthPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubLengthPerMass o1, TimeCubLengthPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeCubLengthPerMass o1, LengthMassPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthMassPerTimeCub o1, TimeCubLengthPerMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(TimeCubLengthPerMass o1, LengthSqrTimeSqrPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrTimeSqrPerMass o1, TimeCubLengthPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(TimeCubLengthPerMass o1, LengthSqrPerTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrPerTimeCub o1, TimeCubLengthPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeCubLengthPerMass o1, TimeCubLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubLengthSqr o1, TimeCubLengthPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeCubLengthPerMass o1, LengthSqrMassPerTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubLengthPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTimePerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubTimePerMass o1, TimeCubLengthPerMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubTimeSqr o1, TimeCubLengthPerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeCubLengthPerMass o1, PerLengthCubTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthCubTimeCub o1, TimeCubLengthPerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeCubLengthPerMass o1, MassPerTimeSqrLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(MassPerTimeSqrLengthCub o1, TimeCubLengthPerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeCubLengthPerMass o1, TimeCubPerMassLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeCubPerMassLengthSqr o1, TimeCubLengthPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeCubLengthPerMass o1, MassPerLengthSqrTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerLengthSqrTimeCub o1, TimeCubLengthPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCubLengthPerMass o1, TimeCubLengthSqrPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(TimeCubLengthSqrPerMass o1, TimeCubLengthPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeCubLengthPerMass o1, LengthSqrMassPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrMassPerTimeCub o1, TimeCubLengthPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTimeSqrPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubTimeSqrPerMass o1, TimeCubLengthPerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubTimeCub o1, TimeCubLengthPerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeCubLengthPerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerLengthCubTimeCub o1, TimeCubLengthPerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimeCubPerMass o1, TimeCubLengthPerMass o2) => new Area(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubLengthPerMass is outside its bounds.");
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
    