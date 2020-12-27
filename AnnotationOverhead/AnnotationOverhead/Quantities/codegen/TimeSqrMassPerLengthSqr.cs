
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeSqrMassPerLengthSqr : Quantity, IEquatable<TimeSqrMassPerLengthSqr>, IComparable
    {
    internal TimeSqrMassPerLengthSqr(double value) : base(value, 2)
    {
        TimeSqrMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal TimeSqrMassPerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeSqrMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeSqrMassPerLengthSqr(TimeSqrMassPerLengthSqr other) : base(other)
    {
        TimeSqrMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrMassPerLengthSqr"))
        {
            switch(FakeDatabase.Units["TimeSqrMassPerLengthSqr"])
            {
				      case "secondsqrkilogrampercentimetersqr": displayUnit_ = secondsqrkilogrampercentimetersqr_; break;
				      case "secondsqrkilogrampermillimetersqr": displayUnit_ = secondsqrkilogrampermillimetersqr_; break;
				      case "secondsqrkilogrampermetersqr": displayUnit_ = secondsqrkilogrampermetersqr_; break;
				      case "secondsqrkilogramperinchsqr": displayUnit_ = secondsqrkilogramperinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondsqrkilogrampercentimetersqr_ = new Unit_("SecondSqrKilogramPerCentimeterSqr", "s² kg/cm²", 1.0);
	private static Unit_ secondsqrkilogrampermillimetersqr_ = new Unit_("SecondSqrKilogramPerMillimeterSqr", "s² kg/mm²", 99.99999999999999);
	private static Unit_ secondsqrkilogrampermetersqr_ = new Unit_("SecondSqrKilogramPerMeterSqr", "s² kg/m²", 0.0001);
	private static Unit_ secondsqrkilogramperinchsqr_ = new Unit_("SecondSqrKilogramPerInchSqr", "s² kg/in²", 0.152587890625);
	private static Unit_ platformUnit_ = secondsqrkilogrampercentimetersqr_;
	private static Unit_ displayUnit_ = secondsqrkilogrampercentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeSqrMassPerLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(TimeSqrMassPerLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeSqrMassPerLengthSqr other)) throw new ArgumentException("Object is not a TimeSqrMassPerLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => !(l1 == l2);
    public static bool operator <(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeSqrMassPerLengthSqr l1, TimeSqrMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerCentimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampercentimetersqr_.Factor, minValue * secondsqrkilogrampercentimetersqr_.Factor, maxValue * secondsqrkilogrampercentimetersqr_.Factor);
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerCentimeterSqrs(double value) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampercentimetersqr_.Factor);
		public double GetValueInSecondSqrKilogramPerCentimeterSqrs() => Value_ / secondsqrkilogrampercentimetersqr_.Factor;
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerMillimeterSqrs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampermillimetersqr_.Factor, minValue * secondsqrkilogrampermillimetersqr_.Factor, maxValue * secondsqrkilogrampermillimetersqr_.Factor);
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerMillimeterSqrs(double value) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampermillimetersqr_.Factor);
		public double GetValueInSecondSqrKilogramPerMillimeterSqrs() => Value_ / secondsqrkilogrampermillimetersqr_.Factor;
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerMeterSqrs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampermetersqr_.Factor, minValue * secondsqrkilogrampermetersqr_.Factor, maxValue * secondsqrkilogrampermetersqr_.Factor);
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerMeterSqrs(double value) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogrampermetersqr_.Factor);
		public double GetValueInSecondSqrKilogramPerMeterSqrs() => Value_ / secondsqrkilogrampermetersqr_.Factor;
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerInchSqrs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogramperinchsqr_.Factor, minValue * secondsqrkilogramperinchsqr_.Factor, maxValue * secondsqrkilogramperinchsqr_.Factor);
		public static TimeSqrMassPerLengthSqr FromSecondSqrKilogramPerInchSqrs(double value) => new TimeSqrMassPerLengthSqr(value * secondsqrkilogramperinchsqr_.Factor);
		public double GetValueInSecondSqrKilogramPerInchSqrs() => Value_ / secondsqrkilogramperinchsqr_.Factor;

#endregion

#region arithmetic
		public static TimeSqrMassPerLengthSqr operator+(TimeSqrMassPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ + o2.Value_);
		public static TimeSqrMassPerLengthSqr operator-(TimeSqrMassPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeSqrMassPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthMassTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerLengthMassTimeCub o1, TimeSqrMassPerLengthSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(TimeSqrMassPerLengthSqr o1, TimeCubMassPerLength o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeCubMassPerLength o1, TimeSqrMassPerLengthSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimeSqrMassPerLengthSqr o1, LengthPerMassTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(LengthPerMassTimeCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(TimeSqrMassPerLengthSqr o1, TimeCubLengthMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(TimeCubLengthMass o1, TimeSqrMassPerLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthSqrPerMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthSqrPerTimeCub o1, TimeSqrMassPerLengthSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubPerMassTime o1, TimeSqrMassPerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(TimeSqrMassPerLengthSqr o1, LengthCubTimePerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthCubTimePerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthCubPerTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(TimeSqrMassPerLengthSqr o1, TimeCubPerLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeCubPerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(TimeSqrMassPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(TimeSqrMassPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCubMassPerLengthSqr o1, TimeSqrMassPerLengthSqr o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimeSqrMassPerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrMassPerLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Length operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubPerMassTimeSqr o1, TimeSqrMassPerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthCubPerTimeCub o1, TimeSqrMassPerLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static Speed operator/(TimeSqrMassPerLengthSqr o1, TimeCubMassPerLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeCubMassPerLengthCub o1, TimeSqrMassPerLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static Speed operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerMassTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthCubPerMassTimeCub o1, TimeSqrMassPerLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeSqrMassPerLengthSqr timesqrmassperlengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (timesqrmassperlengthsqr.HasMinValue && timesqrmassperlengthsqr.Value_ < timesqrmassperlengthsqr.MinValue)
        {
            fail = true;
        }

        if (timesqrmassperlengthsqr.HasMaxValue && timesqrmassperlengthsqr.Value_ > timesqrmassperlengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeSqrMassPerLengthSqr is outside its bounds.");
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
    