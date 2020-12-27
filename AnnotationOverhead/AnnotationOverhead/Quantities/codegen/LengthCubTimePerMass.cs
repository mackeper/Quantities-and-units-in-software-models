
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimePerMass : Quantity, IEquatable<LengthCubTimePerMass>, IComparable
    {
    internal LengthCubTimePerMass(double value) : base(value, 2)
    {
        LengthCubTimePerMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimePerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimePerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimePerMass(LengthCubTimePerMass other) : base(other)
    {
        LengthCubTimePerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimePerMass"))
        {
            switch(FakeDatabase.Units["LengthCubTimePerMass"])
            {
				      case "centimetercubsecondperkilogram": displayUnit_ = centimetercubsecondperkilogram_; break;
				      case "millimetercubsecondperkilogram": displayUnit_ = millimetercubsecondperkilogram_; break;
				      case "metercubsecondperkilogram": displayUnit_ = metercubsecondperkilogram_; break;
				      case "inchcubsecondperkilogram": displayUnit_ = inchcubsecondperkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondperkilogram_ = new Unit_("CentimeterCubSecondPerKilogram", "cm³ s/kg", 1.0);
	private static Unit_ millimetercubsecondperkilogram_ = new Unit_("MillimeterCubSecondPerKilogram", "mm³ s/kg", 0.0010000000000000002);
	private static Unit_ metercubsecondperkilogram_ = new Unit_("MeterCubSecondPerKilogram", "m³ s/kg", 1000000.0);
	private static Unit_ inchcubsecondperkilogram_ = new Unit_("InchCubSecondPerKilogram", "in³ s/kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondperkilogram_;
	private static Unit_ displayUnit_ = centimetercubsecondperkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimePerMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimePerMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimePerMass other)) throw new ArgumentException("Object is not a LengthCubTimePerMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimePerMass l1, LengthCubTimePerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimePerMass FromCentimeterCubSecondPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimePerMass(value * centimetercubsecondperkilogram_.Factor, minValue * centimetercubsecondperkilogram_.Factor, maxValue * centimetercubsecondperkilogram_.Factor);
		public static LengthCubTimePerMass FromCentimeterCubSecondPerKilograms(double value) => new LengthCubTimePerMass(value * centimetercubsecondperkilogram_.Factor);
		public double GetValueInCentimeterCubSecondPerKilograms() => Value_ / centimetercubsecondperkilogram_.Factor;
		public static LengthCubTimePerMass FromMillimeterCubSecondPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimePerMass(value * millimetercubsecondperkilogram_.Factor, minValue * millimetercubsecondperkilogram_.Factor, maxValue * millimetercubsecondperkilogram_.Factor);
		public static LengthCubTimePerMass FromMillimeterCubSecondPerKilograms(double value) => new LengthCubTimePerMass(value * millimetercubsecondperkilogram_.Factor);
		public double GetValueInMillimeterCubSecondPerKilograms() => Value_ / millimetercubsecondperkilogram_.Factor;
		public static LengthCubTimePerMass FromMeterCubSecondPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimePerMass(value * metercubsecondperkilogram_.Factor, minValue * metercubsecondperkilogram_.Factor, maxValue * metercubsecondperkilogram_.Factor);
		public static LengthCubTimePerMass FromMeterCubSecondPerKilograms(double value) => new LengthCubTimePerMass(value * metercubsecondperkilogram_.Factor);
		public double GetValueInMeterCubSecondPerKilograms() => Value_ / metercubsecondperkilogram_.Factor;
		public static LengthCubTimePerMass FromInchCubSecondPerKilograms(double value, double minValue, double maxValue) => new LengthCubTimePerMass(value * inchcubsecondperkilogram_.Factor, minValue * inchcubsecondperkilogram_.Factor, maxValue * inchcubsecondperkilogram_.Factor);
		public static LengthCubTimePerMass FromInchCubSecondPerKilograms(double value) => new LengthCubTimePerMass(value * inchcubsecondperkilogram_.Factor);
		public double GetValueInInchCubSecondPerKilograms() => Value_ / inchcubsecondperkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimePerMass operator+(LengthCubTimePerMass o1, LengthCubTimePerMass o2) => new LengthCubTimePerMass(o1.Value_ + o2.Value_);
		public static LengthCubTimePerMass operator-(LengthCubTimePerMass o1, LengthCubTimePerMass o2) => new LengthCubTimePerMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimePerMass o1, LengthCubTimePerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator/(LengthCubTimePerMass o1, LengthCubPerTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(LengthCubPerTimeSqr o1, LengthCubTimePerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(LengthCubTimePerMass o1, LengthCubTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(LengthCubTimeSqr o1, LengthCubTimePerMass o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(LengthCubTimePerMass o1, PerLengthCubTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(PerLengthCubTimeCub o1, LengthCubTimePerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(LengthCubTimePerMass o1, MassPerTimeSqrLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(MassPerTimeSqrLengthCub o1, LengthCubTimePerMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(LengthCubTimePerMass o1, TimeSqrMassPerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqrMassPerLengthCub o1, LengthCubTimePerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(LengthCubTimePerMass o1, MassPerLengthSqrTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(MassPerLengthSqrTimeCub o1, LengthCubTimePerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Acceleration operator/(LengthCubTimePerMass o1, TimeCubLengthSqrPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubLengthSqrPerMass o1, LengthCubTimePerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static TimeCub operator/(LengthCubTimePerMass o1, LengthCubPerMassTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(LengthCubPerMassTimeSqr o1, LengthCubTimePerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(LengthCubTimePerMass o1, LengthCubTimeSqrPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubTimeSqrPerMass o1, LengthCubTimePerMass o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(LengthCubTimePerMass o1, LengthCubTimeCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(LengthCubTimeCub o1, LengthCubTimePerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(LengthCubTimePerMass o1, MassPerLengthCubTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(MassPerLengthCubTimeCub o1, LengthCubTimePerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(LengthCubTimePerMass o1, LengthCubTimeCubPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthCubTimeCubPerMass o1, LengthCubTimePerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimePerMass lengthcubtimepermass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimepermass.HasMinValue && lengthcubtimepermass.Value_ < lengthcubtimepermass.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimepermass.HasMaxValue && lengthcubtimepermass.Value_ > lengthcubtimepermass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimePerMass is outside its bounds.");
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
    