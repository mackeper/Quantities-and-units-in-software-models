
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LuminousIntensity : Quantity, IEquatable<LuminousIntensity>, IComparable
    {
    internal LuminousIntensity(double value) : base(value, 2)
    {
        LuminousIntensity.ImportDisplayUnitFromDatabase_();
    }
    internal LuminousIntensity(double value, double minValue, double maxValue) : base(value, 2)
    {
        LuminousIntensity.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LuminousIntensity(LuminousIntensity other) : base(other)
    {
        LuminousIntensity.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LuminousIntensity"))
        {
            switch(FakeDatabase.Units["LuminousIntensity"])
            {
				      case "candela": displayUnit_ = candela_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ candela_ = new Unit_("Candela", "cd", 1);
	private static Unit_ platformUnit_ = candela_;
	private static Unit_ displayUnit_ = candela_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LuminousIntensity other) => other is object && Equals((object)other);
    public int CompareTo(LuminousIntensity other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LuminousIntensity other)) throw new ArgumentException("Object is not a LuminousIntensity.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LuminousIntensity l1, LuminousIntensity l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LuminousIntensity l1, LuminousIntensity l2) => !(l1 == l2);
    public static bool operator <(LuminousIntensity l1, LuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LuminousIntensity l1, LuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LuminousIntensity l1, LuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LuminousIntensity l1, LuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LuminousIntensity FromCandelas(double value, double minValue, double maxValue) => new LuminousIntensity(value * candela_.Factor, minValue * candela_.Factor, maxValue * candela_.Factor);
		public static LuminousIntensity FromCandelas(double value) => new LuminousIntensity(value * candela_.Factor);
		public double GetValueInCandelas() => Value_ / candela_.Factor;

#endregion

#region arithmetic
		public static LuminousIntensity operator+(LuminousIntensity o1, LuminousIntensity o2) => new LuminousIntensity(o1.Value_ + o2.Value_);
		public static LuminousIntensity operator-(LuminousIntensity o1, LuminousIntensity o2) => new LuminousIntensity(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LuminousIntensity o1, LuminousIntensity o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LuminousIntensity luminousintensity, bool throwOnFail=true)
    {
        bool fail = false;
        if (luminousintensity.HasMinValue && luminousintensity.Value_ < luminousintensity.MinValue)
        {
            fail = true;
        }

        if (luminousintensity.HasMaxValue && luminousintensity.Value_ > luminousintensity.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LuminousIntensity is outside its bounds.");
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
    