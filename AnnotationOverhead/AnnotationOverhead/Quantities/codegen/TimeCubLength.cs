
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeCubLength : Quantity, IEquatable<TimeCubLength>, IComparable
    {
    internal TimeCubLength(double value) : base(value, 2)
    {
        TimeCubLength.ImportDisplayUnitFromDatabase_();
    }
    internal TimeCubLength(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeCubLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeCubLength(TimeCubLength other) : base(other)
    {
        TimeCubLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeCubLength"))
        {
            switch(FakeDatabase.Units["TimeCubLength"])
            {
				      case "secondcubcentimeter": displayUnit_ = secondcubcentimeter_; break;
				      case "secondcubmillimeter": displayUnit_ = secondcubmillimeter_; break;
				      case "secondcubmeter": displayUnit_ = secondcubmeter_; break;
				      case "secondcubinch": displayUnit_ = secondcubinch_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondcubcentimeter_ = new Unit_("SecondCubCentimeter", "s³ cm", 1);
	private static Unit_ secondcubmillimeter_ = new Unit_("SecondCubMillimeter", "s³ mm", 0.1);
	private static Unit_ secondcubmeter_ = new Unit_("SecondCubMeter", "s³ m", 100);
	private static Unit_ secondcubinch_ = new Unit_("SecondCubInch", "s³ in", 2.56);
	private static Unit_ platformUnit_ = secondcubcentimeter_;
	private static Unit_ displayUnit_ = secondcubcentimeter_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeCubLength other) => other is object && Equals((object)other);
    public int CompareTo(TimeCubLength other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeCubLength other)) throw new ArgumentException("Object is not a TimeCubLength.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeCubLength l1, TimeCubLength l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeCubLength l1, TimeCubLength l2) => !(l1 == l2);
    public static bool operator <(TimeCubLength l1, TimeCubLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeCubLength l1, TimeCubLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeCubLength l1, TimeCubLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeCubLength l1, TimeCubLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeCubLength FromSecondCubCentimeters(double value, double minValue, double maxValue) => new TimeCubLength(value * secondcubcentimeter_.Factor, minValue * secondcubcentimeter_.Factor, maxValue * secondcubcentimeter_.Factor);
		public static TimeCubLength FromSecondCubCentimeters(double value) => new TimeCubLength(value * secondcubcentimeter_.Factor);
		public double GetValueInSecondCubCentimeters() => Value_ / secondcubcentimeter_.Factor;
		public static TimeCubLength FromSecondCubMillimeters(double value, double minValue, double maxValue) => new TimeCubLength(value * secondcubmillimeter_.Factor, minValue * secondcubmillimeter_.Factor, maxValue * secondcubmillimeter_.Factor);
		public static TimeCubLength FromSecondCubMillimeters(double value) => new TimeCubLength(value * secondcubmillimeter_.Factor);
		public double GetValueInSecondCubMillimeters() => Value_ / secondcubmillimeter_.Factor;
		public static TimeCubLength FromSecondCubMeters(double value, double minValue, double maxValue) => new TimeCubLength(value * secondcubmeter_.Factor, minValue * secondcubmeter_.Factor, maxValue * secondcubmeter_.Factor);
		public static TimeCubLength FromSecondCubMeters(double value) => new TimeCubLength(value * secondcubmeter_.Factor);
		public double GetValueInSecondCubMeters() => Value_ / secondcubmeter_.Factor;
		public static TimeCubLength FromSecondCubInchs(double value, double minValue, double maxValue) => new TimeCubLength(value * secondcubinch_.Factor, minValue * secondcubinch_.Factor, maxValue * secondcubinch_.Factor);
		public static TimeCubLength FromSecondCubInchs(double value) => new TimeCubLength(value * secondcubinch_.Factor);
		public double GetValueInSecondCubInchs() => Value_ / secondcubinch_.Factor;

#endregion

#region arithmetic
		public static TimeCubLength operator+(TimeCubLength o1, TimeCubLength o2) => new TimeCubLength(o1.Value_ + o2.Value_);
		public static TimeCubLength operator-(TimeCubLength o1, TimeCubLength o2) => new TimeCubLength(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeCubLength o1, TimeCubLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(TimeCubLength o1, Force o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(Force o1, TimeCubLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator/(TimeCubLength o1, TimeSqrLengthMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(TimeSqrLengthMass o1, TimeCubLength o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator*(TimeCubLength o1, LengthSqrPerMassTime o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator*(LengthSqrPerMassTime o1, TimeCubLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator/(TimeCubLength o1, LengthSqrTimePerMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(LengthSqrTimePerMass o1, TimeCubLength o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(TimeCubLength o1, QDose o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(QDose o1, TimeCubLength o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(TimeCubLength o1, LengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthSqrTimeSqr o1, TimeCubLength o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqrMass operator*(TimeCubLength o1, LengthSqrMassPerTime o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrMass operator*(LengthSqrMassPerTime o1, TimeCubLength o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(TimeCubLength o1, LengthSqrMassTime o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(LengthSqrMassTime o1, TimeCubLength o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator/(TimeCubLength o1, LengthCubPerMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(LengthCubPerMass o1, TimeCubLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(TimeCubLength o1, LengthCubTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthCubTime o1, TimeCubLength o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator/(TimeCubLength o1, LengthCubMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(LengthCubMass o1, TimeCubLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator*(TimeCubLength o1, PerMassTimeLengthCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthSqr operator*(PerMassTimeLengthCub o1, TimeCubLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator*(TimeCubLength o1, PerTimeSqrLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(PerTimeSqrLengthCub o1, TimeCubLength o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator*(TimeCubLength o1, MassPerTimeLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthSqr operator*(MassPerTimeLengthCub o1, TimeCubLength o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator*(TimeCubLength o1, PerMassLengthSqrTimeSqr o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(PerMassLengthSqrTimeSqr o1, TimeCubLength o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthCubMassTime operator/(TimeCubLength o1, TimeSqrPerMassLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(TimeSqrPerMassLengthSqr o1, TimeCubLength o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(TimeCubLength o1, PerLengthSqrTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(PerLengthSqrTimeCub o1, TimeCubLength o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static Volume operator/(TimeCubLength o1, TimeCubPerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(TimeCubPerLengthSqr o1, TimeCubLength o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(TimeCubLength o1, MassPerLengthSqrTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(MassPerLengthSqrTimeSqr o1, TimeCubLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static LengthCubTimePerMass operator/(TimeCubLength o1, TimeSqrMassPerLengthSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(TimeSqrMassPerLengthSqr o1, TimeCubLength o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(TimeCubLength o1, PerLengthMassTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerLengthMassTimeCub o1, TimeCubLength o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(TimeCubLength o1, TimeCubPerLengthMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimeCubPerLengthMass o1, TimeCubLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Mass operator*(TimeCubLength o1, MassPerLengthTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerLengthTimeCub o1, TimeCubLength o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator/(TimeCubLength o1, TimeCubMassPerLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(TimeCubMassPerLength o1, TimeCubLength o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(TimeCubLength o1, LengthPerMassTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthPerMassTimeCub o1, TimeCubLength o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static Mass operator/(TimeCubLength o1, TimeCubLengthPerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(TimeCubLengthPerMass o1, TimeCubLength o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(TimeCubLength o1, LengthMassPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthMassPerTimeCub o1, TimeCubLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(TimeCubLength o1, TimeCubLengthMass o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(TimeCubLengthMass o1, TimeCubLength o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(TimeCubLength o1, LengthSqrPerMassTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthSqrPerMassTimeSqr o1, TimeCubLength o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator/(TimeCubLength o1, LengthSqrTimeSqrPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthSqrTimeSqrPerMass o1, TimeCubLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(TimeCubLength o1, LengthSqrPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthSqrPerTimeCub o1, TimeCubLength o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(TimeCubLength o1, TimeCubLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(TimeCubLengthSqr o1, TimeCubLength o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(TimeCubLength o1, LengthSqrMassPerTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthSqrMassPerTimeSqr o1, TimeCubLength o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		
		public static TimePerLengthMass operator/(TimeCubLength o1, LengthSqrTimeSqrMass o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthSqrTimeSqrMass o1, TimeCubLength o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLengthSqr operator/(TimeCubLength o1, LengthCubTimePerMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeSqr operator/(LengthCubTimePerMass o1, TimeCubLength o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator/(TimeCubLength o1, LengthCubTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthCubTimeSqr o1, TimeCubLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthSqr operator/(TimeCubLength o1, LengthCubMassTime o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeSqr operator/(LengthCubMassTime o1, TimeCubLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator*(TimeCubLength o1, PerMassTimeSqrLengthCub o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator*(PerMassTimeSqrLengthCub o1, TimeCubLength o2) => new TimePerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator*(TimeCubLength o1, PerLengthCubTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(PerLengthCubTimeCub o1, TimeCubLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator*(TimeCubLength o1, MassPerTimeSqrLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(MassPerTimeSqrLengthCub o1, TimeCubLength o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator*(TimeCubLength o1, PerMassLengthSqrTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(PerMassLengthSqrTimeCub o1, TimeCubLength o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static LengthCubMass operator/(TimeCubLength o1, TimeCubPerMassLengthSqr o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(TimeCubPerMassLengthSqr o1, TimeCubLength o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(TimeCubLength o1, MassPerLengthSqrTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(MassPerLengthSqrTimeCub o1, TimeCubLength o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMass operator/(TimeCubLength o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(TimeCubMassPerLengthSqr o1, TimeCubLength o2) => new Density(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(TimeCubLength o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthSqrPerMassTimeCub o1, TimeCubLength o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(TimeCubLength o1, TimeCubLengthSqrPerMass o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(TimeCubLengthSqrPerMass o1, TimeCubLength o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(TimeCubLength o1, LengthSqrMassPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthSqrMassPerTimeCub o1, TimeCubLength o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(TimeCubLength o1, TimeCubLengthSqrMass o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(TimeCubLengthSqrMass o1, TimeCubLength o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator/(TimeCubLength o1, LengthCubTimeSqrPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthCubTimeSqrPerMass o1, TimeCubLength o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(TimeCubLength o1, LengthCubTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthCubTimeCub o1, TimeCubLength o2) => new Area(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthSqr operator/(TimeCubLength o1, LengthCubTimeSqrMass o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthCubTimeSqrMass o1, TimeCubLength o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(TimeCubLength o1, PerMassLengthCubTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(PerMassLengthCubTimeCub o1, TimeCubLength o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator*(TimeCubLength o1, MassPerLengthCubTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(MassPerLengthCubTimeCub o1, TimeCubLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(TimeCubLength o1, LengthCubTimeCubPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthCubTimeCubPerMass o1, TimeCubLength o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator/(TimeCubLength o1, LengthCubTimeCubMass o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthCubTimeCubMass o1, TimeCubLength o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeCubLength timecublength, bool throwOnFail=true)
    {
        bool fail = false;
        if (timecublength.HasMinValue && timecublength.Value_ < timecublength.MinValue)
        {
            fail = true;
        }

        if (timecublength.HasMaxValue && timecublength.Value_ > timecublength.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeCubLength is outside its bounds.");
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
    