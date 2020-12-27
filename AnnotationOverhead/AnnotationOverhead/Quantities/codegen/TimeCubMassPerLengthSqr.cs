
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubMassPerLengthSqr : Quantity, IEquatable<TimeCubMassPerLengthSqr>, IComparable
    {
    internal TimeCubMassPerLengthSqr(double value) : base(value, 2)
    {
        TimeCubMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubMassPerLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubMassPerLengthSqr(TimeCubMassPerLengthSqr other) : base(other)
    {
        TimeCubMassPerLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubMassPerLengthSqr"))
        {
            switch(FakeDatabase.Units["TimeCubMassPerLengthSqr"])
            {
				      case "secondcubkilogrampercentimetersqr": displayUnit_ = secondcubkilogrampercentimetersqr_; break;
				      case "secondcubkilogrampermillimetersqr": displayUnit_ = secondcubkilogrampermillimetersqr_; break;
				      case "secondcubkilogrampermetersqr": displayUnit_ = secondcubkilogrampermetersqr_; break;
				      case "secondcubkilogramperinchsqr": displayUnit_ = secondcubkilogramperinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubkilogrampercentimetersqr_ = new Unit_("SecondCubKilogramPerCentimeterSqr", "s³ kg/cm²", 1.0);
	private static Unit_ secondcubkilogrampermillimetersqr_ = new Unit_("SecondCubKilogramPerMillimeterSqr", "s³ kg/mm²", 99.99999999999999);
	private static Unit_ secondcubkilogrampermetersqr_ = new Unit_("SecondCubKilogramPerMeterSqr", "s³ kg/m²", 0.0001);
	private static Unit_ secondcubkilogramperinchsqr_ = new Unit_("SecondCubKilogramPerInchSqr", "s³ kg/in²", 0.152587890625);
	private static Unit_ platformUnit_ = secondcubkilogrampercentimetersqr_;
	private static Unit_ displayUnit_ = secondcubkilogrampercentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubMassPerLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubMassPerLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubMassPerLengthSqr other)) throw new ArgumentException("Object is not a TimeCubMassPerLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => !(l1 == l2);
    public static bool operator <(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubMassPerLengthSqr l1, TimeCubMassPerLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerCentimeterSqrs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampercentimetersqr_.Factor, minValue * secondcubkilogrampercentimetersqr_.Factor, maxValue * secondcubkilogrampercentimetersqr_.Factor);
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerCentimeterSqrs(double value) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampercentimetersqr_.Factor);
		public double GetValueInSecondCubKilogramPerCentimeterSqrs() => Value_ / secondcubkilogrampercentimetersqr_.Factor;
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerMillimeterSqrs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampermillimetersqr_.Factor, minValue * secondcubkilogrampermillimetersqr_.Factor, maxValue * secondcubkilogrampermillimetersqr_.Factor);
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerMillimeterSqrs(double value) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampermillimetersqr_.Factor);
		public double GetValueInSecondCubKilogramPerMillimeterSqrs() => Value_ / secondcubkilogrampermillimetersqr_.Factor;
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerMeterSqrs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampermetersqr_.Factor, minValue * secondcubkilogrampermetersqr_.Factor, maxValue * secondcubkilogrampermetersqr_.Factor);
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerMeterSqrs(double value) => new TimeCubMassPerLengthSqr(value * secondcubkilogrampermetersqr_.Factor);
		public double GetValueInSecondCubKilogramPerMeterSqrs() => Value_ / secondcubkilogrampermetersqr_.Factor;
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerInchSqrs(double value, double minValue, double maxValue) => new TimeCubMassPerLengthSqr(value * secondcubkilogramperinchsqr_.Factor, minValue * secondcubkilogramperinchsqr_.Factor, maxValue * secondcubkilogramperinchsqr_.Factor);
		public static TimeCubMassPerLengthSqr FromSecondCubKilogramPerInchSqrs(double value) => new TimeCubMassPerLengthSqr(value * secondcubkilogramperinchsqr_.Factor);
		public double GetValueInSecondCubKilogramPerInchSqrs() => Value_ / secondcubkilogramperinchsqr_.Factor;

#endregion

#region arithmetic
		public static TimeCubMassPerLengthSqr operator+(TimeCubMassPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ + o2.Value_);
		public static TimeCubMassPerLengthSqr operator-(TimeCubMassPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new TimeCubMassPerLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubMassPerLengthSqr o1, TimeCubMassPerLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeCubMassPerLengthSqr o1, LengthSqrPerMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthSqrPerMassTimeCub o1, TimeCubMassPerLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(TimeCubMassPerLengthSqr o1, LengthCubPerMassTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubPerMassTimeSqr o1, TimeCubMassPerLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(TimeCubMassPerLengthSqr o1, LengthCubPerTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthCubPerTimeCub o1, TimeCubMassPerLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static Length operator/(TimeCubMassPerLengthSqr o1, TimeCubMassPerLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeCubMassPerLengthCub o1, TimeCubMassPerLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimeCubMassPerLengthSqr o1, LengthCubPerMassTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubPerMassTimeCub o1, TimeCubMassPerLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubMassPerLengthSqr timecubmassperlengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecubmassperlengthsqr.HasMinValue && timecubmassperlengthsqr.Value_ < timecubmassperlengthsqr.MinValue)
        {
            fail = true;
        }

        if (timecubmassperlengthsqr.HasMaxValue && timecubmassperlengthsqr.Value_ > timecubmassperlengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubMassPerLengthSqr is outside its bounds.");
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
    