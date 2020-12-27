
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubPerLengthSqr : Quantity, IEquatable<TimeCubPerLengthSqr>, IComparable
  {  
    internal TimeCubPerLengthSqr(double value) : base(value, 2)
    {
      TimeCubPerLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubPerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubPerLengthSqr(TimeCubPerLengthSqr other) : base(other)
    {
      TimeCubPerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerLengthSqr"))
    {
      switch(FakeDatabase.Units["TimeCubPerLengthSqr"])
      {
        case "secondcubpercentimetersqr": displayUnit_ = secondcubpercentimetersqr_; break;
        case "secondcubpermillimetersqr": displayUnit_ = secondcubpermillimetersqr_; break;
        case "secondcubpermetersqr": displayUnit_ = secondcubpermetersqr_; break;
        case "secondcubperinchsqr": displayUnit_ = secondcubperinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubpercentimetersqr_ = new Unit_("SecondCubPerCentimeterSqr", "s³/cm²", 1.0, 0);
  private static Unit_ secondcubpermillimetersqr_ = new Unit_("SecondCubPerMillimeterSqr", "s³/mm²", 99.99999999999999, 0);
  private static Unit_ secondcubpermetersqr_ = new Unit_("SecondCubPerMeterSqr", "s³/m²", 0.0001, 0);
  private static Unit_ secondcubperinchsqr_ = new Unit_("SecondCubPerInchSqr", "s³/in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = secondcubpercentimetersqr_;
  private static Unit_ displayUnit_ = secondcubpercentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubPerLengthSqr other && Equals(other);
  public bool Equals(TimeCubPerLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubPerLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubPerLengthSqr other)) throw new ArgumentException("Object is not a TimeCubPerLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => !(l1 == l2);
  public static bool operator <(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubPerLengthSqr l1, TimeCubPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubPerLengthSqr FromSecondCubPerCentimeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerLengthSqr((value + secondcubpercentimetersqr_.Offset) * secondcubpercentimetersqr_.Factor, minValue * secondcubpercentimetersqr_.Factor, maxValue * secondcubpercentimetersqr_.Factor);
  public static TimeCubPerLengthSqr FromSecondCubPerCentimeterSqrs(double value) => new TimeCubPerLengthSqr((value + secondcubpercentimetersqr_.Offset) * secondcubpercentimetersqr_.Factor);
  public double GetValueInSecondCubPerCentimeterSqrs() => (Value_ - secondcubpercentimetersqr_.Offset) / secondcubpercentimetersqr_.Factor;
  public static TimeCubPerLengthSqr FromSecondCubPerMillimeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerLengthSqr((value + secondcubpermillimetersqr_.Offset) * secondcubpermillimetersqr_.Factor, minValue * secondcubpermillimetersqr_.Factor, maxValue * secondcubpermillimetersqr_.Factor);
  public static TimeCubPerLengthSqr FromSecondCubPerMillimeterSqrs(double value) => new TimeCubPerLengthSqr((value + secondcubpermillimetersqr_.Offset) * secondcubpermillimetersqr_.Factor);
  public double GetValueInSecondCubPerMillimeterSqrs() => (Value_ - secondcubpermillimetersqr_.Offset) / secondcubpermillimetersqr_.Factor;
  public static TimeCubPerLengthSqr FromSecondCubPerMeterSqrs(double value, double minValue, double maxValue) => new TimeCubPerLengthSqr((value + secondcubpermetersqr_.Offset) * secondcubpermetersqr_.Factor, minValue * secondcubpermetersqr_.Factor, maxValue * secondcubpermetersqr_.Factor);
  public static TimeCubPerLengthSqr FromSecondCubPerMeterSqrs(double value) => new TimeCubPerLengthSqr((value + secondcubpermetersqr_.Offset) * secondcubpermetersqr_.Factor);
  public double GetValueInSecondCubPerMeterSqrs() => (Value_ - secondcubpermetersqr_.Offset) / secondcubpermetersqr_.Factor;
  public static TimeCubPerLengthSqr FromSecondCubPerInchSqrs(double value, double minValue, double maxValue) => new TimeCubPerLengthSqr((value + secondcubperinchsqr_.Offset) * secondcubperinchsqr_.Factor, minValue * secondcubperinchsqr_.Factor, maxValue * secondcubperinchsqr_.Factor);
  public static TimeCubPerLengthSqr FromSecondCubPerInchSqrs(double value) => new TimeCubPerLengthSqr((value + secondcubperinchsqr_.Offset) * secondcubperinchsqr_.Factor);
  public double GetValueInSecondCubPerInchSqrs() => (Value_ - secondcubperinchsqr_.Offset) / secondcubperinchsqr_.Factor;

#endregion

#region arithmetic
  public static TimeCubPerLengthSqr operator+(TimeCubPerLengthSqr o1, TimeCubPerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ + o2.Value_);
  public static TimeCubPerLengthSqr operator-(TimeCubPerLengthSqr o1, TimeCubPerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubPerLengthSqr o1, TimeCubPerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(TimeCubPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(TimeSqrMassPerLengthSqr o1, TimeCubPerLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthMassTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerLengthMassTimeCub o1, TimeCubPerLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(TimeCubPerLengthSqr o1, TimeCubPerLengthMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(TimeCubPerLengthMass o1, TimeCubPerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static Density operator*(TimeCubPerLengthSqr o1, MassPerLengthTimeCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(MassPerLengthTimeCub o1, TimeCubPerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(TimeCubPerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(TimeCubMassPerLength o1, TimeCubPerLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(TimeCubPerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(LengthPerMassTimeCub o1, TimeCubPerLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeCubPerLengthSqr o1, TimeCubLengthPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(TimeCubLengthPerMass o1, TimeCubPerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(TimeCubPerLengthSqr o1, LengthMassPerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(LengthMassPerTimeCub o1, TimeCubPerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(TimeCubPerLengthSqr o1, TimeCubLengthMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(TimeCubLengthMass o1, TimeCubPerLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(TimeCubPerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(LengthSqrPerMassTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(TimeCubPerLengthSqr o1, LengthSqrPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrPerTimeCub o1, TimeCubPerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(TimeCubPerLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(TimeCubPerLengthSqr o1, LengthCubPerMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(LengthCubPerMassTime o1, TimeCubPerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(TimeCubPerLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubPerTimeSqr o1, TimeCubPerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(TimeCubPerLengthSqr o1, LengthCubMassPerTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubMassPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(TimeCubPerLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(TimeSqrPerMassLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator/(TimeCubPerLengthSqr o1, TimeCubPerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubPerLengthCub o1, TimeCubPerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(TimeCubPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(TimeSqrMassPerLengthCub o1, TimeCubPerLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static Mass operator/(TimeCubPerLengthSqr o1, TimeCubPerMassLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(TimeCubPerMassLengthSqr o1, TimeCubPerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(TimeCubPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(TimeCubMassPerLengthSqr o1, TimeCubPerLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(TimeCubPerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(LengthSqrPerMassTimeCub o1, TimeCubPerLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(TimeCubPerLengthSqr o1, LengthSqrMassPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(LengthSqrMassPerTimeCub o1, TimeCubPerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(TimeCubPerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthCubPerMassTimeSqr o1, TimeCubPerLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Length operator*(TimeCubPerLengthSqr o1, LengthCubPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubPerTimeCub o1, TimeCubPerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(TimeCubPerLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(TimeCubPerLengthSqr o1, TimeCubPerMassLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(TimeCubPerMassLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator/(TimeCubPerLengthSqr o1, TimeCubMassPerLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(TimeCubMassPerLengthCub o1, TimeCubPerLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(TimeCubPerLengthSqr o1, LengthCubPerMassTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubPerMassTimeCub o1, TimeCubPerLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(TimeCubPerLengthSqr o1, LengthCubMassPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubMassPerTimeCub o1, TimeCubPerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubPerLengthSqr is outside its bounds.");
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
    