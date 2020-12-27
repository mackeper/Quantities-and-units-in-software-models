
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubPerMassLengthCub : Quantity, IEquatable<TimeCubPerMassLengthCub>, IComparable
    {
    internal TimeCubPerMassLengthCub(double value) : base(value, 2)
    {
        TimeCubPerMassLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubPerMassLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubPerMassLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubPerMassLengthCub(TimeCubPerMassLengthCub other) : base(other)
    {
        TimeCubPerMassLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerMassLengthCub"))
        {
            switch(FakeDatabase.Units["TimeCubPerMassLengthCub"])
            {
				      case "secondcubperkilogramcentimetercub": displayUnit_ = secondcubperkilogramcentimetercub_; break;
				      case "secondcubperkilogrammillimetercub": displayUnit_ = secondcubperkilogrammillimetercub_; break;
				      case "secondcubperkilogrammetercub": displayUnit_ = secondcubperkilogrammetercub_; break;
				      case "secondcubperkilograminchcub": displayUnit_ = secondcubperkilograminchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubperkilogramcentimetercub_ = new Unit_("SecondCubPerKilogramCentimeterCub", "s³/kg cm³", 1.0);
	private static Unit_ secondcubperkilogrammillimetercub_ = new Unit_("SecondCubPerKilogramMillimeterCub", "s³/kg mm³", 999.9999999999998);
	private static Unit_ secondcubperkilogrammetercub_ = new Unit_("SecondCubPerKilogramMeterCub", "s³/kg m³", 1e-06);
	private static Unit_ secondcubperkilograminchcub_ = new Unit_("SecondCubPerKilogramInchCub", "s³/kg in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = secondcubperkilogramcentimetercub_;
	private static Unit_ displayUnit_ = secondcubperkilogramcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubPerMassLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubPerMassLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubPerMassLengthCub other)) throw new ArgumentException("Object is not a TimeCubPerMassLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => !(l1 == l2);
    public static bool operator <(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubPerMassLengthCub l1, TimeCubPerMassLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramCentimeterCubs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthCub(value * secondcubperkilogramcentimetercub_.Factor, minValue * secondcubperkilogramcentimetercub_.Factor, maxValue * secondcubperkilogramcentimetercub_.Factor);
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramCentimeterCubs(double value) => new TimeCubPerMassLengthCub(value * secondcubperkilogramcentimetercub_.Factor);
		public double GetValueInSecondCubPerKilogramCentimeterCubs() => Value_ / secondcubperkilogramcentimetercub_.Factor;
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramMillimeterCubs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthCub(value * secondcubperkilogrammillimetercub_.Factor, minValue * secondcubperkilogrammillimetercub_.Factor, maxValue * secondcubperkilogrammillimetercub_.Factor);
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramMillimeterCubs(double value) => new TimeCubPerMassLengthCub(value * secondcubperkilogrammillimetercub_.Factor);
		public double GetValueInSecondCubPerKilogramMillimeterCubs() => Value_ / secondcubperkilogrammillimetercub_.Factor;
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramMeterCubs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthCub(value * secondcubperkilogrammetercub_.Factor, minValue * secondcubperkilogrammetercub_.Factor, maxValue * secondcubperkilogrammetercub_.Factor);
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramMeterCubs(double value) => new TimeCubPerMassLengthCub(value * secondcubperkilogrammetercub_.Factor);
		public double GetValueInSecondCubPerKilogramMeterCubs() => Value_ / secondcubperkilogrammetercub_.Factor;
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramInchCubs(double value, double minValue, double maxValue) => new TimeCubPerMassLengthCub(value * secondcubperkilograminchcub_.Factor, minValue * secondcubperkilograminchcub_.Factor, maxValue * secondcubperkilograminchcub_.Factor);
		public static TimeCubPerMassLengthCub FromSecondCubPerKilogramInchCubs(double value) => new TimeCubPerMassLengthCub(value * secondcubperkilograminchcub_.Factor);
		public double GetValueInSecondCubPerKilogramInchCubs() => Value_ / secondcubperkilograminchcub_.Factor;

#endregion

#region arithmetic
		public static TimeCubPerMassLengthCub operator+(TimeCubPerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ + o2.Value_);
		public static TimeCubPerMassLengthCub operator-(TimeCubPerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubPerMassLengthCub o1, TimeCubPerMassLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeCubPerMassLengthCub o1, LengthCubMassPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubMassPerTimeCub o1, TimeCubPerMassLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubPerMassLengthCub timecubpermasslengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecubpermasslengthcub.HasMinValue && timecubpermasslengthcub.Value_ < timecubpermasslengthcub.MinValue)
        {
            fail = true;
        }

        if (timecubpermasslengthcub.HasMaxValue && timecubpermasslengthcub.Value_ > timecubpermasslengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubPerMassLengthCub is outside its bounds.");
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
    