
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassLengthCubTimeCub : Quantity, IEquatable<PerMassLengthCubTimeCub>, IComparable
    {
    internal PerMassLengthCubTimeCub(double value) : base(value, 2)
    {
        PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassLengthCubTimeCub(PerMassLengthCubTimeCub other) : base(other)
    {
        PerMassLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthCubTimeCub"))
        {
            switch(FakeDatabase.Units["PerMassLengthCubTimeCub"])
            {
				      case "perkilogramcubcentimetercubsecondcub": displayUnit_ = perkilogramcubcentimetercubsecondcub_; break;
				      case "perkilogramcubmillimetercubsecondcub": displayUnit_ = perkilogramcubmillimetercubsecondcub_; break;
				      case "perkilogramcubmetercubsecondcub": displayUnit_ = perkilogramcubmetercubsecondcub_; break;
				      case "perkilogramcubinchcubsecondcub": displayUnit_ = perkilogramcubinchcubsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubcentimetercubsecondcub_ = new Unit_("PerKilogramCubCentimeterCubSecondCub", "/kg³ cm³ s³", 1.0);
	private static Unit_ perkilogramcubmillimetercubsecondcub_ = new Unit_("PerKilogramCubMillimeterCubSecondCub", "/kg³ mm³ s³", 999.9999999999998);
	private static Unit_ perkilogramcubmetercubsecondcub_ = new Unit_("PerKilogramCubMeterCubSecondCub", "/kg³ m³ s³", 1e-06);
	private static Unit_ perkilogramcubinchcubsecondcub_ = new Unit_("PerKilogramCubInchCubSecondCub", "/kg³ in³ s³", 0.05960464477539062);
	private static Unit_ platformUnit_ = perkilogramcubcentimetercubsecondcub_;
	private static Unit_ displayUnit_ = perkilogramcubcentimetercubsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassLengthCubTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerMassLengthCubTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassLengthCubTimeCub other)) throw new ArgumentException("Object is not a PerMassLengthCubTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassLengthCubTimeCub l1, PerMassLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassLengthCubTimeCub FromPerKilogramCubCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub(value * perkilogramcubcentimetercubsecondcub_.Factor, minValue * perkilogramcubcentimetercubsecondcub_.Factor, maxValue * perkilogramcubcentimetercubsecondcub_.Factor);
		public static PerMassLengthCubTimeCub FromPerKilogramCubCentimeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub(value * perkilogramcubcentimetercubsecondcub_.Factor);
		public double GetValueInPerKilogramCubCentimeterCubSecondCubs() => Value_ / perkilogramcubcentimetercubsecondcub_.Factor;
		public static PerMassLengthCubTimeCub FromPerKilogramCubMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub(value * perkilogramcubmillimetercubsecondcub_.Factor, minValue * perkilogramcubmillimetercubsecondcub_.Factor, maxValue * perkilogramcubmillimetercubsecondcub_.Factor);
		public static PerMassLengthCubTimeCub FromPerKilogramCubMillimeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub(value * perkilogramcubmillimetercubsecondcub_.Factor);
		public double GetValueInPerKilogramCubMillimeterCubSecondCubs() => Value_ / perkilogramcubmillimetercubsecondcub_.Factor;
		public static PerMassLengthCubTimeCub FromPerKilogramCubMeterCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub(value * perkilogramcubmetercubsecondcub_.Factor, minValue * perkilogramcubmetercubsecondcub_.Factor, maxValue * perkilogramcubmetercubsecondcub_.Factor);
		public static PerMassLengthCubTimeCub FromPerKilogramCubMeterCubSecondCubs(double value) => new PerMassLengthCubTimeCub(value * perkilogramcubmetercubsecondcub_.Factor);
		public double GetValueInPerKilogramCubMeterCubSecondCubs() => Value_ / perkilogramcubmetercubsecondcub_.Factor;
		public static PerMassLengthCubTimeCub FromPerKilogramCubInchCubSecondCubs(double value, double minValue, double maxValue) => new PerMassLengthCubTimeCub(value * perkilogramcubinchcubsecondcub_.Factor, minValue * perkilogramcubinchcubsecondcub_.Factor, maxValue * perkilogramcubinchcubsecondcub_.Factor);
		public static PerMassLengthCubTimeCub FromPerKilogramCubInchCubSecondCubs(double value) => new PerMassLengthCubTimeCub(value * perkilogramcubinchcubsecondcub_.Factor);
		public double GetValueInPerKilogramCubInchCubSecondCubs() => Value_ / perkilogramcubinchcubsecondcub_.Factor;

#endregion

#region arithmetic
		public static PerMassLengthCubTimeCub operator+(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ + o2.Value_);
		public static PerMassLengthCubTimeCub operator-(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new PerMassLengthCubTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerMassLengthCubTimeCub o1, LengthCubTimeCubMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimeCubMass o1, PerMassLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassLengthCubTimeCub permasslengthcubtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasslengthcubtimecub.HasMinValue && permasslengthcubtimecub.Value_ < permasslengthcubtimecub.MinValue)
        {
            fail = true;
        }

        if (permasslengthcubtimecub.HasMaxValue && permasslengthcubtimecub.Value_ > permasslengthcubtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassLengthCubTimeCub is outside its bounds.");
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
    