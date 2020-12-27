
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeSqrMassPerLength : Quantity, IEquatable<TimeSqrMassPerLength>, IComparable
    {
    internal TimeSqrMassPerLength(double value) : base(value, 2)
    {
        TimeSqrMassPerLength.ImportDisplayUnitFromDatabase_();
    }
    internal TimeSqrMassPerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeSqrMassPerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeSqrMassPerLength(TimeSqrMassPerLength other) : base(other)
    {
        TimeSqrMassPerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrMassPerLength"))
        {
            switch(FakeDatabase.Units["TimeSqrMassPerLength"])
            {
				      case "secondsqrkilogrampercentimeter": displayUnit_ = secondsqrkilogrampercentimeter_; break;
				      case "secondsqrkilogrampermillimeter": displayUnit_ = secondsqrkilogrampermillimeter_; break;
				      case "secondsqrkilogrampermeter": displayUnit_ = secondsqrkilogrampermeter_; break;
				      case "secondsqrkilogramperinch": displayUnit_ = secondsqrkilogramperinch_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondsqrkilogrampercentimeter_ = new Unit_("SecondSqrKilogramPerCentimeter", "s� kg/cm", 1.0);
	private static Unit_ secondsqrkilogrampermillimeter_ = new Unit_("SecondSqrKilogramPerMillimeter", "s� kg/mm", 10.0);
	private static Unit_ secondsqrkilogrampermeter_ = new Unit_("SecondSqrKilogramPerMeter", "s� kg/m", 0.01);
	private static Unit_ secondsqrkilogramperinch_ = new Unit_("SecondSqrKilogramPerInch", "s� kg/in", 0.390625);
	private static Unit_ platformUnit_ = secondsqrkilogrampercentimeter_;
	private static Unit_ displayUnit_ = secondsqrkilogrampercentimeter_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeSqrMassPerLength other) => other is object && Equals((object)other);
    public int CompareTo(TimeSqrMassPerLength other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeSqrMassPerLength other)) throw new ArgumentException("Object is not a TimeSqrMassPerLength.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => !(l1 == l2);
    public static bool operator <(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeSqrMassPerLength l1, TimeSqrMassPerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerCentimeters(double value, double minValue, double maxValue) => new TimeSqrMassPerLength(value * secondsqrkilogrampercentimeter_.Factor, minValue * secondsqrkilogrampercentimeter_.Factor, maxValue * secondsqrkilogrampercentimeter_.Factor);
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerCentimeters(double value) => new TimeSqrMassPerLength(value * secondsqrkilogrampercentimeter_.Factor);
		public double GetValueInSecondSqrKilogramPerCentimeters() => Value_ / secondsqrkilogrampercentimeter_.Factor;
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerMillimeters(double value, double minValue, double maxValue) => new TimeSqrMassPerLength(value * secondsqrkilogrampermillimeter_.Factor, minValue * secondsqrkilogrampermillimeter_.Factor, maxValue * secondsqrkilogrampermillimeter_.Factor);
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerMillimeters(double value) => new TimeSqrMassPerLength(value * secondsqrkilogrampermillimeter_.Factor);
		public double GetValueInSecondSqrKilogramPerMillimeters() => Value_ / secondsqrkilogrampermillimeter_.Factor;
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerMeters(double value, double minValue, double maxValue) => new TimeSqrMassPerLength(value * secondsqrkilogrampermeter_.Factor, minValue * secondsqrkilogrampermeter_.Factor, maxValue * secondsqrkilogrampermeter_.Factor);
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerMeters(double value) => new TimeSqrMassPerLength(value * secondsqrkilogrampermeter_.Factor);
		public double GetValueInSecondSqrKilogramPerMeters() => Value_ / secondsqrkilogrampermeter_.Factor;
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerInchs(double value, double minValue, double maxValue) => new TimeSqrMassPerLength(value * secondsqrkilogramperinch_.Factor, minValue * secondsqrkilogramperinch_.Factor, maxValue * secondsqrkilogramperinch_.Factor);
		public static TimeSqrMassPerLength FromSecondSqrKilogramPerInchs(double value) => new TimeSqrMassPerLength(value * secondsqrkilogramperinch_.Factor);
		public double GetValueInSecondSqrKilogramPerInchs() => Value_ / secondsqrkilogramperinch_.Factor;

#endregion

#region arithmetic
		public static TimeSqrMassPerLength operator+(TimeSqrMassPerLength o1, TimeSqrMassPerLength o2) => new TimeSqrMassPerLength(o1.Value_ + o2.Value_);
		public static TimeSqrMassPerLength operator-(TimeSqrMassPerLength o1, TimeSqrMassPerLength o2) => new TimeSqrMassPerLength(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeSqrMassPerLength o1, TimeSqrMassPerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimeSqrMassPerLength o1, PerMassTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerMassTimeCub o1, TimeSqrMassPerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(TimeSqrMassPerLength o1, TimeCubMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeCubMass o1, TimeSqrMassPerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeSqrMassPerLength o1, LengthPerMassTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthPerMassTimeSqr o1, TimeSqrMassPerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(TimeSqrMassPerLength o1, LengthPerTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthPerTimeCub o1, TimeSqrMassPerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthSqr operator/(TimeSqrMassPerLength o1, TimeCubLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(TimeCubLength o1, TimeSqrMassPerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(TimeSqrMassPerLength o1, TimeSqrLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(TimeSqrLengthMass o1, TimeSqrMassPerLength o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(TimeSqrMassPerLength o1, LengthSqrPerMassTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrPerMassTime o1, TimeSqrMassPerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(TimeSqrMassPerLength o1, LengthSqrTimePerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthSqrTimePerMass o1, TimeSqrMassPerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(TimeSqrMassPerLength o1, QDose o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(QDose o1, TimeSqrMassPerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static Density operator/(TimeSqrMassPerLength o1, LengthSqrTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrTimeSqr o1, TimeSqrMassPerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrMassPerTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthSqrMassPerTime o1, TimeSqrMassPerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrMassTime o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrMassTime o1, TimeSqrMassPerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(TimeSqrMassPerLength o1, LengthCubPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubPerMass o1, TimeSqrMassPerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator*(TimeSqrMassPerLength o1, LengthCubPerTime o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(LengthCubPerTime o1, TimeSqrMassPerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(TimeSqrMassPerLength o1, LengthCubTime o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthCubTime o1, TimeSqrMassPerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(TimeSqrMassPerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimeSqrPerLengthCub o1, TimeSqrMassPerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator/(TimeSqrMassPerLength o1, MassPerTimeLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrMassPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(TimeSqrMassPerLength o1, MassTimePerLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassTimePerLengthCub o1, TimeSqrMassPerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(TimeSqrMassPerLength o1, PerMassLengthSqrTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerMassLengthSqrTimeSqr o1, TimeSqrMassPerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator*(TimeSqrMassPerLength o1, PerLengthSqrTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(PerLengthSqrTimeCub o1, TimeSqrMassPerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(TimeSqrMassPerLength o1, TimeCubPerLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeCubPerLengthSqr o1, TimeSqrMassPerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static Length operator/(TimeSqrMassPerLength o1, TimeSqrMassPerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeSqrMassPerLengthSqr o1, TimeSqrMassPerLength o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthMassTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthMassTimeCub o1, TimeSqrMassPerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(TimeSqrMassPerLength o1, TimeCubMassPerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCubMassPerLength o1, TimeSqrMassPerLength o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimeSqrMassPerLength o1, LengthPerMassTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthPerMassTimeCub o1, TimeSqrMassPerLength o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(TimeSqrMassPerLength o1, TimeCubLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(TimeCubLengthMass o1, TimeSqrMassPerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimeSqrMassPerLength o1, LengthSqrPerMassTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrPerMassTimeSqr o1, TimeSqrMassPerLength o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(TimeSqrMassPerLength o1, LengthSqrPerTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthSqrPerTimeCub o1, TimeSqrMassPerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator/(TimeSqrMassPerLength o1, TimeCubLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(TimeCubLengthSqr o1, TimeSqrMassPerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrTimeSqrMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrTimeSqrMass o1, TimeSqrMassPerLength o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(TimeSqrMassPerLength o1, LengthCubPerMassTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubPerMassTime o1, TimeSqrMassPerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(TimeSqrMassPerLength o1, LengthCubTimePerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthCubTimePerMass o1, TimeSqrMassPerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(TimeSqrMassPerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubPerTimeSqr o1, TimeSqrMassPerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator/(TimeSqrMassPerLength o1, TimeCubPerLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeCubPerLengthCub o1, TimeSqrMassPerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(TimeSqrMassPerLength o1, TimeSqrMassPerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimeSqrMassPerLengthCub o1, TimeSqrMassPerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(TimeSqrMassPerLength o1, PerMassLengthSqrTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerMassLengthSqrTimeCub o1, TimeSqrMassPerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static Speed operator/(TimeSqrMassPerLength o1, TimeCubMassPerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeCubMassPerLengthSqr o1, TimeSqrMassPerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static Speed operator*(TimeSqrMassPerLength o1, LengthSqrPerMassTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrPerMassTimeCub o1, TimeSqrMassPerLength o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(TimeSqrMassPerLength o1, TimeCubLengthSqrMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(TimeCubLengthSqrMass o1, TimeSqrMassPerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(TimeSqrMassPerLength o1, LengthCubPerMassTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubPerMassTimeSqr o1, TimeSqrMassPerLength o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(TimeSqrMassPerLength o1, LengthCubPerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubPerTimeCub o1, TimeSqrMassPerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(TimeSqrMassPerLength o1, TimeCubMassPerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeCubMassPerLengthCub o1, TimeSqrMassPerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(TimeSqrMassPerLength o1, LengthCubPerMassTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubPerMassTimeCub o1, TimeSqrMassPerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeSqrMassPerLength timesqrmassperlength, bool throwOnFail=true)
    {
        bool fail = false;
        if (timesqrmassperlength.HasMinValue && timesqrmassperlength.Value_ < timesqrmassperlength.MinValue)
        {
            fail = true;
        }

        if (timesqrmassperlength.HasMaxValue && timesqrmassperlength.Value_ > timesqrmassperlength.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeSqrMassPerLength is outside its bounds.");
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
    