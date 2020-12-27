
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassLengthCub : Quantity, IEquatable<PerMassLengthCub>, IComparable
    {
    internal PerMassLengthCub(double value) : base(value, 2)
    {
        PerMassLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassLengthCub(PerMassLengthCub other) : base(other)
    {
        PerMassLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthCub"))
        {
            switch(FakeDatabase.Units["PerMassLengthCub"])
            {
				      case "perkilogramcubcentimetercub": displayUnit_ = perkilogramcubcentimetercub_; break;
				      case "perkilogramcubmillimetercub": displayUnit_ = perkilogramcubmillimetercub_; break;
				      case "perkilogramcubmetercub": displayUnit_ = perkilogramcubmetercub_; break;
				      case "perkilogramcubinchcub": displayUnit_ = perkilogramcubinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubcentimetercub_ = new Unit_("PerKilogramCubCentimeterCub", "/kg³ cm³", 1.0);
	private static Unit_ perkilogramcubmillimetercub_ = new Unit_("PerKilogramCubMillimeterCub", "/kg³ mm³", 999.9999999999998);
	private static Unit_ perkilogramcubmetercub_ = new Unit_("PerKilogramCubMeterCub", "/kg³ m³", 1e-06);
	private static Unit_ perkilogramcubinchcub_ = new Unit_("PerKilogramCubInchCub", "/kg³ in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = perkilogramcubcentimetercub_;
	private static Unit_ displayUnit_ = perkilogramcubcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(PerMassLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassLengthCub other)) throw new ArgumentException("Object is not a PerMassLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassLengthCub l1, PerMassLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassLengthCub l1, PerMassLengthCub l2) => !(l1 == l2);
    public static bool operator <(PerMassLengthCub l1, PerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassLengthCub l1, PerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassLengthCub l1, PerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassLengthCub l1, PerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassLengthCub FromPerKilogramCubCentimeterCubs(double value, double minValue, double maxValue) => new PerMassLengthCub(value * perkilogramcubcentimetercub_.Factor, minValue * perkilogramcubcentimetercub_.Factor, maxValue * perkilogramcubcentimetercub_.Factor);
		public static PerMassLengthCub FromPerKilogramCubCentimeterCubs(double value) => new PerMassLengthCub(value * perkilogramcubcentimetercub_.Factor);
		public double GetValueInPerKilogramCubCentimeterCubs() => Value_ / perkilogramcubcentimetercub_.Factor;
		public static PerMassLengthCub FromPerKilogramCubMillimeterCubs(double value, double minValue, double maxValue) => new PerMassLengthCub(value * perkilogramcubmillimetercub_.Factor, minValue * perkilogramcubmillimetercub_.Factor, maxValue * perkilogramcubmillimetercub_.Factor);
		public static PerMassLengthCub FromPerKilogramCubMillimeterCubs(double value) => new PerMassLengthCub(value * perkilogramcubmillimetercub_.Factor);
		public double GetValueInPerKilogramCubMillimeterCubs() => Value_ / perkilogramcubmillimetercub_.Factor;
		public static PerMassLengthCub FromPerKilogramCubMeterCubs(double value, double minValue, double maxValue) => new PerMassLengthCub(value * perkilogramcubmetercub_.Factor, minValue * perkilogramcubmetercub_.Factor, maxValue * perkilogramcubmetercub_.Factor);
		public static PerMassLengthCub FromPerKilogramCubMeterCubs(double value) => new PerMassLengthCub(value * perkilogramcubmetercub_.Factor);
		public double GetValueInPerKilogramCubMeterCubs() => Value_ / perkilogramcubmetercub_.Factor;
		public static PerMassLengthCub FromPerKilogramCubInchCubs(double value, double minValue, double maxValue) => new PerMassLengthCub(value * perkilogramcubinchcub_.Factor, minValue * perkilogramcubinchcub_.Factor, maxValue * perkilogramcubinchcub_.Factor);
		public static PerMassLengthCub FromPerKilogramCubInchCubs(double value) => new PerMassLengthCub(value * perkilogramcubinchcub_.Factor);
		public double GetValueInPerKilogramCubInchCubs() => Value_ / perkilogramcubinchcub_.Factor;

#endregion

#region arithmetic
		public static PerMassLengthCub operator+(PerMassLengthCub o1, PerMassLengthCub o2) => new PerMassLengthCub(o1.Value_ + o2.Value_);
		public static PerMassLengthCub operator-(PerMassLengthCub o1, PerMassLengthCub o2) => new PerMassLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassLengthCub o1, PerMassLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerMassLengthCub o1, PerTimeLengthCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerTimeLengthCub o1, PerMassLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerMassLengthCub o1, TimePerLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimePerLengthCub o1, PerMassLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerMassLengthCub o1, PerMassTimeLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerMassTimeLengthSqr o1, PerMassLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(PerMassLengthCub o1, TimePerMassLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimePerMassLengthSqr o1, PerMassLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(PerMassLengthCub o1, PerLengthSqrTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(PerLengthSqrTimeSqr o1, PerMassLengthCub o2) => new Force(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerLengthSqr o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(TimeSqrPerLengthSqr o1, PerMassLengthCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(PerMassLengthCub o1, PerLengthMassTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(PerLengthMassTimeSqr o1, PerMassLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeSqrPerLengthMass o1, PerMassLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator/(PerMassLengthCub o1, PerLengthTimeCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(PerLengthTimeCub o1, PerMassLengthCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator/(PerMassLengthCub o1, TimeCubPerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrMass operator/(TimeCubPerLength o1, PerMassLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator/(PerMassLengthCub o1, PerMassTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(PerMassTimeCub o1, PerMassLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(PerMassLengthCub o1, TimeCubPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeCubPerMass o1, PerMassLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerMassLengthCub o1, MassPerTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(MassPerTimeCub o1, PerMassLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(PerMassLengthCub o1, TimeCubMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeCubMass o1, PerMassLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqrTimeCub operator*(PerMassLengthCub o1, LengthPerTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeCub operator*(LengthPerTimeCub o1, PerMassLengthCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(PerMassLengthCub o1, TimeCubLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimeCubLength o1, PerMassLengthCub o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(PerMassLengthCub o1, Force o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(Force o1, PerMassLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerMassLengthCub o1, TimeSqrLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeSqrLengthMass o1, PerMassLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(PerMassLengthCub o1, QDose o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(QDose o1, PerMassLengthCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerMassLengthCub o1, LengthSqrTimeSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(LengthSqrTimeSqr o1, PerMassLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator*(PerMassLengthCub o1, LengthSqrMassPerTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(LengthSqrMassPerTime o1, PerMassLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(PerMassLengthCub o1, LengthSqrMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(LengthSqrMassTime o1, PerMassLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator*(PerMassLengthCub o1, LengthCubPerTime o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthCubPerTime o1, PerMassLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerMassLengthCub o1, LengthCubTime o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthCubTime o1, PerMassLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerMassLengthCub o1, LengthCubMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubMass o1, PerMassLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerMassLengthCub o1, PerMassTimeLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerMassTimeLengthCub o1, PerMassLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(PerMassLengthCub o1, TimePerMassLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimePerMassLengthCub o1, PerMassLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerMassLengthCub o1, PerTimeSqrLengthCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(PerTimeSqrLengthCub o1, PerMassLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(TimeSqrPerLengthCub o1, PerMassLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(PerMassLengthCub o1, PerMassLengthSqrTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerMassLengthSqrTimeSqr o1, PerMassLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerMassLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeSqrPerMassLengthSqr o1, PerMassLengthCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator/(PerMassLengthCub o1, PerLengthSqrTimeCub o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(PerLengthSqrTimeCub o1, PerMassLengthCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator/(PerMassLengthCub o1, TimeCubPerLengthSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(TimeCubPerLengthSqr o1, PerMassLengthCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(PerMassLengthCub o1, PerLengthMassTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(PerLengthMassTimeCub o1, PerMassLengthCub o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(PerMassLengthCub o1, TimeCubPerLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeCubPerLengthMass o1, PerMassLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(PerMassLengthCub o1, LengthMassPerTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(LengthMassPerTimeCub o1, PerMassLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(PerMassLengthCub o1, TimeCubLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeCubLengthMass o1, PerMassLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeCub operator*(PerMassLengthCub o1, LengthSqrPerTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(LengthSqrPerTimeCub o1, PerMassLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthMass operator*(PerMassLengthCub o1, TimeCubLengthSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimeCubLengthSqr o1, PerMassLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator*(PerMassLengthCub o1, LengthSqrMassPerTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(LengthSqrMassPerTimeSqr o1, PerMassLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(PerMassLengthCub o1, LengthSqrTimeSqrMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(LengthSqrTimeSqrMass o1, PerMassLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqr operator*(PerMassLengthCub o1, LengthCubPerTimeSqr o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthCubPerTimeSqr o1, PerMassLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMass operator*(PerMassLengthCub o1, LengthCubTimeSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(LengthCubTimeSqr o1, PerMassLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(PerMassLengthCub o1, LengthCubMassPerTime o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthCubMassPerTime o1, PerMassLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerMassLengthCub o1, LengthCubMassTime o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubMassTime o1, PerMassLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(PerMassLengthCub o1, PerMassTimeSqrLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerMassTimeSqrLengthCub o1, PerMassLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerMassLengthCub o1, TimeSqrPerMassLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeSqrPerMassLengthCub o1, PerMassLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator/(PerMassLengthCub o1, PerLengthCubTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(PerLengthCubTimeCub o1, PerMassLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerMassLengthCub o1, TimeCubPerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeCubPerLengthCub o1, PerMassLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator/(PerMassLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(PerMassLengthSqrTimeCub o1, PerMassLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(PerMassLengthCub o1, TimeCubPerMassLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeCubPerMassLengthSqr o1, PerMassLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(PerMassLengthCub o1, LengthSqrMassPerTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(LengthSqrMassPerTimeCub o1, PerMassLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(PerMassLengthCub o1, TimeCubLengthSqrMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeCubLengthSqrMass o1, PerMassLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerMassLengthCub o1, LengthCubPerTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthCubPerTimeCub o1, PerMassLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerMass operator*(PerMassLengthCub o1, LengthCubTimeCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(LengthCubTimeCub o1, PerMassLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(PerMassLengthCub o1, LengthCubMassPerTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthCubMassPerTimeSqr o1, PerMassLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(PerMassLengthCub o1, LengthCubTimeSqrMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthCubTimeSqrMass o1, PerMassLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(PerMassLengthCub o1, PerMassLengthCubTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(PerMassLengthCubTimeCub o1, PerMassLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeCubPerMassLengthCub o1, PerMassLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(PerMassLengthCub o1, LengthCubMassPerTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthCubMassPerTimeCub o1, PerMassLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(PerMassLengthCub o1, LengthCubTimeCubMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(LengthCubTimeCubMass o1, PerMassLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassLengthCub permasslengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasslengthcub.HasMinValue && permasslengthcub.Value_ < permasslengthcub.MinValue)
        {
            fail = true;
        }

        if (permasslengthcub.HasMaxValue && permasslengthcub.Value_ > permasslengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassLengthCub is outside its bounds.");
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
    