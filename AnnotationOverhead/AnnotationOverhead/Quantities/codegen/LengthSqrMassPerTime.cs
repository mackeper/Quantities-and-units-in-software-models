
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthSqrMassPerTime : Quantity, IEquatable<LengthSqrMassPerTime>, IComparable
    {
    internal LengthSqrMassPerTime(double value) : base(value, 2)
    {
        LengthSqrMassPerTime.ImportDisplayUnitFromDatabase_();
    }
    internal LengthSqrMassPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthSqrMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthSqrMassPerTime(LengthSqrMassPerTime other) : base(other)
    {
        LengthSqrMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrMassPerTime"))
        {
            switch(FakeDatabase.Units["LengthSqrMassPerTime"])
            {
				      case "centimetersqrkilogrampersecond": displayUnit_ = centimetersqrkilogrampersecond_; break;
				      case "millimetersqrkilogrampersecond": displayUnit_ = millimetersqrkilogrampersecond_; break;
				      case "metersqrkilogrampersecond": displayUnit_ = metersqrkilogrampersecond_; break;
				      case "inchsqrkilogrampersecond": displayUnit_ = inchsqrkilogrampersecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetersqrkilogrampersecond_ = new Unit_("CentimeterSqrKilogramPerSecond", "cm� kg/s", 1.0);
	private static Unit_ millimetersqrkilogrampersecond_ = new Unit_("MillimeterSqrKilogramPerSecond", "mm� kg/s", 0.010000000000000002);
	private static Unit_ metersqrkilogrampersecond_ = new Unit_("MeterSqrKilogramPerSecond", "m� kg/s", 10000.0);
	private static Unit_ inchsqrkilogrampersecond_ = new Unit_("InchSqrKilogramPerSecond", "in� kg/s", 6.5536);
	private static Unit_ platformUnit_ = centimetersqrkilogrampersecond_;
	private static Unit_ displayUnit_ = centimetersqrkilogrampersecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthSqrMassPerTime other) => other is object && Equals((object)other);
    public int CompareTo(LengthSqrMassPerTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthSqrMassPerTime other)) throw new ArgumentException("Object is not a LengthSqrMassPerTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => !(l1 == l2);
    public static bool operator <(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthSqrMassPerTime l1, LengthSqrMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthSqrMassPerTime FromCentimeterSqrKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthSqrMassPerTime(value * centimetersqrkilogrampersecond_.Factor, minValue * centimetersqrkilogrampersecond_.Factor, maxValue * centimetersqrkilogrampersecond_.Factor);
		public static LengthSqrMassPerTime FromCentimeterSqrKilogramPerSeconds(double value) => new LengthSqrMassPerTime(value * centimetersqrkilogrampersecond_.Factor);
		public double GetValueInCentimeterSqrKilogramPerSeconds() => Value_ / centimetersqrkilogrampersecond_.Factor;
		public static LengthSqrMassPerTime FromMillimeterSqrKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthSqrMassPerTime(value * millimetersqrkilogrampersecond_.Factor, minValue * millimetersqrkilogrampersecond_.Factor, maxValue * millimetersqrkilogrampersecond_.Factor);
		public static LengthSqrMassPerTime FromMillimeterSqrKilogramPerSeconds(double value) => new LengthSqrMassPerTime(value * millimetersqrkilogrampersecond_.Factor);
		public double GetValueInMillimeterSqrKilogramPerSeconds() => Value_ / millimetersqrkilogrampersecond_.Factor;
		public static LengthSqrMassPerTime FromMeterSqrKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthSqrMassPerTime(value * metersqrkilogrampersecond_.Factor, minValue * metersqrkilogrampersecond_.Factor, maxValue * metersqrkilogrampersecond_.Factor);
		public static LengthSqrMassPerTime FromMeterSqrKilogramPerSeconds(double value) => new LengthSqrMassPerTime(value * metersqrkilogrampersecond_.Factor);
		public double GetValueInMeterSqrKilogramPerSeconds() => Value_ / metersqrkilogrampersecond_.Factor;
		public static LengthSqrMassPerTime FromInchSqrKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthSqrMassPerTime(value * inchsqrkilogrampersecond_.Factor, minValue * inchsqrkilogrampersecond_.Factor, maxValue * inchsqrkilogrampersecond_.Factor);
		public static LengthSqrMassPerTime FromInchSqrKilogramPerSeconds(double value) => new LengthSqrMassPerTime(value * inchsqrkilogrampersecond_.Factor);
		public double GetValueInInchSqrKilogramPerSeconds() => Value_ / inchsqrkilogrampersecond_.Factor;

#endregion

#region arithmetic
		public static LengthSqrMassPerTime operator+(LengthSqrMassPerTime o1, LengthSqrMassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ + o2.Value_);
		public static LengthSqrMassPerTime operator-(LengthSqrMassPerTime o1, LengthSqrMassPerTime o2) => new LengthSqrMassPerTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthSqrMassPerTime o1, LengthSqrMassPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthSqrMassPerTime o1, LengthSqrMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthSqrMassTime o1, LengthSqrMassPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(LengthSqrMassPerTime o1, LengthCubPerTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthCubPerTime o1, LengthSqrMassPerTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(LengthSqrMassPerTime o1, LengthCubTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(LengthCubTime o1, LengthSqrMassPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(LengthSqrMassPerTime o1, LengthCubMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthCubMass o1, LengthSqrMassPerTime o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(LengthSqrMassPerTime o1, PerMassTimeLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerMassTimeLengthCub o1, LengthSqrMassPerTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(LengthSqrMassPerTime o1, TimePerMassLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimePerMassLengthCub o1, LengthSqrMassPerTime o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(LengthSqrMassPerTime o1, PerTimeSqrLengthCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(PerTimeSqrLengthCub o1, LengthSqrMassPerTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(LengthSqrMassPerTime o1, TimeSqrPerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeSqrPerLengthCub o1, LengthSqrMassPerTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(LengthSqrMassPerTime o1, PerMassLengthSqrTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(PerMassLengthSqrTimeSqr o1, LengthSqrMassPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthSqrMassPerTime o1, TimeSqrPerMassLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrPerMassLengthSqr o1, LengthSqrMassPerTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(LengthSqrMassPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeCubPerLengthSqr o1, LengthSqrMassPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(LengthSqrMassPerTime o1, TimeCubPerLengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubPerLengthMass o1, LengthSqrMassPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqr operator/(LengthSqrMassPerTime o1, MassPerLengthTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(MassPerLengthTimeCub o1, LengthSqrMassPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(LengthSqrMassPerTime o1, TimeCubLengthPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(TimeCubLengthPerMass o1, LengthSqrMassPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(LengthSqrMassPerTime o1, LengthMassPerTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(LengthMassPerTimeCub o1, LengthSqrMassPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator/(LengthSqrMassPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(LengthSqrPerTimeCub o1, LengthSqrMassPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static Time operator/(LengthSqrMassPerTime o1, LengthSqrMassPerTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthSqrMassPerTimeSqr o1, LengthSqrMassPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthSqrMassPerTime o1, LengthSqrTimeSqrMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(LengthSqrTimeSqrMass o1, LengthSqrMassPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator/(LengthSqrMassPerTime o1, LengthCubPerTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthCubPerTimeSqr o1, LengthSqrMassPerTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator/(LengthSqrMassPerTime o1, LengthCubTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(LengthCubTimeSqr o1, LengthSqrMassPerTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(LengthSqrMassPerTime o1, LengthCubMassPerTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubMassPerTime o1, LengthSqrMassPerTime o2) => new Length(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(LengthSqrMassPerTime o1, LengthCubMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(LengthCubMassTime o1, LengthSqrMassPerTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(LengthSqrMassPerTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(PerMassTimeSqrLengthCub o1, LengthSqrMassPerTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(LengthSqrMassPerTime o1, TimeSqrPerMassLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrPerMassLengthCub o1, LengthSqrMassPerTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator*(LengthSqrMassPerTime o1, TimeCubPerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCubPerLengthCub o1, LengthSqrMassPerTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(LengthSqrMassPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubPerMassLengthSqr o1, LengthSqrMassPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(LengthSqrMassPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthSqrMassPerTimeCub o1, LengthSqrMassPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(LengthSqrMassPerTime o1, LengthCubPerTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthCubPerTimeCub o1, LengthSqrMassPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(LengthSqrMassPerTime o1, LengthCubMassPerTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubMassPerTimeSqr o1, LengthSqrMassPerTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(LengthSqrMassPerTime o1, LengthCubTimeSqrMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthCubTimeSqrMass o1, LengthSqrMassPerTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(LengthSqrMassPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubPerMassLengthCub o1, LengthSqrMassPerTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator/(LengthSqrMassPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(LengthCubMassPerTimeCub o1, LengthSqrMassPerTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthSqrMassPerTime lengthsqrmasspertime, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthsqrmasspertime.HasMinValue && lengthsqrmasspertime.Value_ < lengthsqrmasspertime.MinValue)
        {
            fail = true;
        }

        if (lengthsqrmasspertime.HasMaxValue && lengthsqrmasspertime.Value_ > lengthsqrmasspertime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthSqrMassPerTime is outside its bounds.");
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
    