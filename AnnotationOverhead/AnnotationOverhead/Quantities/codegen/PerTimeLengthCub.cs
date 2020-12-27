
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTimeLengthCub : Quantity, IEquatable<PerTimeLengthCub>, IComparable
    {
    internal PerTimeLengthCub(double value) : base(value, 2)
    {
        PerTimeLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerTimeLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTimeLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTimeLengthCub(PerTimeLengthCub other) : base(other)
    {
        PerTimeLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTimeLengthCub"))
        {
            switch(FakeDatabase.Units["PerTimeLengthCub"])
            {
				      case "persecondcubcentimetercub": displayUnit_ = persecondcubcentimetercub_; break;
				      case "persecondcubmillimetercub": displayUnit_ = persecondcubmillimetercub_; break;
				      case "persecondcubmetercub": displayUnit_ = persecondcubmetercub_; break;
				      case "persecondcubinchcub": displayUnit_ = persecondcubinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ persecondcubcentimetercub_ = new Unit_("PerSecondCubCentimeterCub", "/s³ cm³", 1.0);
	private static Unit_ persecondcubmillimetercub_ = new Unit_("PerSecondCubMillimeterCub", "/s³ mm³", 999.9999999999998);
	private static Unit_ persecondcubmetercub_ = new Unit_("PerSecondCubMeterCub", "/s³ m³", 1e-06);
	private static Unit_ persecondcubinchcub_ = new Unit_("PerSecondCubInchCub", "/s³ in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = persecondcubcentimetercub_;
	private static Unit_ displayUnit_ = persecondcubcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTimeLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(PerTimeLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTimeLengthCub other)) throw new ArgumentException("Object is not a PerTimeLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTimeLengthCub l1, PerTimeLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTimeLengthCub l1, PerTimeLengthCub l2) => !(l1 == l2);
    public static bool operator <(PerTimeLengthCub l1, PerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTimeLengthCub l1, PerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTimeLengthCub l1, PerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTimeLengthCub l1, PerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTimeLengthCub FromPerSecondCubCentimeterCubs(double value, double minValue, double maxValue) => new PerTimeLengthCub(value * persecondcubcentimetercub_.Factor, minValue * persecondcubcentimetercub_.Factor, maxValue * persecondcubcentimetercub_.Factor);
		public static PerTimeLengthCub FromPerSecondCubCentimeterCubs(double value) => new PerTimeLengthCub(value * persecondcubcentimetercub_.Factor);
		public double GetValueInPerSecondCubCentimeterCubs() => Value_ / persecondcubcentimetercub_.Factor;
		public static PerTimeLengthCub FromPerSecondCubMillimeterCubs(double value, double minValue, double maxValue) => new PerTimeLengthCub(value * persecondcubmillimetercub_.Factor, minValue * persecondcubmillimetercub_.Factor, maxValue * persecondcubmillimetercub_.Factor);
		public static PerTimeLengthCub FromPerSecondCubMillimeterCubs(double value) => new PerTimeLengthCub(value * persecondcubmillimetercub_.Factor);
		public double GetValueInPerSecondCubMillimeterCubs() => Value_ / persecondcubmillimetercub_.Factor;
		public static PerTimeLengthCub FromPerSecondCubMeterCubs(double value, double minValue, double maxValue) => new PerTimeLengthCub(value * persecondcubmetercub_.Factor, minValue * persecondcubmetercub_.Factor, maxValue * persecondcubmetercub_.Factor);
		public static PerTimeLengthCub FromPerSecondCubMeterCubs(double value) => new PerTimeLengthCub(value * persecondcubmetercub_.Factor);
		public double GetValueInPerSecondCubMeterCubs() => Value_ / persecondcubmetercub_.Factor;
		public static PerTimeLengthCub FromPerSecondCubInchCubs(double value, double minValue, double maxValue) => new PerTimeLengthCub(value * persecondcubinchcub_.Factor, minValue * persecondcubinchcub_.Factor, maxValue * persecondcubinchcub_.Factor);
		public static PerTimeLengthCub FromPerSecondCubInchCubs(double value) => new PerTimeLengthCub(value * persecondcubinchcub_.Factor);
		public double GetValueInPerSecondCubInchCubs() => Value_ / persecondcubinchcub_.Factor;

#endregion

#region arithmetic
		public static PerTimeLengthCub operator+(PerTimeLengthCub o1, PerTimeLengthCub o2) => new PerTimeLengthCub(o1.Value_ + o2.Value_);
		public static PerTimeLengthCub operator-(PerTimeLengthCub o1, PerTimeLengthCub o2) => new PerTimeLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTimeLengthCub o1, PerTimeLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerTimeLengthCub o1, TimePerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimePerLengthCub o1, PerTimeLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerTimeLengthCub o1, Density o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(Density o1, PerTimeLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(PerTimeLengthCub o1, PerMassTimeLengthSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMassTimeLengthSqr o1, PerTimeLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(PerTimeLengthCub o1, TimePerMassLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimePerMassLengthSqr o1, PerTimeLengthCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerTimeLengthCub o1, PerLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthSqrTimeSqr o1, PerTimeLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrPerLengthSqr o1, PerTimeLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(PerTimeLengthCub o1, MassPerTimeLengthSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerTimeLengthSqr o1, PerTimeLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(PerTimeLengthCub o1, MassTimePerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(MassTimePerLengthSqr o1, PerTimeLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator/(PerTimeLengthCub o1, PerLengthMassTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(PerLengthMassTimeSqr o1, PerTimeLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerLengthMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeSqrPerLengthMass o1, PerTimeLengthCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(PerTimeLengthCub o1, PerLengthTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(PerLengthTimeCub o1, PerTimeLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator/(PerTimeLengthCub o1, MassPerLengthTimeSqr o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(MassPerLengthTimeSqr o1, PerTimeLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator/(PerTimeLengthCub o1, TimeSqrMassPerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeSqrMassPerLength o1, PerTimeLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator/(PerTimeLengthCub o1, PerMassTimeCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(PerMassTimeCub o1, PerTimeLengthCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerTimeLengthCub o1, TimeCubPerMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeCubPerMass o1, PerTimeLengthCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator/(PerTimeLengthCub o1, MassPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(MassPerTimeCub o1, PerTimeLengthCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthCub operator*(PerTimeLengthCub o1, TimeCubMass o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator*(TimeCubMass o1, PerTimeLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerTimeLengthCub o1, LengthPerMassTimeSqr o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(LengthPerMassTimeSqr o1, PerTimeLengthCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerTimeLengthCub o1, TimeSqrLengthPerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeSqrLengthPerMass o1, PerTimeLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerTimeLengthCub o1, TimeCubLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubLength o1, PerTimeLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(PerTimeLengthCub o1, Force o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(Force o1, PerTimeLengthCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerTimeLengthCub o1, TimeSqrLengthMass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeSqrLengthMass o1, PerTimeLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(PerTimeLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(LengthSqrPerMassTime o1, PerTimeLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator*(PerTimeLengthCub o1, LengthSqrTimePerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(LengthSqrTimePerMass o1, PerTimeLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(PerTimeLengthCub o1, QDose o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(QDose o1, PerTimeLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(PerTimeLengthCub o1, LengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(LengthSqrTimeSqr o1, PerTimeLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(PerTimeLengthCub o1, LengthSqrMassPerTime o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(LengthSqrMassPerTime o1, PerTimeLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(PerTimeLengthCub o1, LengthSqrMassTime o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(LengthSqrMassTime o1, PerTimeLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator*(PerTimeLengthCub o1, LengthCubPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthCubPerMass o1, PerTimeLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(PerTimeLengthCub o1, LengthCubPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthCubPerTime o1, PerTimeLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerTimeLengthCub o1, LengthCubTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTime o1, PerTimeLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(PerTimeLengthCub o1, LengthCubMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthCubMass o1, PerTimeLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static Mass operator/(PerTimeLengthCub o1, PerMassTimeLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassTimeLengthCub o1, PerTimeLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(PerTimeLengthCub o1, TimePerMassLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimePerMassLengthCub o1, PerTimeLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerTimeLengthCub o1, PerTimeSqrLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerTimeSqrLengthCub o1, PerTimeLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrPerLengthCub o1, PerTimeLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(PerTimeLengthCub o1, MassPerTimeLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerTimeLengthCub o1, PerTimeLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(PerTimeLengthCub o1, MassTimePerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(MassTimePerLengthCub o1, PerTimeLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator/(PerTimeLengthCub o1, PerMassLengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerMassLengthSqrTimeSqr o1, PerTimeLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerMassLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeSqrPerMassLengthSqr o1, PerTimeLengthCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(PerTimeLengthCub o1, PerLengthSqrTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerLengthSqrTimeCub o1, PerTimeLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(PerTimeLengthCub o1, MassPerLengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerLengthSqrTimeSqr o1, PerTimeLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator/(PerTimeLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeSqrMassPerLengthSqr o1, PerTimeLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator/(PerTimeLengthCub o1, PerLengthMassTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(PerLengthMassTimeCub o1, PerTimeLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator/(PerTimeLengthCub o1, MassPerLengthTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(MassPerLengthTimeCub o1, PerTimeLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(PerTimeLengthCub o1, TimeCubLengthPerMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(TimeCubLengthPerMass o1, PerTimeLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(PerTimeLengthCub o1, TimeCubLengthMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeCubLengthMass o1, PerTimeLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerTimeLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(LengthSqrPerMassTimeSqr o1, PerTimeLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator*(PerTimeLengthCub o1, LengthSqrTimeSqrPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(LengthSqrTimeSqrPerMass o1, PerTimeLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(PerTimeLengthCub o1, TimeCubLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubLengthSqr o1, PerTimeLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(PerTimeLengthCub o1, LengthSqrMassPerTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerTimeLengthCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(PerTimeLengthCub o1, LengthSqrTimeSqrMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(LengthSqrTimeSqrMass o1, PerTimeLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqr operator*(PerTimeLengthCub o1, LengthCubPerMassTime o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthCubPerMassTime o1, PerTimeLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(PerTimeLengthCub o1, LengthCubTimePerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthCubTimePerMass o1, PerTimeLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(PerTimeLengthCub o1, LengthCubPerTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthCubPerTimeSqr o1, PerTimeLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerTimeLengthCub o1, LengthCubTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubTimeSqr o1, PerTimeLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(PerTimeLengthCub o1, LengthCubMassPerTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(LengthCubMassPerTime o1, PerTimeLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Mass operator*(PerTimeLengthCub o1, LengthCubMassTime o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthCubMassTime o1, PerTimeLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(PerTimeLengthCub o1, PerMassTimeSqrLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerMassTimeSqrLengthCub o1, PerTimeLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerMassLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeSqrPerMassLengthCub o1, PerTimeLengthCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(PerTimeLengthCub o1, PerLengthCubTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerLengthCubTimeCub o1, PerTimeLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerTimeLengthCub o1, MassPerTimeSqrLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerTimeSqrLengthCub o1, PerTimeLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerTimeLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeSqrMassPerLengthCub o1, PerTimeLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(PerTimeLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerTimeLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(PerTimeLengthCub o1, MassPerLengthSqrTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(MassPerLengthSqrTimeCub o1, PerTimeLengthCub o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerTimeLengthCub o1, TimeCubLengthSqrPerMass o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeCubLengthSqrPerMass o1, PerTimeLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator*(PerTimeLengthCub o1, TimeCubLengthSqrMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCubLengthSqrMass o1, PerTimeLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerTimeLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthCubPerMassTimeSqr o1, PerTimeLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerTimeLengthCub o1, LengthCubTimeSqrPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthCubTimeSqrPerMass o1, PerTimeLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(PerTimeLengthCub o1, LengthCubTimeCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthCubTimeCub o1, PerTimeLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerTimeLengthCub o1, LengthCubMassPerTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerTimeLengthCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(PerTimeLengthCub o1, LengthCubTimeSqrMass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthCubTimeSqrMass o1, PerTimeLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator/(PerTimeLengthCub o1, PerMassLengthCubTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerMassLengthCubTimeCub o1, PerTimeLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerTimeLengthCub o1, MassPerLengthCubTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(MassPerLengthCubTimeCub o1, PerTimeLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator*(PerTimeLengthCub o1, LengthCubTimeCubPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(LengthCubTimeCubPerMass o1, PerTimeLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(PerTimeLengthCub o1, LengthCubTimeCubMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(LengthCubTimeCubMass o1, PerTimeLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTimeLengthCub pertimelengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertimelengthcub.HasMinValue && pertimelengthcub.Value_ < pertimelengthcub.MinValue)
        {
            fail = true;
        }

        if (pertimelengthcub.HasMaxValue && pertimelengthcub.Value_ > pertimelengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTimeLengthCub is outside its bounds.");
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
    