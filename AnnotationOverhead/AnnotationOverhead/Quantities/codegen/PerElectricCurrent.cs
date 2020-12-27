
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerElectricCurrent : Quantity, IEquatable<PerElectricCurrent>, IComparable
    {
    internal PerElectricCurrent(double value) : base(value, 2)
    {
        PerElectricCurrent.ImportDisplayUnitFromDatabase_();
    }
    internal PerElectricCurrent(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerElectricCurrent.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerElectricCurrent(PerElectricCurrent other) : base(other)
    {
        PerElectricCurrent.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerElectricCurrent"))
        {
            switch(FakeDatabase.Units["PerElectricCurrent"])
            {
				      case "peramperecub": displayUnit_ = peramperecub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ peramperecub_ = new Unit_("PerAmpereCub", "/A³", 1.0);
	private static Unit_ platformUnit_ = peramperecub_;
	private static Unit_ displayUnit_ = peramperecub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerElectricCurrent other) => other is object && Equals((object)other);
    public int CompareTo(PerElectricCurrent other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerElectricCurrent other)) throw new ArgumentException("Object is not a PerElectricCurrent.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerElectricCurrent l1, PerElectricCurrent l2) => !(l1 == l2);
    public static bool operator <(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerElectricCurrent FromPerAmpereCubs(double value, double minValue, double maxValue) => new PerElectricCurrent(value * peramperecub_.Factor, minValue * peramperecub_.Factor, maxValue * peramperecub_.Factor);
		public static PerElectricCurrent FromPerAmpereCubs(double value) => new PerElectricCurrent(value * peramperecub_.Factor);
		public double GetValueInPerAmpereCubs() => Value_ / peramperecub_.Factor;

#endregion

#region arithmetic
		public static PerElectricCurrent operator+(PerElectricCurrent o1, PerElectricCurrent o2) => new PerElectricCurrent(o1.Value_ + o2.Value_);
		public static PerElectricCurrent operator-(PerElectricCurrent o1, PerElectricCurrent o2) => new PerElectricCurrent(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerElectricCurrent o1, PerElectricCurrent o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerElectricCurrent o1, ElectricCurrent o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(ElectricCurrent o1, PerElectricCurrent o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerElectricCurrent perelectriccurrent, bool throwOnFail=true)
    {
        bool fail = false;
        if (perelectriccurrent.HasMinValue && perelectriccurrent.Value_ < perelectriccurrent.MinValue)
        {
            fail = true;
        }

        if (perelectriccurrent.HasMaxValue && perelectriccurrent.Value_ > perelectriccurrent.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerElectricCurrent is outside its bounds.");
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
    