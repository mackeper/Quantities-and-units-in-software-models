
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerAmountOfSubstance : Quantity, IEquatable<PerAmountOfSubstance>, IComparable
    {
    internal PerAmountOfSubstance(double value) : base(value, 2)
    {
        PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
    }
    internal PerAmountOfSubstance(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerAmountOfSubstance(PerAmountOfSubstance other) : base(other)
    {
        PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerAmountOfSubstance"))
        {
            switch(FakeDatabase.Units["PerAmountOfSubstance"])
            {
				      case "permolecub": displayUnit_ = permolecub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ permolecub_ = new Unit_("PerMoleCub", "/mol³", 1.0);
	private static Unit_ platformUnit_ = permolecub_;
	private static Unit_ displayUnit_ = permolecub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerAmountOfSubstance other) => other is object && Equals((object)other);
    public int CompareTo(PerAmountOfSubstance other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerAmountOfSubstance other)) throw new ArgumentException("Object is not a PerAmountOfSubstance.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => !(l1 == l2);
    public static bool operator <(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerAmountOfSubstance FromPerMoleCubs(double value, double minValue, double maxValue) => new PerAmountOfSubstance(value * permolecub_.Factor, minValue * permolecub_.Factor, maxValue * permolecub_.Factor);
		public static PerAmountOfSubstance FromPerMoleCubs(double value) => new PerAmountOfSubstance(value * permolecub_.Factor);
		public double GetValueInPerMoleCubs() => Value_ / permolecub_.Factor;

#endregion

#region arithmetic
		public static PerAmountOfSubstance operator+(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new PerAmountOfSubstance(o1.Value_ + o2.Value_);
		public static PerAmountOfSubstance operator-(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new PerAmountOfSubstance(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerAmountOfSubstance o1, AmountOfSubstance o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(AmountOfSubstance o1, PerAmountOfSubstance o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerAmountOfSubstance peramountofsubstance, bool throwOnFail=true)
    {
        bool fail = false;
        if (peramountofsubstance.HasMinValue && peramountofsubstance.Value_ < peramountofsubstance.MinValue)
        {
            fail = true;
        }

        if (peramountofsubstance.HasMaxValue && peramountofsubstance.Value_ > peramountofsubstance.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerAmountOfSubstance is outside its bounds.");
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
    