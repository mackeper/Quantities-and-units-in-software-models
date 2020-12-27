
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class TimeCubMassPerLength : Quantity, IEquatable<TimeCubMassPerLength>, IComparable
  {  
    internal TimeCubMassPerLength(double value) : base(value, 2)
    {
      TimeCubMassPerLength.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal TimeCubMassPerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
      TimeCubMassPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public TimeCubMassPerLength(TimeCubMassPerLength other) : base(other)
    {
      TimeCubMassPerLength.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubMassPerLength"))
    {
      switch(FakeDatabase.Units["TimeCubMassPerLength"])
      {
        case "secondcubkilogrampercentimeter": displayUnit_ = secondcubkilogrampercentimeter_; break;
        case "secondcubkilogrampermillimeter": displayUnit_ = secondcubkilogrampermillimeter_; break;
        case "secondcubkilogrampermeter": displayUnit_ = secondcubkilogrampermeter_; break;
        case "secondcubkilogramperinch": displayUnit_ = secondcubkilogramperinch_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ secondcubkilogrampercentimeter_ = new Unit_("SecondCubKilogramPerCentimeter", "s³ kg/cm", 1.0, 0);
  private static Unit_ secondcubkilogrampermillimeter_ = new Unit_("SecondCubKilogramPerMillimeter", "s³ kg/mm", 10.0, 0);
  private static Unit_ secondcubkilogrampermeter_ = new Unit_("SecondCubKilogramPerMeter", "s³ kg/m", 0.01, 0);
  private static Unit_ secondcubkilogramperinch_ = new Unit_("SecondCubKilogramPerInch", "s³ kg/in", 0.390625, 0);
  private static Unit_ platformUnit_ = secondcubkilogrampercentimeter_;
  private static Unit_ displayUnit_ = secondcubkilogrampercentimeter_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is TimeCubMassPerLength other && Equals(other);
  public bool Equals(TimeCubMassPerLength other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(TimeCubMassPerLength other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is TimeCubMassPerLength other)) throw new ArgumentException("Object is not a TimeCubMassPerLength.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => !(l1 == l2);
  public static bool operator <(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(TimeCubMassPerLength l1, TimeCubMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static TimeCubMassPerLength FromSecondCubKilogramPerCentimeters(double value, double minValue, double maxValue) => new TimeCubMassPerLength((value + secondcubkilogrampercentimeter_.Offset) * secondcubkilogrampercentimeter_.Factor, minValue * secondcubkilogrampercentimeter_.Factor, maxValue * secondcubkilogrampercentimeter_.Factor);
  public static TimeCubMassPerLength FromSecondCubKilogramPerCentimeters(double value) => new TimeCubMassPerLength((value + secondcubkilogrampercentimeter_.Offset) * secondcubkilogrampercentimeter_.Factor);
  public double GetValueInSecondCubKilogramPerCentimeters() => (Value_ - secondcubkilogrampercentimeter_.Offset) / secondcubkilogrampercentimeter_.Factor;
  public static TimeCubMassPerLength FromSecondCubKilogramPerMillimeters(double value, double minValue, double maxValue) => new TimeCubMassPerLength((value + secondcubkilogrampermillimeter_.Offset) * secondcubkilogrampermillimeter_.Factor, minValue * secondcubkilogrampermillimeter_.Factor, maxValue * secondcubkilogrampermillimeter_.Factor);
  public static TimeCubMassPerLength FromSecondCubKilogramPerMillimeters(double value) => new TimeCubMassPerLength((value + secondcubkilogrampermillimeter_.Offset) * secondcubkilogrampermillimeter_.Factor);
  public double GetValueInSecondCubKilogramPerMillimeters() => (Value_ - secondcubkilogrampermillimeter_.Offset) / secondcubkilogrampermillimeter_.Factor;
  public static TimeCubMassPerLength FromSecondCubKilogramPerMeters(double value, double minValue, double maxValue) => new TimeCubMassPerLength((value + secondcubkilogrampermeter_.Offset) * secondcubkilogrampermeter_.Factor, minValue * secondcubkilogrampermeter_.Factor, maxValue * secondcubkilogrampermeter_.Factor);
  public static TimeCubMassPerLength FromSecondCubKilogramPerMeters(double value) => new TimeCubMassPerLength((value + secondcubkilogrampermeter_.Offset) * secondcubkilogrampermeter_.Factor);
  public double GetValueInSecondCubKilogramPerMeters() => (Value_ - secondcubkilogrampermeter_.Offset) / secondcubkilogrampermeter_.Factor;
  public static TimeCubMassPerLength FromSecondCubKilogramPerInchs(double value, double minValue, double maxValue) => new TimeCubMassPerLength((value + secondcubkilogramperinch_.Offset) * secondcubkilogramperinch_.Factor, minValue * secondcubkilogramperinch_.Factor, maxValue * secondcubkilogramperinch_.Factor);
  public static TimeCubMassPerLength FromSecondCubKilogramPerInchs(double value) => new TimeCubMassPerLength((value + secondcubkilogramperinch_.Offset) * secondcubkilogramperinch_.Factor);
  public double GetValueInSecondCubKilogramPerInchs() => (Value_ - secondcubkilogramperinch_.Offset) / secondcubkilogramperinch_.Factor;

#endregion

#region arithmetic
  public static TimeCubMassPerLength operator+(TimeCubMassPerLength o1, TimeCubMassPerLength o2) => new TimeCubMassPerLength(o1.Value_ + o2.Value_);
  public static TimeCubMassPerLength operator-(TimeCubMassPerLength o1, TimeCubMassPerLength o2) => new TimeCubMassPerLength(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(TimeCubMassPerLength o1, TimeCubMassPerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(TimeCubMassPerLength o1, LengthPerMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthPerMassTimeCub o1, TimeCubMassPerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(TimeCubMassPerLength o1, TimeCubLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(TimeCubLengthMass o1, TimeCubMassPerLength o2) => new Area(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(TimeCubMassPerLength o1, LengthSqrPerMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthSqrPerMassTimeSqr o1, TimeCubMassPerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(TimeCubMassPerLength o1, LengthSqrPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrPerTimeCub o1, TimeCubMassPerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static Density operator/(TimeCubMassPerLength o1, TimeCubLengthSqr o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(TimeCubLengthSqr o1, TimeCubMassPerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator/(TimeCubMassPerLength o1, LengthSqrTimeSqrMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrTimeSqrMass o1, TimeCubMassPerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(TimeCubMassPerLength o1, LengthCubPerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthCubPerMassTime o1, TimeCubMassPerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(TimeCubMassPerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubPerTimeSqr o1, TimeCubMassPerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(TimeCubMassPerLength o1, TimeCubPerLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(TimeCubPerLengthCub o1, TimeCubMassPerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(TimeCubMassPerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(TimeSqrMassPerLengthCub o1, TimeCubMassPerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(TimeCubMassPerLength o1, PerMassLengthSqrTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerMassLengthSqrTimeCub o1, TimeCubMassPerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static Length operator/(TimeCubMassPerLength o1, TimeCubMassPerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(TimeCubMassPerLengthSqr o1, TimeCubMassPerLength o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Length operator*(TimeCubMassPerLength o1, LengthSqrPerMassTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrPerMassTimeCub o1, TimeCubMassPerLength o2) => new Length(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(TimeCubMassPerLength o1, TimeCubLengthSqrMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(TimeCubLengthSqrMass o1, TimeCubMassPerLength o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(TimeCubMassPerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubPerMassTimeSqr o1, TimeCubMassPerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(TimeCubMassPerLength o1, LengthCubPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubPerTimeCub o1, TimeCubMassPerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static Area operator/(TimeCubMassPerLength o1, TimeCubMassPerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(TimeCubMassPerLengthCub o1, TimeCubMassPerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator*(TimeCubMassPerLength o1, LengthCubPerMassTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubPerMassTimeCub o1, TimeCubMassPerLength o2) => new Area(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("TimeCubMassPerLength is outside its bounds.");
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
    