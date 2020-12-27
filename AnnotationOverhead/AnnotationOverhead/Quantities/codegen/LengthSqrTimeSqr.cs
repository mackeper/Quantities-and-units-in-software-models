
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthSqrTimeSqr : Quantity, IEquatable<LengthSqrTimeSqr>, IComparable
    {
    internal LengthSqrTimeSqr(double value) : base(value, 2)
    {
        LengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal LengthSqrTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthSqrTimeSqr(LengthSqrTimeSqr other) : base(other)
    {
        LengthSqrTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrTimeSqr"))
        {
            switch(FakeDatabase.Units["LengthSqrTimeSqr"])
            {
				      case "centimetersqrsecondsqr": displayUnit_ = centimetersqrsecondsqr_; break;
				      case "millimetersqrsecondsqr": displayUnit_ = millimetersqrsecondsqr_; break;
				      case "metersqrsecondsqr": displayUnit_ = metersqrsecondsqr_; break;
				      case "inchsqrsecondsqr": displayUnit_ = inchsqrsecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetersqrsecondsqr_ = new Unit_("CentimeterSqrSecondSqr", "cm² s²", 1);
	private static Unit_ millimetersqrsecondsqr_ = new Unit_("MillimeterSqrSecondSqr", "mm² s²", 0.010000000000000002);
	private static Unit_ metersqrsecondsqr_ = new Unit_("MeterSqrSecondSqr", "m² s²", 10000);
	private static Unit_ inchsqrsecondsqr_ = new Unit_("InchSqrSecondSqr", "in² s²", 6.5536);
	private static Unit_ platformUnit_ = centimetersqrsecondsqr_;
	private static Unit_ displayUnit_ = centimetersqrsecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthSqrTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(LengthSqrTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthSqrTimeSqr other)) throw new ArgumentException("Object is not a LengthSqrTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => !(l1 == l2);
    public static bool operator <(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthSqrTimeSqr l1, LengthSqrTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthSqrTimeSqr FromCentimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrTimeSqr(value * centimetersqrsecondsqr_.Factor, minValue * centimetersqrsecondsqr_.Factor, maxValue * centimetersqrsecondsqr_.Factor);
		public static LengthSqrTimeSqr FromCentimeterSqrSecondSqrs(double value) => new LengthSqrTimeSqr(value * centimetersqrsecondsqr_.Factor);
		public double GetValueInCentimeterSqrSecondSqrs() => Value_ / centimetersqrsecondsqr_.Factor;
		public static LengthSqrTimeSqr FromMillimeterSqrSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrTimeSqr(value * millimetersqrsecondsqr_.Factor, minValue * millimetersqrsecondsqr_.Factor, maxValue * millimetersqrsecondsqr_.Factor);
		public static LengthSqrTimeSqr FromMillimeterSqrSecondSqrs(double value) => new LengthSqrTimeSqr(value * millimetersqrsecondsqr_.Factor);
		public double GetValueInMillimeterSqrSecondSqrs() => Value_ / millimetersqrsecondsqr_.Factor;
		public static LengthSqrTimeSqr FromMeterSqrSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrTimeSqr(value * metersqrsecondsqr_.Factor, minValue * metersqrsecondsqr_.Factor, maxValue * metersqrsecondsqr_.Factor);
		public static LengthSqrTimeSqr FromMeterSqrSecondSqrs(double value) => new LengthSqrTimeSqr(value * metersqrsecondsqr_.Factor);
		public double GetValueInMeterSqrSecondSqrs() => Value_ / metersqrsecondsqr_.Factor;
		public static LengthSqrTimeSqr FromInchSqrSecondSqrs(double value, double minValue, double maxValue) => new LengthSqrTimeSqr(value * inchsqrsecondsqr_.Factor, minValue * inchsqrsecondsqr_.Factor, maxValue * inchsqrsecondsqr_.Factor);
		public static LengthSqrTimeSqr FromInchSqrSecondSqrs(double value) => new LengthSqrTimeSqr(value * inchsqrsecondsqr_.Factor);
		public double GetValueInInchSqrSecondSqrs() => Value_ / inchsqrsecondsqr_.Factor;

#endregion

#region arithmetic
		public static LengthSqrTimeSqr operator+(LengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ + o2.Value_);
		public static LengthSqrTimeSqr operator-(LengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator/(LengthSqrTimeSqr o1, LengthSqrMassPerTime o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(LengthSqrMassPerTime o1, LengthSqrTimeSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(LengthSqrTimeSqr o1, LengthSqrMassTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthSqrMassTime o1, LengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(LengthSqrTimeSqr o1, LengthCubPerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthCubPerMass o1, LengthSqrTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator/(LengthSqrTimeSqr o1, LengthCubPerTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(LengthCubPerTime o1, LengthSqrTimeSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(LengthSqrTimeSqr o1, LengthCubTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubTime o1, LengthSqrTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(LengthSqrTimeSqr o1, LengthCubMass o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthCubMass o1, LengthSqrTimeSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(LengthSqrTimeSqr o1, PerMassTimeLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(PerMassTimeLengthCub o1, LengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthMass operator*(LengthSqrTimeSqr o1, TimePerMassLengthCub o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthMass operator*(TimePerMassLengthCub o1, LengthSqrTimeSqr o2) => new TimeCubPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(LengthSqrTimeSqr o1, PerTimeSqrLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerTimeSqrLengthCub o1, LengthSqrTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(LengthSqrTimeSqr o1, MassPerTimeLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassPerTimeLengthCub o1, LengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeCubMassPerLength operator*(LengthSqrTimeSqr o1, MassTimePerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(MassTimePerLengthCub o1, LengthSqrTimeSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(LengthSqrTimeSqr o1, PerMassLengthSqrTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerMassLengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(LengthSqrTimeSqr o1, PerLengthSqrTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(PerLengthSqrTimeCub o1, LengthSqrTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Mass operator*(LengthSqrTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerLengthSqrTimeSqr o1, LengthSqrTimeSqr o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator*(LengthSqrTimeSqr o1, PerLengthMassTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(PerLengthMassTimeCub o1, LengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTime operator/(LengthSqrTimeSqr o1, TimeCubPerLengthMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(TimeCubPerLengthMass o1, LengthSqrTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(LengthSqrTimeSqr o1, MassPerLengthTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(MassPerLengthTimeCub o1, LengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTime operator/(LengthSqrTimeSqr o1, TimeCubMassPerLength o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(TimeCubMassPerLength o1, LengthSqrTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(LengthSqrTimeSqr o1, LengthPerMassTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthPerMassTimeCub o1, LengthSqrTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator/(LengthSqrTimeSqr o1, TimeCubLengthPerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeCubLengthPerMass o1, LengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(LengthSqrTimeSqr o1, LengthMassPerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthMassPerTimeCub o1, LengthSqrTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator/(LengthSqrTimeSqr o1, TimeCubLengthMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(TimeCubLengthMass o1, LengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static Mass operator/(LengthSqrTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(LengthSqrTimeSqrPerMass o1, LengthSqrTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(LengthSqrTimeSqr o1, TimeCubLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCubLengthSqr o1, LengthSqrTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(LengthSqrTimeSqr o1, LengthSqrTimeSqrMass o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(LengthSqrTimeSqrMass o1, LengthSqrTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator/(LengthSqrTimeSqr o1, LengthCubPerMassTime o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(LengthCubPerMassTime o1, LengthSqrTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator/(LengthSqrTimeSqr o1, LengthCubTimePerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthCubTimePerMass o1, LengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(LengthSqrTimeSqr o1, LengthCubTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubTimeSqr o1, LengthSqrTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthMass operator/(LengthSqrTimeSqr o1, LengthCubMassPerTime o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTimeCub operator/(LengthCubMassPerTime o1, LengthSqrTimeSqr o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(LengthSqrTimeSqr o1, LengthCubMassTime o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthCubMassTime o1, LengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(LengthSqrTimeSqr o1, PerMassTimeSqrLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerMassTimeSqrLengthCub o1, LengthSqrTimeSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator*(LengthSqrTimeSqr o1, PerLengthCubTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerLengthCubTimeCub o1, LengthSqrTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(LengthSqrTimeSqr o1, MassPerTimeSqrLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(MassPerTimeSqrLengthCub o1, LengthSqrTimeSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator*(LengthSqrTimeSqr o1, PerMassLengthSqrTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(PerMassLengthSqrTimeCub o1, LengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(LengthSqrTimeSqr o1, MassPerLengthSqrTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(MassPerLengthSqrTimeCub o1, LengthSqrTimeSqr o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator/(LengthSqrTimeSqr o1, TimeCubLengthSqrPerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMass operator/(TimeCubLengthSqrPerMass o1, LengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(LengthSqrTimeSqr o1, TimeCubLengthSqrMass o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimeCubLengthSqrMass o1, LengthSqrTimeSqr o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(LengthSqrTimeSqr o1, LengthCubTimeSqrPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthCubTimeSqrPerMass o1, LengthSqrTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(LengthSqrTimeSqr o1, LengthCubTimeCub o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthCubTimeCub o1, LengthSqrTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(LengthSqrTimeSqr o1, LengthCubTimeSqrMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthCubTimeSqrMass o1, LengthSqrTimeSqr o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(LengthSqrTimeSqr o1, PerMassLengthCubTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(PerMassLengthCubTimeCub o1, LengthSqrTimeSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator*(LengthSqrTimeSqr o1, MassPerLengthCubTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassPerLengthCubTimeCub o1, LengthSqrTimeSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator/(LengthSqrTimeSqr o1, LengthCubTimeCubPerMass o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(LengthCubTimeCubPerMass o1, LengthSqrTimeSqr o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator/(LengthSqrTimeSqr o1, LengthCubTimeCubMass o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(LengthCubTimeCubMass o1, LengthSqrTimeSqr o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthSqrTimeSqr lengthsqrtimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthsqrtimesqr.HasMinValue && lengthsqrtimesqr.Value_ < lengthsqrtimesqr.MinValue)
        {
            fail = true;
        }

        if (lengthsqrtimesqr.HasMaxValue && lengthsqrtimesqr.Value_ > lengthsqrtimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthSqrTimeSqr is outside its bounds.");
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
    