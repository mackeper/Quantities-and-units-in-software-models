
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerLengthSqrTimeSqr : Quantity, IEquatable<MassPerLengthSqrTimeSqr>, IComparable
  {  
    internal MassPerLengthSqrTimeSqr(double value) : base(value, 2)
    {
      MassPerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerLengthSqrTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerLengthSqrTimeSqr(MassPerLengthSqrTimeSqr other) : base(other)
    {
      MassPerLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthSqrTimeSqr"))
    {
      switch(FakeDatabase.Units["MassPerLengthSqrTimeSqr"])
      {
        case "kilogrampercentimetersqrsecondsqr": displayUnit_ = kilogrampercentimetersqrsecondsqr_; break;
        case "kilogrampermillimetersqrsecondsqr": displayUnit_ = kilogrampermillimetersqrsecondsqr_; break;
        case "kilogrampermetersqrsecondsqr": displayUnit_ = kilogrampermetersqrsecondsqr_; break;
        case "kilogramperinchsqrsecondsqr": displayUnit_ = kilogramperinchsqrsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampercentimetersqrsecondsqr_ = new Unit_("KilogramPerCentimeterSqrSecondSqr", "kg/cm² s²", 1.0, 0);
  private static Unit_ kilogrampermillimetersqrsecondsqr_ = new Unit_("KilogramPerMillimeterSqrSecondSqr", "kg/mm² s²", 99.99999999999999, 0);
  private static Unit_ kilogrampermetersqrsecondsqr_ = new Unit_("KilogramPerMeterSqrSecondSqr", "kg/m² s²", 0.0001, 0);
  private static Unit_ kilogramperinchsqrsecondsqr_ = new Unit_("KilogramPerInchSqrSecondSqr", "kg/in² s²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = kilogrampercentimetersqrsecondsqr_;
  private static Unit_ displayUnit_ = kilogrampercentimetersqrsecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerLengthSqrTimeSqr other && Equals(other);
  public bool Equals(MassPerLengthSqrTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerLengthSqrTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerLengthSqrTimeSqr other)) throw new ArgumentException("Object is not a MassPerLengthSqrTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => !(l1 == l2);
  public static bool operator <(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerLengthSqrTimeSqr l1, MassPerLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerLengthSqrTimeSqr FromKilogramPerCentimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeSqr((value + kilogrampercentimetersqrsecondsqr_.Offset) * kilogrampercentimetersqrsecondsqr_.Factor, minValue * kilogrampercentimetersqrsecondsqr_.Factor, maxValue * kilogrampercentimetersqrsecondsqr_.Factor);
  public static MassPerLengthSqrTimeSqr FromKilogramPerCentimeterSqrSecondSqrs(double value) => new MassPerLengthSqrTimeSqr((value + kilogrampercentimetersqrsecondsqr_.Offset) * kilogrampercentimetersqrsecondsqr_.Factor);
  public double GetValueInKilogramPerCentimeterSqrSecondSqrs() => (Value_ - kilogrampercentimetersqrsecondsqr_.Offset) / kilogrampercentimetersqrsecondsqr_.Factor;
  public static MassPerLengthSqrTimeSqr FromKilogramPerMillimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeSqr((value + kilogrampermillimetersqrsecondsqr_.Offset) * kilogrampermillimetersqrsecondsqr_.Factor, minValue * kilogrampermillimetersqrsecondsqr_.Factor, maxValue * kilogrampermillimetersqrsecondsqr_.Factor);
  public static MassPerLengthSqrTimeSqr FromKilogramPerMillimeterSqrSecondSqrs(double value) => new MassPerLengthSqrTimeSqr((value + kilogrampermillimetersqrsecondsqr_.Offset) * kilogrampermillimetersqrsecondsqr_.Factor);
  public double GetValueInKilogramPerMillimeterSqrSecondSqrs() => (Value_ - kilogrampermillimetersqrsecondsqr_.Offset) / kilogrampermillimetersqrsecondsqr_.Factor;
  public static MassPerLengthSqrTimeSqr FromKilogramPerMeterSqrSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeSqr((value + kilogrampermetersqrsecondsqr_.Offset) * kilogrampermetersqrsecondsqr_.Factor, minValue * kilogrampermetersqrsecondsqr_.Factor, maxValue * kilogrampermetersqrsecondsqr_.Factor);
  public static MassPerLengthSqrTimeSqr FromKilogramPerMeterSqrSecondSqrs(double value) => new MassPerLengthSqrTimeSqr((value + kilogrampermetersqrsecondsqr_.Offset) * kilogrampermetersqrsecondsqr_.Factor);
  public double GetValueInKilogramPerMeterSqrSecondSqrs() => (Value_ - kilogrampermetersqrsecondsqr_.Offset) / kilogrampermetersqrsecondsqr_.Factor;
  public static MassPerLengthSqrTimeSqr FromKilogramPerInchSqrSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthSqrTimeSqr((value + kilogramperinchsqrsecondsqr_.Offset) * kilogramperinchsqrsecondsqr_.Factor, minValue * kilogramperinchsqrsecondsqr_.Factor, maxValue * kilogramperinchsqrsecondsqr_.Factor);
  public static MassPerLengthSqrTimeSqr FromKilogramPerInchSqrSecondSqrs(double value) => new MassPerLengthSqrTimeSqr((value + kilogramperinchsqrsecondsqr_.Offset) * kilogramperinchsqrsecondsqr_.Factor);
  public double GetValueInKilogramPerInchSqrSecondSqrs() => (Value_ - kilogramperinchsqrsecondsqr_.Offset) / kilogramperinchsqrsecondsqr_.Factor;

#endregion

#region arithmetic
  public static MassPerLengthSqrTimeSqr operator+(MassPerLengthSqrTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ + o2.Value_);
  public static MassPerLengthSqrTimeSqr operator-(MassPerLengthSqrTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(MassPerLengthSqrTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeCubPerLengthMass o1, MassPerLengthSqrTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(MassPerLengthTimeCub o1, MassPerLengthSqrTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(MassPerLengthSqrTimeSqr o1, TimeCubLengthPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubLengthPerMass o1, MassPerLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(MassPerLengthSqrTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthMassPerTimeCub o1, MassPerLengthSqrTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassPerLengthSqrTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(MassPerLengthSqrTimeSqr o1, TimeCubLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeCubLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(MassPerLengthSqrTimeSqr o1, LengthCubPerMassTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthCubPerMassTime o1, MassPerLengthSqrTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassPerLengthSqrTimeSqr o1, LengthCubTimePerMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubTimePerMass o1, MassPerLengthSqrTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(MassPerLengthSqrTimeSqr o1, LengthCubTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(MassPerLengthSqrTimeSqr o1, PerLengthCubTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerLengthCubTimeCub o1, MassPerLengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static Length operator/(MassPerLengthSqrTimeSqr o1, MassPerTimeSqrLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerTimeSqrLengthCub o1, MassPerLengthSqrTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static Time operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthSqrTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerLengthSqrTimeCub o1, MassPerLengthSqrTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(MassPerLengthSqrTimeSqr o1, TimeCubLengthSqrPerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubLengthSqrPerMass o1, MassPerLengthSqrTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Length operator*(MassPerLengthSqrTimeSqr o1, LengthCubTimeSqrPerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimeSqrPerMass o1, MassPerLengthSqrTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(MassPerLengthSqrTimeSqr o1, LengthCubTimeCub o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthCubTimeCub o1, MassPerLengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthTime operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerLengthCubTimeCub o1, MassPerLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(MassPerLengthSqrTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubTimeCubPerMass o1, MassPerLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerLengthSqrTimeSqr is outside its bounds.");
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
    