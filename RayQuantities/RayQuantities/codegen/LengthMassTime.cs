
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthMassTime : Quantity, IEquatable<LengthMassTime>, IComparable
  {  
    internal LengthMassTime(double value) : base(value, 2)
    {
      LengthMassTime.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthMassTime(LengthMassTime other) : base(other)
    {
      LengthMassTime.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthMassTime"))
    {
      switch(FakeDatabase.Units["LengthMassTime"])
      {
        case "centimeterkilogramsecond": displayUnit_ = centimeterkilogramsecond_; break;
        case "millimeterkilogramsecond": displayUnit_ = millimeterkilogramsecond_; break;
        case "meterkilogramsecond": displayUnit_ = meterkilogramsecond_; break;
        case "inchkilogramsecond": displayUnit_ = inchkilogramsecond_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterkilogramsecond_ = new Unit_("CentimeterKilogramSecond", "cm kg s", 1, 0);
  private static Unit_ millimeterkilogramsecond_ = new Unit_("MillimeterKilogramSecond", "mm kg s", 0.1, 0);
  private static Unit_ meterkilogramsecond_ = new Unit_("MeterKilogramSecond", "m kg s", 100, 0);
  private static Unit_ inchkilogramsecond_ = new Unit_("InchKilogramSecond", "in kg s", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterkilogramsecond_;
  private static Unit_ displayUnit_ = centimeterkilogramsecond_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthMassTime other && Equals(other);
  public bool Equals(LengthMassTime other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthMassTime other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthMassTime other)) throw new ArgumentException("Object is not a LengthMassTime.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthMassTime l1, LengthMassTime l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthMassTime l1, LengthMassTime l2) => !(l1 == l2);
  public static bool operator <(LengthMassTime l1, LengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthMassTime l1, LengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthMassTime l1, LengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthMassTime l1, LengthMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthMassTime FromCentimeterKilogramSeconds(double value, double minValue, double maxValue) => new LengthMassTime((value + centimeterkilogramsecond_.Offset) * centimeterkilogramsecond_.Factor, minValue * centimeterkilogramsecond_.Factor, maxValue * centimeterkilogramsecond_.Factor);
  public static LengthMassTime FromCentimeterKilogramSeconds(double value) => new LengthMassTime((value + centimeterkilogramsecond_.Offset) * centimeterkilogramsecond_.Factor);
  public double GetValueInCentimeterKilogramSeconds() => (Value_ - centimeterkilogramsecond_.Offset) / centimeterkilogramsecond_.Factor;
  public static LengthMassTime FromMillimeterKilogramSeconds(double value, double minValue, double maxValue) => new LengthMassTime((value + millimeterkilogramsecond_.Offset) * millimeterkilogramsecond_.Factor, minValue * millimeterkilogramsecond_.Factor, maxValue * millimeterkilogramsecond_.Factor);
  public static LengthMassTime FromMillimeterKilogramSeconds(double value) => new LengthMassTime((value + millimeterkilogramsecond_.Offset) * millimeterkilogramsecond_.Factor);
  public double GetValueInMillimeterKilogramSeconds() => (Value_ - millimeterkilogramsecond_.Offset) / millimeterkilogramsecond_.Factor;
  public static LengthMassTime FromMeterKilogramSeconds(double value, double minValue, double maxValue) => new LengthMassTime((value + meterkilogramsecond_.Offset) * meterkilogramsecond_.Factor, minValue * meterkilogramsecond_.Factor, maxValue * meterkilogramsecond_.Factor);
  public static LengthMassTime FromMeterKilogramSeconds(double value) => new LengthMassTime((value + meterkilogramsecond_.Offset) * meterkilogramsecond_.Factor);
  public double GetValueInMeterKilogramSeconds() => (Value_ - meterkilogramsecond_.Offset) / meterkilogramsecond_.Factor;
  public static LengthMassTime FromInchKilogramSeconds(double value, double minValue, double maxValue) => new LengthMassTime((value + inchkilogramsecond_.Offset) * inchkilogramsecond_.Factor, minValue * inchkilogramsecond_.Factor, maxValue * inchkilogramsecond_.Factor);
  public static LengthMassTime FromInchKilogramSeconds(double value) => new LengthMassTime((value + inchkilogramsecond_.Offset) * inchkilogramsecond_.Factor);
  public double GetValueInInchKilogramSeconds() => (Value_ - inchkilogramsecond_.Offset) / inchkilogramsecond_.Factor;

#endregion

#region arithmetic
  public static LengthMassTime operator+(LengthMassTime o1, LengthMassTime o2) => new LengthMassTime(o1.Value_ + o2.Value_);
  public static LengthMassTime operator-(LengthMassTime o1, LengthMassTime o2) => new LengthMassTime(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthMassTime o1, LengthMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(LengthMassTime o1, LengthSqrPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrPerMass o1, LengthMassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator*(LengthMassTime o1, LengthSqrPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrPerTime o1, LengthMassTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(LengthMassTime o1, LengthSqrPerTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthSqrPerTime o1, LengthMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(LengthMassTime o1, LengthSqrTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthSqrTime o1, LengthMassTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(LengthMassTime o1, LengthSqrTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrTime o1, LengthMassTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthMassTime o1, LengthSqrMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrMass o1, LengthMassTime o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(LengthMassTime o1, Volume o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(Volume o1, LengthMassTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthMassTime o1, PerMassLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerMassLengthCub o1, LengthMassTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(LengthMassTime o1, PerTimeLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerTimeLengthCub o1, LengthMassTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(LengthMassTime o1, TimePerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimePerLengthCub o1, LengthMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthMassTime o1, PerMassTimeLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassTimeLengthSqr o1, LengthMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthMassTime o1, TimePerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimePerMassLengthSqr o1, LengthMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthMassTime o1, PerLengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerLengthSqrTimeSqr o1, LengthMassTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthMassTime o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthSqrTimeSqr o1, LengthMassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthMassTime o1, TimeSqrPerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeSqrPerLengthSqr o1, LengthMassTime o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(LengthMassTime o1, TimeSqrPerLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimeSqrPerLengthSqr o1, LengthMassTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthMassTime o1, MassPerTimeLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassPerTimeLengthSqr o1, LengthMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(LengthMassTime o1, MassTimePerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(MassTimePerLengthSqr o1, LengthMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(LengthMassTime o1, PerLengthMassTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthMassTimeSqr o1, LengthMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthMassTime o1, TimeSqrPerLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeSqrPerLengthMass o1, LengthMassTime o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthMassTime o1, PerLengthTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(PerLengthTimeCub o1, LengthMassTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(LengthMassTime o1, TimeCubPerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeCubPerLength o1, LengthMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthMassTime o1, MassPerLengthTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(MassPerLengthTimeSqr o1, LengthMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(LengthMassTime o1, TimeSqrMassPerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeSqrMassPerLength o1, LengthMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthMassTime o1, PerMassTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerMassTimeCub o1, LengthMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(LengthMassTime o1, TimeCubMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubMass o1, LengthMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(LengthMassTime o1, LengthPerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthPerMassTimeSqr o1, LengthMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthMassTime o1, TimeSqrLengthPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeSqrLengthPerMass o1, LengthMassTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(LengthMassTime o1, LengthPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthPerTimeCub o1, LengthMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthMassTime o1, TimeCubLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubLength o1, LengthMassTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(LengthMassTime o1, Force o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(Force o1, LengthMassTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthMassTime o1, TimeSqrLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrLengthMass o1, LengthMassTime o2) => new Time(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthMassTime o1, LengthSqrPerMassTime o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrPerMassTime o1, LengthMassTime o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthMassTime o1, LengthSqrTimePerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrTimePerMass o1, LengthMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator*(LengthMassTime o1, QDose o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(QDose o1, LengthMassTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(LengthMassTime o1, QDose o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(QDose o1, LengthMassTime o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(LengthMassTime o1, LengthSqrTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthSqrTimeSqr o1, LengthMassTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(LengthMassTime o1, LengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrTimeSqr o1, LengthMassTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthMassTime o1, LengthSqrMassPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrMassPerTime o1, LengthMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthMassTime o1, LengthSqrMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrMassTime o1, LengthMassTime o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(LengthMassTime o1, LengthCubPerTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthCubPerTime o1, LengthMassTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(LengthMassTime o1, LengthCubTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubTime o1, LengthMassTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthMassTime o1, LengthCubMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubMass o1, LengthMassTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(LengthMassTime o1, PerMassTimeLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassTimeLengthCub o1, LengthMassTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthMassTime o1, TimePerMassLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimePerMassLengthCub o1, LengthMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(LengthMassTime o1, PerTimeSqrLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(PerTimeSqrLengthCub o1, LengthMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(LengthMassTime o1, TimeSqrPerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeSqrPerLengthCub o1, LengthMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(LengthMassTime o1, PerMassLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassLengthSqrTimeSqr o1, LengthMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthMassTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrPerMassLengthSqr o1, LengthMassTime o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthMassTime o1, PerLengthSqrTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(PerLengthSqrTimeCub o1, LengthMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator/(LengthMassTime o1, TimeCubPerLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeCubPerLengthSqr o1, LengthMassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthMassTime o1, MassPerLengthSqrTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(MassPerLengthSqrTimeSqr o1, LengthMassTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(LengthMassTime o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeSqrMassPerLengthSqr o1, LengthMassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(LengthMassTime o1, PerLengthMassTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthMassTimeCub o1, LengthMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static QDose operator/(LengthMassTime o1, TimeCubMassPerLength o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeCubMassPerLength o1, LengthMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthMassTime o1, LengthPerMassTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthPerMassTimeCub o1, LengthMassTime o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator/(LengthMassTime o1, TimeCubLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubLengthMass o1, LengthMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthMassTime o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrPerMassTimeSqr o1, LengthMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthMassTime o1, LengthSqrTimeSqrPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrTimeSqrPerMass o1, LengthMassTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(LengthMassTime o1, LengthSqrPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthSqrPerTimeCub o1, LengthMassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthMassTime o1, TimeCubLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubLengthSqr o1, LengthMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(LengthMassTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, LengthMassTime o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthMassTime o1, LengthSqrTimeSqrMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrTimeSqrMass o1, LengthMassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(LengthMassTime o1, LengthCubPerTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerTimeSqr o1, LengthMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(LengthMassTime o1, LengthCubTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTimeSqr o1, LengthMassTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthMassTime o1, LengthCubMassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubMassPerTime o1, LengthMassTime o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(LengthMassTime o1, LengthCubMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubMassTime o1, LengthMassTime o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthMassTime o1, PerMassTimeSqrLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerMassTimeSqrLengthCub o1, LengthMassTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(LengthMassTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(LengthMassTime o1, PerLengthCubTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(PerLengthCubTimeCub o1, LengthMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthMassTime o1, PerMassLengthSqrTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerMassLengthSqrTimeCub o1, LengthMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthMassTime o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeCubMassPerLengthSqr o1, LengthMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthMassTime o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrPerMassTimeCub o1, LengthMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthMassTime o1, TimeCubLengthSqrMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubLengthSqrMass o1, LengthMassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(LengthMassTime o1, LengthCubTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubTimeCub o1, LengthMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(LengthMassTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthMassTime o1, LengthCubTimeSqrMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeSqrMass o1, LengthMassTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthMassTime o1, PerMassLengthCubTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthMassTime o1, LengthCubTimeCubMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeCubMass o1, LengthMassTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthMassTime is outside its bounds.");
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
    