
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthTimePerMass : Quantity, IEquatable<LengthTimePerMass>, IComparable
  {  
    internal LengthTimePerMass(double value) : base(value, 2)
    {
      LengthTimePerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthTimePerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthTimePerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthTimePerMass(LengthTimePerMass other) : base(other)
    {
      LengthTimePerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthTimePerMass"))
    {
      switch(FakeDatabase.Units["LengthTimePerMass"])
      {
        case "centimetersecondperkilogram": displayUnit_ = centimetersecondperkilogram_; break;
        case "millimetersecondperkilogram": displayUnit_ = millimetersecondperkilogram_; break;
        case "metersecondperkilogram": displayUnit_ = metersecondperkilogram_; break;
        case "inchsecondperkilogram": displayUnit_ = inchsecondperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersecondperkilogram_ = new Unit_("CentimeterSecondPerKilogram", "cm s/kg", 1.0, 0);
  private static Unit_ millimetersecondperkilogram_ = new Unit_("MillimeterSecondPerKilogram", "mm s/kg", 0.1, 0);
  private static Unit_ metersecondperkilogram_ = new Unit_("MeterSecondPerKilogram", "m s/kg", 100.0, 0);
  private static Unit_ inchsecondperkilogram_ = new Unit_("InchSecondPerKilogram", "in s/kg", 2.56, 0);
  private static Unit_ platformUnit_ = centimetersecondperkilogram_;
  private static Unit_ displayUnit_ = centimetersecondperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthTimePerMass other && Equals(other);
  public bool Equals(LengthTimePerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthTimePerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthTimePerMass other)) throw new ArgumentException("Object is not a LengthTimePerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthTimePerMass l1, LengthTimePerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthTimePerMass l1, LengthTimePerMass l2) => !(l1 == l2);
  public static bool operator <(LengthTimePerMass l1, LengthTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthTimePerMass l1, LengthTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthTimePerMass l1, LengthTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthTimePerMass l1, LengthTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthTimePerMass FromCentimeterSecondPerKilograms(double value, double minValue, double maxValue) => new LengthTimePerMass((value + centimetersecondperkilogram_.Offset) * centimetersecondperkilogram_.Factor, minValue * centimetersecondperkilogram_.Factor, maxValue * centimetersecondperkilogram_.Factor);
  public static LengthTimePerMass FromCentimeterSecondPerKilograms(double value) => new LengthTimePerMass((value + centimetersecondperkilogram_.Offset) * centimetersecondperkilogram_.Factor);
  public double GetValueInCentimeterSecondPerKilograms() => (Value_ - centimetersecondperkilogram_.Offset) / centimetersecondperkilogram_.Factor;
  public static LengthTimePerMass FromMillimeterSecondPerKilograms(double value, double minValue, double maxValue) => new LengthTimePerMass((value + millimetersecondperkilogram_.Offset) * millimetersecondperkilogram_.Factor, minValue * millimetersecondperkilogram_.Factor, maxValue * millimetersecondperkilogram_.Factor);
  public static LengthTimePerMass FromMillimeterSecondPerKilograms(double value) => new LengthTimePerMass((value + millimetersecondperkilogram_.Offset) * millimetersecondperkilogram_.Factor);
  public double GetValueInMillimeterSecondPerKilograms() => (Value_ - millimetersecondperkilogram_.Offset) / millimetersecondperkilogram_.Factor;
  public static LengthTimePerMass FromMeterSecondPerKilograms(double value, double minValue, double maxValue) => new LengthTimePerMass((value + metersecondperkilogram_.Offset) * metersecondperkilogram_.Factor, minValue * metersecondperkilogram_.Factor, maxValue * metersecondperkilogram_.Factor);
  public static LengthTimePerMass FromMeterSecondPerKilograms(double value) => new LengthTimePerMass((value + metersecondperkilogram_.Offset) * metersecondperkilogram_.Factor);
  public double GetValueInMeterSecondPerKilograms() => (Value_ - metersecondperkilogram_.Offset) / metersecondperkilogram_.Factor;
  public static LengthTimePerMass FromInchSecondPerKilograms(double value, double minValue, double maxValue) => new LengthTimePerMass((value + inchsecondperkilogram_.Offset) * inchsecondperkilogram_.Factor, minValue * inchsecondperkilogram_.Factor, maxValue * inchsecondperkilogram_.Factor);
  public static LengthTimePerMass FromInchSecondPerKilograms(double value) => new LengthTimePerMass((value + inchsecondperkilogram_.Offset) * inchsecondperkilogram_.Factor);
  public double GetValueInInchSecondPerKilograms() => (Value_ - inchsecondperkilogram_.Offset) / inchsecondperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthTimePerMass operator+(LengthTimePerMass o1, LengthTimePerMass o2) => new LengthTimePerMass(o1.Value_ + o2.Value_);
  public static LengthTimePerMass operator-(LengthTimePerMass o1, LengthTimePerMass o2) => new LengthTimePerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthTimePerMass o1, LengthTimePerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(LengthTimePerMass o1, Acceleration o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(Acceleration o1, LengthTimePerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(LengthTimePerMass o1, Acceleration o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(Acceleration o1, LengthTimePerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(LengthTimePerMass o1, TimeSqrLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeSqrLength o1, LengthTimePerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(LengthTimePerMass o1, TimeSqrLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrLength o1, LengthTimePerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(LengthTimePerMass o1, LengthMassPerTime o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthMassPerTime o1, LengthTimePerMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(LengthTimePerMass o1, LengthMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthMassTime o1, LengthTimePerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthTimePerMass o1, LengthSqrPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerMass o1, LengthTimePerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthTimePerMass o1, LengthSqrPerTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrPerTime o1, LengthTimePerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(LengthTimePerMass o1, LengthSqrPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthSqrPerTime o1, LengthTimePerMass o2) => new Force(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(LengthTimePerMass o1, LengthSqrTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthSqrTime o1, LengthTimePerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(LengthTimePerMass o1, LengthSqrTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrTime o1, LengthTimePerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(LengthTimePerMass o1, LengthSqrMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrMass o1, LengthTimePerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator/(LengthTimePerMass o1, Volume o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(Volume o1, LengthTimePerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthTimePerMass o1, PerTimeLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerTimeLengthCub o1, LengthTimePerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(LengthTimePerMass o1, TimePerLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimePerLengthCub o1, LengthTimePerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthTimePerMass o1, Density o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(Density o1, LengthTimePerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthTimePerMass o1, PerMassTimeLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerMassTimeLengthSqr o1, LengthTimePerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(LengthTimePerMass o1, TimePerMassLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimePerMassLengthSqr o1, LengthTimePerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthTimePerMass o1, PerLengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerLengthSqrTimeSqr o1, LengthTimePerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthTimePerMass o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(PerLengthSqrTimeSqr o1, LengthTimePerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthTimePerMass o1, TimeSqrPerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeSqrPerLengthSqr o1, LengthTimePerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(LengthTimePerMass o1, TimeSqrPerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimeSqrPerLengthSqr o1, LengthTimePerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthTimePerMass o1, MassPerTimeLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerTimeLengthSqr o1, LengthTimePerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthTimePerMass o1, MassTimePerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(MassTimePerLengthSqr o1, LengthTimePerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthTimePerMass o1, PerLengthMassTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthMassTimeSqr o1, LengthTimePerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(LengthTimePerMass o1, TimeSqrPerLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeSqrPerLengthMass o1, LengthTimePerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthTimePerMass o1, PerLengthTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthTimeCub o1, LengthTimePerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(LengthTimePerMass o1, TimeCubPerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeCubPerLength o1, LengthTimePerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(LengthTimePerMass o1, MassPerLengthTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerLengthTimeSqr o1, LengthTimePerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthTimePerMass o1, TimeSqrMassPerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrMassPerLength o1, LengthTimePerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthTimePerMass o1, TimeCubPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubPerMass o1, LengthTimePerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthTimePerMass o1, MassPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(MassPerTimeCub o1, LengthTimePerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthTimePerMass o1, LengthPerMassTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthPerMassTimeSqr o1, LengthTimePerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthTimePerMass o1, TimeSqrLengthPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrLengthPerMass o1, LengthTimePerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(LengthTimePerMass o1, LengthPerTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthPerTimeCub o1, LengthTimePerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthTimePerMass o1, TimeCubLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubLength o1, LengthTimePerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(LengthTimePerMass o1, Force o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(Force o1, LengthTimePerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthTimePerMass o1, TimeSqrLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeSqrLengthMass o1, LengthTimePerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthTimePerMass o1, LengthSqrPerMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrPerMassTime o1, LengthTimePerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthTimePerMass o1, LengthSqrTimePerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrTimePerMass o1, LengthTimePerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(LengthTimePerMass o1, QDose o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(QDose o1, LengthTimePerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(LengthTimePerMass o1, QDose o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(QDose o1, LengthTimePerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(LengthTimePerMass o1, LengthSqrTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(LengthSqrTimeSqr o1, LengthTimePerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(LengthTimePerMass o1, LengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrTimeSqr o1, LengthTimePerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthTimePerMass o1, LengthSqrMassPerTime o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrMassPerTime o1, LengthTimePerMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthTimePerMass o1, LengthSqrMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrMassTime o1, LengthTimePerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthTimePerMass o1, LengthCubPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerMass o1, LengthTimePerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(LengthTimePerMass o1, LengthCubPerTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubPerTime o1, LengthTimePerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthTimePerMass o1, LengthCubTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubTime o1, LengthTimePerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(LengthTimePerMass o1, PerTimeSqrLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerTimeSqrLengthCub o1, LengthTimePerMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(LengthTimePerMass o1, TimeSqrPerLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeSqrPerLengthCub o1, LengthTimePerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthTimePerMass o1, MassPerTimeLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassPerTimeLengthCub o1, LengthTimePerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthTimePerMass o1, MassTimePerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(MassTimePerLengthCub o1, LengthTimePerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthTimePerMass o1, PerMassLengthSqrTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerMassLengthSqrTimeSqr o1, LengthTimePerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(LengthTimePerMass o1, TimeSqrPerMassLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeSqrPerMassLengthSqr o1, LengthTimePerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthTimePerMass o1, PerLengthSqrTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerLengthSqrTimeCub o1, LengthTimePerMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator/(LengthTimePerMass o1, TimeCubPerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeCubPerLengthSqr o1, LengthTimePerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthTimePerMass o1, MassPerLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerLengthSqrTimeSqr o1, LengthTimePerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthTimePerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrMassPerLengthSqr o1, LengthTimePerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static QDose operator/(LengthTimePerMass o1, TimeCubPerLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeCubPerLengthMass o1, LengthTimePerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(LengthTimePerMass o1, MassPerLengthTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(MassPerLengthTimeCub o1, LengthTimePerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(LengthTimePerMass o1, TimeCubLengthPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLengthPerMass o1, LengthTimePerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthTimePerMass o1, LengthMassPerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthMassPerTimeCub o1, LengthTimePerMass o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(LengthTimePerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrPerMassTimeSqr o1, LengthTimePerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthTimePerMass o1, LengthSqrTimeSqrPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrTimeSqrPerMass o1, LengthTimePerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthTimePerMass o1, LengthSqrPerTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrPerTimeCub o1, LengthTimePerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthTimePerMass o1, TimeCubLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubLengthSqr o1, LengthTimePerMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthTimePerMass o1, LengthSqrMassPerTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrMassPerTimeSqr o1, LengthTimePerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthTimePerMass o1, LengthSqrTimeSqrMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrTimeSqrMass o1, LengthTimePerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthTimePerMass o1, LengthCubPerMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerMassTime o1, LengthTimePerMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(LengthTimePerMass o1, LengthCubTimePerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimePerMass o1, LengthTimePerMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(LengthTimePerMass o1, LengthCubPerTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubPerTimeSqr o1, LengthTimePerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthTimePerMass o1, LengthCubTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubTimeSqr o1, LengthTimePerMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(LengthTimePerMass o1, PerLengthCubTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerLengthCubTimeCub o1, LengthTimePerMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthTimePerMass o1, MassPerTimeSqrLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassPerTimeSqrLengthCub o1, LengthTimePerMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(LengthTimePerMass o1, TimeSqrMassPerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthTimePerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthTimePerMass o1, TimeCubPerMassLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubPerMassLengthSqr o1, LengthTimePerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthTimePerMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerLengthSqrTimeCub o1, LengthTimePerMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthTimePerMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubLengthSqrPerMass o1, LengthTimePerMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthTimePerMass o1, LengthSqrMassPerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrMassPerTimeCub o1, LengthTimePerMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(LengthTimePerMass o1, LengthCubPerMassTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthTimePerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthTimePerMass o1, LengthCubTimeSqrPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeSqrPerMass o1, LengthTimePerMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(LengthTimePerMass o1, LengthCubTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubTimeCub o1, LengthTimePerMass o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthTimePerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthTimePerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthTimePerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeCubPerMass o1, LengthTimePerMass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthTimePerMass is outside its bounds.");
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
    