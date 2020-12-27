
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLuminousIntensity : Quantity, IEquatable<PerLuminousIntensity>, IComparable
    {
    internal PerLuminousIntensity(double value) : base(value, 2)
    {
        PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
    }
    internal PerLuminousIntensity(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLuminousIntensity(PerLuminousIntensity other) : base(other)
    {
        PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLuminousIntensity"))
        {
            switch(FakeDatabase.Units["PerLuminousIntensity"])
            {
				      case "percandelacub": displayUnit_ = percandelacub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percandelacub_ = new Unit_("PerCandelaCub", "/cd³", 1.0);
	private static Unit_ platformUnit_ = percandelacub_;
	private static Unit_ displayUnit_ = percandelacub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLuminousIntensity other) => other is object && Equals((object)other);
    public int CompareTo(PerLuminousIntensity other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLuminousIntensity other)) throw new ArgumentException("Object is not a PerLuminousIntensity.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLuminousIntensity l1, PerLuminousIntensity l2) => !(l1 == l2);
    public static bool operator <(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLuminousIntensity FromPerCandelaCubs(double value, double minValue, double maxValue) => new PerLuminousIntensity(value * percandelacub_.Factor, minValue * percandelacub_.Factor, maxValue * percandelacub_.Factor);
		public static PerLuminousIntensity FromPerCandelaCubs(double value) => new PerLuminousIntensity(value * percandelacub_.Factor);
		public double GetValueInPerCandelaCubs() => Value_ / percandelacub_.Factor;

#endregion

#region arithmetic
		public static PerLuminousIntensity operator+(PerLuminousIntensity o1, PerLuminousIntensity o2) => new PerLuminousIntensity(o1.Value_ + o2.Value_);
		public static PerLuminousIntensity operator-(PerLuminousIntensity o1, PerLuminousIntensity o2) => new PerLuminousIntensity(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLuminousIntensity o1, PerLuminousIntensity o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLuminousIntensity o1, LuminousIntensity o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LuminousIntensity o1, PerLuminousIntensity o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLuminousIntensity perluminousintensity, bool throwOnFail=true)
    {
        bool fail = false;
        if (perluminousintensity.HasMinValue && perluminousintensity.Value_ < perluminousintensity.MinValue)
        {
            fail = true;
        }

        if (perluminousintensity.HasMaxValue && perluminousintensity.Value_ > perluminousintensity.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLuminousIntensity is outside its bounds.");
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
    