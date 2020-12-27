
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassLengthSqrTimeCub : Quantity, IEquatable<PerMassLengthSqrTimeCub>, IComparable
    {
    internal PerMassLengthSqrTimeCub(double value) : base(value, 2)
    {
        PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassLengthSqrTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassLengthSqrTimeCub(PerMassLengthSqrTimeCub other) : base(other)
    {
        PerMassLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthSqrTimeCub"))
        {
            switch(FakeDatabase.Units["PerMassLengthSqrTimeCub"])
            {
				      case "perkilogramcubcentimetersqrsecondcub": displayUnit_ = perkilogramcubcentimetersqrsecondcub_; break;
				      case "perkilogramcubmillimetersqrsecondcub": displayUnit_ = perkilogramcubmillimetersqrsecondcub_; break;
				      case "perkilogramcubmetersqrsecondcub": displayUnit_ = perkilogramcubmetersqrsecondcub_; break;
				      case "perkilogramcubinchsqrsecondcub": displayUnit_ = perkilogramcubinchsqrsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubcentimetersqrsecondcub_ = new Unit_("PerKilogramCubCentimeterSqrSecondCub", "/kg³ cm² s³", 1.0);
	private static Unit_ perkilogramcubmillimetersqrsecondcub_ = new Unit_("PerKilogramCubMillimeterSqrSecondCub", "/kg³ mm² s³", 99.99999999999999);
	private static Unit_ perkilogramcubmetersqrsecondcub_ = new Unit_("PerKilogramCubMeterSqrSecondCub", "/kg³ m² s³", 0.0001);
	private static Unit_ perkilogramcubinchsqrsecondcub_ = new Unit_("PerKilogramCubInchSqrSecondCub", "/kg³ in² s³", 0.152587890625);
	private static Unit_ platformUnit_ = perkilogramcubcentimetersqrsecondcub_;
	private static Unit_ displayUnit_ = perkilogramcubcentimetersqrsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassLengthSqrTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerMassLengthSqrTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassLengthSqrTimeCub other)) throw new ArgumentException("Object is not a PerMassLengthSqrTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassLengthSqrTimeCub l1, PerMassLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassLengthSqrTimeCub FromPerKilogramCubCentimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub(value * perkilogramcubcentimetersqrsecondcub_.Factor, minValue * perkilogramcubcentimetersqrsecondcub_.Factor, maxValue * perkilogramcubcentimetersqrsecondcub_.Factor);
		public static PerMassLengthSqrTimeCub FromPerKilogramCubCentimeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub(value * perkilogramcubcentimetersqrsecondcub_.Factor);
		public double GetValueInPerKilogramCubCentimeterSqrSecondCubs() => Value_ / perkilogramcubcentimetersqrsecondcub_.Factor;
		public static PerMassLengthSqrTimeCub FromPerKilogramCubMillimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub(value * perkilogramcubmillimetersqrsecondcub_.Factor, minValue * perkilogramcubmillimetersqrsecondcub_.Factor, maxValue * perkilogramcubmillimetersqrsecondcub_.Factor);
		public static PerMassLengthSqrTimeCub FromPerKilogramCubMillimeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub(value * perkilogramcubmillimetersqrsecondcub_.Factor);
		public double GetValueInPerKilogramCubMillimeterSqrSecondCubs() => Value_ / perkilogramcubmillimetersqrsecondcub_.Factor;
		public static PerMassLengthSqrTimeCub FromPerKilogramCubMeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub(value * perkilogramcubmetersqrsecondcub_.Factor, minValue * perkilogramcubmetersqrsecondcub_.Factor, maxValue * perkilogramcubmetersqrsecondcub_.Factor);
		public static PerMassLengthSqrTimeCub FromPerKilogramCubMeterSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub(value * perkilogramcubmetersqrsecondcub_.Factor);
		public double GetValueInPerKilogramCubMeterSqrSecondCubs() => Value_ / perkilogramcubmetersqrsecondcub_.Factor;
		public static PerMassLengthSqrTimeCub FromPerKilogramCubInchSqrSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeCub(value * perkilogramcubinchsqrsecondcub_.Factor, minValue * perkilogramcubinchsqrsecondcub_.Factor, maxValue * perkilogramcubinchsqrsecondcub_.Factor);
		public static PerMassLengthSqrTimeCub FromPerKilogramCubInchSqrSecondCubs(double value) => new PerMassLengthSqrTimeCub(value * perkilogramcubinchsqrsecondcub_.Factor);
		public double GetValueInPerKilogramCubInchSqrSecondCubs() => Value_ / perkilogramcubinchsqrsecondcub_.Factor;

#endregion

#region arithmetic
		public static PerMassLengthSqrTimeCub operator+(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ + o2.Value_);
		public static PerMassLengthSqrTimeCub operator-(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerMassLengthSqrTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerMassLengthSqrTimeCub o1, TimeCubLengthSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeCubLengthSqrMass o1, PerMassLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeSqrMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthCubTimeSqrMass o1, PerMassLengthSqrTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerMassLengthSqrTimeCub o1, PerMassLengthCubTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerMassLengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerMassLengthSqrTimeCub o1, LengthCubTimeCubMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubTimeCubMass o1, PerMassLengthSqrTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassLengthSqrTimeCub permasslengthsqrtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasslengthsqrtimecub.HasMinValue && permasslengthsqrtimecub.Value_ < permasslengthsqrtimecub.MinValue)
        {
            fail = true;
        }

        if (permasslengthsqrtimecub.HasMaxValue && permasslengthsqrtimecub.Value_ > permasslengthsqrtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassLengthSqrTimeCub is outside its bounds.");
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
    