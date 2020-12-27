
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerLengthTime : Quantity, IEquatable<MassPerLengthTime>, IComparable
    {
    internal MassPerLengthTime(double value) : base(value, 2)
    {
        MassPerLengthTime.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerLengthTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerLengthTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerLengthTime(MassPerLengthTime other) : base(other)
    {
        MassPerLengthTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthTime"))
        {
            switch(FakeDatabase.Units["MassPerLengthTime"])
            {
				      case "kilogrampercentimetersecond": displayUnit_ = kilogrampercentimetersecond_; break;
				      case "kilogrampermillimetersecond": displayUnit_ = kilogrampermillimetersecond_; break;
				      case "kilogrampermetersecond": displayUnit_ = kilogrampermetersecond_; break;
				      case "kilogramperinchsecond": displayUnit_ = kilogramperinchsecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampercentimetersecond_ = new Unit_("KilogramPerCentimeterSecond", "kg/cm s", 1.0);
	private static Unit_ kilogrampermillimetersecond_ = new Unit_("KilogramPerMillimeterSecond", "kg/mm s", 10.0);
	private static Unit_ kilogrampermetersecond_ = new Unit_("KilogramPerMeterSecond", "kg/m s", 0.01);
	private static Unit_ kilogramperinchsecond_ = new Unit_("KilogramPerInchSecond", "kg/in s", 0.390625);
	private static Unit_ platformUnit_ = kilogrampercentimetersecond_;
	private static Unit_ displayUnit_ = kilogrampercentimetersecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerLengthTime other) => other is object && Equals((object)other);
    public int CompareTo(MassPerLengthTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerLengthTime other)) throw new ArgumentException("Object is not a MassPerLengthTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerLengthTime l1, MassPerLengthTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerLengthTime l1, MassPerLengthTime l2) => !(l1 == l2);
    public static bool operator <(MassPerLengthTime l1, MassPerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerLengthTime l1, MassPerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerLengthTime l1, MassPerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerLengthTime l1, MassPerLengthTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerLengthTime FromKilogramPerCentimeterSeconds(double value, double minValue, double maxValue) => new MassPerLengthTime(value * kilogrampercentimetersecond_.Factor, minValue * kilogrampercentimetersecond_.Factor, maxValue * kilogrampercentimetersecond_.Factor);
		public static MassPerLengthTime FromKilogramPerCentimeterSeconds(double value) => new MassPerLengthTime(value * kilogrampercentimetersecond_.Factor);
		public double GetValueInKilogramPerCentimeterSeconds() => Value_ / kilogrampercentimetersecond_.Factor;
		public static MassPerLengthTime FromKilogramPerMillimeterSeconds(double value, double minValue, double maxValue) => new MassPerLengthTime(value * kilogrampermillimetersecond_.Factor, minValue * kilogrampermillimetersecond_.Factor, maxValue * kilogrampermillimetersecond_.Factor);
		public static MassPerLengthTime FromKilogramPerMillimeterSeconds(double value) => new MassPerLengthTime(value * kilogrampermillimetersecond_.Factor);
		public double GetValueInKilogramPerMillimeterSeconds() => Value_ / kilogrampermillimetersecond_.Factor;
		public static MassPerLengthTime FromKilogramPerMeterSeconds(double value, double minValue, double maxValue) => new MassPerLengthTime(value * kilogrampermetersecond_.Factor, minValue * kilogrampermetersecond_.Factor, maxValue * kilogrampermetersecond_.Factor);
		public static MassPerLengthTime FromKilogramPerMeterSeconds(double value) => new MassPerLengthTime(value * kilogrampermetersecond_.Factor);
		public double GetValueInKilogramPerMeterSeconds() => Value_ / kilogrampermetersecond_.Factor;
		public static MassPerLengthTime FromKilogramPerInchSeconds(double value, double minValue, double maxValue) => new MassPerLengthTime(value * kilogramperinchsecond_.Factor, minValue * kilogramperinchsecond_.Factor, maxValue * kilogramperinchsecond_.Factor);
		public static MassPerLengthTime FromKilogramPerInchSeconds(double value) => new MassPerLengthTime(value * kilogramperinchsecond_.Factor);
		public double GetValueInKilogramPerInchSeconds() => Value_ / kilogramperinchsecond_.Factor;

#endregion

#region arithmetic
		public static MassPerLengthTime operator+(MassPerLengthTime o1, MassPerLengthTime o2) => new MassPerLengthTime(o1.Value_ + o2.Value_);
		public static MassPerLengthTime operator-(MassPerLengthTime o1, MassPerLengthTime o2) => new MassPerLengthTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerLengthTime o1, MassPerLengthTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(MassPerLengthTime o1, MassTimePerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(MassTimePerLength o1, MassPerLengthTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(MassPerLengthTime o1, PerMassTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(PerMassTimeSqr o1, MassPerLengthTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(MassPerLengthTime o1, TimeSqrPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrPerMass o1, MassPerLengthTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator/(MassPerLengthTime o1, PerTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerTimeCub o1, MassPerLengthTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(MassPerLengthTime o1, TimeCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCub o1, MassPerLengthTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(MassPerLengthTime o1, MassPerTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(MassPerTimeSqr o1, MassPerLengthTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(MassPerLengthTime o1, TimeSqrMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrMass o1, MassPerLengthTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(MassPerLengthTime o1, LengthPerMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthPerMassTime o1, MassPerLengthTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(MassPerLengthTime o1, LengthTimePerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthTimePerMass o1, MassPerLengthTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(MassPerLengthTime o1, Acceleration o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(Acceleration o1, MassPerLengthTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerLengthTime o1, Acceleration o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(Acceleration o1, MassPerLengthTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(MassPerLengthTime o1, TimeSqrLength o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(TimeSqrLength o1, MassPerLengthTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerLengthTime o1, TimeSqrLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeSqrLength o1, MassPerLengthTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(MassPerLengthTime o1, LengthMassPerTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthMassPerTime o1, MassPerLengthTime o2) => new Area(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(MassPerLengthTime o1, LengthMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(LengthMassTime o1, MassPerLengthTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Speed operator*(MassPerLengthTime o1, LengthSqrPerMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrPerMass o1, MassPerLengthTime o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static Force operator*(MassPerLengthTime o1, LengthSqrPerTime o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthSqrPerTime o1, MassPerLengthTime o2) => new Force(o1.Value_ * o2.Value_);
		public static Density operator/(MassPerLengthTime o1, LengthSqrPerTime o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrPerTime o1, MassPerLengthTime o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(MassPerLengthTime o1, LengthSqrTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthSqrTime o1, MassPerLengthTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(MassPerLengthTime o1, LengthSqrTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthSqrTime o1, MassPerLengthTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator/(MassPerLengthTime o1, LengthSqrMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrMass o1, MassPerLengthTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassPerLengthTime o1, Volume o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(Volume o1, MassPerLengthTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(MassPerLengthTime o1, PerTimeLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerTimeLengthCub o1, MassPerLengthTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(MassPerLengthTime o1, TimePerLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimePerLengthCub o1, MassPerLengthTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(MassPerLengthTime o1, Density o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(Density o1, MassPerLengthTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(MassPerLengthTime o1, PerMassTimeLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerMassTimeLengthSqr o1, MassPerLengthTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator*(MassPerLengthTime o1, TimePerMassLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimePerMassLengthSqr o1, MassPerLengthTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(MassPerLengthTime o1, PerLengthSqrTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(PerLengthSqrTimeSqr o1, MassPerLengthTime o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassTime operator/(MassPerLengthTime o1, PerLengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerLengthSqrTimeSqr o1, MassPerLengthTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(MassPerLengthTime o1, TimeSqrPerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimeSqrPerLengthSqr o1, MassPerLengthTime o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator/(MassPerLengthTime o1, TimeSqrPerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeSqrPerLengthSqr o1, MassPerLengthTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(MassPerLengthTime o1, MassPerTimeLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassPerTimeLengthSqr o1, MassPerLengthTime o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(MassPerLengthTime o1, MassTimePerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(MassTimePerLengthSqr o1, MassPerLengthTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(MassPerLengthTime o1, PerLengthMassTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerLengthMassTimeSqr o1, MassPerLengthTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator*(MassPerLengthTime o1, TimeSqrPerLengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeSqrPerLengthMass o1, MassPerLengthTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator/(MassPerLengthTime o1, PerLengthTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerLengthTimeCub o1, MassPerLengthTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(MassPerLengthTime o1, TimeCubPerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeCubPerLength o1, MassPerLengthTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static Time operator/(MassPerLengthTime o1, MassPerLengthTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(MassPerLengthTimeSqr o1, MassPerLengthTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(MassPerLengthTime o1, TimeSqrMassPerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrMassPerLength o1, MassPerLengthTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(MassPerLengthTime o1, TimeCubPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubPerMass o1, MassPerLengthTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator/(MassPerLengthTime o1, MassPerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(MassPerTimeCub o1, MassPerLengthTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(MassPerLengthTime o1, LengthPerMassTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthPerMassTimeSqr o1, MassPerLengthTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(MassPerLengthTime o1, TimeSqrLengthPerMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrLengthPerMass o1, MassPerLengthTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator/(MassPerLengthTime o1, LengthPerTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthPerTimeCub o1, MassPerLengthTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator*(MassPerLengthTime o1, TimeCubLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeCubLength o1, MassPerLengthTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(MassPerLengthTime o1, Force o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(Force o1, MassPerLengthTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(MassPerLengthTime o1, TimeSqrLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeSqrLengthMass o1, MassPerLengthTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(MassPerLengthTime o1, LengthSqrPerMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthSqrPerMassTime o1, MassPerLengthTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Length operator*(MassPerLengthTime o1, LengthSqrTimePerMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrTimePerMass o1, MassPerLengthTime o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(MassPerLengthTime o1, QDose o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(QDose o1, MassPerLengthTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(MassPerLengthTime o1, QDose o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(QDose o1, MassPerLengthTime o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(MassPerLengthTime o1, LengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthSqrTimeSqr o1, MassPerLengthTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(MassPerLengthTime o1, LengthSqrTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(LengthSqrTimeSqr o1, MassPerLengthTime o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(MassPerLengthTime o1, LengthSqrMassPerTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrMassPerTime o1, MassPerLengthTime o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(MassPerLengthTime o1, LengthSqrMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthSqrMassTime o1, MassPerLengthTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(MassPerLengthTime o1, LengthCubPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubPerMass o1, MassPerLengthTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(MassPerLengthTime o1, LengthCubPerTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubPerTime o1, MassPerLengthTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(MassPerLengthTime o1, LengthCubTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubTime o1, MassPerLengthTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(MassPerLengthTime o1, PerTimeSqrLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerTimeSqrLengthCub o1, MassPerLengthTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator/(MassPerLengthTime o1, TimeSqrPerLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimeSqrPerLengthCub o1, MassPerLengthTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(MassPerLengthTime o1, MassPerTimeLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(MassPerTimeLengthCub o1, MassPerLengthTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator/(MassPerLengthTime o1, MassTimePerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(MassTimePerLengthCub o1, MassPerLengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(MassPerLengthTime o1, PerMassLengthSqrTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerMassLengthSqrTimeSqr o1, MassPerLengthTime o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator*(MassPerLengthTime o1, TimeSqrPerMassLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeSqrPerMassLengthSqr o1, MassPerLengthTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthMass operator/(MassPerLengthTime o1, PerLengthSqrTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerLengthSqrTimeCub o1, MassPerLengthTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(MassPerLengthTime o1, TimeCubPerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeCubPerLengthSqr o1, MassPerLengthTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(MassPerLengthTime o1, MassPerLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(MassPerLengthSqrTimeSqr o1, MassPerLengthTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(MassPerLengthTime o1, TimeSqrMassPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeSqrMassPerLengthSqr o1, MassPerLengthTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(MassPerLengthTime o1, TimeCubPerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubPerLengthMass o1, MassPerLengthTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(MassPerLengthTime o1, MassPerLengthTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(MassPerLengthTimeCub o1, MassPerLengthTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(MassPerLengthTime o1, TimeCubLengthPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubLengthPerMass o1, MassPerLengthTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(MassPerLengthTime o1, LengthMassPerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthMassPerTimeCub o1, MassPerLengthTime o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(MassPerLengthTime o1, LengthSqrPerMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthSqrPerMassTimeSqr o1, MassPerLengthTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(MassPerLengthTime o1, LengthSqrTimeSqrPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator/(MassPerLengthTime o1, LengthSqrPerTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthSqrPerTimeCub o1, MassPerLengthTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(MassPerLengthTime o1, TimeCubLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(TimeCubLengthSqr o1, MassPerLengthTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(MassPerLengthTime o1, LengthSqrMassPerTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrMassPerTimeSqr o1, MassPerLengthTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(MassPerLengthTime o1, LengthSqrTimeSqrMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthSqrTimeSqrMass o1, MassPerLengthTime o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassPerLengthTime o1, LengthCubPerMassTime o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubPerMassTime o1, MassPerLengthTime o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static Area operator*(MassPerLengthTime o1, LengthCubTimePerMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimePerMass o1, MassPerLengthTime o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(MassPerLengthTime o1, LengthCubPerTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthCubPerTimeSqr o1, MassPerLengthTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator*(MassPerLengthTime o1, LengthCubTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthCubTimeSqr o1, MassPerLengthTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator/(MassPerLengthTime o1, PerLengthCubTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerLengthCubTimeCub o1, MassPerLengthTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(MassPerLengthTime o1, MassPerTimeSqrLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassPerTimeSqrLengthCub o1, MassPerLengthTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(MassPerLengthTime o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeSqrMassPerLengthCub o1, MassPerLengthTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(MassPerLengthTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeCubPerMassLengthSqr o1, MassPerLengthTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(MassPerLengthTime o1, MassPerLengthSqrTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(MassPerLengthSqrTimeCub o1, MassPerLengthTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(MassPerLengthTime o1, TimeCubLengthSqrPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubLengthSqrPerMass o1, MassPerLengthTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(MassPerLengthTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthSqrMassPerTimeCub o1, MassPerLengthTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(MassPerLengthTime o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthCubPerMassTimeSqr o1, MassPerLengthTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(MassPerLengthTime o1, LengthCubTimeSqrPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubTimeSqrPerMass o1, MassPerLengthTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(MassPerLengthTime o1, LengthCubTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthCubTimeCub o1, MassPerLengthTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator/(MassPerLengthTime o1, MassPerLengthCubTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(MassPerLengthCubTimeCub o1, MassPerLengthTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(MassPerLengthTime o1, LengthCubTimeCubPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubTimeCubPerMass o1, MassPerLengthTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerLengthTime massperlengthtime, bool throwOnFail=true)
    {
        bool fail = false;
        if (massperlengthtime.HasMinValue && massperlengthtime.Value_ < massperlengthtime.MinValue)
        {
            fail = true;
        }

        if (massperlengthtime.HasMaxValue && massperlengthtime.Value_ > massperlengthtime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerLengthTime is outside its bounds.");
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
    