
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthMassTimeSqr : Quantity, IEquatable<PerLengthMassTimeSqr>, IComparable
    {
    internal PerLengthMassTimeSqr(double value) : base(value, 2)
    {
        PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthMassTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthMassTimeSqr(PerLengthMassTimeSqr other) : base(other)
    {
        PerLengthMassTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMassTimeSqr"))
        {
            switch(FakeDatabase.Units["PerLengthMassTimeSqr"])
            {
				      case "percentimetercubkilogramsecondsqr": displayUnit_ = percentimetercubkilogramsecondsqr_; break;
				      case "permillimetercubkilogramsecondsqr": displayUnit_ = permillimetercubkilogramsecondsqr_; break;
				      case "permetercubkilogramsecondsqr": displayUnit_ = permetercubkilogramsecondsqr_; break;
				      case "perinchcubkilogramsecondsqr": displayUnit_ = perinchcubkilogramsecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetercubkilogramsecondsqr_ = new Unit_("PerCentimeterCubKilogramSecondSqr", "/cm³ kg s²", 1.0);
	private static Unit_ permillimetercubkilogramsecondsqr_ = new Unit_("PerMillimeterCubKilogramSecondSqr", "/mm³ kg s²", 0.1);
	private static Unit_ permetercubkilogramsecondsqr_ = new Unit_("PerMeterCubKilogramSecondSqr", "/m³ kg s²", 100.0);
	private static Unit_ perinchcubkilogramsecondsqr_ = new Unit_("PerInchCubKilogramSecondSqr", "/in³ kg s²", 2.56);
	private static Unit_ platformUnit_ = percentimetercubkilogramsecondsqr_;
	private static Unit_ displayUnit_ = percentimetercubkilogramsecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthMassTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthMassTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthMassTimeSqr other)) throw new ArgumentException("Object is not a PerLengthMassTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => !(l1 == l2);
    public static bool operator <(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthMassTimeSqr l1, PerLengthMassTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthMassTimeSqr FromPerCentimeterCubKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr(value * percentimetercubkilogramsecondsqr_.Factor, minValue * percentimetercubkilogramsecondsqr_.Factor, maxValue * percentimetercubkilogramsecondsqr_.Factor);
		public static PerLengthMassTimeSqr FromPerCentimeterCubKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr(value * percentimetercubkilogramsecondsqr_.Factor);
		public double GetValueInPerCentimeterCubKilogramSecondSqrs() => Value_ / percentimetercubkilogramsecondsqr_.Factor;
		public static PerLengthMassTimeSqr FromPerMillimeterCubKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr(value * permillimetercubkilogramsecondsqr_.Factor, minValue * permillimetercubkilogramsecondsqr_.Factor, maxValue * permillimetercubkilogramsecondsqr_.Factor);
		public static PerLengthMassTimeSqr FromPerMillimeterCubKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr(value * permillimetercubkilogramsecondsqr_.Factor);
		public double GetValueInPerMillimeterCubKilogramSecondSqrs() => Value_ / permillimetercubkilogramsecondsqr_.Factor;
		public static PerLengthMassTimeSqr FromPerMeterCubKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr(value * permetercubkilogramsecondsqr_.Factor, minValue * permetercubkilogramsecondsqr_.Factor, maxValue * permetercubkilogramsecondsqr_.Factor);
		public static PerLengthMassTimeSqr FromPerMeterCubKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr(value * permetercubkilogramsecondsqr_.Factor);
		public double GetValueInPerMeterCubKilogramSecondSqrs() => Value_ / permetercubkilogramsecondsqr_.Factor;
		public static PerLengthMassTimeSqr FromPerInchCubKilogramSecondSqrs(double value, double minValue, double maxValue) => new PerLengthMassTimeSqr(value * perinchcubkilogramsecondsqr_.Factor, minValue * perinchcubkilogramsecondsqr_.Factor, maxValue * perinchcubkilogramsecondsqr_.Factor);
		public static PerLengthMassTimeSqr FromPerInchCubKilogramSecondSqrs(double value) => new PerLengthMassTimeSqr(value * perinchcubkilogramsecondsqr_.Factor);
		public double GetValueInPerInchCubKilogramSecondSqrs() => Value_ / perinchcubkilogramsecondsqr_.Factor;

#endregion

#region arithmetic
		public static PerLengthMassTimeSqr operator+(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ + o2.Value_);
		public static PerLengthMassTimeSqr operator-(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerLengthTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerLengthMassTimeSqr o1, TimeCubPerLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeCubPerLength o1, PerLengthMassTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator*(PerLengthMassTimeSqr o1, TimeSqrMassPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthMassTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(PerLengthMassTimeSqr o1, PerMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerMassTimeCub o1, PerLengthMassTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerLengthMassTimeSqr o1, TimeCubMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubMass o1, PerLengthMassTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthPerMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthPerTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerLengthMassTimeSqr o1, TimeCubLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubLength o1, PerLengthMassTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerLengthMassTimeSqr o1, TimeSqrLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeSqrLengthMass o1, PerLengthMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrPerMassTime o1, PerLengthMassTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(PerLengthMassTimeSqr o1, LengthSqrTimePerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthSqrTimePerMass o1, PerLengthMassTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator/(PerLengthMassTimeSqr o1, QDose o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(QDose o1, PerLengthMassTimeSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerLengthMassTimeSqr o1, LengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthSqrTimeSqr o1, PerLengthMassTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerLengthMassTimeSqr o1, LengthSqrMassPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthSqrMassPerTime o1, PerLengthMassTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerLengthMassTimeSqr o1, LengthSqrMassTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrMassTime o1, PerLengthMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerLengthMassTimeSqr o1, LengthCubPerTime o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthCubPerTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerLengthMassTimeSqr o1, LengthCubTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static QDose operator*(PerLengthMassTimeSqr o1, LengthCubMass o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubMass o1, PerLengthMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(PerLengthMassTimeSqr o1, PerMassTimeLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(PerLengthMassTimeSqr o1, TimePerMassLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimePerMassLengthCub o1, PerLengthMassTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(PerLengthMassTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthMassTimeSqr o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(PerLengthMassTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerMassLengthSqrTimeSqr o1, PerLengthMassTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(PerLengthSqrTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerLengthMassTimeSqr o1, TimeCubPerLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator*(PerLengthMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthMassTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerLengthMassTimeSqr o1, PerLengthMassTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerLengthMassTimeCub o1, PerLengthMassTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(PerLengthMassTimeSqr o1, TimeCubMassPerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthMassTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(PerLengthMassTimeSqr o1, LengthPerMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthPerMassTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerLengthMassTimeSqr o1, TimeCubLengthMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubLengthMass o1, PerLengthMassTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrPerMassTimeSqr o1, PerLengthMassTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthSqrPerTimeCub o1, PerLengthMassTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(PerLengthMassTimeSqr o1, TimeCubLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeCubLengthSqr o1, PerLengthMassTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerLengthMassTimeSqr o1, LengthSqrTimeSqrMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrTimeSqrMass o1, PerLengthMassTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator*(PerLengthMassTimeSqr o1, LengthCubTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubTimeSqr o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(PerLengthMassTimeSqr o1, LengthCubMassPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthCubMassPerTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(PerLengthMassTimeSqr o1, LengthCubMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubMassTime o1, PerLengthMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static Area operator/(PerLengthMassTimeSqr o1, PerMassTimeSqrLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthMassTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator/(PerLengthMassTimeSqr o1, PerLengthCubTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerLengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthTime operator/(PerLengthMassTimeSqr o1, PerMassLengthSqrTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerMassLengthSqrTimeCub o1, PerLengthMassTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerLengthMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerLengthMassTimeSqr o1, LengthSqrPerMassTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrPerMassTimeCub o1, PerLengthMassTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(PerLengthMassTimeSqr o1, TimeCubLengthSqrMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(TimeCubLengthSqrMass o1, PerLengthMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimePerMass operator*(PerLengthMassTimeSqr o1, LengthCubTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static Area operator*(PerLengthMassTimeSqr o1, LengthCubTimeSqrMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimeSqrMass o1, PerLengthMassTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(PerLengthMassTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerMassLengthCubTimeCub o1, PerLengthMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(PerLengthMassTimeSqr o1, LengthCubTimeCubMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubTimeCubMass o1, PerLengthMassTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthMassTimeSqr perlengthmasstimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthmasstimesqr.HasMinValue && perlengthmasstimesqr.Value_ < perlengthmasstimesqr.MinValue)
        {
            fail = true;
        }

        if (perlengthmasstimesqr.HasMaxValue && perlengthmasstimesqr.Value_ > perlengthmasstimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthMassTimeSqr is outside its bounds.");
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
    