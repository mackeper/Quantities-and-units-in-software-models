
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubMassTime : Quantity, IEquatable<LengthCubMassTime>, IComparable
    {
    internal LengthCubMassTime(double value) : base(value, 2)
    {
        LengthCubMassTime.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubMassTime(LengthCubMassTime other) : base(other)
    {
        LengthCubMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubMassTime"))
        {
            switch(FakeDatabase.Units["LengthCubMassTime"])
            {
				      case "centimetercubkilogramsecond": displayUnit_ = centimetercubkilogramsecond_; break;
				      case "millimetercubkilogramsecond": displayUnit_ = millimetercubkilogramsecond_; break;
				      case "metercubkilogramsecond": displayUnit_ = metercubkilogramsecond_; break;
				      case "inchcubkilogramsecond": displayUnit_ = inchcubkilogramsecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubkilogramsecond_ = new Unit_("CentimeterCubKilogramSecond", "cm³ kg s", 1);
	private static Unit_ millimetercubkilogramsecond_ = new Unit_("MillimeterCubKilogramSecond", "mm³ kg s", 0.0010000000000000002);
	private static Unit_ metercubkilogramsecond_ = new Unit_("MeterCubKilogramSecond", "m³ kg s", 1000000);
	private static Unit_ inchcubkilogramsecond_ = new Unit_("InchCubKilogramSecond", "in³ kg s", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubkilogramsecond_;
	private static Unit_ displayUnit_ = centimetercubkilogramsecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubMassTime other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubMassTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubMassTime other)) throw new ArgumentException("Object is not a LengthCubMassTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubMassTime l1, LengthCubMassTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubMassTime l1, LengthCubMassTime l2) => !(l1 == l2);
    public static bool operator <(LengthCubMassTime l1, LengthCubMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubMassTime l1, LengthCubMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubMassTime l1, LengthCubMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubMassTime l1, LengthCubMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubMassTime FromCentimeterCubKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubMassTime(value * centimetercubkilogramsecond_.Factor, minValue * centimetercubkilogramsecond_.Factor, maxValue * centimetercubkilogramsecond_.Factor);
		public static LengthCubMassTime FromCentimeterCubKilogramSeconds(double value) => new LengthCubMassTime(value * centimetercubkilogramsecond_.Factor);
		public double GetValueInCentimeterCubKilogramSeconds() => Value_ / centimetercubkilogramsecond_.Factor;
		public static LengthCubMassTime FromMillimeterCubKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubMassTime(value * millimetercubkilogramsecond_.Factor, minValue * millimetercubkilogramsecond_.Factor, maxValue * millimetercubkilogramsecond_.Factor);
		public static LengthCubMassTime FromMillimeterCubKilogramSeconds(double value) => new LengthCubMassTime(value * millimetercubkilogramsecond_.Factor);
		public double GetValueInMillimeterCubKilogramSeconds() => Value_ / millimetercubkilogramsecond_.Factor;
		public static LengthCubMassTime FromMeterCubKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubMassTime(value * metercubkilogramsecond_.Factor, minValue * metercubkilogramsecond_.Factor, maxValue * metercubkilogramsecond_.Factor);
		public static LengthCubMassTime FromMeterCubKilogramSeconds(double value) => new LengthCubMassTime(value * metercubkilogramsecond_.Factor);
		public double GetValueInMeterCubKilogramSeconds() => Value_ / metercubkilogramsecond_.Factor;
		public static LengthCubMassTime FromInchCubKilogramSeconds(double value, double minValue, double maxValue) => new LengthCubMassTime(value * inchcubkilogramsecond_.Factor, minValue * inchcubkilogramsecond_.Factor, maxValue * inchcubkilogramsecond_.Factor);
		public static LengthCubMassTime FromInchCubKilogramSeconds(double value) => new LengthCubMassTime(value * inchcubkilogramsecond_.Factor);
		public double GetValueInInchCubKilogramSeconds() => Value_ / inchcubkilogramsecond_.Factor;

#endregion

#region arithmetic
		public static LengthCubMassTime operator+(LengthCubMassTime o1, LengthCubMassTime o2) => new LengthCubMassTime(o1.Value_ + o2.Value_);
		public static LengthCubMassTime operator-(LengthCubMassTime o1, LengthCubMassTime o2) => new LengthCubMassTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubMassTime o1, LengthCubMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(LengthCubMassTime o1, PerMassTimeSqrLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerMassTimeSqrLengthCub o1, LengthCubMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(LengthCubMassTime o1, TimeSqrPerMassLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqrPerMassLengthCub o1, LengthCubMassTime o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(LengthCubMassTime o1, PerLengthCubTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(PerLengthCubTimeCub o1, LengthCubMassTime o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(LengthCubMassTime o1, PerMassLengthSqrTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(PerMassLengthSqrTimeCub o1, LengthCubMassTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Acceleration operator/(LengthCubMassTime o1, TimeCubLengthSqrMass o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubLengthSqrMass o1, LengthCubMassTime o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(LengthCubMassTime o1, LengthCubTimeCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(LengthCubTimeCub o1, LengthCubMassTime o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCub operator/(LengthCubMassTime o1, LengthCubMassPerTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(LengthCubMassPerTimeSqr o1, LengthCubMassTime o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(LengthCubMassTime o1, LengthCubTimeSqrMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubTimeSqrMass o1, LengthCubMassTime o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(LengthCubMassTime o1, PerMassLengthCubTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(PerMassLengthCubTimeCub o1, LengthCubMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(LengthCubMassTime o1, LengthCubTimeCubMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthCubTimeCubMass o1, LengthCubMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubMassTime lengthcubmasstime, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubmasstime.HasMinValue && lengthcubmasstime.Value_ < lengthcubmasstime.MinValue)
        {
            fail = true;
        }

        if (lengthcubmasstime.HasMaxValue && lengthcubmasstime.Value_ > lengthcubmasstime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubMassTime is outside its bounds.");
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
    