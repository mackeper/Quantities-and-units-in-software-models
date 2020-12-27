
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubMassPerLengthCub : Quantity, IEquatable<TimeCubMassPerLengthCub>, IComparable
    {
    internal TimeCubMassPerLengthCub(double value) : base(value, 2)
    {
        TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubMassPerLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubMassPerLengthCub(TimeCubMassPerLengthCub other) : base(other)
    {
        TimeCubMassPerLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubMassPerLengthCub"))
        {
            switch(FakeDatabase.Units["TimeCubMassPerLengthCub"])
            {
				      case "secondcubkilogrampercentimetercub": displayUnit_ = secondcubkilogrampercentimetercub_; break;
				      case "secondcubkilogrampermillimetercub": displayUnit_ = secondcubkilogrampermillimetercub_; break;
				      case "secondcubkilogrampermetercub": displayUnit_ = secondcubkilogrampermetercub_; break;
				      case "secondcubkilogramperinchcub": displayUnit_ = secondcubkilogramperinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubkilogrampercentimetercub_ = new Unit_("SecondCubKilogramPerCentimeterCub", "s� kg/cm�", 1.0);
	private static Unit_ secondcubkilogrampermillimetercub_ = new Unit_("SecondCubKilogramPerMillimeterCub", "s� kg/mm�", 999.9999999999998);
	private static Unit_ secondcubkilogrampermetercub_ = new Unit_("SecondCubKilogramPerMeterCub", "s� kg/m�", 1e-06);
	private static Unit_ secondcubkilogramperinchcub_ = new Unit_("SecondCubKilogramPerInchCub", "s� kg/in�", 0.05960464477539062);
	private static Unit_ platformUnit_ = secondcubkilogrampercentimetercub_;
	private static Unit_ displayUnit_ = secondcubkilogrampercentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubMassPerLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubMassPerLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubMassPerLengthCub other)) throw new ArgumentException("Object is not a TimeCubMassPerLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => !(l1 == l2);
    public static bool operator <(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubMassPerLengthCub l1, TimeCubMassPerLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerCentimeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub(value * secondcubkilogrampercentimetercub_.Factor, minValue * secondcubkilogrampercentimetercub_.Factor, maxValue * secondcubkilogrampercentimetercub_.Factor);
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerCentimeterCubs(double value) => new TimeCubMassPerLengthCub(value * secondcubkilogrampercentimetercub_.Factor);
		public double GetValueInSecondCubKilogramPerCentimeterCubs() => Value_ / secondcubkilogrampercentimetercub_.Factor;
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMillimeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub(value * secondcubkilogrampermillimetercub_.Factor, minValue * secondcubkilogrampermillimetercub_.Factor, maxValue * secondcubkilogrampermillimetercub_.Factor);
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMillimeterCubs(double value) => new TimeCubMassPerLengthCub(value * secondcubkilogrampermillimetercub_.Factor);
		public double GetValueInSecondCubKilogramPerMillimeterCubs() => Value_ / secondcubkilogrampermillimetercub_.Factor;
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMeterCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub(value * secondcubkilogrampermetercub_.Factor, minValue * secondcubkilogrampermetercub_.Factor, maxValue * secondcubkilogrampermetercub_.Factor);
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerMeterCubs(double value) => new TimeCubMassPerLengthCub(value * secondcubkilogrampermetercub_.Factor);
		public double GetValueInSecondCubKilogramPerMeterCubs() => Value_ / secondcubkilogrampermetercub_.Factor;
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerInchCubs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthCub(value * secondcubkilogramperinchcub_.Factor, minValue * secondcubkilogramperinchcub_.Factor, maxValue * secondcubkilogramperinchcub_.Factor);
		public static TimeCubMassPerLengthCub FromSecondCubKilogramPerInchCubs(double value) => new TimeCubMassPerLengthCub(value * secondcubkilogramperinchcub_.Factor);
		public double GetValueInSecondCubKilogramPerInchCubs() => Value_ / secondcubkilogramperinchcub_.Factor;

#endregion

#region arithmetic
		public static TimeCubMassPerLengthCub operator+(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ + o2.Value_);
		public static TimeCubMassPerLengthCub operator-(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new TimeCubMassPerLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeCubMassPerLengthCub o1, LengthCubPerMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubPerMassTimeCub o1, TimeCubMassPerLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubMassPerLengthCub timecubmassperlengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecubmassperlengthcub.HasMinValue && timecubmassperlengthcub.Value_ < timecubmassperlengthcub.MinValue)
        {
            fail = true;
        }

        if (timecubmassperlengthcub.HasMaxValue && timecubmassperlengthcub.Value_ > timecubmassperlengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubMassPerLengthCub is outside its bounds.");
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
    