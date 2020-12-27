
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class Temperature : Quantity, IEquatable<Temperature>, IComparable
    {
    internal Temperature(double value) : base(value, 2)
    {
        Temperature.ImportDisplayUnitFromDatabase_();
    }
    internal Temperature(double value, double minValue, double maxValue) : base(value, 2)
    {
        Temperature.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public Temperature(Temperature other) : base(other)
    {
        Temperature.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Temperature"))
        {
            switch(FakeDatabase.Units["Temperature"])
            {
				      case "kelvin": displayUnit_ = kelvin_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kelvin_ = new Unit_("Kelvin", "K", 1);
	private static Unit_ platformUnit_ = kelvin_;
	private static Unit_ displayUnit_ = kelvin_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(Temperature other) => other is object && Equals((object)other);
    public int CompareTo(Temperature other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is Temperature other)) throw new ArgumentException("Object is not a Temperature.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(Temperature l1, Temperature l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(Temperature l1, Temperature l2) => !(l1 == l2);
    public static bool operator <(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static Temperature FromKelvins(double value, double minValue, double maxValue) => new Temperature(value * kelvin_.Factor, minValue * kelvin_.Factor, maxValue * kelvin_.Factor);
		public static Temperature FromKelvins(double value) => new Temperature(value * kelvin_.Factor);
		public double GetValueInKelvins() => Value_ / kelvin_.Factor;

#endregion

#region arithmetic
		public static Temperature operator+(Temperature o1, Temperature o2) => new Temperature(o1.Value_ + o2.Value_);
		public static Temperature operator-(Temperature o1, Temperature o2) => new Temperature(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(Temperature o1, Temperature o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(Temperature temperature, bool throwOnFail=true)
    {
        bool fail = false;
        if (temperature.HasMinValue && temperature.Value_ < temperature.MinValue)
        {
            fail = true;
        }

        if (temperature.HasMaxValue && temperature.Value_ > temperature.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("Temperature is outside its bounds.");
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
    