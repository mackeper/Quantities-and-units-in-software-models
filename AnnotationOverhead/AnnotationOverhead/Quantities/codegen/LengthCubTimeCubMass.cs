
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimeCubMass : Quantity, IEquatable<LengthCubTimeCubMass>, IComparable
    {
    internal LengthCubTimeCubMass(double value) : base(value, 2)
    {
        LengthCubTimeCubMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimeCubMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimeCubMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimeCubMass(LengthCubTimeCubMass other) : base(other)
    {
        LengthCubTimeCubMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeCubMass"))
        {
            switch(FakeDatabase.Units["LengthCubTimeCubMass"])
            {
				      case "centimetercubsecondcubkilogram": displayUnit_ = centimetercubsecondcubkilogram_; break;
				      case "millimetercubsecondcubkilogram": displayUnit_ = millimetercubsecondcubkilogram_; break;
				      case "metercubsecondcubkilogram": displayUnit_ = metercubsecondcubkilogram_; break;
				      case "inchcubsecondcubkilogram": displayUnit_ = inchcubsecondcubkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondcubkilogram_ = new Unit_("CentimeterCubSecondCubKilogram", "cm³ s³ kg", 1);
	private static Unit_ millimetercubsecondcubkilogram_ = new Unit_("MillimeterCubSecondCubKilogram", "mm³ s³ kg", 0.0010000000000000002);
	private static Unit_ metercubsecondcubkilogram_ = new Unit_("MeterCubSecondCubKilogram", "m³ s³ kg", 1000000);
	private static Unit_ inchcubsecondcubkilogram_ = new Unit_("InchCubSecondCubKilogram", "in³ s³ kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondcubkilogram_;
	private static Unit_ displayUnit_ = centimetercubsecondcubkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimeCubMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimeCubMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimeCubMass other)) throw new ArgumentException("Object is not a LengthCubTimeCubMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimeCubMass l1, LengthCubTimeCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimeCubMass FromCentimeterCubSecondCubKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubMass(value * centimetercubsecondcubkilogram_.Factor, minValue * centimetercubsecondcubkilogram_.Factor, maxValue * centimetercubsecondcubkilogram_.Factor);
		public static LengthCubTimeCubMass FromCentimeterCubSecondCubKilograms(double value) => new LengthCubTimeCubMass(value * centimetercubsecondcubkilogram_.Factor);
		public double GetValueInCentimeterCubSecondCubKilograms() => Value_ / centimetercubsecondcubkilogram_.Factor;
		public static LengthCubTimeCubMass FromMillimeterCubSecondCubKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubMass(value * millimetercubsecondcubkilogram_.Factor, minValue * millimetercubsecondcubkilogram_.Factor, maxValue * millimetercubsecondcubkilogram_.Factor);
		public static LengthCubTimeCubMass FromMillimeterCubSecondCubKilograms(double value) => new LengthCubTimeCubMass(value * millimetercubsecondcubkilogram_.Factor);
		public double GetValueInMillimeterCubSecondCubKilograms() => Value_ / millimetercubsecondcubkilogram_.Factor;
		public static LengthCubTimeCubMass FromMeterCubSecondCubKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubMass(value * metercubsecondcubkilogram_.Factor, minValue * metercubsecondcubkilogram_.Factor, maxValue * metercubsecondcubkilogram_.Factor);
		public static LengthCubTimeCubMass FromMeterCubSecondCubKilograms(double value) => new LengthCubTimeCubMass(value * metercubsecondcubkilogram_.Factor);
		public double GetValueInMeterCubSecondCubKilograms() => Value_ / metercubsecondcubkilogram_.Factor;
		public static LengthCubTimeCubMass FromInchCubSecondCubKilograms(double value, double minValue, double maxValue) => new LengthCubTimeCubMass(value * inchcubsecondcubkilogram_.Factor, minValue * inchcubsecondcubkilogram_.Factor, maxValue * inchcubsecondcubkilogram_.Factor);
		public static LengthCubTimeCubMass FromInchCubSecondCubKilograms(double value) => new LengthCubTimeCubMass(value * inchcubsecondcubkilogram_.Factor);
		public double GetValueInInchCubSecondCubKilograms() => Value_ / inchcubsecondcubkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimeCubMass operator+(LengthCubTimeCubMass o1, LengthCubTimeCubMass o2) => new LengthCubTimeCubMass(o1.Value_ + o2.Value_);
		public static LengthCubTimeCubMass operator-(LengthCubTimeCubMass o1, LengthCubTimeCubMass o2) => new LengthCubTimeCubMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimeCubMass o1, LengthCubTimeCubMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimeCubMass lengthcubtimecubmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimecubmass.HasMinValue && lengthcubtimecubmass.Value_ < lengthcubtimecubmass.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimecubmass.HasMaxValue && lengthcubtimecubmass.Value_ > lengthcubtimecubmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimeCubMass is outside its bounds.");
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
    