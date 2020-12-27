
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerLengthCubTimeCub : Quantity, IEquatable<MassPerLengthCubTimeCub>, IComparable
    {
    internal MassPerLengthCubTimeCub(double value) : base(value, 2)
    {
        MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerLengthCubTimeCub(MassPerLengthCubTimeCub other) : base(other)
    {
        MassPerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthCubTimeCub"))
        {
            switch(FakeDatabase.Units["MassPerLengthCubTimeCub"])
            {
				      case "kilogrampercentimetercubsecondcub": displayUnit_ = kilogrampercentimetercubsecondcub_; break;
				      case "kilogrampermillimetercubsecondcub": displayUnit_ = kilogrampermillimetercubsecondcub_; break;
				      case "kilogrampermetercubsecondcub": displayUnit_ = kilogrampermetercubsecondcub_; break;
				      case "kilogramperinchcubsecondcub": displayUnit_ = kilogramperinchcubsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampercentimetercubsecondcub_ = new Unit_("KilogramPerCentimeterCubSecondCub", "kg/cm³ s³", 1.0);
	private static Unit_ kilogrampermillimetercubsecondcub_ = new Unit_("KilogramPerMillimeterCubSecondCub", "kg/mm³ s³", 999.9999999999998);
	private static Unit_ kilogrampermetercubsecondcub_ = new Unit_("KilogramPerMeterCubSecondCub", "kg/m³ s³", 1e-06);
	private static Unit_ kilogramperinchcubsecondcub_ = new Unit_("KilogramPerInchCubSecondCub", "kg/in³ s³", 0.05960464477539062);
	private static Unit_ platformUnit_ = kilogrampercentimetercubsecondcub_;
	private static Unit_ displayUnit_ = kilogrampercentimetercubsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerLengthCubTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(MassPerLengthCubTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerLengthCubTimeCub other)) throw new ArgumentException("Object is not a MassPerLengthCubTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => !(l1 == l2);
    public static bool operator <(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerLengthCubTimeCub l1, MassPerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerLengthCubTimeCub FromKilogramPerCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub(value * kilogrampercentimetercubsecondcub_.Factor, minValue * kilogrampercentimetercubsecondcub_.Factor, maxValue * kilogrampercentimetercubsecondcub_.Factor);
		public static MassPerLengthCubTimeCub FromKilogramPerCentimeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub(value * kilogrampercentimetercubsecondcub_.Factor);
		public double GetValueInKilogramPerCentimeterCubSecondCubs() => Value_ / kilogrampercentimetercubsecondcub_.Factor;
		public static MassPerLengthCubTimeCub FromKilogramPerMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub(value * kilogrampermillimetercubsecondcub_.Factor, minValue * kilogrampermillimetercubsecondcub_.Factor, maxValue * kilogrampermillimetercubsecondcub_.Factor);
		public static MassPerLengthCubTimeCub FromKilogramPerMillimeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub(value * kilogrampermillimetercubsecondcub_.Factor);
		public double GetValueInKilogramPerMillimeterCubSecondCubs() => Value_ / kilogrampermillimetercubsecondcub_.Factor;
		public static MassPerLengthCubTimeCub FromKilogramPerMeterCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub(value * kilogrampermetercubsecondcub_.Factor, minValue * kilogrampermetercubsecondcub_.Factor, maxValue * kilogrampermetercubsecondcub_.Factor);
		public static MassPerLengthCubTimeCub FromKilogramPerMeterCubSecondCubs(double value) => new MassPerLengthCubTimeCub(value * kilogrampermetercubsecondcub_.Factor);
		public double GetValueInKilogramPerMeterCubSecondCubs() => Value_ / kilogrampermetercubsecondcub_.Factor;
		public static MassPerLengthCubTimeCub FromKilogramPerInchCubSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthCubTimeCub(value * kilogramperinchcubsecondcub_.Factor, minValue * kilogramperinchcubsecondcub_.Factor, maxValue * kilogramperinchcubsecondcub_.Factor);
		public static MassPerLengthCubTimeCub FromKilogramPerInchCubSecondCubs(double value) => new MassPerLengthCubTimeCub(value * kilogramperinchcubsecondcub_.Factor);
		public double GetValueInKilogramPerInchCubSecondCubs() => Value_ / kilogramperinchcubsecondcub_.Factor;

#endregion

#region arithmetic
		public static MassPerLengthCubTimeCub operator+(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ + o2.Value_);
		public static MassPerLengthCubTimeCub operator-(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new MassPerLengthCubTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(MassPerLengthCubTimeCub o1, LengthCubTimeCubPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimeCubPerMass o1, MassPerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerLengthCubTimeCub massperlengthcubtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (massperlengthcubtimecub.HasMinValue && massperlengthcubtimecub.Value_ < massperlengthcubtimecub.MinValue)
        {
            fail = true;
        }

        if (massperlengthcubtimecub.HasMaxValue && massperlengthcubtimecub.Value_ > massperlengthcubtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerLengthCubTimeCub is outside its bounds.");
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
    