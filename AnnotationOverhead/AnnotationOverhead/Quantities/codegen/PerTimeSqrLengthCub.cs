
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerTimeSqrLengthCub : Quantity, IEquatable<PerTimeSqrLengthCub>, IComparable
    {
    internal PerTimeSqrLengthCub(double value) : base(value, 2)
    {
        PerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerTimeSqrLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerTimeSqrLengthCub(PerTimeSqrLengthCub other) : base(other)
    {
        PerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTimeSqrLengthCub"))
        {
            switch(FakeDatabase.Units["PerTimeSqrLengthCub"])
            {
				      case "persecondsqrcentimetercub": displayUnit_ = persecondsqrcentimetercub_; break;
				      case "persecondsqrmillimetercub": displayUnit_ = persecondsqrmillimetercub_; break;
				      case "persecondsqrmetercub": displayUnit_ = persecondsqrmetercub_; break;
				      case "persecondsqrinchcub": displayUnit_ = persecondsqrinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ persecondsqrcentimetercub_ = new Unit_("PerSecondSqrCentimeterCub", "/s² cm³", 1.0);
	private static Unit_ persecondsqrmillimetercub_ = new Unit_("PerSecondSqrMillimeterCub", "/s² mm³", 999.9999999999998);
	private static Unit_ persecondsqrmetercub_ = new Unit_("PerSecondSqrMeterCub", "/s² m³", 1e-06);
	private static Unit_ persecondsqrinchcub_ = new Unit_("PerSecondSqrInchCub", "/s² in³", 0.05960464477539062);
	private static Unit_ platformUnit_ = persecondsqrcentimetercub_;
	private static Unit_ displayUnit_ = persecondsqrcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerTimeSqrLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(PerTimeSqrLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerTimeSqrLengthCub other)) throw new ArgumentException("Object is not a PerTimeSqrLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => !(l1 == l2);
    public static bool operator <(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerTimeSqrLengthCub l1, PerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerTimeSqrLengthCub FromPerSecondSqrCentimeterCubs(double value, double minValue, double maxValue) => new PerTimeSqrLengthCub(value * persecondsqrcentimetercub_.Factor, minValue * persecondsqrcentimetercub_.Factor, maxValue * persecondsqrcentimetercub_.Factor);
		public static PerTimeSqrLengthCub FromPerSecondSqrCentimeterCubs(double value) => new PerTimeSqrLengthCub(value * persecondsqrcentimetercub_.Factor);
		public double GetValueInPerSecondSqrCentimeterCubs() => Value_ / persecondsqrcentimetercub_.Factor;
		public static PerTimeSqrLengthCub FromPerSecondSqrMillimeterCubs(double value, double minValue, double maxValue) => new PerTimeSqrLengthCub(value * persecondsqrmillimetercub_.Factor, minValue * persecondsqrmillimetercub_.Factor, maxValue * persecondsqrmillimetercub_.Factor);
		public static PerTimeSqrLengthCub FromPerSecondSqrMillimeterCubs(double value) => new PerTimeSqrLengthCub(value * persecondsqrmillimetercub_.Factor);
		public double GetValueInPerSecondSqrMillimeterCubs() => Value_ / persecondsqrmillimetercub_.Factor;
		public static PerTimeSqrLengthCub FromPerSecondSqrMeterCubs(double value, double minValue, double maxValue) => new PerTimeSqrLengthCub(value * persecondsqrmetercub_.Factor, minValue * persecondsqrmetercub_.Factor, maxValue * persecondsqrmetercub_.Factor);
		public static PerTimeSqrLengthCub FromPerSecondSqrMeterCubs(double value) => new PerTimeSqrLengthCub(value * persecondsqrmetercub_.Factor);
		public double GetValueInPerSecondSqrMeterCubs() => Value_ / persecondsqrmetercub_.Factor;
		public static PerTimeSqrLengthCub FromPerSecondSqrInchCubs(double value, double minValue, double maxValue) => new PerTimeSqrLengthCub(value * persecondsqrinchcub_.Factor, minValue * persecondsqrinchcub_.Factor, maxValue * persecondsqrinchcub_.Factor);
		public static PerTimeSqrLengthCub FromPerSecondSqrInchCubs(double value) => new PerTimeSqrLengthCub(value * persecondsqrinchcub_.Factor);
		public double GetValueInPerSecondSqrInchCubs() => Value_ / persecondsqrinchcub_.Factor;

#endregion

#region arithmetic
		public static PerTimeSqrLengthCub operator+(PerTimeSqrLengthCub o1, PerTimeSqrLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ + o2.Value_);
		public static PerTimeSqrLengthCub operator-(PerTimeSqrLengthCub o1, PerTimeSqrLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerTimeSqrLengthCub o1, PerTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerTimeSqrLengthCub o1, MassPerTimeLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerTimeLengthCub o1, PerTimeSqrLengthCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerTimeSqrLengthCub o1, MassTimePerLengthCub o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(MassTimePerLengthCub o1, PerTimeSqrLengthCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(PerTimeSqrLengthCub o1, PerMassLengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMassLengthSqrTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerTimeSqrLengthCub o1, PerLengthSqrTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthSqrTimeCub o1, PerTimeSqrLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(PerTimeSqrLengthCub o1, MassPerLengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerLengthSqrTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthMassTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(PerLengthMassTimeCub o1, PerTimeSqrLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator/(PerTimeSqrLengthCub o1, MassPerLengthTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(MassPerLengthTimeCub o1, PerTimeSqrLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(PerTimeSqrLengthCub o1, TimeCubLengthPerMass o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(TimeCubLengthPerMass o1, PerTimeSqrLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator*(PerTimeSqrLengthCub o1, TimeCubLengthMass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeCubLengthMass o1, PerTimeSqrLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator*(PerTimeSqrLengthCub o1, LengthSqrTimeSqrPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(LengthSqrTimeSqrPerMass o1, PerTimeSqrLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(PerTimeSqrLengthCub o1, TimeCubLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubLengthSqr o1, PerTimeSqrLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(PerTimeSqrLengthCub o1, LengthSqrTimeSqrMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(LengthSqrTimeSqrMass o1, PerTimeSqrLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerTimeSqrLengthCub o1, LengthCubPerMassTime o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(LengthCubPerMassTime o1, PerTimeSqrLengthCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator*(PerTimeSqrLengthCub o1, LengthCubTimePerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthCubTimePerMass o1, PerTimeSqrLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerTimeSqrLengthCub o1, LengthCubTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimeSqr o1, PerTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(PerTimeSqrLengthCub o1, LengthCubMassPerTime o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthCubMassPerTime o1, PerTimeSqrLengthCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(PerTimeSqrLengthCub o1, LengthCubMassTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthCubMassTime o1, PerTimeSqrLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static Mass operator/(PerTimeSqrLengthCub o1, PerMassTimeSqrLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassTimeSqrLengthCub o1, PerTimeSqrLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerTimeSqrLengthCub o1, PerLengthCubTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerLengthCubTimeCub o1, PerTimeSqrLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(PerTimeSqrLengthCub o1, MassPerTimeSqrLengthCub o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerTimeSqrLengthCub o1, PerTimeSqrLengthCub o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator/(PerTimeSqrLengthCub o1, PerMassLengthSqrTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(PerMassLengthSqrTimeCub o1, PerTimeSqrLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(PerTimeSqrLengthCub o1, MassPerLengthSqrTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(MassPerLengthSqrTimeCub o1, PerTimeSqrLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(PerTimeSqrLengthCub o1, TimeCubLengthSqrPerMass o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeCubLengthSqrPerMass o1, PerTimeSqrLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(PerTimeSqrLengthCub o1, TimeCubLengthSqrMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeCubLengthSqrMass o1, PerTimeSqrLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(PerTimeSqrLengthCub o1, LengthCubTimeSqrPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthCubTimeSqrPerMass o1, PerTimeSqrLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerTimeSqrLengthCub o1, LengthCubTimeCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubTimeCub o1, PerTimeSqrLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		
		public static Mass operator*(PerTimeSqrLengthCub o1, LengthCubTimeSqrMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthCubTimeSqrMass o1, PerTimeSqrLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(PerTimeSqrLengthCub o1, PerMassLengthCubTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(PerMassLengthCubTimeCub o1, PerTimeSqrLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerTimeSqrLengthCub o1, MassPerLengthCubTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(MassPerLengthCubTimeCub o1, PerTimeSqrLengthCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(PerTimeSqrLengthCub o1, LengthCubTimeCubPerMass o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthCubTimeCubPerMass o1, PerTimeSqrLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(PerTimeSqrLengthCub o1, LengthCubTimeCubMass o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthCubTimeCubMass o1, PerTimeSqrLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerTimeSqrLengthCub pertimesqrlengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (pertimesqrlengthcub.HasMinValue && pertimesqrlengthcub.Value_ < pertimesqrlengthcub.MinValue)
        {
            fail = true;
        }

        if (pertimesqrlengthcub.HasMaxValue && pertimesqrlengthcub.Value_ > pertimesqrlengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerTimeSqrLengthCub is outside its bounds.");
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
    