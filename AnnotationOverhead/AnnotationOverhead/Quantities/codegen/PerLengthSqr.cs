
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthSqr : Quantity, IEquatable<PerLengthSqr>, IComparable
    {
    internal PerLengthSqr(double value) : base(value, 2)
    {
        PerLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthSqr(PerLengthSqr other) : base(other)
    {
        PerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthSqr"))
        {
            switch(FakeDatabase.Units["PerLengthSqr"])
            {
				      case "percentimetersqr": displayUnit_ = percentimetersqr_; break;
				      case "permillimetersqr": displayUnit_ = permillimetersqr_; break;
				      case "permetersqr": displayUnit_ = permetersqr_; break;
				      case "perinchsqr": displayUnit_ = perinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetersqr_ = new Unit_("PerCentimeterSqr", "/cm²", 1.0);
	private static Unit_ permillimetersqr_ = new Unit_("PerMillimeterSqr", "/mm²", 0.010000000000000002);
	private static Unit_ permetersqr_ = new Unit_("PerMeterSqr", "/m²", 10000.0);
	private static Unit_ perinchsqr_ = new Unit_("PerInchSqr", "/in²", 6.5536);
	private static Unit_ platformUnit_ = percentimetersqr_;
	private static Unit_ displayUnit_ = percentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthSqr other)) throw new ArgumentException("Object is not a PerLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthSqr l1, PerLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthSqr l1, PerLengthSqr l2) => !(l1 == l2);
    public static bool operator <(PerLengthSqr l1, PerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthSqr l1, PerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthSqr l1, PerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthSqr l1, PerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthSqr FromPerCentimeterSqrs(double value, double minValue, double maxValue) => new PerLengthSqr(value * percentimetersqr_.Factor, minValue * percentimetersqr_.Factor, maxValue * percentimetersqr_.Factor);
		public static PerLengthSqr FromPerCentimeterSqrs(double value) => new PerLengthSqr(value * percentimetersqr_.Factor);
		public double GetValueInPerCentimeterSqrs() => Value_ / percentimetersqr_.Factor;
		public static PerLengthSqr FromPerMillimeterSqrs(double value, double minValue, double maxValue) => new PerLengthSqr(value * permillimetersqr_.Factor, minValue * permillimetersqr_.Factor, maxValue * permillimetersqr_.Factor);
		public static PerLengthSqr FromPerMillimeterSqrs(double value) => new PerLengthSqr(value * permillimetersqr_.Factor);
		public double GetValueInPerMillimeterSqrs() => Value_ / permillimetersqr_.Factor;
		public static PerLengthSqr FromPerMeterSqrs(double value, double minValue, double maxValue) => new PerLengthSqr(value * permetersqr_.Factor, minValue * permetersqr_.Factor, maxValue * permetersqr_.Factor);
		public static PerLengthSqr FromPerMeterSqrs(double value) => new PerLengthSqr(value * permetersqr_.Factor);
		public double GetValueInPerMeterSqrs() => Value_ / permetersqr_.Factor;
		public static PerLengthSqr FromPerInchSqrs(double value, double minValue, double maxValue) => new PerLengthSqr(value * perinchsqr_.Factor, minValue * perinchsqr_.Factor, maxValue * perinchsqr_.Factor);
		public static PerLengthSqr FromPerInchSqrs(double value) => new PerLengthSqr(value * perinchsqr_.Factor);
		public double GetValueInPerInchSqrs() => Value_ / perinchsqr_.Factor;

#endregion

#region arithmetic
		public static PerLengthSqr operator+(PerLengthSqr o1, PerLengthSqr o2) => new PerLengthSqr(o1.Value_ + o2.Value_);
		public static PerLengthSqr operator-(PerLengthSqr o1, PerLengthSqr o2) => new PerLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthSqr o1, PerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerLengthSqr o1, PerLengthMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(PerLengthMass o1, PerLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(PerLengthSqr o1, PerLengthMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerLengthMass o1, PerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(PerLengthSqr o1, PerLengthTime o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerLengthTime o1, PerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLength operator/(PerLengthSqr o1, PerLengthTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthTime o1, PerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerLengthSqr o1, TimePerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimePerLength o1, PerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthTime operator/(PerLengthSqr o1, TimePerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimePerLength o1, PerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerLengthSqr o1, MassPerLength o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(MassPerLength o1, PerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
		public static PerLengthMass operator/(PerLengthSqr o1, MassPerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerLength o1, PerLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(PerLengthSqr o1, PerMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerMassTime o1, PerLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(PerLengthSqr o1, PerMassTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(PerMassTime o1, PerLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerLengthSqr o1, TimePerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimePerMass o1, PerLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerLengthSqr o1, TimePerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(TimePerMass o1, PerLengthSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(PerLengthSqr o1, PerTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerTimeSqr o1, PerLengthSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator/(PerLengthSqr o1, PerTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(PerTimeSqr o1, PerLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerLengthSqr o1, TimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeSqr o1, PerLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerLengthSqr o1, TimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeSqr o1, PerLengthSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerLengthSqr o1, MassPerTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassPerTime o1, PerLengthSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(PerLengthSqr o1, MassPerTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(MassPerTime o1, PerLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerLengthSqr o1, MassTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(MassTime o1, PerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerLengthSqr o1, MassTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(MassTime o1, PerLengthSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerLengthSqr o1, LengthPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(LengthPerMass o1, PerLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static Density operator/(PerLengthSqr o1, LengthPerMass o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthPerMass o1, PerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(PerLengthSqr o1, Speed o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(Speed o1, PerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator/(PerLengthSqr o1, Speed o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(Speed o1, PerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerLengthSqr o1, LengthTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(LengthTime o1, PerLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator/(PerLengthSqr o1, LengthTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthTime o1, PerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerLengthSqr o1, LengthMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(LengthMass o1, PerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(PerLengthSqr o1, LengthMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthMass o1, PerLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLengthSqr o1, Area o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(Area o1, PerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerLengthSqr o1, PerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthCub o1, PerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Mass operator/(PerLengthSqr o1, PerMassLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassLengthSqr o1, PerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerLengthSqr o1, PerTimeLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerTimeLengthSqr o1, PerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(PerLengthSqr o1, TimePerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimePerLengthSqr o1, PerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(PerLengthSqr o1, MassPerLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerLengthSqr o1, PerLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerLengthSqr o1, PerLengthMassTime o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerLengthMassTime o1, PerLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(PerLengthSqr o1, PerLengthMassTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerLengthMassTime o1, PerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerLengthSqr o1, TimePerLengthMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimePerLengthMass o1, PerLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator/(PerLengthSqr o1, TimePerLengthMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(TimePerLengthMass o1, PerLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(PerLengthSqr o1, PerLengthTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerLengthTimeSqr o1, PerLengthSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator/(PerLengthSqr o1, PerLengthTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerLengthTimeSqr o1, PerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(PerLengthSqr o1, TimeSqrPerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeSqrPerLength o1, PerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator/(PerLengthSqr o1, TimeSqrPerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeSqrPerLength o1, PerLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerLengthSqr o1, MassPerLengthTime o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassPerLengthTime o1, PerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(PerLengthSqr o1, MassPerLengthTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerLengthTime o1, PerLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(PerLengthSqr o1, MassTimePerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(MassTimePerLength o1, PerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator/(PerLengthSqr o1, MassTimePerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(MassTimePerLength o1, PerLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(PerLengthSqr o1, PerMassTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerMassTimeSqr o1, PerLengthSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(PerLengthSqr o1, PerMassTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(PerMassTimeSqr o1, PerLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(PerLengthSqr o1, TimeSqrPerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerMass o1, PerLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(PerLengthSqr o1, TimeSqrPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeSqrPerMass o1, PerLengthSqr o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(PerLengthSqr o1, PerTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerTimeCub o1, PerLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator/(PerLengthSqr o1, PerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(PerTimeCub o1, PerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(PerLengthSqr o1, TimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeCub o1, PerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerLengthSqr o1, TimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeCub o1, PerLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(PerLengthSqr o1, MassPerTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(MassPerTimeSqr o1, PerLengthSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerLengthSqr o1, MassPerTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(MassPerTimeSqr o1, PerLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(PerLengthSqr o1, TimeSqrMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeSqrMass o1, PerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerLengthSqr o1, TimeSqrMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(TimeSqrMass o1, PerLengthSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(PerLengthSqr o1, LengthPerMassTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(LengthPerMassTime o1, PerLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(PerLengthSqr o1, LengthPerMassTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthPerMassTime o1, PerLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerLengthSqr o1, LengthTimePerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(LengthTimePerMass o1, PerLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(PerLengthSqr o1, LengthTimePerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthTimePerMass o1, PerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(PerLengthSqr o1, Acceleration o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(Acceleration o1, PerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator/(PerLengthSqr o1, Acceleration o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(Acceleration o1, PerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(PerLengthSqr o1, TimeSqrLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeSqrLength o1, PerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerLengthSqr o1, TimeSqrLength o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(TimeSqrLength o1, PerLengthSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(PerLengthSqr o1, LengthMassPerTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(LengthMassPerTime o1, PerLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(PerLengthSqr o1, LengthMassPerTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthMassPerTime o1, PerLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(PerLengthSqr o1, LengthMassTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(LengthMassTime o1, PerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthSqr o1, LengthMassTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthMassTime o1, PerLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerLengthSqr o1, LengthSqrPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthSqrPerMass o1, PerLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(PerLengthSqr o1, LengthSqrPerTime o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthSqrPerTime o1, PerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerLengthSqr o1, LengthSqrTime o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthSqrTime o1, PerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static Mass operator*(PerLengthSqr o1, LengthSqrMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthSqrMass o1, PerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerLengthSqr o1, Volume o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(Volume o1, PerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMass operator/(PerLengthSqr o1, PerMassLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerMassLengthCub o1, PerLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator/(PerLengthSqr o1, PerTimeLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerTimeLengthCub o1, PerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static Speed operator/(PerLengthSqr o1, TimePerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimePerLengthCub o1, PerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator/(PerLengthSqr o1, Density o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(Density o1, PerLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static MassTime operator/(PerLengthSqr o1, PerMassTimeLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerMassTimeLengthSqr o1, PerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator/(PerLengthSqr o1, TimePerMassLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMass operator/(TimePerMassLengthSqr o1, PerLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(PerLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerLengthSqrTimeSqr o1, PerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeSqrPerLengthSqr o1, PerLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerLengthSqr o1, MassPerTimeLengthSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerTimeLengthSqr o1, PerLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerLengthSqr o1, MassTimePerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassTimePerLengthSqr o1, PerLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerLengthMassTimeSqr o1, PerLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(PerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerLengthMassTimeSqr o1, PerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerLengthSqr o1, TimeSqrPerLengthMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeSqrPerLengthMass o1, PerLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerLengthSqr o1, TimeSqrPerLengthMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeSqrPerLengthMass o1, PerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerLengthSqr o1, PerLengthTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerLengthTimeCub o1, PerLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator/(PerLengthSqr o1, PerLengthTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(PerLengthTimeCub o1, PerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator*(PerLengthSqr o1, TimeCubPerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeCubPerLength o1, PerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator/(PerLengthSqr o1, TimeCubPerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeCubPerLength o1, PerLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(PerLengthSqr o1, MassPerLengthTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(MassPerLengthTimeSqr o1, PerLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator/(PerLengthSqr o1, MassPerLengthTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(MassPerLengthTimeSqr o1, PerLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(PerLengthSqr o1, TimeSqrMassPerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeSqrMassPerLength o1, PerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(TimeSqrMassPerLength o1, PerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerLengthSqr o1, PerMassTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(PerMassTimeCub o1, PerLengthSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(PerLengthSqr o1, PerMassTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(PerMassTimeCub o1, PerLengthSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(PerLengthSqr o1, TimeCubPerMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimeCubPerMass o1, PerLengthSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerLengthSqr o1, TimeCubPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeCubPerMass o1, PerLengthSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerLengthSqr o1, MassPerTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(MassPerTimeCub o1, PerLengthSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(PerLengthSqr o1, MassPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(MassPerTimeCub o1, PerLengthSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(PerLengthSqr o1, TimeCubMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeCubMass o1, PerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerLengthSqr o1, TimeCubMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeCubMass o1, PerLengthSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(PerLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(LengthPerMassTimeSqr o1, PerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(PerLengthSqr o1, LengthPerMassTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthPerMassTimeSqr o1, PerLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerLengthSqr o1, TimeSqrLengthPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeSqrLengthPerMass o1, PerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerLengthSqr o1, TimeSqrLengthPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(TimeSqrLengthPerMass o1, PerLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(PerLengthSqr o1, LengthPerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(LengthPerTimeCub o1, PerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator/(PerLengthSqr o1, LengthPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthPerTimeCub o1, PerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator*(PerLengthSqr o1, TimeCubLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeCubLength o1, PerLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerLengthSqr o1, TimeCubLength o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeCubLength o1, PerLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(PerLengthSqr o1, Force o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(Force o1, PerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(PerLengthSqr o1, Force o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(Force o1, PerLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(PerLengthSqr o1, TimeSqrLengthMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeSqrLengthMass o1, PerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerLengthSqr o1, TimeSqrLengthMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(TimeSqrLengthMass o1, PerLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(PerLengthSqr o1, LengthSqrPerMassTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthSqrPerMassTime o1, PerLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerLengthSqr o1, LengthSqrTimePerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthSqrTimePerMass o1, PerLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(PerLengthSqr o1, QDose o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(QDose o1, PerLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(PerLengthSqr o1, LengthSqrTimeSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthSqrTimeSqr o1, PerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(PerLengthSqr o1, LengthSqrMassPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthSqrMassPerTime o1, PerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(PerLengthSqr o1, LengthSqrMassTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthSqrMassTime o1, PerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator*(PerLengthSqr o1, LengthCubPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthCubPerMass o1, PerLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerLengthSqr o1, LengthCubPerTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthCubPerTime o1, PerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(PerLengthSqr o1, LengthCubTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubTime o1, PerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(PerLengthSqr o1, LengthCubMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthCubMass o1, PerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(PerLengthSqr o1, PerMassTimeLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerMassTimeLengthCub o1, PerLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator/(PerLengthSqr o1, TimePerMassLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimePerMassLengthCub o1, PerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(PerLengthSqr o1, PerTimeSqrLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerTimeSqrLengthCub o1, PerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(PerLengthSqr o1, TimeSqrPerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeSqrPerLengthCub o1, PerLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(PerLengthSqr o1, MassPerTimeLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerTimeLengthCub o1, PerLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator/(PerLengthSqr o1, MassTimePerLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassTimePerLengthCub o1, PerLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator/(PerLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerMassLengthSqrTimeSqr o1, PerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(PerLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeSqrPerMassLengthSqr o1, PerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCub operator/(PerLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(PerLengthSqrTimeCub o1, PerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerLengthSqr o1, TimeCubPerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeCubPerLengthSqr o1, PerLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(MassPerLengthSqrTimeSqr o1, PerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(PerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(TimeSqrMassPerLengthSqr o1, PerLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerLengthSqr o1, PerLengthMassTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerLengthMassTimeCub o1, PerLengthSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(PerLengthSqr o1, PerLengthMassTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(PerLengthMassTimeCub o1, PerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(PerLengthSqr o1, TimeCubPerLengthMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimeCubPerLengthMass o1, PerLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(PerLengthSqr o1, TimeCubPerLengthMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeCubPerLengthMass o1, PerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerLengthSqr o1, MassPerLengthTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(MassPerLengthTimeCub o1, PerLengthSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator/(PerLengthSqr o1, MassPerLengthTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(MassPerLengthTimeCub o1, PerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(PerLengthSqr o1, TimeCubMassPerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeCubMassPerLength o1, PerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeCubMassPerLength o1, PerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(LengthPerMassTimeCub o1, PerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(PerLengthSqr o1, LengthPerMassTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthPerMassTimeCub o1, PerLengthSqr o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator*(PerLengthSqr o1, TimeCubLengthPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimeCubLengthPerMass o1, PerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerLengthSqr o1, TimeCubLengthPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeCubLengthPerMass o1, PerLengthSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator*(PerLengthSqr o1, LengthMassPerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(LengthMassPerTimeCub o1, PerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(PerLengthSqr o1, LengthMassPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthMassPerTimeCub o1, PerLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(PerLengthSqr o1, TimeCubLengthMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeCubLengthMass o1, PerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerLengthSqr o1, TimeCubLengthMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(TimeCubLengthMass o1, PerLengthSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(PerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthSqrPerMassTimeSqr o1, PerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMass operator*(PerLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(LengthSqrTimeSqrPerMass o1, PerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(PerLengthSqr o1, LengthSqrPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthSqrPerTimeCub o1, PerLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(PerLengthSqr o1, TimeCubLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeCubLengthSqr o1, PerLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(PerLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(LengthSqrMassPerTimeSqr o1, PerLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(PerLengthSqr o1, LengthSqrTimeSqrMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(LengthSqrTimeSqrMass o1, PerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator*(PerLengthSqr o1, LengthCubPerMassTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthCubPerMassTime o1, PerLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator*(PerLengthSqr o1, LengthCubTimePerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthCubTimePerMass o1, PerLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(PerLengthSqr o1, LengthCubPerTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthCubPerTimeSqr o1, PerLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(PerLengthSqr o1, LengthCubTimeSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthCubTimeSqr o1, PerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(PerLengthSqr o1, LengthCubMassPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthCubMassPerTime o1, PerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator*(PerLengthSqr o1, LengthCubMassTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthCubMassTime o1, PerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthMass operator/(PerLengthSqr o1, PerMassTimeSqrLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static Force operator/(PerLengthSqr o1, TimeSqrPerMassLengthCub o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeSqrPerMassLengthCub o1, PerLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator/(PerLengthSqr o1, PerLengthCubTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(PerLengthCubTimeCub o1, PerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(PerLengthSqr o1, TimeCubPerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeCubPerLengthCub o1, PerLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator/(PerLengthSqr o1, MassPerTimeSqrLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(MassPerTimeSqrLengthCub o1, PerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator/(PerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLength operator/(TimeSqrMassPerLengthCub o1, PerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator/(PerLengthSqr o1, PerMassLengthSqrTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(PerMassLengthSqrTimeCub o1, PerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator/(PerLengthSqr o1, TimeCubPerMassLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeCubPerMassLengthSqr o1, PerLengthSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator/(PerLengthSqr o1, MassPerLengthSqrTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(MassPerLengthSqrTimeCub o1, PerLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeCubMassPerLengthSqr o1, PerLengthSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator*(PerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthSqrPerMassTimeCub o1, PerLengthSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerMass operator*(PerLengthSqr o1, TimeCubLengthSqrPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthSqr o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerLengthSqr o1, LengthSqrMassPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthSqrMassPerTimeCub o1, PerLengthSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubMass operator*(PerLengthSqr o1, TimeCubLengthSqrMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeCubLengthSqrMass o1, PerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthCubPerMassTimeSqr o1, PerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(PerLengthSqr o1, LengthCubTimeSqrPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthCubTimeSqrPerMass o1, PerLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerLengthSqr o1, LengthCubPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthCubPerTimeCub o1, PerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(PerLengthSqr o1, LengthCubTimeCub o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthCubTimeCub o1, PerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static Force operator*(PerLengthSqr o1, LengthCubMassPerTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthCubMassPerTimeSqr o1, PerLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthMass operator*(PerLengthSqr o1, LengthCubTimeSqrMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthCubTimeSqrMass o1, PerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthMass operator/(PerLengthSqr o1, PerMassLengthCubTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerMassLengthCubTimeCub o1, PerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTimeCub operator/(PerLengthSqr o1, TimeCubPerMassLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeCubPerMassLengthCub o1, PerLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator/(PerLengthSqr o1, MassPerLengthCubTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(MassPerLengthCubTimeCub o1, PerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator/(PerLengthSqr o1, TimeCubMassPerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeCubMassPerLengthCub o1, PerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerLengthSqr o1, LengthCubPerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthCubPerMassTimeCub o1, PerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthPerMass operator*(PerLengthSqr o1, LengthCubTimeCubPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(LengthCubTimeCubPerMass o1, PerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(PerLengthSqr o1, LengthCubMassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthCubMassPerTimeCub o1, PerLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthMass operator*(PerLengthSqr o1, LengthCubTimeCubMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(LengthCubTimeCubMass o1, PerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthSqr perlengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthsqr.HasMinValue && perlengthsqr.Value_ < perlengthsqr.MinValue)
        {
            fail = true;
        }

        if (perlengthsqr.HasMaxValue && perlengthsqr.Value_ > perlengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthSqr is outside its bounds.");
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
    