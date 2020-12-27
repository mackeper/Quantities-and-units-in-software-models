
// GENERATED FILE! (20/10/2020 20:11:29)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Dimensionless : Quantity, IEquatable<Dimensionless>, IComparable
  {  
    internal Dimensionless(double value) : base(value, 2)
    {
      Dimensionless.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Dimensionless(double value, double minValue, double maxValue) : base(value, 2)
    {
      Dimensionless.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Dimensionless(Dimensionless other) : base(other)
    {
      Dimensionless.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Dimensionless"))
    {
      switch(FakeDatabase.Units["Dimensionless"])
      {
        case "": displayUnit_ = _; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ _ = new Unit_("", "", 1, 0);
  private static Unit_ platformUnit_ = _;
  private static Unit_ displayUnit_ = _;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Dimensionless other && Equals(other);
  public bool Equals(Dimensionless other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Dimensionless other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Dimensionless other)) throw new ArgumentException("Object is not a Dimensionless.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Dimensionless l1, Dimensionless l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Dimensionless l1, Dimensionless l2) => !(l1 == l2);
  public static bool operator <(Dimensionless l1, Dimensionless l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Dimensionless l1, Dimensionless l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Dimensionless l1, Dimensionless l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Dimensionless l1, Dimensionless l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Dimensionless Froms(double value, double minValue, double maxValue) => new Dimensionless((value + _.Offset) * _.Factor, minValue * _.Factor, maxValue * _.Factor);
  public static Dimensionless Froms(double value) => new Dimensionless((value + _.Offset) * _.Factor);
  public double GetValueIns() => (Value_ - _.Offset) / _.Factor;

#endregion

#region arithmetic
  public static Dimensionless operator+(Dimensionless o1, Dimensionless o2) => new Dimensionless(o1.Value_ + o2.Value_);
  public static Dimensionless operator-(Dimensionless o1, Dimensionless o2) => new Dimensionless(o1.Value_ - o2.Value_);
  public static Dimensionless operator*(Dimensionless o1, Dimensionless o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator/(Dimensionless o1, Dimensionless o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(Dimensionless o1, PerLength o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLength o1, Dimensionless o2) => new PerLength(o1.Value_ * o2.Value_);
  public static Length operator/(Dimensionless o1, PerLength o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerLength o1, Dimensionless o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(Dimensionless o1, PerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMass o1, Dimensionless o2) => new PerMass(o1.Value_ * o2.Value_);
  public static Mass operator/(Dimensionless o1, PerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerMass o1, Dimensionless o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(Dimensionless o1, PerTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerTime o1, Dimensionless o2) => new PerTime(o1.Value_ * o2.Value_);
  public static Time operator/(Dimensionless o1, PerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(PerTime o1, Dimensionless o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(Dimensionless o1, Time o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(Time o1, Dimensionless o2) => new Time(o1.Value_ * o2.Value_);
  public static PerTime operator/(Dimensionless o1, Time o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(Time o1, Dimensionless o2) => new Time(o1.Value_ / o2.Value_);
  
  public static Mass operator*(Dimensionless o1, Mass o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(Mass o1, Dimensionless o2) => new Mass(o1.Value_ * o2.Value_);
  public static PerMass operator/(Dimensionless o1, Mass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(Mass o1, Dimensionless o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static Length operator*(Dimensionless o1, Length o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(Length o1, Dimensionless o2) => new Length(o1.Value_ * o2.Value_);
  public static PerLength operator/(Dimensionless o1, Length o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(Length o1, Dimensionless o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerElectricCurrent operator*(PerElectricCurrent o1, Dimensionless o2) => new PerElectricCurrent(o1.Value_ * o2.Value_);
  public static PerElectricCurrent operator/(PerElectricCurrent o1, Dimensionless o2) => new PerElectricCurrent(o1.Value_ / o2.Value_);
  
  public static ElectricCurrent operator*(ElectricCurrent o1, Dimensionless o2) => new ElectricCurrent(o1.Value_ * o2.Value_);
  public static ElectricCurrent operator/(ElectricCurrent o1, Dimensionless o2) => new ElectricCurrent(o1.Value_ / o2.Value_);
  
  public static PerTemperature operator*(PerTemperature o1, Dimensionless o2) => new PerTemperature(o1.Value_ * o2.Value_);
  public static PerTemperature operator/(PerTemperature o1, Dimensionless o2) => new PerTemperature(o1.Value_ / o2.Value_);
  
  public static Temperature operator*(Temperature o1, Dimensionless o2) => new Temperature(o1.Value_ * o2.Value_);
  public static Temperature operator/(Temperature o1, Dimensionless o2) => new Temperature(o1.Value_ / o2.Value_);
  
  public static PerAmountOfSubstance operator*(PerAmountOfSubstance o1, Dimensionless o2) => new PerAmountOfSubstance(o1.Value_ * o2.Value_);
  public static PerAmountOfSubstance operator/(PerAmountOfSubstance o1, Dimensionless o2) => new PerAmountOfSubstance(o1.Value_ / o2.Value_);
  
  public static AmountOfSubstance operator*(AmountOfSubstance o1, Dimensionless o2) => new AmountOfSubstance(o1.Value_ * o2.Value_);
  public static AmountOfSubstance operator/(AmountOfSubstance o1, Dimensionless o2) => new AmountOfSubstance(o1.Value_ / o2.Value_);
  
  public static PerLuminousIntensity operator*(PerLuminousIntensity o1, Dimensionless o2) => new PerLuminousIntensity(o1.Value_ * o2.Value_);
  public static PerLuminousIntensity operator/(PerLuminousIntensity o1, Dimensionless o2) => new PerLuminousIntensity(o1.Value_ / o2.Value_);
  
  public static LuminousIntensity operator*(LuminousIntensity o1, Dimensionless o2) => new LuminousIntensity(o1.Value_ * o2.Value_);
  public static LuminousIntensity operator/(LuminousIntensity o1, Dimensionless o2) => new LuminousIntensity(o1.Value_ / o2.Value_);
  
  public static PerAngle operator*(PerAngle o1, Dimensionless o2) => new PerAngle(o1.Value_ * o2.Value_);
  public static PerAngle operator/(PerAngle o1, Dimensionless o2) => new PerAngle(o1.Value_ / o2.Value_);
  
  public static Angle operator*(Angle o1, Dimensionless o2) => new Angle(o1.Value_ * o2.Value_);
  public static Angle operator/(Angle o1, Dimensionless o2) => new Angle(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(Dimensionless o1, PerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerLengthSqr o1, Dimensionless o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static Area operator/(Dimensionless o1, PerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(PerLengthSqr o1, Dimensionless o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(Dimensionless o1, PerLengthMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerLengthMass o1, Dimensionless o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator/(Dimensionless o1, PerLengthMass o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(PerLengthMass o1, Dimensionless o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(Dimensionless o1, PerLengthTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerLengthTime o1, Dimensionless o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator/(Dimensionless o1, PerLengthTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(PerLengthTime o1, Dimensionless o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(Dimensionless o1, TimePerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerLength o1, Dimensionless o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static Speed operator/(Dimensionless o1, TimePerLength o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(TimePerLength o1, Dimensionless o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(Dimensionless o1, MassPerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(MassPerLength o1, Dimensionless o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static LengthPerMass operator/(Dimensionless o1, MassPerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassPerLength o1, Dimensionless o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(Dimensionless o1, PerMassTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassTime o1, Dimensionless o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static MassTime operator/(Dimensionless o1, PerMassTime o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(PerMassTime o1, Dimensionless o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator*(Dimensionless o1, TimePerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimePerMass o1, Dimensionless o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static MassPerTime operator/(Dimensionless o1, TimePerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(TimePerMass o1, Dimensionless o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(Dimensionless o1, PerTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerTimeSqr o1, Dimensionless o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator/(Dimensionless o1, PerTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(PerTimeSqr o1, Dimensionless o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator*(Dimensionless o1, TimeSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqr o1, Dimensionless o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator/(Dimensionless o1, TimeSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqr o1, Dimensionless o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator*(Dimensionless o1, MassPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerTime o1, Dimensionless o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static TimePerMass operator/(Dimensionless o1, MassPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(MassPerTime o1, Dimensionless o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static MassTime operator*(Dimensionless o1, MassTime o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(MassTime o1, Dimensionless o2) => new MassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator/(Dimensionless o1, MassTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassTime o1, Dimensionless o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(Dimensionless o1, LengthPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthPerMass o1, Dimensionless o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(Dimensionless o1, LengthPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthPerMass o1, Dimensionless o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static Speed operator*(Dimensionless o1, Speed o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(Speed o1, Dimensionless o2) => new Speed(o1.Value_ * o2.Value_);
  public static TimePerLength operator/(Dimensionless o1, Speed o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(Speed o1, Dimensionless o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static LengthTime operator*(Dimensionless o1, LengthTime o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthTime o1, Dimensionless o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator/(Dimensionless o1, LengthTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthTime o1, Dimensionless o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(Dimensionless o1, LengthMass o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthMass o1, Dimensionless o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator/(Dimensionless o1, LengthMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthMass o1, Dimensionless o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static Area operator*(Dimensionless o1, Area o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(Area o1, Dimensionless o2) => new Area(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator/(Dimensionless o1, Area o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(Area o1, Dimensionless o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(Dimensionless o1, PerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerLengthCub o1, Dimensionless o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static Volume operator/(Dimensionless o1, PerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerLengthCub o1, Dimensionless o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(Dimensionless o1, PerMassLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(PerMassLengthSqr o1, Dimensionless o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator/(Dimensionless o1, PerMassLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerMassLengthSqr o1, Dimensionless o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(Dimensionless o1, PerTimeLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerTimeLengthSqr o1, Dimensionless o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator/(Dimensionless o1, PerTimeLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(PerTimeLengthSqr o1, Dimensionless o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator*(Dimensionless o1, TimePerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimePerLengthSqr o1, Dimensionless o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator/(Dimensionless o1, TimePerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(TimePerLengthSqr o1, Dimensionless o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(Dimensionless o1, MassPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(MassPerLengthSqr o1, Dimensionless o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator/(Dimensionless o1, MassPerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassPerLengthSqr o1, Dimensionless o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(Dimensionless o1, PerLengthMassTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerLengthMassTime o1, Dimensionless o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(Dimensionless o1, PerLengthMassTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerLengthMassTime o1, Dimensionless o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator*(Dimensionless o1, TimePerLengthMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimePerLengthMass o1, Dimensionless o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(Dimensionless o1, TimePerLengthMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimePerLengthMass o1, Dimensionless o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(Dimensionless o1, PerLengthTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthTimeSqr o1, Dimensionless o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator/(Dimensionless o1, PerLengthTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(PerLengthTimeSqr o1, Dimensionless o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator*(Dimensionless o1, TimeSqrPerLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerLength o1, Dimensionless o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static Acceleration operator/(Dimensionless o1, TimeSqrPerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrPerLength o1, Dimensionless o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(Dimensionless o1, MassPerLengthTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerLengthTime o1, Dimensionless o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(Dimensionless o1, MassPerLengthTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(MassPerLengthTime o1, Dimensionless o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(Dimensionless o1, MassTimePerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassTimePerLength o1, Dimensionless o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(Dimensionless o1, MassTimePerLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(MassTimePerLength o1, Dimensionless o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(Dimensionless o1, PerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassTimeSqr o1, Dimensionless o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(Dimensionless o1, PerMassTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerMassTimeSqr o1, Dimensionless o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator*(Dimensionless o1, TimeSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerMass o1, Dimensionless o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator/(Dimensionless o1, TimeSqrPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqrPerMass o1, Dimensionless o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(Dimensionless o1, PerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerTimeCub o1, Dimensionless o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator/(Dimensionless o1, PerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(PerTimeCub o1, Dimensionless o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCub operator*(Dimensionless o1, TimeCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCub o1, Dimensionless o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator/(Dimensionless o1, TimeCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCub o1, Dimensionless o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator*(Dimensionless o1, MassPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerTimeSqr o1, Dimensionless o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator/(Dimensionless o1, MassPerTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(MassPerTimeSqr o1, Dimensionless o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(Dimensionless o1, TimeSqrMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrMass o1, Dimensionless o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator/(Dimensionless o1, TimeSqrMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(TimeSqrMass o1, Dimensionless o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator*(Dimensionless o1, LengthPerMassTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthPerMassTime o1, Dimensionless o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(Dimensionless o1, LengthPerMassTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthPerMassTime o1, Dimensionless o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(Dimensionless o1, LengthTimePerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(LengthTimePerMass o1, Dimensionless o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(Dimensionless o1, LengthTimePerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthTimePerMass o1, Dimensionless o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(Dimensionless o1, Acceleration o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(Acceleration o1, Dimensionless o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator/(Dimensionless o1, Acceleration o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(Acceleration o1, Dimensionless o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(Dimensionless o1, TimeSqrLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrLength o1, Dimensionless o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator/(Dimensionless o1, TimeSqrLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrLength o1, Dimensionless o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(Dimensionless o1, LengthMassPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthMassPerTime o1, Dimensionless o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator/(Dimensionless o1, LengthMassPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthMassPerTime o1, Dimensionless o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(Dimensionless o1, LengthMassTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthMassTime o1, Dimensionless o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator/(Dimensionless o1, LengthMassTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthMassTime o1, Dimensionless o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(Dimensionless o1, LengthSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(LengthSqrPerMass o1, Dimensionless o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator/(Dimensionless o1, LengthSqrPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthSqrPerMass o1, Dimensionless o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(Dimensionless o1, LengthSqrPerTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthSqrPerTime o1, Dimensionless o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator/(Dimensionless o1, LengthSqrPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrPerTime o1, Dimensionless o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator*(Dimensionless o1, LengthSqrTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthSqrTime o1, Dimensionless o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator/(Dimensionless o1, LengthSqrTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthSqrTime o1, Dimensionless o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(Dimensionless o1, LengthSqrMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(LengthSqrMass o1, Dimensionless o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator/(Dimensionless o1, LengthSqrMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthSqrMass o1, Dimensionless o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
  public static Volume operator*(Dimensionless o1, Volume o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(Volume o1, Dimensionless o2) => new Volume(o1.Value_ * o2.Value_);
  public static PerLengthCub operator/(Dimensionless o1, Volume o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(Volume o1, Dimensionless o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(Dimensionless o1, PerMassLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(PerMassLengthCub o1, Dimensionless o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMass operator/(Dimensionless o1, PerMassLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerMassLengthCub o1, Dimensionless o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(Dimensionless o1, PerTimeLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerTimeLengthCub o1, Dimensionless o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTime operator/(Dimensionless o1, PerTimeLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(PerTimeLengthCub o1, Dimensionless o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator*(Dimensionless o1, TimePerLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimePerLengthCub o1, Dimensionless o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator/(Dimensionless o1, TimePerLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(TimePerLengthCub o1, Dimensionless o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static Density operator*(Dimensionless o1, Density o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(Density o1, Dimensionless o2) => new Density(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator/(Dimensionless o1, Density o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(Density o1, Dimensionless o2) => new Density(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(Dimensionless o1, PerMassTimeLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(PerMassTimeLengthSqr o1, Dimensionless o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator/(Dimensionless o1, PerMassTimeLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerMassTimeLengthSqr o1, Dimensionless o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthSqr operator*(Dimensionless o1, TimePerMassLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator*(TimePerMassLengthSqr o1, Dimensionless o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator/(Dimensionless o1, TimePerMassLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimePerMassLengthSqr o1, Dimensionless o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(Dimensionless o1, PerLengthSqrTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerLengthSqrTimeSqr o1, Dimensionless o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator/(Dimensionless o1, PerLengthSqrTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(PerLengthSqrTimeSqr o1, Dimensionless o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(Dimensionless o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrPerLengthSqr o1, Dimensionless o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static QDose operator/(Dimensionless o1, TimeSqrPerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrPerLengthSqr o1, Dimensionless o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(Dimensionless o1, MassPerTimeLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(MassPerTimeLengthSqr o1, Dimensionless o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator/(Dimensionless o1, MassPerTimeLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthSqr operator/(MassPerTimeLengthSqr o1, Dimensionless o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(Dimensionless o1, MassTimePerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(MassTimePerLengthSqr o1, Dimensionless o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator/(Dimensionless o1, MassTimePerLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthSqr operator/(MassTimePerLengthSqr o1, Dimensionless o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(Dimensionless o1, PerLengthMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerLengthMassTimeSqr o1, Dimensionless o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator/(Dimensionless o1, PerLengthMassTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthMassTimeSqr o1, Dimensionless o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(Dimensionless o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrPerLengthMass o1, Dimensionless o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static Force operator/(Dimensionless o1, TimeSqrPerLengthMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrPerLengthMass o1, Dimensionless o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(Dimensionless o1, PerLengthTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerLengthTimeCub o1, Dimensionless o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLength operator/(Dimensionless o1, PerLengthTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(PerLengthTimeCub o1, Dimensionless o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator*(Dimensionless o1, TimeCubPerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerLength o1, Dimensionless o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator/(Dimensionless o1, TimeCubPerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubPerLength o1, Dimensionless o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(Dimensionless o1, MassPerLengthTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerLengthTimeSqr o1, Dimensionless o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator/(Dimensionless o1, MassPerLengthTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(MassPerLengthTimeSqr o1, Dimensionless o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(Dimensionless o1, TimeSqrMassPerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrMassPerLength o1, Dimensionless o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator/(Dimensionless o1, TimeSqrMassPerLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrMassPerLength o1, Dimensionless o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(Dimensionless o1, PerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerMassTimeCub o1, Dimensionless o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(Dimensionless o1, PerMassTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerMassTimeCub o1, Dimensionless o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator*(Dimensionless o1, TimeCubPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerMass o1, Dimensionless o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator/(Dimensionless o1, TimeCubPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubPerMass o1, Dimensionless o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator*(Dimensionless o1, MassPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerTimeCub o1, Dimensionless o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator/(Dimensionless o1, MassPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(MassPerTimeCub o1, Dimensionless o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(Dimensionless o1, TimeCubMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubMass o1, Dimensionless o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator/(Dimensionless o1, TimeCubMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubMass o1, Dimensionless o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(Dimensionless o1, LengthPerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthPerMassTimeSqr o1, Dimensionless o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(Dimensionless o1, LengthPerMassTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthPerMassTimeSqr o1, Dimensionless o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(Dimensionless o1, TimeSqrLengthPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeSqrLengthPerMass o1, Dimensionless o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(Dimensionless o1, TimeSqrLengthPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeSqrLengthPerMass o1, Dimensionless o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(Dimensionless o1, LengthPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthPerTimeCub o1, Dimensionless o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator/(Dimensionless o1, LengthPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthPerTimeCub o1, Dimensionless o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator*(Dimensionless o1, TimeCubLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubLength o1, Dimensionless o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator/(Dimensionless o1, TimeCubLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubLength o1, Dimensionless o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static Force operator*(Dimensionless o1, Force o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(Force o1, Dimensionless o2) => new Force(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator/(Dimensionless o1, Force o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(Force o1, Dimensionless o2) => new Force(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(Dimensionless o1, TimeSqrLengthMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeSqrLengthMass o1, Dimensionless o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator/(Dimensionless o1, TimeSqrLengthMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(TimeSqrLengthMass o1, Dimensionless o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTime operator*(Dimensionless o1, LengthSqrPerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTime operator*(LengthSqrPerMassTime o1, Dimensionless o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(Dimensionless o1, LengthSqrPerMassTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthSqrPerMassTime o1, Dimensionless o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimePerMass operator*(Dimensionless o1, LengthSqrTimePerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimePerMass operator*(LengthSqrTimePerMass o1, Dimensionless o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(Dimensionless o1, LengthSqrTimePerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthSqrTimePerMass o1, Dimensionless o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static QDose operator*(Dimensionless o1, QDose o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(QDose o1, Dimensionless o2) => new QDose(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator/(Dimensionless o1, QDose o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(QDose o1, Dimensionless o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator*(Dimensionless o1, LengthSqrTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthSqrTimeSqr o1, Dimensionless o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator/(Dimensionless o1, LengthSqrTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthSqrTimeSqr o1, Dimensionless o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(Dimensionless o1, LengthSqrMassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthSqrMassPerTime o1, Dimensionless o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthSqr operator/(Dimensionless o1, LengthSqrMassPerTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTime operator/(LengthSqrMassPerTime o1, Dimensionless o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(Dimensionless o1, LengthSqrMassTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthSqrMassTime o1, Dimensionless o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator/(Dimensionless o1, LengthSqrMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthSqrMassTime o1, Dimensionless o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(Dimensionless o1, LengthCubPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(LengthCubPerMass o1, Dimensionless o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static Density operator/(Dimensionless o1, LengthCubPerMass o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthCubPerMass o1, Dimensionless o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(Dimensionless o1, LengthCubPerTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthCubPerTime o1, Dimensionless o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator/(Dimensionless o1, LengthCubPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubPerTime o1, Dimensionless o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator*(Dimensionless o1, LengthCubTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubTime o1, Dimensionless o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator/(Dimensionless o1, LengthCubTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthCubTime o1, Dimensionless o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(Dimensionless o1, LengthCubMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(LengthCubMass o1, Dimensionless o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator/(Dimensionless o1, LengthCubMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthCubMass o1, Dimensionless o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthCub operator*(Dimensionless o1, PerMassTimeLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator*(PerMassTimeLengthCub o1, Dimensionless o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(Dimensionless o1, PerMassTimeLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerMassTimeLengthCub o1, Dimensionless o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static TimePerMassLengthCub operator*(Dimensionless o1, TimePerMassLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator*(TimePerMassLengthCub o1, Dimensionless o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(Dimensionless o1, TimePerMassLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerMassLengthCub o1, Dimensionless o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(Dimensionless o1, PerTimeSqrLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerTimeSqrLengthCub o1, Dimensionless o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator/(Dimensionless o1, PerTimeSqrLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerTimeSqrLengthCub o1, Dimensionless o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(Dimensionless o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeSqrPerLengthCub o1, Dimensionless o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator/(Dimensionless o1, TimeSqrPerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrPerLengthCub o1, Dimensionless o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthCub operator*(Dimensionless o1, MassPerTimeLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(MassPerTimeLengthCub o1, Dimensionless o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(Dimensionless o1, MassPerTimeLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerTimeLengthCub o1, Dimensionless o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(Dimensionless o1, MassTimePerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(MassTimePerLengthCub o1, Dimensionless o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(Dimensionless o1, MassTimePerLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(MassTimePerLengthCub o1, Dimensionless o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(Dimensionless o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(PerMassLengthSqrTimeSqr o1, Dimensionless o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(Dimensionless o1, PerMassLengthSqrTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassLengthSqrTimeSqr o1, Dimensionless o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthSqr operator*(Dimensionless o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerMassLengthSqr o1, Dimensionless o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(Dimensionless o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerMassLengthSqr o1, Dimensionless o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(Dimensionless o1, PerLengthSqrTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerLengthSqrTimeCub o1, Dimensionless o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator/(Dimensionless o1, PerLengthSqrTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerLengthSqrTimeCub o1, Dimensionless o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(Dimensionless o1, TimeCubPerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubPerLengthSqr o1, Dimensionless o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator/(Dimensionless o1, TimeCubPerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubPerLengthSqr o1, Dimensionless o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(Dimensionless o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassPerLengthSqrTimeSqr o1, Dimensionless o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(Dimensionless o1, MassPerLengthSqrTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerLengthSqrTimeSqr o1, Dimensionless o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(Dimensionless o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrMassPerLengthSqr o1, Dimensionless o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(Dimensionless o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, Dimensionless o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(Dimensionless o1, PerLengthMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerLengthMassTimeCub o1, Dimensionless o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(Dimensionless o1, PerLengthMassTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerLengthMassTimeCub o1, Dimensionless o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator*(Dimensionless o1, TimeCubPerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubPerLengthMass o1, Dimensionless o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(Dimensionless o1, TimeCubPerLengthMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubPerLengthMass o1, Dimensionless o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator*(Dimensionless o1, MassPerLengthTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerLengthTimeCub o1, Dimensionless o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(Dimensionless o1, MassPerLengthTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(MassPerLengthTimeCub o1, Dimensionless o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(Dimensionless o1, TimeCubMassPerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubMassPerLength o1, Dimensionless o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(Dimensionless o1, TimeCubMassPerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubMassPerLength o1, Dimensionless o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator*(Dimensionless o1, LengthPerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(LengthPerMassTimeCub o1, Dimensionless o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(Dimensionless o1, LengthPerMassTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthPerMassTimeCub o1, Dimensionless o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(Dimensionless o1, TimeCubLengthPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubLengthPerMass o1, Dimensionless o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(Dimensionless o1, TimeCubLengthPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubLengthPerMass o1, Dimensionless o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator*(Dimensionless o1, LengthMassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthMassPerTimeCub o1, Dimensionless o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator/(Dimensionless o1, LengthMassPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthMassPerTimeCub o1, Dimensionless o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(Dimensionless o1, TimeCubLengthMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubLengthMass o1, Dimensionless o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator/(Dimensionless o1, TimeCubLengthMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(TimeCubLengthMass o1, Dimensionless o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(Dimensionless o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(LengthSqrPerMassTimeSqr o1, Dimensionless o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(Dimensionless o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthSqrPerMassTimeSqr o1, Dimensionless o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(Dimensionless o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(LengthSqrTimeSqrPerMass o1, Dimensionless o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(Dimensionless o1, LengthSqrTimeSqrPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthSqrTimeSqrPerMass o1, Dimensionless o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(Dimensionless o1, LengthSqrPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthSqrPerTimeCub o1, Dimensionless o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator/(Dimensionless o1, LengthSqrPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthSqrPerTimeCub o1, Dimensionless o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator*(Dimensionless o1, TimeCubLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubLengthSqr o1, Dimensionless o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator/(Dimensionless o1, TimeCubLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubLengthSqr o1, Dimensionless o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(Dimensionless o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(LengthSqrMassPerTimeSqr o1, Dimensionless o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(Dimensionless o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthSqrMassPerTimeSqr o1, Dimensionless o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(Dimensionless o1, LengthSqrTimeSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthSqrTimeSqrMass o1, Dimensionless o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(Dimensionless o1, LengthSqrTimeSqrMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthSqrTimeSqrMass o1, Dimensionless o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(Dimensionless o1, LengthCubPerMassTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthCubPerMassTime o1, Dimensionless o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(Dimensionless o1, LengthCubPerMassTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthCubPerMassTime o1, Dimensionless o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(Dimensionless o1, LengthCubTimePerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthCubTimePerMass o1, Dimensionless o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(Dimensionless o1, LengthCubTimePerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(LengthCubTimePerMass o1, Dimensionless o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(Dimensionless o1, LengthCubPerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthCubPerTimeSqr o1, Dimensionless o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator/(Dimensionless o1, LengthCubPerTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubPerTimeSqr o1, Dimensionless o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(Dimensionless o1, LengthCubTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubTimeSqr o1, Dimensionless o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator/(Dimensionless o1, LengthCubTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthCubTimeSqr o1, Dimensionless o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(Dimensionless o1, LengthCubMassPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthCubMassPerTime o1, Dimensionless o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static TimePerMassLengthCub operator/(Dimensionless o1, LengthCubMassPerTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTime operator/(LengthCubMassPerTime o1, Dimensionless o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Dimensionless o1, LengthCubMassTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthCubMassTime o1, Dimensionless o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthCub operator/(Dimensionless o1, LengthCubMassTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassTime operator/(LengthCubMassTime o1, Dimensionless o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqrLengthCub operator*(Dimensionless o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator*(PerMassTimeSqrLengthCub o1, Dimensionless o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(Dimensionless o1, PerMassTimeSqrLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerMassTimeSqrLengthCub o1, Dimensionless o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMassLengthCub operator*(Dimensionless o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator*(TimeSqrPerMassLengthCub o1, Dimensionless o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(Dimensionless o1, TimeSqrPerMassLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerMassLengthCub o1, Dimensionless o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(Dimensionless o1, PerLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerLengthCubTimeCub o1, Dimensionless o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator/(Dimensionless o1, PerLengthCubTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthCubTimeCub o1, Dimensionless o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthCub operator*(Dimensionless o1, TimeCubPerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCubPerLengthCub o1, Dimensionless o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator/(Dimensionless o1, TimeCubPerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubPerLengthCub o1, Dimensionless o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(Dimensionless o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(MassPerTimeSqrLengthCub o1, Dimensionless o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(Dimensionless o1, MassPerTimeSqrLengthCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerTimeSqrLengthCub o1, Dimensionless o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(Dimensionless o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeSqrMassPerLengthCub o1, Dimensionless o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(Dimensionless o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeSqrMassPerLengthCub o1, Dimensionless o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator*(Dimensionless o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator*(PerMassLengthSqrTimeCub o1, Dimensionless o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(Dimensionless o1, PerMassLengthSqrTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassLengthSqrTimeCub o1, Dimensionless o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthSqr operator*(Dimensionless o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator*(TimeCubPerMassLengthSqr o1, Dimensionless o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(Dimensionless o1, TimeCubPerMassLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubPerMassLengthSqr o1, Dimensionless o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(Dimensionless o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(MassPerLengthSqrTimeCub o1, Dimensionless o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(Dimensionless o1, MassPerLengthSqrTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerLengthSqrTimeCub o1, Dimensionless o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(Dimensionless o1, TimeCubMassPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCubMassPerLengthSqr o1, Dimensionless o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(Dimensionless o1, TimeCubMassPerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubMassPerLengthSqr o1, Dimensionless o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(Dimensionless o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(LengthSqrPerMassTimeCub o1, Dimensionless o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(Dimensionless o1, LengthSqrPerMassTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthSqrPerMassTimeCub o1, Dimensionless o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(Dimensionless o1, TimeCubLengthSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeCubLengthSqrPerMass o1, Dimensionless o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(Dimensionless o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(TimeCubLengthSqrPerMass o1, Dimensionless o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Dimensionless o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthSqrMassPerTimeCub o1, Dimensionless o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(Dimensionless o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthSqrMassPerTimeCub o1, Dimensionless o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(Dimensionless o1, TimeCubLengthSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubLengthSqrMass o1, Dimensionless o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(Dimensionless o1, TimeCubLengthSqrMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(TimeCubLengthSqrMass o1, Dimensionless o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(Dimensionless o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthCubPerMassTimeSqr o1, Dimensionless o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(Dimensionless o1, LengthCubPerMassTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthCubPerMassTimeSqr o1, Dimensionless o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(Dimensionless o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(LengthCubTimeSqrPerMass o1, Dimensionless o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(Dimensionless o1, LengthCubTimeSqrPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthCubTimeSqrPerMass o1, Dimensionless o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Dimensionless o1, LengthCubPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthCubPerTimeCub o1, Dimensionless o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator/(Dimensionless o1, LengthCubPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthCubPerTimeCub o1, Dimensionless o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(Dimensionless o1, LengthCubTimeCub o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthCubTimeCub o1, Dimensionless o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator/(Dimensionless o1, LengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthCubTimeCub o1, Dimensionless o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(Dimensionless o1, LengthCubMassPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthCubMassPerTimeSqr o1, Dimensionless o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(Dimensionless o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthCubMassPerTimeSqr o1, Dimensionless o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(Dimensionless o1, LengthCubTimeSqrMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthCubTimeSqrMass o1, Dimensionless o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(Dimensionless o1, LengthCubTimeSqrMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthCubTimeSqrMass o1, Dimensionless o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCubTimeCub operator*(Dimensionless o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator*(PerMassLengthCubTimeCub o1, Dimensionless o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(Dimensionless o1, PerMassLengthCubTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassLengthCubTimeCub o1, Dimensionless o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMassLengthCub operator*(Dimensionless o1, TimeCubPerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator*(TimeCubPerMassLengthCub o1, Dimensionless o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Dimensionless o1, TimeCubPerMassLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerMassLengthCub o1, Dimensionless o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(Dimensionless o1, MassPerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(MassPerLengthCubTimeCub o1, Dimensionless o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(Dimensionless o1, MassPerLengthCubTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthCubTimeCub o1, Dimensionless o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(Dimensionless o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeCubMassPerLengthCub o1, Dimensionless o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(Dimensionless o1, TimeCubMassPerLengthCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubMassPerLengthCub o1, Dimensionless o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(Dimensionless o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthCubPerMassTimeCub o1, Dimensionless o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(Dimensionless o1, LengthCubPerMassTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthCubPerMassTimeCub o1, Dimensionless o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(Dimensionless o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(LengthCubTimeCubPerMass o1, Dimensionless o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(Dimensionless o1, LengthCubTimeCubPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthCubTimeCubPerMass o1, Dimensionless o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Dimensionless o1, LengthCubMassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthCubMassPerTimeCub o1, Dimensionless o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubPerMassLengthCub operator/(Dimensionless o1, LengthCubMassPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthCubMassPerTimeCub o1, Dimensionless o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(Dimensionless o1, LengthCubTimeCubMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthCubTimeCubMass o1, Dimensionless o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static PerMassLengthCubTimeCub operator/(Dimensionless o1, LengthCubTimeCubMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthCubTimeCubMass o1, Dimensionless o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Dimensionless is outside its bounds.");
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
    