
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerLength : Quantity, IEquatable<MassPerLength>, IComparable
    {
    internal MassPerLength(double value) : base(value, 2)
    {
        MassPerLength.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerLength(MassPerLength other) : base(other)
    {
        MassPerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLength"))
        {
            switch(FakeDatabase.Units["MassPerLength"])
            {
				      case "kilogrampercentimeter": displayUnit_ = kilogrampercentimeter_; break;
				      case "kilogrampermillimeter": displayUnit_ = kilogrampermillimeter_; break;
				      case "kilogrampermeter": displayUnit_ = kilogrampermeter_; break;
				      case "kilogramperinch": displayUnit_ = kilogramperinch_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampercentimeter_ = new Unit_("KilogramPerCentimeter", "kg/cm", 1.0);
	private static Unit_ kilogrampermillimeter_ = new Unit_("KilogramPerMillimeter", "kg/mm", 10.0);
	private static Unit_ kilogrampermeter_ = new Unit_("KilogramPerMeter", "kg/m", 0.01);
	private static Unit_ kilogramperinch_ = new Unit_("KilogramPerInch", "kg/in", 0.390625);
	private static Unit_ platformUnit_ = kilogrampercentimeter_;
	private static Unit_ displayUnit_ = kilogrampercentimeter_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerLength other) => other is object && Equals((object)other);
    public int CompareTo(MassPerLength other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerLength other)) throw new ArgumentException("Object is not a MassPerLength.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerLength l1, MassPerLength l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerLength l1, MassPerLength l2) => !(l1 == l2);
    public static bool operator <(MassPerLength l1, MassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerLength l1, MassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerLength l1, MassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerLength l1, MassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerLength FromKilogramPerCentimeters(double value, double minValue, double maxValue) => new MassPerLength(value * kilogrampercentimeter_.Factor, minValue * kilogrampercentimeter_.Factor, maxValue * kilogrampercentimeter_.Factor);
		public static MassPerLength FromKilogramPerCentimeters(double value) => new MassPerLength(value * kilogrampercentimeter_.Factor);
		public double GetValueInKilogramPerCentimeters() => Value_ / kilogrampercentimeter_.Factor;
		public static MassPerLength FromKilogramPerMillimeters(double value, double minValue, double maxValue) => new MassPerLength(value * kilogrampermillimeter_.Factor, minValue * kilogrampermillimeter_.Factor, maxValue * kilogrampermillimeter_.Factor);
		public static MassPerLength FromKilogramPerMillimeters(double value) => new MassPerLength(value * kilogrampermillimeter_.Factor);
		public double GetValueInKilogramPerMillimeters() => Value_ / kilogrampermillimeter_.Factor;
		public static MassPerLength FromKilogramPerMeters(double value, double minValue, double maxValue) => new MassPerLength(value * kilogrampermeter_.Factor, minValue * kilogrampermeter_.Factor, maxValue * kilogrampermeter_.Factor);
		public static MassPerLength FromKilogramPerMeters(double value) => new MassPerLength(value * kilogrampermeter_.Factor);
		public double GetValueInKilogramPerMeters() => Value_ / kilogrampermeter_.Factor;
		public static MassPerLength FromKilogramPerInchs(double value, double minValue, double maxValue) => new MassPerLength(value * kilogramperinch_.Factor, minValue * kilogramperinch_.Factor, maxValue * kilogramperinch_.Factor);
		public static MassPerLength FromKilogramPerInchs(double value) => new MassPerLength(value * kilogramperinch_.Factor);
		public double GetValueInKilogramPerInchs() => Value_ / kilogramperinch_.Factor;

#endregion

#region arithmetic
		public static MassPerLength operator+(MassPerLength o1, MassPerLength o2) => new MassPerLength(o1.Value_ + o2.Value_);
		public static MassPerLength operator-(MassPerLength o1, MassPerLength o2) => new MassPerLength(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerLength o1, MassPerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(MassPerLength o1, PerMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerMassTime o1, MassPerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(MassPerLength o1, TimePerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimePerMass o1, MassPerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(MassPerLength o1, PerTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(PerTimeSqr o1, MassPerLength o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(MassPerLength o1, PerTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerTimeSqr o1, MassPerLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(MassPerLength o1, TimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeSqr o1, MassPerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(MassPerLength o1, TimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeSqr o1, MassPerLength o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(MassPerLength o1, MassPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(MassPerTime o1, MassPerLength o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(MassPerLength o1, MassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(MassTime o1, MassPerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(MassPerLength o1, LengthPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthPerMass o1, MassPerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(MassPerLength o1, Speed o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(Speed o1, MassPerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerLength o1, Speed o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(Speed o1, MassPerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(MassPerLength o1, LengthTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthTime o1, MassPerLength o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerLength o1, LengthTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthTime o1, MassPerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(MassPerLength o1, LengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthMass o1, MassPerLength o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(MassPerLength o1, Area o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(Area o1, MassPerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static Density operator/(MassPerLength o1, Area o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(Area o1, MassPerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator/(MassPerLength o1, PerLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerLengthCub o1, MassPerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(MassPerLength o1, PerMassLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerMassLengthSqr o1, MassPerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator*(MassPerLength o1, PerTimeLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(PerTimeLengthSqr o1, MassPerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassTime operator/(MassPerLength o1, PerTimeLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerTimeLengthSqr o1, MassPerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(MassPerLength o1, TimePerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimePerLengthSqr o1, MassPerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(MassPerLength o1, TimePerLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimePerLengthSqr o1, MassPerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(MassPerLength o1, MassPerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassPerLengthSqr o1, MassPerLength o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(MassPerLength o1, PerLengthMassTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthMassTime o1, MassPerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator*(MassPerLength o1, TimePerLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimePerLengthMass o1, MassPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(MassPerLength o1, PerLengthTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(PerLengthTimeSqr o1, MassPerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator/(MassPerLength o1, PerLengthTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerLengthTimeSqr o1, MassPerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(MassPerLength o1, TimeSqrPerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeSqrPerLength o1, MassPerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator/(MassPerLength o1, TimeSqrPerLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeSqrPerLength o1, MassPerLength o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(MassPerLength o1, MassPerLengthTime o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(MassPerLengthTime o1, MassPerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(MassPerLength o1, MassTimePerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(MassTimePerLength o1, MassPerLength o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(MassPerLength o1, PerMassTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerMassTimeSqr o1, MassPerLength o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(MassPerLength o1, TimeSqrPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeSqrPerMass o1, MassPerLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(MassPerLength o1, PerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(PerTimeCub o1, MassPerLength o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(MassPerLength o1, PerTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(PerTimeCub o1, MassPerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(MassPerLength o1, TimeCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeCub o1, MassPerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(MassPerLength o1, TimeCub o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeCub o1, MassPerLength o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(MassPerLength o1, MassPerTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(MassPerTimeSqr o1, MassPerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(MassPerLength o1, TimeSqrMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeSqrMass o1, MassPerLength o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(MassPerLength o1, LengthPerMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthPerMassTime o1, MassPerLength o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(MassPerLength o1, LengthTimePerMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthTimePerMass o1, MassPerLength o2) => new Time(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(MassPerLength o1, Acceleration o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(Acceleration o1, MassPerLength o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(MassPerLength o1, Acceleration o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(Acceleration o1, MassPerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator*(MassPerLength o1, TimeSqrLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeSqrLength o1, MassPerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(MassPerLength o1, TimeSqrLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeSqrLength o1, MassPerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator/(MassPerLength o1, LengthMassPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthMassPerTime o1, MassPerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator/(MassPerLength o1, LengthMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthMassTime o1, MassPerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(MassPerLength o1, LengthSqrPerMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrPerMass o1, MassPerLength o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(MassPerLength o1, LengthSqrPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthSqrPerTime o1, MassPerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(MassPerLength o1, LengthSqrPerTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthSqrPerTime o1, MassPerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(MassPerLength o1, LengthSqrTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthSqrTime o1, MassPerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(MassPerLength o1, LengthSqrTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthSqrTime o1, MassPerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(MassPerLength o1, LengthSqrMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrMass o1, MassPerLength o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(MassPerLength o1, Volume o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(Volume o1, MassPerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(MassPerLength o1, PerTimeLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerTimeLengthCub o1, MassPerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator/(MassPerLength o1, TimePerLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimePerLengthCub o1, MassPerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(MassPerLength o1, Density o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(Density o1, MassPerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(MassPerLength o1, PerMassTimeLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerMassTimeLengthSqr o1, MassPerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator*(MassPerLength o1, TimePerMassLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimePerMassLengthSqr o1, MassPerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(MassPerLength o1, PerLengthSqrTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(PerLengthSqrTimeSqr o1, MassPerLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator/(MassPerLength o1, PerLengthSqrTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerLengthSqrTimeSqr o1, MassPerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(MassPerLength o1, TimeSqrPerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeSqrPerLengthSqr o1, MassPerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static Force operator/(MassPerLength o1, TimeSqrPerLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeSqrPerLengthSqr o1, MassPerLength o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator/(MassPerLength o1, MassPerTimeLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(MassPerTimeLengthSqr o1, MassPerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static Speed operator/(MassPerLength o1, MassTimePerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(MassTimePerLengthSqr o1, MassPerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(MassPerLength o1, PerLengthMassTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerLengthMassTimeSqr o1, MassPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(MassPerLength o1, TimeSqrPerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeSqrPerLengthMass o1, MassPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(MassPerLength o1, PerLengthTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(PerLengthTimeCub o1, MassPerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMass operator/(MassPerLength o1, PerLengthTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(PerLengthTimeCub o1, MassPerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(MassPerLength o1, TimeCubPerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeCubPerLength o1, MassPerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator/(MassPerLength o1, TimeCubPerLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeCubPerLength o1, MassPerLength o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(MassPerLength o1, MassPerLengthTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(MassPerLengthTimeSqr o1, MassPerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(MassPerLength o1, TimeSqrMassPerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeSqrMassPerLength o1, MassPerLength o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(MassPerLength o1, PerMassTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(PerMassTimeCub o1, MassPerLength o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(MassPerLength o1, TimeCubPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeCubPerMass o1, MassPerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator/(MassPerLength o1, MassPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(MassPerTimeCub o1, MassPerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(MassPerLength o1, TimeCubMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeCubMass o1, MassPerLength o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(MassPerLength o1, LengthPerMassTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthPerMassTimeSqr o1, MassPerLength o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(MassPerLength o1, TimeSqrLengthPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeSqrLengthPerMass o1, MassPerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(MassPerLength o1, LengthPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthPerTimeCub o1, MassPerLength o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(MassPerLength o1, LengthPerTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(LengthPerTimeCub o1, MassPerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator*(MassPerLength o1, TimeCubLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeCubLength o1, MassPerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerLength o1, TimeCubLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeCubLength o1, MassPerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(MassPerLength o1, Force o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(Force o1, MassPerLength o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(MassPerLength o1, TimeSqrLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeSqrLengthMass o1, MassPerLength o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Speed operator*(MassPerLength o1, LengthSqrPerMassTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrPerMassTime o1, MassPerLength o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(MassPerLength o1, LengthSqrTimePerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrTimePerMass o1, MassPerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static Force operator*(MassPerLength o1, QDose o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(QDose o1, MassPerLength o2) => new Force(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(MassPerLength o1, QDose o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(QDose o1, MassPerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(MassPerLength o1, LengthSqrTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthSqrTimeSqr o1, MassPerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(MassPerLength o1, LengthSqrTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthSqrTimeSqr o1, MassPerLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator/(MassPerLength o1, LengthSqrMassPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrMassPerTime o1, MassPerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator/(MassPerLength o1, LengthSqrMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrMassTime o1, MassPerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(MassPerLength o1, LengthCubPerMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubPerMass o1, MassPerLength o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassPerLength o1, LengthCubPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubPerTime o1, MassPerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator*(MassPerLength o1, LengthCubTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthCubTime o1, MassPerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator/(MassPerLength o1, PerTimeSqrLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerTimeSqrLengthCub o1, MassPerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(MassPerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerLengthCub o1, MassPerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(MassPerLength o1, MassPerTimeLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassPerTimeLengthCub o1, MassPerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(MassPerLength o1, MassTimePerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(MassTimePerLengthCub o1, MassPerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(MassPerLength o1, PerMassLengthSqrTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerMassLengthSqrTimeSqr o1, MassPerLength o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(MassPerLength o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeSqrPerMassLengthSqr o1, MassPerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(MassPerLength o1, PerLengthSqrTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(PerLengthSqrTimeCub o1, MassPerLength o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(MassPerLength o1, PerLengthSqrTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthSqrTimeCub o1, MassPerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(MassPerLength o1, TimeCubPerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeCubPerLengthSqr o1, MassPerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator/(MassPerLength o1, TimeCubPerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeCubPerLengthSqr o1, MassPerLength o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(MassPerLength o1, MassPerLengthSqrTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(MassPerLengthSqrTimeSqr o1, MassPerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(MassPerLength o1, TimeSqrMassPerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeSqrMassPerLengthSqr o1, MassPerLength o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(MassPerLength o1, PerLengthMassTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerLengthMassTimeCub o1, MassPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(MassPerLength o1, TimeCubPerLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeCubPerLengthMass o1, MassPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(MassPerLength o1, MassPerLengthTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(MassPerLengthTimeCub o1, MassPerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(MassPerLength o1, TimeCubMassPerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeCubMassPerLength o1, MassPerLength o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(MassPerLength o1, LengthPerMassTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthPerMassTimeCub o1, MassPerLength o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(MassPerLength o1, TimeCubLengthPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeCubLengthPerMass o1, MassPerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(MassPerLength o1, LengthMassPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthMassPerTimeCub o1, MassPerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(MassPerLength o1, TimeCubLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeCubLengthMass o1, MassPerLength o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(MassPerLength o1, LengthSqrPerMassTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthSqrPerMassTimeSqr o1, MassPerLength o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(MassPerLength o1, LengthSqrTimeSqrPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthSqrTimeSqrPerMass o1, MassPerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(MassPerLength o1, LengthSqrPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthSqrPerTimeCub o1, MassPerLength o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(MassPerLength o1, LengthSqrPerTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthSqrPerTimeCub o1, MassPerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(MassPerLength o1, TimeCubLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(TimeCubLengthSqr o1, MassPerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(MassPerLength o1, TimeCubLengthSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeCubLengthSqr o1, MassPerLength o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(MassPerLength o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthSqrMassPerTimeSqr o1, MassPerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(MassPerLength o1, LengthSqrTimeSqrMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthSqrTimeSqrMass o1, MassPerLength o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(MassPerLength o1, LengthCubPerMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubPerMassTime o1, MassPerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(MassPerLength o1, LengthCubTimePerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubTimePerMass o1, MassPerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(MassPerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubPerTimeSqr o1, MassPerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(MassPerLength o1, LengthCubTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthCubTimeSqr o1, MassPerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator/(MassPerLength o1, PerLengthCubTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerLengthCubTimeCub o1, MassPerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator/(MassPerLength o1, TimeCubPerLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimeCubPerLengthCub o1, MassPerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator/(MassPerLength o1, MassPerTimeSqrLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(MassPerTimeSqrLengthCub o1, MassPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator/(MassPerLength o1, TimeSqrMassPerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeSqrMassPerLengthCub o1, MassPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(MassPerLength o1, PerMassLengthSqrTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerMassLengthSqrTimeCub o1, MassPerLength o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(MassPerLength o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeCubPerMassLengthSqr o1, MassPerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator/(MassPerLength o1, MassPerLengthSqrTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(MassPerLengthSqrTimeCub o1, MassPerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(MassPerLength o1, TimeCubMassPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeCubMassPerLengthSqr o1, MassPerLength o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(MassPerLength o1, LengthSqrPerMassTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthSqrPerMassTimeCub o1, MassPerLength o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(MassPerLength o1, TimeCubLengthSqrPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeCubLengthSqrPerMass o1, MassPerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator/(MassPerLength o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthSqrMassPerTimeCub o1, MassPerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(MassPerLength o1, TimeCubLengthSqrMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeCubLengthSqrMass o1, MassPerLength o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassPerLength o1, LengthCubPerMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubPerMassTimeSqr o1, MassPerLength o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(MassPerLength o1, LengthCubTimeSqrPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubTimeSqrPerMass o1, MassPerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(MassPerLength o1, LengthCubPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthCubPerTimeCub o1, MassPerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(MassPerLength o1, LengthCubTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthCubTimeCub o1, MassPerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator/(MassPerLength o1, MassPerLengthCubTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(MassPerLengthCubTimeCub o1, MassPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(MassPerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeCubMassPerLengthCub o1, MassPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(MassPerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthCubPerMassTimeCub o1, MassPerLength o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(MassPerLength o1, LengthCubTimeCubPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthCubTimeCubPerMass o1, MassPerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerLength massperlength, bool throwOnFail=true)
    {
        bool fail = false;
        if (massperlength.HasMinValue && massperlength.Value_ < massperlength.MinValue)
        {
            fail = true;
        }

        if (massperlength.HasMaxValue && massperlength.Value_ > massperlength.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerLength is outside its bounds.");
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
    