
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubPerTimeSqr : Quantity, IEquatable<LengthCubPerTimeSqr>, IComparable
    {
    internal LengthCubPerTimeSqr(double value) : base(value, 2)
    {
        LengthCubPerTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubPerTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubPerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubPerTimeSqr(LengthCubPerTimeSqr other) : base(other)
    {
        LengthCubPerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerTimeSqr"))
        {
            switch(FakeDatabase.Units["LengthCubPerTimeSqr"])
            {
				      case "centimetercubpersecondsqr": displayUnit_ = centimetercubpersecondsqr_; break;
				      case "millimetercubpersecondsqr": displayUnit_ = millimetercubpersecondsqr_; break;
				      case "metercubpersecondsqr": displayUnit_ = metercubpersecondsqr_; break;
				      case "inchcubpersecondsqr": displayUnit_ = inchcubpersecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubpersecondsqr_ = new Unit_("CentimeterCubPerSecondSqr", "cm³/s²", 1.0);
	private static Unit_ millimetercubpersecondsqr_ = new Unit_("MillimeterCubPerSecondSqr", "mm³/s²", 0.0010000000000000002);
	private static Unit_ metercubpersecondsqr_ = new Unit_("MeterCubPerSecondSqr", "m³/s²", 1000000.0);
	private static Unit_ inchcubpersecondsqr_ = new Unit_("InchCubPerSecondSqr", "in³/s²", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubpersecondsqr_;
	private static Unit_ displayUnit_ = centimetercubpersecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubPerTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubPerTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubPerTimeSqr other)) throw new ArgumentException("Object is not a LengthCubPerTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => !(l1 == l2);
    public static bool operator <(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubPerTimeSqr l1, LengthCubPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubPerTimeSqr FromCentimeterCubPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerTimeSqr(value * centimetercubpersecondsqr_.Factor, minValue * centimetercubpersecondsqr_.Factor, maxValue * centimetercubpersecondsqr_.Factor);
		public static LengthCubPerTimeSqr FromCentimeterCubPerSecondSqrs(double value) => new LengthCubPerTimeSqr(value * centimetercubpersecondsqr_.Factor);
		public double GetValueInCentimeterCubPerSecondSqrs() => Value_ / centimetercubpersecondsqr_.Factor;
		public static LengthCubPerTimeSqr FromMillimeterCubPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerTimeSqr(value * millimetercubpersecondsqr_.Factor, minValue * millimetercubpersecondsqr_.Factor, maxValue * millimetercubpersecondsqr_.Factor);
		public static LengthCubPerTimeSqr FromMillimeterCubPerSecondSqrs(double value) => new LengthCubPerTimeSqr(value * millimetercubpersecondsqr_.Factor);
		public double GetValueInMillimeterCubPerSecondSqrs() => Value_ / millimetercubpersecondsqr_.Factor;
		public static LengthCubPerTimeSqr FromMeterCubPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerTimeSqr(value * metercubpersecondsqr_.Factor, minValue * metercubpersecondsqr_.Factor, maxValue * metercubpersecondsqr_.Factor);
		public static LengthCubPerTimeSqr FromMeterCubPerSecondSqrs(double value) => new LengthCubPerTimeSqr(value * metercubpersecondsqr_.Factor);
		public double GetValueInMeterCubPerSecondSqrs() => Value_ / metercubpersecondsqr_.Factor;
		public static LengthCubPerTimeSqr FromInchCubPerSecondSqrs(double value, double minValue, double maxValue) => new LengthCubPerTimeSqr(value * inchcubpersecondsqr_.Factor, minValue * inchcubpersecondsqr_.Factor, maxValue * inchcubpersecondsqr_.Factor);
		public static LengthCubPerTimeSqr FromInchCubPerSecondSqrs(double value) => new LengthCubPerTimeSqr(value * inchcubpersecondsqr_.Factor);
		public double GetValueInInchCubPerSecondSqrs() => Value_ / inchcubpersecondsqr_.Factor;

#endregion

#region arithmetic
		public static LengthCubPerTimeSqr operator+(LengthCubPerTimeSqr o1, LengthCubPerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ + o2.Value_);
		public static LengthCubPerTimeSqr operator-(LengthCubPerTimeSqr o1, LengthCubPerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubPerTimeSqr o1, LengthCubPerTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(LengthCubPerTimeSqr o1, LengthCubMassPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(LengthCubMassPerTime o1, LengthCubPerTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(LengthCubPerTimeSqr o1, LengthCubMassTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(LengthCubMassTime o1, LengthCubPerTimeSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(LengthCubPerTimeSqr o1, TimeSqrPerMassLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeSqrPerMassLengthCub o1, LengthCubPerTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthCubPerTimeSqr o1, TimeCubPerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubPerLengthCub o1, LengthCubPerTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static Mass operator*(LengthCubPerTimeSqr o1, TimeSqrMassPerLengthCub o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeSqrMassPerLengthCub o1, LengthCubPerTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator*(LengthCubPerTimeSqr o1, TimeCubPerMassLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeCubPerMassLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator*(LengthCubPerTimeSqr o1, TimeCubMassPerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(TimeCubMassPerLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(LengthCubPerTimeSqr o1, LengthSqrPerMassTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(LengthSqrPerMassTimeCub o1, LengthCubPerTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(LengthCubPerTimeSqr o1, LengthSqrMassPerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(LengthSqrMassPerTimeCub o1, LengthCubPerTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static Mass operator/(LengthCubPerTimeSqr o1, LengthCubPerMassTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(LengthCubPerMassTimeSqr o1, LengthCubPerTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(LengthCubPerTimeSqr o1, LengthCubPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthCubPerTimeCub o1, LengthCubPerTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(LengthCubPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(LengthCubMassPerTimeSqr o1, LengthCubPerTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator*(LengthCubPerTimeSqr o1, TimeCubPerMassLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubPerMassLengthCub o1, LengthCubPerTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(LengthCubPerTimeSqr o1, TimeCubMassPerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(TimeCubMassPerLengthCub o1, LengthCubPerTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(LengthCubPerTimeSqr o1, LengthCubPerMassTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(LengthCubPerMassTimeCub o1, LengthCubPerTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(LengthCubPerTimeSqr o1, LengthCubMassPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthCubMassPerTimeCub o1, LengthCubPerTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubPerTimeSqr lengthcubpertimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubpertimesqr.HasMinValue && lengthcubpertimesqr.Value_ < lengthcubpertimesqr.MinValue)
        {
            fail = true;
        }

        if (lengthcubpertimesqr.HasMaxValue && lengthcubpertimesqr.Value_ > lengthcubpertimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubPerTimeSqr is outside its bounds.");
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
    