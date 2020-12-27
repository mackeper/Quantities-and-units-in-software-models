
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthTimeSqr : Quantity, IEquatable<PerLengthTimeSqr>, IComparable
    {
    internal PerLengthTimeSqr(double value) : base(value, 2)
    {
        PerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthTimeSqr(PerLengthTimeSqr other) : base(other)
    {
        PerLengthTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthTimeSqr"))
        {
            switch(FakeDatabase.Units["PerLengthTimeSqr"])
            {
				      case "percentimetercubsecondsqr": displayUnit_ = percentimetercubsecondsqr_; break;
				      case "permillimetercubsecondsqr": displayUnit_ = permillimetercubsecondsqr_; break;
				      case "permetercubsecondsqr": displayUnit_ = permetercubsecondsqr_; break;
				      case "perinchcubsecondsqr": displayUnit_ = perinchcubsecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetercubsecondsqr_ = new Unit_("PerCentimeterCubSecondSqr", "/cm³ s²", 1.0);
	private static Unit_ permillimetercubsecondsqr_ = new Unit_("PerMillimeterCubSecondSqr", "/mm³ s²", 0.1);
	private static Unit_ permetercubsecondsqr_ = new Unit_("PerMeterCubSecondSqr", "/m³ s²", 100.0);
	private static Unit_ perinchcubsecondsqr_ = new Unit_("PerInchCubSecondSqr", "/in³ s²", 2.56);
	private static Unit_ platformUnit_ = percentimetercubsecondsqr_;
	private static Unit_ displayUnit_ = percentimetercubsecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthTimeSqr other)) throw new ArgumentException("Object is not a PerLengthTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => !(l1 == l2);
    public static bool operator <(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthTimeSqr l1, PerLengthTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthTimeSqr FromPerCentimeterCubSecondSqrs(double value, double minValue, double maxValue) => new PerLengthTimeSqr(value * percentimetercubsecondsqr_.Factor, minValue * percentimetercubsecondsqr_.Factor, maxValue * percentimetercubsecondsqr_.Factor);
		public static PerLengthTimeSqr FromPerCentimeterCubSecondSqrs(double value) => new PerLengthTimeSqr(value * percentimetercubsecondsqr_.Factor);
		public double GetValueInPerCentimeterCubSecondSqrs() => Value_ / percentimetercubsecondsqr_.Factor;
		public static PerLengthTimeSqr FromPerMillimeterCubSecondSqrs(double value, double minValue, double maxValue) => new PerLengthTimeSqr(value * permillimetercubsecondsqr_.Factor, minValue * permillimetercubsecondsqr_.Factor, maxValue * permillimetercubsecondsqr_.Factor);
		public static PerLengthTimeSqr FromPerMillimeterCubSecondSqrs(double value) => new PerLengthTimeSqr(value * permillimetercubsecondsqr_.Factor);
		public double GetValueInPerMillimeterCubSecondSqrs() => Value_ / permillimetercubsecondsqr_.Factor;
		public static PerLengthTimeSqr FromPerMeterCubSecondSqrs(double value, double minValue, double maxValue) => new PerLengthTimeSqr(value * permetercubsecondsqr_.Factor, minValue * permetercubsecondsqr_.Factor, maxValue * permetercubsecondsqr_.Factor);
		public static PerLengthTimeSqr FromPerMeterCubSecondSqrs(double value) => new PerLengthTimeSqr(value * permetercubsecondsqr_.Factor);
		public double GetValueInPerMeterCubSecondSqrs() => Value_ / permetercubsecondsqr_.Factor;
		public static PerLengthTimeSqr FromPerInchCubSecondSqrs(double value, double minValue, double maxValue) => new PerLengthTimeSqr(value * perinchcubsecondsqr_.Factor, minValue * perinchcubsecondsqr_.Factor, maxValue * perinchcubsecondsqr_.Factor);
		public static PerLengthTimeSqr FromPerInchCubSecondSqrs(double value) => new PerLengthTimeSqr(value * perinchcubsecondsqr_.Factor);
		public double GetValueInPerInchCubSecondSqrs() => Value_ / perinchcubsecondsqr_.Factor;

#endregion

#region arithmetic
		public static PerLengthTimeSqr operator+(PerLengthTimeSqr o1, PerLengthTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ + o2.Value_);
		public static PerLengthTimeSqr operator-(PerLengthTimeSqr o1, PerLengthTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthTimeSqr o1, PerLengthTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(PerLengthTimeSqr o1, TimeSqrPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeSqrPerLength o1, PerLengthTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerLengthTimeSqr o1, MassPerLengthTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(MassPerLengthTime o1, PerLengthTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTime operator/(PerLengthTimeSqr o1, MassPerLengthTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerLengthTime o1, PerLengthTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerLengthTimeSqr o1, MassTimePerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassTimePerLength o1, PerLengthTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator/(PerLengthTimeSqr o1, MassTimePerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(MassTimePerLength o1, PerLengthTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(PerLengthTimeSqr o1, PerMassTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMassTimeSqr o1, PerLengthTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerLengthTimeSqr o1, TimeSqrPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeSqrPerMass o1, PerLengthTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(PerLengthTimeSqr o1, PerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerTimeCub o1, PerLengthTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerLengthTimeSqr o1, TimeCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCub o1, PerLengthTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(PerLengthTimeSqr o1, MassPerTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerTimeSqr o1, PerLengthTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerLengthTimeSqr o1, TimeSqrMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeSqrMass o1, PerLengthTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerLengthTimeSqr o1, LengthPerMassTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthPerMassTime o1, PerLengthTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerLengthTimeSqr o1, LengthPerMassTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthPerMassTime o1, PerLengthTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(PerLengthTimeSqr o1, LengthTimePerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthTimePerMass o1, PerLengthTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerLengthTimeSqr o1, LengthTimePerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(LengthTimePerMass o1, PerLengthTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(PerLengthTimeSqr o1, Acceleration o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(Acceleration o1, PerLengthTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLengthTimeSqr o1, TimeSqrLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeSqrLength o1, PerLengthTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerLengthTimeSqr o1, LengthMassPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthMassPerTime o1, PerLengthTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerLengthTimeSqr o1, LengthMassPerTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(LengthMassPerTime o1, PerLengthTimeSqr o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(PerLengthTimeSqr o1, LengthMassTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthMassTime o1, PerLengthTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerLengthTimeSqr o1, LengthMassTime o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(LengthMassTime o1, PerLengthTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerLengthTimeSqr o1, LengthSqrPerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthSqrPerMass o1, PerLengthTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerLengthTimeSqr o1, LengthSqrPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthSqrPerMass o1, PerLengthTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(PerLengthTimeSqr o1, LengthSqrPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthSqrPerTime o1, PerLengthTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator/(PerLengthTimeSqr o1, LengthSqrPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrPerTime o1, PerLengthTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerLengthTimeSqr o1, LengthSqrTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrTime o1, PerLengthTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerLengthTimeSqr o1, LengthSqrTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthSqrTime o1, PerLengthTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static Force operator*(PerLengthTimeSqr o1, LengthSqrMass o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthSqrMass o1, PerLengthTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerLengthTimeSqr o1, LengthSqrMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthSqrMass o1, PerLengthTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static QDose operator*(PerLengthTimeSqr o1, Volume o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(Volume o1, PerLengthTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(PerLengthTimeSqr o1, PerMassLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerMassLengthCub o1, PerLengthTimeSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(PerLengthTimeSqr o1, PerTimeLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerTimeLengthCub o1, PerLengthTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(PerLengthTimeSqr o1, TimePerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimePerLengthCub o1, PerLengthTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(PerLengthTimeSqr o1, Density o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(Density o1, PerLengthTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerLengthTimeSqr o1, PerMassTimeLengthSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerMassTimeLengthSqr o1, PerLengthTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(PerLengthTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(PerMassTimeLengthSqr o1, PerLengthTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerLengthTimeSqr o1, TimePerMassLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(TimePerMassLengthSqr o1, PerLengthTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator/(PerLengthTimeSqr o1, TimePerMassLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimePerMassLengthSqr o1, PerLengthTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(PerLengthTimeSqr o1, PerLengthSqrTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthSqrTimeSqr o1, PerLengthTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerLengthTimeSqr o1, TimeSqrPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeSqrPerLengthSqr o1, PerLengthTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerLengthTimeSqr o1, MassPerTimeLengthSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(MassPerTimeLengthSqr o1, PerLengthTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator/(PerLengthTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassPerTimeLengthSqr o1, PerLengthTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerLengthTimeSqr o1, MassTimePerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassTimePerLengthSqr o1, PerLengthTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator/(PerLengthTimeSqr o1, MassTimePerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(MassTimePerLengthSqr o1, PerLengthTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static Mass operator/(PerLengthTimeSqr o1, PerLengthMassTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerLengthMassTimeSqr o1, PerLengthTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerLengthTimeSqr o1, TimeSqrPerLengthMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(TimeSqrPerLengthMass o1, PerLengthTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerLengthTimeSqr o1, PerLengthTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerLengthTimeCub o1, PerLengthTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(PerLengthTimeSqr o1, TimeCubPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeCubPerLength o1, PerLengthTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(PerLengthTimeSqr o1, MassPerLengthTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerLengthTimeSqr o1, PerLengthTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(PerLengthTimeSqr o1, TimeSqrMassPerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthTimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator/(PerLengthTimeSqr o1, PerMassTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerMassTimeCub o1, PerLengthTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerLengthTimeSqr o1, TimeCubPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeCubPerMass o1, PerLengthTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator/(PerLengthTimeSqr o1, MassPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerTimeCub o1, PerLengthTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(PerLengthTimeSqr o1, TimeCubMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeCubMass o1, PerLengthTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(PerLengthTimeSqr o1, LengthPerMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthPerMassTimeSqr o1, PerLengthTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerLengthTimeSqr o1, TimeSqrLengthPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeSqrLengthPerMass o1, PerLengthTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(PerLengthTimeSqr o1, LengthPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthPerTimeCub o1, PerLengthTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerLengthTimeSqr o1, TimeCubLength o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubLength o1, PerLengthTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(PerLengthTimeSqr o1, Force o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(Force o1, PerLengthTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static Mass operator*(PerLengthTimeSqr o1, TimeSqrLengthMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeSqrLengthMass o1, PerLengthTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerLengthTimeSqr o1, LengthSqrPerMassTime o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthSqrPerMassTime o1, PerLengthTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(PerLengthTimeSqr o1, LengthSqrPerMassTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthSqrPerMassTime o1, PerLengthTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(PerLengthTimeSqr o1, LengthSqrTimePerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthSqrTimePerMass o1, PerLengthTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerLengthTimeSqr o1, LengthSqrTimePerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(LengthSqrTimePerMass o1, PerLengthTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(PerLengthTimeSqr o1, QDose o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(QDose o1, PerLengthTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerLengthTimeSqr o1, LengthSqrTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrTimeSqr o1, PerLengthTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(PerLengthTimeSqr o1, LengthSqrMassPerTime o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthSqrMassPerTime o1, PerLengthTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthTimeSqr o1, LengthSqrMassPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthSqrMassPerTime o1, PerLengthTimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(PerLengthTimeSqr o1, LengthSqrMassTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthSqrMassTime o1, PerLengthTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerLengthTimeSqr o1, LengthSqrMassTime o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(LengthSqrMassTime o1, PerLengthTimeSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerLengthTimeSqr o1, LengthCubPerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthCubPerMass o1, PerLengthTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(PerLengthTimeSqr o1, LengthCubPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthCubPerTime o1, PerLengthTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(PerLengthTimeSqr o1, LengthCubTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubTime o1, PerLengthTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(PerLengthTimeSqr o1, LengthCubMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubMass o1, PerLengthTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator/(PerLengthTimeSqr o1, PerMassTimeLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator/(PerLengthTimeSqr o1, TimePerMassLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimePerMassLengthCub o1, PerLengthTimeSqr o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(PerLengthTimeSqr o1, PerTimeSqrLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator/(PerLengthTimeSqr o1, MassPerTimeLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerTimeLengthCub o1, PerLengthTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator/(PerLengthTimeSqr o1, MassTimePerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(MassTimePerLengthCub o1, PerLengthTimeSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthMass operator/(PerLengthTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerMassLengthSqrTimeSqr o1, PerLengthTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerLengthTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimeSqrPerMassLengthSqr o1, PerLengthTimeSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(PerLengthTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerLengthSqrTimeCub o1, PerLengthTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerLengthTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator/(PerLengthTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerLengthSqrTimeSqr o1, PerLengthTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerLengthTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(TimeSqrMassPerLengthSqr o1, PerLengthTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(PerLengthTimeSqr o1, PerLengthMassTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerLengthMassTimeCub o1, PerLengthTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerLengthTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeCubPerLengthMass o1, PerLengthTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator/(PerLengthTimeSqr o1, MassPerLengthTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerLengthTimeCub o1, PerLengthTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerLengthTimeSqr o1, TimeCubMassPerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator/(PerLengthTimeSqr o1, LengthPerMassTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthPerMassTimeCub o1, PerLengthTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerLengthTimeSqr o1, TimeCubLengthPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubLengthPerMass o1, PerLengthTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerMassLengthSqr operator/(PerLengthTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthMassPerTimeCub o1, PerLengthTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(PerLengthTimeSqr o1, TimeCubLengthMass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(TimeCubLengthMass o1, PerLengthTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static Density operator/(PerLengthTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrPerMassTimeSqr o1, PerLengthTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerLengthTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthSqrTimeSqrPerMass o1, PerLengthTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerLengthTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrPerTimeCub o1, PerLengthTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(PerLengthTimeSqr o1, TimeCubLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(TimeCubLengthSqr o1, PerLengthTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(PerLengthTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthSqrMassPerTimeSqr o1, PerLengthTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(PerLengthTimeSqr o1, LengthSqrTimeSqrMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthSqrTimeSqrMass o1, PerLengthTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerLengthTimeSqr o1, LengthCubPerMassTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthCubPerMassTime o1, PerLengthTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerLengthTimeSqr o1, LengthCubTimePerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubTimePerMass o1, PerLengthTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static Area operator*(PerLengthTimeSqr o1, LengthCubTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimeSqr o1, PerLengthTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(PerLengthTimeSqr o1, LengthCubMassPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthCubMassPerTime o1, PerLengthTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(PerLengthTimeSqr o1, LengthCubMassTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubMassTime o1, PerLengthTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(PerLengthTimeSqr o1, PerMassTimeSqrLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(PerLengthTimeSqr o1, PerLengthCubTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerLengthCubTimeCub o1, PerLengthTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(PerLengthTimeSqr o1, MassPerTimeSqrLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(MassPerTimeSqrLengthCub o1, PerLengthTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator/(PerLengthTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerMassLengthSqrTimeCub o1, PerLengthTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerLengthTimeSqr o1, TimeCubPerMassLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimeCubPerMassLengthSqr o1, PerLengthTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator/(PerLengthTimeSqr o1, MassPerLengthSqrTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerLengthSqrTimeCub o1, PerLengthTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(PerLengthTimeSqr o1, TimeCubMassPerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthCub operator/(PerLengthTimeSqr o1, LengthSqrPerMassTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthSqrPerMassTimeCub o1, PerLengthTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(PerLengthTimeSqr o1, TimeCubLengthSqrPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static TimePerMassLengthCub operator/(PerLengthTimeSqr o1, LengthSqrMassPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthSqrMassPerTimeCub o1, PerLengthTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(PerLengthTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(TimeCubLengthSqrMass o1, PerLengthTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator*(PerLengthTimeSqr o1, LengthCubTimeSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubTimeSqrPerMass o1, PerLengthTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(PerLengthTimeSqr o1, LengthCubTimeCub o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubTimeCub o1, PerLengthTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(PerLengthTimeSqr o1, LengthCubTimeSqrMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubTimeSqrMass o1, PerLengthTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(PerLengthTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerMassLengthCubTimeCub o1, PerLengthTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator/(PerLengthTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerLengthCubTimeCub o1, PerLengthTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(PerLengthTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthCubTimeCubPerMass o1, PerLengthTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator*(PerLengthTimeSqr o1, LengthCubTimeCubMass o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthCubTimeCubMass o1, PerLengthTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthTimeSqr perlengthtimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthtimesqr.HasMinValue && perlengthtimesqr.Value_ < perlengthtimesqr.MinValue)
        {
            fail = true;
        }

        if (perlengthtimesqr.HasMaxValue && perlengthtimesqr.Value_ > perlengthtimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthTimeSqr is outside its bounds.");
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
    