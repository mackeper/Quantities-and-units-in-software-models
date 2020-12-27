
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimePerLengthCub : Quantity, IEquatable<TimePerLengthCub>, IComparable
  {  
    internal TimePerLengthCub(double value) : base(value, 2)
    {
      TimePerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimePerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimePerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimePerLengthCub(TimePerLengthCub other) : base(other)
    {
      TimePerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerLengthCub"))
    {
      switch(FakeDatabase.Units["TimePerLengthCub"])
      {
        case "secondpercentimetercub": displayUnit_ = secondpercentimetercub_; break;
        case "secondpermillimetercub": displayUnit_ = secondpermillimetercub_; break;
        case "secondpermetercub": displayUnit_ = secondpermetercub_; break;
        case "secondperinchcub": displayUnit_ = secondperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondpercentimetercub_ = new Unit_("SecondPerCentimeterCub", "s/cm�", 1.0, 0);
  private static Unit_ secondpermillimetercub_ = new Unit_("SecondPerMillimeterCub", "s/mm�", 999.9999999999998, 0);
  private static Unit_ secondpermetercub_ = new Unit_("SecondPerMeterCub", "s/m�", 1e-06, 0);
  private static Unit_ secondperinchcub_ = new Unit_("SecondPerInchCub", "s/in�", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondpercentimetercub_;
  private static Unit_ displayUnit_ = secondpercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimePerLengthCub other && Equals(other);
  public bool Equals(TimePerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimePerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimePerLengthCub other)) throw new ArgumentException("Object is not a TimePerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimePerLengthCub l1, TimePerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimePerLengthCub l1, TimePerLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimePerLengthCub l1, TimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimePerLengthCub l1, TimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimePerLengthCub l1, TimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimePerLengthCub l1, TimePerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimePerLengthCub FromSecondPerCentimeterCubs(double value, double minValue, double maxValue) => new TimePerLengthCub((value + secondpercentimetercub_.Offset) * secondpercentimetercub_.Factor, minValue * secondpercentimetercub_.Factor, maxValue * secondpercentimetercub_.Factor);
  public static TimePerLengthCub FromSecondPerCentimeterCubs(double value) => new TimePerLengthCub((value + secondpercentimetercub_.Offset) * secondpercentimetercub_.Factor);
  public double GetValueInSecondPerCentimeterCubs() => (Value_ - secondpercentimetercub_.Offset) / secondpercentimetercub_.Factor;
  public static TimePerLengthCub FromSecondPerMillimeterCubs(double value, double minValue, double maxValue) => new TimePerLengthCub((value + secondpermillimetercub_.Offset) * secondpermillimetercub_.Factor, minValue * secondpermillimetercub_.Factor, maxValue * secondpermillimetercub_.Factor);
  public static TimePerLengthCub FromSecondPerMillimeterCubs(double value) => new TimePerLengthCub((value + secondpermillimetercub_.Offset) * secondpermillimetercub_.Factor);
  public double GetValueInSecondPerMillimeterCubs() => (Value_ - secondpermillimetercub_.Offset) / secondpermillimetercub_.Factor;
  public static TimePerLengthCub FromSecondPerMeterCubs(double value, double minValue, double maxValue) => new TimePerLengthCub((value + secondpermetercub_.Offset) * secondpermetercub_.Factor, minValue * secondpermetercub_.Factor, maxValue * secondpermetercub_.Factor);
  public static TimePerLengthCub FromSecondPerMeterCubs(double value) => new TimePerLengthCub((value + secondpermetercub_.Offset) * secondpermetercub_.Factor);
  public double GetValueInSecondPerMeterCubs() => (Value_ - secondpermetercub_.Offset) / secondpermetercub_.Factor;
  public static TimePerLengthCub FromSecondPerInchCubs(double value, double minValue, double maxValue) => new TimePerLengthCub((value + secondperinchcub_.Offset) * secondperinchcub_.Factor, minValue * secondperinchcub_.Factor, maxValue * secondperinchcub_.Factor);
  public static TimePerLengthCub FromSecondPerInchCubs(double value) => new TimePerLengthCub((value + secondperinchcub_.Offset) * secondperinchcub_.Factor);
  public double GetValueInSecondPerInchCubs() => (Value_ - secondperinchcub_.Offset) / secondperinchcub_.Factor;

#endregion

#region arithmetic
  public static TimePerLengthCub operator+(TimePerLengthCub o1, TimePerLengthCub o2) => new TimePerLengthCub(o1.Value_ + o2.Value_);
  public static TimePerLengthCub operator-(TimePerLengthCub o1, TimePerLengthCub o2) => new TimePerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimePerLengthCub o1, TimePerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimePerLengthCub o1, Density o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(Density o1, TimePerLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(TimePerLengthCub o1, PerMassTimeLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(PerMassTimeLengthSqr o1, TimePerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(TimePerLengthCub o1, TimePerMassLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimePerMassLengthSqr o1, TimePerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(TimePerLengthCub o1, PerLengthSqrTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimePerLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrPerLengthSqr o1, TimePerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(TimePerLengthCub o1, MassPerTimeLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(MassPerTimeLengthSqr o1, TimePerLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(TimePerLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassTimePerLengthSqr o1, TimePerLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(TimePerLengthCub o1, PerLengthMassTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(PerLengthMassTimeSqr o1, TimePerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimePerLengthCub o1, TimeSqrPerLengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeSqrPerLengthMass o1, TimePerLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(TimePerLengthCub o1, TimeCubPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubPerLength o1, TimePerLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator/(TimePerLengthCub o1, MassPerLengthTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(MassPerLengthTimeSqr o1, TimePerLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimePerLengthCub o1, TimeSqrMassPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeSqrMassPerLength o1, TimePerLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(TimePerLengthCub o1, PerMassTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerMassTimeCub o1, TimePerLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator/(TimePerLengthCub o1, TimeCubPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeCubPerMass o1, TimePerLengthCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(TimePerLengthCub o1, MassPerTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerTimeCub o1, TimePerLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator/(TimePerLengthCub o1, TimeCubMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(TimeCubMass o1, TimePerLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimePerLengthCub o1, LengthPerMassTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(LengthPerMassTimeSqr o1, TimePerLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(TimePerLengthCub o1, TimeSqrLengthPerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeSqrLengthPerMass o1, TimePerLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(TimePerLengthCub o1, LengthPerTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(LengthPerTimeCub o1, TimePerLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimePerLengthCub o1, Force o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(Force o1, TimePerLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(TimePerLengthCub o1, TimeSqrLengthMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeSqrLengthMass o1, TimePerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(TimePerLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthSqrPerMassTime o1, TimePerLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(TimePerLengthCub o1, LengthSqrTimePerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(LengthSqrTimePerMass o1, TimePerLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(TimePerLengthCub o1, QDose o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(QDose o1, TimePerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(TimePerLengthCub o1, LengthSqrTimeSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(LengthSqrTimeSqr o1, TimePerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(TimePerLengthCub o1, LengthSqrMassPerTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthSqrMassPerTime o1, TimePerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(TimePerLengthCub o1, LengthSqrMassTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(LengthSqrMassTime o1, TimePerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(TimePerLengthCub o1, LengthCubPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubPerMass o1, TimePerLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimePerLengthCub o1, LengthCubPerTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerTime o1, TimePerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(TimePerLengthCub o1, LengthCubTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthCubTime o1, TimePerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimePerLengthCub o1, LengthCubMass o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthCubMass o1, TimePerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator/(TimePerLengthCub o1, PerMassTimeLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerMassTimeLengthCub o1, TimePerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator/(TimePerLengthCub o1, TimePerMassLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimePerMassLengthCub o1, TimePerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(TimePerLengthCub o1, PerTimeSqrLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerTimeSqrLengthCub o1, TimePerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimePerLengthCub o1, TimeSqrPerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrPerLengthCub o1, TimePerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(TimePerLengthCub o1, MassPerTimeLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerTimeLengthCub o1, TimePerLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimePerLengthCub o1, MassTimePerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassTimePerLengthCub o1, TimePerLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator/(TimePerLengthCub o1, PerMassLengthSqrTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(TimePerLengthCub o1, TimeSqrPerMassLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeSqrPerMassLengthSqr o1, TimePerLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(TimePerLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubPerLengthSqr o1, TimePerLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(TimePerLengthCub o1, MassPerLengthSqrTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(MassPerLengthSqrTimeSqr o1, TimePerLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(TimePerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeSqrMassPerLengthSqr o1, TimePerLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(TimePerLengthCub o1, TimeCubPerLengthMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(TimeCubPerLengthMass o1, TimePerLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(TimePerLengthCub o1, TimeCubMassPerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(TimeCubMassPerLength o1, TimePerLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(TimePerLengthCub o1, LengthPerMassTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(LengthPerMassTimeCub o1, TimePerLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(TimePerLengthCub o1, LengthMassPerTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(LengthMassPerTimeCub o1, TimePerLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator*(TimePerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(LengthSqrPerMassTimeSqr o1, TimePerLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(TimePerLengthCub o1, LengthSqrTimeSqrPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(LengthSqrTimeSqrPerMass o1, TimePerLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(TimePerLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthSqrPerTimeCub o1, TimePerLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(TimePerLengthCub o1, LengthSqrMassPerTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(LengthSqrMassPerTimeSqr o1, TimePerLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(TimePerLengthCub o1, LengthSqrTimeSqrMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(LengthSqrTimeSqrMass o1, TimePerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(TimePerLengthCub o1, LengthCubPerMassTime o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthCubPerMassTime o1, TimePerLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(TimePerLengthCub o1, LengthCubTimePerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(LengthCubTimePerMass o1, TimePerLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimePerLengthCub o1, LengthCubPerTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubPerTimeSqr o1, TimePerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(TimePerLengthCub o1, LengthCubTimeSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthCubTimeSqr o1, TimePerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimePerLengthCub o1, LengthCubMassPerTime o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthCubMassPerTime o1, TimePerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(TimePerLengthCub o1, LengthCubMassTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(LengthCubMassTime o1, TimePerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator/(TimePerLengthCub o1, PerMassTimeSqrLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(TimePerLengthCub o1, TimeSqrPerMassLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeSqrPerMassLengthCub o1, TimePerLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(TimePerLengthCub o1, TimeCubPerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubPerLengthCub o1, TimePerLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimePerLengthCub o1, MassPerTimeSqrLengthCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerTimeSqrLengthCub o1, TimePerLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimePerLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeSqrMassPerLengthCub o1, TimePerLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(TimePerLengthCub o1, TimeCubPerMassLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubPerMassLengthSqr o1, TimePerLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(TimePerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeCubMassPerLengthSqr o1, TimePerLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(TimePerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(LengthSqrPerMassTimeCub o1, TimePerLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(TimePerLengthCub o1, LengthSqrMassPerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(LengthSqrMassPerTimeCub o1, TimePerLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(TimePerLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubPerMassTimeSqr o1, TimePerLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimePerLengthCub o1, LengthCubTimeSqrPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthCubTimeSqrPerMass o1, TimePerLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(TimePerLengthCub o1, LengthCubPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthCubPerTimeCub o1, TimePerLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(TimePerLengthCub o1, LengthCubMassPerTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubMassPerTimeSqr o1, TimePerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(TimePerLengthCub o1, LengthCubTimeSqrMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthCubTimeSqrMass o1, TimePerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator/(TimePerLengthCub o1, TimeCubPerMassLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubPerMassLengthCub o1, TimePerLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(TimePerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeCubMassPerLengthCub o1, TimePerLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(TimePerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(LengthCubPerMassTimeCub o1, TimePerLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(TimePerLengthCub o1, LengthCubMassPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthCubMassPerTimeCub o1, TimePerLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimePerLengthCub is outside its bounds.");
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
    