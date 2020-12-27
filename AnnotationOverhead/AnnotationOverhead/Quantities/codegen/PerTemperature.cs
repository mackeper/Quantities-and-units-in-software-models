
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTemperature : Quantity, IEquatable<PerTemperature>, IComparable
    {
    internal PerTemperature(double value) : base(value, 2)
    {
        PerTemperature.ImportDisplayUnitFromDatabase_();
    }
    internal PerTemperature(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTemperature.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTemperature(PerTemperature other) : base(other)
    {
        PerTemperature.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTemperature"))
        {
            switch(FakeDatabase.Units["PerTemperature"])
            {
				      case "perkelvincub": displayUnit_ = perkelvincub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkelvincub_ = new Unit_("PerKelvinCub", "/K³", 1.0);
	private static Unit_ platformUnit_ = perkelvincub_;
	private static Unit_ displayUnit_ = perkelvincub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTemperature other) => other is object && Equals((object)other);
    public int CompareTo(PerTemperature other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTemperature other)) throw new ArgumentException("Object is not a PerTemperature.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTemperature l1, PerTemperature l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTemperature l1, PerTemperature l2) => !(l1 == l2);
    public static bool operator <(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTemperature FromPerKelvinCubs(double value, double minValue, double maxValue) => new PerTemperature(value * perkelvincub_.Factor, minValue * perkelvincub_.Factor, maxValue * perkelvincub_.Factor);
		public static PerTemperature FromPerKelvinCubs(double value) => new PerTemperature(value * perkelvincub_.Factor);
		public double GetValueInPerKelvinCubs() => Value_ / perkelvincub_.Factor;

#endregion

#region arithmetic
		public static PerTemperature operator+(PerTemperature o1, PerTemperature o2) => new PerTemperature(o1.Value_ + o2.Value_);
		public static PerTemperature operator-(PerTemperature o1, PerTemperature o2) => new PerTemperature(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTemperature o1, PerTemperature o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerTemperature o1, Temperature o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(Temperature o1, PerTemperature o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTemperature pertemperature, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertemperature.HasMinValue && pertemperature.Value_ < pertemperature.MinValue)
        {
            fail = true;
        }

        if (pertemperature.HasMaxValue && pertemperature.Value_ > pertemperature.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTemperature is outside its bounds.");
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
    