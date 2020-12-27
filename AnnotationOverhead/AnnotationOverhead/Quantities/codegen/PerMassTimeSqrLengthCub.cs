
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassTimeSqrLengthCub : Quantity, IEquatable<PerMassTimeSqrLengthCub>, IComparable
    {
    internal PerMassTimeSqrLengthCub(double value) : base(value, 2)
    {
        PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassTimeSqrLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassTimeSqrLengthCub(PerMassTimeSqrLengthCub other) : base(other)
    {
        PerMassTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeSqrLengthCub"))
        {
            switch(FakeDatabase.Units["PerMassTimeSqrLengthCub"])
            {
				      case "perkilogramcubsecondsqrcentimetercub": displayUnit_ = perkilogramcubsecondsqrcentimetercub_; break;
				      case "perkilogramcubsecondsqrmillimetercub": displayUnit_ = perkilogramcubsecondsqrmillimetercub_; break;
				      case "perkilogramcubsecondsqrmetercub": displayUnit_ = perkilogramcubsecondsqrmetercub_; break;
				      case "perkilogramcubsecondsqrinchcub": displayUnit_ = perkilogramcubsecondsqrinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubsecondsqrcentimetercub_ = new Unit_("PerKilogramCubSecondSqrCentimeterCub", "/kg³ s² cm³", 1.0);
	private static Unit_ perkilogramcubsecondsqrmillimetercub_ = new Unit_("PerKilogramCubSecondSqrMillimeterCub", "/kg³ s² mm³", 999.9999999999998);
	private static Unit_ perkilogramcubsecondsqrmetercub_ = new Unit_("PerKilogramCubSecondSqrMeterCub", "/kg³ s² m³", 1e-06);
	private static Unit_ perkilogramcubsecondsqrinchcub_ = new Unit_("PerKilogramCubSecondSqrInchCub", "/kg³ s² in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = perkilogramcubsecondsqrcentimetercub_;
	private static Unit_ displayUnit_ = perkilogramcubsecondsqrcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassTimeSqrLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(PerMassTimeSqrLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassTimeSqrLengthCub other)) throw new ArgumentException("Object is not a PerMassTimeSqrLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => !(l1 == l2);
    public static bool operator <(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassTimeSqrLengthCub l1, PerMassTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrCentimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrcentimetercub_.Factor, minValue * perkilogramcubsecondsqrcentimetercub_.Factor, maxValue * perkilogramcubsecondsqrcentimetercub_.Factor);
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrCentimeterCubs(double value) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrcentimetercub_.Factor);
		public double GetValueInPerKilogramCubSecondSqrCentimeterCubs() => Value_ / perkilogramcubsecondsqrcentimetercub_.Factor;
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrMillimeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrmillimetercub_.Factor, minValue * perkilogramcubsecondsqrmillimetercub_.Factor, maxValue * perkilogramcubsecondsqrmillimetercub_.Factor);
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrMillimeterCubs(double value) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrmillimetercub_.Factor);
		public double GetValueInPerKilogramCubSecondSqrMillimeterCubs() => Value_ / perkilogramcubsecondsqrmillimetercub_.Factor;
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrMeterCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrmetercub_.Factor, minValue * perkilogramcubsecondsqrmetercub_.Factor, maxValue * perkilogramcubsecondsqrmetercub_.Factor);
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrMeterCubs(double value) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrmetercub_.Factor);
		public double GetValueInPerKilogramCubSecondSqrMeterCubs() => Value_ / perkilogramcubsecondsqrmetercub_.Factor;
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrInchCubs(double value, double minValue, double maxValue) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrinchcub_.Factor, minValue * perkilogramcubsecondsqrinchcub_.Factor, maxValue * perkilogramcubsecondsqrinchcub_.Factor);
		public static PerMassTimeSqrLengthCub FromPerKilogramCubSecondSqrInchCubs(double value) => new PerMassTimeSqrLengthCub(value * perkilogramcubsecondsqrinchcub_.Factor);
		public double GetValueInPerKilogramCubSecondSqrInchCubs() => Value_ / perkilogramcubsecondsqrinchcub_.Factor;

#endregion

#region arithmetic
		public static PerMassTimeSqrLengthCub operator+(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ + o2.Value_);
		public static PerMassTimeSqrLengthCub operator-(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerMassTimeSqrLengthCub o1, PerLengthCubTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerLengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerMassTimeSqrLengthCub o1, PerMassLengthSqrTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerMassLengthSqrTimeCub o1, PerMassTimeSqrLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerMassTimeSqrLengthCub o1, TimeCubLengthSqrMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubLengthSqrMass o1, PerMassTimeSqrLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimeSqrMass o1, PerMassTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static Time operator/(PerMassTimeSqrLengthCub o1, PerMassLengthCubTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerMassLengthCubTimeCub o1, PerMassTimeSqrLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerMassTimeSqrLengthCub o1, LengthCubTimeCubMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubTimeCubMass o1, PerMassTimeSqrLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassTimeSqrLengthCub permasstimesqrlengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasstimesqrlengthcub.HasMinValue && permasstimesqrlengthcub.Value_ < permasstimesqrlengthcub.MinValue)
        {
            fail = true;
        }

        if (permasstimesqrlengthcub.HasMaxValue && permasstimesqrlengthcub.Value_ > permasstimesqrlengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassTimeSqrLengthCub is outside its bounds.");
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
    