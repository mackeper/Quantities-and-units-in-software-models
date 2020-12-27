
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassTime : Quantity, IEquatable<MassTime>, IComparable
    {
    internal MassTime(double value) : base(value, 2)
    {
        MassTime.ImportDisplayUnitFromDatabase_();
    }
    internal MassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassTime(MassTime other) : base(other)
    {
        MassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassTime"))
        {
            switch(FakeDatabase.Units["MassTime"])
            {
				      case "kilogramsecond": displayUnit_ = kilogramsecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogramsecond_ = new Unit_("KilogramSecond", "kg s", 1);
	private static Unit_ platformUnit_ = kilogramsecond_;
	private static Unit_ displayUnit_ = kilogramsecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassTime other) => other is object && Equals((object)other);
    public int CompareTo(MassTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassTime other)) throw new ArgumentException("Object is not a MassTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassTime l1, MassTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassTime l1, MassTime l2) => !(l1 == l2);
    public static bool operator <(MassTime l1, MassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassTime l1, MassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassTime l1, MassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassTime l1, MassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassTime FromKilogramSeconds(double value, double minValue, double maxValue) => new MassTime(value * kilogramsecond_.Factor, minValue * kilogramsecond_.Factor, maxValue * kilogramsecond_.Factor);
		public static MassTime FromKilogramSeconds(double value) => new MassTime(value * kilogramsecond_.Factor);
		public double GetValueInKilogramSeconds() => Value_ / kilogramsecond_.Factor;

#endregion

#region arithmetic
		public static MassTime operator+(MassTime o1, MassTime o2) => new MassTime(o1.Value_ + o2.Value_);
		public static MassTime operator-(MassTime o1, MassTime o2) => new MassTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassTime o1, MassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(MassTime o1, LengthPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthPerMass o1, MassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(MassTime o1, Speed o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(Speed o1, MassTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(MassTime o1, Speed o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(Speed o1, MassTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(MassTime o1, LengthTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthTime o1, MassTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(MassTime o1, LengthTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthTime o1, MassTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(MassTime o1, LengthMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthMass o1, MassTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(MassTime o1, Area o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(Area o1, MassTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(MassTime o1, Area o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(Area o1, MassTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(MassTime o1, PerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(PerLengthCub o1, MassTime o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator/(MassTime o1, PerLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthCub o1, MassTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(MassTime o1, PerMassLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(PerMassLengthSqr o1, MassTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator*(MassTime o1, PerTimeLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(PerTimeLengthSqr o1, MassTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator/(MassTime o1, PerTimeLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerTimeLengthSqr o1, MassTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(MassTime o1, TimePerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimePerLengthSqr o1, MassTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator/(MassTime o1, TimePerLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimePerLengthSqr o1, MassTime o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(MassTime o1, MassPerLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassPerLengthSqr o1, MassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(MassTime o1, PerLengthMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerLengthMassTime o1, MassTime o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(MassTime o1, TimePerLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimePerLengthMass o1, MassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator*(MassTime o1, PerLengthTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(PerLengthTimeSqr o1, MassTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(MassTime o1, PerLengthTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthTimeSqr o1, MassTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(MassTime o1, TimeSqrPerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeSqrPerLength o1, MassTime o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(MassTime o1, TimeSqrPerLength o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeSqrPerLength o1, MassTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(MassTime o1, MassPerLengthTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(MassPerLengthTime o1, MassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(MassTime o1, MassTimePerLength o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassTimePerLength o1, MassTime o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(MassTime o1, PerMassTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerMassTimeSqr o1, MassTime o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(MassTime o1, TimeSqrPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqrPerMass o1, MassTime o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(MassTime o1, PerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(PerTimeCub o1, MassTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator/(MassTime o1, TimeCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeCub o1, MassTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCub operator/(MassTime o1, MassPerTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(MassPerTimeSqr o1, MassTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(MassTime o1, TimeSqrMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeSqrMass o1, MassTime o2) => new Time(o1.Value_ / o2.Value_);
		
		public static Length operator*(MassTime o1, LengthPerMassTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthPerMassTime o1, MassTime o2) => new Length(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(MassTime o1, LengthTimePerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthTimePerMass o1, MassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(MassTime o1, Acceleration o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(Acceleration o1, MassTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(MassTime o1, Acceleration o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(Acceleration o1, MassTime o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(MassTime o1, TimeSqrLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(TimeSqrLength o1, MassTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator/(MassTime o1, TimeSqrLength o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(TimeSqrLength o1, MassTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(MassTime o1, LengthMassPerTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(LengthMassPerTime o1, MassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(MassTime o1, LengthMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthMassTime o1, MassTime o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(MassTime o1, LengthSqrPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthSqrPerMass o1, MassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(MassTime o1, LengthSqrPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthSqrPerTime o1, MassTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(MassTime o1, LengthSqrPerTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthSqrPerTime o1, MassTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(MassTime o1, LengthSqrTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthSqrTime o1, MassTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator/(MassTime o1, LengthSqrTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthSqrTime o1, MassTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator/(MassTime o1, LengthSqrMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrMass o1, MassTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(MassTime o1, Volume o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(Volume o1, MassTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(MassTime o1, Volume o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(Volume o1, MassTime o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(MassTime o1, PerMassLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(PerMassLengthCub o1, MassTime o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static Density operator*(MassTime o1, PerTimeLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(PerTimeLengthCub o1, MassTime o2) => new Density(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator/(MassTime o1, PerTimeLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerTimeLengthCub o1, MassTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(MassTime o1, TimePerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimePerLengthCub o1, MassTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMass operator/(MassTime o1, TimePerLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(TimePerLengthCub o1, MassTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator/(MassTime o1, Density o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(Density o1, MassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(MassTime o1, PerMassTimeLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(PerMassTimeLengthSqr o1, MassTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(MassTime o1, TimePerMassLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimePerMassLengthSqr o1, MassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(MassTime o1, PerLengthSqrTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(PerLengthSqrTimeSqr o1, MassTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator/(MassTime o1, PerLengthSqrTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerLengthSqrTimeSqr o1, MassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(MassTime o1, TimeSqrPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeSqrPerLengthSqr o1, MassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator/(MassTime o1, TimeSqrPerLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeSqrPerLengthSqr o1, MassTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator/(MassTime o1, MassPerTimeLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(MassPerTimeLengthSqr o1, MassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(MassTime o1, MassTimePerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(MassTimePerLengthSqr o1, MassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(MassTime o1, PerLengthMassTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerLengthMassTimeSqr o1, MassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(MassTime o1, TimeSqrPerLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeSqrPerLengthMass o1, MassTime o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(MassTime o1, PerLengthTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(PerLengthTimeCub o1, MassTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static Force operator/(MassTime o1, TimeCubPerLength o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeCubPerLength o1, MassTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator/(MassTime o1, MassPerLengthTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(MassPerLengthTimeSqr o1, MassTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static Speed operator/(MassTime o1, TimeSqrMassPerLength o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeSqrMassPerLength o1, MassTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(MassTime o1, PerMassTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(PerMassTimeCub o1, MassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(MassTime o1, TimeCubMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeCubMass o1, MassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static Speed operator*(MassTime o1, LengthPerMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthPerMassTimeSqr o1, MassTime o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(MassTime o1, TimeSqrLengthPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeSqrLengthPerMass o1, MassTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static Force operator*(MassTime o1, LengthPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthPerTimeCub o1, MassTime o2) => new Force(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(MassTime o1, TimeCubLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeCubLength o1, MassTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator/(MassTime o1, Force o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(Force o1, MassTime o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(MassTime o1, TimeSqrLengthMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeSqrLengthMass o1, MassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(MassTime o1, LengthSqrPerMassTime o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrPerMassTime o1, MassTime o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(MassTime o1, LengthSqrTimePerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthSqrTimePerMass o1, MassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassTime o1, QDose o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(QDose o1, MassTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(MassTime o1, QDose o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(QDose o1, MassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(MassTime o1, LengthSqrTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthSqrTimeSqr o1, MassTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassTime o1, LengthSqrTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthSqrTimeSqr o1, MassTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(MassTime o1, LengthSqrMassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthSqrMassPerTime o1, MassTime o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(MassTime o1, LengthSqrMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrMassTime o1, MassTime o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(MassTime o1, LengthCubPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubPerMass o1, MassTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static LengthCubMass operator*(MassTime o1, LengthCubPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubPerTime o1, MassTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(MassTime o1, LengthCubPerTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthCubPerTime o1, MassTime o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrMass operator*(MassTime o1, LengthCubTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator*(LengthCubTime o1, MassTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static Density operator/(MassTime o1, LengthCubTime o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubTime o1, MassTime o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator/(MassTime o1, LengthCubMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubMass o1, MassTime o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(MassTime o1, PerMassTimeLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerMassTimeLengthCub o1, MassTime o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(MassTime o1, TimePerMassLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimePerMassLengthCub o1, MassTime o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator*(MassTime o1, PerTimeSqrLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(PerTimeSqrLengthCub o1, MassTime o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator/(MassTime o1, PerTimeSqrLengthCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerTimeSqrLengthCub o1, MassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(MassTime o1, TimeSqrPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeSqrPerLengthCub o1, MassTime o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator/(MassTime o1, TimeSqrPerLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(TimeSqrPerLengthCub o1, MassTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator/(MassTime o1, MassPerTimeLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(MassPerTimeLengthCub o1, MassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static Volume operator/(MassTime o1, MassTimePerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(MassTimePerLengthCub o1, MassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(MassTime o1, PerMassLengthSqrTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerMassLengthSqrTimeSqr o1, MassTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(MassTime o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeSqrPerMassLengthSqr o1, MassTime o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(MassTime o1, PerLengthSqrTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(PerLengthSqrTimeCub o1, MassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(MassTime o1, TimeCubPerLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeCubPerLengthSqr o1, MassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator/(MassTime o1, MassPerLengthSqrTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(MassPerLengthSqrTimeSqr o1, MassTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(MassTime o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, MassTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(MassTime o1, PerLengthMassTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerLengthMassTimeCub o1, MassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static Acceleration operator/(MassTime o1, TimeCubMassPerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubMassPerLength o1, MassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(MassTime o1, LengthPerMassTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthPerMassTimeCub o1, MassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator/(MassTime o1, TimeCubLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeCubLengthMass o1, MassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(MassTime o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrPerMassTimeSqr o1, MassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(MassTime o1, LengthSqrTimeSqrPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthSqrTimeSqrPerMass o1, MassTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(MassTime o1, LengthSqrPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthSqrPerTimeCub o1, MassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator/(MassTime o1, TimeCubLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeCubLengthSqr o1, MassTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(MassTime o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, MassTime o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator/(MassTime o1, LengthSqrTimeSqrMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthSqrTimeSqrMass o1, MassTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(MassTime o1, LengthCubPerMassTime o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubPerMassTime o1, MassTime o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqr operator*(MassTime o1, LengthCubTimePerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(LengthCubTimePerMass o1, MassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTime operator*(MassTime o1, LengthCubPerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubPerTimeSqr o1, MassTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(MassTime o1, LengthCubPerTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthCubPerTimeSqr o1, MassTime o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubMass operator*(MassTime o1, LengthCubTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator*(LengthCubTimeSqr o1, MassTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(MassTime o1, LengthCubTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubTimeSqr o1, MassTime o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(MassTime o1, LengthCubMassPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthCubMassPerTime o1, MassTime o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(MassTime o1, LengthCubMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubMassTime o1, MassTime o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(MassTime o1, PerMassTimeSqrLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerMassTimeSqrLengthCub o1, MassTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(MassTime o1, TimeSqrPerMassLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeSqrPerMassLengthCub o1, MassTime o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(MassTime o1, PerLengthCubTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(PerLengthCubTimeCub o1, MassTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator/(MassTime o1, TimeCubPerLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(TimeCubPerLengthCub o1, MassTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCub operator/(MassTime o1, MassPerTimeSqrLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		public static PerLengthCubTimeCub operator/(MassPerTimeSqrLengthCub o1, MassTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator/(MassTime o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(TimeSqrMassPerLengthCub o1, MassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(MassTime o1, PerMassLengthSqrTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerMassLengthSqrTimeCub o1, MassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static QDose operator/(MassTime o1, TimeCubMassPerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeCubMassPerLengthSqr o1, MassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassTime o1, LengthSqrPerMassTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthSqrPerMassTimeCub o1, MassTime o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(MassTime o1, TimeCubLengthSqrMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeCubLengthSqrMass o1, MassTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(MassTime o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubPerMassTimeSqr o1, MassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeCub operator*(MassTime o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator*(LengthCubTimeSqrPerMass o1, MassTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(MassTime o1, LengthCubPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(LengthCubPerTimeCub o1, MassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator/(MassTime o1, LengthCubTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthCubTimeCub o1, MassTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator/(MassTime o1, LengthCubMassPerTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthCubMassPerTimeSqr o1, MassTime o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator/(MassTime o1, LengthCubTimeSqrMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubTimeSqrMass o1, MassTime o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(MassTime o1, PerMassLengthCubTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerMassLengthCubTimeCub o1, MassTime o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(MassTime o1, TimeCubMassPerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(TimeCubMassPerLengthCub o1, MassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(MassTime o1, LengthCubPerMassTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthCubPerMassTimeCub o1, MassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(MassTime o1, LengthCubTimeCubMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthCubTimeCubMass o1, MassTime o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassTime masstime, bool throwOnFail=true)
    {
        bool fail = false;
        if (masstime.HasMinValue && masstime.Value_ < masstime.MinValue)
        {
            fail = true;
        }

        if (masstime.HasMaxValue && masstime.Value_ > masstime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassTime is outside its bounds.");
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
    