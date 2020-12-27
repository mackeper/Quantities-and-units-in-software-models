
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerLengthTimeSqr : Quantity, IEquatable<MassPerLengthTimeSqr>, IComparable
  {  
    internal MassPerLengthTimeSqr(double value) : base(value, 2)
    {
      MassPerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerLengthTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerLengthTimeSqr(MassPerLengthTimeSqr other) : base(other)
    {
      MassPerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthTimeSqr"))
    {
      switch(FakeDatabase.Units["MassPerLengthTimeSqr"])
      {
        case "kilogrampercentimetersecondsqr": displayUnit_ = kilogrampercentimetersecondsqr_; break;
        case "kilogrampermillimetersecondsqr": displayUnit_ = kilogrampermillimetersecondsqr_; break;
        case "kilogrampermetersecondsqr": displayUnit_ = kilogrampermetersecondsqr_; break;
        case "kilogramperinchsecondsqr": displayUnit_ = kilogramperinchsecondsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampercentimetersecondsqr_ = new Unit_("KilogramPerCentimeterSecondSqr", "kg/cm s²", 1.0, 0);
  private static Unit_ kilogrampermillimetersecondsqr_ = new Unit_("KilogramPerMillimeterSecondSqr", "kg/mm s²", 10.0, 0);
  private static Unit_ kilogrampermetersecondsqr_ = new Unit_("KilogramPerMeterSecondSqr", "kg/m s²", 0.01, 0);
  private static Unit_ kilogramperinchsecondsqr_ = new Unit_("KilogramPerInchSecondSqr", "kg/in s²", 0.390625, 0);
  private static Unit_ platformUnit_ = kilogrampercentimetersecondsqr_;
  private static Unit_ displayUnit_ = kilogrampercentimetersecondsqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerLengthTimeSqr other && Equals(other);
  public bool Equals(MassPerLengthTimeSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerLengthTimeSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerLengthTimeSqr other)) throw new ArgumentException("Object is not a MassPerLengthTimeSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => !(l1 == l2);
  public static bool operator <(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerLengthTimeSqr l1, MassPerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerLengthTimeSqr FromKilogramPerCentimeterSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthTimeSqr((value + kilogrampercentimetersecondsqr_.Offset) * kilogrampercentimetersecondsqr_.Factor, minValue * kilogrampercentimetersecondsqr_.Factor, maxValue * kilogrampercentimetersecondsqr_.Factor);
  public static MassPerLengthTimeSqr FromKilogramPerCentimeterSecondSqrs(double value) => new MassPerLengthTimeSqr((value + kilogrampercentimetersecondsqr_.Offset) * kilogrampercentimetersecondsqr_.Factor);
  public double GetValueInKilogramPerCentimeterSecondSqrs() => (Value_ - kilogrampercentimetersecondsqr_.Offset) / kilogrampercentimetersecondsqr_.Factor;
  public static MassPerLengthTimeSqr FromKilogramPerMillimeterSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthTimeSqr((value + kilogrampermillimetersecondsqr_.Offset) * kilogrampermillimetersecondsqr_.Factor, minValue * kilogrampermillimetersecondsqr_.Factor, maxValue * kilogrampermillimetersecondsqr_.Factor);
  public static MassPerLengthTimeSqr FromKilogramPerMillimeterSecondSqrs(double value) => new MassPerLengthTimeSqr((value + kilogrampermillimetersecondsqr_.Offset) * kilogrampermillimetersecondsqr_.Factor);
  public double GetValueInKilogramPerMillimeterSecondSqrs() => (Value_ - kilogrampermillimetersecondsqr_.Offset) / kilogrampermillimetersecondsqr_.Factor;
  public static MassPerLengthTimeSqr FromKilogramPerMeterSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthTimeSqr((value + kilogrampermetersecondsqr_.Offset) * kilogrampermetersecondsqr_.Factor, minValue * kilogrampermetersecondsqr_.Factor, maxValue * kilogrampermetersecondsqr_.Factor);
  public static MassPerLengthTimeSqr FromKilogramPerMeterSecondSqrs(double value) => new MassPerLengthTimeSqr((value + kilogrampermetersecondsqr_.Offset) * kilogrampermetersecondsqr_.Factor);
  public double GetValueInKilogramPerMeterSecondSqrs() => (Value_ - kilogrampermetersecondsqr_.Offset) / kilogrampermetersecondsqr_.Factor;
  public static MassPerLengthTimeSqr FromKilogramPerInchSecondSqrs(double value, double minValue, double maxValue) => new MassPerLengthTimeSqr((value + kilogramperinchsecondsqr_.Offset) * kilogramperinchsecondsqr_.Factor, minValue * kilogramperinchsecondsqr_.Factor, maxValue * kilogramperinchsecondsqr_.Factor);
  public static MassPerLengthTimeSqr FromKilogramPerInchSecondSqrs(double value) => new MassPerLengthTimeSqr((value + kilogramperinchsecondsqr_.Offset) * kilogramperinchsecondsqr_.Factor);
  public double GetValueInKilogramPerInchSecondSqrs() => (Value_ - kilogramperinchsecondsqr_.Offset) / kilogramperinchsecondsqr_.Factor;

#endregion

#region arithmetic
  public static MassPerLengthTimeSqr operator+(MassPerLengthTimeSqr o1, MassPerLengthTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ + o2.Value_);
  public static MassPerLengthTimeSqr operator-(MassPerLengthTimeSqr o1, MassPerLengthTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerLengthTimeSqr o1, MassPerLengthTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(MassPerLengthTimeSqr o1, TimeCubPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubPerMass o1, MassPerLengthTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator/(MassPerLengthTimeSqr o1, MassPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(MassPerTimeCub o1, MassPerLengthTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassPerLengthTimeSqr o1, TimeSqrLengthPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeSqrLengthPerMass o1, MassPerLengthTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator/(MassPerLengthTimeSqr o1, LengthPerTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthPerTimeCub o1, MassPerLengthTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(MassPerLengthTimeSqr o1, TimeCubLength o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(TimeCubLength o1, MassPerLengthTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator/(MassPerLengthTimeSqr o1, Force o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(Force o1, MassPerLengthTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(MassPerLengthTimeSqr o1, LengthSqrPerMassTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthSqrPerMassTime o1, MassPerLengthTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassPerLengthTimeSqr o1, LengthSqrTimePerMass o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthSqrTimePerMass o1, MassPerLengthTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Density operator/(MassPerLengthTimeSqr o1, QDose o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(QDose o1, MassPerLengthTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(MassPerLengthTimeSqr o1, LengthSqrTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthSqrTimeSqr o1, MassPerLengthTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrMassPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthSqrMassPerTime o1, MassPerLengthTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(MassPerLengthTimeSqr o1, LengthSqrMassTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthSqrMassTime o1, MassPerLengthTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static QDose operator*(MassPerLengthTimeSqr o1, LengthCubPerMass o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthCubPerMass o1, MassPerLengthTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(MassPerLengthTimeSqr o1, LengthCubPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthCubPerTime o1, MassPerLengthTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator*(MassPerLengthTimeSqr o1, LengthCubTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthCubTime o1, MassPerLengthTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(MassPerLengthTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerTimeSqrLengthCub o1, MassPerLengthTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(MassPerLengthTimeSqr o1, MassPerTimeLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(MassPerTimeLengthCub o1, MassPerLengthTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(MassPerLengthTimeSqr o1, MassTimePerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(MassTimePerLengthCub o1, MassPerLengthTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(MassPerLengthTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(TimeSqrPerMassLengthSqr o1, MassPerLengthTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator/(MassPerLengthTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerLengthSqrTimeCub o1, MassPerLengthTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(MassPerLengthTimeSqr o1, TimeCubPerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(TimeCubPerLengthSqr o1, MassPerLengthTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static Length operator/(MassPerLengthTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(MassPerLengthTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimeCubPerLengthMass o1, MassPerLengthTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static Time operator/(MassPerLengthTimeSqr o1, MassPerLengthTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerLengthTimeCub o1, MassPerLengthTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(MassPerLengthTimeSqr o1, TimeCubLengthPerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimeCubLengthPerMass o1, MassPerLengthTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator/(MassPerLengthTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthMassPerTimeCub o1, MassPerLengthTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static Length operator*(MassPerLengthTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrPerTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthSqrPerTimeCub o1, MassPerLengthTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(MassPerLengthTimeSqr o1, TimeCubLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(TimeCubLengthSqr o1, MassPerLengthTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static PerLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthSqrMassPerTimeSqr o1, MassPerLengthTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(MassPerLengthTimeSqr o1, LengthCubPerMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthCubPerMassTime o1, MassPerLengthTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTime operator*(MassPerLengthTimeSqr o1, LengthCubTimePerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthCubTimePerMass o1, MassPerLengthTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator*(MassPerLengthTimeSqr o1, LengthCubTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthCubTimeSqr o1, MassPerLengthTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator/(MassPerLengthTimeSqr o1, PerLengthCubTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerLengthCubTimeCub o1, MassPerLengthTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(MassPerLengthTimeSqr o1, MassPerTimeSqrLengthCub o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(MassPerTimeSqrLengthCub o1, MassPerLengthTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(MassPerLengthTimeSqr o1, TimeCubPerMassLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimeCubPerMassLengthSqr o1, MassPerLengthTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthTime operator/(MassPerLengthTimeSqr o1, MassPerLengthSqrTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerLengthSqrTimeCub o1, MassPerLengthTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(MassPerLengthTimeSqr o1, TimeCubLengthSqrPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(TimeCubLengthSqrPerMass o1, MassPerLengthTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrMassPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthSqrMassPerTimeCub o1, MassPerLengthTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(MassPerLengthTimeSqr o1, LengthCubTimeSqrPerMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthCubTimeSqrPerMass o1, MassPerLengthTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassTime operator*(MassPerLengthTimeSqr o1, LengthCubTimeCub o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthCubTimeCub o1, MassPerLengthTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator/(MassPerLengthTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(MassPerLengthCubTimeCub o1, MassPerLengthTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(MassPerLengthTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthCubTimeCubPerMass o1, MassPerLengthTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerLengthTimeSqr is outside its bounds.");
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
    