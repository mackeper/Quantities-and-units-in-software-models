
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubPerLengthMass : Quantity, IEquatable<TimeCubPerLengthMass>, IComparable
    {
    internal TimeCubPerLengthMass(double value) : base(value, 2)
    {
        TimeCubPerLengthMass.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubPerLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubPerLengthMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubPerLengthMass(TimeCubPerLengthMass other) : base(other)
    {
        TimeCubPerLengthMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubPerLengthMass"))
        {
            switch(FakeDatabase.Units["TimeCubPerLengthMass"])
            {
				      case "secondcubpercentimeterkilogram": displayUnit_ = secondcubpercentimeterkilogram_; break;
				      case "secondcubpermillimeterkilogram": displayUnit_ = secondcubpermillimeterkilogram_; break;
				      case "secondcubpermeterkilogram": displayUnit_ = secondcubpermeterkilogram_; break;
				      case "secondcubperinchkilogram": displayUnit_ = secondcubperinchkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubpercentimeterkilogram_ = new Unit_("SecondCubPerCentimeterKilogram", "s³/cm kg", 1.0);
	private static Unit_ secondcubpermillimeterkilogram_ = new Unit_("SecondCubPerMillimeterKilogram", "s³/mm kg", 10.0);
	private static Unit_ secondcubpermeterkilogram_ = new Unit_("SecondCubPerMeterKilogram", "s³/m kg", 0.01);
	private static Unit_ secondcubperinchkilogram_ = new Unit_("SecondCubPerInchKilogram", "s³/in kg", 0.390625);
	private static Unit_ platformUnit_ = secondcubpercentimeterkilogram_;
	private static Unit_ displayUnit_ = secondcubpercentimeterkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubPerLengthMass other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubPerLengthMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubPerLengthMass other)) throw new ArgumentException("Object is not a TimeCubPerLengthMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => !(l1 == l2);
    public static bool operator <(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubPerLengthMass l1, TimeCubPerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubPerLengthMass FromSecondCubPerCentimeterKilograms(double value, double minValue, double maxValue) => new TimeCubPerLengthMass(value * secondcubpercentimeterkilogram_.Factor, minValue * secondcubpercentimeterkilogram_.Factor, maxValue * secondcubpercentimeterkilogram_.Factor);
		public static TimeCubPerLengthMass FromSecondCubPerCentimeterKilograms(double value) => new TimeCubPerLengthMass(value * secondcubpercentimeterkilogram_.Factor);
		public double GetValueInSecondCubPerCentimeterKilograms() => Value_ / secondcubpercentimeterkilogram_.Factor;
		public static TimeCubPerLengthMass FromSecondCubPerMillimeterKilograms(double value, double minValue, double maxValue) => new TimeCubPerLengthMass(value * secondcubpermillimeterkilogram_.Factor, minValue * secondcubpermillimeterkilogram_.Factor, maxValue * secondcubpermillimeterkilogram_.Factor);
		public static TimeCubPerLengthMass FromSecondCubPerMillimeterKilograms(double value) => new TimeCubPerLengthMass(value * secondcubpermillimeterkilogram_.Factor);
		public double GetValueInSecondCubPerMillimeterKilograms() => Value_ / secondcubpermillimeterkilogram_.Factor;
		public static TimeCubPerLengthMass FromSecondCubPerMeterKilograms(double value, double minValue, double maxValue) => new TimeCubPerLengthMass(value * secondcubpermeterkilogram_.Factor, minValue * secondcubpermeterkilogram_.Factor, maxValue * secondcubpermeterkilogram_.Factor);
		public static TimeCubPerLengthMass FromSecondCubPerMeterKilograms(double value) => new TimeCubPerLengthMass(value * secondcubpermeterkilogram_.Factor);
		public double GetValueInSecondCubPerMeterKilograms() => Value_ / secondcubpermeterkilogram_.Factor;
		public static TimeCubPerLengthMass FromSecondCubPerInchKilograms(double value, double minValue, double maxValue) => new TimeCubPerLengthMass(value * secondcubperinchkilogram_.Factor, minValue * secondcubperinchkilogram_.Factor, maxValue * secondcubperinchkilogram_.Factor);
		public static TimeCubPerLengthMass FromSecondCubPerInchKilograms(double value) => new TimeCubPerLengthMass(value * secondcubperinchkilogram_.Factor);
		public double GetValueInSecondCubPerInchKilograms() => Value_ / secondcubperinchkilogram_.Factor;

#endregion

#region arithmetic
		public static TimeCubPerLengthMass operator+(TimeCubPerLengthMass o1, TimeCubPerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ + o2.Value_);
		public static TimeCubPerLengthMass operator-(TimeCubPerLengthMass o1, TimeCubPerLengthMass o2) => new TimeCubPerLengthMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubPerLengthMass o1, TimeCubPerLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(TimeCubPerLengthMass o1, MassPerLengthTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(MassPerLengthTimeCub o1, TimeCubPerLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(TimeCubPerLengthMass o1, TimeCubLengthPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(TimeCubLengthPerMass o1, TimeCubPerLengthMass o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeCubPerLengthMass o1, LengthMassPerTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthMassPerTimeCub o1, TimeCubPerLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(TimeCubPerLengthMass o1, LengthSqrTimeSqrPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubPerLengthMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(TimeCubPerLengthMass o1, LengthSqrPerTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthSqrPerTimeCub o1, TimeCubPerLengthMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(TimeCubPerLengthMass o1, TimeCubLengthSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(TimeCubLengthSqr o1, TimeCubPerLengthMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(TimeCubPerLengthMass o1, LengthSqrMassPerTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubPerLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimePerMass operator*(TimeCubPerLengthMass o1, LengthCubPerTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthCubPerTimeSqr o1, TimeCubPerLengthMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(TimeCubPerLengthMass o1, LengthCubMassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubMassPerTime o1, TimeCubPerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(TimeCubPerLengthMass o1, TimeSqrPerMassLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimeCubPerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(TimeCubPerLengthMass o1, TimeCubPerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(TimeCubPerLengthCub o1, TimeCubPerLengthMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(TimeCubPerLengthMass o1, TimeCubPerMassLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeCubPerMassLengthSqr o1, TimeCubPerLengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(TimeCubPerLengthMass o1, MassPerLengthSqrTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(MassPerLengthSqrTimeCub o1, TimeCubPerLengthMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(TimeCubPerLengthMass o1, TimeCubLengthSqrPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(TimeCubLengthSqrPerMass o1, TimeCubPerLengthMass o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimeCubPerLengthMass o1, LengthSqrMassPerTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrMassPerTimeCub o1, TimeCubPerLengthMass o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator*(TimeCubPerLengthMass o1, LengthCubPerTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubPerTimeCub o1, TimeCubPerLengthMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(TimeCubPerLengthMass o1, LengthCubMassPerTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubMassPerTimeSqr o1, TimeCubPerLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static Area operator/(TimeCubPerLengthMass o1, TimeCubPerMassLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimeCubPerMassLengthCub o1, TimeCubPerLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator*(TimeCubPerLengthMass o1, LengthCubMassPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubMassPerTimeCub o1, TimeCubPerLengthMass o2) => new Area(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubPerLengthMass timecubperlengthmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecubperlengthmass.HasMinValue && timecubperlengthmass.Value_ < timecubperlengthmass.MinValue)
        {
            fail = true;
        }

        if (timecubperlengthmass.HasMaxValue && timecubperlengthmass.Value_ > timecubperlengthmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubPerLengthMass is outside its bounds.");
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
    