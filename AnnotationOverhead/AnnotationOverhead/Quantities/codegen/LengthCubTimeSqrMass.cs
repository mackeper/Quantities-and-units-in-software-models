
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimeSqrMass : Quantity, IEquatable<LengthCubTimeSqrMass>, IComparable
    {
    internal LengthCubTimeSqrMass(double value) : base(value, 2)
    {
        LengthCubTimeSqrMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimeSqrMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimeSqrMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimeSqrMass(LengthCubTimeSqrMass other) : base(other)
    {
        LengthCubTimeSqrMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeSqrMass"))
        {
            switch(FakeDatabase.Units["LengthCubTimeSqrMass"])
            {
				      case "centimetercubsecondsqrkilogram": displayUnit_ = centimetercubsecondsqrkilogram_; break;
				      case "millimetercubsecondsqrkilogram": displayUnit_ = millimetercubsecondsqrkilogram_; break;
				      case "metercubsecondsqrkilogram": displayUnit_ = metercubsecondsqrkilogram_; break;
				      case "inchcubsecondsqrkilogram": displayUnit_ = inchcubsecondsqrkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondsqrkilogram_ = new Unit_("CentimeterCubSecondSqrKilogram", "cm³ s² kg", 1);
	private static Unit_ millimetercubsecondsqrkilogram_ = new Unit_("MillimeterCubSecondSqrKilogram", "mm³ s² kg", 0.0010000000000000002);
	private static Unit_ metercubsecondsqrkilogram_ = new Unit_("MeterCubSecondSqrKilogram", "m³ s² kg", 1000000);
	private static Unit_ inchcubsecondsqrkilogram_ = new Unit_("InchCubSecondSqrKilogram", "in³ s² kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondsqrkilogram_;
	private static Unit_ displayUnit_ = centimetercubsecondsqrkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimeSqrMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimeSqrMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimeSqrMass other)) throw new ArgumentException("Object is not a LengthCubTimeSqrMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimeSqrMass l1, LengthCubTimeSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimeSqrMass FromCentimeterCubSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrMass(value * centimetercubsecondsqrkilogram_.Factor, minValue * centimetercubsecondsqrkilogram_.Factor, maxValue * centimetercubsecondsqrkilogram_.Factor);
		public static LengthCubTimeSqrMass FromCentimeterCubSecondSqrKilograms(double value) => new LengthCubTimeSqrMass(value * centimetercubsecondsqrkilogram_.Factor);
		public double GetValueInCentimeterCubSecondSqrKilograms() => Value_ / centimetercubsecondsqrkilogram_.Factor;
		public static LengthCubTimeSqrMass FromMillimeterCubSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrMass(value * millimetercubsecondsqrkilogram_.Factor, minValue * millimetercubsecondsqrkilogram_.Factor, maxValue * millimetercubsecondsqrkilogram_.Factor);
		public static LengthCubTimeSqrMass FromMillimeterCubSecondSqrKilograms(double value) => new LengthCubTimeSqrMass(value * millimetercubsecondsqrkilogram_.Factor);
		public double GetValueInMillimeterCubSecondSqrKilograms() => Value_ / millimetercubsecondsqrkilogram_.Factor;
		public static LengthCubTimeSqrMass FromMeterCubSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrMass(value * metercubsecondsqrkilogram_.Factor, minValue * metercubsecondsqrkilogram_.Factor, maxValue * metercubsecondsqrkilogram_.Factor);
		public static LengthCubTimeSqrMass FromMeterCubSecondSqrKilograms(double value) => new LengthCubTimeSqrMass(value * metercubsecondsqrkilogram_.Factor);
		public double GetValueInMeterCubSecondSqrKilograms() => Value_ / metercubsecondsqrkilogram_.Factor;
		public static LengthCubTimeSqrMass FromInchCubSecondSqrKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrMass(value * inchcubsecondsqrkilogram_.Factor, minValue * inchcubsecondsqrkilogram_.Factor, maxValue * inchcubsecondsqrkilogram_.Factor);
		public static LengthCubTimeSqrMass FromInchCubSecondSqrKilograms(double value) => new LengthCubTimeSqrMass(value * inchcubsecondsqrkilogram_.Factor);
		public double GetValueInInchCubSecondSqrKilograms() => Value_ / inchcubsecondsqrkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimeSqrMass operator+(LengthCubTimeSqrMass o1, LengthCubTimeSqrMass o2) => new LengthCubTimeSqrMass(o1.Value_ + o2.Value_);
		public static LengthCubTimeSqrMass operator-(LengthCubTimeSqrMass o1, LengthCubTimeSqrMass o2) => new LengthCubTimeSqrMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimeSqrMass o1, LengthCubTimeSqrMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(LengthCubTimeSqrMass o1, PerMassLengthCubTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerMassLengthCubTimeCub o1, LengthCubTimeSqrMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(LengthCubTimeSqrMass o1, LengthCubTimeCubMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubTimeCubMass o1, LengthCubTimeSqrMass o2) => new Time(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimeSqrMass lengthcubtimesqrmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimesqrmass.HasMinValue && lengthcubtimesqrmass.Value_ < lengthcubtimesqrmass.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimesqrmass.HasMaxValue && lengthcubtimesqrmass.Value_ > lengthcubtimesqrmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimeSqrMass is outside its bounds.");
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
    