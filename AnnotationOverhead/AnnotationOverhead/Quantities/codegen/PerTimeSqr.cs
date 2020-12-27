
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTimeSqr : Quantity, IEquatable<PerTimeSqr>, IComparable
    {
    internal PerTimeSqr(double value) : base(value, 2)
    {
        PerTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTimeSqr(PerTimeSqr other) : base(other)
    {
        PerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTimeSqr"))
        {
            switch(FakeDatabase.Units["PerTimeSqr"])
            {
				      case "persecondsqr": displayUnit_ = persecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ persecondsqr_ = new Unit_("PerSecondSqr", "/s²", 1.0);
	private static Unit_ platformUnit_ = persecondsqr_;
	private static Unit_ displayUnit_ = persecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTimeSqr other)) throw new ArgumentException("Object is not a PerTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTimeSqr l1, PerTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTimeSqr l1, PerTimeSqr l2) => !(l1 == l2);
    public static bool operator <(PerTimeSqr l1, PerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTimeSqr l1, PerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTimeSqr l1, PerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTimeSqr l1, PerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTimeSqr FromPerSecondSqrs(double value, double minValue, double maxValue) => new PerTimeSqr(value * persecondsqr_.Factor, minValue * persecondsqr_.Factor, maxValue * persecondsqr_.Factor);
		public static PerTimeSqr FromPerSecondSqrs(double value) => new PerTimeSqr(value * persecondsqr_.Factor);
		public double GetValueInPerSecondSqrs() => Value_ / persecondsqr_.Factor;

#endregion

#region arithmetic
		public static PerTimeSqr operator+(PerTimeSqr o1, PerTimeSqr o2) => new PerTimeSqr(o1.Value_ + o2.Value_);
		public static PerTimeSqr operator-(PerTimeSqr o1, PerTimeSqr o2) => new PerTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTimeSqr o1, PerTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerTimeSqr o1, TimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeSqr o1, PerTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerTimeSqr o1, MassPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(MassPerTime o1, PerTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTime operator/(PerTimeSqr o1, MassPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerTime o1, PerTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(PerTimeSqr o1, MassTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(MassTime o1, PerTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator/(PerTimeSqr o1, MassTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(MassTime o1, PerTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerTimeSqr o1, LengthPerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthPerMass o1, PerTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerTimeSqr o1, LengthPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(LengthPerMass o1, PerTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(PerTimeSqr o1, Speed o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(Speed o1, PerTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTime operator/(PerTimeSqr o1, Speed o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(Speed o1, PerTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerTimeSqr o1, LengthTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthTime o1, PerTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator/(PerTimeSqr o1, LengthTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthTime o1, PerTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static Force operator*(PerTimeSqr o1, LengthMass o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthMass o1, PerTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerTimeSqr o1, LengthMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(LengthMass o1, PerTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static QDose operator*(PerTimeSqr o1, Area o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(Area o1, PerTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerTimeSqr o1, Area o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(Area o1, PerTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(PerTimeSqr o1, PerLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerLengthCub o1, PerTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator/(PerTimeSqr o1, PerLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(PerLengthCub o1, PerTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(PerTimeSqr o1, PerMassLengthSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerMassLengthSqr o1, PerTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(PerTimeSqr o1, PerMassLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerMassLengthSqr o1, PerTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(PerTimeSqr o1, PerTimeLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerTimeLengthSqr o1, PerTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator/(PerTimeSqr o1, PerTimeLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerTimeLengthSqr o1, PerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(PerTimeSqr o1, TimePerLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(TimePerLengthSqr o1, PerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator/(PerTimeSqr o1, TimePerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimePerLengthSqr o1, PerTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(PerTimeSqr o1, MassPerLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(MassPerLengthSqr o1, PerTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(PerTimeSqr o1, MassPerLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(MassPerLengthSqr o1, PerTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerTimeSqr o1, PerLengthMassTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(PerLengthMassTime o1, PerTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(PerTimeSqr o1, PerLengthMassTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(PerLengthMassTime o1, PerTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(PerTimeSqr o1, TimePerLengthMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(TimePerLengthMass o1, PerTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator/(PerTimeSqr o1, TimePerLengthMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimePerLengthMass o1, PerTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(PerTimeSqr o1, PerLengthTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthTimeSqr o1, PerTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(PerTimeSqr o1, TimeSqrPerLength o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimeSqrPerLength o1, PerTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(PerTimeSqr o1, MassPerLengthTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(MassPerLengthTime o1, PerTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator/(PerTimeSqr o1, MassPerLengthTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassPerLengthTime o1, PerTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(PerTimeSqr o1, MassTimePerLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassTimePerLength o1, PerTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator/(PerTimeSqr o1, MassTimePerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(MassTimePerLength o1, PerTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static Mass operator/(PerTimeSqr o1, PerMassTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassTimeSqr o1, PerTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerTimeSqr o1, TimeSqrPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeSqrPerMass o1, PerTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerTimeSqr o1, PerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerTimeCub o1, PerTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerTimeSqr o1, TimeCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCub o1, PerTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(PerTimeSqr o1, MassPerTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerTimeSqr o1, PerTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static Mass operator*(PerTimeSqr o1, TimeSqrMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeSqrMass o1, PerTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerTimeSqr o1, LengthPerMassTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthPerMassTime o1, PerTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator/(PerTimeSqr o1, LengthPerMassTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(LengthPerMassTime o1, PerTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(PerTimeSqr o1, LengthTimePerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthTimePerMass o1, PerTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(PerTimeSqr o1, LengthTimePerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(LengthTimePerMass o1, PerTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(PerTimeSqr o1, Acceleration o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(Acceleration o1, PerTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerTimeSqr o1, TimeSqrLength o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeSqrLength o1, PerTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(PerTimeSqr o1, LengthMassPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthMassPerTime o1, PerTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator/(PerTimeSqr o1, LengthMassPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(LengthMassPerTime o1, PerTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(PerTimeSqr o1, LengthMassTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthMassTime o1, PerTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator/(PerTimeSqr o1, LengthMassTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(LengthMassTime o1, PerTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerTimeSqr o1, LengthSqrPerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthSqrPerMass o1, PerTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(PerTimeSqr o1, LengthSqrPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(LengthSqrPerMass o1, PerTimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(PerTimeSqr o1, LengthSqrPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthSqrPerTime o1, PerTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator/(PerTimeSqr o1, LengthSqrPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthSqrPerTime o1, PerTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(PerTimeSqr o1, LengthSqrTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrTime o1, PerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerTimeSqr o1, LengthSqrTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(LengthSqrTime o1, PerTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(PerTimeSqr o1, LengthSqrMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthSqrMass o1, PerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerTimeSqr o1, LengthSqrMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(LengthSqrMass o1, PerTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(PerTimeSqr o1, Volume o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(Volume o1, PerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerTimeSqr o1, Volume o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(Volume o1, PerTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerTimeSqr o1, PerMassLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerMassLengthCub o1, PerTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(PerTimeSqr o1, PerMassLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(PerMassLengthCub o1, PerTimeSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerTimeSqr o1, PerTimeLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerTimeLengthCub o1, PerTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator/(PerTimeSqr o1, PerTimeLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(PerTimeLengthCub o1, PerTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(PerTimeSqr o1, TimePerLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(TimePerLengthCub o1, PerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator/(PerTimeSqr o1, TimePerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthCub operator/(TimePerLengthCub o1, PerTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(PerTimeSqr o1, Density o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(Density o1, PerTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(PerTimeSqr o1, Density o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(Density o1, PerTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerTimeSqr o1, PerMassTimeLengthSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(PerMassTimeLengthSqr o1, PerTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator/(PerTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(PerMassTimeLengthSqr o1, PerTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(PerTimeSqr o1, TimePerMassLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(TimePerMassLengthSqr o1, PerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(PerTimeSqr o1, TimePerMassLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimePerMassLengthSqr o1, PerTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(PerTimeSqr o1, PerLengthSqrTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerLengthSqrTimeSqr o1, PerTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(PerTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeSqrPerLengthSqr o1, PerTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerTimeSqr o1, MassPerTimeLengthSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(MassPerTimeLengthSqr o1, PerTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator/(PerTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerTimeLengthSqr o1, PerTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerTimeSqr o1, MassTimePerLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassTimePerLengthSqr o1, PerTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(PerTimeSqr o1, MassTimePerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(MassTimePerLengthSqr o1, PerTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthMass operator/(PerTimeSqr o1, PerLengthMassTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerLengthMassTimeSqr o1, PerTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerTimeSqr o1, TimeSqrPerLengthMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeSqrPerLengthMass o1, PerTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(PerTimeSqr o1, PerLengthTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerLengthTimeCub o1, PerTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerTimeSqr o1, TimeCubPerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubPerLength o1, PerTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator/(PerTimeSqr o1, MassPerLengthTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerLengthTimeSqr o1, PerTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerTimeSqr o1, TimeSqrMassPerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeSqrMassPerLength o1, PerTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(PerTimeSqr o1, PerMassTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerMassTimeCub o1, PerTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerTimeSqr o1, TimeCubPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubPerMass o1, PerTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator/(PerTimeSqr o1, MassPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerTimeCub o1, PerTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(PerTimeSqr o1, TimeCubMass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(TimeCubMass o1, PerTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(PerTimeSqr o1, LengthPerMassTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthPerMassTimeSqr o1, PerTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerTimeSqr o1, TimeSqrLengthPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(TimeSqrLengthPerMass o1, PerTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(PerTimeSqr o1, LengthPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthPerTimeCub o1, PerTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(PerTimeSqr o1, TimeCubLength o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(TimeCubLength o1, PerTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(PerTimeSqr o1, Force o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(Force o1, PerTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(PerTimeSqr o1, TimeSqrLengthMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(TimeSqrLengthMass o1, PerTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerTimeSqr o1, LengthSqrPerMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthSqrPerMassTime o1, PerTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerTimeSqr o1, LengthSqrPerMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthSqrPerMassTime o1, PerTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerTimeSqr o1, LengthSqrTimePerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthSqrTimePerMass o1, PerTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerTimeSqr o1, LengthSqrTimePerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(LengthSqrTimePerMass o1, PerTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(PerTimeSqr o1, QDose o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(QDose o1, PerTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Area operator*(PerTimeSqr o1, LengthSqrTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrTimeSqr o1, PerTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(PerTimeSqr o1, LengthSqrMassPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthSqrMassPerTime o1, PerTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerTimeSqr o1, LengthSqrMassPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(LengthSqrMassPerTime o1, PerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(PerTimeSqr o1, LengthSqrMassTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthSqrMassTime o1, PerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerTimeSqr o1, LengthSqrMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(LengthSqrMassTime o1, PerTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator*(PerTimeSqr o1, LengthCubPerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator*(LengthCubPerMass o1, PerTimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerTimeSqr o1, LengthCubPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthCubPerMass o1, PerTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator*(PerTimeSqr o1, LengthCubPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator*(LengthCubPerTime o1, PerTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator/(PerTimeSqr o1, LengthCubPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubPerTime o1, PerTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(PerTimeSqr o1, LengthCubTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubTime o1, PerTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerTimeSqr o1, LengthCubTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthCubTime o1, PerTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(PerTimeSqr o1, LengthCubMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(LengthCubMass o1, PerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerTimeSqr o1, LengthCubMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthCubMass o1, PerTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerTimeSqr o1, PerMassTimeLengthCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerMassTimeLengthCub o1, PerTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator/(PerTimeSqr o1, PerMassTimeLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(PerMassTimeLengthCub o1, PerTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerTimeSqr o1, TimePerMassLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(TimePerMassLengthCub o1, PerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator/(PerTimeSqr o1, TimePerMassLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimePerMassLengthCub o1, PerTimeSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static Volume operator/(PerTimeSqr o1, PerTimeSqrLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(PerTimeSqrLengthCub o1, PerTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerTimeSqr o1, TimeSqrPerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeSqrPerLengthCub o1, PerTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerTimeSqr o1, MassPerTimeLengthCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(MassPerTimeLengthCub o1, PerTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator/(PerTimeSqr o1, MassPerTimeLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(MassPerTimeLengthCub o1, PerTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerTimeSqr o1, MassTimePerLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassTimePerLengthCub o1, PerTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator/(PerTimeSqr o1, MassTimePerLengthCub o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthCub operator/(MassTimePerLengthCub o1, PerTimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator/(PerTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerMassLengthSqrTimeSqr o1, PerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(TimeSqrPerMassLengthSqr o1, PerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(PerTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerLengthSqrTimeCub o1, PerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(PerTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeCubPerLengthSqr o1, PerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator/(PerTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(MassPerLengthSqrTimeSqr o1, PerTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(PerTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimeSqrMassPerLengthSqr o1, PerTimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(PerTimeSqr o1, PerLengthMassTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerLengthMassTimeCub o1, PerTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeCubPerLengthMass o1, PerTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator/(PerTimeSqr o1, MassPerLengthTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerLengthTimeCub o1, PerTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(PerTimeSqr o1, TimeCubMassPerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeCubMassPerLength o1, PerTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator/(PerTimeSqr o1, LengthPerMassTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthPerMassTimeCub o1, PerTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(PerTimeSqr o1, TimeCubLengthPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeCubLengthPerMass o1, PerTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator/(PerTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthMassPerTimeCub o1, PerTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(PerTimeSqr o1, TimeCubLengthMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(TimeCubLengthMass o1, PerTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(PerTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthSqrPerMassTimeSqr o1, PerTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(PerTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthSqrTimeSqrPerMass o1, PerTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(PerTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrPerTimeCub o1, PerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(PerTimeSqr o1, TimeCubLengthSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(TimeCubLengthSqr o1, PerTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(PerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrMassPerTimeSqr o1, PerTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(PerTimeSqr o1, LengthSqrTimeSqrMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthSqrTimeSqrMass o1, PerTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTimeCub operator*(PerTimeSqr o1, LengthCubPerMassTime o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator*(LengthCubPerMassTime o1, PerTimeSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(PerTimeSqr o1, LengthCubPerMassTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubPerMassTime o1, PerTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(PerTimeSqr o1, LengthCubTimePerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthCubTimePerMass o1, PerTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerTimeSqr o1, LengthCubTimePerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(LengthCubTimePerMass o1, PerTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(PerTimeSqr o1, LengthCubPerTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubPerTimeSqr o1, PerTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Volume operator*(PerTimeSqr o1, LengthCubTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubTimeSqr o1, PerTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeCub operator*(PerTimeSqr o1, LengthCubMassPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator*(LengthCubMassPerTime o1, PerTimeSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(PerTimeSqr o1, LengthCubMassPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthCubMassPerTime o1, PerTimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(PerTimeSqr o1, LengthCubMassTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubMassTime o1, PerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerTimeSqr o1, LengthCubMassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(LengthCubMassTime o1, PerTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator/(PerTimeSqr o1, PerMassTimeSqrLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(PerMassTimeSqrLengthCub o1, PerTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerTimeSqr o1, TimeSqrPerMassLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimeSqrPerMassLengthCub o1, PerTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator/(PerTimeSqr o1, PerLengthCubTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(PerLengthCubTimeCub o1, PerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerTimeSqr o1, TimeCubPerLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeCubPerLengthCub o1, PerTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMass operator/(PerTimeSqr o1, MassPerTimeSqrLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(MassPerTimeSqrLengthCub o1, PerTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerTimeSqr o1, TimeSqrMassPerLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(TimeSqrMassPerLengthCub o1, PerTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(PerTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerMassLengthSqrTimeCub o1, PerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerTimeSqr o1, TimeCubPerMassLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeCubPerMassLengthSqr o1, PerTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimePerMass operator/(PerTimeSqr o1, MassPerLengthSqrTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerLengthSqrTimeCub o1, PerTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerTimeSqr o1, TimeCubMassPerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeCubMassPerLengthSqr o1, PerTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator/(PerTimeSqr o1, LengthSqrPerMassTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthSqrPerMassTimeCub o1, PerTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(PerTimeSqr o1, TimeCubLengthSqrPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(TimeCubLengthSqrPerMass o1, PerTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerMassLengthSqr operator/(PerTimeSqr o1, LengthSqrMassPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthSqrMassPerTimeCub o1, PerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(PerTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(TimeCubLengthSqrMass o1, PerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static Density operator/(PerTimeSqr o1, LengthCubPerMassTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubPerMassTimeSqr o1, PerTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(PerTimeSqr o1, LengthCubTimeSqrPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubTimeSqrPerMass o1, PerTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerTimeSqr o1, LengthCubPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubPerTimeCub o1, PerTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(PerTimeSqr o1, LengthCubTimeCub o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubTimeCub o1, PerTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(PerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubMassPerTimeSqr o1, PerTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(PerTimeSqr o1, LengthCubTimeSqrMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubTimeSqrMass o1, PerTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		
		public static LengthCubMassTime operator/(PerTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerMassLengthCubTimeCub o1, PerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerTimeSqr o1, TimeCubPerMassLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimeCubPerMassLengthCub o1, PerTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubTimePerMass operator/(PerTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(MassPerLengthCubTimeCub o1, PerTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(PerTimeSqr o1, TimeCubMassPerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimeCubMassPerLengthCub o1, PerTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthCub operator/(PerTimeSqr o1, LengthCubPerMassTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthCubPerMassTimeCub o1, PerTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(PerTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthCubTimeCubPerMass o1, PerTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerMassLengthCub operator/(PerTimeSqr o1, LengthCubMassPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthCubMassPerTimeCub o1, PerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(PerTimeSqr o1, LengthCubTimeCubMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthCubTimeCubMass o1, PerTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTimeSqr pertimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertimesqr.HasMinValue && pertimesqr.Value_ < pertimesqr.MinValue)
        {
            fail = true;
        }

        if (pertimesqr.HasMaxValue && pertimesqr.Value_ > pertimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTimeSqr is outside its bounds.");
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
    