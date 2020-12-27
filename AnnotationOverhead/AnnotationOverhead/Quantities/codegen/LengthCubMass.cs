
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubMass : Quantity, IEquatable<LengthCubMass>, IComparable
    {
    internal LengthCubMass(double value) : base(value, 2)
    {
        LengthCubMass.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubMass(LengthCubMass other) : base(other)
    {
        LengthCubMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubMass"))
        {
            switch(FakeDatabase.Units["LengthCubMass"])
            {
				      case "centimetercubkilogram": displayUnit_ = centimetercubkilogram_; break;
				      case "millimetercubkilogram": displayUnit_ = millimetercubkilogram_; break;
				      case "metercubkilogram": displayUnit_ = metercubkilogram_; break;
				      case "inchcubkilogram": displayUnit_ = inchcubkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubkilogram_ = new Unit_("CentimeterCubKilogram", "cm³ kg", 1);
	private static Unit_ millimetercubkilogram_ = new Unit_("MillimeterCubKilogram", "mm³ kg", 0.0010000000000000002);
	private static Unit_ metercubkilogram_ = new Unit_("MeterCubKilogram", "m³ kg", 1000000);
	private static Unit_ inchcubkilogram_ = new Unit_("InchCubKilogram", "in³ kg", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubkilogram_;
	private static Unit_ displayUnit_ = centimetercubkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubMass other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubMass other)) throw new ArgumentException("Object is not a LengthCubMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubMass l1, LengthCubMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubMass l1, LengthCubMass l2) => !(l1 == l2);
    public static bool operator <(LengthCubMass l1, LengthCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubMass l1, LengthCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubMass l1, LengthCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubMass l1, LengthCubMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubMass FromCentimeterCubKilograms(double value, double minValue, double maxValue) => new LengthCubMass(value * centimetercubkilogram_.Factor, minValue * centimetercubkilogram_.Factor, maxValue * centimetercubkilogram_.Factor);
		public static LengthCubMass FromCentimeterCubKilograms(double value) => new LengthCubMass(value * centimetercubkilogram_.Factor);
		public double GetValueInCentimeterCubKilograms() => Value_ / centimetercubkilogram_.Factor;
		public static LengthCubMass FromMillimeterCubKilograms(double value, double minValue, double maxValue) => new LengthCubMass(value * millimetercubkilogram_.Factor, minValue * millimetercubkilogram_.Factor, maxValue * millimetercubkilogram_.Factor);
		public static LengthCubMass FromMillimeterCubKilograms(double value) => new LengthCubMass(value * millimetercubkilogram_.Factor);
		public double GetValueInMillimeterCubKilograms() => Value_ / millimetercubkilogram_.Factor;
		public static LengthCubMass FromMeterCubKilograms(double value, double minValue, double maxValue) => new LengthCubMass(value * metercubkilogram_.Factor, minValue * metercubkilogram_.Factor, maxValue * metercubkilogram_.Factor);
		public static LengthCubMass FromMeterCubKilograms(double value) => new LengthCubMass(value * metercubkilogram_.Factor);
		public double GetValueInMeterCubKilograms() => Value_ / metercubkilogram_.Factor;
		public static LengthCubMass FromInchCubKilograms(double value, double minValue, double maxValue) => new LengthCubMass(value * inchcubkilogram_.Factor, minValue * inchcubkilogram_.Factor, maxValue * inchcubkilogram_.Factor);
		public static LengthCubMass FromInchCubKilograms(double value) => new LengthCubMass(value * inchcubkilogram_.Factor);
		public double GetValueInInchCubKilograms() => Value_ / inchcubkilogram_.Factor;

#endregion

#region arithmetic
		public static LengthCubMass operator+(LengthCubMass o1, LengthCubMass o2) => new LengthCubMass(o1.Value_ + o2.Value_);
		public static LengthCubMass operator-(LengthCubMass o1, LengthCubMass o2) => new LengthCubMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubMass o1, LengthCubMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(LengthCubMass o1, PerMassTimeLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerMassTimeLengthCub o1, LengthCubMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthCubMass o1, TimePerMassLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimePerMassLengthCub o1, LengthCubMass o2) => new Time(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(LengthCubMass o1, PerTimeSqrLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(PerTimeSqrLengthCub o1, LengthCubMass o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(LengthCubMass o1, TimeSqrPerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeSqrPerLengthCub o1, LengthCubMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(LengthCubMass o1, PerMassLengthSqrTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(PerMassLengthSqrTimeSqr o1, LengthCubMass o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(LengthCubMass o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeSqrPerMassLengthSqr o1, LengthCubMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTimeCub operator*(LengthCubMass o1, PerLengthSqrTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTimeCub operator*(PerLengthSqrTimeCub o1, LengthCubMass o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthMass operator*(LengthCubMass o1, TimeCubPerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(TimeCubPerLengthSqr o1, LengthCubMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(LengthCubMass o1, PerLengthMassTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(PerLengthMassTimeCub o1, LengthCubMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(LengthCubMass o1, TimeCubPerLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(TimeCubPerLengthMass o1, LengthCubMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator/(LengthCubMass o1, LengthMassPerTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(LengthMassPerTimeCub o1, LengthCubMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(LengthCubMass o1, TimeCubLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeCubLengthMass o1, LengthCubMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator/(LengthCubMass o1, LengthSqrPerTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(LengthSqrPerTimeCub o1, LengthCubMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTimeCub operator/(LengthCubMass o1, TimeCubLengthSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthMass operator/(TimeCubLengthSqr o1, LengthCubMass o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(LengthCubMass o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(LengthSqrMassPerTimeSqr o1, LengthCubMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(LengthCubMass o1, LengthSqrTimeSqrMass o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(LengthSqrTimeSqrMass o1, LengthCubMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator/(LengthCubMass o1, LengthCubPerTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(LengthCubPerTimeSqr o1, LengthCubMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(LengthCubMass o1, LengthCubTimeSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(LengthCubTimeSqr o1, LengthCubMass o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(LengthCubMass o1, LengthCubMassPerTime o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthCubMassPerTime o1, LengthCubMass o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(LengthCubMass o1, LengthCubMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(LengthCubMassTime o1, LengthCubMass o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(LengthCubMass o1, PerMassTimeSqrLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(PerMassTimeSqrLengthCub o1, LengthCubMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(LengthCubMass o1, TimeSqrPerMassLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeSqrPerMassLengthCub o1, LengthCubMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(LengthCubMass o1, PerLengthCubTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(PerLengthCubTimeCub o1, LengthCubMass o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubMass operator*(LengthCubMass o1, TimeCubPerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeCubPerLengthCub o1, LengthCubMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(LengthCubMass o1, PerMassLengthSqrTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(PerMassLengthSqrTimeCub o1, LengthCubMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(LengthCubMass o1, TimeCubPerMassLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(TimeCubPerMassLengthSqr o1, LengthCubMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator/(LengthCubMass o1, LengthSqrMassPerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(LengthSqrMassPerTimeCub o1, LengthCubMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(LengthCubMass o1, TimeCubLengthSqrMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeCubLengthSqrMass o1, LengthCubMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator/(LengthCubMass o1, LengthCubPerTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(LengthCubPerTimeCub o1, LengthCubMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator/(LengthCubMass o1, LengthCubTimeCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(LengthCubTimeCub o1, LengthCubMass o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(LengthCubMass o1, LengthCubMassPerTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthCubMassPerTimeSqr o1, LengthCubMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthCubMass o1, LengthCubTimeSqrMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthCubTimeSqrMass o1, LengthCubMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(LengthCubMass o1, PerMassLengthCubTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(PerMassLengthCubTimeCub o1, LengthCubMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(LengthCubMass o1, TimeCubPerMassLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeCubPerMassLengthCub o1, LengthCubMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(LengthCubMass o1, LengthCubMassPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(LengthCubMassPerTimeCub o1, LengthCubMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthCubMass o1, LengthCubTimeCubMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(LengthCubTimeCubMass o1, LengthCubMass o2) => new TimeCub(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubMass lengthcubmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubmass.HasMinValue && lengthcubmass.Value_ < lengthcubmass.MinValue)
        {
            fail = true;
        }

        if (lengthcubmass.HasMaxValue && lengthcubmass.Value_ > lengthcubmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubMass is outside its bounds.");
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
    