
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimeCubPerMass : Quantity, IEquatable<LengthCubTimeCubPerMass>, IComparable
    {
    internal LengthCubTimeCubPerMass(double value) : base(value, 2)
    {
        LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimeCubPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimeCubPerMass(LengthCubTimeCubPerMass other) : base(other)
    {
        LengthCubTimeCubPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeCubPerMass"))
        {
            switch(FakeDatabase.Units["LengthCubTimeCubPerMass"])
            {
				      case "centimetercubsecondcubperkilogram": displayUnit_ = centimetercubsecondcubperkilogram_; break;
				      case "millimetercubsecondcubperkilogram": displayUnit_ = millimetercubsecondcubperkilogram_; break;
				      case "metercubsecondcubperkilogram": displayUnit_ = metercubsecondcubperkilogram_; break;
				      case "inchcubsecondcubperkilogram": displayUnit_ = inchcubsecondcubperkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondcubperkilogram_ = new Unit_("CentimeterCubSecondCubPerKilogram", "cm³ s³/kg", 1.0);
	private static Unit_ millimetercubsecondcubperkilogram_ = new Unit_("MillimeterCubSecondCubPerKilogram", "mm³ s³/kg", 0.0010000000000000002);
	private static Unit_ metercubsecondcubperkilogram_ = new Unit_("MeterCubSecondCubPerKilogram", "m³ s³/kg", 1000000.0);
	private static Unit_ inchcubsecondcubperkilogram_ = new Unit_("InchCubSecondCubPerKilogram", "in³ s³/kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondcubperkilogram_;
	private static Unit_ displayUnit_ = centimetercubsecondcubperkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimeCubPerMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimeCubPerMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimeCubPerMass other)) throw new ArgumentException("Object is not a LengthCubTimeCubPerMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimeCubPerMass l1, LengthCubTimeCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimeCubPerMass FromCentimeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass(value * centimetercubsecondcubperkilogram_.Factor, minValue * centimetercubsecondcubperkilogram_.Factor, maxValue * centimetercubsecondcubperkilogram_.Factor);
		public static LengthCubTimeCubPerMass FromCentimeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass(value * centimetercubsecondcubperkilogram_.Factor);
		public double GetValueInCentimeterCubSecondCubPerKilograms() => Value_ / centimetercubsecondcubperkilogram_.Factor;
		public static LengthCubTimeCubPerMass FromMillimeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass(value * millimetercubsecondcubperkilogram_.Factor, minValue * millimetercubsecondcubperkilogram_.Factor, maxValue * millimetercubsecondcubperkilogram_.Factor);
		public static LengthCubTimeCubPerMass FromMillimeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass(value * millimetercubsecondcubperkilogram_.Factor);
		public double GetValueInMillimeterCubSecondCubPerKilograms() => Value_ / millimetercubsecondcubperkilogram_.Factor;
		public static LengthCubTimeCubPerMass FromMeterCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass(value * metercubsecondcubperkilogram_.Factor, minValue * metercubsecondcubperkilogram_.Factor, maxValue * metercubsecondcubperkilogram_.Factor);
		public static LengthCubTimeCubPerMass FromMeterCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass(value * metercubsecondcubperkilogram_.Factor);
		public double GetValueInMeterCubSecondCubPerKilograms() => Value_ / metercubsecondcubperkilogram_.Factor;
		public static LengthCubTimeCubPerMass FromInchCubSecondCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubPerMass(value * inchcubsecondcubperkilogram_.Factor, minValue * inchcubsecondcubperkilogram_.Factor, maxValue * inchcubsecondcubperkilogram_.Factor);
		public static LengthCubTimeCubPerMass FromInchCubSecondCubPerKilograms(double value) => new LengthCubTimeCubPerMass(value * inchcubsecondcubperkilogram_.Factor);
		public double GetValueInInchCubSecondCubPerKilograms() => Value_ / inchcubsecondcubperkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimeCubPerMass operator+(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ + o2.Value_);
		public static LengthCubTimeCubPerMass operator-(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimeCubPerMass o1, LengthCubTimeCubPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimeCubPerMass lengthcubtimecubpermass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimecubpermass.HasMinValue && lengthcubtimecubpermass.Value_ < lengthcubtimecubpermass.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimecubpermass.HasMaxValue && lengthcubtimecubpermass.Value_ > lengthcubtimecubpermass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimeCubPerMass is outside its bounds.");
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
    