
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimeSqrPerMass : Quantity, IEquatable<LengthCubTimeSqrPerMass>, IComparable
    {
    internal LengthCubTimeSqrPerMass(double value) : base(value, 2)
    {
        LengthCubTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimeSqrPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimeSqrPerMass(LengthCubTimeSqrPerMass other) : base(other)
    {
        LengthCubTimeSqrPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeSqrPerMass"))
        {
            switch(FakeDatabase.Units["LengthCubTimeSqrPerMass"])
            {
				      case "centimetercubsecondsqrperkilogram": displayUnit_ = centimetercubsecondsqrperkilogram_; break;
				      case "millimetercubsecondsqrperkilogram": displayUnit_ = millimetercubsecondsqrperkilogram_; break;
				      case "metercubsecondsqrperkilogram": displayUnit_ = metercubsecondsqrperkilogram_; break;
				      case "inchcubsecondsqrperkilogram": displayUnit_ = inchcubsecondsqrperkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondsqrperkilogram_ = new Unit_("CentimeterCubSecondSqrPerKilogram", "cm³ s²/kg", 1.0);
	private static Unit_ millimetercubsecondsqrperkilogram_ = new Unit_("MillimeterCubSecondSqrPerKilogram", "mm³ s²/kg", 0.0010000000000000002);
	private static Unit_ metercubsecondsqrperkilogram_ = new Unit_("MeterCubSecondSqrPerKilogram", "m³ s²/kg", 1000000.0);
	private static Unit_ inchcubsecondsqrperkilogram_ = new Unit_("InchCubSecondSqrPerKilogram", "in³ s²/kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondsqrperkilogram_;
	private static Unit_ displayUnit_ = centimetercubsecondsqrperkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimeSqrPerMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimeSqrPerMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimeSqrPerMass other)) throw new ArgumentException("Object is not a LengthCubTimeSqrPerMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimeSqrPerMass l1, LengthCubTimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimeSqrPerMass FromCentimeterCubSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrPerMass(value * centimetercubsecondsqrperkilogram_.Factor, minValue * centimetercubsecondsqrperkilogram_.Factor, maxValue * centimetercubsecondsqrperkilogram_.Factor);
		public static LengthCubTimeSqrPerMass FromCentimeterCubSecondSqrPerKilograms(double value) => new LengthCubTimeSqrPerMass(value * centimetercubsecondsqrperkilogram_.Factor);
		public double GetValueInCentimeterCubSecondSqrPerKilograms() => Value_ / centimetercubsecondsqrperkilogram_.Factor;
		public static LengthCubTimeSqrPerMass FromMillimeterCubSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrPerMass(value * millimetercubsecondsqrperkilogram_.Factor, minValue * millimetercubsecondsqrperkilogram_.Factor, maxValue * millimetercubsecondsqrperkilogram_.Factor);
		public static LengthCubTimeSqrPerMass FromMillimeterCubSecondSqrPerKilograms(double value) => new LengthCubTimeSqrPerMass(value * millimetercubsecondsqrperkilogram_.Factor);
		public double GetValueInMillimeterCubSecondSqrPerKilograms() => Value_ / millimetercubsecondsqrperkilogram_.Factor;
		public static LengthCubTimeSqrPerMass FromMeterCubSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrPerMass(value * metercubsecondsqrperkilogram_.Factor, minValue * metercubsecondsqrperkilogram_.Factor, maxValue * metercubsecondsqrperkilogram_.Factor);
		public static LengthCubTimeSqrPerMass FromMeterCubSecondSqrPerKilograms(double value) => new LengthCubTimeSqrPerMass(value * metercubsecondsqrperkilogram_.Factor);
		public double GetValueInMeterCubSecondSqrPerKilograms() => Value_ / metercubsecondsqrperkilogram_.Factor;
		public static LengthCubTimeSqrPerMass FromInchCubSecondSqrPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimeSqrPerMass(value * inchcubsecondsqrperkilogram_.Factor, minValue * inchcubsecondsqrperkilogram_.Factor, maxValue * inchcubsecondsqrperkilogram_.Factor);
		public static LengthCubTimeSqrPerMass FromInchCubSecondSqrPerKilograms(double value) => new LengthCubTimeSqrPerMass(value * inchcubsecondsqrperkilogram_.Factor);
		public double GetValueInInchCubSecondSqrPerKilograms() => Value_ / inchcubsecondsqrperkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimeSqrPerMass operator+(LengthCubTimeSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ + o2.Value_);
		public static LengthCubTimeSqrPerMass operator-(LengthCubTimeSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimeSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(LengthCubTimeSqrPerMass o1, LengthCubTimeCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(LengthCubTimeCub o1, LengthCubTimeSqrPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(LengthCubTimeSqrPerMass o1, MassPerLengthCubTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(MassPerLengthCubTimeCub o1, LengthCubTimeSqrPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(LengthCubTimeSqrPerMass o1, LengthCubTimeCubPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubTimeCubPerMass o1, LengthCubTimeSqrPerMass o2) => new Time(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimeSqrPerMass lengthcubtimesqrpermass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimesqrpermass.HasMinValue && lengthcubtimesqrpermass.Value_ < lengthcubtimesqrpermass.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimesqrpermass.HasMaxValue && lengthcubtimesqrpermass.Value_ > lengthcubtimesqrpermass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimeSqrPerMass is outside its bounds.");
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
    