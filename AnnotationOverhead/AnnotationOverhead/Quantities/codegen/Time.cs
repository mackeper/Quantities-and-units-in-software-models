
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class Time : Quantity, IEquatable<Time>, IComparable
    {
    internal Time(double value) : base(value, 2)
    {
        Time.ImportDisplayUnitFromDatabase_();
    }
    internal Time(double value, double minValue, double maxValue) : base(value, 2)
    {
        Time.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public Time(Time other) : base(other)
    {
        Time.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Time"))
        {
            switch(FakeDatabase.Units["Time"])
            {
				      case "second": displayUnit_ = second_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ second_ = new Unit_("Second", "s", 1);
	private static Unit_ platformUnit_ = second_;
	private static Unit_ displayUnit_ = second_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(Time other) => other is object && Equals((object)other);
    public int CompareTo(Time other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is Time other)) throw new ArgumentException("Object is not a Time.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(Time l1, Time l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(Time l1, Time l2) => !(l1 == l2);
    public static bool operator <(Time l1, Time l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(Time l1, Time l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(Time l1, Time l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(Time l1, Time l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static Time FromSeconds(double value, double minValue, double maxValue) => new Time(value * second_.Factor, minValue * second_.Factor, maxValue * second_.Factor);
		public static Time FromSeconds(double value) => new Time(value * second_.Factor);
		public double GetValueInSeconds() => Value_ / second_.Factor;

#endregion

#region arithmetic
		public static Time operator+(Time o1, Time o2) => new Time(o1.Value_ + o2.Value_);
		public static Time operator-(Time o1, Time o2) => new Time(o1.Value_ - o2.Value_);
		public static TimeSqr operator*(Time o1, Time o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static Dimensionless operator/(Time o1, Time o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(Time o1, Mass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(Mass o1, Time o2) => new MassTime(o1.Value_ * o2.Value_);
		public static TimePerMass operator/(Time o1, Mass o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(Mass o1, Time o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(Time o1, Length o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(Length o1, Time o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static TimePerLength operator/(Time o1, Length o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(Length o1, Time o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(Time o1, PerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(PerLengthSqr o1, Time o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator/(Time o1, PerLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerLengthSqr o1, Time o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(Time o1, PerLengthMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(PerLengthMass o1, Time o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static LengthMassTime operator/(Time o1, PerLengthMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerLengthMass o1, Time o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(Time o1, PerLengthTime o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerLengthTime o1, Time o2) => new PerLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator/(Time o1, PerLengthTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerLengthTime o1, Time o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(Time o1, TimePerLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimePerLength o1, Time o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static Length operator/(Time o1, TimePerLength o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimePerLength o1, Time o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(Time o1, MassPerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassPerLength o1, Time o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator/(Time o1, MassPerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerLength o1, Time o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(Time o1, PerMassTime o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerMassTime o1, Time o2) => new PerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator/(Time o1, PerMassTime o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerMassTime o1, Time o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator*(Time o1, TimePerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimePerMass o1, Time o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static Mass operator/(Time o1, TimePerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(TimePerMass o1, Time o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(Time o1, PerTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerTimeSqr o1, Time o2) => new PerTime(o1.Value_ * o2.Value_);
		public static TimeCub operator/(Time o1, PerTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(PerTimeSqr o1, Time o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCub operator*(Time o1, TimeSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqr o1, Time o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static PerTime operator/(Time o1, TimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeSqr o1, Time o2) => new Time(o1.Value_ / o2.Value_);
		
		public static Mass operator*(Time o1, MassPerTime o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerTime o1, Time o2) => new Mass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator/(Time o1, MassPerTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(MassPerTime o1, Time o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator*(Time o1, MassTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(MassTime o1, Time o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static PerMass operator/(Time o1, MassTime o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassTime o1, Time o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(Time o1, LengthPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthPerMass o1, Time o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(Time o1, LengthPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthPerMass o1, Time o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(Time o1, Speed o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(Speed o1, Time o2) => new Length(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator/(Time o1, Speed o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(Speed o1, Time o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(Time o1, LengthTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthTime o1, Time o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static PerLength operator/(Time o1, LengthTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthTime o1, Time o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(Time o1, LengthMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthMass o1, Time o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(Time o1, LengthMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthMass o1, Time o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(Time o1, Area o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(Area o1, Time o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator/(Time o1, Area o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(Area o1, Time o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(Time o1, PerLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(PerLengthCub o1, Time o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTime operator/(Time o1, PerLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(PerLengthCub o1, Time o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(Time o1, PerMassLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(PerMassLengthSqr o1, Time o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator/(Time o1, PerMassLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerMassLengthSqr o1, Time o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(Time o1, PerTimeLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(PerTimeLengthSqr o1, Time o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator/(Time o1, PerTimeLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerTimeLengthSqr o1, Time o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(Time o1, TimePerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimePerLengthSqr o1, Time o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static Area operator/(Time o1, TimePerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimePerLengthSqr o1, Time o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(Time o1, MassPerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(MassPerLengthSqr o1, Time o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator/(Time o1, MassPerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerLengthSqr o1, Time o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(Time o1, PerLengthMassTime o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerLengthMassTime o1, Time o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator/(Time o1, PerLengthMassTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerLengthMassTime o1, Time o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(Time o1, TimePerLengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimePerLengthMass o1, Time o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator/(Time o1, TimePerLengthMass o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(TimePerLengthMass o1, Time o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(Time o1, PerLengthTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerLengthTimeSqr o1, Time o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static TimeCubLength operator/(Time o1, PerLengthTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(PerLengthTimeSqr o1, Time o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator*(Time o1, TimeSqrPerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeSqrPerLength o1, Time o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static Speed operator/(Time o1, TimeSqrPerLength o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeSqrPerLength o1, Time o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(Time o1, MassPerLengthTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(MassPerLengthTime o1, Time o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator/(Time o1, MassPerLengthTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(MassPerLengthTime o1, Time o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(Time o1, MassTimePerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(MassTimePerLength o1, Time o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static LengthPerMass operator/(Time o1, MassTimePerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassTimePerLength o1, Time o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(Time o1, PerMassTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(PerMassTimeSqr o1, Time o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubMass operator/(Time o1, PerMassTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(PerMassTimeSqr o1, Time o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator*(Time o1, TimeSqrPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(TimeSqrPerMass o1, Time o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static MassPerTime operator/(Time o1, TimeSqrPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMass operator/(TimeSqrPerMass o1, Time o2) => new TimePerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(Time o1, PerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(PerTimeCub o1, Time o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(Time o1, TimeCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeCub o1, Time o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(Time o1, MassPerTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(MassPerTimeSqr o1, Time o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator/(Time o1, MassPerTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(MassPerTimeSqr o1, Time o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator*(Time o1, TimeSqrMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeSqrMass o1, Time o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static PerMassTime operator/(Time o1, TimeSqrMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimeSqrMass o1, Time o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(Time o1, LengthPerMassTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthPerMassTime o1, Time o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(Time o1, LengthPerMassTime o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthPerMassTime o1, Time o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(Time o1, LengthTimePerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthTimePerMass o1, Time o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(Time o1, LengthTimePerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthTimePerMass o1, Time o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static Speed operator*(Time o1, Acceleration o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(Acceleration o1, Time o2) => new Speed(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator/(Time o1, Acceleration o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(Acceleration o1, Time o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator*(Time o1, TimeSqrLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeSqrLength o1, Time o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static PerLengthTime operator/(Time o1, TimeSqrLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeSqrLength o1, Time o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(Time o1, LengthMassPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthMassPerTime o1, Time o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator/(Time o1, LengthMassPerTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthMassPerTime o1, Time o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(Time o1, LengthMassTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthMassTime o1, Time o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator/(Time o1, LengthMassTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthMassTime o1, Time o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(Time o1, LengthSqrPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthSqrPerMass o1, Time o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(Time o1, LengthSqrPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthSqrPerMass o1, Time o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(Time o1, LengthSqrPerTime o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrPerTime o1, Time o2) => new Area(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator/(Time o1, LengthSqrPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthSqrPerTime o1, Time o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(Time o1, LengthSqrTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthSqrTime o1, Time o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator/(Time o1, LengthSqrTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrTime o1, Time o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(Time o1, LengthSqrMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthSqrMass o1, Time o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(Time o1, LengthSqrMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthSqrMass o1, Time o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(Time o1, Volume o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(Volume o1, Time o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator/(Time o1, Volume o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(Volume o1, Time o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(Time o1, PerMassLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(PerMassLengthCub o1, Time o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator/(Time o1, PerMassLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerMassLengthCub o1, Time o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(Time o1, PerTimeLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerTimeLengthCub o1, Time o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator/(Time o1, PerTimeLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerTimeLengthCub o1, Time o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(Time o1, TimePerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimePerLengthCub o1, Time o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static Volume operator/(Time o1, TimePerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(TimePerLengthCub o1, Time o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(Time o1, Density o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(Density o1, Time o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator/(Time o1, Density o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(Density o1, Time o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(Time o1, PerMassTimeLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(PerMassTimeLengthSqr o1, Time o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator/(Time o1, PerMassTimeLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerMassTimeLengthSqr o1, Time o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(Time o1, TimePerMassLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimePerMassLengthSqr o1, Time o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator/(Time o1, TimePerMassLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimePerMassLengthSqr o1, Time o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(Time o1, PerLengthSqrTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthSqrTimeSqr o1, Time o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator/(Time o1, PerLengthSqrTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerLengthSqrTimeSqr o1, Time o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(Time o1, TimeSqrPerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeSqrPerLengthSqr o1, Time o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator/(Time o1, TimeSqrPerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeSqrPerLengthSqr o1, Time o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(Time o1, MassPerTimeLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(MassPerTimeLengthSqr o1, Time o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(Time o1, MassPerTimeLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(MassPerTimeLengthSqr o1, Time o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(Time o1, MassTimePerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(MassTimePerLengthSqr o1, Time o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator/(Time o1, MassTimePerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(MassTimePerLengthSqr o1, Time o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(Time o1, PerLengthMassTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(PerLengthMassTimeSqr o1, Time o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(Time o1, PerLengthMassTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthMassTimeSqr o1, Time o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator*(Time o1, TimeSqrPerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimeSqrPerLengthMass o1, Time o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(Time o1, TimeSqrPerLengthMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeSqrPerLengthMass o1, Time o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(Time o1, PerLengthTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerLengthTimeCub o1, Time o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static Acceleration operator/(Time o1, TimeCubPerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubPerLength o1, Time o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(Time o1, MassPerLengthTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassPerLengthTimeSqr o1, Time o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator/(Time o1, MassPerLengthTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(MassPerLengthTimeSqr o1, Time o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(Time o1, TimeSqrMassPerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeSqrMassPerLength o1, Time o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator/(Time o1, TimeSqrMassPerLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(TimeSqrMassPerLength o1, Time o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(Time o1, PerMassTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(PerMassTimeCub o1, Time o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator/(Time o1, TimeCubPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeCubPerMass o1, Time o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator*(Time o1, MassPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(MassPerTimeCub o1, Time o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqr operator/(Time o1, TimeCubMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(TimeCubMass o1, Time o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(Time o1, LengthPerMassTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthPerMassTimeSqr o1, Time o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(Time o1, LengthPerMassTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(LengthPerMassTimeSqr o1, Time o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator*(Time o1, TimeSqrLengthPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(TimeSqrLengthPerMass o1, Time o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator/(Time o1, TimeSqrLengthPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(TimeSqrLengthPerMass o1, Time o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(Time o1, LengthPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthPerTimeCub o1, Time o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator/(Time o1, TimeCubLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeCubLength o1, Time o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(Time o1, Force o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(Force o1, Time o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator/(Time o1, Force o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(Force o1, Time o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(Time o1, TimeSqrLengthMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(TimeSqrLengthMass o1, Time o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator/(Time o1, TimeSqrLengthMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(TimeSqrLengthMass o1, Time o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(Time o1, LengthSqrPerMassTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthSqrPerMassTime o1, Time o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(Time o1, LengthSqrPerMassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthSqrPerMassTime o1, Time o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator*(Time o1, LengthSqrTimePerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator*(LengthSqrTimePerMass o1, Time o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator/(Time o1, LengthSqrTimePerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthSqrTimePerMass o1, Time o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(Time o1, QDose o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(QDose o1, Time o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator/(Time o1, QDose o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(QDose o1, Time o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator*(Time o1, LengthSqrTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthSqrTimeSqr o1, Time o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator/(Time o1, LengthSqrTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthSqrTimeSqr o1, Time o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(Time o1, LengthSqrMassPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthSqrMassPerTime o1, Time o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(Time o1, LengthSqrMassPerTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(LengthSqrMassPerTime o1, Time o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(Time o1, LengthSqrMassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthSqrMassTime o1, Time o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator/(Time o1, LengthSqrMassTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrMassTime o1, Time o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(Time o1, LengthCubPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthCubPerMass o1, Time o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(Time o1, LengthCubPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthCubPerMass o1, Time o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(Time o1, LengthCubPerTime o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubPerTime o1, Time o2) => new Volume(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator/(Time o1, LengthCubPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthCubPerTime o1, Time o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(Time o1, LengthCubTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(LengthCubTime o1, Time o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthCub operator/(Time o1, LengthCubTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubTime o1, Time o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(Time o1, LengthCubMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthCubMass o1, Time o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(Time o1, LengthCubMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthCubMass o1, Time o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(Time o1, PerMassTimeLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(PerMassTimeLengthCub o1, Time o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator/(Time o1, PerMassTimeLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerMassTimeLengthCub o1, Time o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(Time o1, TimePerMassLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimePerMassLengthCub o1, Time o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMass operator/(Time o1, TimePerMassLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(TimePerMassLengthCub o1, Time o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(Time o1, PerTimeSqrLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerTimeSqrLengthCub o1, Time o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator/(Time o1, PerTimeSqrLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		public static PerLengthCubTimeCub operator/(PerTimeSqrLengthCub o1, Time o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator*(Time o1, TimeSqrPerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeSqrPerLengthCub o1, Time o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator/(Time o1, TimeSqrPerLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(TimeSqrPerLengthCub o1, Time o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static Density operator*(Time o1, MassPerTimeLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(MassPerTimeLengthCub o1, Time o2) => new Density(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(Time o1, MassPerTimeLengthCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(MassPerTimeLengthCub o1, Time o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(Time o1, MassTimePerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(MassTimePerLengthCub o1, Time o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator/(Time o1, MassTimePerLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(MassTimePerLengthCub o1, Time o2) => new Density(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(Time o1, PerMassLengthSqrTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerMassLengthSqrTimeSqr o1, Time o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator/(Time o1, PerMassLengthSqrTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerMassLengthSqrTimeSqr o1, Time o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(Time o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimeSqrPerMassLengthSqr o1, Time o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator/(Time o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeSqrPerMassLengthSqr o1, Time o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(Time o1, PerLengthSqrTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerLengthSqrTimeCub o1, Time o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static QDose operator/(Time o1, TimeCubPerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeCubPerLengthSqr o1, Time o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(Time o1, MassPerLengthSqrTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassPerLengthSqrTimeSqr o1, Time o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(Time o1, MassPerLengthSqrTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerLengthSqrTimeSqr o1, Time o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(Time o1, TimeSqrMassPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeSqrMassPerLengthSqr o1, Time o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator/(Time o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, Time o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(Time o1, PerLengthMassTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(PerLengthMassTimeCub o1, Time o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static Force operator/(Time o1, TimeCubPerLengthMass o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeCubPerLengthMass o1, Time o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(Time o1, MassPerLengthTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(MassPerLengthTimeCub o1, Time o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeSqr operator/(Time o1, TimeCubMassPerLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLength operator/(TimeCubMassPerLength o1, Time o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(Time o1, LengthPerMassTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthPerMassTimeCub o1, Time o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(Time o1, TimeCubLengthPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeCubLengthPerMass o1, Time o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static Force operator*(Time o1, LengthMassPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthMassPerTimeCub o1, Time o2) => new Force(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(Time o1, TimeCubLengthMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(TimeCubLengthMass o1, Time o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(Time o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthSqrPerMassTimeSqr o1, Time o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(Time o1, LengthSqrPerMassTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(LengthSqrPerMassTimeSqr o1, Time o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator*(Time o1, LengthSqrTimeSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator*(LengthSqrTimeSqrPerMass o1, Time o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(Time o1, LengthSqrTimeSqrPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthSqrTimeSqrPerMass o1, Time o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static QDose operator*(Time o1, LengthSqrPerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthSqrPerTimeCub o1, Time o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(Time o1, TimeCubLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeCubLengthSqr o1, Time o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(Time o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthSqrMassPerTimeSqr o1, Time o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(Time o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, Time o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(Time o1, LengthSqrTimeSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthSqrTimeSqrMass o1, Time o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(Time o1, LengthSqrTimeSqrMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(LengthSqrTimeSqrMass o1, Time o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(Time o1, LengthCubPerMassTime o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubPerMassTime o1, Time o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(Time o1, LengthCubPerMassTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthCubPerMassTime o1, Time o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator*(Time o1, LengthCubTimePerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator*(LengthCubTimePerMass o1, Time o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static Density operator/(Time o1, LengthCubTimePerMass o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubTimePerMass o1, Time o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(Time o1, LengthCubPerTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubPerTimeSqr o1, Time o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator/(Time o1, LengthCubPerTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthCubPerTimeSqr o1, Time o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCub operator*(Time o1, LengthCubTimeSqr o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator*(LengthCubTimeSqr o1, Time o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator/(Time o1, LengthCubTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubTimeSqr o1, Time o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(Time o1, LengthCubMassPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubMassPerTime o1, Time o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(Time o1, LengthCubMassPerTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthCubMassPerTime o1, Time o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrMass operator*(Time o1, LengthCubMassTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator*(LengthCubMassTime o1, Time o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(Time o1, LengthCubMassTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubMassTime o1, Time o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(Time o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerMassTimeSqrLengthCub o1, Time o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator/(Time o1, PerMassTimeSqrLengthCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerMassTimeSqrLengthCub o1, Time o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(Time o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimeSqrPerMassLengthCub o1, Time o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator/(Time o1, TimeSqrPerMassLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(TimeSqrPerMassLengthCub o1, Time o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(Time o1, PerLengthCubTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerLengthCubTimeCub o1, Time o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(Time o1, TimeCubPerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(TimeCubPerLengthCub o1, Time o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(Time o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassPerTimeSqrLengthCub o1, Time o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator/(Time o1, MassPerTimeSqrLengthCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthCubTimeCub operator/(MassPerTimeSqrLengthCub o1, Time o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(Time o1, TimeSqrMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeSqrMassPerLengthCub o1, Time o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator/(Time o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(TimeSqrMassPerLengthCub o1, Time o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(Time o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerMassLengthSqrTimeCub o1, Time o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(Time o1, TimeCubPerMassLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeCubPerMassLengthSqr o1, Time o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(Time o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(MassPerLengthSqrTimeCub o1, Time o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(Time o1, TimeCubMassPerLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(TimeCubMassPerLengthSqr o1, Time o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(Time o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthSqrPerMassTimeCub o1, Time o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator/(Time o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeCubLengthSqrPerMass o1, Time o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(Time o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthSqrMassPerTimeCub o1, Time o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator/(Time o1, TimeCubLengthSqrMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(TimeCubLengthSqrMass o1, Time o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(Time o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthCubPerMassTimeSqr o1, Time o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(Time o1, LengthCubPerMassTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthCubPerMassTimeSqr o1, Time o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubPerMass operator*(Time o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator*(LengthCubTimeSqrPerMass o1, Time o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(Time o1, LengthCubTimeSqrPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubTimeSqrPerMass o1, Time o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(Time o1, LengthCubPerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthCubPerTimeCub o1, Time o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(Time o1, LengthCubTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthCubTimeCub o1, Time o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(Time o1, LengthCubMassPerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubMassPerTimeSqr o1, Time o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(Time o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthCubMassPerTimeSqr o1, Time o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubMass operator*(Time o1, LengthCubTimeSqrMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator*(LengthCubTimeSqrMass o1, Time o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(Time o1, LengthCubTimeSqrMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthCubTimeSqrMass o1, Time o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(Time o1, PerMassLengthCubTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerMassLengthCubTimeCub o1, Time o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator/(Time o1, TimeCubPerMassLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(TimeCubPerMassLengthCub o1, Time o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(Time o1, MassPerLengthCubTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(MassPerLengthCubTimeCub o1, Time o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator/(Time o1, TimeCubMassPerLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(TimeCubMassPerLengthCub o1, Time o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator*(Time o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator*(LengthCubPerMassTimeCub o1, Time o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator/(Time o1, LengthCubTimeCubPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthCubTimeCubPerMass o1, Time o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(Time o1, LengthCubMassPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(LengthCubMassPerTimeCub o1, Time o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator/(Time o1, LengthCubTimeCubMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthCubTimeCubMass o1, Time o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(Time time, bool throwOnFail=true)
    {
        bool fail = false;
        if (time.HasMinValue && time.Value_ < time.MinValue)
        {
            fail = true;
        }

        if (time.HasMaxValue && time.Value_ > time.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("Time is outside its bounds.");
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
    