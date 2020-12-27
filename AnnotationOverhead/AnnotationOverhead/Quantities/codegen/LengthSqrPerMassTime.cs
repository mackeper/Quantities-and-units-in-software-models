
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthSqrPerMassTime : Quantity, IEquatable<LengthSqrPerMassTime>, IComparable
    {
    internal LengthSqrPerMassTime(double value) : base(value, 2)
    {
        LengthSqrPerMassTime.ImportDisplayUnitFromDatabase_();
    }
    internal LengthSqrPerMassTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthSqrPerMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthSqrPerMassTime(LengthSqrPerMassTime other) : base(other)
    {
        LengthSqrPerMassTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrPerMassTime"))
        {
            switch(FakeDatabase.Units["LengthSqrPerMassTime"])
            {
				      case "centimetersqrperkilogramsecond": displayUnit_ = centimetersqrperkilogramsecond_; break;
				      case "millimetersqrperkilogramsecond": displayUnit_ = millimetersqrperkilogramsecond_; break;
				      case "metersqrperkilogramsecond": displayUnit_ = metersqrperkilogramsecond_; break;
				      case "inchsqrperkilogramsecond": displayUnit_ = inchsqrperkilogramsecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetersqrperkilogramsecond_ = new Unit_("CentimeterSqrPerKilogramSecond", "cm²/kg s", 1.0);
	private static Unit_ millimetersqrperkilogramsecond_ = new Unit_("MillimeterSqrPerKilogramSecond", "mm²/kg s", 0.010000000000000002);
	private static Unit_ metersqrperkilogramsecond_ = new Unit_("MeterSqrPerKilogramSecond", "m²/kg s", 10000.0);
	private static Unit_ inchsqrperkilogramsecond_ = new Unit_("InchSqrPerKilogramSecond", "in²/kg s", 6.5536);
	private static Unit_ platformUnit_ = centimetersqrperkilogramsecond_;
	private static Unit_ displayUnit_ = centimetersqrperkilogramsecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthSqrPerMassTime other) => other is object && Equals((object)other);
    public int CompareTo(LengthSqrPerMassTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthSqrPerMassTime other)) throw new ArgumentException("Object is not a LengthSqrPerMassTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => !(l1 == l2);
    public static bool operator <(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthSqrPerMassTime l1, LengthSqrPerMassTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthSqrPerMassTime FromCentimeterSqrPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrPerMassTime(value * centimetersqrperkilogramsecond_.Factor, minValue * centimetersqrperkilogramsecond_.Factor, maxValue * centimetersqrperkilogramsecond_.Factor);
		public static LengthSqrPerMassTime FromCentimeterSqrPerKilogramSeconds(double value) => new LengthSqrPerMassTime(value * centimetersqrperkilogramsecond_.Factor);
		public double GetValueInCentimeterSqrPerKilogramSeconds() => Value_ / centimetersqrperkilogramsecond_.Factor;
		public static LengthSqrPerMassTime FromMillimeterSqrPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrPerMassTime(value * millimetersqrperkilogramsecond_.Factor, minValue * millimetersqrperkilogramsecond_.Factor, maxValue * millimetersqrperkilogramsecond_.Factor);
		public static LengthSqrPerMassTime FromMillimeterSqrPerKilogramSeconds(double value) => new LengthSqrPerMassTime(value * millimetersqrperkilogramsecond_.Factor);
		public double GetValueInMillimeterSqrPerKilogramSeconds() => Value_ / millimetersqrperkilogramsecond_.Factor;
		public static LengthSqrPerMassTime FromMeterSqrPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrPerMassTime(value * metersqrperkilogramsecond_.Factor, minValue * metersqrperkilogramsecond_.Factor, maxValue * metersqrperkilogramsecond_.Factor);
		public static LengthSqrPerMassTime FromMeterSqrPerKilogramSeconds(double value) => new LengthSqrPerMassTime(value * metersqrperkilogramsecond_.Factor);
		public double GetValueInMeterSqrPerKilogramSeconds() => Value_ / metersqrperkilogramsecond_.Factor;
		public static LengthSqrPerMassTime FromInchSqrPerKilogramSeconds(double value, double minValue, double maxValue) => new LengthSqrPerMassTime(value * inchsqrperkilogramsecond_.Factor, minValue * inchsqrperkilogramsecond_.Factor, maxValue * inchsqrperkilogramsecond_.Factor);
		public static LengthSqrPerMassTime FromInchSqrPerKilogramSeconds(double value) => new LengthSqrPerMassTime(value * inchsqrperkilogramsecond_.Factor);
		public double GetValueInInchSqrPerKilogramSeconds() => Value_ / inchsqrperkilogramsecond_.Factor;

#endregion

#region arithmetic
		public static LengthSqrPerMassTime operator+(LengthSqrPerMassTime o1, LengthSqrPerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ + o2.Value_);
		public static LengthSqrPerMassTime operator-(LengthSqrPerMassTime o1, LengthSqrPerMassTime o2) => new LengthSqrPerMassTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthSqrPerMassTime o1, LengthSqrPerMassTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthSqrPerMassTime o1, LengthSqrTimePerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthSqrTimePerMass o1, LengthSqrPerMassTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(LengthSqrPerMassTime o1, QDose o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(QDose o1, LengthSqrPerMassTime o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(LengthSqrPerMassTime o1, LengthSqrTimeSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(LengthSqrTimeSqr o1, LengthSqrPerMassTime o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(LengthSqrPerMassTime o1, LengthCubPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthCubPerMass o1, LengthSqrPerMassTime o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(LengthSqrPerMassTime o1, LengthCubPerTime o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthCubPerTime o1, LengthSqrPerMassTime o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(LengthSqrPerMassTime o1, LengthCubTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(LengthCubTime o1, LengthSqrPerMassTime o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(LengthSqrPerMassTime o1, PerTimeSqrLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(PerTimeSqrLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator*(LengthSqrPerMassTime o1, TimeSqrPerLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeSqrPerLengthCub o1, LengthSqrPerMassTime o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator*(LengthSqrPerMassTime o1, MassPerTimeLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(MassPerTimeLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(LengthSqrPerMassTime o1, MassTimePerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(MassTimePerLengthCub o1, LengthSqrPerMassTime o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMass operator*(LengthSqrPerMassTime o1, TimeCubPerLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeCubPerLengthSqr o1, LengthSqrPerMassTime o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(LengthSqrPerMassTime o1, MassPerLengthSqrTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(MassPerLengthSqrTimeSqr o1, LengthSqrPerMassTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthSqrPerMassTime o1, TimeSqrMassPerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerMassTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqr operator/(LengthSqrPerMassTime o1, PerLengthMassTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerLengthMassTimeCub o1, LengthSqrPerMassTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(LengthSqrPerMassTime o1, TimeCubMassPerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubMassPerLength o1, LengthSqrPerMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(LengthSqrPerMassTime o1, LengthPerMassTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(LengthPerMassTimeCub o1, LengthSqrPerMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(LengthSqrPerMassTime o1, TimeCubLengthMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(TimeCubLengthMass o1, LengthSqrPerMassTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
		public static Time operator/(LengthSqrPerMassTime o1, LengthSqrPerMassTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthSqrPerMassTimeSqr o1, LengthSqrPerMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthSqrPerMassTime o1, LengthSqrTimeSqrPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(LengthSqrTimeSqrPerMass o1, LengthSqrPerMassTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(LengthSqrPerMassTime o1, LengthSqrPerTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(LengthSqrPerTimeCub o1, LengthSqrPerMassTime o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(LengthSqrPerMassTime o1, LengthCubPerMassTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubPerMassTime o1, LengthSqrPerMassTime o2) => new Length(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(LengthSqrPerMassTime o1, LengthCubTimePerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(LengthCubTimePerMass o1, LengthSqrPerMassTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(LengthSqrPerMassTime o1, LengthCubPerTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthCubPerTimeSqr o1, LengthSqrPerMassTime o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator/(LengthSqrPerMassTime o1, LengthCubTimeSqr o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(LengthCubTimeSqr o1, LengthSqrPerMassTime o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(LengthSqrPerMassTime o1, TimeCubPerLengthCub o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeCubPerLengthCub o1, LengthSqrPerMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(LengthSqrPerMassTime o1, MassPerTimeSqrLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(MassPerTimeSqrLengthCub o1, LengthSqrPerMassTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(LengthSqrPerMassTime o1, TimeSqrMassPerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerMassTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(LengthSqrPerMassTime o1, TimeCubMassPerLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(LengthSqrPerMassTime o1, LengthSqrPerMassTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthSqrPerMassTimeCub o1, LengthSqrPerMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(LengthSqrPerMassTime o1, LengthCubPerMassTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubPerMassTimeSqr o1, LengthSqrPerMassTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(LengthSqrPerMassTime o1, LengthCubTimeSqrPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthCubTimeSqrPerMass o1, LengthSqrPerMassTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(LengthSqrPerMassTime o1, LengthCubPerTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthCubPerTimeCub o1, LengthSqrPerMassTime o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(LengthSqrPerMassTime o1, TimeCubMassPerLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubMassPerLengthCub o1, LengthSqrPerMassTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator/(LengthSqrPerMassTime o1, LengthCubPerMassTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(LengthCubPerMassTimeCub o1, LengthSqrPerMassTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthSqrPerMassTime lengthsqrpermasstime, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthsqrpermasstime.HasMinValue && lengthsqrpermasstime.Value_ < lengthsqrpermasstime.MinValue)
        {
            fail = true;
        }

        if (lengthsqrpermasstime.HasMaxValue && lengthsqrpermasstime.Value_ > lengthsqrpermasstime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthSqrPerMassTime is outside its bounds.");
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
    