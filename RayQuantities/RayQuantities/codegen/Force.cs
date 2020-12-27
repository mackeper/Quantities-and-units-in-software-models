
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Force : Quantity, IEquatable<Force>, IComparable
  {  
    internal Force(double value) : base(value, 2)
    {
      Force.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Force(double value, double minValue, double maxValue) : base(value, 2)
    {
      Force.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Force(Force other) : base(other)
    {
      Force.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Force"))
    {
      switch(FakeDatabase.Units["Force"])
      {
        case "centimeterkilogrampersecondsqr": displayUnit_ = centimeterkilogrampersecondsqr_; break;
        case "millimeterkilogrampersecondsqr": displayUnit_ = millimeterkilogrampersecondsqr_; break;
        case "meterkilogrampersecondsqr": displayUnit_ = meterkilogrampersecondsqr_; break;
        case "inchkilogrampersecondsqr": displayUnit_ = inchkilogrampersecondsqr_; break;
        case "newton": displayUnit_ = newton_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterkilogrampersecondsqr_ = new Unit_("CentimeterKilogramPerSecondSqr", "cm kg/s²", 1.0, 0);
  private static Unit_ millimeterkilogrampersecondsqr_ = new Unit_("MillimeterKilogramPerSecondSqr", "mm kg/s²", 0.1, 0);
  private static Unit_ meterkilogrampersecondsqr_ = new Unit_("MeterKilogramPerSecondSqr", "m kg/s²", 100.0, 0);
  private static Unit_ inchkilogrampersecondsqr_ = new Unit_("InchKilogramPerSecondSqr", "in kg/s²", 2.56, 0);
  private static Unit_ newton_ = new Unit_("Newton", "N", 1, 0);
  private static Unit_ platformUnit_ = centimeterkilogrampersecondsqr_;
  private static Unit_ displayUnit_ = centimeterkilogrampersecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Force other && Equals(other);
  public bool Equals(Force other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Force other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Force other)) throw new ArgumentException("Object is not a Force.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Force l1, Force l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Force l1, Force l2) => !(l1 == l2);
  public static bool operator <(Force l1, Force l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Force l1, Force l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Force l1, Force l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Force l1, Force l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Force FromCentimeterKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new Force((value + centimeterkilogrampersecondsqr_.Offset) * centimeterkilogrampersecondsqr_.Factor, minValue * centimeterkilogrampersecondsqr_.Factor, maxValue * centimeterkilogrampersecondsqr_.Factor);
  public static Force FromCentimeterKilogramPerSecondSqrs(double value) => new Force((value + centimeterkilogrampersecondsqr_.Offset) * centimeterkilogrampersecondsqr_.Factor);
  public double GetValueInCentimeterKilogramPerSecondSqrs() => (Value_ - centimeterkilogrampersecondsqr_.Offset) / centimeterkilogrampersecondsqr_.Factor;
  public static Force FromMillimeterKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new Force((value + millimeterkilogrampersecondsqr_.Offset) * millimeterkilogrampersecondsqr_.Factor, minValue * millimeterkilogrampersecondsqr_.Factor, maxValue * millimeterkilogrampersecondsqr_.Factor);
  public static Force FromMillimeterKilogramPerSecondSqrs(double value) => new Force((value + millimeterkilogrampersecondsqr_.Offset) * millimeterkilogrampersecondsqr_.Factor);
  public double GetValueInMillimeterKilogramPerSecondSqrs() => (Value_ - millimeterkilogrampersecondsqr_.Offset) / millimeterkilogrampersecondsqr_.Factor;
  public static Force FromMeterKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new Force((value + meterkilogrampersecondsqr_.Offset) * meterkilogrampersecondsqr_.Factor, minValue * meterkilogrampersecondsqr_.Factor, maxValue * meterkilogrampersecondsqr_.Factor);
  public static Force FromMeterKilogramPerSecondSqrs(double value) => new Force((value + meterkilogrampersecondsqr_.Offset) * meterkilogrampersecondsqr_.Factor);
  public double GetValueInMeterKilogramPerSecondSqrs() => (Value_ - meterkilogrampersecondsqr_.Offset) / meterkilogrampersecondsqr_.Factor;
  public static Force FromInchKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new Force((value + inchkilogrampersecondsqr_.Offset) * inchkilogrampersecondsqr_.Factor, minValue * inchkilogrampersecondsqr_.Factor, maxValue * inchkilogrampersecondsqr_.Factor);
  public static Force FromInchKilogramPerSecondSqrs(double value) => new Force((value + inchkilogrampersecondsqr_.Offset) * inchkilogrampersecondsqr_.Factor);
  public double GetValueInInchKilogramPerSecondSqrs() => (Value_ - inchkilogrampersecondsqr_.Offset) / inchkilogrampersecondsqr_.Factor;
  public static Force FromNewtons(double value, double minValue, double maxValue) => new Force((value + newton_.Offset) * newton_.Factor, minValue * newton_.Factor, maxValue * newton_.Factor);
  public static Force FromNewtons(double value) => new Force((value + newton_.Offset) * newton_.Factor);
  public double GetValueInNewtons() => (Value_ - newton_.Offset) / newton_.Factor;

#endregion

#region arithmetic
  public static Force operator+(Force o1, Force o2) => new Force(o1.Value_ + o2.Value_);
  public static Force operator-(Force o1, Force o2) => new Force(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Force o1, Force o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Force o1, LengthSqrPerMassTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrPerMassTime o1, Force o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator*(Force o1, LengthSqrTimePerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrTimePerMass o1, Force o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(Force o1, QDose o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(QDose o1, Force o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(Force o1, LengthSqrTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrTimeSqr o1, Force o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(Force o1, LengthSqrMassPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrMassPerTime o1, Force o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(Force o1, LengthSqrMassTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthSqrMassTime o1, Force o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(Force o1, LengthCubPerTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubPerTime o1, Force o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(Force o1, LengthCubTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthCubTime o1, Force o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(Force o1, LengthCubMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubMass o1, Force o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(Force o1, PerMassTimeLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerMassTimeLengthCub o1, Force o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(Force o1, TimePerMassLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimePerMassLengthCub o1, Force o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(Force o1, TimeSqrPerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(TimeSqrPerLengthCub o1, Force o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(Force o1, TimeSqrPerMassLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrPerMassLengthSqr o1, Force o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubMassTime operator/(Force o1, PerLengthSqrTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerLengthSqrTimeCub o1, Force o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(Force o1, TimeCubPerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimeCubPerLengthSqr o1, Force o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static Volume operator/(Force o1, MassPerLengthSqrTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(MassPerLengthSqrTimeSqr o1, Force o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static Time operator*(Force o1, TimeCubPerLengthMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubPerLengthMass o1, Force o2) => new Time(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(Force o1, MassPerLengthTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(MassPerLengthTimeCub o1, Force o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(Force o1, TimeCubLengthPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(TimeCubLengthPerMass o1, Force o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static Time operator/(Force o1, LengthMassPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthMassPerTimeCub o1, Force o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(Force o1, LengthSqrTimeSqrPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrTimeSqrPerMass o1, Force o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator/(Force o1, LengthSqrPerTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrPerTimeCub o1, Force o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Force o1, TimeCubLengthSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(TimeCubLengthSqr o1, Force o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(Force o1, LengthSqrMassPerTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrMassPerTimeSqr o1, Force o2) => new Length(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(Force o1, LengthCubPerTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubPerTimeSqr o1, Force o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(Force o1, LengthCubMassPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubMassPerTime o1, Force o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(Force o1, LengthCubMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubMassTime o1, Force o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(Force o1, TimeSqrPerMassLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeSqrPerMassLengthCub o1, Force o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(Force o1, TimeCubPerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimeCubPerLengthCub o1, Force o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(Force o1, TimeCubPerMassLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubPerMassLengthSqr o1, Force o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(Force o1, MassPerLengthSqrTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(MassPerLengthSqrTimeCub o1, Force o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(Force o1, TimeCubLengthSqrPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(TimeCubLengthSqrPerMass o1, Force o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(Force o1, LengthSqrMassPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrMassPerTimeCub o1, Force o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(Force o1, LengthCubPerTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubPerTimeCub o1, Force o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(Force o1, LengthCubMassPerTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubMassPerTimeSqr o1, Force o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(Force o1, TimeCubPerMassLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubPerMassLengthCub o1, Force o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(Force o1, LengthCubMassPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubMassPerTimeCub o1, Force o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Force is outside its bounds.");
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
    