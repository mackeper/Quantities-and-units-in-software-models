
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthPerMass : Quantity, IEquatable<LengthPerMass>, IComparable
  {  
    internal LengthPerMass(double value) : base(value, 2)
    {
      LengthPerMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthPerMass(LengthPerMass other) : base(other)
    {
      LengthPerMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthPerMass"))
    {
      switch(FakeDatabase.Units["LengthPerMass"])
      {
        case "centimeterperkilogram": displayUnit_ = centimeterperkilogram_; break;
        case "millimeterperkilogram": displayUnit_ = millimeterperkilogram_; break;
        case "meterperkilogram": displayUnit_ = meterperkilogram_; break;
        case "inchperkilogram": displayUnit_ = inchperkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterperkilogram_ = new Unit_("CentimeterPerKilogram", "cm/kg", 1.0, 0);
  private static Unit_ millimeterperkilogram_ = new Unit_("MillimeterPerKilogram", "mm/kg", 0.1, 0);
  private static Unit_ meterperkilogram_ = new Unit_("MeterPerKilogram", "m/kg", 100.0, 0);
  private static Unit_ inchperkilogram_ = new Unit_("InchPerKilogram", "in/kg", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterperkilogram_;
  private static Unit_ displayUnit_ = centimeterperkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthPerMass other && Equals(other);
  public bool Equals(LengthPerMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthPerMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthPerMass other)) throw new ArgumentException("Object is not a LengthPerMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthPerMass l1, LengthPerMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthPerMass l1, LengthPerMass l2) => !(l1 == l2);
  public static bool operator <(LengthPerMass l1, LengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthPerMass l1, LengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthPerMass l1, LengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthPerMass l1, LengthPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthPerMass FromCentimeterPerKilograms(double value, double minValue, double maxValue) => new LengthPerMass((value + centimeterperkilogram_.Offset) * centimeterperkilogram_.Factor, minValue * centimeterperkilogram_.Factor, maxValue * centimeterperkilogram_.Factor);
  public static LengthPerMass FromCentimeterPerKilograms(double value) => new LengthPerMass((value + centimeterperkilogram_.Offset) * centimeterperkilogram_.Factor);
  public double GetValueInCentimeterPerKilograms() => (Value_ - centimeterperkilogram_.Offset) / centimeterperkilogram_.Factor;
  public static LengthPerMass FromMillimeterPerKilograms(double value, double minValue, double maxValue) => new LengthPerMass((value + millimeterperkilogram_.Offset) * millimeterperkilogram_.Factor, minValue * millimeterperkilogram_.Factor, maxValue * millimeterperkilogram_.Factor);
  public static LengthPerMass FromMillimeterPerKilograms(double value) => new LengthPerMass((value + millimeterperkilogram_.Offset) * millimeterperkilogram_.Factor);
  public double GetValueInMillimeterPerKilograms() => (Value_ - millimeterperkilogram_.Offset) / millimeterperkilogram_.Factor;
  public static LengthPerMass FromMeterPerKilograms(double value, double minValue, double maxValue) => new LengthPerMass((value + meterperkilogram_.Offset) * meterperkilogram_.Factor, minValue * meterperkilogram_.Factor, maxValue * meterperkilogram_.Factor);
  public static LengthPerMass FromMeterPerKilograms(double value) => new LengthPerMass((value + meterperkilogram_.Offset) * meterperkilogram_.Factor);
  public double GetValueInMeterPerKilograms() => (Value_ - meterperkilogram_.Offset) / meterperkilogram_.Factor;
  public static LengthPerMass FromInchPerKilograms(double value, double minValue, double maxValue) => new LengthPerMass((value + inchperkilogram_.Offset) * inchperkilogram_.Factor, minValue * inchperkilogram_.Factor, maxValue * inchperkilogram_.Factor);
  public static LengthPerMass FromInchPerKilograms(double value) => new LengthPerMass((value + inchperkilogram_.Offset) * inchperkilogram_.Factor);
  public double GetValueInInchPerKilograms() => (Value_ - inchperkilogram_.Offset) / inchperkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthPerMass operator+(LengthPerMass o1, LengthPerMass o2) => new LengthPerMass(o1.Value_ + o2.Value_);
  public static LengthPerMass operator-(LengthPerMass o1, LengthPerMass o2) => new LengthPerMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthPerMass o1, LengthPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(LengthPerMass o1, Speed o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(Speed o1, LengthPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(LengthPerMass o1, Speed o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(Speed o1, LengthPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(LengthPerMass o1, LengthTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthTime o1, LengthPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(LengthPerMass o1, LengthTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthTime o1, LengthPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(LengthPerMass o1, LengthMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthMass o1, LengthPerMass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator*(LengthPerMass o1, Area o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(Area o1, LengthPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(LengthPerMass o1, Area o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(Area o1, LengthPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthPerMass o1, PerLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerLengthCub o1, LengthPerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthPerMass o1, PerMassLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassLengthSqr o1, LengthPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthPerMass o1, PerTimeLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerTimeLengthSqr o1, LengthPerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(LengthPerMass o1, PerTimeLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(PerTimeLengthSqr o1, LengthPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(LengthPerMass o1, TimePerLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimePerLengthSqr o1, LengthPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(LengthPerMass o1, TimePerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimePerLengthSqr o1, LengthPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthPerMass o1, MassPerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassPerLengthSqr o1, LengthPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(LengthPerMass o1, PerLengthMassTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthMassTime o1, LengthPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(LengthPerMass o1, TimePerLengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimePerLengthMass o1, LengthPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthPerMass o1, PerLengthTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerLengthTimeSqr o1, LengthPerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthPerMass o1, PerLengthTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(PerLengthTimeSqr o1, LengthPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthPerMass o1, TimeSqrPerLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerLength o1, LengthPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthPerMass o1, TimeSqrPerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrPerLength o1, LengthPerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(LengthPerMass o1, MassPerLengthTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(MassPerLengthTime o1, LengthPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthPerMass o1, MassTimePerLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(MassTimePerLength o1, LengthPerMass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(LengthPerMass o1, PerMassTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassTimeSqr o1, LengthPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(LengthPerMass o1, TimeSqrPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrPerMass o1, LengthPerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(LengthPerMass o1, PerTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerTimeCub o1, LengthPerMass o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthPerMass o1, PerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(PerTimeCub o1, LengthPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(LengthPerMass o1, TimeCub o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCub o1, LengthPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthPerMass o1, TimeCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCub o1, LengthPerMass o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthPerMass o1, MassPerTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(MassPerTimeSqr o1, LengthPerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthPerMass o1, TimeSqrMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrMass o1, LengthPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthPerMass o1, LengthPerMassTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthPerMassTime o1, LengthPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthPerMass o1, LengthTimePerMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthTimePerMass o1, LengthPerMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(LengthPerMass o1, Acceleration o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(Acceleration o1, LengthPerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(LengthPerMass o1, Acceleration o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(Acceleration o1, LengthPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(LengthPerMass o1, TimeSqrLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeSqrLength o1, LengthPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator/(LengthPerMass o1, TimeSqrLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrLength o1, LengthPerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(LengthPerMass o1, LengthMassPerTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthMassPerTime o1, LengthPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(LengthPerMass o1, LengthMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthMassTime o1, LengthPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthPerMass o1, LengthSqrPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrPerMass o1, LengthPerMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(LengthPerMass o1, LengthSqrPerTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrPerTime o1, LengthPerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(LengthPerMass o1, LengthSqrPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrPerTime o1, LengthPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(LengthPerMass o1, LengthSqrTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthSqrTime o1, LengthPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(LengthPerMass o1, LengthSqrTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrTime o1, LengthPerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthPerMass o1, LengthSqrMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrMass o1, LengthPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthPerMass o1, Volume o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(Volume o1, LengthPerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(LengthPerMass o1, PerTimeLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerTimeLengthCub o1, LengthPerMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator*(LengthPerMass o1, TimePerLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimePerLengthCub o1, LengthPerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthPerMass o1, Density o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(Density o1, LengthPerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(LengthPerMass o1, PerMassTimeLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerMassTimeLengthSqr o1, LengthPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(LengthPerMass o1, TimePerMassLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimePerMassLengthSqr o1, LengthPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthPerMass o1, PerLengthSqrTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerLengthSqrTimeSqr o1, LengthPerMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthPerMass o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(PerLengthSqrTimeSqr o1, LengthPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthPerMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrPerLengthSqr o1, LengthPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthPerMass o1, TimeSqrPerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeSqrPerLengthSqr o1, LengthPerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthPerMass o1, MassPerTimeLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(MassPerTimeLengthSqr o1, LengthPerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthPerMass o1, MassTimePerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(MassTimePerLengthSqr o1, LengthPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator/(LengthPerMass o1, PerLengthMassTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthMassTimeSqr o1, LengthPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(LengthPerMass o1, TimeSqrPerLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrPerLengthMass o1, LengthPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(LengthPerMass o1, PerLengthTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerLengthTimeCub o1, LengthPerMass o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthPerMass o1, PerLengthTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(PerLengthTimeCub o1, LengthPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(LengthPerMass o1, TimeCubPerLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerLength o1, LengthPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthPerMass o1, TimeCubPerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubPerLength o1, LengthPerMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(LengthPerMass o1, MassPerLengthTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(MassPerLengthTimeSqr o1, LengthPerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthPerMass o1, TimeSqrMassPerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrMassPerLength o1, LengthPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(LengthPerMass o1, PerMassTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerMassTimeCub o1, LengthPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(LengthPerMass o1, TimeCubPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubPerMass o1, LengthPerMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(LengthPerMass o1, MassPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(MassPerTimeCub o1, LengthPerMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(LengthPerMass o1, TimeCubMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubMass o1, LengthPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(LengthPerMass o1, LengthPerMassTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthPerMassTimeSqr o1, LengthPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthPerMass o1, TimeSqrLengthPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrLengthPerMass o1, LengthPerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(LengthPerMass o1, LengthPerTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthPerTimeCub o1, LengthPerMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(LengthPerMass o1, LengthPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthPerTimeCub o1, LengthPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(LengthPerMass o1, TimeCubLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeCubLength o1, LengthPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(LengthPerMass o1, TimeCubLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubLength o1, LengthPerMass o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthPerMass o1, Force o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(Force o1, LengthPerMass o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(LengthPerMass o1, TimeSqrLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(TimeSqrLengthMass o1, LengthPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthPerMass o1, LengthSqrPerMassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerMassTime o1, LengthPerMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthPerMass o1, LengthSqrTimePerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrTimePerMass o1, LengthPerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthPerMass o1, QDose o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(QDose o1, LengthPerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(LengthPerMass o1, QDose o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(QDose o1, LengthPerMass o2) => new Force(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(LengthPerMass o1, LengthSqrTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthSqrTimeSqr o1, LengthPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthPerMass o1, LengthSqrTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthSqrTimeSqr o1, LengthPerMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthPerMass o1, LengthSqrMassPerTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrMassPerTime o1, LengthPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator*(LengthPerMass o1, LengthSqrMassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrMassTime o1, LengthPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(LengthPerMass o1, LengthCubPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerMass o1, LengthPerMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(LengthPerMass o1, LengthCubPerTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubPerTime o1, LengthPerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthPerMass o1, LengthCubTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubTime o1, LengthPerMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(LengthPerMass o1, PerTimeSqrLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerTimeSqrLengthCub o1, LengthPerMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(LengthPerMass o1, TimeSqrPerLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerLengthCub o1, LengthPerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthPerMass o1, MassPerTimeLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassPerTimeLengthCub o1, LengthPerMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthPerMass o1, MassTimePerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(MassTimePerLengthCub o1, LengthPerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthPerMass o1, PerMassLengthSqrTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerMassLengthSqrTimeSqr o1, LengthPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthPerMass o1, TimeSqrPerMassLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrPerMassLengthSqr o1, LengthPerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(LengthPerMass o1, PerLengthSqrTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerLengthSqrTimeCub o1, LengthPerMass o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthPerMass o1, PerLengthSqrTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(PerLengthSqrTimeCub o1, LengthPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(LengthPerMass o1, TimeCubPerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubPerLengthSqr o1, LengthPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthPerMass o1, TimeCubPerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubPerLengthSqr o1, LengthPerMass o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthPerMass o1, MassPerLengthSqrTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerLengthSqrTimeSqr o1, LengthPerMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthPerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrMassPerLengthSqr o1, LengthPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthPerMass o1, PerLengthMassTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthMassTimeCub o1, LengthPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(LengthPerMass o1, TimeCubPerLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubPerLengthMass o1, LengthPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(LengthPerMass o1, MassPerLengthTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(MassPerLengthTimeCub o1, LengthPerMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthPerMass o1, TimeCubMassPerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubMassPerLength o1, LengthPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthPerMass o1, LengthPerMassTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthPerMassTimeCub o1, LengthPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthPerMass o1, TimeCubLengthPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLengthPerMass o1, LengthPerMass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(LengthPerMass o1, LengthMassPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthMassPerTimeCub o1, LengthPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthPerMass o1, TimeCubLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubLengthMass o1, LengthPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthPerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrPerMassTimeSqr o1, LengthPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthPerMass o1, LengthSqrTimeSqrPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthSqrTimeSqrPerMass o1, LengthPerMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(LengthPerMass o1, LengthSqrPerTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthSqrPerTimeCub o1, LengthPerMass o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(LengthPerMass o1, LengthSqrPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrPerTimeCub o1, LengthPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(LengthPerMass o1, TimeCubLengthSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeCubLengthSqr o1, LengthPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthPerMass o1, TimeCubLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCubLengthSqr o1, LengthPerMass o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthPerMass o1, LengthSqrMassPerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrMassPerTimeSqr o1, LengthPerMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthPerMass o1, LengthSqrTimeSqrMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrTimeSqrMass o1, LengthPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthPerMass o1, LengthCubPerMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerMassTime o1, LengthPerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthPerMass o1, LengthCubTimePerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimePerMass o1, LengthPerMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(LengthPerMass o1, LengthCubPerTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubPerTimeSqr o1, LengthPerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(LengthPerMass o1, LengthCubTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubTimeSqr o1, LengthPerMass o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(LengthPerMass o1, PerLengthCubTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerLengthCubTimeCub o1, LengthPerMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(LengthPerMass o1, TimeCubPerLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCubPerLengthCub o1, LengthPerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthPerMass o1, MassPerTimeSqrLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerTimeSqrLengthCub o1, LengthPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthPerMass o1, TimeSqrMassPerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthPerMass o1, PerMassLengthSqrTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerMassLengthSqrTimeCub o1, LengthPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(LengthPerMass o1, TimeCubPerMassLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubPerMassLengthSqr o1, LengthPerMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthPerMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(MassPerLengthSqrTimeCub o1, LengthPerMass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthPerMass o1, TimeCubMassPerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubMassPerLengthSqr o1, LengthPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(LengthPerMass o1, LengthSqrPerMassTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrPerMassTimeCub o1, LengthPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthPerMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubLengthSqrPerMass o1, LengthPerMass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthPerMass o1, LengthSqrMassPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrMassPerTimeCub o1, LengthPerMass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthPerMass o1, TimeCubLengthSqrMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLengthSqrMass o1, LengthPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthPerMass o1, LengthCubPerMassTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerMassTimeSqr o1, LengthPerMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthPerMass o1, LengthCubTimeSqrPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeSqrPerMass o1, LengthPerMass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(LengthPerMass o1, LengthCubPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubPerTimeCub o1, LengthPerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(LengthPerMass o1, LengthCubTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubTimeCub o1, LengthPerMass o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(LengthPerMass o1, MassPerLengthCubTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerLengthCubTimeCub o1, LengthPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(LengthPerMass o1, TimeCubMassPerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubMassPerLengthCub o1, LengthPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(LengthPerMass o1, LengthCubPerMassTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerMassTimeCub o1, LengthPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(LengthPerMass o1, LengthCubTimeCubPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTimeCubPerMass o1, LengthPerMass o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthPerMass is outside its bounds.");
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
    