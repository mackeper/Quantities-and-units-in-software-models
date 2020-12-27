
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Mass : Quantity, IEquatable<Mass>, IComparable
  {  
    internal Mass(double value) : base(value, 2)
    {
      Mass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Mass(double value, double minValue, double maxValue) : base(value, 2)
    {
      Mass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Mass(Mass other) : base(other)
    {
      Mass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Mass"))
    {
      switch(FakeDatabase.Units["Mass"])
      {
        case "kilogram": displayUnit_ = kilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogram_ = new Unit_("Kilogram", "kg", 1, 0);
  private static Unit_ platformUnit_ = kilogram_;
  private static Unit_ displayUnit_ = kilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Mass other && Equals(other);
  public bool Equals(Mass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Mass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Mass other)) throw new ArgumentException("Object is not a Mass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Mass l1, Mass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Mass l1, Mass l2) => !(l1 == l2);
  public static bool operator <(Mass l1, Mass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Mass l1, Mass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Mass l1, Mass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Mass l1, Mass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Mass FromKilograms(double value, double minValue, double maxValue) => new Mass((value + kilogram_.Offset) * kilogram_.Factor, minValue * kilogram_.Factor, maxValue * kilogram_.Factor);
  public static Mass FromKilograms(double value) => new Mass((value + kilogram_.Offset) * kilogram_.Factor);
  public double GetValueInKilograms() => (Value_ - kilogram_.Offset) / kilogram_.Factor;

#endregion

#region arithmetic
  public static Mass operator+(Mass o1, Mass o2) => new Mass(o1.Value_ + o2.Value_);
  public static Mass operator-(Mass o1, Mass o2) => new Mass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Mass o1, Mass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthMass operator*(Mass o1, Length o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(Length o1, Mass o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(Mass o1, Length o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(Length o1, Mass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(Mass o1, PerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerLengthSqr o1, Mass o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator/(Mass o1, PerLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerLengthSqr o1, Mass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(Mass o1, PerLengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthMass o1, Mass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(Mass o1, PerLengthTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerLengthTime o1, Mass o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(Mass o1, PerLengthTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(PerLengthTime o1, Mass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(Mass o1, TimePerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimePerLength o1, Mass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(Mass o1, TimePerLength o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(TimePerLength o1, Mass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(Mass o1, MassPerLength o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(MassPerLength o1, Mass o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(Mass o1, PerMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerMassTime o1, Mass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(Mass o1, TimePerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerMass o1, Mass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(Mass o1, PerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(PerTimeSqr o1, Mass o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(Mass o1, PerTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(PerTimeSqr o1, Mass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(Mass o1, TimeSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqr o1, Mass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator/(Mass o1, TimeSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqr o1, Mass o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(Mass o1, MassPerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerTime o1, Mass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(Mass o1, MassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(MassTime o1, Mass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static Length operator*(Mass o1, LengthPerMass o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthPerMass o1, Mass o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(Mass o1, Speed o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(Speed o1, Mass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(Mass o1, Speed o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(Speed o1, Mass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(Mass o1, LengthTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(LengthTime o1, Mass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(Mass o1, LengthTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthTime o1, Mass o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(Mass o1, LengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthMass o1, Mass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(Mass o1, Area o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(Area o1, Mass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator/(Mass o1, Area o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(Area o1, Mass o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Density operator*(Mass o1, PerLengthCub o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(PerLengthCub o1, Mass o2) => new Density(o1.Value_ * o2.Value_);
  public static LengthCubMass operator/(Mass o1, PerLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerLengthCub o1, Mass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(Mass o1, PerMassLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassLengthSqr o1, Mass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(Mass o1, PerTimeLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(PerTimeLengthSqr o1, Mass o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator/(Mass o1, PerTimeLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthSqr operator/(PerTimeLengthSqr o1, Mass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator*(Mass o1, TimePerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimePerLengthSqr o1, Mass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator/(Mass o1, TimePerLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthSqr operator/(TimePerLengthSqr o1, Mass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static Area operator/(Mass o1, MassPerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
  public static PerLengthSqr operator/(MassPerLengthSqr o1, Mass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(Mass o1, PerLengthMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerLengthMassTime o1, Mass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(Mass o1, TimePerLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerLengthMass o1, Mass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(Mass o1, PerLengthTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(PerLengthTimeSqr o1, Mass o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator/(Mass o1, PerLengthTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(PerLengthTimeSqr o1, Mass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(Mass o1, TimeSqrPerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrPerLength o1, Mass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static Force operator/(Mass o1, TimeSqrPerLength o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrPerLength o1, Mass o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthTime operator/(Mass o1, MassPerLengthTime o2) => new LengthTime(o1.Value_ / o2.Value_);
  public static PerLengthTime operator/(MassPerLengthTime o1, Mass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  
  public static Speed operator/(Mass o1, MassTimePerLength o2) => new Speed(o1.Value_ / o2.Value_);
  public static TimePerLength operator/(MassTimePerLength o1, Mass o2) => new TimePerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(Mass o1, PerMassTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerMassTimeSqr o1, Mass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(Mass o1, TimeSqrPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerMass o1, Mass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(Mass o1, PerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(PerTimeCub o1, Mass o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(Mass o1, PerTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(PerTimeCub o1, Mass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(Mass o1, TimeCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCub o1, Mass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator/(Mass o1, TimeCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCub o1, Mass o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(Mass o1, MassPerTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(MassPerTimeSqr o1, Mass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(Mass o1, TimeSqrMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrMass o1, Mass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static Speed operator*(Mass o1, LengthPerMassTime o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthPerMassTime o1, Mass o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static LengthTime operator*(Mass o1, LengthTimePerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
  public static LengthTime operator*(LengthTimePerMass o1, Mass o2) => new LengthTime(o1.Value_ * o2.Value_);
  
  public static Force operator*(Mass o1, Acceleration o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(Acceleration o1, Mass o2) => new Force(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(Mass o1, Acceleration o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(Acceleration o1, Mass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(Mass o1, TimeSqrLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeSqrLength o1, Mass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(Mass o1, TimeSqrLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(TimeSqrLength o1, Mass o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(Mass o1, LengthMassPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthMassPerTime o1, Mass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(Mass o1, LengthMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthMassTime o1, Mass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static Area operator*(Mass o1, LengthSqrPerMass o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(LengthSqrPerMass o1, Mass o2) => new Area(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTime operator*(Mass o1, LengthSqrPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(LengthSqrPerTime o1, Mass o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator/(Mass o1, LengthSqrPerTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthSqrPerTime o1, Mass o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassTime operator*(Mass o1, LengthSqrTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassTime operator*(LengthSqrTime o1, Mass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator/(Mass o1, LengthSqrTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthSqrTime o1, Mass o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(Mass o1, LengthSqrMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthSqrMass o1, Mass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(Mass o1, Volume o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(Volume o1, Mass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static Density operator/(Mass o1, Volume o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(Volume o1, Mass o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator*(Mass o1, PerMassLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  public static PerLengthCub operator*(PerMassLengthCub o1, Mass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthCub operator*(Mass o1, PerTimeLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator*(PerTimeLengthCub o1, Mass o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(Mass o1, PerTimeLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerTimeLengthCub o1, Mass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthCub operator*(Mass o1, TimePerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator*(TimePerLengthCub o1, Mass o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(Mass o1, TimePerLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerLengthCub o1, Mass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(Mass o1, Density o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(Density o1, Mass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(Mass o1, PerMassTimeLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerMassTimeLengthSqr o1, Mass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(Mass o1, TimePerMassLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimePerMassLengthSqr o1, Mass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(Mass o1, PerLengthSqrTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(PerLengthSqrTimeSqr o1, Mass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(Mass o1, PerLengthSqrTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthSqrTimeSqr o1, Mass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(Mass o1, TimeSqrPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrPerLengthSqr o1, Mass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(Mass o1, TimeSqrPerLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerLengthSqr o1, Mass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(Mass o1, MassPerTimeLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(MassPerTimeLengthSqr o1, Mass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(Mass o1, MassTimePerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(MassTimePerLengthSqr o1, Mass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(Mass o1, PerLengthMassTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerLengthMassTimeSqr o1, Mass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(Mass o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerLengthMass o1, Mass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(Mass o1, PerLengthTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(PerLengthTimeCub o1, Mass o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(Mass o1, PerLengthTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerLengthTimeCub o1, Mass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(Mass o1, TimeCubPerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubPerLength o1, Mass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(Mass o1, TimeCubPerLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubPerLength o1, Mass o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(Mass o1, MassPerLengthTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerLengthTimeSqr o1, Mass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(Mass o1, TimeSqrMassPerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrMassPerLength o1, Mass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(Mass o1, PerMassTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerMassTimeCub o1, Mass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(Mass o1, TimeCubPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerMass o1, Mass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(Mass o1, MassPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(MassPerTimeCub o1, Mass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(Mass o1, TimeCubMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubMass o1, Mass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(Mass o1, LengthPerMassTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(LengthPerMassTimeSqr o1, Mass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(Mass o1, TimeSqrLengthPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrLengthPerMass o1, Mass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(Mass o1, LengthPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(LengthPerTimeCub o1, Mass o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(Mass o1, LengthPerTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthPerTimeCub o1, Mass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(Mass o1, TimeCubLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubLength o1, Mass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(Mass o1, TimeCubLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubLength o1, Mass o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(Mass o1, Force o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(Force o1, Mass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(Mass o1, TimeSqrLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(TimeSqrLengthMass o1, Mass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(Mass o1, LengthSqrPerMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthSqrPerMassTime o1, Mass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(Mass o1, LengthSqrTimePerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthSqrTimePerMass o1, Mass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(Mass o1, QDose o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(QDose o1, Mass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(Mass o1, QDose o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(QDose o1, Mass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(Mass o1, LengthSqrTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(LengthSqrTimeSqr o1, Mass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(Mass o1, LengthSqrTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthSqrTimeSqr o1, Mass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(Mass o1, LengthSqrMassPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthSqrMassPerTime o1, Mass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(Mass o1, LengthSqrMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthSqrMassTime o1, Mass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static Volume operator*(Mass o1, LengthCubPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthCubPerMass o1, Mass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator*(Mass o1, LengthCubPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthCubPerTime o1, Mass o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static MassTimePerLengthCub operator/(Mass o1, LengthCubPerTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTime operator/(LengthCubPerTime o1, Mass o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Mass o1, LengthCubTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthCubTime o1, Mass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthCub operator/(Mass o1, LengthCubTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimePerMass operator/(LengthCubTime o1, Mass o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthCub operator/(Mass o1, LengthCubMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  public static Volume operator/(LengthCubMass o1, Mass o2) => new Volume(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator*(Mass o1, PerMassTimeLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeLengthCub operator*(PerMassTimeLengthCub o1, Mass o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
  
  public static TimePerLengthCub operator*(Mass o1, TimePerMassLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  public static TimePerLengthCub operator*(TimePerMassLengthCub o1, Mass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqrLengthCub operator*(Mass o1, PerTimeSqrLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator*(PerTimeSqrLengthCub o1, Mass o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(Mass o1, PerTimeSqrLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerTimeSqrLengthCub o1, Mass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthCub operator*(Mass o1, TimeSqrPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator*(TimeSqrPerLengthCub o1, Mass o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(Mass o1, TimeSqrPerLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerLengthCub o1, Mass o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator/(Mass o1, MassPerTimeLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(MassPerTimeLengthCub o1, Mass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(Mass o1, MassTimePerLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(MassTimePerLengthCub o1, Mass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(Mass o1, PerMassLengthSqrTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassLengthSqrTimeSqr o1, Mass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(Mass o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrPerMassLengthSqr o1, Mass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(Mass o1, PerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(PerLengthSqrTimeCub o1, Mass o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(Mass o1, PerLengthSqrTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthSqrTimeCub o1, Mass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(Mass o1, TimeCubPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCubPerLengthSqr o1, Mass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(Mass o1, TimeCubPerLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubPerLengthSqr o1, Mass o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator/(Mass o1, MassPerLengthSqrTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(MassPerLengthSqrTimeSqr o1, Mass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(Mass o1, TimeSqrMassPerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, Mass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(Mass o1, PerLengthMassTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerLengthMassTimeCub o1, Mass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(Mass o1, TimeCubPerLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerLengthMass o1, Mass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(Mass o1, MassPerLengthTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(MassPerLengthTimeCub o1, Mass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(Mass o1, TimeCubMassPerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubMassPerLength o1, Mass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(Mass o1, LengthPerMassTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(LengthPerMassTimeCub o1, Mass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(Mass o1, TimeCubLengthPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubLengthPerMass o1, Mass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(Mass o1, LengthMassPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthMassPerTimeCub o1, Mass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(Mass o1, TimeCubLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubLengthMass o1, Mass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static QDose operator*(Mass o1, LengthSqrPerMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthSqrPerMassTimeSqr o1, Mass o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(Mass o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(LengthSqrTimeSqrPerMass o1, Mass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Mass o1, LengthSqrPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthSqrPerTimeCub o1, Mass o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(Mass o1, LengthSqrPerTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthSqrPerTimeCub o1, Mass o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(Mass o1, TimeCubLengthSqr o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubLengthSqr o1, Mass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(Mass o1, TimeCubLengthSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(TimeCubLengthSqr o1, Mass o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(Mass o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthSqrMassPerTimeSqr o1, Mass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(Mass o1, LengthSqrTimeSqrMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthSqrTimeSqrMass o1, Mass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(Mass o1, LengthCubPerMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthCubPerMassTime o1, Mass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator*(Mass o1, LengthCubTimePerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthCubTimePerMass o1, Mass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(Mass o1, LengthCubPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthCubPerTimeSqr o1, Mass o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(Mass o1, LengthCubPerTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(LengthCubPerTimeSqr o1, Mass o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(Mass o1, LengthCubTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthCubTimeSqr o1, Mass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(Mass o1, LengthCubTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(LengthCubTimeSqr o1, Mass o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthCub operator/(Mass o1, LengthCubMassPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTime operator/(LengthCubMassPerTime o1, Mass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthCub operator/(Mass o1, LengthCubMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTime operator/(LengthCubMassTime o1, Mass o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator*(Mass o1, PerMassTimeSqrLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  public static PerTimeSqrLengthCub operator*(PerMassTimeSqrLengthCub o1, Mass o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthCub operator*(Mass o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthCub operator*(TimeSqrPerMassLengthCub o1, Mass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
  
  public static MassPerLengthCubTimeCub operator*(Mass o1, PerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator*(PerLengthCubTimeCub o1, Mass o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(Mass o1, PerLengthCubTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthCubTimeCub o1, Mass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthCub operator*(Mass o1, TimeCubPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator*(TimeCubPerLengthCub o1, Mass o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Mass o1, TimeCubPerLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerLengthCub o1, Mass o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(Mass o1, MassPerTimeSqrLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassPerTimeSqrLengthCub o1, Mass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(Mass o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrMassPerLengthCub o1, Mass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(Mass o1, PerMassLengthSqrTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerMassLengthSqrTimeCub o1, Mass o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(Mass o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubPerMassLengthSqr o1, Mass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(Mass o1, MassPerLengthSqrTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(MassPerLengthSqrTimeCub o1, Mass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(Mass o1, TimeCubMassPerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubMassPerLengthSqr o1, Mass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(Mass o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthSqrPerMassTimeCub o1, Mass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(Mass o1, TimeCubLengthSqrPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubLengthSqrPerMass o1, Mass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(Mass o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthSqrMassPerTimeCub o1, Mass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(Mass o1, TimeCubLengthSqrMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(TimeCubLengthSqrMass o1, Mass o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(Mass o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthCubPerMassTimeSqr o1, Mass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(Mass o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthCubTimeSqrPerMass o1, Mass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Mass o1, LengthCubPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthCubPerTimeCub o1, Mass o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthCub operator/(Mass o1, LengthCubPerTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerMassTimeCub operator/(LengthCubPerTimeCub o1, Mass o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(Mass o1, LengthCubTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(LengthCubTimeCub o1, Mass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static MassPerLengthCubTimeCub operator/(Mass o1, LengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCubPerMass operator/(LengthCubTimeCub o1, Mass o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthCub operator/(Mass o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeSqr operator/(LengthCubMassPerTimeSqr o1, Mass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqrLengthCub operator/(Mass o1, LengthCubTimeSqrMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeSqr operator/(LengthCubTimeSqrMass o1, Mass o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator*(Mass o1, PerMassLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthCubTimeCub operator*(PerMassLengthCubTimeCub o1, Mass o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator*(Mass o1, TimeCubPerMassLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthCub operator*(TimeCubPerMassLengthCub o1, Mass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(Mass o1, MassPerLengthCubTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(MassPerLengthCubTimeCub o1, Mass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(Mass o1, TimeCubMassPerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubMassPerLengthCub o1, Mass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Mass o1, LengthCubPerMassTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthCubPerMassTimeCub o1, Mass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(Mass o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(LengthCubTimeCubPerMass o1, Mass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthCub operator/(Mass o1, LengthCubMassPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubPerTimeCub operator/(LengthCubMassPerTimeCub o1, Mass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthCubTimeCub operator/(Mass o1, LengthCubTimeCubMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  public static LengthCubTimeCub operator/(LengthCubTimeCubMass o1, Mass o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Mass is outside its bounds.");
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
    