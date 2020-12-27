
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeSqrMassPerLengthCub : Quantity, IEquatable<TimeSqrMassPerLengthCub>, IComparable
    {
    internal TimeSqrMassPerLengthCub(double value) : base(value, 2)
    {
        TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal TimeSqrMassPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeSqrMassPerLengthCub(TimeSqrMassPerLengthCub other) : base(other)
    {
        TimeSqrMassPerLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrMassPerLengthCub"))
        {
            switch(FakeDatabase.Units["TimeSqrMassPerLengthCub"])
            {
				      case "secondsqrkilogrampercentimetercub": displayUnit_ = secondsqrkilogrampercentimetercub_; break;
				      case "secondsqrkilogrampermillimetercub": displayUnit_ = secondsqrkilogrampermillimetercub_; break;
				      case "secondsqrkilogrampermetercub": displayUnit_ = secondsqrkilogrampermetercub_; break;
				      case "secondsqrkilogramperinchcub": displayUnit_ = secondsqrkilogramperinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondsqrkilogrampercentimetercub_ = new Unit_("SecondSqrKilogramPerCentimeterCub", "s² kg/cm³", 1.0);
	private static Unit_ secondsqrkilogrampermillimetercub_ = new Unit_("SecondSqrKilogramPerMillimeterCub", "s² kg/mm³", 999.9999999999998);
	private static Unit_ secondsqrkilogrampermetercub_ = new Unit_("SecondSqrKilogramPerMeterCub", "s² kg/m³", 1e-06);
	private static Unit_ secondsqrkilogramperinchcub_ = new Unit_("SecondSqrKilogramPerInchCub", "s² kg/in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = secondsqrkilogrampercentimetercub_;
	private static Unit_ displayUnit_ = secondsqrkilogrampercentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeSqrMassPerLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(TimeSqrMassPerLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeSqrMassPerLengthCub other)) throw new ArgumentException("Object is not a TimeSqrMassPerLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => !(l1 == l2);
    public static bool operator <(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeSqrMassPerLengthCub l1, TimeSqrMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampercentimetercub_.Factor, minValue * secondsqrkilogrampercentimetercub_.Factor, maxValue * secondsqrkilogrampercentimetercub_.Factor);
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerCentimeterCubs(double value) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampercentimetercub_.Factor);
		public double GetValueInSecondSqrKilogramPerCentimeterCubs() => Value_ / secondsqrkilogrampercentimetercub_.Factor;
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampermillimetercub_.Factor, minValue * secondsqrkilogrampermillimetercub_.Factor, maxValue * secondsqrkilogrampermillimetercub_.Factor);
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMillimeterCubs(double value) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampermillimetercub_.Factor);
		public double GetValueInSecondSqrKilogramPerMillimeterCubs() => Value_ / secondsqrkilogrampermillimetercub_.Factor;
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMeterCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampermetercub_.Factor, minValue * secondsqrkilogrampermetercub_.Factor, maxValue * secondsqrkilogrampermetercub_.Factor);
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerMeterCubs(double value) => new TimeSqrMassPerLengthCub(value * secondsqrkilogrampermetercub_.Factor);
		public double GetValueInSecondSqrKilogramPerMeterCubs() => Value_ / secondsqrkilogrampermetercub_.Factor;
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerInchCubs(double value, double minValue, double maxValue) => new TimeSqrMassPerLengthCub(value * secondsqrkilogramperinchcub_.Factor, minValue * secondsqrkilogramperinchcub_.Factor, maxValue * secondsqrkilogramperinchcub_.Factor);
		public static TimeSqrMassPerLengthCub FromSecondSqrKilogramPerInchCubs(double value) => new TimeSqrMassPerLengthCub(value * secondsqrkilogramperinchcub_.Factor);
		public double GetValueInSecondSqrKilogramPerInchCubs() => Value_ / secondsqrkilogramperinchcub_.Factor;

#endregion

#region arithmetic
		public static TimeSqrMassPerLengthCub operator+(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ + o2.Value_);
		public static TimeSqrMassPerLengthCub operator-(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMassPerLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(TimeSqrMassPerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeCubMassPerLengthSqr o1, TimeSqrMassPerLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimeSqrMassPerLengthCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(LengthSqrPerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubPerMassTimeSqr o1, TimeSqrMassPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(TimeSqrMassPerLengthCub o1, LengthCubPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthCubPerTimeCub o1, TimeSqrMassPerLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(TimeSqrMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCubMassPerLengthCub o1, TimeSqrMassPerLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMassTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthCubPerMassTimeCub o1, TimeSqrMassPerLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeSqrMassPerLengthCub timesqrmassperlengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (timesqrmassperlengthcub.HasMinValue && timesqrmassperlengthcub.Value_ < timesqrmassperlengthcub.MinValue)
        {
            fail = true;
        }

        if (timesqrmassperlengthcub.HasMaxValue && timesqrmassperlengthcub.Value_ > timesqrmassperlengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeSqrMassPerLengthCub is outside its bounds.");
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
    