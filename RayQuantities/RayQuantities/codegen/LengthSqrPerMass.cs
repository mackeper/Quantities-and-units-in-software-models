
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrPerMass : Quantity, IEquatable<LengthSqrPerMass>, IComparable
  {  
    internal LengthSqrPerMass(double value) : base(value, 2)
    {
      LengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrPerMass(LengthSqrPerMass other) : base(other)
    {
      LengthSqrPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerMass"))
    {
      switch(FakeDatabase.Units["LengthSqrPerMass"])
      {
        case "centimetersqrperkilogram": displayUnit_ = centimetersqrperkilogram_; break;
        case "millimetersqrperkilogram": displayUnit_ = millimetersqrperkilogram_; break;
        case "metersqrperkilogram": displayUnit_ = metersqrperkilogram_; break;
        case "inchsqrperkilogram": displayUnit_ = inchsqrperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrperkilogram_ = new Unit_("CentimeterSqrPerKilogram", "cm²/kg", 1.0, 0);
  private static Unit_ millimetersqrperkilogram_ = new Unit_("MillimeterSqrPerKilogram", "mm²/kg", 0.010000000000000002, 0);
  private static Unit_ metersqrperkilogram_ = new Unit_("MeterSqrPerKilogram", "m²/kg", 10000.0, 0);
  private static Unit_ inchsqrperkilogram_ = new Unit_("InchSqrPerKilogram", "in²/kg", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrperkilogram_;
  private static Unit_ displayUnit_ = centimetersqrperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrPerMass other && Equals(other);
  public bool Equals(LengthSqrPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrPerMass other)) throw new ArgumentException("Object is not a LengthSqrPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrPerMass l1, LengthSqrPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrPerMass l1, LengthSqrPerMass l2) => !(l1 == l2);
  public static bool operator <(LengthSqrPerMass l1, LengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrPerMass l1, LengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrPerMass l1, LengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrPerMass l1, LengthSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrPerMass FromCentimeterSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrPerMass((value + centimetersqrperkilogram_.Offset) * centimetersqrperkilogram_.Factor, minValue * centimetersqrperkilogram_.Factor, maxValue * centimetersqrperkilogram_.Factor);
  public static LengthSqrPerMass FromCentimeterSqrPerKilograms(double value) => new LengthSqrPerMass((value + centimetersqrperkilogram_.Offset) * centimetersqrperkilogram_.Factor);
  public double GetValueInCentimeterSqrPerKilograms() => (Value_ - centimetersqrperkilogram_.Offset) / centimetersqrperkilogram_.Factor;
  public static LengthSqrPerMass FromMillimeterSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrPerMass((value + millimetersqrperkilogram_.Offset) * millimetersqrperkilogram_.Factor, minValue * millimetersqrperkilogram_.Factor, maxValue * millimetersqrperkilogram_.Factor);
  public static LengthSqrPerMass FromMillimeterSqrPerKilograms(double value) => new LengthSqrPerMass((value + millimetersqrperkilogram_.Offset) * millimetersqrperkilogram_.Factor);
  public double GetValueInMillimeterSqrPerKilograms() => (Value_ - millimetersqrperkilogram_.Offset) / millimetersqrperkilogram_.Factor;
  public static LengthSqrPerMass FromMeterSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrPerMass((value + metersqrperkilogram_.Offset) * metersqrperkilogram_.Factor, minValue * metersqrperkilogram_.Factor, maxValue * metersqrperkilogram_.Factor);
  public static LengthSqrPerMass FromMeterSqrPerKilograms(double value) => new LengthSqrPerMass((value + metersqrperkilogram_.Offset) * metersqrperkilogram_.Factor);
  public double GetValueInMeterSqrPerKilograms() => (Value_ - metersqrperkilogram_.Offset) / metersqrperkilogram_.Factor;
  public static LengthSqrPerMass FromInchSqrPerKilograms(double value, double minValue, double maxValue) => new LengthSqrPerMass((value + inchsqrperkilogram_.Offset) * inchsqrperkilogram_.Factor, minValue * inchsqrperkilogram_.Factor, maxValue * inchsqrperkilogram_.Factor);
  public static LengthSqrPerMass FromInchSqrPerKilograms(double value) => new LengthSqrPerMass((value + inchsqrperkilogram_.Offset) * inchsqrperkilogram_.Factor);
  public double GetValueInInchSqrPerKilograms() => (Value_ - inchsqrperkilogram_.Offset) / inchsqrperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthSqrPerMass operator+(LengthSqrPerMass o1, LengthSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ + o2.Value_);
  public static LengthSqrPerMass operator-(LengthSqrPerMass o1, LengthSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrPerMass o1, LengthSqrPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthSqrPerMass o1, LengthSqrPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthSqrPerTime o1, LengthSqrPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrPerMass o1, LengthSqrTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrTime o1, LengthSqrPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrPerMass o1, Volume o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(Volume o1, LengthSqrPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrPerMass o1, PerTimeLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerTimeLengthCub o1, LengthSqrPerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(LengthSqrPerMass o1, TimePerLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimePerLengthCub o1, LengthSqrPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrPerMass o1, Density o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(Density o1, LengthSqrPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthSqrPerMass o1, PerLengthSqrTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthSqrTimeSqr o1, LengthSqrPerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthSqrPerMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerLengthSqr o1, LengthSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrPerMass o1, MassPerTimeLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerTimeLengthSqr o1, LengthSqrPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthSqrPerMass o1, MassTimePerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(MassTimePerLengthSqr o1, LengthSqrPerMass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthSqrPerMass o1, PerLengthMassTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthSqrPerMass o1, TimeSqrPerLengthMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrPerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(LengthSqrPerMass o1, PerLengthTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerLengthTimeCub o1, LengthSqrPerMass o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthSqrPerMass o1, PerLengthTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(PerLengthTimeCub o1, LengthSqrPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(LengthSqrPerMass o1, TimeCubPerLength o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubPerLength o1, LengthSqrPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthSqrPerMass o1, TimeCubPerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubPerLength o1, LengthSqrPerMass o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthSqrPerMass o1, MassPerLengthTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(MassPerLengthTimeSqr o1, LengthSqrPerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthSqrPerMass o1, TimeSqrMassPerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrMassPerLength o1, LengthSqrPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthSqrPerMass o1, PerMassTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerMassTimeCub o1, LengthSqrPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(LengthSqrPerMass o1, TimeCubPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubPerMass o1, LengthSqrPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(LengthSqrPerMass o1, MassPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(MassPerTimeCub o1, LengthSqrPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthSqrPerMass o1, TimeCubMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubMass o1, LengthSqrPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(LengthSqrPerMass o1, LengthPerMassTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(LengthPerMassTimeSqr o1, LengthSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(LengthSqrPerMass o1, TimeSqrLengthPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrLengthPerMass o1, LengthSqrPerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(LengthSqrPerMass o1, LengthPerTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthPerTimeCub o1, LengthSqrPerMass o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthSqrPerMass o1, LengthPerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(LengthPerTimeCub o1, LengthSqrPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(LengthSqrPerMass o1, TimeCubLength o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeCubLength o1, LengthSqrPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerMass o1, TimeCubLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubLength o1, LengthSqrPerMass o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthSqrPerMass o1, Force o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(Force o1, LengthSqrPerMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthSqrPerMass o1, TimeSqrLengthMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(TimeSqrLengthMass o1, LengthSqrPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthSqrPerMass o1, LengthSqrPerMassTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthSqrPerMassTime o1, LengthSqrPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthSqrPerMass o1, LengthSqrTimePerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrTimePerMass o1, LengthSqrPerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthSqrPerMass o1, QDose o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(QDose o1, LengthSqrPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthSqrPerMass o1, LengthSqrTimeSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthSqrTimeSqr o1, LengthSqrPerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrPerMass o1, LengthCubPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubPerMass o1, LengthSqrPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(LengthSqrPerMass o1, LengthCubPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthCubPerTime o1, LengthSqrPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrPerMass o1, LengthCubTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubTime o1, LengthSqrPerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthSqrPerMass o1, PerTimeSqrLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerTimeSqrLengthCub o1, LengthSqrPerMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthSqrPerMass o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrPerLengthCub o1, LengthSqrPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrPerMass o1, MassPerTimeLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerTimeLengthCub o1, LengthSqrPerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthSqrPerMass o1, MassTimePerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(MassTimePerLengthCub o1, LengthSqrPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(LengthSqrPerMass o1, PerLengthSqrTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerLengthSqrTimeCub o1, LengthSqrPerMass o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(LengthSqrPerMass o1, TimeCubPerLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerLengthSqr o1, LengthSqrPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthSqrPerMass o1, MassPerLengthSqrTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(MassPerLengthSqrTimeSqr o1, LengthSqrPerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthSqrPerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthSqrPerMass o1, PerLengthMassTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthMassTimeCub o1, LengthSqrPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(LengthSqrPerMass o1, TimeCubPerLengthMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubPerLengthMass o1, LengthSqrPerMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(LengthSqrPerMass o1, MassPerLengthTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(MassPerLengthTimeCub o1, LengthSqrPerMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(LengthSqrPerMass o1, TimeCubMassPerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubMassPerLength o1, LengthSqrPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(LengthSqrPerMass o1, LengthPerMassTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(LengthPerMassTimeCub o1, LengthSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(LengthSqrPerMass o1, TimeCubLengthPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubLengthPerMass o1, LengthSqrPerMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthSqrPerMass o1, LengthMassPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthMassPerTimeCub o1, LengthSqrPerMass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthSqrPerMass o1, TimeCubLengthMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLengthMass o1, LengthSqrPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(LengthSqrPerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthSqrTimeSqrPerMass o1, LengthSqrPerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(LengthSqrPerMass o1, LengthSqrPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthSqrPerTimeCub o1, LengthSqrPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(LengthSqrPerMass o1, TimeCubLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubLengthSqr o1, LengthSqrPerMass o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrPerMass o1, LengthCubPerMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubPerMassTime o1, LengthSqrPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrPerMass o1, LengthCubTimePerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTimePerMass o1, LengthSqrPerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(LengthSqrPerMass o1, LengthCubPerTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthCubPerTimeSqr o1, LengthSqrPerMass o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthSqrPerMass o1, LengthCubTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubTimeSqr o1, LengthSqrPerMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(LengthSqrPerMass o1, PerLengthCubTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerLengthCubTimeCub o1, LengthSqrPerMass o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthSqrPerMass o1, TimeCubPerLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubPerLengthCub o1, LengthSqrPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrPerMass o1, MassPerTimeSqrLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerTimeSqrLengthCub o1, LengthSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrPerMass o1, TimeSqrMassPerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthSqrPerMass o1, MassPerLengthSqrTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(MassPerLengthSqrTimeCub o1, LengthSqrPerMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthSqrPerMass o1, TimeCubMassPerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthSqrPerMass o1, LengthSqrPerMassTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLengthSqrPerMass o1, LengthSqrPerMass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrPerMass o1, LengthCubPerMassTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeSqrPerMass o1, LengthSqrPerMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(LengthSqrPerMass o1, LengthCubPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthCubPerTimeCub o1, LengthSqrPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator/(LengthSqrPerMass o1, LengthCubTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(LengthCubTimeCub o1, LengthSqrPerMass o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthSqrPerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(MassPerLengthCubTimeCub o1, LengthSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthSqrPerMass o1, TimeCubMassPerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrPerMass o1, LengthCubPerMassTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubPerMassTimeCub o1, LengthSqrPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthSqrPerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubTimeCubPerMass o1, LengthSqrPerMass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrPerMass is outside its bounds.");
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
    