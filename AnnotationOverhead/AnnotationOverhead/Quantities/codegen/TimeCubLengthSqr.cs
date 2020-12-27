
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubLengthSqr : Quantity, IEquatable<TimeCubLengthSqr>, IComparable
    {
    internal TimeCubLengthSqr(double value) : base(value, 2)
    {
        TimeCubLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubLengthSqr(TimeCubLengthSqr other) : base(other)
    {
        TimeCubLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLengthSqr"))
        {
            switch(FakeDatabase.Units["TimeCubLengthSqr"])
            {
				      case "secondcubcentimetersqr": displayUnit_ = secondcubcentimetersqr_; break;
				      case "secondcubmillimetersqr": displayUnit_ = secondcubmillimetersqr_; break;
				      case "secondcubmetersqr": displayUnit_ = secondcubmetersqr_; break;
				      case "secondcubinchsqr": displayUnit_ = secondcubinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubcentimetersqr_ = new Unit_("SecondCubCentimeterSqr", "s³ cm²", 1);
	private static Unit_ secondcubmillimetersqr_ = new Unit_("SecondCubMillimeterSqr", "s³ mm²", 0.010000000000000002);
	private static Unit_ secondcubmetersqr_ = new Unit_("SecondCubMeterSqr", "s³ m²", 10000);
	private static Unit_ secondcubinchsqr_ = new Unit_("SecondCubInchSqr", "s³ in²", 6.5536);
	private static Unit_ platformUnit_ = secondcubcentimetersqr_;
	private static Unit_ displayUnit_ = secondcubcentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubLengthSqr other)) throw new ArgumentException("Object is not a TimeCubLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => !(l1 == l2);
    public static bool operator <(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubLengthSqr l1, TimeCubLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubLengthSqr FromSecondCubCentimeterSqrs(double value, double minValue, double maxValue) => new TimeCubLengthSqr(value * secondcubcentimetersqr_.Factor, minValue * secondcubcentimetersqr_.Factor, maxValue * secondcubcentimetersqr_.Factor);
		public static TimeCubLengthSqr FromSecondCubCentimeterSqrs(double value) => new TimeCubLengthSqr(value * secondcubcentimetersqr_.Factor);
		public double GetValueInSecondCubCentimeterSqrs() => Value_ / secondcubcentimetersqr_.Factor;
		public static TimeCubLengthSqr FromSecondCubMillimeterSqrs(double value, double minValue, double maxValue) => new TimeCubLengthSqr(value * secondcubmillimetersqr_.Factor, minValue * secondcubmillimetersqr_.Factor, maxValue * secondcubmillimetersqr_.Factor);
		public static TimeCubLengthSqr FromSecondCubMillimeterSqrs(double value) => new TimeCubLengthSqr(value * secondcubmillimetersqr_.Factor);
		public double GetValueInSecondCubMillimeterSqrs() => Value_ / secondcubmillimetersqr_.Factor;
		public static TimeCubLengthSqr FromSecondCubMeterSqrs(double value, double minValue, double maxValue) => new TimeCubLengthSqr(value * secondcubmetersqr_.Factor, minValue * secondcubmetersqr_.Factor, maxValue * secondcubmetersqr_.Factor);
		public static TimeCubLengthSqr FromSecondCubMeterSqrs(double value) => new TimeCubLengthSqr(value * secondcubmetersqr_.Factor);
		public double GetValueInSecondCubMeterSqrs() => Value_ / secondcubmetersqr_.Factor;
		public static TimeCubLengthSqr FromSecondCubInchSqrs(double value, double minValue, double maxValue) => new TimeCubLengthSqr(value * secondcubinchsqr_.Factor, minValue * secondcubinchsqr_.Factor, maxValue * secondcubinchsqr_.Factor);
		public static TimeCubLengthSqr FromSecondCubInchSqrs(double value) => new TimeCubLengthSqr(value * secondcubinchsqr_.Factor);
		public double GetValueInSecondCubInchSqrs() => Value_ / secondcubinchsqr_.Factor;

#endregion

#region arithmetic
		public static TimeCubLengthSqr operator+(TimeCubLengthSqr o1, TimeCubLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ + o2.Value_);
		public static TimeCubLengthSqr operator-(TimeCubLengthSqr o1, TimeCubLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubLengthSqr o1, TimeCubLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(TimeCubLengthSqr o1, LengthSqrTimeSqrMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthSqrTimeSqrMass o1, TimeCubLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(TimeCubLengthSqr o1, LengthCubTimePerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthCubTimePerMass o1, TimeCubLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(TimeCubLengthSqr o1, LengthCubTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubTimeSqr o1, TimeCubLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(TimeCubLengthSqr o1, LengthCubMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthCubMassTime o1, TimeCubLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(TimeCubLengthSqr o1, PerMassTimeSqrLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(PerMassTimeSqrLengthCub o1, TimeCubLengthSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(TimeCubLengthSqr o1, PerLengthCubTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerLengthCubTimeCub o1, TimeCubLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(TimeCubLengthSqr o1, MassPerTimeSqrLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassPerTimeSqrLengthCub o1, TimeCubLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(TimeCubLengthSqr o1, PerMassLengthSqrTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerMassLengthSqrTimeCub o1, TimeCubLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Mass operator*(TimeCubLengthSqr o1, MassPerLengthSqrTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerLengthSqrTimeCub o1, TimeCubLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static Mass operator/(TimeCubLengthSqr o1, TimeCubLengthSqrPerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(TimeCubLengthSqrPerMass o1, TimeCubLengthSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(TimeCubLengthSqr o1, TimeCubLengthSqrMass o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(TimeCubLengthSqrMass o1, TimeCubLengthSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator/(TimeCubLengthSqr o1, LengthCubTimeSqrPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthCubTimeSqrPerMass o1, TimeCubLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(TimeCubLengthSqr o1, LengthCubTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubTimeCub o1, TimeCubLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(TimeCubLengthSqr o1, LengthCubTimeSqrMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthCubTimeSqrMass o1, TimeCubLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(TimeCubLengthSqr o1, PerMassLengthCubTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerMassLengthCubTimeCub o1, TimeCubLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(TimeCubLengthSqr o1, MassPerLengthCubTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(MassPerLengthCubTimeCub o1, TimeCubLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(TimeCubLengthSqr o1, LengthCubTimeCubPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthCubTimeCubPerMass o1, TimeCubLengthSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(TimeCubLengthSqr o1, LengthCubTimeCubMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthCubTimeCubMass o1, TimeCubLengthSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubLengthSqr timecublengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecublengthsqr.HasMinValue && timecublengthsqr.Value_ < timecublengthsqr.MinValue)
        {
            fail = true;
        }

        if (timecublengthsqr.HasMaxValue && timecublengthsqr.Value_ > timecublengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubLengthSqr is outside its bounds.");
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
    