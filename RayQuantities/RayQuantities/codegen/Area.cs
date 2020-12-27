
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Area : Quantity, IEquatable<Area>, IComparable
  {  
    internal Area(double value) : base(value, 2)
    {
      Area.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Area(double value, double minValue, double maxValue) : base(value, 2)
    {
      Area.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Area(Area other) : base(other)
    {
      Area.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Area"))
    {
      switch(FakeDatabase.Units["Area"])
      {
        case "centimetersqr": displayUnit_ = centimetersqr_; break;
        case "millimetersqr": displayUnit_ = millimetersqr_; break;
        case "metersqr": displayUnit_ = metersqr_; break;
        case "inchsqr": displayUnit_ = inchsqr_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqr_ = new Unit_("CentimeterSqr", "cm²", 1, 0);
  private static Unit_ millimetersqr_ = new Unit_("MillimeterSqr", "mm²", 0.010000000000000002, 0);
  private static Unit_ metersqr_ = new Unit_("MeterSqr", "m²", 10000, 0);
  private static Unit_ inchsqr_ = new Unit_("InchSqr", "in²", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqr_;
  private static Unit_ displayUnit_ = centimetersqr_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Area other && Equals(other);
  public bool Equals(Area other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Area other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Area other)) throw new ArgumentException("Object is not a Area.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Area l1, Area l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Area l1, Area l2) => !(l1 == l2);
  public static bool operator <(Area l1, Area l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Area l1, Area l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Area l1, Area l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Area l1, Area l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Area FromCentimeterSqrs(double value, double minValue, double maxValue) => new Area((value + centimetersqr_.Offset) * centimetersqr_.Factor, minValue * centimetersqr_.Factor, maxValue * centimetersqr_.Factor);
  public static Area FromCentimeterSqrs(double value) => new Area((value + centimetersqr_.Offset) * centimetersqr_.Factor);
  public double GetValueInCentimeterSqrs() => (Value_ - centimetersqr_.Offset) / centimetersqr_.Factor;
  public static Area FromMillimeterSqrs(double value, double minValue, double maxValue) => new Area((value + millimetersqr_.Offset) * millimetersqr_.Factor, minValue * millimetersqr_.Factor, maxValue * millimetersqr_.Factor);
  public static Area FromMillimeterSqrs(double value) => new Area((value + millimetersqr_.Offset) * millimetersqr_.Factor);
  public double GetValueInMillimeterSqrs() => (Value_ - millimetersqr_.Offset) / millimetersqr_.Factor;
  public static Area FromMeterSqrs(double value, double minValue, double maxValue) => new Area((value + metersqr_.Offset) * metersqr_.Factor, minValue * metersqr_.Factor, maxValue * metersqr_.Factor);
  public static Area FromMeterSqrs(double value) => new Area((value + metersqr_.Offset) * metersqr_.Factor);
  public double GetValueInMeterSqrs() => (Value_ - metersqr_.Offset) / metersqr_.Factor;
  public static Area FromInchSqrs(double value, double minValue, double maxValue) => new Area((value + inchsqr_.Offset) * inchsqr_.Factor, minValue * inchsqr_.Factor, maxValue * inchsqr_.Factor);
  public static Area FromInchSqrs(double value) => new Area((value + inchsqr_.Offset) * inchsqr_.Factor);
  public double GetValueInInchSqrs() => (Value_ - inchsqr_.Offset) / inchsqr_.Factor;

#endregion

#region arithmetic
  public static Area operator+(Area o1, Area o2) => new Area(o1.Value_ + o2.Value_);
  public static Area operator-(Area o1, Area o2) => new Area(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Area o1, Area o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(Area o1, PerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerLengthCub o1, Area o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static PerMass operator*(Area o1, PerMassLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassLengthSqr o1, Area o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(Area o1, PerTimeLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerTimeLengthSqr o1, Area o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(Area o1, TimePerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerLengthSqr o1, Area o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Mass operator*(Area o1, MassPerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(MassPerLengthSqr o1, Area o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(Area o1, PerLengthMassTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerLengthMassTime o1, Area o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(Area o1, PerLengthMassTime o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerLengthMassTime o1, Area o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator*(Area o1, TimePerLengthMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimePerLengthMass o1, Area o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(Area o1, TimePerLengthMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerLengthMass o1, Area o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(Area o1, PerLengthTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthTimeSqr o1, Area o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator/(Area o1, PerLengthTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(PerLengthTimeSqr o1, Area o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator*(Area o1, TimeSqrPerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrPerLength o1, Area o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator/(Area o1, TimeSqrPerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrPerLength o1, Area o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator*(Area o1, MassPerLengthTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerLengthTime o1, Area o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator/(Area o1, MassPerLengthTime o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeLengthCub operator/(MassPerLengthTime o1, Area o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator*(Area o1, MassTimePerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(MassTimePerLength o1, Area o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator/(Area o1, MassTimePerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(MassTimePerLength o1, Area o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(Area o1, PerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(PerMassTimeSqr o1, Area o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(Area o1, PerMassTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerMassTimeSqr o1, Area o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(Area o1, TimeSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeSqrPerMass o1, Area o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(Area o1, TimeSqrPerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerMass o1, Area o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(Area o1, PerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(PerTimeCub o1, Area o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator/(Area o1, PerTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(PerTimeCub o1, Area o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator*(Area o1, TimeCub o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCub o1, Area o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator/(Area o1, TimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCub o1, Area o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(Area o1, MassPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(MassPerTimeSqr o1, Area o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(Area o1, MassPerTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(MassPerTimeSqr o1, Area o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(Area o1, TimeSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeSqrMass o1, Area o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(Area o1, TimeSqrMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrMass o1, Area o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(Area o1, LengthPerMassTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthPerMassTime o1, Area o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator/(Area o1, LengthPerMassTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(LengthPerMassTime o1, Area o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubTimePerMass operator*(Area o1, LengthTimePerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimePerMass operator*(LengthTimePerMass o1, Area o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator/(Area o1, LengthTimePerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(LengthTimePerMass o1, Area o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(Area o1, Acceleration o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(Acceleration o1, Area o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator/(Area o1, Acceleration o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(Acceleration o1, Area o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator*(Area o1, TimeSqrLength o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(TimeSqrLength o1, Area o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static Acceleration operator/(Area o1, TimeSqrLength o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrLength o1, Area o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(Area o1, LengthMassPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthMassPerTime o1, Area o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator/(Area o1, LengthMassPerTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(LengthMassPerTime o1, Area o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(Area o1, LengthMassTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthMassTime o1, Area o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator/(Area o1, LengthMassTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(LengthMassTime o1, Area o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(Area o1, LengthSqrPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthSqrPerMass o1, Area o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(Area o1, LengthSqrPerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthSqrPerTime o1, Area o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(Area o1, LengthSqrTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrTime o1, Area o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(Area o1, LengthSqrMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthSqrMass o1, Area o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(Area o1, Volume o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(Volume o1, Area o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(Area o1, PerMassLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(PerMassLengthCub o1, Area o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(Area o1, PerTimeLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerTimeLengthCub o1, Area o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(Area o1, TimePerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerLengthCub o1, Area o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator*(Area o1, Density o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(Density o1, Area o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(Area o1, PerMassTimeLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassTimeLengthSqr o1, Area o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(Area o1, TimePerMassLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimePerMassLengthSqr o1, Area o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(Area o1, PerLengthSqrTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthSqrTimeSqr o1, Area o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(Area o1, TimeSqrPerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerLengthSqr o1, Area o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(Area o1, MassPerTimeLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerTimeLengthSqr o1, Area o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(Area o1, MassTimePerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(MassTimePerLengthSqr o1, Area o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(Area o1, PerLengthMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerLengthMassTimeSqr o1, Area o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(Area o1, PerLengthMassTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthMassTimeSqr o1, Area o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(Area o1, TimeSqrPerLengthMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeSqrPerLengthMass o1, Area o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(Area o1, TimeSqrPerLengthMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerLengthMass o1, Area o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(Area o1, PerLengthTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(PerLengthTimeCub o1, Area o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator/(Area o1, PerLengthTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(PerLengthTimeCub o1, Area o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator*(Area o1, TimeCubPerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubPerLength o1, Area o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator/(Area o1, TimeCubPerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubPerLength o1, Area o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static Force operator*(Area o1, MassPerLengthTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerLengthTimeSqr o1, Area o2) => new Force(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator/(Area o1, MassPerLengthTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqrLengthCub operator/(MassPerLengthTimeSqr o1, Area o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator*(Area o1, TimeSqrMassPerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeSqrMassPerLength o1, Area o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator/(Area o1, TimeSqrMassPerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthCub operator/(TimeSqrMassPerLength o1, Area o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(Area o1, PerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(PerMassTimeCub o1, Area o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(Area o1, PerMassTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerMassTimeCub o1, Area o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(Area o1, TimeCubPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeCubPerMass o1, Area o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(Area o1, TimeCubPerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubPerMass o1, Area o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Area o1, MassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(MassPerTimeCub o1, Area o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(Area o1, MassPerTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(MassPerTimeCub o1, Area o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(Area o1, TimeCubMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubMass o1, Area o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(Area o1, TimeCubMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubMass o1, Area o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(Area o1, LengthPerMassTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthPerMassTimeSqr o1, Area o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator/(Area o1, LengthPerMassTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthPerMassTimeSqr o1, Area o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrPerMass operator*(Area o1, TimeSqrLengthPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrPerMass operator*(TimeSqrLengthPerMass o1, Area o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static Force operator/(Area o1, TimeSqrLengthPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(TimeSqrLengthPerMass o1, Area o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(Area o1, LengthPerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthPerTimeCub o1, Area o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLength operator/(Area o1, LengthPerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(LengthPerTimeCub o1, Area o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCub operator*(Area o1, TimeCubLength o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLength o1, Area o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator/(Area o1, TimeCubLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubLength o1, Area o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(Area o1, Force o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(Force o1, Area o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator/(Area o1, Force o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(Force o1, Area o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(Area o1, TimeSqrLengthMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(TimeSqrLengthMass o1, Area o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator/(Area o1, TimeSqrLengthMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(TimeSqrLengthMass o1, Area o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static MassTime operator/(Area o1, LengthSqrPerMassTime o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthSqrPerMassTime o1, Area o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(Area o1, LengthSqrTimePerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthSqrTimePerMass o1, Area o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(Area o1, QDose o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(QDose o1, Area o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(Area o1, LengthSqrTimeSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthSqrTimeSqr o1, Area o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(Area o1, LengthSqrMassPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthSqrMassPerTime o1, Area o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(Area o1, LengthSqrMassTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthSqrMassTime o1, Area o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(Area o1, LengthCubPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthCubPerMass o1, Area o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(Area o1, LengthCubPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubPerTime o1, Area o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(Area o1, LengthCubTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubTime o1, Area o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator/(Area o1, LengthCubMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthCubMass o1, Area o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(Area o1, PerMassTimeLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(PerMassTimeLengthCub o1, Area o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerLengthMass operator*(Area o1, TimePerMassLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  public static TimePerLengthMass operator*(TimePerMassLengthCub o1, Area o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(Area o1, PerTimeSqrLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerTimeSqrLengthCub o1, Area o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(Area o1, TimeSqrPerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerLengthCub o1, Area o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(Area o1, MassPerTimeLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(MassPerTimeLengthCub o1, Area o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(Area o1, MassTimePerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(MassTimePerLengthCub o1, Area o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeSqr operator*(Area o1, PerMassLengthSqrTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassLengthSqrTimeSqr o1, Area o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(Area o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerMassLengthSqr o1, Area o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(Area o1, PerLengthSqrTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerLengthSqrTimeCub o1, Area o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(Area o1, TimeCubPerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerLengthSqr o1, Area o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(Area o1, MassPerLengthSqrTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerLengthSqrTimeSqr o1, Area o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(Area o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrMassPerLengthSqr o1, Area o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(Area o1, PerLengthMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerLengthMassTimeCub o1, Area o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(Area o1, PerLengthMassTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthMassTimeCub o1, Area o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator*(Area o1, TimeCubPerLengthMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubPerLengthMass o1, Area o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Area o1, TimeCubPerLengthMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerLengthMass o1, Area o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator*(Area o1, MassPerLengthTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(MassPerLengthTimeCub o1, Area o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(Area o1, MassPerLengthTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerLengthTimeCub o1, Area o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(Area o1, TimeCubMassPerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubMassPerLength o1, Area o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(Area o1, TimeCubMassPerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubMassPerLength o1, Area o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(Area o1, LengthPerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(LengthPerMassTimeCub o1, Area o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(Area o1, LengthPerMassTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthPerMassTimeCub o1, Area o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(Area o1, TimeCubLengthPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeCubLengthPerMass o1, Area o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(Area o1, TimeCubLengthPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubLengthPerMass o1, Area o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Area o1, LengthMassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthMassPerTimeCub o1, Area o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator/(Area o1, LengthMassPerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(LengthMassPerTimeCub o1, Area o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(Area o1, TimeCubLengthMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeCubLengthMass o1, Area o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator/(Area o1, TimeCubLengthMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubLengthMass o1, Area o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(Area o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthSqrPerMassTimeSqr o1, Area o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(Area o1, LengthSqrTimeSqrPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthSqrTimeSqrPerMass o1, Area o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(Area o1, LengthSqrPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthSqrPerTimeCub o1, Area o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(Area o1, TimeCubLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLengthSqr o1, Area o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(Area o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthSqrMassPerTimeSqr o1, Area o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(Area o1, LengthSqrTimeSqrMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthSqrTimeSqrMass o1, Area o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(Area o1, LengthCubPerMassTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthCubPerMassTime o1, Area o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(Area o1, LengthCubTimePerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubTimePerMass o1, Area o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(Area o1, LengthCubPerTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubPerTimeSqr o1, Area o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(Area o1, LengthCubTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeSqr o1, Area o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimePerLengthMass operator/(Area o1, LengthCubMassPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTime operator/(LengthCubMassPerTime o1, Area o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator/(Area o1, LengthCubMassTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthCubMassTime o1, Area o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator*(Area o1, PerMassTimeSqrLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeSqr operator*(PerMassTimeSqrLengthCub o1, Area o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthMass operator*(Area o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthMass operator*(TimeSqrPerMassLengthCub o1, Area o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(Area o1, PerLengthCubTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerLengthCubTimeCub o1, Area o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(Area o1, TimeCubPerLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerLengthCub o1, Area o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(Area o1, MassPerTimeSqrLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(MassPerTimeSqrLengthCub o1, Area o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(Area o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrMassPerLengthCub o1, Area o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTimeCub operator*(Area o1, PerMassLengthSqrTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerMassLengthSqrTimeCub o1, Area o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(Area o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerMassLengthSqr o1, Area o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(Area o1, MassPerLengthSqrTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerLengthSqrTimeCub o1, Area o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(Area o1, TimeCubMassPerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubMassPerLengthSqr o1, Area o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator/(Area o1, LengthSqrPerMassTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthSqrPerMassTimeCub o1, Area o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(Area o1, TimeCubLengthSqrPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubLengthSqrPerMass o1, Area o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(Area o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthSqrMassPerTimeCub o1, Area o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(Area o1, TimeCubLengthSqrMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(TimeCubLengthSqrMass o1, Area o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(Area o1, LengthCubPerMassTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthCubPerMassTimeSqr o1, Area o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(Area o1, LengthCubTimeSqrPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubTimeSqrPerMass o1, Area o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLength operator/(Area o1, LengthCubPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubPerTimeCub o1, Area o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(Area o1, LengthCubTimeCub o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubTimeCub o1, Area o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthMass operator/(Area o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  public static Force operator/(LengthCubMassPerTimeSqr o1, Area o2) => new Force(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(Area o1, LengthCubTimeSqrMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthCubTimeSqrMass o1, Area o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator*(Area o1, PerMassLengthCubTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthMassTimeCub operator*(PerMassLengthCubTimeCub o1, Area o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthMass operator*(Area o1, TimeCubPerMassLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthMass operator*(TimeCubPerMassLengthCub o1, Area o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(Area o1, MassPerLengthCubTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(MassPerLengthCubTimeCub o1, Area o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(Area o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubMassPerLengthCub o1, Area o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator/(Area o1, LengthCubPerMassTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthCubPerMassTimeCub o1, Area o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator/(Area o1, LengthCubTimeCubPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthCubTimeCubPerMass o1, Area o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerLengthMass operator/(Area o1, LengthCubMassPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthCubMassPerTimeCub o1, Area o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTimeCub operator/(Area o1, LengthCubTimeCubMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthMass operator/(LengthCubTimeCubMass o1, Area o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Area is outside its bounds.");
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
    