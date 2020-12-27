
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class AmountOfSubstance : Quantity, IEquatable<AmountOfSubstance>, IComparable
    {
    internal AmountOfSubstance(double value) : base(value, 2)
    {
        AmountOfSubstance.ImportDisplayUnitFromDatabase_();
    }
    internal AmountOfSubstance(double value, double minValue, double maxValue) : base(value, 2)
    {
        AmountOfSubstance.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public AmountOfSubstance(AmountOfSubstance other) : base(other)
    {
        AmountOfSubstance.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("AmountOfSubstance"))
        {
            switch(FakeDatabase.Units["AmountOfSubstance"])
            {
				      case "mole": displayUnit_ = mole_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ mole_ = new Unit_("Mole", "mol", 1);
	private static Unit_ platformUnit_ = mole_;
	private static Unit_ displayUnit_ = mole_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(AmountOfSubstance other) => other is object && Equals((object)other);
    public int CompareTo(AmountOfSubstance other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is AmountOfSubstance other)) throw new ArgumentException("Object is not a AmountOfSubstance.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(AmountOfSubstance l1, AmountOfSubstance l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(AmountOfSubstance l1, AmountOfSubstance l2) => !(l1 == l2);
    public static bool operator <(AmountOfSubstance l1, AmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(AmountOfSubstance l1, AmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(AmountOfSubstance l1, AmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(AmountOfSubstance l1, AmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static AmountOfSubstance FromMoles(double value, double minValue, double maxValue) => new AmountOfSubstance(value * mole_.Factor, minValue * mole_.Factor, maxValue * mole_.Factor);
		public static AmountOfSubstance FromMoles(double value) => new AmountOfSubstance(value * mole_.Factor);
		public double GetValueInMoles() => Value_ / mole_.Factor;

#endregion

#region arithmetic
		public static AmountOfSubstance operator+(AmountOfSubstance o1, AmountOfSubstance o2) => new AmountOfSubstance(o1.Value_ + o2.Value_);
		public static AmountOfSubstance operator-(AmountOfSubstance o1, AmountOfSubstance o2) => new AmountOfSubstance(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(AmountOfSubstance o1, AmountOfSubstance o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(AmountOfSubstance amountofsubstance, bool throwOnFail=true)
    {
        bool fail = false;
        if (amountofsubstance.HasMinValue && amountofsubstance.Value_ < amountofsubstance.MinValue)
        {
            fail = true;
        }

        if (amountofsubstance.HasMaxValue && amountofsubstance.Value_ > amountofsubstance.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("AmountOfSubstance is outside its bounds.");
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
    