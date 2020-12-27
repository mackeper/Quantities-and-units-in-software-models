
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubLengthSqrMass : Quantity, IEquatable<TimeCubLengthSqrMass>, IComparable
    {
    internal TimeCubLengthSqrMass(double value) : base(value, 2)
    {
        TimeCubLengthSqrMass.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubLengthSqrMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubLengthSqrMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubLengthSqrMass(TimeCubLengthSqrMass other) : base(other)
    {
        TimeCubLengthSqrMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLengthSqrMass"))
        {
            switch(FakeDatabase.Units["TimeCubLengthSqrMass"])
            {
				      case "secondcubcentimetersqrkilogram": displayUnit_ = secondcubcentimetersqrkilogram_; break;
				      case "secondcubmillimetersqrkilogram": displayUnit_ = secondcubmillimetersqrkilogram_; break;
				      case "secondcubmetersqrkilogram": displayUnit_ = secondcubmetersqrkilogram_; break;
				      case "secondcubinchsqrkilogram": displayUnit_ = secondcubinchsqrkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubcentimetersqrkilogram_ = new Unit_("SecondCubCentimeterSqrKilogram", "s³ cm² kg", 1);
	private static Unit_ secondcubmillimetersqrkilogram_ = new Unit_("SecondCubMillimeterSqrKilogram", "s³ mm² kg", 0.010000000000000002);
	private static Unit_ secondcubmetersqrkilogram_ = new Unit_("SecondCubMeterSqrKilogram", "s³ m² kg", 10000);
	private static Unit_ secondcubinchsqrkilogram_ = new Unit_("SecondCubInchSqrKilogram", "s³ in² kg", 6.5536);
	private static Unit_ platformUnit_ = secondcubcentimetersqrkilogram_;
	private static Unit_ displayUnit_ = secondcubcentimetersqrkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubLengthSqrMass other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubLengthSqrMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubLengthSqrMass other)) throw new ArgumentException("Object is not a TimeCubLengthSqrMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => !(l1 == l2);
    public static bool operator <(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubLengthSqrMass l1, TimeCubLengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubLengthSqrMass FromSecondCubCentimeterSqrKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrMass(value * secondcubcentimetersqrkilogram_.Factor, minValue * secondcubcentimetersqrkilogram_.Factor, maxValue * secondcubcentimetersqrkilogram_.Factor);
		public static TimeCubLengthSqrMass FromSecondCubCentimeterSqrKilograms(double value) => new TimeCubLengthSqrMass(value * secondcubcentimetersqrkilogram_.Factor);
		public double GetValueInSecondCubCentimeterSqrKilograms() => Value_ / secondcubcentimetersqrkilogram_.Factor;
		public static TimeCubLengthSqrMass FromSecondCubMillimeterSqrKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrMass(value * secondcubmillimetersqrkilogram_.Factor, minValue * secondcubmillimetersqrkilogram_.Factor, maxValue * secondcubmillimetersqrkilogram_.Factor);
		public static TimeCubLengthSqrMass FromSecondCubMillimeterSqrKilograms(double value) => new TimeCubLengthSqrMass(value * secondcubmillimetersqrkilogram_.Factor);
		public double GetValueInSecondCubMillimeterSqrKilograms() => Value_ / secondcubmillimetersqrkilogram_.Factor;
		public static TimeCubLengthSqrMass FromSecondCubMeterSqrKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrMass(value * secondcubmetersqrkilogram_.Factor, minValue * secondcubmetersqrkilogram_.Factor, maxValue * secondcubmetersqrkilogram_.Factor);
		public static TimeCubLengthSqrMass FromSecondCubMeterSqrKilograms(double value) => new TimeCubLengthSqrMass(value * secondcubmetersqrkilogram_.Factor);
		public double GetValueInSecondCubMeterSqrKilograms() => Value_ / secondcubmetersqrkilogram_.Factor;
		public static TimeCubLengthSqrMass FromSecondCubInchSqrKilograms(double value, double minValue, double maxValue) => new TimeCubLengthSqrMass(value * secondcubinchsqrkilogram_.Factor, minValue * secondcubinchsqrkilogram_.Factor, maxValue * secondcubinchsqrkilogram_.Factor);
		public static TimeCubLengthSqrMass FromSecondCubInchSqrKilograms(double value) => new TimeCubLengthSqrMass(value * secondcubinchsqrkilogram_.Factor);
		public double GetValueInSecondCubInchSqrKilograms() => Value_ / secondcubinchsqrkilogram_.Factor;

#endregion

#region arithmetic
		public static TimeCubLengthSqrMass operator+(TimeCubLengthSqrMass o1, TimeCubLengthSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ + o2.Value_);
		public static TimeCubLengthSqrMass operator-(TimeCubLengthSqrMass o1, TimeCubLengthSqrMass o2) => new TimeCubLengthSqrMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubLengthSqrMass o1, TimeCubLengthSqrMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(TimeCubLengthSqrMass o1, LengthCubTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthCubTimeCub o1, TimeCubLengthSqrMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(TimeCubLengthSqrMass o1, LengthCubTimeSqrMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubTimeSqrMass o1, TimeCubLengthSqrMass o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(TimeCubLengthSqrMass o1, PerMassLengthCubTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerMassLengthCubTimeCub o1, TimeCubLengthSqrMass o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(TimeCubLengthSqrMass o1, LengthCubTimeCubMass o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubTimeCubMass o1, TimeCubLengthSqrMass o2) => new Length(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubLengthSqrMass timecublengthsqrmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecublengthsqrmass.HasMinValue && timecublengthsqrmass.Value_ < timecublengthsqrmass.MinValue)
        {
            fail = true;
        }

        if (timecublengthsqrmass.HasMaxValue && timecublengthsqrmass.Value_ > timecublengthsqrmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubLengthSqrMass is outside its bounds.");
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
    