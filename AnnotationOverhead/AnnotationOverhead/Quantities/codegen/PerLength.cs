
// GENERATE FILE! (15/04/2020 13:18:17)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLength : Quantity, IEquatable<PerLength>, IComparable
    {
    internal PerLength(double value) : base(value, 2)
    {
        PerLength.ImportDisplayUnitFromDatabase_();
    }
    internal PerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLength(PerLength other) : base(other)
    {
        PerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLength"))
        {
            switch(FakeDatabase.Units["PerLength"])
            {
				      case "percentimetercub": displayUnit_ = percentimetercub_; break;
				      case "permillimetercub": displayUnit_ = permillimetercub_; break;
				      case "permetercub": displayUnit_ = permetercub_; break;
				      case "perinchcub": displayUnit_ = perinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetercub_ = new Unit_("PerCentimeterCub", "/cm�", 1.0);
	private static Unit_ permillimetercub_ = new Unit_("PerMillimeterCub", "/mm�", 0.1);
	private static Unit_ permetercub_ = new Unit_("PerMeterCub", "/m�", 100.0);
	private static Unit_ perinchcub_ = new Unit_("PerInchCub", "/in�", 2.56);
	private static Unit_ platformUnit_ = percentimetercub_;
	private static Unit_ displayUnit_ = percentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLength other) => other is object && Equals((object)other);
    public int CompareTo(PerLength other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLength other)) throw new ArgumentException("Object is not a PerLength.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLength l1, PerLength l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLength l1, PerLength l2) => !(l1 == l2);
    public static bool operator <(PerLength l1, PerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLength l1, PerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLength l1, PerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLength l1, PerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLength FromPerCentimeterCubs(double value, double minValue, double maxValue) => new PerLength(value * percentimetercub_.Factor, minValue * percentimetercub_.Factor, maxValue * percentimetercub_.Factor);
		public static PerLength FromPerCentimeterCubs(double value) => new PerLength(value * percentimetercub_.Factor);
		public double GetValueInPerCentimeterCubs() => Value_ / percentimetercub_.Factor;
		public static PerLength FromPerMillimeterCubs(double value, double minValue, double maxValue) => new PerLength(value * permillimetercub_.Factor, minValue * permillimetercub_.Factor, maxValue * permillimetercub_.Factor);
		public static PerLength FromPerMillimeterCubs(double value) => new PerLength(value * permillimetercub_.Factor);
		public double GetValueInPerMillimeterCubs() => Value_ / permillimetercub_.Factor;
		public static PerLength FromPerMeterCubs(double value, double minValue, double maxValue) => new PerLength(value * permetercub_.Factor, minValue * permetercub_.Factor, maxValue * permetercub_.Factor);
		public static PerLength FromPerMeterCubs(double value) => new PerLength(value * permetercub_.Factor);
		public double GetValueInPerMeterCubs() => Value_ / permetercub_.Factor;
		public static PerLength FromPerInchCubs(double value, double minValue, double maxValue) => new PerLength(value * perinchcub_.Factor, minValue * perinchcub_.Factor, maxValue * perinchcub_.Factor);
		public static PerLength FromPerInchCubs(double value) => new PerLength(value * perinchcub_.Factor);
		public double GetValueInPerInchCubs() => Value_ / perinchcub_.Factor;

#endregion

#region arithmetic
		public static PerLength operator+(PerLength o1, PerLength o2) => new PerLength(o1.Value_ + o2.Value_);
		public static PerLength operator-(PerLength o1, PerLength o2) => new PerLength(o1.Value_ - o2.Value_);
		public static PerLengthSqr operator*(PerLength o1, PerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static Dimensionless operator/(PerLength o1, PerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerLength o1, PerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerMass o1, PerLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(PerLength o1, PerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMass o1, PerLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(PerLength o1, PerTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerTime o1, PerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static TimePerLength operator/(PerLength o1, PerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerTime o1, PerLength o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerLength o1, Time o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(Time o1, PerLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static PerLengthTime operator/(PerLength o1, Time o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(Time o1, PerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerLength o1, Mass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(Mass o1, PerLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static PerLengthMass operator/(PerLength o1, Mass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(Mass o1, PerLength o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLength o1, Length o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(Length o1, PerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator/(PerLength o1, Length o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(Length o1, PerLength o2) => new Area(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerLength o1, PerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerLengthSqr o1, PerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static Length operator/(PerLength o1, PerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthSqr o1, PerLength o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerLength o1, PerLengthMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(PerLengthMass o1, PerLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static Mass operator/(PerLength o1, PerLengthMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerLengthMass o1, PerLength o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(PerLength o1, PerLengthTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthTime o1, PerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static Time operator/(PerLength o1, PerLengthTime o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerLengthTime o1, PerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(PerLength o1, TimePerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimePerLength o1, PerLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static PerTime operator/(PerLength o1, TimePerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimePerLength o1, PerLength o2) => new Time(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(PerLength o1, MassPerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(MassPerLength o1, PerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMass operator/(PerLength o1, MassPerLength o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerLength o1, PerLength o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(PerLength o1, PerMassTime o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(PerMassTime o1, PerLength o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(PerLength o1, PerMassTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerMassTime o1, PerLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerLength o1, TimePerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimePerMass o1, PerLength o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator/(PerLength o1, TimePerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(TimePerMass o1, PerLength o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(PerLength o1, PerTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerTimeSqr o1, PerLength o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator/(PerLength o1, PerTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerTimeSqr o1, PerLength o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(PerLength o1, TimeSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeSqr o1, PerLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator/(PerLength o1, TimeSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeSqr o1, PerLength o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator*(PerLength o1, MassPerTime o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassPerTime o1, PerLength o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(PerLength o1, MassPerTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerTime o1, PerLength o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(PerLength o1, MassTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassTime o1, PerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator/(PerLength o1, MassTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(MassTime o1, PerLength o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerLength o1, LengthPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthPerMass o1, PerLength o2) => new PerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator/(PerLength o1, LengthPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthPerMass o1, PerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(PerLength o1, Speed o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(Speed o1, PerLength o2) => new PerTime(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator/(PerLength o1, Speed o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(Speed o1, PerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerLength o1, LengthTime o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthTime o1, PerLength o2) => new Time(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator/(PerLength o1, LengthTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthTime o1, PerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static Mass operator*(PerLength o1, LengthMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthMass o1, PerLength o2) => new Mass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator/(PerLength o1, LengthMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthMass o1, PerLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerLength o1, Area o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(Area o1, PerLength o2) => new Length(o1.Value_ * o2.Value_);
		public static PerLengthCub operator/(PerLength o1, Area o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(Area o1, PerLength o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Area operator/(PerLength o1, PerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerLengthCub o1, PerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerLength o1, PerMassLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(PerMassLengthSqr o1, PerLength o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthMass operator/(PerLength o1, PerMassLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerMassLengthSqr o1, PerLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(PerLength o1, PerTimeLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerTimeLengthSqr o1, PerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthTime operator/(PerLength o1, PerTimeLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerTimeLengthSqr o1, PerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerLength o1, TimePerLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimePerLengthSqr o1, PerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static Speed operator/(PerLength o1, TimePerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimePerLengthSqr o1, PerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerLength o1, MassPerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(MassPerLengthSqr o1, PerLength o2) => new Density(o1.Value_ * o2.Value_);
		public static LengthPerMass operator/(PerLength o1, MassPerLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerLengthSqr o1, PerLength o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(PerLength o1, PerLengthMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerLengthMassTime o1, PerLength o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassTime operator/(PerLength o1, PerLengthMassTime o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerLengthMassTime o1, PerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerLength o1, TimePerLengthMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimePerLengthMass o1, PerLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTime operator/(PerLength o1, TimePerLengthMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMass operator/(TimePerLengthMass o1, PerLength o2) => new TimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(PerLength o1, PerLengthTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerLengthTimeSqr o1, PerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator/(PerLength o1, PerLengthTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerLengthTimeSqr o1, PerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerLength o1, TimeSqrPerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeSqrPerLength o1, PerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator/(PerLength o1, TimeSqrPerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeSqrPerLength o1, PerLength o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerLength o1, MassPerLengthTime o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(MassPerLengthTime o1, PerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMass operator/(PerLength o1, MassPerLengthTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerLengthTime o1, PerLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerLength o1, MassTimePerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(MassTimePerLength o1, PerLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTime operator/(PerLength o1, MassTimePerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassTimePerLength o1, PerLength o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(PerLength o1, PerMassTimeSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(PerMassTimeSqr o1, PerLength o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator/(PerLength o1, PerMassTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerMassTimeSqr o1, PerLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerLength o1, TimeSqrPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeSqrPerMass o1, PerLength o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerLength o1, TimeSqrPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeSqrPerMass o1, PerLength o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(PerLength o1, PerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(PerTimeCub o1, PerLength o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator/(PerLength o1, PerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(PerTimeCub o1, PerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator*(PerLength o1, TimeCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeCub o1, PerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator/(PerLength o1, TimeCub o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeCub o1, PerLength o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(PerLength o1, MassPerTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(MassPerTimeSqr o1, PerLength o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator/(PerLength o1, MassPerTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(MassPerTimeSqr o1, PerLength o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(PerLength o1, TimeSqrMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeSqrMass o1, PerLength o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerLength o1, TimeSqrMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(TimeSqrMass o1, PerLength o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(PerLength o1, LengthPerMassTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthPerMassTime o1, PerLength o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(PerLength o1, LengthPerMassTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthPerMassTime o1, PerLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerLength o1, LengthTimePerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthTimePerMass o1, PerLength o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(PerLength o1, LengthTimePerMass o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthTimePerMass o1, PerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(PerLength o1, Acceleration o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(Acceleration o1, PerLength o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator/(PerLength o1, Acceleration o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(Acceleration o1, PerLength o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(PerLength o1, TimeSqrLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeSqrLength o1, PerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerLength o1, TimeSqrLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeSqrLength o1, PerLength o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(PerLength o1, LengthMassPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthMassPerTime o1, PerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(PerLength o1, LengthMassPerTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthMassPerTime o1, PerLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTime operator*(PerLength o1, LengthMassTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthMassTime o1, PerLength o2) => new MassTime(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerLength o1, LengthMassTime o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(LengthMassTime o1, PerLength o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerLength o1, LengthSqrPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthSqrPerMass o1, PerLength o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static Density operator/(PerLength o1, LengthSqrPerMass o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrPerMass o1, PerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerLength o1, LengthSqrPerTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrPerTime o1, PerLength o2) => new Speed(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator/(PerLength o1, LengthSqrPerTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrPerTime o1, PerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(PerLength o1, LengthSqrTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrTime o1, PerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator/(PerLength o1, LengthSqrTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrTime o1, PerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(PerLength o1, LengthSqrMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthSqrMass o1, PerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(PerLength o1, LengthSqrMass o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthSqrMass o1, PerLength o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static Area operator*(PerLength o1, Volume o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(Volume o1, PerLength o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(PerLength o1, PerMassLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerMassLengthCub o1, PerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(PerLength o1, PerTimeLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerTimeLengthCub o1, PerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(PerLength o1, TimePerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimePerLengthCub o1, PerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(PerLength o1, Density o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(Density o1, PerLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerLength o1, PerMassTimeLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerMassTimeLengthSqr o1, PerLength o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassTime operator/(PerLength o1, PerMassTimeLengthSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerMassTimeLengthSqr o1, PerLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerLength o1, TimePerMassLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimePerMassLengthSqr o1, PerLength o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(PerLength o1, TimePerMassLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimePerMassLengthSqr o1, PerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(PerLength o1, PerLengthSqrTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerLengthSqrTimeSqr o1, PerLength o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator/(PerLength o1, PerLengthSqrTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerLengthSqrTimeSqr o1, PerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(PerLength o1, TimeSqrPerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeSqrPerLengthSqr o1, PerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static Acceleration operator/(PerLength o1, TimeSqrPerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeSqrPerLengthSqr o1, PerLength o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerLength o1, MassPerTimeLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(MassPerTimeLengthSqr o1, PerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator/(PerLength o1, MassPerTimeLengthSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerTimeLengthSqr o1, PerLength o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(PerLength o1, MassTimePerLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(MassTimePerLengthSqr o1, PerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator/(PerLength o1, MassTimePerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassTimePerLengthSqr o1, PerLength o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(PerLength o1, PerLengthMassTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerLengthMassTimeSqr o1, PerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator/(PerLength o1, PerLengthMassTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerLengthMassTimeSqr o1, PerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(PerLength o1, TimeSqrPerLengthMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimeSqrPerLengthMass o1, PerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator/(PerLength o1, TimeSqrPerLengthMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeSqrPerLengthMass o1, PerLength o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(PerLength o1, PerLengthTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerLengthTimeCub o1, PerLength o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator/(PerLength o1, PerLengthTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(PerLengthTimeCub o1, PerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(PerLength o1, TimeCubPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeCubPerLength o1, PerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeCub operator/(PerLength o1, TimeCubPerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeCubPerLength o1, PerLength o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(PerLength o1, MassPerLengthTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(MassPerLengthTimeSqr o1, PerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator/(PerLength o1, MassPerLengthTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(MassPerLengthTimeSqr o1, PerLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(PerLength o1, TimeSqrMassPerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeSqrMassPerLength o1, PerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator/(PerLength o1, TimeSqrMassPerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(TimeSqrMassPerLength o1, PerLength o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerLength o1, PerMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(PerMassTimeCub o1, PerLength o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator/(PerLength o1, PerMassTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(PerMassTimeCub o1, PerLength o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator*(PerLength o1, TimeCubPerMass o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimeCubPerMass o1, PerLength o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(PerLength o1, TimeCubPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeCubPerMass o1, PerLength o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator*(PerLength o1, MassPerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(MassPerTimeCub o1, PerLength o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator/(PerLength o1, MassPerTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(MassPerTimeCub o1, PerLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator*(PerLength o1, TimeCubMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeCubMass o1, PerLength o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLength o1, TimeCubMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeCubMass o1, PerLength o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(PerLength o1, LengthPerMassTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthPerMassTimeSqr o1, PerLength o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(PerLength o1, LengthPerMassTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthPerMassTimeSqr o1, PerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator*(PerLength o1, TimeSqrLengthPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeSqrLengthPerMass o1, PerLength o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(PerLength o1, TimeSqrLengthPerMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeSqrLengthPerMass o1, PerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(PerLength o1, LengthPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthPerTimeCub o1, PerLength o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator/(PerLength o1, LengthPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthPerTimeCub o1, PerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCub operator*(PerLength o1, TimeCubLength o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeCubLength o1, PerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerLength o1, TimeCubLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeCubLength o1, PerLength o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator*(PerLength o1, Force o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(Force o1, PerLength o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerLength o1, Force o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(Force o1, PerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator*(PerLength o1, TimeSqrLengthMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeSqrLengthMass o1, PerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerLength o1, TimeSqrLengthMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(TimeSqrLengthMass o1, PerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(PerLength o1, LengthSqrPerMassTime o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthSqrPerMassTime o1, PerLength o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(PerLength o1, LengthSqrPerMassTime o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthSqrPerMassTime o1, PerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(PerLength o1, LengthSqrTimePerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthSqrTimePerMass o1, PerLength o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(PerLength o1, LengthSqrTimePerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthSqrTimePerMass o1, PerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(PerLength o1, QDose o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(QDose o1, PerLength o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator/(PerLength o1, QDose o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(QDose o1, PerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(PerLength o1, LengthSqrTimeSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthSqrTimeSqr o1, PerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerLength o1, LengthSqrTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthSqrTimeSqr o1, PerLength o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(PerLength o1, LengthSqrMassPerTime o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthSqrMassPerTime o1, PerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(PerLength o1, LengthSqrMassPerTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthSqrMassPerTime o1, PerLength o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(PerLength o1, LengthSqrMassTime o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthSqrMassTime o1, PerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLength o1, LengthSqrMassTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthSqrMassTime o1, PerLength o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(PerLength o1, LengthCubPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubPerMass o1, PerLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(PerLength o1, LengthCubPerTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubPerTime o1, PerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(PerLength o1, LengthCubTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubTime o1, PerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(PerLength o1, LengthCubMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubMass o1, PerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(PerLength o1, PerMassTimeLengthCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerMassTimeLengthCub o1, PerLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator/(PerLength o1, TimePerMassLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimePerMassLengthCub o1, PerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator/(PerLength o1, PerTimeSqrLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerTimeSqrLengthCub o1, PerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator/(PerLength o1, TimeSqrPerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeSqrPerLengthCub o1, PerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator/(PerLength o1, MassPerTimeLengthCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerTimeLengthCub o1, PerLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator/(PerLength o1, MassTimePerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(MassTimePerLengthCub o1, PerLength o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerLength o1, PerMassLengthSqrTimeSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerMassLengthSqrTimeSqr o1, PerLength o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator/(PerLength o1, PerMassLengthSqrTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerMassLengthSqrTimeSqr o1, PerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerLength o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeSqrPerMassLengthSqr o1, PerLength o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static Force operator/(PerLength o1, TimeSqrPerMassLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeSqrPerMassLengthSqr o1, PerLength o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerLength o1, PerLengthSqrTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerLengthSqrTimeCub o1, PerLength o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubLength operator/(PerLength o1, PerLengthSqrTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(PerLengthSqrTimeCub o1, PerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator*(PerLength o1, TimeCubPerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeCubPerLengthSqr o1, PerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator/(PerLength o1, TimeCubPerLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeCubPerLengthSqr o1, PerLength o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(PerLength o1, MassPerLengthSqrTimeSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(MassPerLengthSqrTimeSqr o1, PerLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator/(PerLength o1, MassPerLengthSqrTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(MassPerLengthSqrTimeSqr o1, PerLength o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(PerLength o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerLength o1, TimeSqrMassPerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLength operator/(TimeSqrMassPerLengthSqr o1, PerLength o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerLength o1, PerLengthMassTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(PerLengthMassTimeCub o1, PerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMass operator/(PerLength o1, PerLengthMassTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(PerLengthMassTimeCub o1, PerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(PerLength o1, TimeCubPerLengthMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimeCubPerLengthMass o1, PerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator/(PerLength o1, TimeCubPerLengthMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeCubPerLengthMass o1, PerLength o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerLength o1, MassPerLengthTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(MassPerLengthTimeCub o1, PerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator/(PerLength o1, MassPerLengthTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(MassPerLengthTimeCub o1, PerLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(PerLength o1, TimeCubMassPerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeCubMassPerLength o1, PerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator/(PerLength o1, TimeCubMassPerLength o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeCubMassPerLength o1, PerLength o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator*(PerLength o1, LengthPerMassTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthPerMassTimeCub o1, PerLength o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(PerLength o1, LengthPerMassTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(LengthPerMassTimeCub o1, PerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator*(PerLength o1, TimeCubLengthPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(TimeCubLengthPerMass o1, PerLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerLength o1, TimeCubLengthPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeCubLengthPerMass o1, PerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator*(PerLength o1, LengthMassPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthMassPerTimeCub o1, PerLength o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(PerLength o1, LengthMassPerTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(LengthMassPerTimeCub o1, PerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator*(PerLength o1, TimeCubLengthMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeCubLengthMass o1, PerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerLength o1, TimeCubLengthMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeCubLengthMass o1, PerLength o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerLength o1, LengthSqrPerMassTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthSqrPerMassTimeSqr o1, PerLength o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(PerLength o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthSqrPerMassTimeSqr o1, PerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(PerLength o1, LengthSqrTimeSqrPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthSqrTimeSqrPerMass o1, PerLength o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerLength o1, LengthSqrTimeSqrPerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthSqrTimeSqrPerMass o1, PerLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(PerLength o1, LengthSqrPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthSqrPerTimeCub o1, PerLength o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator/(PerLength o1, LengthSqrPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthSqrPerTimeCub o1, PerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator*(PerLength o1, TimeCubLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeCubLengthSqr o1, PerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerLength o1, TimeCubLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeCubLengthSqr o1, PerLength o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static Force operator*(PerLength o1, LengthSqrMassPerTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthSqrMassPerTimeSqr o1, PerLength o2) => new Force(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(PerLength o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthSqrMassPerTimeSqr o1, PerLength o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(PerLength o1, LengthSqrTimeSqrMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthSqrTimeSqrMass o1, PerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerLength o1, LengthSqrTimeSqrMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthSqrTimeSqrMass o1, PerLength o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerLength o1, LengthCubPerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubPerMassTime o1, PerLength o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimePerMass operator*(PerLength o1, LengthCubTimePerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthCubTimePerMass o1, PerLength o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static QDose operator*(PerLength o1, LengthCubPerTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubPerTimeSqr o1, PerLength o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(PerLength o1, LengthCubTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubTimeSqr o1, PerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(PerLength o1, LengthCubMassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubMassPerTime o1, PerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator*(PerLength o1, LengthCubMassTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthCubMassTime o1, PerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator/(PerLength o1, PerMassTimeSqrLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(PerLength o1, TimeSqrPerMassLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerMassLengthCub o1, PerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator/(PerLength o1, PerLengthCubTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerLengthCubTimeCub o1, PerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(PerLength o1, TimeCubPerLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeCubPerLengthCub o1, PerLength o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator/(PerLength o1, MassPerTimeSqrLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(MassPerTimeSqrLengthCub o1, PerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(PerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(TimeSqrMassPerLengthCub o1, PerLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerLength o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerMassLengthSqrTimeCub o1, PerLength o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(PerLength o1, PerMassLengthSqrTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerMassLengthSqrTimeCub o1, PerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(PerLength o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimeCubPerMassLengthSqr o1, PerLength o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator/(PerLength o1, TimeCubPerMassLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeCubPerMassLengthSqr o1, PerLength o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerLength o1, MassPerLengthSqrTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(MassPerLengthSqrTimeCub o1, PerLength o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator/(PerLength o1, MassPerLengthSqrTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(MassPerLengthSqrTimeCub o1, PerLength o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(PerLength o1, TimeCubMassPerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator/(PerLength o1, TimeCubMassPerLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeCubMassPerLengthSqr o1, PerLength o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerLength o1, LengthSqrPerMassTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthSqrPerMassTimeCub o1, PerLength o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(PerLength o1, LengthSqrPerMassTimeCub o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(LengthSqrPerMassTimeCub o1, PerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator*(PerLength o1, TimeCubLengthSqrPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(TimeCubLengthSqrPerMass o1, PerLength o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerLength o1, TimeCubLengthSqrPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeCubLengthSqrPerMass o1, PerLength o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTimeCub operator*(PerLength o1, LengthSqrMassPerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthSqrMassPerTimeCub o1, PerLength o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(PerLength o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthSqrMassPerTimeCub o1, PerLength o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(PerLength o1, TimeCubLengthSqrMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(TimeCubLengthSqrMass o1, PerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerLength o1, TimeCubLengthSqrMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(TimeCubLengthSqrMass o1, PerLength o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthCubPerMassTimeSqr o1, PerLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator*(PerLength o1, LengthCubTimeSqrPerMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator*(LengthCubTimeSqrPerMass o1, PerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(PerLength o1, LengthCubPerTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthCubPerTimeCub o1, PerLength o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(PerLength o1, LengthCubTimeCub o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthCubTimeCub o1, PerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(PerLength o1, LengthCubMassPerTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubMassPerTimeSqr o1, PerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(PerLength o1, LengthCubTimeSqrMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthCubTimeSqrMass o1, PerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator/(PerLength o1, PerMassLengthCubTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerMassLengthCubTimeCub o1, PerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator/(PerLength o1, TimeCubPerMassLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimeCubPerMassLengthCub o1, PerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator/(PerLength o1, MassPerLengthCubTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerLengthCubTimeCub o1, PerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator/(PerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(TimeCubMassPerLengthCub o1, PerLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthCubPerMassTimeCub o1, PerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator*(PerLength o1, LengthCubTimeCubPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator*(LengthCubTimeCubPerMass o1, PerLength o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(PerLength o1, LengthCubMassPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthCubMassPerTimeCub o1, PerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(PerLength o1, LengthCubTimeCubMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthCubTimeCubMass o1, PerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLength perlength, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlength.HasMinValue && perlength.Value_ < perlength.MinValue)
        {
            fail = true;
        }

        if (perlength.HasMaxValue && perlength.Value_ > perlength.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLength is outside its bounds.");
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
    