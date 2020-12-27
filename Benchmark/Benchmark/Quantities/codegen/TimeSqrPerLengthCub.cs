
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeSqrPerLengthCub : Quantity, IEquatable<TimeSqrPerLengthCub>, IComparable
  {  
    internal TimeSqrPerLengthCub(double value) : base(value, 2)
    {
      TimeSqrPerLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeSqrPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeSqrPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeSqrPerLengthCub(TimeSqrPerLengthCub other) : base(other)
    {
      TimeSqrPerLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerLengthCub"))
    {
      switch(FakeDatabase.Units["TimeSqrPerLengthCub"])
      {
        case "secondsqrpercentimetercub": displayUnit_ = secondsqrpercentimetercub_; break;
        case "secondsqrpermillimetercub": displayUnit_ = secondsqrpermillimetercub_; break;
        case "secondsqrpermetercub": displayUnit_ = secondsqrpermetercub_; break;
        case "secondsqrperinchcub": displayUnit_ = secondsqrperinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondsqrpercentimetercub_ = new Unit_("SecondSqrPerCentimeterCub", "s²/cm³", 1.0, 0);
  private static Unit_ secondsqrpermillimetercub_ = new Unit_("SecondSqrPerMillimeterCub", "s²/mm³", 999.9999999999998, 0);
  private static Unit_ secondsqrpermetercub_ = new Unit_("SecondSqrPerMeterCub", "s²/m³", 1e-06, 0);
  private static Unit_ secondsqrperinchcub_ = new Unit_("SecondSqrPerInchCub", "s²/in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = secondsqrpercentimetercub_;
  private static Unit_ displayUnit_ = secondsqrpercentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeSqrPerLengthCub other && Equals(other);
  public bool Equals(TimeSqrPerLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeSqrPerLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeSqrPerLengthCub other)) throw new ArgumentException("Object is not a TimeSqrPerLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => !(l1 == l2);
  public static bool operator <(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeSqrPerLengthCub l1, TimeSqrPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeSqrPerLengthCub FromSecondSqrPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerLengthCub((value + secondsqrpercentimetercub_.Offset) * secondsqrpercentimetercub_.Factor, minValue * secondsqrpercentimetercub_.Factor, maxValue * secondsqrpercentimetercub_.Factor);
  public static TimeSqrPerLengthCub FromSecondSqrPerCentimeterCubs(double value) => new TimeSqrPerLengthCub((value + secondsqrpercentimetercub_.Offset) * secondsqrpercentimetercub_.Factor);
  public double GetValueInSecondSqrPerCentimeterCubs() => (Value_ - secondsqrpercentimetercub_.Offset) / secondsqrpercentimetercub_.Factor;
  public static TimeSqrPerLengthCub FromSecondSqrPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerLengthCub((value + secondsqrpermillimetercub_.Offset) * secondsqrpermillimetercub_.Factor, minValue * secondsqrpermillimetercub_.Factor, maxValue * secondsqrpermillimetercub_.Factor);
  public static TimeSqrPerLengthCub FromSecondSqrPerMillimeterCubs(double value) => new TimeSqrPerLengthCub((value + secondsqrpermillimetercub_.Offset) * secondsqrpermillimetercub_.Factor);
  public double GetValueInSecondSqrPerMillimeterCubs() => (Value_ - secondsqrpermillimetercub_.Offset) / secondsqrpermillimetercub_.Factor;
  public static TimeSqrPerLengthCub FromSecondSqrPerMeterCubs(double value, double minValue, double maxValue) => new TimeSqrPerLengthCub((value + secondsqrpermetercub_.Offset) * secondsqrpermetercub_.Factor, minValue * secondsqrpermetercub_.Factor, maxValue * secondsqrpermetercub_.Factor);
  public static TimeSqrPerLengthCub FromSecondSqrPerMeterCubs(double value) => new TimeSqrPerLengthCub((value + secondsqrpermetercub_.Offset) * secondsqrpermetercub_.Factor);
  public double GetValueInSecondSqrPerMeterCubs() => (Value_ - secondsqrpermetercub_.Offset) / secondsqrpermetercub_.Factor;
  public static TimeSqrPerLengthCub FromSecondSqrPerInchCubs(double value, double minValue, double maxValue) => new TimeSqrPerLengthCub((value + secondsqrperinchcub_.Offset) * secondsqrperinchcub_.Factor, minValue * secondsqrperinchcub_.Factor, maxValue * secondsqrperinchcub_.Factor);
  public static TimeSqrPerLengthCub FromSecondSqrPerInchCubs(double value) => new TimeSqrPerLengthCub((value + secondsqrperinchcub_.Offset) * secondsqrperinchcub_.Factor);
  public double GetValueInSecondSqrPerInchCubs() => (Value_ - secondsqrperinchcub_.Offset) / secondsqrperinchcub_.Factor;

#endregion

#region arithmetic
  public static TimeSqrPerLengthCub operator+(TimeSqrPerLengthCub o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ + o2.Value_);
  public static TimeSqrPerLengthCub operator-(TimeSqrPerLengthCub o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeSqrPerLengthCub o1, TimeSqrPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(TimeSqrPerLengthCub o1, MassPerTimeLengthCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrPerLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimeSqrPerLengthCub o1, MassTimePerLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassTimePerLengthCub o1, TimeSqrPerLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(TimeSqrPerLengthCub o1, TimeSqrPerMassLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(TimeSqrPerLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeCubPerLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(TimeSqrPerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeSqrMassPerLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(TimeSqrPerLengthCub o1, TimeCubPerLengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(TimeCubPerLengthMass o1, TimeSqrPerLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(TimeSqrPerLengthCub o1, TimeCubMassPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(TimeCubMassPerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(TimeSqrPerLengthCub o1, LengthPerMassTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(LengthPerMassTimeCub o1, TimeSqrPerLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(TimeSqrPerLengthCub o1, LengthMassPerTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(LengthMassPerTimeCub o1, TimeSqrPerLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator*(TimeSqrPerLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthSqrPerMassTimeSqr o1, TimeSqrPerLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(TimeSqrPerLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(TimeSqrPerLengthCub o1, LengthSqrMassPerTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(TimeSqrPerLengthCub o1, LengthCubPerMassTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthCubPerMassTime o1, TimeSqrPerLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(TimeSqrPerLengthCub o1, LengthCubTimePerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(LengthCubTimePerMass o1, TimeSqrPerLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeSqrPerLengthCub o1, LengthCubPerTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubPerTimeSqr o1, TimeSqrPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimeSqrPerLengthCub o1, LengthCubMassPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthCubMassPerTime o1, TimeSqrPerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(TimeSqrPerLengthCub o1, LengthCubMassTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthCubMassTime o1, TimeSqrPerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(TimeSqrPerLengthCub o1, TimeSqrPerMassLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(TimeSqrPerLengthCub o1, TimeCubPerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeCubPerLengthCub o1, TimeSqrPerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimeSqrPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeSqrMassPerLengthCub o1, TimeSqrPerLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(TimeSqrPerLengthCub o1, TimeCubPerMassLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(TimeSqrPerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(TimeCubMassPerLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(TimeSqrPerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrPerLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(TimeSqrPerLengthCub o1, LengthSqrMassPerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(TimeSqrPerLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthCubPerMassTimeSqr o1, TimeSqrPerLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(TimeSqrPerLengthCub o1, LengthCubPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthCubPerTimeCub o1, TimeSqrPerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimeSqrPerLengthCub o1, LengthCubMassPerTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator/(TimeSqrPerLengthCub o1, TimeCubPerMassLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimeCubPerMassLengthCub o1, TimeSqrPerLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(TimeSqrPerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(TimeCubMassPerLengthCub o1, TimeSqrPerLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(TimeSqrPerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthCubPerMassTimeCub o1, TimeSqrPerLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(TimeSqrPerLengthCub o1, LengthCubMassPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeSqrPerLengthCub is outside its bounds.");
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
    