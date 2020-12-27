
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTimeLengthSqr : Quantity, IEquatable<PerTimeLengthSqr>, IComparable
    {
    internal PerTimeLengthSqr(double value) : base(value, 2)
    {
        PerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerTimeLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTimeLengthSqr(PerTimeLengthSqr other) : base(other)
    {
        PerTimeLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTimeLengthSqr"))
        {
            switch(FakeDatabase.Units["PerTimeLengthSqr"])
            {
				      case "persecondcubcentimetersqr": displayUnit_ = persecondcubcentimetersqr_; break;
				      case "persecondcubmillimetersqr": displayUnit_ = persecondcubmillimetersqr_; break;
				      case "persecondcubmetersqr": displayUnit_ = persecondcubmetersqr_; break;
				      case "persecondcubinchsqr": displayUnit_ = persecondcubinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ persecondcubcentimetersqr_ = new Unit_("PerSecondCubCentimeterSqr", "/s³ cm²", 1.0);
	private static Unit_ persecondcubmillimetersqr_ = new Unit_("PerSecondCubMillimeterSqr", "/s³ mm²", 99.99999999999999);
	private static Unit_ persecondcubmetersqr_ = new Unit_("PerSecondCubMeterSqr", "/s³ m²", 0.0001);
	private static Unit_ persecondcubinchsqr_ = new Unit_("PerSecondCubInchSqr", "/s³ in²", 0.152587890625);
	private static Unit_ platformUnit_ = persecondcubcentimetersqr_;
	private static Unit_ displayUnit_ = persecondcubcentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTimeLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerTimeLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTimeLengthSqr other)) throw new ArgumentException("Object is not a PerTimeLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => !(l1 == l2);
    public static bool operator <(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTimeLengthSqr l1, PerTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTimeLengthSqr FromPerSecondCubCentimeterSqrs(double value, double minValue, double maxValue) => new PerTimeLengthSqr(value * persecondcubcentimetersqr_.Factor, minValue * persecondcubcentimetersqr_.Factor, maxValue * persecondcubcentimetersqr_.Factor);
		public static PerTimeLengthSqr FromPerSecondCubCentimeterSqrs(double value) => new PerTimeLengthSqr(value * persecondcubcentimetersqr_.Factor);
		public double GetValueInPerSecondCubCentimeterSqrs() => Value_ / persecondcubcentimetersqr_.Factor;
		public static PerTimeLengthSqr FromPerSecondCubMillimeterSqrs(double value, double minValue, double maxValue) => new PerTimeLengthSqr(value * persecondcubmillimetersqr_.Factor, minValue * persecondcubmillimetersqr_.Factor, maxValue * persecondcubmillimetersqr_.Factor);
		public static PerTimeLengthSqr FromPerSecondCubMillimeterSqrs(double value) => new PerTimeLengthSqr(value * persecondcubmillimetersqr_.Factor);
		public double GetValueInPerSecondCubMillimeterSqrs() => Value_ / persecondcubmillimetersqr_.Factor;
		public static PerTimeLengthSqr FromPerSecondCubMeterSqrs(double value, double minValue, double maxValue) => new PerTimeLengthSqr(value * persecondcubmetersqr_.Factor, minValue * persecondcubmetersqr_.Factor, maxValue * persecondcubmetersqr_.Factor);
		public static PerTimeLengthSqr FromPerSecondCubMeterSqrs(double value) => new PerTimeLengthSqr(value * persecondcubmetersqr_.Factor);
		public double GetValueInPerSecondCubMeterSqrs() => Value_ / persecondcubmetersqr_.Factor;
		public static PerTimeLengthSqr FromPerSecondCubInchSqrs(double value, double minValue, double maxValue) => new PerTimeLengthSqr(value * persecondcubinchsqr_.Factor, minValue * persecondcubinchsqr_.Factor, maxValue * persecondcubinchsqr_.Factor);
		public static PerTimeLengthSqr FromPerSecondCubInchSqrs(double value) => new PerTimeLengthSqr(value * persecondcubinchsqr_.Factor);
		public double GetValueInPerSecondCubInchSqrs() => Value_ / persecondcubinchsqr_.Factor;

#endregion

#region arithmetic
		public static PerTimeLengthSqr operator+(PerTimeLengthSqr o1, PerTimeLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ + o2.Value_);
		public static PerTimeLengthSqr operator-(PerTimeLengthSqr o1, PerTimeLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTimeLengthSqr o1, PerTimeLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerTimeLengthSqr o1, TimePerLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimePerLengthSqr o1, PerTimeLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerTimeLengthSqr o1, MassPerLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerLengthSqr o1, PerTimeLengthSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(PerTimeLengthSqr o1, PerLengthMassTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerLengthMassTime o1, PerTimeLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(PerTimeLengthSqr o1, PerLengthMassTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerLengthMassTime o1, PerTimeLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerTimeLengthSqr o1, TimePerLengthMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimePerLengthMass o1, PerTimeLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerTimeLengthSqr o1, TimePerLengthMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimePerLengthMass o1, PerTimeLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerTimeLengthSqr o1, PerLengthTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerLengthTimeSqr o1, PerTimeLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimePerLength operator/(PerTimeLengthSqr o1, PerLengthTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthTimeSqr o1, PerTimeLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerTimeLengthSqr o1, TimeSqrPerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeSqrPerLength o1, PerTimeLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrPerLength o1, PerTimeLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(PerTimeLengthSqr o1, MassPerLengthTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(MassPerLengthTime o1, PerTimeLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthMass operator/(PerTimeLengthSqr o1, MassPerLengthTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerLengthTime o1, PerTimeLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerTimeLengthSqr o1, MassTimePerLength o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(MassTimePerLength o1, PerTimeLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerTimeLengthSqr o1, MassTimePerLength o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(MassTimePerLength o1, PerTimeLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerTimeLengthSqr o1, PerMassTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(PerMassTimeSqr o1, PerTimeLengthSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator/(PerTimeLengthSqr o1, PerMassTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(PerMassTimeSqr o1, PerTimeLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerTimeLengthSqr o1, TimeSqrPerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeSqrPerMass o1, PerTimeLengthSqr o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeSqrPerMass o1, PerTimeLengthSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(PerTimeLengthSqr o1, PerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(PerTimeCub o1, PerTimeLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerTimeLengthSqr o1, TimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCub o1, PerTimeLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerTimeLengthSqr o1, MassPerTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(MassPerTimeSqr o1, PerTimeLengthSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(PerTimeLengthSqr o1, MassPerTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(MassPerTimeSqr o1, PerTimeLengthSqr o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerTimeLengthSqr o1, TimeSqrMass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeSqrMass o1, PerTimeLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerTimeLengthSqr o1, TimeSqrMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeSqrMass o1, PerTimeLengthSqr o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(PerTimeLengthSqr o1, LengthPerMassTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(LengthPerMassTime o1, PerTimeLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static Density operator/(PerTimeLengthSqr o1, LengthPerMassTime o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthPerMassTime o1, PerTimeLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerTimeLengthSqr o1, LengthTimePerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(LengthTimePerMass o1, PerTimeLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(PerTimeLengthSqr o1, LengthTimePerMass o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthTimePerMass o1, PerTimeLengthSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(PerTimeLengthSqr o1, Acceleration o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(Acceleration o1, PerTimeLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator/(PerTimeLengthSqr o1, Acceleration o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(Acceleration o1, PerTimeLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerTimeLengthSqr o1, TimeSqrLength o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrLength o1, PerTimeLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator/(PerTimeLengthSqr o1, TimeSqrLength o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeSqrLength o1, PerTimeLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(PerTimeLengthSqr o1, LengthMassPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(LengthMassPerTime o1, PerTimeLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(PerTimeLengthSqr o1, LengthMassPerTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthMassPerTime o1, PerTimeLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerTimeLengthSqr o1, LengthMassTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(LengthMassTime o1, PerTimeLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerTimeLengthSqr o1, LengthMassTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthMassTime o1, PerTimeLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(PerTimeLengthSqr o1, LengthSqrPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthSqrPerMass o1, PerTimeLengthSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(PerTimeLengthSqr o1, LengthSqrPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthSqrPerTime o1, PerTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerTimeLengthSqr o1, LengthSqrTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthSqrTime o1, PerTimeLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(PerTimeLengthSqr o1, LengthSqrMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthSqrMass o1, PerTimeLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerTimeLengthSqr o1, Volume o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(Volume o1, PerTimeLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(PerTimeLengthSqr o1, PerMassLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(PerMassLengthCub o1, PerTimeLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(PerTimeLengthSqr o1, PerTimeLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerTimeLengthCub o1, PerTimeLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(PerTimeLengthSqr o1, TimePerLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimePerLengthCub o1, PerTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator/(PerTimeLengthSqr o1, Density o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(Density o1, PerTimeLengthSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static Mass operator/(PerTimeLengthSqr o1, PerMassTimeLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassTimeLengthSqr o1, PerTimeLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(PerTimeLengthSqr o1, TimePerMassLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimePerMassLengthSqr o1, PerTimeLengthSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerTimeLengthSqr o1, PerLengthSqrTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerLengthSqrTimeSqr o1, PerTimeLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrPerLengthSqr o1, PerTimeLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(PerTimeLengthSqr o1, MassPerTimeLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerTimeLengthSqr o1, PerTimeLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(PerTimeLengthSqr o1, MassTimePerLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(MassTimePerLengthSqr o1, PerTimeLengthSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCubTimeCub operator*(PerTimeLengthSqr o1, PerLengthMassTimeSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator*(PerLengthMassTimeSqr o1, PerTimeLengthSqr o2) => new PerMassLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(PerTimeLengthSqr o1, PerLengthMassTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerLengthMassTimeSqr o1, PerTimeLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(PerTimeLengthSqr o1, TimeSqrPerLengthMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(TimeSqrPerLengthMass o1, PerTimeLengthSqr o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerLengthMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeSqrPerLengthMass o1, PerTimeLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(PerTimeLengthSqr o1, PerLengthTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerLengthTimeCub o1, PerTimeLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(PerTimeLengthSqr o1, TimeCubPerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeCubPerLength o1, PerTimeLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(PerTimeLengthSqr o1, MassPerLengthTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(MassPerLengthTimeSqr o1, PerTimeLengthSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator/(PerTimeLengthSqr o1, MassPerLengthTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerLengthTimeSqr o1, PerTimeLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(PerTimeLengthSqr o1, TimeSqrMassPerLength o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimeSqrMassPerLength o1, PerTimeLengthSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator/(PerTimeLengthSqr o1, TimeSqrMassPerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeSqrMassPerLength o1, PerTimeLengthSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator/(PerTimeLengthSqr o1, PerMassTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(PerMassTimeCub o1, PerTimeLengthSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(PerTimeLengthSqr o1, TimeCubPerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimeCubPerMass o1, PerTimeLengthSqr o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator/(PerTimeLengthSqr o1, MassPerTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(MassPerTimeCub o1, PerTimeLengthSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(PerTimeLengthSqr o1, TimeCubMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeCubMass o1, PerTimeLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerTimeLengthSqr o1, LengthPerMassTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(LengthPerMassTimeSqr o1, PerTimeLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator/(PerTimeLengthSqr o1, LengthPerMassTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthPerMassTimeSqr o1, PerTimeLengthSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerTimeLengthSqr o1, TimeSqrLengthPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeSqrLengthPerMass o1, PerTimeLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerTimeLengthSqr o1, TimeSqrLengthPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeSqrLengthPerMass o1, PerTimeLengthSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(PerTimeLengthSqr o1, LengthPerTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthPerTimeCub o1, PerTimeLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(PerTimeLengthSqr o1, TimeCubLength o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubLength o1, PerTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(PerTimeLengthSqr o1, Force o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(Force o1, PerTimeLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(PerTimeLengthSqr o1, Force o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(Force o1, PerTimeLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(PerTimeLengthSqr o1, TimeSqrLengthMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeSqrLengthMass o1, PerTimeLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static PerMassLengthCubTimeCub operator/(PerTimeLengthSqr o1, TimeSqrLengthMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubMass operator/(TimeSqrLengthMass o1, PerTimeLengthSqr o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(PerTimeLengthSqr o1, LengthSqrPerMassTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthSqrPerMassTime o1, PerTimeLengthSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(PerTimeLengthSqr o1, LengthSqrTimePerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthSqrTimePerMass o1, PerTimeLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(PerTimeLengthSqr o1, QDose o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(QDose o1, PerTimeLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerTimeLengthSqr o1, LengthSqrTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthSqrTimeSqr o1, PerTimeLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(PerTimeLengthSqr o1, LengthSqrMassPerTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(LengthSqrMassPerTime o1, PerTimeLengthSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Mass operator*(PerTimeLengthSqr o1, LengthSqrMassTime o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthSqrMassTime o1, PerTimeLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator*(PerTimeLengthSqr o1, LengthCubPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthCubPerMass o1, PerTimeLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(PerTimeLengthSqr o1, LengthCubPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthCubPerTime o1, PerTimeLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerTimeLengthSqr o1, LengthCubTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubTime o1, PerTimeLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(PerTimeLengthSqr o1, LengthCubMass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthCubMass o1, PerTimeLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthMass operator/(PerTimeLengthSqr o1, PerMassTimeLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerMassTimeLengthCub o1, PerTimeLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static Force operator/(PerTimeLengthSqr o1, TimePerMassLengthCub o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimePerMassLengthCub o1, PerTimeLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator/(PerTimeLengthSqr o1, PerTimeSqrLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerTimeSqrLengthCub o1, PerTimeLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeSqrPerLengthCub o1, PerTimeLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator/(PerTimeLengthSqr o1, MassPerTimeLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerTimeLengthCub o1, PerTimeLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator/(PerTimeLengthSqr o1, MassTimePerLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLength operator/(MassTimePerLengthCub o1, PerTimeLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		
		public static MassTime operator/(PerTimeLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerMassLengthSqrTimeSqr o1, PerTimeLengthSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeSqrPerMassLengthSqr o1, PerTimeLengthSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(PerTimeLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerLengthSqrTimeCub o1, PerTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerTimeLengthSqr o1, MassPerLengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerLengthSqrTimeSqr o1, PerTimeLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerTimeLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeSqrMassPerLengthSqr o1, PerTimeLengthSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(PerTimeLengthSqr o1, PerLengthMassTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerLengthMassTimeCub o1, PerTimeLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerTimeLengthSqr o1, TimeCubPerLengthMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeCubPerLengthMass o1, PerTimeLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(PerTimeLengthSqr o1, MassPerLengthTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(MassPerLengthTimeCub o1, PerTimeLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(PerTimeLengthSqr o1, TimeCubMassPerLength o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeCubMassPerLength o1, PerTimeLengthSqr o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator/(PerTimeLengthSqr o1, LengthPerMassTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthPerMassTimeCub o1, PerTimeLengthSqr o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerTimeLengthSqr o1, TimeCubLengthPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeCubLengthPerMass o1, PerTimeLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator/(PerTimeLengthSqr o1, LengthMassPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthMassPerTimeCub o1, PerTimeLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(PerTimeLengthSqr o1, TimeCubLengthMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCubLengthMass o1, PerTimeLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerTimeLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthSqrPerMassTimeSqr o1, PerTimeLengthSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerTimeLengthSqr o1, LengthSqrTimeSqrPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthSqrTimeSqrPerMass o1, PerTimeLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(PerTimeLengthSqr o1, TimeCubLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubLengthSqr o1, PerTimeLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerTimeLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerTimeLengthSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(PerTimeLengthSqr o1, LengthSqrTimeSqrMass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthSqrTimeSqrMass o1, PerTimeLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerTimeLengthSqr o1, LengthCubPerMassTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthCubPerMassTime o1, PerTimeLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator*(PerTimeLengthSqr o1, LengthCubTimePerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthCubTimePerMass o1, PerTimeLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerTimeLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthCubPerTimeSqr o1, PerTimeLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(PerTimeLengthSqr o1, LengthCubTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubTimeSqr o1, PerTimeLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static Force operator*(PerTimeLengthSqr o1, LengthCubMassPerTime o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthCubMassPerTime o1, PerTimeLengthSqr o2) => new Force(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(PerTimeLengthSqr o1, LengthCubMassTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthCubMassTime o1, PerTimeLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(PerTimeLengthSqr o1, PerMassTimeSqrLengthCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerMassTimeSqrLengthCub o1, PerTimeLengthSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTimeCub operator/(PerTimeLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeSqrPerMassLengthCub o1, PerTimeLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(PerTimeLengthSqr o1, PerLengthCubTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerLengthCubTimeCub o1, PerTimeLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(PerTimeLengthSqr o1, MassPerTimeSqrLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(MassPerTimeSqrLengthCub o1, PerTimeLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator/(PerTimeLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeSqrMassPerLengthCub o1, PerTimeLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator/(PerTimeLengthSqr o1, PerMassLengthSqrTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerTimeLengthSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerTimeLengthSqr o1, MassPerLengthSqrTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(MassPerLengthSqrTimeCub o1, PerTimeLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator*(PerTimeLengthSqr o1, TimeCubLengthSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeCubLengthSqrPerMass o1, PerTimeLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(PerTimeLengthSqr o1, TimeCubLengthSqrMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeCubLengthSqrMass o1, PerTimeLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerTimeLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthCubPerMassTimeSqr o1, PerTimeLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator*(PerTimeLengthSqr o1, LengthCubTimeSqrPerMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthCubTimeSqrPerMass o1, PerTimeLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(PerTimeLengthSqr o1, LengthCubTimeCub o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthCubTimeCub o1, PerTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(PerTimeLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerTimeLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator*(PerTimeLengthSqr o1, LengthCubTimeSqrMass o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(LengthCubTimeSqrMass o1, PerTimeLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthMass operator/(PerTimeLengthSqr o1, PerMassLengthCubTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeSqr operator/(PerMassLengthCubTimeCub o1, PerTimeLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator/(PerTimeLengthSqr o1, MassPerLengthCubTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(MassPerLengthCubTimeCub o1, PerTimeLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(PerTimeLengthSqr o1, LengthCubTimeCubPerMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthCubTimeCubPerMass o1, PerTimeLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthMass operator*(PerTimeLengthSqr o1, LengthCubTimeCubMass o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthCubTimeCubMass o1, PerTimeLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTimeLengthSqr pertimelengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertimelengthsqr.HasMinValue && pertimelengthsqr.Value_ < pertimelengthsqr.MinValue)
        {
            fail = true;
        }

        if (pertimelengthsqr.HasMaxValue && pertimelengthsqr.Value_ > pertimelengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTimeLengthSqr is outside its bounds.");
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
    