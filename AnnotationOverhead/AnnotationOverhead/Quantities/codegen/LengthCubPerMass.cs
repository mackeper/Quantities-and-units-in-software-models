
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubPerMass : Quantity, IEquatable<LengthCubPerMass>, IComparable
    {
    internal LengthCubPerMass(double value) : base(value, 2)
    {
        LengthCubPerMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubPerMass(LengthCubPerMass other) : base(other)
    {
        LengthCubPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerMass"))
        {
            switch(FakeDatabase.Units["LengthCubPerMass"])
            {
				      case "centimetercubperkilogram": displayUnit_ = centimetercubperkilogram_; break;
				      case "millimetercubperkilogram": displayUnit_ = millimetercubperkilogram_; break;
				      case "metercubperkilogram": displayUnit_ = metercubperkilogram_; break;
				      case "inchcubperkilogram": displayUnit_ = inchcubperkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubperkilogram_ = new Unit_("CentimeterCubPerKilogram", "cm³/kg", 1.0);
	private static Unit_ millimetercubperkilogram_ = new Unit_("MillimeterCubPerKilogram", "mm³/kg", 0.0010000000000000002);
	private static Unit_ metercubperkilogram_ = new Unit_("MeterCubPerKilogram", "m³/kg", 1000000.0);
	private static Unit_ inchcubperkilogram_ = new Unit_("InchCubPerKilogram", "in³/kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubperkilogram_;
	private static Unit_ displayUnit_ = centimetercubperkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubPerMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubPerMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubPerMass other)) throw new ArgumentException("Object is not a LengthCubPerMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubPerMass l1, LengthCubPerMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubPerMass l1, LengthCubPerMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubPerMass l1, LengthCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubPerMass l1, LengthCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubPerMass l1, LengthCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubPerMass l1, LengthCubPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubPerMass FromCentimeterCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubPerMass(value * centimetercubperkilogram_.Factor, minValue * centimetercubperkilogram_.Factor, maxValue * centimetercubperkilogram_.Factor);
		public static LengthCubPerMass FromCentimeterCubPerKilograms(double value) => new LengthCubPerMass(value * centimetercubperkilogram_.Factor);
		public double GetValueInCentimeterCubPerKilograms() => Value_ / centimetercubperkilogram_.Factor;
		public static LengthCubPerMass FromMillimeterCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubPerMass(value * millimetercubperkilogram_.Factor, minValue * millimetercubperkilogram_.Factor, maxValue * millimetercubperkilogram_.Factor);
		public static LengthCubPerMass FromMillimeterCubPerKilograms(double value) => new LengthCubPerMass(value * millimetercubperkilogram_.Factor);
		public double GetValueInMillimeterCubPerKilograms() => Value_ / millimetercubperkilogram_.Factor;
		public static LengthCubPerMass FromMeterCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubPerMass(value * metercubperkilogram_.Factor, minValue * metercubperkilogram_.Factor, maxValue * metercubperkilogram_.Factor);
		public static LengthCubPerMass FromMeterCubPerKilograms(double value) => new LengthCubPerMass(value * metercubperkilogram_.Factor);
		public double GetValueInMeterCubPerKilograms() => Value_ / metercubperkilogram_.Factor;
		public static LengthCubPerMass FromInchCubPerKilograms(double value, double minValue, double maxValue) => new LengthCubPerMass(value * inchcubperkilogram_.Factor, minValue * inchcubperkilogram_.Factor, maxValue * inchcubperkilogram_.Factor);
		public static LengthCubPerMass FromInchCubPerKilograms(double value) => new LengthCubPerMass(value * inchcubperkilogram_.Factor);
		public double GetValueInInchCubPerKilograms() => Value_ / inchcubperkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubPerMass operator+(LengthCubPerMass o1, LengthCubPerMass o2) => new LengthCubPerMass(o1.Value_ + o2.Value_);
		public static LengthCubPerMass operator-(LengthCubPerMass o1, LengthCubPerMass o2) => new LengthCubPerMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubPerMass o1, LengthCubPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(LengthCubPerMass o1, LengthCubPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthCubPerTime o1, LengthCubPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(LengthCubPerMass o1, LengthCubTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(LengthCubTime o1, LengthCubPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(LengthCubPerMass o1, PerTimeSqrLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(PerTimeSqrLengthCub o1, LengthCubPerMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMass operator*(LengthCubPerMass o1, TimeSqrPerLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeSqrPerLengthCub o1, LengthCubPerMass o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(LengthCubPerMass o1, MassPerTimeLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(MassPerTimeLengthCub o1, LengthCubPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthCubPerMass o1, MassTimePerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(MassTimePerLengthCub o1, LengthCubPerMass o2) => new Time(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeCub operator*(LengthCubPerMass o1, PerLengthSqrTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(PerLengthSqrTimeCub o1, LengthCubPerMass o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthPerMass operator*(LengthCubPerMass o1, TimeCubPerLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(TimeCubPerLengthSqr o1, LengthCubPerMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(LengthCubPerMass o1, MassPerLengthSqrTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(MassPerLengthSqrTimeSqr o1, LengthCubPerMass o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(LengthCubPerMass o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeSqrMassPerLengthSqr o1, LengthCubPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(LengthCubPerMass o1, MassPerLengthTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(MassPerLengthTimeCub o1, LengthCubPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(LengthCubPerMass o1, TimeCubMassPerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(TimeCubMassPerLength o1, LengthCubPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator/(LengthCubPerMass o1, LengthPerMassTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(LengthPerMassTimeCub o1, LengthCubPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(LengthCubPerMass o1, TimeCubLengthPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeCubLengthPerMass o1, LengthCubPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(LengthCubPerMass o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(LengthSqrPerMassTimeSqr o1, LengthCubPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(LengthCubPerMass o1, LengthSqrTimeSqrPerMass o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(LengthSqrTimeSqrPerMass o1, LengthCubPerMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator/(LengthCubPerMass o1, LengthSqrPerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(LengthSqrPerTimeCub o1, LengthCubPerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator/(LengthCubPerMass o1, TimeCubLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeCubLengthSqr o1, LengthCubPerMass o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static Time operator/(LengthCubPerMass o1, LengthCubPerMassTime o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthCubPerMassTime o1, LengthCubPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(LengthCubPerMass o1, LengthCubTimePerMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubTimePerMass o1, LengthCubPerMass o2) => new Time(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(LengthCubPerMass o1, LengthCubPerTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(LengthCubPerTimeSqr o1, LengthCubPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator/(LengthCubPerMass o1, LengthCubTimeSqr o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(LengthCubTimeSqr o1, LengthCubPerMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator*(LengthCubPerMass o1, PerLengthCubTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(PerLengthCubTimeCub o1, LengthCubPerMass o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerMass operator*(LengthCubPerMass o1, TimeCubPerLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(TimeCubPerLengthCub o1, LengthCubPerMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(LengthCubPerMass o1, MassPerTimeSqrLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(MassPerTimeSqrLengthCub o1, LengthCubPerMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(LengthCubPerMass o1, TimeSqrMassPerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeSqrMassPerLengthCub o1, LengthCubPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(LengthCubPerMass o1, MassPerLengthSqrTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(MassPerLengthSqrTimeCub o1, LengthCubPerMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(LengthCubPerMass o1, TimeCubMassPerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeCubMassPerLengthSqr o1, LengthCubPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator/(LengthCubPerMass o1, LengthSqrPerMassTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(LengthSqrPerMassTimeCub o1, LengthCubPerMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(LengthCubPerMass o1, TimeCubLengthSqrPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeCubLengthSqrPerMass o1, LengthCubPerMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(LengthCubPerMass o1, LengthCubPerMassTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthCubPerMassTimeSqr o1, LengthCubPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthCubPerMass o1, LengthCubTimeSqrPerMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthCubTimeSqrPerMass o1, LengthCubPerMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator/(LengthCubPerMass o1, LengthCubPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(LengthCubPerTimeCub o1, LengthCubPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(LengthCubPerMass o1, LengthCubTimeCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(LengthCubTimeCub o1, LengthCubPerMass o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(LengthCubPerMass o1, MassPerLengthCubTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(MassPerLengthCubTimeCub o1, LengthCubPerMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(LengthCubPerMass o1, TimeCubMassPerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeCubMassPerLengthCub o1, LengthCubPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(LengthCubPerMass o1, LengthCubPerMassTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(LengthCubPerMassTimeCub o1, LengthCubPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthCubPerMass o1, LengthCubTimeCubPerMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(LengthCubTimeCubPerMass o1, LengthCubPerMass o2) => new TimeCub(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubPerMass lengthcubpermass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubpermass.HasMinValue && lengthcubpermass.Value_ < lengthcubpermass.MinValue)
        {
            fail = true;
        }

        if (lengthcubpermass.HasMaxValue && lengthcubpermass.Value_ > lengthcubpermass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubPerMass is outside its bounds.");
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
    