
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubLengthMass : Quantity, IEquatable<TimeCubLengthMass>, IComparable
  {  
    internal TimeCubLengthMass(double value) : base(value, 2)
    {
      TimeCubLengthMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubLengthMass(TimeCubLengthMass other) : base(other)
    {
      TimeCubLengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLengthMass"))
    {
      switch(FakeDatabase.Units["TimeCubLengthMass"])
      {
        case "secondcubcentimeterkilogram": displayUnit_ = secondcubcentimeterkilogram_; break;
        case "secondcubmillimeterkilogram": displayUnit_ = secondcubmillimeterkilogram_; break;
        case "secondcubmeterkilogram": displayUnit_ = secondcubmeterkilogram_; break;
        case "secondcubinchkilogram": displayUnit_ = secondcubinchkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubcentimeterkilogram_ = new Unit_("SecondCubCentimeterKilogram", "s³ cm kg", 1, 0);
  private static Unit_ secondcubmillimeterkilogram_ = new Unit_("SecondCubMillimeterKilogram", "s³ mm kg", 0.1, 0);
  private static Unit_ secondcubmeterkilogram_ = new Unit_("SecondCubMeterKilogram", "s³ m kg", 100, 0);
  private static Unit_ secondcubinchkilogram_ = new Unit_("SecondCubInchKilogram", "s³ in kg", 2.56, 0);
  private static Unit_ platformUnit_ = secondcubcentimeterkilogram_;
  private static Unit_ displayUnit_ = secondcubcentimeterkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubLengthMass other && Equals(other);
  public bool Equals(TimeCubLengthMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubLengthMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubLengthMass other)) throw new ArgumentException("Object is not a TimeCubLengthMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubLengthMass l1, TimeCubLengthMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubLengthMass l1, TimeCubLengthMass l2) => !(l1 == l2);
  public static bool operator <(TimeCubLengthMass l1, TimeCubLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubLengthMass l1, TimeCubLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubLengthMass l1, TimeCubLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubLengthMass l1, TimeCubLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubLengthMass FromSecondCubCentimeterKilograms(double value, double minValue, double maxValue) => new TimeCubLengthMass((value + secondcubcentimeterkilogram_.Offset) * secondcubcentimeterkilogram_.Factor, minValue * secondcubcentimeterkilogram_.Factor, maxValue * secondcubcentimeterkilogram_.Factor);
  public static TimeCubLengthMass FromSecondCubCentimeterKilograms(double value) => new TimeCubLengthMass((value + secondcubcentimeterkilogram_.Offset) * secondcubcentimeterkilogram_.Factor);
  public double GetValueInSecondCubCentimeterKilograms() => (Value_ - secondcubcentimeterkilogram_.Offset) / secondcubcentimeterkilogram_.Factor;
  public static TimeCubLengthMass FromSecondCubMillimeterKilograms(double value, double minValue, double maxValue) => new TimeCubLengthMass((value + secondcubmillimeterkilogram_.Offset) * secondcubmillimeterkilogram_.Factor, minValue * secondcubmillimeterkilogram_.Factor, maxValue * secondcubmillimeterkilogram_.Factor);
  public static TimeCubLengthMass FromSecondCubMillimeterKilograms(double value) => new TimeCubLengthMass((value + secondcubmillimeterkilogram_.Offset) * secondcubmillimeterkilogram_.Factor);
  public double GetValueInSecondCubMillimeterKilograms() => (Value_ - secondcubmillimeterkilogram_.Offset) / secondcubmillimeterkilogram_.Factor;
  public static TimeCubLengthMass FromSecondCubMeterKilograms(double value, double minValue, double maxValue) => new TimeCubLengthMass((value + secondcubmeterkilogram_.Offset) * secondcubmeterkilogram_.Factor, minValue * secondcubmeterkilogram_.Factor, maxValue * secondcubmeterkilogram_.Factor);
  public static TimeCubLengthMass FromSecondCubMeterKilograms(double value) => new TimeCubLengthMass((value + secondcubmeterkilogram_.Offset) * secondcubmeterkilogram_.Factor);
  public double GetValueInSecondCubMeterKilograms() => (Value_ - secondcubmeterkilogram_.Offset) / secondcubmeterkilogram_.Factor;
  public static TimeCubLengthMass FromSecondCubInchKilograms(double value, double minValue, double maxValue) => new TimeCubLengthMass((value + secondcubinchkilogram_.Offset) * secondcubinchkilogram_.Factor, minValue * secondcubinchkilogram_.Factor, maxValue * secondcubinchkilogram_.Factor);
  public static TimeCubLengthMass FromSecondCubInchKilograms(double value) => new TimeCubLengthMass((value + secondcubinchkilogram_.Offset) * secondcubinchkilogram_.Factor);
  public double GetValueInSecondCubInchKilograms() => (Value_ - secondcubinchkilogram_.Offset) / secondcubinchkilogram_.Factor;

#endregion

#region arithmetic
  public static TimeCubLengthMass operator+(TimeCubLengthMass o1, TimeCubLengthMass o2) => new TimeCubLengthMass(o1.Value_ + o2.Value_);
  public static TimeCubLengthMass operator-(TimeCubLengthMass o1, TimeCubLengthMass o2) => new TimeCubLengthMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubLengthMass o1, TimeCubLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeCubLengthMass o1, LengthSqrPerMassTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrPerMassTimeSqr o1, TimeCubLengthMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator*(TimeCubLengthMass o1, LengthSqrPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrPerTimeCub o1, TimeCubLengthMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeCubLengthMass o1, TimeCubLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubLengthSqr o1, TimeCubLengthMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(TimeCubLengthMass o1, LengthSqrTimeSqrMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrTimeSqrMass o1, TimeCubLengthMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeCubLengthMass o1, LengthCubTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubTimeSqr o1, TimeCubLengthMass o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeCubLengthMass o1, LengthCubMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubMassTime o1, TimeCubLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeCubLengthMass o1, PerMassTimeSqrLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerMassTimeSqrLengthCub o1, TimeCubLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeCubLengthMass o1, PerLengthCubTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerLengthCubTimeCub o1, TimeCubLengthMass o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(TimeCubLengthMass o1, PerMassLengthSqrTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassLengthSqrTimeCub o1, TimeCubLengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeCubLengthMass o1, TimeCubMassPerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeCubMassPerLengthSqr o1, TimeCubLengthMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeCubLengthMass o1, LengthSqrPerMassTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrPerMassTimeCub o1, TimeCubLengthMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeCubLengthMass o1, TimeCubLengthSqrMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(TimeCubLengthSqrMass o1, TimeCubLengthMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeCubLengthMass o1, LengthCubTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubTimeCub o1, TimeCubLengthMass o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeCubLengthMass o1, LengthCubTimeSqrMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubTimeSqrMass o1, TimeCubLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(TimeCubLengthMass o1, PerMassLengthCubTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassLengthCubTimeCub o1, TimeCubLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubLengthMass o1, LengthCubTimeCubMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimeCubMass o1, TimeCubLengthMass o2) => new Area(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubLengthMass is outside its bounds.");
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
    