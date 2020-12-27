
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthPerMassTime : Quantity, IEquatable<LengthPerMassTime>, IComparable
  {  
    internal LengthPerMassTime(double value) : base(value, 2)
    {
      LengthPerMassTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthPerMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthPerMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthPerMassTime(LengthPerMassTime other) : base(other)
    {
      LengthPerMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthPerMassTime"))
    {
      switch(FakeDatabase.Units["LengthPerMassTime"])
      {
        case "centimeterperkilogramsecond": displayUnit_ = centimeterperkilogramsecond_; break;
        case "millimeterperkilogramsecond": displayUnit_ = millimeterperkilogramsecond_; break;
        case "meterperkilogramsecond": displayUnit_ = meterperkilogramsecond_; break;
        case "inchperkilogramsecond": displayUnit_ = inchperkilogramsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterperkilogramsecond_ = new Unit_("CentimeterPerKilogramSecond", "cm/kg s", 1.0, 0);
  private static Unit_ millimeterperkilogramsecond_ = new Unit_("MillimeterPerKilogramSecond", "mm/kg s", 0.1, 0);
  private static Unit_ meterperkilogramsecond_ = new Unit_("MeterPerKilogramSecond", "m/kg s", 100.0, 0);
  private static Unit_ inchperkilogramsecond_ = new Unit_("InchPerKilogramSecond", "in/kg s", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterperkilogramsecond_;
  private static Unit_ displayUnit_ = centimeterperkilogramsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthPerMassTime other && Equals(other);
  public bool Equals(LengthPerMassTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthPerMassTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthPerMassTime other)) throw new ArgumentException("Object is not a LengthPerMassTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthPerMassTime l1, LengthPerMassTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthPerMassTime l1, LengthPerMassTime l2) => !(l1 == l2);
  public static bool operator <(LengthPerMassTime l1, LengthPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthPerMassTime l1, LengthPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthPerMassTime l1, LengthPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthPerMassTime l1, LengthPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthPerMassTime FromCentimeterPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthPerMassTime((value + centimeterperkilogramsecond_.Offset) * centimeterperkilogramsecond_.Factor, minValue * centimeterperkilogramsecond_.Factor, maxValue * centimeterperkilogramsecond_.Factor);
  public static LengthPerMassTime FromCentimeterPerKilogramSeconds(double value) => new LengthPerMassTime((value + centimeterperkilogramsecond_.Offset) * centimeterperkilogramsecond_.Factor);
  public double GetValueInCentimeterPerKilogramSeconds() => (Value_ - centimeterperkilogramsecond_.Offset) / centimeterperkilogramsecond_.Factor;
  public static LengthPerMassTime FromMillimeterPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthPerMassTime((value + millimeterperkilogramsecond_.Offset) * millimeterperkilogramsecond_.Factor, minValue * millimeterperkilogramsecond_.Factor, maxValue * millimeterperkilogramsecond_.Factor);
  public static LengthPerMassTime FromMillimeterPerKilogramSeconds(double value) => new LengthPerMassTime((value + millimeterperkilogramsecond_.Offset) * millimeterperkilogramsecond_.Factor);
  public double GetValueInMillimeterPerKilogramSeconds() => (Value_ - millimeterperkilogramsecond_.Offset) / millimeterperkilogramsecond_.Factor;
  public static LengthPerMassTime FromMeterPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthPerMassTime((value + meterperkilogramsecond_.Offset) * meterperkilogramsecond_.Factor, minValue * meterperkilogramsecond_.Factor, maxValue * meterperkilogramsecond_.Factor);
  public static LengthPerMassTime FromMeterPerKilogramSeconds(double value) => new LengthPerMassTime((value + meterperkilogramsecond_.Offset) * meterperkilogramsecond_.Factor);
  public double GetValueInMeterPerKilogramSeconds() => (Value_ - meterperkilogramsecond_.Offset) / meterperkilogramsecond_.Factor;
  public static LengthPerMassTime FromInchPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthPerMassTime((value + inchperkilogramsecond_.Offset) * inchperkilogramsecond_.Factor, minValue * inchperkilogramsecond_.Factor, maxValue * inchperkilogramsecond_.Factor);
  public static LengthPerMassTime FromInchPerKilogramSeconds(double value) => new LengthPerMassTime((value + inchperkilogramsecond_.Offset) * inchperkilogramsecond_.Factor);
  public double GetValueInInchPerKilogramSeconds() => (Value_ - inchperkilogramsecond_.Offset) / inchperkilogramsecond_.Factor;

#endregion

#region arithmetic
  public static LengthPerMassTime operator+(LengthPerMassTime o1, LengthPerMassTime o2) => new LengthPerMassTime(o1.Value_ + o2.Value_);
  public static LengthPerMassTime operator-(LengthPerMassTime o1, LengthPerMassTime o2) => new LengthPerMassTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthPerMassTime o1, LengthPerMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthPerMassTime o1, LengthTimePerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthTimePerMass o1, LengthPerMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(LengthPerMassTime o1, Acceleration o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(Acceleration o1, LengthPerMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(LengthPerMassTime o1, Acceleration o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(Acceleration o1, LengthPerMassTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(LengthPerMassTime o1, TimeSqrLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(TimeSqrLength o1, LengthPerMassTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(LengthPerMassTime o1, TimeSqrLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeSqrLength o1, LengthPerMassTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthPerMassTime o1, LengthMassPerTime o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthMassPerTime o1, LengthPerMassTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static Area operator*(LengthPerMassTime o1, LengthMassTime o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthMassTime o1, LengthPerMassTime o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthPerMassTime o1, LengthSqrPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrPerMass o1, LengthPerMassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthPerMassTime o1, LengthSqrPerTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrPerTime o1, LengthPerMassTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(LengthPerMassTime o1, LengthSqrPerTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrPerTime o1, LengthPerMassTime o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthPerMassTime o1, LengthSqrTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrTime o1, LengthPerMassTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthPerMassTime o1, LengthSqrTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthSqrTime o1, LengthPerMassTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthPerMassTime o1, LengthSqrMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrMass o1, LengthPerMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthPerMassTime o1, Volume o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(Volume o1, LengthPerMassTime o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(LengthPerMassTime o1, PerTimeLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerTimeLengthCub o1, LengthPerMassTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthPerMassTime o1, TimePerLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimePerLengthCub o1, LengthPerMassTime o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthPerMassTime o1, Density o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(Density o1, LengthPerMassTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthPerMassTime o1, PerMassTimeLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassTimeLengthSqr o1, LengthPerMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthPerMassTime o1, TimePerMassLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimePerMassLengthSqr o1, LengthPerMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(LengthPerMassTime o1, PerLengthSqrTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerLengthSqrTimeSqr o1, LengthPerMassTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(LengthPerMassTime o1, PerLengthSqrTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(PerLengthSqrTimeSqr o1, LengthPerMassTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(LengthPerMassTime o1, TimeSqrPerLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeSqrPerLengthSqr o1, LengthPerMassTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthPerMassTime o1, TimeSqrPerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeSqrPerLengthSqr o1, LengthPerMassTime o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthPerMassTime o1, MassPerTimeLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(MassPerTimeLengthSqr o1, LengthPerMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthPerMassTime o1, MassTimePerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(MassTimePerLengthSqr o1, LengthPerMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(LengthPerMassTime o1, PerLengthMassTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(LengthPerMassTime o1, TimeSqrPerLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeSqrPerLengthMass o1, LengthPerMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(LengthPerMassTime o1, PerLengthTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(PerLengthTimeCub o1, LengthPerMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthPerMassTime o1, TimeCubPerLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubPerLength o1, LengthPerMassTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthPerMassTime o1, MassPerLengthTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(MassPerLengthTimeSqr o1, LengthPerMassTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthPerMassTime o1, TimeSqrMassPerLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrMassPerLength o1, LengthPerMassTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator/(LengthPerMassTime o1, PerMassTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerMassTimeCub o1, LengthPerMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(LengthPerMassTime o1, TimeCubMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubMass o1, LengthPerMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthPerMassTime o1, LengthPerMassTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthPerMassTimeSqr o1, LengthPerMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthPerMassTime o1, TimeSqrLengthPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeSqrLengthPerMass o1, LengthPerMassTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthPerMassTime o1, LengthPerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthPerTimeCub o1, LengthPerMassTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(LengthPerMassTime o1, TimeCubLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeCubLength o1, LengthPerMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(LengthPerMassTime o1, Force o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(Force o1, LengthPerMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(LengthPerMassTime o1, TimeSqrLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(TimeSqrLengthMass o1, LengthPerMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthPerMassTime o1, LengthSqrPerMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrPerMassTime o1, LengthPerMassTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthPerMassTime o1, LengthSqrTimePerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthSqrTimePerMass o1, LengthPerMassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(LengthPerMassTime o1, QDose o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(QDose o1, LengthPerMassTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(LengthPerMassTime o1, QDose o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(QDose o1, LengthPerMassTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(LengthPerMassTime o1, LengthSqrTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthSqrTimeSqr o1, LengthPerMassTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthPerMassTime o1, LengthSqrTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(LengthSqrTimeSqr o1, LengthPerMassTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthPerMassTime o1, LengthSqrMassPerTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrMassPerTime o1, LengthPerMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator*(LengthPerMassTime o1, LengthSqrMassTime o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrMassTime o1, LengthPerMassTime o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthPerMassTime o1, LengthCubPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubPerMass o1, LengthPerMassTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthPerMassTime o1, LengthCubPerTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubPerTime o1, LengthPerMassTime o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(LengthPerMassTime o1, LengthCubTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubTime o1, LengthPerMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(LengthPerMassTime o1, PerTimeSqrLengthCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerTimeSqrLengthCub o1, LengthPerMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerMassLengthSqr operator*(LengthPerMassTime o1, TimeSqrPerLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeSqrPerLengthCub o1, LengthPerMassTime o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthPerMassTime o1, MassPerTimeLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(MassPerTimeLengthCub o1, LengthPerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthPerMassTime o1, MassTimePerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(MassTimePerLengthCub o1, LengthPerMassTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(LengthPerMassTime o1, PerMassLengthSqrTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerMassLengthSqrTimeSqr o1, LengthPerMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(LengthPerMassTime o1, TimeSqrPerMassLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeSqrPerMassLengthSqr o1, LengthPerMassTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator/(LengthPerMassTime o1, PerLengthSqrTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(PerLengthSqrTimeCub o1, LengthPerMassTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthPerMassTime o1, TimeCubPerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeCubPerLengthSqr o1, LengthPerMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthPerMassTime o1, MassPerLengthSqrTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(MassPerLengthSqrTimeSqr o1, LengthPerMassTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthPerMassTime o1, TimeSqrMassPerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqrMassPerLengthSqr o1, LengthPerMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator/(LengthPerMassTime o1, PerLengthMassTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthMassTimeCub o1, LengthPerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(LengthPerMassTime o1, TimeCubMassPerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubMassPerLength o1, LengthPerMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator/(LengthPerMassTime o1, LengthPerMassTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthPerMassTimeCub o1, LengthPerMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(LengthPerMassTime o1, TimeCubLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(TimeCubLengthMass o1, LengthPerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthPerMassTime o1, LengthSqrPerMassTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerMassTimeSqr o1, LengthPerMassTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthPerMassTime o1, LengthSqrTimeSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthSqrTimeSqrPerMass o1, LengthPerMassTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(LengthPerMassTime o1, LengthSqrPerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthSqrPerTimeCub o1, LengthPerMassTime o2) => new Force(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(LengthPerMassTime o1, TimeCubLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(TimeCubLengthSqr o1, LengthPerMassTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthPerMassTime o1, LengthSqrMassPerTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrMassPerTimeSqr o1, LengthPerMassTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator*(LengthPerMassTime o1, LengthSqrTimeSqrMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrTimeSqrMass o1, LengthPerMassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(LengthPerMassTime o1, LengthCubPerMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerMassTime o1, LengthPerMassTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthPerMassTime o1, LengthCubTimePerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimePerMass o1, LengthPerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(LengthPerMassTime o1, LengthCubPerTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubPerTimeSqr o1, LengthPerMassTime o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(LengthPerMassTime o1, LengthCubTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubTimeSqr o1, LengthPerMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(LengthPerMassTime o1, TimeCubPerLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeCubPerLengthCub o1, LengthPerMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(LengthPerMassTime o1, MassPerTimeSqrLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerTimeSqrLengthCub o1, LengthPerMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthPerMassTime o1, TimeSqrMassPerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthPerMassTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthPerMassTime o1, PerMassLengthSqrTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerMassLengthSqrTimeCub o1, LengthPerMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthPerMassTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubMassPerLengthSqr o1, LengthPerMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthPerMassTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrPerMassTimeCub o1, LengthPerMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthPerMassTime o1, TimeCubLengthSqrMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(TimeCubLengthSqrMass o1, LengthPerMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthPerMassTime o1, LengthCubPerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerMassTimeSqr o1, LengthPerMassTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(LengthPerMassTime o1, LengthCubTimeSqrPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTimeSqrPerMass o1, LengthPerMassTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(LengthPerMassTime o1, LengthCubPerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubPerTimeCub o1, LengthPerMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthPerMassTime o1, TimeCubMassPerLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeCubMassPerLengthCub o1, LengthPerMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthPerMassTime o1, LengthCubPerMassTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubPerMassTimeCub o1, LengthPerMassTime o2) => new QDose(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthPerMassTime is outside its bounds.");
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
    