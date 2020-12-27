
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthMassPerTime : Quantity, IEquatable<LengthMassPerTime>, IComparable
    {
    internal LengthMassPerTime(double value) : base(value, 2)
    {
        LengthMassPerTime.ImportDisplayUnitFromDatabase_();
    }
    internal LengthMassPerTime(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthMassPerTime(LengthMassPerTime other) : base(other)
    {
        LengthMassPerTime.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthMassPerTime"))
        {
            switch(FakeDatabase.Units["LengthMassPerTime"])
            {
				      case "centimeterkilogrampersecond": displayUnit_ = centimeterkilogrampersecond_; break;
				      case "millimeterkilogrampersecond": displayUnit_ = millimeterkilogrampersecond_; break;
				      case "meterkilogrampersecond": displayUnit_ = meterkilogrampersecond_; break;
				      case "inchkilogrampersecond": displayUnit_ = inchkilogrampersecond_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimeterkilogrampersecond_ = new Unit_("CentimeterKilogramPerSecond", "cm kg/s", 1.0);
	private static Unit_ millimeterkilogrampersecond_ = new Unit_("MillimeterKilogramPerSecond", "mm kg/s", 0.1);
	private static Unit_ meterkilogrampersecond_ = new Unit_("MeterKilogramPerSecond", "m kg/s", 100.0);
	private static Unit_ inchkilogrampersecond_ = new Unit_("InchKilogramPerSecond", "in kg/s", 2.56);
	private static Unit_ platformUnit_ = centimeterkilogrampersecond_;
	private static Unit_ displayUnit_ = centimeterkilogrampersecond_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthMassPerTime other) => other is object && Equals((object)other);
    public int CompareTo(LengthMassPerTime other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthMassPerTime other)) throw new ArgumentException("Object is not a LengthMassPerTime.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthMassPerTime l1, LengthMassPerTime l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthMassPerTime l1, LengthMassPerTime l2) => !(l1 == l2);
    public static bool operator <(LengthMassPerTime l1, LengthMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthMassPerTime l1, LengthMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthMassPerTime l1, LengthMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthMassPerTime l1, LengthMassPerTime l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthMassPerTime FromCentimeterKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthMassPerTime(value * centimeterkilogrampersecond_.Factor, minValue * centimeterkilogrampersecond_.Factor, maxValue * centimeterkilogrampersecond_.Factor);
		public static LengthMassPerTime FromCentimeterKilogramPerSeconds(double value) => new LengthMassPerTime(value * centimeterkilogrampersecond_.Factor);
		public double GetValueInCentimeterKilogramPerSeconds() => Value_ / centimeterkilogrampersecond_.Factor;
		public static LengthMassPerTime FromMillimeterKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthMassPerTime(value * millimeterkilogrampersecond_.Factor, minValue * millimeterkilogrampersecond_.Factor, maxValue * millimeterkilogrampersecond_.Factor);
		public static LengthMassPerTime FromMillimeterKilogramPerSeconds(double value) => new LengthMassPerTime(value * millimeterkilogrampersecond_.Factor);
		public double GetValueInMillimeterKilogramPerSeconds() => Value_ / millimeterkilogrampersecond_.Factor;
		public static LengthMassPerTime FromMeterKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthMassPerTime(value * meterkilogrampersecond_.Factor, minValue * meterkilogrampersecond_.Factor, maxValue * meterkilogrampersecond_.Factor);
		public static LengthMassPerTime FromMeterKilogramPerSeconds(double value) => new LengthMassPerTime(value * meterkilogrampersecond_.Factor);
		public double GetValueInMeterKilogramPerSeconds() => Value_ / meterkilogrampersecond_.Factor;
		public static LengthMassPerTime FromInchKilogramPerSeconds(double value, double minValue, double maxValue) => new LengthMassPerTime(value * inchkilogrampersecond_.Factor, minValue * inchkilogrampersecond_.Factor, maxValue * inchkilogrampersecond_.Factor);
		public static LengthMassPerTime FromInchKilogramPerSeconds(double value) => new LengthMassPerTime(value * inchkilogrampersecond_.Factor);
		public double GetValueInInchKilogramPerSeconds() => Value_ / inchkilogrampersecond_.Factor;

#endregion

#region arithmetic
		public static LengthMassPerTime operator+(LengthMassPerTime o1, LengthMassPerTime o2) => new LengthMassPerTime(o1.Value_ + o2.Value_);
		public static LengthMassPerTime operator-(LengthMassPerTime o1, LengthMassPerTime o2) => new LengthMassPerTime(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthMassPerTime o1, LengthMassPerTime o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(LengthMassPerTime o1, LengthMassTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(LengthMassTime o1, LengthMassPerTime o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(LengthMassPerTime o1, LengthSqrPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthSqrPerMass o1, LengthMassPerTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(LengthMassPerTime o1, LengthSqrPerTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(LengthSqrPerTime o1, LengthMassPerTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLength operator/(LengthMassPerTime o1, LengthSqrPerTime o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthSqrPerTime o1, LengthMassPerTime o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(LengthMassPerTime o1, LengthSqrTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthSqrTime o1, LengthMassPerTime o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator/(LengthMassPerTime o1, LengthSqrTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(LengthSqrTime o1, LengthMassPerTime o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(LengthMassPerTime o1, LengthSqrMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthSqrMass o1, LengthMassPerTime o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator/(LengthMassPerTime o1, Volume o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(Volume o1, LengthMassPerTime o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(LengthMassPerTime o1, PerMassLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerMassLengthCub o1, LengthMassPerTime o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(LengthMassPerTime o1, PerTimeLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(PerTimeLengthCub o1, LengthMassPerTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator*(LengthMassPerTime o1, TimePerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimePerLengthCub o1, LengthMassPerTime o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator*(LengthMassPerTime o1, PerMassTimeLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerMassTimeLengthSqr o1, LengthMassPerTime o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(LengthMassPerTime o1, TimePerMassLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimePerMassLengthSqr o1, LengthMassPerTime o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(LengthMassPerTime o1, PerLengthSqrTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(PerLengthSqrTimeSqr o1, LengthMassPerTime o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator/(LengthMassPerTime o1, PerLengthSqrTimeSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthSqrTimeSqr o1, LengthMassPerTime o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(LengthMassPerTime o1, TimeSqrPerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeSqrPerLengthSqr o1, LengthMassPerTime o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthMassPerTime o1, TimeSqrPerLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimeSqrPerLengthSqr o1, LengthMassPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static Volume operator/(LengthMassPerTime o1, MassPerTimeLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(MassPerTimeLengthSqr o1, LengthMassPerTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(LengthMassPerTime o1, MassTimePerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(MassTimePerLengthSqr o1, LengthMassPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(LengthMassPerTime o1, PerLengthMassTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(PerLengthMassTimeSqr o1, LengthMassPerTime o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(LengthMassPerTime o1, TimeSqrPerLengthMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeSqrPerLengthMass o1, LengthMassPerTime o2) => new Time(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator/(LengthMassPerTime o1, PerLengthTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerLengthTimeCub o1, LengthMassPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMass operator*(LengthMassPerTime o1, TimeCubPerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(TimeCubPerLength o1, LengthMassPerTime o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(LengthMassPerTime o1, MassPerLengthTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassPerLengthTimeSqr o1, LengthMassPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(LengthMassPerTime o1, TimeSqrMassPerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(TimeSqrMassPerLength o1, LengthMassPerTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(LengthMassPerTime o1, TimeCubPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(TimeCubPerMass o1, LengthMassPerTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(LengthMassPerTime o1, MassPerTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(MassPerTimeCub o1, LengthMassPerTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(LengthMassPerTime o1, LengthPerMassTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthPerMassTimeSqr o1, LengthMassPerTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(LengthMassPerTime o1, TimeSqrLengthPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(TimeSqrLengthPerMass o1, LengthMassPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator/(LengthMassPerTime o1, LengthPerTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(LengthPerTimeCub o1, LengthMassPerTime o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(LengthMassPerTime o1, TimeCubLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(TimeCubLength o1, LengthMassPerTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static Time operator/(LengthMassPerTime o1, Force o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(Force o1, LengthMassPerTime o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(LengthMassPerTime o1, TimeSqrLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrLengthMass o1, LengthMassPerTime o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(LengthMassPerTime o1, LengthSqrPerMassTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthSqrPerMassTime o1, LengthMassPerTime o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Volume operator*(LengthMassPerTime o1, LengthSqrTimePerMass o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthSqrTimePerMass o1, LengthMassPerTime o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeCub operator*(LengthMassPerTime o1, QDose o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator*(QDose o1, LengthMassPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator/(LengthMassPerTime o1, QDose o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(QDose o1, LengthMassPerTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(LengthMassPerTime o1, LengthSqrTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthSqrTimeSqr o1, LengthMassPerTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator/(LengthMassPerTime o1, LengthSqrTimeSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(LengthSqrTimeSqr o1, LengthMassPerTime o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(LengthMassPerTime o1, LengthSqrMassPerTime o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthSqrMassPerTime o1, LengthMassPerTime o2) => new Length(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(LengthMassPerTime o1, LengthSqrMassTime o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(LengthSqrMassTime o1, LengthMassPerTime o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator/(LengthMassPerTime o1, LengthCubPerTime o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthCubPerTime o1, LengthMassPerTime o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator/(LengthMassPerTime o1, LengthCubTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(LengthCubTime o1, LengthMassPerTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator/(LengthMassPerTime o1, LengthCubMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthCubMass o1, LengthMassPerTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(LengthMassPerTime o1, PerMassTimeLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerMassTimeLengthCub o1, LengthMassPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator*(LengthMassPerTime o1, TimePerMassLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimePerMassLengthCub o1, LengthMassPerTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(LengthMassPerTime o1, PerTimeSqrLengthCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(PerTimeSqrLengthCub o1, LengthMassPerTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator*(LengthMassPerTime o1, TimeSqrPerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeSqrPerLengthCub o1, LengthMassPerTime o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(LengthMassPerTime o1, PerMassLengthSqrTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(PerMassLengthSqrTimeSqr o1, LengthMassPerTime o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(LengthMassPerTime o1, TimeSqrPerMassLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrPerMassLengthSqr o1, LengthMassPerTime o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqrMass operator/(LengthMassPerTime o1, PerLengthSqrTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqrLengthCub operator/(PerLengthSqrTimeCub o1, LengthMassPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator*(LengthMassPerTime o1, TimeCubPerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCubPerLengthSqr o1, LengthMassPerTime o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator/(LengthMassPerTime o1, MassPerLengthSqrTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(MassPerLengthSqrTimeSqr o1, LengthMassPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator/(LengthMassPerTime o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthCub operator/(TimeSqrMassPerLengthSqr o1, LengthMassPerTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(LengthMassPerTime o1, TimeCubPerLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubPerLengthMass o1, LengthMassPerTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator/(LengthMassPerTime o1, MassPerLengthTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(MassPerLengthTimeCub o1, LengthMassPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(LengthMassPerTime o1, TimeCubLengthPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(TimeCubLengthPerMass o1, LengthMassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(LengthMassPerTime o1, LengthMassPerTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(LengthMassPerTimeCub o1, LengthMassPerTime o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator*(LengthMassPerTime o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator*(LengthSqrPerMassTimeSqr o1, LengthMassPerTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator*(LengthMassPerTime o1, LengthSqrTimeSqrPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthSqrTimeSqrPerMass o1, LengthMassPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator/(LengthMassPerTime o1, LengthSqrPerTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthSqrPerTimeCub o1, LengthMassPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrMass operator*(LengthMassPerTime o1, TimeCubLengthSqr o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator*(TimeCubLengthSqr o1, LengthMassPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(LengthMassPerTime o1, LengthSqrMassPerTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthSqrMassPerTimeSqr o1, LengthMassPerTime o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(LengthMassPerTime o1, LengthSqrTimeSqrMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthSqrTimeSqrMass o1, LengthMassPerTime o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator/(LengthMassPerTime o1, LengthCubPerTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthCubPerTimeSqr o1, LengthMassPerTime o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator/(LengthMassPerTime o1, LengthCubTimeSqr o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(LengthCubTimeSqr o1, LengthMassPerTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(LengthMassPerTime o1, LengthCubMassPerTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthCubMassPerTime o1, LengthMassPerTime o2) => new Area(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(LengthMassPerTime o1, LengthCubMassTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(LengthCubMassTime o1, LengthMassPerTime o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(LengthMassPerTime o1, PerMassTimeSqrLengthCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerMassTimeSqrLengthCub o1, LengthMassPerTime o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator*(LengthMassPerTime o1, TimeSqrPerMassLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthMassPerTime o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(LengthMassPerTime o1, TimeCubPerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(TimeCubPerLengthCub o1, LengthMassPerTime o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(LengthMassPerTime o1, TimeCubPerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubPerMassLengthSqr o1, LengthMassPerTime o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqr operator/(LengthMassPerTime o1, MassPerLengthSqrTimeCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(MassPerLengthSqrTimeCub o1, LengthMassPerTime o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(LengthMassPerTime o1, TimeCubLengthSqrPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(TimeCubLengthSqrPerMass o1, LengthMassPerTime o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator/(LengthMassPerTime o1, LengthSqrMassPerTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(LengthSqrMassPerTimeCub o1, LengthMassPerTime o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator/(LengthMassPerTime o1, LengthCubPerTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthCubPerTimeCub o1, LengthMassPerTime o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator/(LengthMassPerTime o1, LengthCubMassPerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthCubMassPerTimeSqr o1, LengthMassPerTime o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(LengthMassPerTime o1, LengthCubTimeSqrMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(LengthCubTimeSqrMass o1, LengthMassPerTime o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(LengthMassPerTime o1, TimeCubPerMassLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubPerMassLengthCub o1, LengthMassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(LengthMassPerTime o1, LengthCubMassPerTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthCubMassPerTimeCub o1, LengthMassPerTime o2) => new QDose(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthMassPerTime lengthmasspertime, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthmasspertime.HasMinValue && lengthmasspertime.Value_ < lengthmasspertime.MinValue)
        {
            fail = true;
        }

        if (lengthmasspertime.HasMaxValue && lengthmasspertime.Value_ > lengthmasspertime.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthMassPerTime is outside its bounds.");
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
    