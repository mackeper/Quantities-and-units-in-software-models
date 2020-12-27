
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrPerTime : Quantity, IEquatable<LengthSqrPerTime>, IComparable
  {  
    internal LengthSqrPerTime(double value) : base(value, 2)
    {
      LengthSqrPerTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrPerTime(LengthSqrPerTime other) : base(other)
    {
      LengthSqrPerTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerTime"))
    {
      switch(FakeDatabase.Units["LengthSqrPerTime"])
      {
        case "centimetersqrpersecond": displayUnit_ = centimetersqrpersecond_; break;
        case "millimetersqrpersecond": displayUnit_ = millimetersqrpersecond_; break;
        case "metersqrpersecond": displayUnit_ = metersqrpersecond_; break;
        case "inchsqrpersecond": displayUnit_ = inchsqrpersecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrpersecond_ = new Unit_("CentimeterSqrPerSecond", "cm²/s", 1.0, 0);
  private static Unit_ millimetersqrpersecond_ = new Unit_("MillimeterSqrPerSecond", "mm²/s", 0.010000000000000002, 0);
  private static Unit_ metersqrpersecond_ = new Unit_("MeterSqrPerSecond", "m²/s", 10000.0, 0);
  private static Unit_ inchsqrpersecond_ = new Unit_("InchSqrPerSecond", "in²/s", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrpersecond_;
  private static Unit_ displayUnit_ = centimetersqrpersecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrPerTime other && Equals(other);
  public bool Equals(LengthSqrPerTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrPerTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrPerTime other)) throw new ArgumentException("Object is not a LengthSqrPerTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrPerTime l1, LengthSqrPerTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrPerTime l1, LengthSqrPerTime l2) => !(l1 == l2);
  public static bool operator <(LengthSqrPerTime l1, LengthSqrPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrPerTime l1, LengthSqrPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrPerTime l1, LengthSqrPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrPerTime l1, LengthSqrPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrPerTime FromCentimeterSqrPerSeconds(double value, double minValue, double maxValue) => new LengthSqrPerTime((value + centimetersqrpersecond_.Offset) * centimetersqrpersecond_.Factor, minValue * centimetersqrpersecond_.Factor, maxValue * centimetersqrpersecond_.Factor);
  public static LengthSqrPerTime FromCentimeterSqrPerSeconds(double value) => new LengthSqrPerTime((value + centimetersqrpersecond_.Offset) * centimetersqrpersecond_.Factor);
  public double GetValueInCentimeterSqrPerSeconds() => (Value_ - centimetersqrpersecond_.Offset) / centimetersqrpersecond_.Factor;
  public static LengthSqrPerTime FromMillimeterSqrPerSeconds(double value, double minValue, double maxValue) => new LengthSqrPerTime((value + millimetersqrpersecond_.Offset) * millimetersqrpersecond_.Factor, minValue * millimetersqrpersecond_.Factor, maxValue * millimetersqrpersecond_.Factor);
  public static LengthSqrPerTime FromMillimeterSqrPerSeconds(double value) => new LengthSqrPerTime((value + millimetersqrpersecond_.Offset) * millimetersqrpersecond_.Factor);
  public double GetValueInMillimeterSqrPerSeconds() => (Value_ - millimetersqrpersecond_.Offset) / millimetersqrpersecond_.Factor;
  public static LengthSqrPerTime FromMeterSqrPerSeconds(double value, double minValue, double maxValue) => new LengthSqrPerTime((value + metersqrpersecond_.Offset) * metersqrpersecond_.Factor, minValue * metersqrpersecond_.Factor, maxValue * metersqrpersecond_.Factor);
  public static LengthSqrPerTime FromMeterSqrPerSeconds(double value) => new LengthSqrPerTime((value + metersqrpersecond_.Offset) * metersqrpersecond_.Factor);
  public double GetValueInMeterSqrPerSeconds() => (Value_ - metersqrpersecond_.Offset) / metersqrpersecond_.Factor;
  public static LengthSqrPerTime FromInchSqrPerSeconds(double value, double minValue, double maxValue) => new LengthSqrPerTime((value + inchsqrpersecond_.Offset) * inchsqrpersecond_.Factor, minValue * inchsqrpersecond_.Factor, maxValue * inchsqrpersecond_.Factor);
  public static LengthSqrPerTime FromInchSqrPerSeconds(double value) => new LengthSqrPerTime((value + inchsqrpersecond_.Offset) * inchsqrpersecond_.Factor);
  public double GetValueInInchSqrPerSeconds() => (Value_ - inchsqrpersecond_.Offset) / inchsqrpersecond_.Factor;

#endregion

#region arithmetic
  public static LengthSqrPerTime operator+(LengthSqrPerTime o1, LengthSqrPerTime o2) => new LengthSqrPerTime(o1.Value_ + o2.Value_);
  public static LengthSqrPerTime operator-(LengthSqrPerTime o1, LengthSqrPerTime o2) => new LengthSqrPerTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrPerTime o1, LengthSqrPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrPerTime o1, LengthSqrTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthSqrTime o1, LengthSqrPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(LengthSqrPerTime o1, LengthSqrMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrMass o1, LengthSqrPerTime o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrPerTime o1, Volume o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(Volume o1, LengthSqrPerTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthSqrPerTime o1, PerMassLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassLengthCub o1, LengthSqrPerTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrPerTime o1, PerTimeLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerTimeLengthCub o1, LengthSqrPerTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthSqrPerTime o1, TimePerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimePerLengthCub o1, LengthSqrPerTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrPerTime o1, Density o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(Density o1, LengthSqrPerTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(LengthSqrPerTime o1, PerMassTimeLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassTimeLengthSqr o1, LengthSqrPerTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(LengthSqrPerTime o1, TimePerMassLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimePerMassLengthSqr o1, LengthSqrPerTime o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthSqrPerTime o1, PerLengthSqrTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerLengthSqrTimeSqr o1, LengthSqrPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthSqrPerTime o1, TimeSqrPerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeSqrPerLengthSqr o1, LengthSqrPerTime o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthSqrPerTime o1, MassPerTimeLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerTimeLengthSqr o1, LengthSqrPerTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Mass operator*(LengthSqrPerTime o1, MassTimePerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassTimePerLengthSqr o1, LengthSqrPerTime o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(LengthSqrPerTime o1, PerLengthMassTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerLengthMassTimeSqr o1, LengthSqrPerTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(LengthSqrPerTime o1, PerLengthMassTimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(LengthSqrPerTime o1, TimeSqrPerLengthMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimeSqrPerLengthMass o1, LengthSqrPerTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthSqrPerTime o1, TimeSqrPerLengthMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeSqrPerLengthMass o1, LengthSqrPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthSqrPerTime o1, PerLengthTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerLengthTimeCub o1, LengthSqrPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(LengthSqrPerTime o1, TimeCubPerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeCubPerLength o1, LengthSqrPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(LengthSqrPerTime o1, MassPerLengthTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(MassPerLengthTimeSqr o1, LengthSqrPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(LengthSqrPerTime o1, MassPerLengthTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrPerTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(LengthSqrPerTime o1, TimeSqrMassPerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(TimeSqrMassPerLength o1, LengthSqrPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthSqrPerTime o1, TimeSqrMassPerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrPerTime o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(LengthSqrPerTime o1, PerMassTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassTimeCub o1, LengthSqrPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(LengthSqrPerTime o1, TimeCubPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeCubPerMass o1, LengthSqrPerTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(LengthSqrPerTime o1, MassPerTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerTimeCub o1, LengthSqrPerTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(LengthSqrPerTime o1, TimeCubMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeCubMass o1, LengthSqrPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(LengthSqrPerTime o1, LengthPerMassTimeSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthPerMassTimeSqr o1, LengthSqrPerTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(LengthSqrPerTime o1, LengthPerMassTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(LengthPerMassTimeSqr o1, LengthSqrPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(LengthSqrPerTime o1, TimeSqrLengthPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(TimeSqrLengthPerMass o1, LengthSqrPerTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrPerTime o1, TimeSqrLengthPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeSqrLengthPerMass o1, LengthSqrPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(LengthSqrPerTime o1, LengthPerTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(LengthPerTimeCub o1, LengthSqrPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthSqrPerTime o1, TimeCubLength o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(TimeCubLength o1, LengthSqrPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(LengthSqrPerTime o1, Force o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(Force o1, LengthSqrPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrPerTime o1, Force o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(Force o1, LengthSqrPerTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(LengthSqrPerTime o1, TimeSqrLengthMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(TimeSqrLengthMass o1, LengthSqrPerTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerTime o1, TimeSqrLengthMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeSqrLengthMass o1, LengthSqrPerTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(LengthSqrPerTime o1, LengthSqrPerMassTime o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthSqrPerMassTime o1, LengthSqrPerTime o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthSqrPerTime o1, LengthSqrTimePerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthSqrTimePerMass o1, LengthSqrPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(LengthSqrPerTime o1, QDose o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(QDose o1, LengthSqrPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthSqrPerTime o1, LengthSqrTimeSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(LengthSqrTimeSqr o1, LengthSqrPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(LengthSqrPerTime o1, LengthSqrMassPerTime o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthSqrMassPerTime o1, LengthSqrPerTime o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(LengthSqrPerTime o1, LengthSqrMassTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthSqrMassTime o1, LengthSqrPerTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrPerTime o1, LengthCubPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubPerMass o1, LengthSqrPerTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrPerTime o1, LengthCubPerTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubPerTime o1, LengthSqrPerTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrPerTime o1, LengthCubTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTime o1, LengthSqrPerTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(LengthSqrPerTime o1, LengthCubMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubMass o1, LengthSqrPerTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(LengthSqrPerTime o1, PerMassTimeLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassTimeLengthCub o1, LengthSqrPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(LengthSqrPerTime o1, TimePerMassLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimePerMassLengthCub o1, LengthSqrPerTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthSqrPerTime o1, PerTimeSqrLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerTimeSqrLengthCub o1, LengthSqrPerTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthSqrPerTime o1, TimeSqrPerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeSqrPerLengthCub o1, LengthSqrPerTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthSqrPerTime o1, MassPerTimeLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerTimeLengthCub o1, LengthSqrPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(LengthSqrPerTime o1, MassTimePerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassTimePerLengthCub o1, LengthSqrPerTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(LengthSqrPerTime o1, PerMassLengthSqrTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerMassLengthSqrTimeSqr o1, LengthSqrPerTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(LengthSqrPerTime o1, TimeSqrPerMassLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimeSqrPerMassLengthSqr o1, LengthSqrPerTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthSqrPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeCubPerLengthSqr o1, LengthSqrPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(LengthSqrPerTime o1, MassPerLengthSqrTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerLengthSqrTimeSqr o1, LengthSqrPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(LengthSqrPerTime o1, TimeSqrMassPerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrMass operator/(LengthSqrPerTime o1, PerLengthMassTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthMassTimeCub o1, LengthSqrPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(LengthSqrPerTime o1, TimeCubPerLengthMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeCubPerLengthMass o1, LengthSqrPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator/(LengthSqrPerTime o1, MassPerLengthTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerLengthTimeCub o1, LengthSqrPerTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(LengthSqrPerTime o1, TimeCubMassPerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeCubMassPerLength o1, LengthSqrPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator/(LengthSqrPerTime o1, LengthPerMassTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthPerMassTimeCub o1, LengthSqrPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(LengthSqrPerTime o1, TimeCubLengthPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(TimeCubLengthPerMass o1, LengthSqrPerTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(LengthSqrPerTime o1, LengthMassPerTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(LengthMassPerTimeCub o1, LengthSqrPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(LengthSqrPerTime o1, TimeCubLengthMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(TimeCubLengthMass o1, LengthSqrPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static MassTime operator/(LengthSqrPerTime o1, LengthSqrPerMassTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(LengthSqrPerTime o1, LengthSqrTimeSqrPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(LengthSqrTimeSqrPerMass o1, LengthSqrPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(LengthSqrPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthSqrPerTimeCub o1, LengthSqrPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthSqrPerTime o1, LengthSqrMassPerTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthSqrMassPerTimeSqr o1, LengthSqrPerTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(LengthSqrPerTime o1, LengthSqrTimeSqrMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(LengthSqrTimeSqrMass o1, LengthSqrPerTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrPerTime o1, LengthCubPerMassTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubPerMassTime o1, LengthSqrPerTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthSqrPerTime o1, LengthCubTimePerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubTimePerMass o1, LengthSqrPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrPerTime o1, LengthCubPerTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubPerTimeSqr o1, LengthSqrPerTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthSqrPerTime o1, LengthCubTimeSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubTimeSqr o1, LengthSqrPerTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthSqrPerTime o1, LengthCubMassPerTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubMassPerTime o1, LengthSqrPerTime o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthSqrPerTime o1, LengthCubMassTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubMassTime o1, LengthSqrPerTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(LengthSqrPerTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerMassTimeSqrLengthCub o1, LengthSqrPerTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(LengthSqrPerTime o1, TimeSqrPerMassLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeSqrPerMassLengthCub o1, LengthSqrPerTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrPerTime o1, TimeCubPerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeCubPerLengthCub o1, LengthSqrPerTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(LengthSqrPerTime o1, MassPerTimeSqrLengthCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerTimeSqrLengthCub o1, LengthSqrPerTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(LengthSqrPerTime o1, TimeSqrMassPerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(LengthSqrPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeCubPerMassLengthSqr o1, LengthSqrPerTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(LengthSqrPerTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator/(LengthSqrPerTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(LengthSqrPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthSqrMassPerTimeCub o1, LengthSqrPerTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(LengthSqrPerTime o1, LengthCubPerMassTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator/(LengthSqrPerTime o1, LengthCubTimeSqrPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthCubTimeSqrPerMass o1, LengthSqrPerTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrPerTime o1, LengthCubPerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubPerTimeCub o1, LengthSqrPerTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(LengthSqrPerTime o1, LengthCubMassPerTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthCubMassPerTimeSqr o1, LengthSqrPerTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator/(LengthSqrPerTime o1, LengthCubTimeSqrMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(LengthCubTimeSqrMass o1, LengthSqrPerTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(LengthSqrPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeCubPerMassLengthCub o1, LengthSqrPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(LengthSqrPerTime o1, TimeCubMassPerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator/(LengthSqrPerTime o1, LengthCubPerMassTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthCubPerMassTimeCub o1, LengthSqrPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(LengthSqrPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthCubMassPerTimeCub o1, LengthSqrPerTime o2) => new Force(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrPerTime is outside its bounds.");
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
    