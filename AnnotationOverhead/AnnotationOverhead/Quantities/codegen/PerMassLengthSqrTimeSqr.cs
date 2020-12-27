
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassLengthSqrTimeSqr : Quantity, IEquatable<PerMassLengthSqrTimeSqr>, IComparable
    {
    internal PerMassLengthSqrTimeSqr(double value) : base(value, 2)
    {
        PerMassLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassLengthSqrTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassLengthSqrTimeSqr(PerMassLengthSqrTimeSqr other) : base(other)
    {
        PerMassLengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassLengthSqrTimeSqr"))
        {
            switch(FakeDatabase.Units["PerMassLengthSqrTimeSqr"])
            {
				      case "perkilogramcubcentimetersqrsecondsqr": displayUnit_ = perkilogramcubcentimetersqrsecondsqr_; break;
				      case "perkilogramcubmillimetersqrsecondsqr": displayUnit_ = perkilogramcubmillimetersqrsecondsqr_; break;
				      case "perkilogramcubmetersqrsecondsqr": displayUnit_ = perkilogramcubmetersqrsecondsqr_; break;
				      case "perkilogramcubinchsqrsecondsqr": displayUnit_ = perkilogramcubinchsqrsecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubcentimetersqrsecondsqr_ = new Unit_("PerKilogramCubCentimeterSqrSecondSqr", "/kg³ cm² s²", 1.0);
	private static Unit_ perkilogramcubmillimetersqrsecondsqr_ = new Unit_("PerKilogramCubMillimeterSqrSecondSqr", "/kg³ mm² s²", 99.99999999999999);
	private static Unit_ perkilogramcubmetersqrsecondsqr_ = new Unit_("PerKilogramCubMeterSqrSecondSqr", "/kg³ m² s²", 0.0001);
	private static Unit_ perkilogramcubinchsqrsecondsqr_ = new Unit_("PerKilogramCubInchSqrSecondSqr", "/kg³ in² s²", 0.152587890625);
	private static Unit_ platformUnit_ = perkilogramcubcentimetersqrsecondsqr_;
	private static Unit_ displayUnit_ = perkilogramcubcentimetersqrsecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassLengthSqrTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerMassLengthSqrTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassLengthSqrTimeSqr other)) throw new ArgumentException("Object is not a PerMassLengthSqrTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => !(l1 == l2);
    public static bool operator <(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassLengthSqrTimeSqr l1, PerMassLengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubCentimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeSqr(value * perkilogramcubcentimetersqrsecondsqr_.Factor, minValue * perkilogramcubcentimetersqrsecondsqr_.Factor, maxValue * perkilogramcubcentimetersqrsecondsqr_.Factor);
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubCentimeterSqrSecondSqrs(double value) => new PerMassLengthSqrTimeSqr(value * perkilogramcubcentimetersqrsecondsqr_.Factor);
		public double GetValueInPerKilogramCubCentimeterSqrSecondSqrs() => Value_ / perkilogramcubcentimetersqrsecondsqr_.Factor;
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubMillimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeSqr(value * perkilogramcubmillimetersqrsecondsqr_.Factor, minValue * perkilogramcubmillimetersqrsecondsqr_.Factor, maxValue * perkilogramcubmillimetersqrsecondsqr_.Factor);
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubMillimeterSqrSecondSqrs(double value) => new PerMassLengthSqrTimeSqr(value * perkilogramcubmillimetersqrsecondsqr_.Factor);
		public double GetValueInPerKilogramCubMillimeterSqrSecondSqrs() => Value_ / perkilogramcubmillimetersqrsecondsqr_.Factor;
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubMeterSqrSecondSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeSqr(value * perkilogramcubmetersqrsecondsqr_.Factor, minValue * perkilogramcubmetersqrsecondsqr_.Factor, maxValue * perkilogramcubmetersqrsecondsqr_.Factor);
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubMeterSqrSecondSqrs(double value) => new PerMassLengthSqrTimeSqr(value * perkilogramcubmetersqrsecondsqr_.Factor);
		public double GetValueInPerKilogramCubMeterSqrSecondSqrs() => Value_ / perkilogramcubmetersqrsecondsqr_.Factor;
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubInchSqrSecondSqrs(double value, double minValue, double maxValue) => new PerMassLengthSqrTimeSqr(value * perkilogramcubinchsqrsecondsqr_.Factor, minValue * perkilogramcubinchsqrsecondsqr_.Factor, maxValue * perkilogramcubinchsqrsecondsqr_.Factor);
		public static PerMassLengthSqrTimeSqr FromPerKilogramCubInchSqrSecondSqrs(double value) => new PerMassLengthSqrTimeSqr(value * perkilogramcubinchsqrsecondsqr_.Factor);
		public double GetValueInPerKilogramCubInchSqrSecondSqrs() => Value_ / perkilogramcubinchsqrsecondsqr_.Factor;

#endregion

#region arithmetic
		public static PerMassLengthSqrTimeSqr operator+(PerMassLengthSqrTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ + o2.Value_);
		public static PerMassLengthSqrTimeSqr operator-(PerMassLengthSqrTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new PerMassLengthSqrTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassLengthSqrTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerMassLengthSqrTimeSqr o1, PerLengthSqrTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerLengthSqrTimeCub o1, PerMassLengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerMassLengthSqrTimeSqr o1, PerLengthMassTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthMassTimeCub o1, PerMassLengthSqrTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(PerMassLengthSqrTimeSqr o1, TimeCubMassPerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeCubMassPerLength o1, PerMassLengthSqrTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerMassLengthSqrTimeSqr o1, LengthPerMassTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthPerMassTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(PerMassLengthSqrTimeSqr o1, TimeCubLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubLengthMass o1, PerMassLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerMassLengthSqrTimeSqr o1, TimeCubLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerMassLengthSqrTimeSqr o1, LengthSqrTimeSqrMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthSqrTimeSqrMass o1, PerMassLengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator*(PerMassLengthSqrTimeSqr o1, LengthCubTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthCubTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerMassLengthSqrTimeSqr o1, LengthCubMassPerTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthCubMassPerTime o1, PerMassLengthSqrTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerMassLengthSqrTimeSqr o1, LengthCubMassTime o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthCubMassTime o1, PerMassLengthSqrTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerMassLengthSqrTimeSqr o1, PerMassTimeSqrLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerMassTimeSqrLengthCub o1, PerMassLengthSqrTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(PerMassLengthSqrTimeSqr o1, PerLengthCubTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(PerLengthCubTimeCub o1, PerMassLengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerMassLengthSqrTimeSqr o1, PerMassLengthSqrTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerMassLengthSqrTimeCub o1, PerMassLengthSqrTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static Time operator*(PerMassLengthSqrTimeSqr o1, TimeCubLengthSqrMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubLengthSqrMass o1, PerMassLengthSqrTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator*(PerMassLengthSqrTimeSqr o1, LengthCubTimeCub o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthCubTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerMassLengthSqrTimeSqr o1, LengthCubTimeSqrMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubTimeSqrMass o1, PerMassLengthSqrTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(PerMassLengthSqrTimeSqr o1, PerMassLengthCubTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerMassLengthCubTimeCub o1, PerMassLengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(PerMassLengthSqrTimeSqr o1, LengthCubTimeCubMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubTimeCubMass o1, PerMassLengthSqrTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassLengthSqrTimeSqr permasslengthsqrtimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasslengthsqrtimesqr.HasMinValue && permasslengthsqrtimesqr.Value_ < permasslengthsqrtimesqr.MinValue)
        {
            fail = true;
        }

        if (permasslengthsqrtimesqr.HasMaxValue && permasslengthsqrtimesqr.Value_ > permasslengthsqrtimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassLengthSqrTimeSqr is outside its bounds.");
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
    