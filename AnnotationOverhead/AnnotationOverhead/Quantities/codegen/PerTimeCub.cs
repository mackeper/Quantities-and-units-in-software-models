
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTimeCub : Quantity, IEquatable<PerTimeCub>, IComparable
    {
    internal PerTimeCub(double value) : base(value, 2)
    {
        PerTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTimeCub(PerTimeCub other) : base(other)
    {
        PerTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTimeCub"))
        {
            switch(FakeDatabase.Units["PerTimeCub"])
            {
				      case "persecond": displayUnit_ = persecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ persecond_ = new Unit_("PerSecond", "/s", 1.0);
	private static Unit_ platformUnit_ = persecond_;
	private static Unit_ displayUnit_ = persecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTimeCub other)) throw new ArgumentException("Object is not a PerTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTimeCub l1, PerTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTimeCub l1, PerTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerTimeCub l1, PerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTimeCub l1, PerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTimeCub l1, PerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTimeCub l1, PerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTimeCub FromPerSeconds(double value, double minValue, double maxValue) => new PerTimeCub(value * persecond_.Factor, minValue * persecond_.Factor, maxValue * persecond_.Factor);
		public static PerTimeCub FromPerSeconds(double value) => new PerTimeCub(value * persecond_.Factor);
		public double GetValueInPerSeconds() => Value_ / persecond_.Factor;

#endregion

#region arithmetic
		public static PerTimeCub operator+(PerTimeCub o1, PerTimeCub o2) => new PerTimeCub(o1.Value_ + o2.Value_);
		public static PerTimeCub operator-(PerTimeCub o1, PerTimeCub o2) => new PerTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTimeCub o1, PerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerTimeCub o1, TimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeCub o1, PerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator/(PerTimeCub o1, MassPerTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerTimeSqr o1, PerTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(PerTimeCub o1, TimeSqrMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(TimeSqrMass o1, PerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(PerTimeCub o1, LengthPerMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(LengthPerMassTime o1, PerTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerTimeCub o1, LengthTimePerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthTimePerMass o1, PerTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(PerTimeCub o1, Acceleration o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(Acceleration o1, PerTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerTimeCub o1, TimeSqrLength o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(TimeSqrLength o1, PerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(PerTimeCub o1, LengthMassPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(LengthMassPerTime o1, PerTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static Force operator*(PerTimeCub o1, LengthMassTime o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthMassTime o1, PerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerTimeCub o1, LengthSqrPerMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthSqrPerMass o1, PerTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerTimeCub o1, LengthSqrPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(LengthSqrPerMass o1, PerTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(PerTimeCub o1, LengthSqrPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(LengthSqrPerTime o1, PerTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator*(PerTimeCub o1, LengthSqrTime o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthSqrTime o1, PerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(PerTimeCub o1, LengthSqrMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthSqrMass o1, PerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerTimeCub o1, LengthSqrMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(LengthSqrMass o1, PerTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator*(PerTimeCub o1, Volume o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator*(Volume o1, PerTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerTimeCub o1, Volume o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(Volume o1, PerTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerTimeCub o1, PerMassLengthCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerMassLengthCub o1, PerTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator/(PerTimeCub o1, PerMassLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthCub operator/(PerMassLengthCub o1, PerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(PerTimeCub o1, PerTimeLengthCub o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(PerTimeLengthCub o1, PerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(PerTimeCub o1, TimePerLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(TimePerLengthCub o1, PerTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerTimeCub o1, Density o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(Density o1, PerTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator/(PerTimeCub o1, Density o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthCub operator/(Density o1, PerTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(PerTimeCub o1, PerMassTimeLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerMassTimeLengthSqr o1, PerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(PerTimeCub o1, TimePerMassLengthSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(TimePerMassLengthSqr o1, PerTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(PerTimeCub o1, PerLengthSqrTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerLengthSqrTimeSqr o1, PerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(PerTimeCub o1, TimeSqrPerLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(TimeSqrPerLengthSqr o1, PerTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(PerTimeCub o1, MassPerTimeLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(MassPerTimeLengthSqr o1, PerTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(PerTimeCub o1, MassTimePerLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(MassTimePerLengthSqr o1, PerTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(PerTimeCub o1, PerLengthMassTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(PerLengthMassTimeSqr o1, PerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(PerTimeCub o1, TimeSqrPerLengthMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(TimeSqrPerLengthMass o1, PerTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerTimeCub o1, PerLengthTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthTimeCub o1, PerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(PerTimeCub o1, TimeCubPerLength o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimeCubPerLength o1, PerTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator/(PerTimeCub o1, MassPerLengthTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassPerLengthTimeSqr o1, PerTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(PerTimeCub o1, TimeSqrMassPerLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(TimeSqrMassPerLength o1, PerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		
		public static Mass operator/(PerTimeCub o1, PerMassTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassTimeCub o1, PerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerTimeCub o1, TimeCubPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeCubPerMass o1, PerTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(PerTimeCub o1, MassPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerTimeCub o1, PerTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static Mass operator*(PerTimeCub o1, TimeCubMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeCubMass o1, PerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator/(PerTimeCub o1, LengthPerMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(LengthPerMassTimeSqr o1, PerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(PerTimeCub o1, TimeSqrLengthPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(TimeSqrLengthPerMass o1, PerTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(PerTimeCub o1, LengthPerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthPerTimeCub o1, PerTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerTimeCub o1, TimeCubLength o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeCubLength o1, PerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTime operator/(PerTimeCub o1, Force o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(Force o1, PerTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(PerTimeCub o1, TimeSqrLengthMass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(TimeSqrLengthMass o1, PerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator/(PerTimeCub o1, LengthSqrPerMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(LengthSqrPerMassTime o1, PerTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerTimeCub o1, LengthSqrTimePerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthSqrTimePerMass o1, PerTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(PerTimeCub o1, QDose o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(QDose o1, PerTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(PerTimeCub o1, LengthSqrTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrTimeSqr o1, PerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator/(PerTimeCub o1, LengthSqrMassPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(LengthSqrMassPerTime o1, PerTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(PerTimeCub o1, LengthSqrMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthSqrMassTime o1, PerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTimeCub operator*(PerTimeCub o1, LengthCubPerMass o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeCub operator*(LengthCubPerMass o1, PerTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerTimeCub o1, LengthCubPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(LengthCubPerMass o1, PerTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(PerTimeCub o1, LengthCubPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthCubPerTime o1, PerTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(PerTimeCub o1, LengthCubTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthCubTime o1, PerTimeCub o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeCub operator*(PerTimeCub o1, LengthCubMass o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator*(LengthCubMass o1, PerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerTimeCub o1, LengthCubMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(LengthCubMass o1, PerTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator/(PerTimeCub o1, PerMassTimeLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(PerMassTimeLengthCub o1, PerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerTimeCub o1, TimePerMassLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(TimePerMassLengthCub o1, PerTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTime operator/(PerTimeCub o1, PerTimeSqrLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(PerTimeSqrLengthCub o1, PerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(PerTimeCub o1, TimeSqrPerLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(TimeSqrPerLengthCub o1, PerTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator/(PerTimeCub o1, MassPerTimeLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(MassPerTimeLengthCub o1, PerTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(PerTimeCub o1, MassTimePerLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(MassTimePerLengthCub o1, PerTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator/(PerTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(PerMassLengthSqrTimeSqr o1, PerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(PerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(TimeSqrPerMassLengthSqr o1, PerTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static Area operator/(PerTimeCub o1, PerLengthSqrTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerLengthSqrTimeCub o1, PerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(PerTimeCub o1, TimeCubPerLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeCubPerLengthSqr o1, PerTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator/(PerTimeCub o1, MassPerLengthSqrTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerLengthSqrTimeSqr o1, PerTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerTimeCub o1, TimeSqrMassPerLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(TimeSqrMassPerLengthSqr o1, PerTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthMass operator/(PerTimeCub o1, PerLengthMassTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerLengthMassTimeCub o1, PerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerTimeCub o1, TimeCubPerLengthMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeCubPerLengthMass o1, PerTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator/(PerTimeCub o1, MassPerLengthTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerLengthTimeCub o1, PerTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerTimeCub o1, TimeCubMassPerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeCubMassPerLength o1, PerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(PerTimeCub o1, LengthPerMassTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthPerMassTimeCub o1, PerTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerTimeCub o1, TimeCubLengthPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(TimeCubLengthPerMass o1, PerTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(PerTimeCub o1, LengthMassPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthMassPerTimeCub o1, PerTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(PerTimeCub o1, TimeCubLengthMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(TimeCubLengthMass o1, PerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthSqr operator/(PerTimeCub o1, LengthSqrPerMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthSqrPerMassTimeSqr o1, PerTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerTimeCub o1, LengthSqrTimeSqrPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthSqrTimeSqrPerMass o1, PerTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(PerTimeCub o1, LengthSqrPerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrPerTimeCub o1, PerTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Area operator*(PerTimeCub o1, TimeCubLengthSqr o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(TimeCubLengthSqr o1, PerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthSqr operator/(PerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(LengthSqrMassPerTimeSqr o1, PerTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(PerTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthSqrTimeSqrMass o1, PerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator/(PerTimeCub o1, LengthCubPerMassTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthCubPerMassTime o1, PerTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTimeSqr operator*(PerTimeCub o1, LengthCubTimePerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTimeSqr operator*(LengthCubTimePerMass o1, PerTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(PerTimeCub o1, LengthCubPerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubPerTimeSqr o1, PerTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(PerTimeCub o1, LengthCubTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubTimeSqr o1, PerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator/(PerTimeCub o1, LengthCubMassPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthCubMassPerTime o1, PerTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(PerTimeCub o1, LengthCubMassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(LengthCubMassTime o1, PerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTime operator/(PerTimeCub o1, PerMassTimeSqrLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(PerMassTimeSqrLengthCub o1, PerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(TimeSqrPerMassLengthCub o1, PerTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static Volume operator/(PerTimeCub o1, PerLengthCubTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(PerLengthCubTimeCub o1, PerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerTimeCub o1, TimeCubPerLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeCubPerLengthCub o1, PerTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTime operator/(PerTimeCub o1, MassPerTimeSqrLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(MassPerTimeSqrLengthCub o1, PerTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerTimeCub o1, TimeSqrMassPerLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(TimeSqrMassPerLengthCub o1, PerTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(PerTimeCub o1, PerMassLengthSqrTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerMassLengthSqrTimeCub o1, PerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(TimeCubPerMassLengthSqr o1, PerTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator/(PerTimeCub o1, MassPerLengthSqrTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(MassPerLengthSqrTimeCub o1, PerTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(PerTimeCub o1, TimeCubMassPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimeCubMassPerLengthSqr o1, PerTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(PerTimeCub o1, LengthSqrPerMassTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthSqrPerMassTimeCub o1, PerTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(PerTimeCub o1, TimeCubLengthSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(TimeCubLengthSqrPerMass o1, PerTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(PerTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrMassPerTimeCub o1, PerTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(PerTimeCub o1, TimeCubLengthSqrMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(TimeCubLengthSqrMass o1, PerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator/(PerTimeCub o1, LengthCubPerMassTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubPerMassTimeSqr o1, PerTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(PerTimeCub o1, LengthCubTimeSqrPerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthCubTimeSqrPerMass o1, PerTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(PerTimeCub o1, LengthCubPerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubPerTimeCub o1, PerTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Volume operator*(PerTimeCub o1, LengthCubTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubTimeCub o1, PerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthCub operator/(PerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthCubMassPerTimeSqr o1, PerTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(PerTimeCub o1, LengthCubTimeSqrMass o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubTimeSqrMass o1, PerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthCubMass operator/(PerTimeCub o1, PerMassLengthCubTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(PerMassLengthCubTimeCub o1, PerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimeCubPerMassLengthCub o1, PerTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMass operator/(PerTimeCub o1, MassPerLengthCubTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(MassPerLengthCubTimeCub o1, PerTimeCub o2) => new Density(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerTimeCub o1, TimeCubMassPerLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(TimeCubMassPerLengthCub o1, PerTimeCub o2) => new Density(o1.Value_ * o2.Value_);
		
		public static Density operator/(PerTimeCub o1, LengthCubPerMassTimeCub o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubPerMassTimeCub o1, PerTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(PerTimeCub o1, LengthCubTimeCubPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubTimeCubPerMass o1, PerTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(PerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubMassPerTimeCub o1, PerTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(PerTimeCub o1, LengthCubTimeCubMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubTimeCubMass o1, PerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTimeCub pertimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertimecub.HasMinValue && pertimecub.Value_ < pertimecub.MinValue)
        {
            fail = true;
        }

        if (pertimecub.HasMaxValue && pertimecub.Value_ > pertimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTimeCub is outside its bounds.");
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
    