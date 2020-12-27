
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassTime : Quantity, IEquatable<PerMassTime>, IComparable
    {
    internal PerMassTime(double value) : base(value, 2)
    {
        PerMassTime.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassTime(PerMassTime other) : base(other)
    {
        PerMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTime"))
        {
            switch(FakeDatabase.Units["PerMassTime"])
            {
				      case "perkilogramcubsecond": displayUnit_ = perkilogramcubsecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubsecond_ = new Unit_("PerKilogramCubSecond", "/kg³ s", 1.0);
	private static Unit_ platformUnit_ = perkilogramcubsecond_;
	private static Unit_ displayUnit_ = perkilogramcubsecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassTime other) => other is object && Equals((object)other);
    public int CompareTo(PerMassTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassTime other)) throw new ArgumentException("Object is not a PerMassTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassTime l1, PerMassTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassTime l1, PerMassTime l2) => !(l1 == l2);
    public static bool operator <(PerMassTime l1, PerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassTime l1, PerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassTime l1, PerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassTime l1, PerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassTime FromPerKilogramCubSeconds(double value, double minValue, double maxValue) => new PerMassTime(value * perkilogramcubsecond_.Factor, minValue * perkilogramcubsecond_.Factor, maxValue * perkilogramcubsecond_.Factor);
		public static PerMassTime FromPerKilogramCubSeconds(double value) => new PerMassTime(value * perkilogramcubsecond_.Factor);
		public double GetValueInPerKilogramCubSeconds() => Value_ / perkilogramcubsecond_.Factor;

#endregion

#region arithmetic
		public static PerMassTime operator+(PerMassTime o1, PerMassTime o2) => new PerMassTime(o1.Value_ + o2.Value_);
		public static PerMassTime operator-(PerMassTime o1, PerMassTime o2) => new PerMassTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassTime o1, PerMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerMassTime o1, TimePerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimePerMass o1, PerMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator*(PerMassTime o1, PerTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(PerTimeSqr o1, PerMassTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimePerMass operator/(PerMassTime o1, PerTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerTimeSqr o1, PerMassTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerMassTime o1, TimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeSqr o1, PerMassTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator/(PerMassTime o1, TimeSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeSqr o1, PerMassTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(PerMassTime o1, MassPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(MassPerTime o1, PerMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerMassTime o1, MassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(MassTime o1, PerMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(PerMassTime o1, LengthPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthPerMass o1, PerMassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerMassTime o1, Speed o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(Speed o1, PerMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMass operator/(PerMassTime o1, Speed o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(Speed o1, PerMassTime o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerMassTime o1, LengthTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthTime o1, PerMassTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerMassTime o1, LengthTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(LengthTime o1, PerMassTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerMassTime o1, LengthMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthMass o1, PerMassTime o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerMassTime o1, Area o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(Area o1, PerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerMassTime o1, Area o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(Area o1, PerMassTime o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerMassTime o1, PerLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerLengthCub o1, PerMassTime o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator/(PerMassTime o1, PerLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(PerLengthCub o1, PerMassTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(PerMassTime o1, PerMassLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerMassLengthSqr o1, PerMassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(PerMassTime o1, PerTimeLengthSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerTimeLengthSqr o1, PerMassTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator/(PerMassTime o1, PerTimeLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(PerTimeLengthSqr o1, PerMassTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerMassTime o1, TimePerLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(TimePerLengthSqr o1, PerMassTime o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(PerMassTime o1, TimePerLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(TimePerLengthSqr o1, PerMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(PerMassTime o1, MassPerLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(MassPerLengthSqr o1, PerMassTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerMassTime o1, PerLengthMassTime o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthMassTime o1, PerMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(PerMassTime o1, TimePerLengthMass o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimePerLengthMass o1, PerMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerMassTime o1, PerLengthTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(PerLengthTimeSqr o1, PerMassTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator/(PerMassTime o1, PerLengthTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(PerLengthTimeSqr o1, PerMassTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerMassTime o1, TimeSqrPerLength o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeSqrPerLength o1, PerMassTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator/(PerMassTime o1, TimeSqrPerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeSqrPerLength o1, PerMassTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(PerMassTime o1, MassPerLengthTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(MassPerLengthTime o1, PerMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(PerMassTime o1, MassTimePerLength o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(MassTimePerLength o1, PerMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerMassTime o1, PerMassTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerMassTimeSqr o1, PerMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerMassTime o1, TimeSqrPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrPerMass o1, PerMassTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerMassTime o1, PerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(PerTimeCub o1, PerMassTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator*(PerMassTime o1, TimeCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeCub o1, PerMassTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(PerMassTime o1, MassPerTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(MassPerTimeSqr o1, PerMassTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerMassTime o1, TimeSqrMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrMass o1, PerMassTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(PerMassTime o1, LengthPerMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthPerMassTime o1, PerMassTime o2) => new Length(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(PerMassTime o1, LengthTimePerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(LengthTimePerMass o1, PerMassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerMassTime o1, Acceleration o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(Acceleration o1, PerMassTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(PerMassTime o1, Acceleration o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(Acceleration o1, PerMassTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(PerMassTime o1, TimeSqrLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeSqrLength o1, PerMassTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator/(PerMassTime o1, TimeSqrLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeSqrLength o1, PerMassTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(PerMassTime o1, LengthMassPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthMassPerTime o1, PerMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerMassTime o1, LengthMassTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthMassTime o1, PerMassTime o2) => new Length(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(PerMassTime o1, LengthSqrPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthSqrPerMass o1, PerMassTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerMassTime o1, LengthSqrPerTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthSqrPerTime o1, PerMassTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator/(PerMassTime o1, LengthSqrPerTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrPerTime o1, PerMassTime o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(PerMassTime o1, LengthSqrTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthSqrTime o1, PerMassTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerMassTime o1, LengthSqrTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(LengthSqrTime o1, PerMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(PerMassTime o1, LengthSqrMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrMass o1, PerMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTime operator*(PerMassTime o1, Volume o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(Volume o1, PerMassTime o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(PerMassTime o1, Volume o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(Volume o1, PerMassTime o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator/(PerMassTime o1, PerMassLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(PerMassLengthCub o1, PerMassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerMassTime o1, PerTimeLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerTimeLengthCub o1, PerMassTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator/(PerMassTime o1, PerTimeLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(PerTimeLengthCub o1, PerMassTime o2) => new Density(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerMassTime o1, TimePerLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimePerLengthCub o1, PerMassTime o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(PerMassTime o1, TimePerLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(TimePerLengthCub o1, PerMassTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(PerMassTime o1, Density o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(Density o1, PerMassTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static Area operator/(PerMassTime o1, PerMassTimeLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerMassTimeLengthSqr o1, PerMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator/(PerMassTime o1, TimePerMassLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimePerMassLengthSqr o1, PerMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerMassTime o1, PerLengthSqrTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(PerLengthSqrTimeSqr o1, PerMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator/(PerMassTime o1, PerLengthSqrTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerLengthSqrTimeSqr o1, PerMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerMassTime o1, TimeSqrPerLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeSqrPerLengthSqr o1, PerMassTime o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(PerMassTime o1, TimeSqrPerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(TimeSqrPerLengthSqr o1, PerMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(PerMassTime o1, MassPerTimeLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(MassPerTimeLengthSqr o1, PerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator*(PerMassTime o1, MassTimePerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(MassTimePerLengthSqr o1, PerMassTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(PerMassTime o1, PerLengthMassTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerLengthMassTimeSqr o1, PerMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(PerMassTime o1, TimeSqrPerLengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeSqrPerLengthMass o1, PerMassTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator/(PerMassTime o1, PerLengthTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerLengthTimeCub o1, PerMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerMassTime o1, TimeCubPerLength o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeCubPerLength o1, PerMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(PerMassTime o1, MassPerLengthTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(MassPerLengthTimeSqr o1, PerMassTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(PerMassTime o1, TimeSqrMassPerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrMassPerLength o1, PerMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(PerMassTime o1, PerMassTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerMassTimeCub o1, PerMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(PerMassTime o1, TimeCubMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubMass o1, PerMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(PerMassTime o1, LengthPerMassTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthPerMassTimeSqr o1, PerMassTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(PerMassTime o1, TimeSqrLengthPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrLengthPerMass o1, PerMassTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(PerMassTime o1, LengthPerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthPerTimeCub o1, PerMassTime o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(PerMassTime o1, TimeCubLength o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(TimeCubLength o1, PerMassTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerMassTime o1, Force o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(Force o1, PerMassTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(PerMassTime o1, TimeSqrLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(TimeSqrLengthMass o1, PerMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(PerMassTime o1, LengthSqrPerMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrPerMassTime o1, PerMassTime o2) => new Area(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(PerMassTime o1, LengthSqrTimePerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(LengthSqrTimePerMass o1, PerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerMassTime o1, QDose o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(QDose o1, PerMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(PerMassTime o1, QDose o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(QDose o1, PerMassTime o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(PerMassTime o1, LengthSqrTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthSqrTimeSqr o1, PerMassTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerMassTime o1, LengthSqrTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(LengthSqrTimeSqr o1, PerMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static QDose operator*(PerMassTime o1, LengthSqrMassPerTime o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthSqrMassPerTime o1, PerMassTime o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static Area operator*(PerMassTime o1, LengthSqrMassTime o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrMassTime o1, PerMassTime o2) => new Area(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(PerMassTime o1, LengthCubPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubPerMass o1, PerMassTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator*(PerMassTime o1, LengthCubPerTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator*(LengthCubPerTime o1, PerMassTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(PerMassTime o1, LengthCubPerTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubPerTime o1, PerMassTime o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(PerMassTime o1, LengthCubTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubTime o1, PerMassTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerMassTime o1, LengthCubTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthCubTime o1, PerMassTime o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(PerMassTime o1, LengthCubMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubMass o1, PerMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static Volume operator/(PerMassTime o1, PerMassTimeLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(PerMassTimeLengthCub o1, PerMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(PerMassTime o1, TimePerMassLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(TimePerMassLengthCub o1, PerMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerMassTime o1, PerTimeSqrLengthCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerTimeSqrLengthCub o1, PerMassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator/(PerMassTime o1, PerTimeSqrLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(PerTimeSqrLengthCub o1, PerMassTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerMassTime o1, TimeSqrPerLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimeSqrPerLengthCub o1, PerMassTime o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator/(PerMassTime o1, TimeSqrPerLengthCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthCub operator/(TimeSqrPerLengthCub o1, PerMassTime o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(PerMassTime o1, MassPerTimeLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(MassPerTimeLengthCub o1, PerMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator*(PerMassTime o1, MassTimePerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(MassTimePerLengthCub o1, PerMassTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(PerMassTime o1, PerMassLengthSqrTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerMassLengthSqrTimeSqr o1, PerMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(PerMassTime o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeSqrPerMassLengthSqr o1, PerMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator/(PerMassTime o1, PerLengthSqrTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(PerLengthSqrTimeCub o1, PerMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(PerMassTime o1, TimeCubPerLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimeCubPerLengthSqr o1, PerMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(PerMassTime o1, MassPerLengthSqrTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(MassPerLengthSqrTimeSqr o1, PerMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator*(PerMassTime o1, TimeSqrMassPerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeSqrMassPerLengthSqr o1, PerMassTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(PerMassTime o1, PerLengthMassTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerLengthMassTimeCub o1, PerMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(PerMassTime o1, TimeCubMassPerLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubMassPerLength o1, PerMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator/(PerMassTime o1, LengthPerMassTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(LengthPerMassTimeCub o1, PerMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(PerMassTime o1, TimeCubLengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubLengthMass o1, PerMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(PerMassTime o1, LengthSqrPerMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrPerMassTimeSqr o1, PerMassTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(PerMassTime o1, LengthSqrTimeSqrPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(LengthSqrTimeSqrPerMass o1, PerMassTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator/(PerMassTime o1, LengthSqrPerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(LengthSqrPerTimeCub o1, PerMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator*(PerMassTime o1, TimeCubLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator*(TimeCubLengthSqr o1, PerMassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(PerMassTime o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(PerMassTime o1, LengthSqrTimeSqrMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthSqrTimeSqrMass o1, PerMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(PerMassTime o1, LengthCubPerMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubPerMassTime o1, PerMassTime o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(PerMassTime o1, LengthCubTimePerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthCubTimePerMass o1, PerMassTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTimeCub operator*(PerMassTime o1, LengthCubPerTimeSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator*(LengthCubPerTimeSqr o1, PerMassTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(PerMassTime o1, LengthCubPerTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthCubPerTimeSqr o1, PerMassTime o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(PerMassTime o1, LengthCubTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthCubTimeSqr o1, PerMassTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerMassTime o1, LengthCubTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(LengthCubTimeSqr o1, PerMassTime o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(PerMassTime o1, LengthCubMassPerTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthCubMassPerTime o1, PerMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Volume operator*(PerMassTime o1, LengthCubMassTime o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubMassTime o1, PerMassTime o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator/(PerMassTime o1, PerMassTimeSqrLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(PerMassTimeSqrLengthCub o1, PerMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator/(PerMassTime o1, TimeSqrPerMassLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthCub operator/(TimeSqrPerMassLengthCub o1, PerMassTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator/(PerMassTime o1, PerLengthCubTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerLengthCubTimeCub o1, PerMassTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerMassTime o1, TimeCubPerLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeCubPerLengthCub o1, PerMassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerMassTime o1, MassPerTimeSqrLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(MassPerTimeSqrLengthCub o1, PerMassTime o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator*(PerMassTime o1, TimeSqrMassPerLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeSqrMassPerLengthCub o1, PerMassTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator/(PerMassTime o1, PerMassLengthSqrTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerMassTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubMassPerLengthSqr o1, PerMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(PerMassTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthSqrPerMassTimeCub o1, PerMassTime o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(PerMassTime o1, TimeCubLengthSqrMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(TimeCubLengthSqrMass o1, PerMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerMassTime o1, LengthCubPerMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubPerMassTimeSqr o1, PerMassTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(PerMassTime o1, LengthCubTimeSqrPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthCubTimeSqrPerMass o1, PerMassTime o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator/(PerMassTime o1, LengthCubPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthCubPerTimeCub o1, PerMassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator*(PerMassTime o1, LengthCubTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator*(LengthCubTimeCub o1, PerMassTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTimeCub operator*(PerMassTime o1, LengthCubMassPerTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerMassTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator*(PerMassTime o1, LengthCubTimeSqrMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubTimeSqrMass o1, PerMassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqr operator/(PerMassTime o1, PerMassLengthCubTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerMassLengthCubTimeCub o1, PerMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(PerMassTime o1, TimeCubMassPerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeCubMassPerLengthCub o1, PerMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(PerMassTime o1, LengthCubPerMassTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthCubPerMassTimeCub o1, PerMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(PerMassTime o1, LengthCubTimeCubMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(LengthCubTimeCubMass o1, PerMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassTime permasstime, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasstime.HasMinValue && permasstime.Value_ < permasstime.MinValue)
        {
            fail = true;
        }

        if (permasstime.HasMaxValue && permasstime.Value_ > permasstime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassTime is outside its bounds.");
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
    