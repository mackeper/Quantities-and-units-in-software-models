
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassTimePerLengthSqr : Quantity, IEquatable<MassTimePerLengthSqr>, IComparable
  {  
    internal MassTimePerLengthSqr(double value) : base(value, 2)
    {
      MassTimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassTimePerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassTimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassTimePerLengthSqr(MassTimePerLengthSqr other) : base(other)
    {
      MassTimePerLengthSqr.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassTimePerLengthSqr"))
    {
      switch(FakeDatabase.Units["MassTimePerLengthSqr"])
      {
        case "kilogramsecondpercentimetersqr": displayUnit_ = kilogramsecondpercentimetersqr_; break;
        case "kilogramsecondpermillimetersqr": displayUnit_ = kilogramsecondpermillimetersqr_; break;
        case "kilogramsecondpermetersqr": displayUnit_ = kilogramsecondpermetersqr_; break;
        case "kilogramsecondperinchsqr": displayUnit_ = kilogramsecondperinchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogramsecondpercentimetersqr_ = new Unit_("KilogramSecondPerCentimeterSqr", "kg s/cm²", 1.0, 0);
  private static Unit_ kilogramsecondpermillimetersqr_ = new Unit_("KilogramSecondPerMillimeterSqr", "kg s/mm²", 99.99999999999999, 0);
  private static Unit_ kilogramsecondpermetersqr_ = new Unit_("KilogramSecondPerMeterSqr", "kg s/m²", 0.0001, 0);
  private static Unit_ kilogramsecondperinchsqr_ = new Unit_("KilogramSecondPerInchSqr", "kg s/in²", 0.152587890625, 0);
  private static Unit_ platformUnit_ = kilogramsecondpercentimetersqr_;
  private static Unit_ displayUnit_ = kilogramsecondpercentimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassTimePerLengthSqr other && Equals(other);
  public bool Equals(MassTimePerLengthSqr other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassTimePerLengthSqr other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassTimePerLengthSqr other)) throw new ArgumentException("Object is not a MassTimePerLengthSqr.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => !(l1 == l2);
  public static bool operator <(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassTimePerLengthSqr l1, MassTimePerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassTimePerLengthSqr FromKilogramSecondPerCentimeterSqrs(double value, double minValue, double maxValue) => new MassTimePerLengthSqr((value + kilogramsecondpercentimetersqr_.Offset) * kilogramsecondpercentimetersqr_.Factor, minValue * kilogramsecondpercentimetersqr_.Factor, maxValue * kilogramsecondpercentimetersqr_.Factor);
  public static MassTimePerLengthSqr FromKilogramSecondPerCentimeterSqrs(double value) => new MassTimePerLengthSqr((value + kilogramsecondpercentimetersqr_.Offset) * kilogramsecondpercentimetersqr_.Factor);
  public double GetValueInKilogramSecondPerCentimeterSqrs() => (Value_ - kilogramsecondpercentimetersqr_.Offset) / kilogramsecondpercentimetersqr_.Factor;
  public static MassTimePerLengthSqr FromKilogramSecondPerMillimeterSqrs(double value, double minValue, double maxValue) => new MassTimePerLengthSqr((value + kilogramsecondpermillimetersqr_.Offset) * kilogramsecondpermillimetersqr_.Factor, minValue * kilogramsecondpermillimetersqr_.Factor, maxValue * kilogramsecondpermillimetersqr_.Factor);
  public static MassTimePerLengthSqr FromKilogramSecondPerMillimeterSqrs(double value) => new MassTimePerLengthSqr((value + kilogramsecondpermillimetersqr_.Offset) * kilogramsecondpermillimetersqr_.Factor);
  public double GetValueInKilogramSecondPerMillimeterSqrs() => (Value_ - kilogramsecondpermillimetersqr_.Offset) / kilogramsecondpermillimetersqr_.Factor;
  public static MassTimePerLengthSqr FromKilogramSecondPerMeterSqrs(double value, double minValue, double maxValue) => new MassTimePerLengthSqr((value + kilogramsecondpermetersqr_.Offset) * kilogramsecondpermetersqr_.Factor, minValue * kilogramsecondpermetersqr_.Factor, maxValue * kilogramsecondpermetersqr_.Factor);
  public static MassTimePerLengthSqr FromKilogramSecondPerMeterSqrs(double value) => new MassTimePerLengthSqr((value + kilogramsecondpermetersqr_.Offset) * kilogramsecondpermetersqr_.Factor);
  public double GetValueInKilogramSecondPerMeterSqrs() => (Value_ - kilogramsecondpermetersqr_.Offset) / kilogramsecondpermetersqr_.Factor;
  public static MassTimePerLengthSqr FromKilogramSecondPerInchSqrs(double value, double minValue, double maxValue) => new MassTimePerLengthSqr((value + kilogramsecondperinchsqr_.Offset) * kilogramsecondperinchsqr_.Factor, minValue * kilogramsecondperinchsqr_.Factor, maxValue * kilogramsecondperinchsqr_.Factor);
  public static MassTimePerLengthSqr FromKilogramSecondPerInchSqrs(double value) => new MassTimePerLengthSqr((value + kilogramsecondperinchsqr_.Offset) * kilogramsecondperinchsqr_.Factor);
  public double GetValueInKilogramSecondPerInchSqrs() => (Value_ - kilogramsecondperinchsqr_.Offset) / kilogramsecondperinchsqr_.Factor;

#endregion

#region arithmetic
  public static MassTimePerLengthSqr operator+(MassTimePerLengthSqr o1, MassTimePerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ + o2.Value_);
  public static MassTimePerLengthSqr operator-(MassTimePerLengthSqr o1, MassTimePerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassTimePerLengthSqr o1, MassTimePerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(MassTimePerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerLengthMassTimeSqr o1, MassTimePerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(MassTimePerLengthSqr o1, TimeSqrPerLengthMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeSqrPerLengthMass o1, MassTimePerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(MassTimePerLengthSqr o1, PerLengthTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(PerLengthTimeCub o1, MassTimePerLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(MassTimePerLengthSqr o1, TimeCubPerLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeCubPerLength o1, MassTimePerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(MassTimePerLengthSqr o1, MassPerLengthTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(MassPerLengthTimeSqr o1, MassTimePerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(MassTimePerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(TimeSqrMassPerLength o1, MassTimePerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(MassTimePerLengthSqr o1, PerMassTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassTimeCub o1, MassTimePerLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(MassTimePerLengthSqr o1, TimeCubMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(TimeCubMass o1, MassTimePerLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(MassTimePerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(LengthPerMassTimeSqr o1, MassTimePerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(MassTimePerLengthSqr o1, TimeSqrLengthPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeSqrLengthPerMass o1, MassTimePerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(MassTimePerLengthSqr o1, LengthPerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(LengthPerTimeCub o1, MassTimePerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator/(MassTimePerLengthSqr o1, TimeCubLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(TimeCubLength o1, MassTimePerLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator/(MassTimePerLengthSqr o1, Force o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(Force o1, MassTimePerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(MassTimePerLengthSqr o1, TimeSqrLengthMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(TimeSqrLengthMass o1, MassTimePerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(MassTimePerLengthSqr o1, LengthSqrPerMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthSqrPerMassTime o1, MassTimePerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(MassTimePerLengthSqr o1, LengthSqrTimePerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(LengthSqrTimePerMass o1, MassTimePerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(MassTimePerLengthSqr o1, QDose o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(QDose o1, MassTimePerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(MassTimePerLengthSqr o1, LengthSqrTimeSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(LengthSqrTimeSqr o1, MassTimePerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(MassTimePerLengthSqr o1, LengthCubPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthCubPerMass o1, MassTimePerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(MassTimePerLengthSqr o1, LengthCubPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubPerTime o1, MassTimePerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(MassTimePerLengthSqr o1, LengthCubTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(LengthCubTime o1, MassTimePerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator/(MassTimePerLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerTimeSqrLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator/(MassTimePerLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimeSqrPerLengthCub o1, MassTimePerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(MassTimePerLengthSqr o1, MassPerTimeLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerTimeLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Length operator/(MassTimePerLengthSqr o1, MassTimePerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassTimePerLengthCub o1, MassTimePerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(MassTimePerLengthSqr o1, TimeCubPerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeCubPerLengthSqr o1, MassTimePerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(MassTimePerLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(MassPerLengthSqrTimeSqr o1, MassTimePerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(MassTimePerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(TimeSqrMassPerLengthSqr o1, MassTimePerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(MassTimePerLengthSqr o1, PerLengthMassTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerLengthMassTimeCub o1, MassTimePerLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator/(MassTimePerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeCubMassPerLength o1, MassTimePerLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(MassTimePerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(LengthPerMassTimeCub o1, MassTimePerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(MassTimePerLengthSqr o1, TimeCubLengthMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(TimeCubLengthMass o1, MassTimePerLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(MassTimePerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(LengthSqrPerMassTimeSqr o1, MassTimePerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(MassTimePerLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(LengthSqrTimeSqrPerMass o1, MassTimePerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(MassTimePerLengthSqr o1, LengthSqrPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(LengthSqrPerTimeCub o1, MassTimePerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Length operator*(MassTimePerLengthSqr o1, LengthCubPerMassTime o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubPerMassTime o1, MassTimePerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(MassTimePerLengthSqr o1, LengthCubTimePerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(LengthCubTimePerMass o1, MassTimePerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(MassTimePerLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubPerTimeSqr o1, MassTimePerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(MassTimePerLengthSqr o1, LengthCubTimeSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(LengthCubTimeSqr o1, MassTimePerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static Force operator/(MassTimePerLengthSqr o1, TimeCubPerLengthCub o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeCubPerLengthCub o1, MassTimePerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator/(MassTimePerLengthSqr o1, MassPerTimeSqrLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(MassPerTimeSqrLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static Speed operator/(MassTimePerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimeSqrMassPerLengthCub o1, MassTimePerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(MassTimePerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeCubMassPerLengthSqr o1, MassTimePerLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(MassTimePerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(LengthSqrPerMassTimeCub o1, MassTimePerLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static Speed operator*(MassTimePerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubPerMassTimeSqr o1, MassTimePerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(MassTimePerLengthSqr o1, LengthCubTimeSqrPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(LengthCubTimeSqrPerMass o1, MassTimePerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static Force operator*(MassTimePerLengthSqr o1, LengthCubPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubPerTimeCub o1, MassTimePerLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
  
  public static Acceleration operator/(MassTimePerLengthSqr o1, TimeCubMassPerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeCubMassPerLengthCub o1, MassTimePerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(MassTimePerLengthSqr o1, LengthCubPerMassTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthCubPerMassTimeCub o1, MassTimePerLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassTimePerLengthSqr is outside its bounds.");
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
    