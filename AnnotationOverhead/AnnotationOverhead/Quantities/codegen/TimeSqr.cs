
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeSqr : Quantity, IEquatable<TimeSqr>, IComparable
    {
    internal TimeSqr(double value) : base(value, 2)
    {
        TimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal TimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeSqr(TimeSqr other) : base(other)
    {
        TimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqr"))
        {
            switch(FakeDatabase.Units["TimeSqr"])
            {
				      case "secondsqr": displayUnit_ = secondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondsqr_ = new Unit_("SecondSqr", "s²", 1);
	private static Unit_ platformUnit_ = secondsqr_;
	private static Unit_ displayUnit_ = secondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(TimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeSqr other)) throw new ArgumentException("Object is not a TimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeSqr l1, TimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeSqr l1, TimeSqr l2) => !(l1 == l2);
    public static bool operator <(TimeSqr l1, TimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeSqr l1, TimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeSqr l1, TimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeSqr l1, TimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeSqr FromSecondSqrs(double value, double minValue, double maxValue) => new TimeSqr(value * secondsqr_.Factor, minValue * secondsqr_.Factor, maxValue * secondsqr_.Factor);
		public static TimeSqr FromSecondSqrs(double value) => new TimeSqr(value * secondsqr_.Factor);
		public double GetValueInSecondSqrs() => Value_ / secondsqr_.Factor;

#endregion

#region arithmetic
		public static TimeSqr operator+(TimeSqr o1, TimeSqr o2) => new TimeSqr(o1.Value_ + o2.Value_);
		public static TimeSqr operator-(TimeSqr o1, TimeSqr o2) => new TimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeSqr o1, TimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(TimeSqr o1, MassPerTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(MassPerTime o1, TimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator/(TimeSqr o1, MassPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(MassPerTime o1, TimeSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator*(TimeSqr o1, MassTime o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(MassTime o1, TimeSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator/(TimeSqr o1, MassTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassTime o1, TimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(TimeSqr o1, LengthPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthPerMass o1, TimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(TimeSqr o1, LengthPerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthPerMass o1, TimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(TimeSqr o1, Speed o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(Speed o1, TimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator/(TimeSqr o1, Speed o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(Speed o1, TimeSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator*(TimeSqr o1, LengthTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthTime o1, TimeSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator/(TimeSqr o1, LengthTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthTime o1, TimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(TimeSqr o1, LengthMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthMass o1, TimeSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeSqr o1, LengthMass o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthMass o1, TimeSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(TimeSqr o1, Area o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(Area o1, TimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeSqr o1, Area o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(Area o1, TimeSqr o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(TimeSqr o1, PerLengthCub o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(PerLengthCub o1, TimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator/(TimeSqr o1, PerLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerLengthCub o1, TimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(TimeSqr o1, PerMassLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(PerMassLengthSqr o1, TimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator/(TimeSqr o1, PerMassLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerMassLengthSqr o1, TimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(TimeSqr o1, PerTimeLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(PerTimeLengthSqr o1, TimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator/(TimeSqr o1, PerTimeLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerTimeLengthSqr o1, TimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(TimeSqr o1, TimePerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimePerLengthSqr o1, TimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator/(TimeSqr o1, TimePerLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(TimePerLengthSqr o1, TimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(TimeSqr o1, MassPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(MassPerLengthSqr o1, TimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeSqr o1, MassPerLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(MassPerLengthSqr o1, TimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(TimeSqr o1, PerLengthMassTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(PerLengthMassTime o1, TimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(TimeSqr o1, PerLengthMassTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthMassTime o1, TimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator*(TimeSqr o1, TimePerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimePerLengthMass o1, TimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static LengthMassTime operator/(TimeSqr o1, TimePerLengthMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(TimePerLengthMass o1, TimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(TimeSqr o1, PerLengthTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerLengthTimeSqr o1, TimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static Length operator/(TimeSqr o1, TimeSqrPerLength o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeSqrPerLength o1, TimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(TimeSqr o1, MassPerLengthTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassPerLengthTime o1, TimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeSqr o1, MassPerLengthTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(MassPerLengthTime o1, TimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(TimeSqr o1, MassTimePerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(MassTimePerLength o1, TimeSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator/(TimeSqr o1, MassTimePerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassTimePerLength o1, TimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(TimeSqr o1, PerMassTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerMassTimeSqr o1, TimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Mass operator/(TimeSqr o1, TimeSqrPerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(TimeSqrPerMass o1, TimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimeSqr o1, PerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerTimeCub o1, TimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(TimeSqr o1, TimeCub o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCub o1, TimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		
		public static Mass operator*(TimeSqr o1, MassPerTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerTimeSqr o1, TimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(TimeSqr o1, TimeSqrMass o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(TimeSqrMass o1, TimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(TimeSqr o1, LengthPerMassTime o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthPerMassTime o1, TimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(TimeSqr o1, LengthPerMassTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(LengthPerMassTime o1, TimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator*(TimeSqr o1, LengthTimePerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(LengthTimePerMass o1, TimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(TimeSqr o1, LengthTimePerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthTimePerMass o1, TimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimeSqr o1, Acceleration o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(Acceleration o1, TimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(TimeSqr o1, TimeSqrLength o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(TimeSqrLength o1, TimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(TimeSqr o1, LengthMassPerTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthMassPerTime o1, TimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeSqr o1, LengthMassPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(LengthMassPerTime o1, TimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(TimeSqr o1, LengthMassTime o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(LengthMassTime o1, TimeSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(TimeSqr o1, LengthMassTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthMassTime o1, TimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator*(TimeSqr o1, LengthSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator*(LengthSqrPerMass o1, TimeSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(TimeSqr o1, LengthSqrPerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthSqrPerMass o1, TimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(TimeSqr o1, LengthSqrPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthSqrPerTime o1, TimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeSqr o1, LengthSqrPerTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthSqrPerTime o1, TimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator*(TimeSqr o1, LengthSqrTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthSqrTime o1, TimeSqr o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator/(TimeSqr o1, LengthSqrTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrTime o1, TimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(TimeSqr o1, LengthSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthSqrMass o1, TimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeSqr o1, LengthSqrMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(LengthSqrMass o1, TimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(TimeSqr o1, Volume o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(Volume o1, TimeSqr o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator/(TimeSqr o1, Volume o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(Volume o1, TimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(TimeSqr o1, PerMassLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(PerMassLengthCub o1, TimeSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator/(TimeSqr o1, PerMassLengthCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerMassLengthCub o1, TimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(TimeSqr o1, PerTimeLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(PerTimeLengthCub o1, TimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator/(TimeSqr o1, PerTimeLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		public static PerLengthCubTimeCub operator/(PerTimeLengthCub o1, TimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator*(TimeSqr o1, TimePerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimePerLengthCub o1, TimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTime operator/(TimeSqr o1, TimePerLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(TimePerLengthCub o1, TimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(TimeSqr o1, Density o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(Density o1, TimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(TimeSqr o1, Density o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(Density o1, TimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(TimeSqr o1, PerMassTimeLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(PerMassTimeLengthSqr o1, TimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeSqr o1, PerMassTimeLengthSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(TimeSqr o1, TimePerMassLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimePerMassLengthSqr o1, TimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator/(TimeSqr o1, TimePerMassLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(TimePerMassLengthSqr o1, TimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(TimeSqr o1, PerLengthSqrTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(PerLengthSqrTimeSqr o1, TimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static Area operator/(TimeSqr o1, TimeSqrPerLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimeSqrPerLengthSqr o1, TimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(TimeSqr o1, MassPerTimeLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(MassPerTimeLengthSqr o1, TimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeSqr o1, MassPerTimeLengthSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerTimeLengthSqr o1, TimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(TimeSqr o1, MassTimePerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(MassTimePerLengthSqr o1, TimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator/(TimeSqr o1, MassTimePerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassTimePerLengthSqr o1, TimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(TimeSqr o1, PerLengthMassTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerLengthMassTimeSqr o1, TimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthMass operator/(TimeSqr o1, TimeSqrPerLengthMass o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(TimeSqrPerLengthMass o1, TimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimeSqr o1, PerLengthTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerLengthTimeCub o1, TimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static Speed operator/(TimeSqr o1, TimeCubPerLength o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeCubPerLength o1, TimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(TimeSqr o1, MassPerLengthTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(MassPerLengthTimeSqr o1, TimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator/(TimeSqr o1, TimeSqrMassPerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(TimeSqrMassPerLength o1, TimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(TimeSqr o1, PerMassTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(PerMassTimeCub o1, TimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator/(TimeSqr o1, TimeCubPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMass operator/(TimeCubPerMass o1, TimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(TimeSqr o1, MassPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(MassPerTimeCub o1, TimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator/(TimeSqr o1, TimeCubMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimeCubMass o1, TimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(TimeSqr o1, LengthPerMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthPerMassTimeSqr o1, TimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(TimeSqr o1, TimeSqrLengthPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(TimeSqrLengthPerMass o1, TimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static Speed operator*(TimeSqr o1, LengthPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthPerTimeCub o1, TimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(TimeSqr o1, TimeCubLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeCubLength o1, TimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(TimeSqr o1, Force o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(Force o1, TimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(TimeSqr o1, TimeSqrLengthMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(TimeSqrLengthMass o1, TimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(TimeSqr o1, LengthSqrPerMassTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthSqrPerMassTime o1, TimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(TimeSqr o1, LengthSqrPerMassTime o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(LengthSqrPerMassTime o1, TimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator*(TimeSqr o1, LengthSqrTimePerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator*(LengthSqrTimePerMass o1, TimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(TimeSqr o1, LengthSqrTimePerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthSqrTimePerMass o1, TimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(TimeSqr o1, QDose o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(QDose o1, TimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(TimeSqr o1, LengthSqrTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrTimeSqr o1, TimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(TimeSqr o1, LengthSqrMassPerTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthSqrMassPerTime o1, TimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimeSqr o1, LengthSqrMassPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(LengthSqrMassPerTime o1, TimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(TimeSqr o1, LengthSqrMassTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthSqrMassTime o1, TimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeSqr o1, LengthSqrMassTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthSqrMassTime o1, TimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator*(TimeSqr o1, LengthCubPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator*(LengthCubPerMass o1, TimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(TimeSqr o1, LengthCubPerMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthCubPerMass o1, TimeSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(TimeSqr o1, LengthCubPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubPerTime o1, TimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator/(TimeSqr o1, LengthCubPerTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthCubPerTime o1, TimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCub operator*(TimeSqr o1, LengthCubTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator*(LengthCubTime o1, TimeSqr o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator/(TimeSqr o1, LengthCubTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubTime o1, TimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrMass operator*(TimeSqr o1, LengthCubMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator*(LengthCubMass o1, TimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(TimeSqr o1, LengthCubMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthCubMass o1, TimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(TimeSqr o1, PerMassTimeLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(PerMassTimeLengthCub o1, TimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator/(TimeSqr o1, PerMassTimeLengthCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerMassTimeLengthCub o1, TimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(TimeSqr o1, TimePerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimePerMassLengthCub o1, TimeSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator/(TimeSqr o1, TimePerMassLengthCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(TimePerMassLengthCub o1, TimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(TimeSqr o1, PerTimeSqrLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerTimeSqrLengthCub o1, TimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static Volume operator/(TimeSqr o1, TimeSqrPerLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(TimeSqrPerLengthCub o1, TimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(TimeSqr o1, MassPerTimeLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(MassPerTimeLengthCub o1, TimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeSqr o1, MassPerTimeLengthCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthCubTimeCub operator/(MassPerTimeLengthCub o1, TimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(TimeSqr o1, MassTimePerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(MassTimePerLengthCub o1, TimeSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator/(TimeSqr o1, MassTimePerLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(MassTimePerLengthCub o1, TimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(TimeSqr o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(PerMassLengthSqrTimeSqr o1, TimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(TimeSqr o1, TimeSqrPerMassLengthSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimeSqrPerMassLengthSqr o1, TimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(TimeSqr o1, PerLengthSqrTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthSqrTimeCub o1, TimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(TimeSqr o1, TimeCubPerLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeCubPerLengthSqr o1, TimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(TimeSqr o1, MassPerLengthSqrTimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(MassPerLengthSqrTimeSqr o1, TimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator/(TimeSqr o1, TimeSqrMassPerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(TimeSqrMassPerLengthSqr o1, TimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(TimeSqr o1, PerLengthMassTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(PerLengthMassTimeCub o1, TimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(TimeSqr o1, TimeCubPerLengthMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeCubPerLengthMass o1, TimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(TimeSqr o1, MassPerLengthTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassPerLengthTimeCub o1, TimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator/(TimeSqr o1, TimeCubMassPerLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(TimeCubMassPerLength o1, TimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(TimeSqr o1, LengthPerMassTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthPerMassTimeCub o1, TimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator/(TimeSqr o1, TimeCubLengthPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(TimeCubLengthPerMass o1, TimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(TimeSqr o1, LengthMassPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthMassPerTimeCub o1, TimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTime operator/(TimeSqr o1, TimeCubLengthMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(TimeCubLengthMass o1, TimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(TimeSqr o1, LengthSqrPerMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthSqrPerMassTimeSqr o1, TimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(TimeSqr o1, LengthSqrTimeSqrPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthSqrTimeSqrPerMass o1, TimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(TimeSqr o1, LengthSqrPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrPerTimeCub o1, TimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(TimeSqr o1, TimeCubLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(TimeCubLengthSqr o1, TimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(TimeSqr o1, LengthSqrMassPerTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthSqrMassPerTimeSqr o1, TimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(TimeSqr o1, LengthSqrTimeSqrMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrTimeSqrMass o1, TimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(TimeSqr o1, LengthCubPerMassTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthCubPerMassTime o1, TimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(TimeSqr o1, LengthCubPerMassTime o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthCubPerMassTime o1, TimeSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubPerMass operator*(TimeSqr o1, LengthCubTimePerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator*(LengthCubTimePerMass o1, TimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(TimeSqr o1, LengthCubTimePerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthCubTimePerMass o1, TimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(TimeSqr o1, LengthCubPerTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubPerTimeSqr o1, TimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(TimeSqr o1, LengthCubTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubTimeSqr o1, TimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(TimeSqr o1, LengthCubMassPerTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthCubMassPerTime o1, TimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimeSqr o1, LengthCubMassPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthCubMassPerTime o1, TimeSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubMass operator*(TimeSqr o1, LengthCubMassTime o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubMass operator*(LengthCubMassTime o1, TimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(TimeSqr o1, LengthCubMassTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthCubMassTime o1, TimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(TimeSqr o1, PerMassTimeSqrLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(PerMassTimeSqrLengthCub o1, TimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMass operator/(TimeSqr o1, TimeSqrPerMassLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(TimeSqrPerMassLengthCub o1, TimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(TimeSqr o1, PerLengthCubTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerLengthCubTimeCub o1, TimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTime operator/(TimeSqr o1, TimeCubPerLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(TimeCubPerLengthCub o1, TimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static Density operator*(TimeSqr o1, MassPerTimeSqrLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(MassPerTimeSqrLengthCub o1, TimeSqr o2) => new Density(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMass operator/(TimeSqr o1, TimeSqrMassPerLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(TimeSqrMassPerLengthCub o1, TimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(TimeSqr o1, PerMassLengthSqrTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerMassLengthSqrTimeCub o1, TimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator/(TimeSqr o1, TimeCubPerMassLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeCubPerMassLengthSqr o1, TimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(TimeSqr o1, MassPerLengthSqrTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassPerLengthSqrTimeCub o1, TimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator/(TimeSqr o1, TimeCubMassPerLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(TimeCubMassPerLengthSqr o1, TimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(TimeSqr o1, LengthSqrPerMassTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthSqrPerMassTimeCub o1, TimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthSqr operator/(TimeSqr o1, TimeCubLengthSqrPerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(TimeCubLengthSqrPerMass o1, TimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(TimeSqr o1, LengthSqrMassPerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthSqr operator/(TimeSqr o1, TimeCubLengthSqrMass o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(TimeCubLengthSqrMass o1, TimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(TimeSqr o1, LengthCubPerMassTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubPerMassTimeSqr o1, TimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		
		public static Density operator/(TimeSqr o1, LengthCubTimeSqrPerMass o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubTimeSqrPerMass o1, TimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(TimeSqr o1, LengthCubPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubPerTimeCub o1, TimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(TimeSqr o1, LengthCubTimeCub o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubTimeCub o1, TimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(TimeSqr o1, LengthCubMassPerTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubMassPerTimeSqr o1, TimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(TimeSqr o1, LengthCubTimeSqrMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubTimeSqrMass o1, TimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(TimeSqr o1, PerMassLengthCubTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerMassLengthCubTimeCub o1, TimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTime operator/(TimeSqr o1, TimeCubPerMassLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(TimeCubPerMassLengthCub o1, TimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(TimeSqr o1, MassPerLengthCubTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassPerLengthCubTimeCub o1, TimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTime operator/(TimeSqr o1, TimeCubMassPerLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(TimeCubMassPerLengthCub o1, TimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(TimeSqr o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthCubPerMassTimeCub o1, TimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator/(TimeSqr o1, LengthCubTimeCubPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubTimeCubPerMass o1, TimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(TimeSqr o1, LengthCubMassPerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthCub operator/(TimeSqr o1, LengthCubTimeCubMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthCubTimeCubMass o1, TimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeSqr timesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (timesqr.HasMinValue && timesqr.Value_ < timesqr.MinValue)
        {
            fail = true;
        }

        if (timesqr.HasMaxValue && timesqr.Value_ > timesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeSqr is outside its bounds.");
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
    