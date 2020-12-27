
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrLength : Quantity, IEquatable<TimeSqrLength>, IComparable
  {  
    internal TimeSqrLength(double value) : base(value, 2)
    {
      TimeSqrLength.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrLength(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrLength(TimeSqrLength other) : base(other)
    {
      TimeSqrLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrLength"))
    {
      switch(FakeDatabase.Units["TimeSqrLength"])
      {
        case "secondsqrcentimeter": displayUnit_ = secondsqrcentimeter_; break;
        case "secondsqrmillimeter": displayUnit_ = secondsqrmillimeter_; break;
        case "secondsqrmeter": displayUnit_ = secondsqrmeter_; break;
        case "secondsqrinch": displayUnit_ = secondsqrinch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrcentimeter_ = new Unit_("SecondSqrCentimeter", "s� cm", 1, 0);
  private static Unit_ secondsqrmillimeter_ = new Unit_("SecondSqrMillimeter", "s� mm", 0.1, 0);
  private static Unit_ secondsqrmeter_ = new Unit_("SecondSqrMeter", "s� m", 100, 0);
  private static Unit_ secondsqrinch_ = new Unit_("SecondSqrInch", "s� in", 2.56, 0);
  private static Unit_ platformUnit_ = secondsqrcentimeter_;
  private static Unit_ displayUnit_ = secondsqrcentimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrLength other && Equals(other);
  public bool Equals(TimeSqrLength other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrLength other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrLength other)) throw new ArgumentException("Object is not a TimeSqrLength.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrLength l1, TimeSqrLength l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrLength l1, TimeSqrLength l2) => !(l1 == l2);
  public static bool operator <(TimeSqrLength l1, TimeSqrLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrLength l1, TimeSqrLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrLength l1, TimeSqrLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrLength l1, TimeSqrLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrLength FromSecondSqrCentimeters(double value, double minValue, double maxValue) => new TimeSqrLength((value + secondsqrcentimeter_.Offset) * secondsqrcentimeter_.Factor, minValue * secondsqrcentimeter_.Factor, maxValue * secondsqrcentimeter_.Factor);
  public static TimeSqrLength FromSecondSqrCentimeters(double value) => new TimeSqrLength((value + secondsqrcentimeter_.Offset) * secondsqrcentimeter_.Factor);
  public double GetValueInSecondSqrCentimeters() => (Value_ - secondsqrcentimeter_.Offset) / secondsqrcentimeter_.Factor;
  public static TimeSqrLength FromSecondSqrMillimeters(double value, double minValue, double maxValue) => new TimeSqrLength((value + secondsqrmillimeter_.Offset) * secondsqrmillimeter_.Factor, minValue * secondsqrmillimeter_.Factor, maxValue * secondsqrmillimeter_.Factor);
  public static TimeSqrLength FromSecondSqrMillimeters(double value) => new TimeSqrLength((value + secondsqrmillimeter_.Offset) * secondsqrmillimeter_.Factor);
  public double GetValueInSecondSqrMillimeters() => (Value_ - secondsqrmillimeter_.Offset) / secondsqrmillimeter_.Factor;
  public static TimeSqrLength FromSecondSqrMeters(double value, double minValue, double maxValue) => new TimeSqrLength((value + secondsqrmeter_.Offset) * secondsqrmeter_.Factor, minValue * secondsqrmeter_.Factor, maxValue * secondsqrmeter_.Factor);
  public static TimeSqrLength FromSecondSqrMeters(double value) => new TimeSqrLength((value + secondsqrmeter_.Offset) * secondsqrmeter_.Factor);
  public double GetValueInSecondSqrMeters() => (Value_ - secondsqrmeter_.Offset) / secondsqrmeter_.Factor;
  public static TimeSqrLength FromSecondSqrInchs(double value, double minValue, double maxValue) => new TimeSqrLength((value + secondsqrinch_.Offset) * secondsqrinch_.Factor, minValue * secondsqrinch_.Factor, maxValue * secondsqrinch_.Factor);
  public static TimeSqrLength FromSecondSqrInchs(double value) => new TimeSqrLength((value + secondsqrinch_.Offset) * secondsqrinch_.Factor);
  public double GetValueInSecondSqrInchs() => (Value_ - secondsqrinch_.Offset) / secondsqrinch_.Factor;

#endregion

#region arithmetic
  public static TimeSqrLength operator+(TimeSqrLength o1, TimeSqrLength o2) => new TimeSqrLength(o1.Value_ + o2.Value_);
  public static TimeSqrLength operator-(TimeSqrLength o1, TimeSqrLength o2) => new TimeSqrLength(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrLength o1, TimeSqrLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeSqrLength o1, LengthMassPerTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthMassPerTime o1, TimeSqrLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(TimeSqrLength o1, LengthMassPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthMassPerTime o1, TimeSqrLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(TimeSqrLength o1, LengthMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(LengthMassTime o1, TimeSqrLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(TimeSqrLength o1, LengthMassTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthMassTime o1, TimeSqrLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(TimeSqrLength o1, LengthSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthSqrPerMass o1, TimeSqrLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrLength o1, LengthSqrPerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthSqrPerMass o1, TimeSqrLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(TimeSqrLength o1, LengthSqrPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrPerTime o1, TimeSqrLength o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(TimeSqrLength o1, LengthSqrPerTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrPerTime o1, TimeSqrLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(TimeSqrLength o1, LengthSqrTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthSqrTime o1, TimeSqrLength o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static TimePerLength operator/(TimeSqrLength o1, LengthSqrTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrTime o1, TimeSqrLength o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(TimeSqrLength o1, LengthSqrMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthSqrMass o1, TimeSqrLength o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrLength o1, LengthSqrMass o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthSqrMass o1, TimeSqrLength o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(TimeSqrLength o1, Volume o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(Volume o1, TimeSqrLength o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrLength o1, PerMassLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(PerMassLengthCub o1, TimeSqrLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(TimeSqrLength o1, PerTimeLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(PerTimeLengthCub o1, TimeSqrLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(TimeSqrLength o1, TimePerLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimePerLengthCub o1, TimeSqrLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrLength o1, Density o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(Density o1, TimeSqrLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(TimeSqrLength o1, PerMassTimeLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(PerMassTimeLengthSqr o1, TimeSqrLength o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(TimeSqrLength o1, PerMassTimeLengthSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrLength o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(TimeSqrLength o1, TimePerMassLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimePerMassLengthSqr o1, TimeSqrLength o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(TimeSqrLength o1, TimePerMassLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(TimePerMassLengthSqr o1, TimeSqrLength o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(TimeSqrLength o1, PerLengthSqrTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthSqrTimeSqr o1, TimeSqrLength o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static Volume operator/(TimeSqrLength o1, TimeSqrPerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(TimeSqrPerLengthSqr o1, TimeSqrLength o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(TimeSqrLength o1, MassPerTimeLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassPerTimeLengthSqr o1, TimeSqrLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(TimeSqrLength o1, MassPerTimeLengthSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqrLength o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(TimeSqrLength o1, MassTimePerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(MassTimePerLengthSqr o1, TimeSqrLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(TimeSqrLength o1, MassTimePerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassTimePerLengthSqr o1, TimeSqrLength o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeSqrLength o1, PerLengthMassTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerLengthMassTimeSqr o1, TimeSqrLength o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeSqrLength o1, TimeSqrPerLengthMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeSqrPerLengthMass o1, TimeSqrLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(TimeSqrLength o1, PerLengthTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthTimeCub o1, TimeSqrLength o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator/(TimeSqrLength o1, TimeCubPerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimeCubPerLength o1, TimeSqrLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator*(TimeSqrLength o1, MassPerLengthTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerLengthTimeSqr o1, TimeSqrLength o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator/(TimeSqrLength o1, TimeSqrMassPerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(TimeSqrMassPerLength o1, TimeSqrLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(TimeSqrLength o1, PerMassTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassTimeCub o1, TimeSqrLength o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(TimeSqrLength o1, TimeCubPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeCubPerMass o1, TimeSqrLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(TimeSqrLength o1, MassPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerTimeCub o1, TimeSqrLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator/(TimeSqrLength o1, TimeCubMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(TimeCubMass o1, TimeSqrLength o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(TimeSqrLength o1, LengthPerMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthPerMassTimeSqr o1, TimeSqrLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeSqrLength o1, TimeSqrLengthPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeSqrLengthPerMass o1, TimeSqrLength o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(TimeSqrLength o1, LengthPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthPerTimeCub o1, TimeSqrLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static PerTime operator/(TimeSqrLength o1, TimeCubLength o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubLength o1, TimeSqrLength o2) => new Time(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(TimeSqrLength o1, Force o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(Force o1, TimeSqrLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(TimeSqrLength o1, TimeSqrLengthMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeSqrLengthMass o1, TimeSqrLength o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(TimeSqrLength o1, LengthSqrPerMassTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthSqrPerMassTime o1, TimeSqrLength o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(TimeSqrLength o1, LengthSqrPerMassTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerMassTime o1, TimeSqrLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(TimeSqrLength o1, LengthSqrTimePerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(LengthSqrTimePerMass o1, TimeSqrLength o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(TimeSqrLength o1, LengthSqrTimePerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrTimePerMass o1, TimeSqrLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(TimeSqrLength o1, QDose o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(QDose o1, TimeSqrLength o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(TimeSqrLength o1, LengthSqrTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrTimeSqr o1, TimeSqrLength o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(TimeSqrLength o1, LengthSqrMassPerTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthSqrMassPerTime o1, TimeSqrLength o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeSqrLength o1, LengthSqrMassPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrMassPerTime o1, TimeSqrLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(TimeSqrLength o1, LengthSqrMassTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthSqrMassTime o1, TimeSqrLength o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrLength o1, LengthSqrMassTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthSqrMassTime o1, TimeSqrLength o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrLength o1, LengthCubPerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthCubPerMass o1, TimeSqrLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(TimeSqrLength o1, LengthCubPerTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubPerTime o1, TimeSqrLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(TimeSqrLength o1, LengthCubTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubTime o1, TimeSqrLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrLength o1, LengthCubMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthCubMass o1, TimeSqrLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(TimeSqrLength o1, PerMassTimeLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(PerMassTimeLengthCub o1, TimeSqrLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(TimeSqrLength o1, TimePerMassLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimePerMassLengthCub o1, TimeSqrLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(TimeSqrLength o1, PerTimeSqrLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerTimeSqrLengthCub o1, TimeSqrLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(TimeSqrLength o1, MassPerTimeLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassPerTimeLengthCub o1, TimeSqrLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(TimeSqrLength o1, MassTimePerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(MassTimePerLengthCub o1, TimeSqrLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(TimeSqrLength o1, PerMassLengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassLengthSqrTimeSqr o1, TimeSqrLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator/(TimeSqrLength o1, TimeSqrPerMassLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(TimeSqrPerMassLengthSqr o1, TimeSqrLength o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrLength o1, PerLengthSqrTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerLengthSqrTimeCub o1, TimeSqrLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static LengthCubPerTime operator/(TimeSqrLength o1, TimeCubPerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimeCubPerLengthSqr o1, TimeSqrLength o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeSqrLength o1, MassPerLengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerLengthSqrTimeSqr o1, TimeSqrLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator/(TimeSqrLength o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(TimeSqrMassPerLengthSqr o1, TimeSqrLength o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimeSqrLength o1, PerLengthMassTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerLengthMassTimeCub o1, TimeSqrLength o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator/(TimeSqrLength o1, TimeCubPerLengthMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimeCubPerLengthMass o1, TimeSqrLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(TimeSqrLength o1, MassPerLengthTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerLengthTimeCub o1, TimeSqrLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTime operator/(TimeSqrLength o1, TimeCubMassPerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(TimeCubMassPerLength o1, TimeSqrLength o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(TimeSqrLength o1, LengthPerMassTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthPerMassTimeCub o1, TimeSqrLength o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator/(TimeSqrLength o1, TimeCubLengthPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeCubLengthPerMass o1, TimeSqrLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(TimeSqrLength o1, LengthMassPerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthMassPerTimeCub o1, TimeSqrLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator/(TimeSqrLength o1, TimeCubLengthMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubLengthMass o1, TimeSqrLength o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(TimeSqrLength o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthSqrPerMassTimeSqr o1, TimeSqrLength o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeSqrLength o1, LengthSqrTimeSqrPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrTimeSqrPerMass o1, TimeSqrLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(TimeSqrLength o1, LengthSqrPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrPerTimeCub o1, TimeSqrLength o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrLength o1, TimeCubLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubLengthSqr o1, TimeSqrLength o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(TimeSqrLength o1, LengthSqrMassPerTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthSqrMassPerTimeSqr o1, TimeSqrLength o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeSqrLength o1, LengthSqrTimeSqrMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrTimeSqrMass o1, TimeSqrLength o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(TimeSqrLength o1, LengthCubPerMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerMassTime o1, TimeSqrLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(TimeSqrLength o1, LengthCubTimePerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubTimePerMass o1, TimeSqrLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(TimeSqrLength o1, LengthCubTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubTimeSqr o1, TimeSqrLength o2) => new Area(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(TimeSqrLength o1, LengthCubMassPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthCubMassPerTime o1, TimeSqrLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator/(TimeSqrLength o1, LengthCubMassTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthCubMassTime o1, TimeSqrLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(TimeSqrLength o1, PerMassTimeSqrLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerMassTimeSqrLengthCub o1, TimeSqrLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(TimeSqrLength o1, PerLengthCubTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerLengthCubTimeCub o1, TimeSqrLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(TimeSqrLength o1, MassPerTimeSqrLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerTimeSqrLengthCub o1, TimeSqrLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator*(TimeSqrLength o1, PerMassLengthSqrTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassLengthSqrTimeCub o1, TimeSqrLength o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator/(TimeSqrLength o1, TimeCubPerMassLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimeCubPerMassLengthSqr o1, TimeSqrLength o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(TimeSqrLength o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerLengthSqrTimeCub o1, TimeSqrLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTime operator/(TimeSqrLength o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(TimeCubMassPerLengthSqr o1, TimeSqrLength o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(TimeSqrLength o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrLength o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator/(TimeSqrLength o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeCubLengthSqrPerMass o1, TimeSqrLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(TimeSqrLength o1, LengthSqrMassPerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrLength o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator/(TimeSqrLength o1, TimeCubLengthSqrMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeCubLengthSqrMass o1, TimeSqrLength o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(TimeSqrLength o1, LengthCubTimeSqrPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubTimeSqrPerMass o1, TimeSqrLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(TimeSqrLength o1, LengthCubTimeCub o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubTimeCub o1, TimeSqrLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(TimeSqrLength o1, LengthCubTimeSqrMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubTimeSqrMass o1, TimeSqrLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrLength o1, PerMassLengthCubTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassLengthCubTimeCub o1, TimeSqrLength o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimeSqrLength o1, MassPerLengthCubTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerLengthCubTimeCub o1, TimeSqrLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimeSqrLength o1, LengthCubTimeCubPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTimeCubPerMass o1, TimeSqrLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrLength o1, LengthCubTimeCubMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubTimeCubMass o1, TimeSqrLength o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrLength is outside its bounds.");
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
    