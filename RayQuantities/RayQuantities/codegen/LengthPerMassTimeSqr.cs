
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthPerMassTimeSqr : Quantity, IEquatable<LengthPerMassTimeSqr>, IComparable
  {  
    internal LengthPerMassTimeSqr(double value) : base(value, 2)
    {
      LengthPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthPerMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthPerMassTimeSqr(LengthPerMassTimeSqr other) : base(other)
    {
      LengthPerMassTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthPerMassTimeSqr"))
    {
      switch(FakeDatabase.Units["LengthPerMassTimeSqr"])
      {
        case "centimeterperkilogramsecondsqr": displayUnit_ = centimeterperkilogramsecondsqr_; break;
        case "millimeterperkilogramsecondsqr": displayUnit_ = millimeterperkilogramsecondsqr_; break;
        case "meterperkilogramsecondsqr": displayUnit_ = meterperkilogramsecondsqr_; break;
        case "inchperkilogramsecondsqr": displayUnit_ = inchperkilogramsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterperkilogramsecondsqr_ = new Unit_("CentimeterPerKilogramSecondSqr", "cm/kg s²", 1.0, 0);
  private static Unit_ millimeterperkilogramsecondsqr_ = new Unit_("MillimeterPerKilogramSecondSqr", "mm/kg s²", 0.1, 0);
  private static Unit_ meterperkilogramsecondsqr_ = new Unit_("MeterPerKilogramSecondSqr", "m/kg s²", 100.0, 0);
  private static Unit_ inchperkilogramsecondsqr_ = new Unit_("InchPerKilogramSecondSqr", "in/kg s²", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterperkilogramsecondsqr_;
  private static Unit_ displayUnit_ = centimeterperkilogramsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthPerMassTimeSqr other && Equals(other);
  public bool Equals(LengthPerMassTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthPerMassTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthPerMassTimeSqr other)) throw new ArgumentException("Object is not a LengthPerMassTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => !(l1 == l2);
  public static bool operator <(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthPerMassTimeSqr l1, LengthPerMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthPerMassTimeSqr FromCentimeterPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthPerMassTimeSqr((value + centimeterperkilogramsecondsqr_.Offset) * centimeterperkilogramsecondsqr_.Factor, minValue * centimeterperkilogramsecondsqr_.Factor, maxValue * centimeterperkilogramsecondsqr_.Factor);
  public static LengthPerMassTimeSqr FromCentimeterPerKilogramSecondSqrs(double value) => new LengthPerMassTimeSqr((value + centimeterperkilogramsecondsqr_.Offset) * centimeterperkilogramsecondsqr_.Factor);
  public double GetValueInCentimeterPerKilogramSecondSqrs() => (Value_ - centimeterperkilogramsecondsqr_.Offset) / centimeterperkilogramsecondsqr_.Factor;
  public static LengthPerMassTimeSqr FromMillimeterPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthPerMassTimeSqr((value + millimeterperkilogramsecondsqr_.Offset) * millimeterperkilogramsecondsqr_.Factor, minValue * millimeterperkilogramsecondsqr_.Factor, maxValue * millimeterperkilogramsecondsqr_.Factor);
  public static LengthPerMassTimeSqr FromMillimeterPerKilogramSecondSqrs(double value) => new LengthPerMassTimeSqr((value + millimeterperkilogramsecondsqr_.Offset) * millimeterperkilogramsecondsqr_.Factor);
  public double GetValueInMillimeterPerKilogramSecondSqrs() => (Value_ - millimeterperkilogramsecondsqr_.Offset) / millimeterperkilogramsecondsqr_.Factor;
  public static LengthPerMassTimeSqr FromMeterPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthPerMassTimeSqr((value + meterperkilogramsecondsqr_.Offset) * meterperkilogramsecondsqr_.Factor, minValue * meterperkilogramsecondsqr_.Factor, maxValue * meterperkilogramsecondsqr_.Factor);
  public static LengthPerMassTimeSqr FromMeterPerKilogramSecondSqrs(double value) => new LengthPerMassTimeSqr((value + meterperkilogramsecondsqr_.Offset) * meterperkilogramsecondsqr_.Factor);
  public double GetValueInMeterPerKilogramSecondSqrs() => (Value_ - meterperkilogramsecondsqr_.Offset) / meterperkilogramsecondsqr_.Factor;
  public static LengthPerMassTimeSqr FromInchPerKilogramSecondSqrs(double value, double minValue, double maxValue) => new LengthPerMassTimeSqr((value + inchperkilogramsecondsqr_.Offset) * inchperkilogramsecondsqr_.Factor, minValue * inchperkilogramsecondsqr_.Factor, maxValue * inchperkilogramsecondsqr_.Factor);
  public static LengthPerMassTimeSqr FromInchPerKilogramSecondSqrs(double value) => new LengthPerMassTimeSqr((value + inchperkilogramsecondsqr_.Offset) * inchperkilogramsecondsqr_.Factor);
  public double GetValueInInchPerKilogramSecondSqrs() => (Value_ - inchperkilogramsecondsqr_.Offset) / inchperkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
  public static LengthPerMassTimeSqr operator+(LengthPerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ + o2.Value_);
  public static LengthPerMassTimeSqr operator-(LengthPerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthPerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(LengthPerMassTimeSqr o1, LengthPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthPerTimeCub o1, LengthPerMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(LengthPerMassTimeSqr o1, TimeCubLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(TimeCubLength o1, LengthPerMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  
  public static Area operator*(LengthPerMassTimeSqr o1, TimeSqrLengthMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(TimeSqrLengthMass o1, LengthPerMassTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthPerMassTimeSqr o1, LengthSqrPerMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrPerMassTime o1, LengthPerMassTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthPerMassTimeSqr o1, LengthSqrTimePerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthSqrTimePerMass o1, LengthPerMassTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(LengthPerMassTimeSqr o1, QDose o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(QDose o1, LengthPerMassTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthPerMassTimeSqr o1, LengthSqrTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrTimeSqr o1, LengthPerMassTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthPerMassTimeSqr o1, LengthSqrMassPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrMassPerTime o1, LengthPerMassTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator*(LengthPerMassTimeSqr o1, LengthSqrMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrMassTime o1, LengthPerMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubPerMass o1, LengthPerMassTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubPerTime o1, LengthPerMassTimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(LengthPerMassTimeSqr o1, LengthCubTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubTime o1, LengthPerMassTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthPerMassTimeSqr o1, TimeSqrPerLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeSqrPerLengthCub o1, LengthPerMassTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(LengthPerMassTimeSqr o1, MassPerTimeLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(MassPerTimeLengthCub o1, LengthPerMassTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthPerMassTimeSqr o1, MassTimePerLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(MassTimePerLengthCub o1, LengthPerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthPerMassTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerMassLengthSqrTimeSqr o1, LengthPerMassTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator/(LengthPerMassTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(PerLengthSqrTimeCub o1, LengthPerMassTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(LengthPerMassTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimeCubPerLengthSqr o1, LengthPerMassTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthPerMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeSqrMassPerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(LengthPerMassTimeSqr o1, PerLengthMassTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerLengthMassTimeCub o1, LengthPerMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Time operator*(LengthPerMassTimeSqr o1, TimeCubMassPerLength o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubMassPerLength o1, LengthPerMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Time operator/(LengthPerMassTimeSqr o1, LengthPerMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthPerMassTimeCub o1, LengthPerMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(LengthPerMassTimeSqr o1, TimeCubLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(TimeCubLengthMass o1, LengthPerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthPerMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrPerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(LengthPerMassTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrPerTimeCub o1, LengthPerMassTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(LengthPerMassTimeSqr o1, TimeCubLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(TimeCubLengthSqr o1, LengthPerMassTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  
  public static Volume operator*(LengthPerMassTimeSqr o1, LengthSqrTimeSqrMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrTimeSqrMass o1, LengthPerMassTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubPerMassTime o1, LengthPerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(LengthPerMassTimeSqr o1, LengthCubTimePerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTimePerMass o1, LengthPerMassTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubPerTimeSqr o1, LengthPerMassTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(LengthPerMassTimeSqr o1, TimeCubPerLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimeCubPerLengthCub o1, LengthPerMassTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthPerMassTimeSqr o1, TimeSqrMassPerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthPerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator/(LengthPerMassTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerMassLengthSqrTimeCub o1, LengthPerMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(LengthPerMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubMassPerLengthSqr o1, LengthPerMassTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(LengthPerMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrPerMassTimeCub o1, LengthPerMassTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(LengthPerMassTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(TimeCubLengthSqrMass o1, LengthPerMassTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerMassTimeSqr o1, LengthPerMassTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubPerTimeCub o1, LengthPerMassTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthPerMassTimeSqr o1, TimeCubMassPerLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubMassPerLengthCub o1, LengthPerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthPerMassTimeSqr o1, LengthCubPerMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubPerMassTimeCub o1, LengthPerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthPerMassTimeSqr is outside its bounds.");
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
    