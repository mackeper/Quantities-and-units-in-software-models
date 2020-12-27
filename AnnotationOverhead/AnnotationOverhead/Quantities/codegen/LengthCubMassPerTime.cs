
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubMassPerTime : Quantity, IEquatable<LengthCubMassPerTime>, IComparable
    {
    internal LengthCubMassPerTime(double value) : base(value, 2)
    {
        LengthCubMassPerTime.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubMassPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubMassPerTime(LengthCubMassPerTime other) : base(other)
    {
        LengthCubMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubMassPerTime"))
        {
            switch(FakeDatabase.Units["LengthCubMassPerTime"])
            {
				      case "centimetercubkilogrampersecond": displayUnit_ = centimetercubkilogrampersecond_; break;
				      case "millimetercubkilogrampersecond": displayUnit_ = millimetercubkilogrampersecond_; break;
				      case "metercubkilogrampersecond": displayUnit_ = metercubkilogrampersecond_; break;
				      case "inchcubkilogrampersecond": displayUnit_ = inchcubkilogrampersecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubkilogrampersecond_ = new Unit_("CentimeterCubKilogramPerSecond", "cm³ kg/s", 1.0);
	private static Unit_ millimetercubkilogrampersecond_ = new Unit_("MillimeterCubKilogramPerSecond", "mm³ kg/s", 0.0010000000000000002);
	private static Unit_ metercubkilogrampersecond_ = new Unit_("MeterCubKilogramPerSecond", "m³ kg/s", 1000000.0);
	private static Unit_ inchcubkilogrampersecond_ = new Unit_("InchCubKilogramPerSecond", "in³ kg/s", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubkilogrampersecond_;
	private static Unit_ displayUnit_ = centimetercubkilogrampersecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubMassPerTime other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubMassPerTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubMassPerTime other)) throw new ArgumentException("Object is not a LengthCubMassPerTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => !(l1 == l2);
    public static bool operator <(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubMassPerTime l1, LengthCubMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubMassPerTime FromCentimeterCubKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthCubMassPerTime(value * centimetercubkilogrampersecond_.Factor, minValue * centimetercubkilogrampersecond_.Factor, maxValue * centimetercubkilogrampersecond_.Factor);
		public static LengthCubMassPerTime FromCentimeterCubKilogramPerSeconds(double value) => new LengthCubMassPerTime(value * centimetercubkilogrampersecond_.Factor);
		public double GetValueInCentimeterCubKilogramPerSeconds() => Value_ / centimetercubkilogrampersecond_.Factor;
		public static LengthCubMassPerTime FromMillimeterCubKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthCubMassPerTime(value * millimetercubkilogrampersecond_.Factor, minValue * millimetercubkilogrampersecond_.Factor, maxValue * millimetercubkilogrampersecond_.Factor);
		public static LengthCubMassPerTime FromMillimeterCubKilogramPerSeconds(double value) => new LengthCubMassPerTime(value * millimetercubkilogrampersecond_.Factor);
		public double GetValueInMillimeterCubKilogramPerSeconds() => Value_ / millimetercubkilogrampersecond_.Factor;
		public static LengthCubMassPerTime FromMeterCubKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthCubMassPerTime(value * metercubkilogrampersecond_.Factor, minValue * metercubkilogrampersecond_.Factor, maxValue * metercubkilogrampersecond_.Factor);
		public static LengthCubMassPerTime FromMeterCubKilogramPerSeconds(double value) => new LengthCubMassPerTime(value * metercubkilogrampersecond_.Factor);
		public double GetValueInMeterCubKilogramPerSeconds() => Value_ / metercubkilogrampersecond_.Factor;
		public static LengthCubMassPerTime FromInchCubKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthCubMassPerTime(value * inchcubkilogrampersecond_.Factor, minValue * inchcubkilogrampersecond_.Factor, maxValue * inchcubkilogrampersecond_.Factor);
		public static LengthCubMassPerTime FromInchCubKilogramPerSeconds(double value) => new LengthCubMassPerTime(value * inchcubkilogrampersecond_.Factor);
		public double GetValueInInchCubKilogramPerSeconds() => Value_ / inchcubkilogrampersecond_.Factor;

#endregion

#region arithmetic
		public static LengthCubMassPerTime operator+(LengthCubMassPerTime o1, LengthCubMassPerTime o2) => new LengthCubMassPerTime(o1.Value_ + o2.Value_);
		public static LengthCubMassPerTime operator-(LengthCubMassPerTime o1, LengthCubMassPerTime o2) => new LengthCubMassPerTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubMassPerTime o1, LengthCubMassPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthCubMassPerTime o1, LengthCubMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthCubMassTime o1, LengthCubMassPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(LengthCubMassPerTime o1, PerMassTimeSqrLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(PerMassTimeSqrLengthCub o1, LengthCubMassPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthCubMassPerTime o1, TimeSqrPerMassLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrPerMassLengthCub o1, LengthCubMassPerTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(LengthCubMassPerTime o1, TimeCubPerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeCubPerLengthCub o1, LengthCubMassPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(LengthCubMassPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubPerMassLengthSqr o1, LengthCubMassPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(LengthCubMassPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(LengthSqrMassPerTimeCub o1, LengthCubMassPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator/(LengthCubMassPerTime o1, LengthCubPerTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(LengthCubPerTimeCub o1, LengthCubMassPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static Time operator/(LengthCubMassPerTime o1, LengthCubMassPerTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthCubMassPerTimeSqr o1, LengthCubMassPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthCubMassPerTime o1, LengthCubTimeSqrMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(LengthCubTimeSqrMass o1, LengthCubMassPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(LengthCubMassPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubPerMassLengthCub o1, LengthCubMassPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(LengthCubMassPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthCubMassPerTimeCub o1, LengthCubMassPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubMassPerTime lengthcubmasspertime, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubmasspertime.HasMinValue && lengthcubmasspertime.Value_ < lengthcubmasspertime.MinValue)
        {
            fail = true;
        }

        if (lengthcubmasspertime.HasMaxValue && lengthcubmasspertime.Value_ > lengthcubmasspertime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubMassPerTime is outside its bounds.");
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
    