
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerMassTimeLengthSqr : Quantity, IEquatable<PerMassTimeLengthSqr>, IComparable
    {
    internal PerMassTimeLengthSqr(double value) : base(value, 2)
    {
        PerMassTimeLengthSqr.ImportDisplayUnitFromDatabase_();
    }
    internal PerMassTimeLengthSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerMassTimeLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerMassTimeLengthSqr(PerMassTimeLengthSqr other) : base(other)
    {
        PerMassTimeLengthSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerMassTimeLengthSqr"))
        {
            switch(FakeDatabase.Units["PerMassTimeLengthSqr"])
            {
				      case "perkilogramcubsecondcentimetersqr": displayUnit_ = perkilogramcubsecondcentimetersqr_; break;
				      case "perkilogramcubsecondmillimetersqr": displayUnit_ = perkilogramcubsecondmillimetersqr_; break;
				      case "perkilogramcubsecondmetersqr": displayUnit_ = perkilogramcubsecondmetersqr_; break;
				      case "perkilogramcubsecondinchsqr": displayUnit_ = perkilogramcubsecondinchsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ perkilogramcubsecondcentimetersqr_ = new Unit_("PerKilogramCubSecondCentimeterSqr", "/kg³ s cm²", 1.0);
	private static Unit_ perkilogramcubsecondmillimetersqr_ = new Unit_("PerKilogramCubSecondMillimeterSqr", "/kg³ s mm²", 99.99999999999999);
	private static Unit_ perkilogramcubsecondmetersqr_ = new Unit_("PerKilogramCubSecondMeterSqr", "/kg³ s m²", 0.0001);
	private static Unit_ perkilogramcubsecondinchsqr_ = new Unit_("PerKilogramCubSecondInchSqr", "/kg³ s in²", 0.152587890625);
	private static Unit_ platformUnit_ = perkilogramcubsecondcentimetersqr_;
	private static Unit_ displayUnit_ = perkilogramcubsecondcentimetersqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerMassTimeLengthSqr other) => other is object && Equals((object)other);
    public int CompareTo(PerMassTimeLengthSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerMassTimeLengthSqr other)) throw new ArgumentException("Object is not a PerMassTimeLengthSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => !(l1 == l2);
    public static bool operator <(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerMassTimeLengthSqr l1, PerMassTimeLengthSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondCentimeterSqrs(double value, double minValue, double maxValue) => new PerMassTimeLengthSqr(value * perkilogramcubsecondcentimetersqr_.Factor, minValue * perkilogramcubsecondcentimetersqr_.Factor, maxValue * perkilogramcubsecondcentimetersqr_.Factor);
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondCentimeterSqrs(double value) => new PerMassTimeLengthSqr(value * perkilogramcubsecondcentimetersqr_.Factor);
		public double GetValueInPerKilogramCubSecondCentimeterSqrs() => Value_ / perkilogramcubsecondcentimetersqr_.Factor;
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondMillimeterSqrs(double value, double minValue, double maxValue) => new PerMassTimeLengthSqr(value * perkilogramcubsecondmillimetersqr_.Factor, minValue * perkilogramcubsecondmillimetersqr_.Factor, maxValue * perkilogramcubsecondmillimetersqr_.Factor);
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondMillimeterSqrs(double value) => new PerMassTimeLengthSqr(value * perkilogramcubsecondmillimetersqr_.Factor);
		public double GetValueInPerKilogramCubSecondMillimeterSqrs() => Value_ / perkilogramcubsecondmillimetersqr_.Factor;
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondMeterSqrs(double value, double minValue, double maxValue) => new PerMassTimeLengthSqr(value * perkilogramcubsecondmetersqr_.Factor, minValue * perkilogramcubsecondmetersqr_.Factor, maxValue * perkilogramcubsecondmetersqr_.Factor);
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondMeterSqrs(double value) => new PerMassTimeLengthSqr(value * perkilogramcubsecondmetersqr_.Factor);
		public double GetValueInPerKilogramCubSecondMeterSqrs() => Value_ / perkilogramcubsecondmetersqr_.Factor;
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondInchSqrs(double value, double minValue, double maxValue) => new PerMassTimeLengthSqr(value * perkilogramcubsecondinchsqr_.Factor, minValue * perkilogramcubsecondinchsqr_.Factor, maxValue * perkilogramcubsecondinchsqr_.Factor);
		public static PerMassTimeLengthSqr FromPerKilogramCubSecondInchSqrs(double value) => new PerMassTimeLengthSqr(value * perkilogramcubsecondinchsqr_.Factor);
		public double GetValueInPerKilogramCubSecondInchSqrs() => Value_ / perkilogramcubsecondinchsqr_.Factor;

#endregion

#region arithmetic
		public static PerMassTimeLengthSqr operator+(PerMassTimeLengthSqr o1, PerMassTimeLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ + o2.Value_);
		public static PerMassTimeLengthSqr operator-(PerMassTimeLengthSqr o1, PerMassTimeLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerMassTimeLengthSqr o1, PerMassTimeLengthSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(PerMassTimeLengthSqr o1, TimePerMassLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimePerMassLengthSqr o1, PerMassTimeLengthSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(PerMassTimeLengthSqr o1, PerLengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(PerLengthSqrTimeSqr o1, PerMassTimeLengthSqr o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerLengthSqr o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(TimeSqrPerLengthSqr o1, PerMassTimeLengthSqr o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(PerMassTimeLengthSqr o1, PerLengthMassTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(PerLengthMassTimeSqr o1, PerMassTimeLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrPerLengthMass o1, PerMassTimeLengthSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator/(PerMassTimeLengthSqr o1, PerLengthTimeCub o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		public static Force operator/(PerLengthTimeCub o1, PerMassTimeLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator*(PerMassTimeLengthSqr o1, TimeCubPerLength o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator*(TimeCubPerLength o1, PerMassTimeLengthSqr o2) => new TimeSqrPerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCubTimeCub operator*(PerMassTimeLengthSqr o1, MassPerLengthTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(MassPerLengthTimeSqr o1, PerMassTimeLengthSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator*(PerMassTimeLengthSqr o1, TimeSqrMassPerLength o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeSqrMassPerLength o1, PerMassTimeLengthSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(PerMassTimeLengthSqr o1, PerMassTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(PerMassTimeCub o1, PerMassTimeLengthSqr o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(PerMassTimeLengthSqr o1, TimeCubMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubMass o1, PerMassTimeLengthSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(PerMassTimeLengthSqr o1, LengthPerMassTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthPerMassTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrLengthPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeSqrLengthPerMass o1, PerMassTimeLengthSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMassLengthCub operator/(PerMassTimeLengthSqr o1, LengthPerTimeCub o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthPerTimeCub o1, PerMassTimeLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthMass operator*(PerMassTimeLengthSqr o1, TimeCubLength o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthMass operator*(TimeCubLength o1, PerMassTimeLengthSqr o2) => new TimeSqrPerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(PerMassTimeLengthSqr o1, Force o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(Force o1, PerMassTimeLengthSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(PerMassTimeLengthSqr o1, TimeSqrLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeSqrLengthMass o1, PerMassTimeLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTimeCub operator*(PerMassTimeLengthSqr o1, QDose o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		public static PerMassTimeCub operator*(QDose o1, PerMassTimeLengthSqr o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(PerMassTimeLengthSqr o1, LengthSqrTimeSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(LengthSqrTimeSqr o1, PerMassTimeLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(PerMassTimeLengthSqr o1, LengthSqrMassPerTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthSqrMassPerTime o1, PerMassTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerMassTimeLengthSqr o1, LengthSqrMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthSqrMassTime o1, PerMassTimeLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerMassTimeLengthSqr o1, LengthCubPerTime o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthCubPerTime o1, PerMassTimeLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator*(PerMassTimeLengthSqr o1, LengthCubTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthCubTime o1, PerMassTimeLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerMassTimeLengthSqr o1, LengthCubMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthCubMass o1, PerMassTimeLengthSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerMassTimeLengthSqr o1, PerMassTimeLengthCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerMassTimeLengthCub o1, PerMassTimeLengthSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(PerMassTimeLengthSqr o1, TimePerMassLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimePerMassLengthCub o1, PerMassTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator/(PerMassTimeLengthSqr o1, PerTimeSqrLengthCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(PerTimeSqrLengthCub o1, PerMassTimeLengthSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerLengthCub o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMassPerLength operator/(TimeSqrPerLengthCub o1, PerMassTimeLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		
		public static Time operator/(PerMassTimeLengthSqr o1, PerMassLengthSqrTimeSqr o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(PerMassLengthSqrTimeSqr o1, PerMassTimeLengthSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerMassLengthSqr o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrPerMassLengthSqr o1, PerMassTimeLengthSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerMass operator/(PerMassTimeLengthSqr o1, PerLengthSqrTimeCub o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeSqr operator/(PerLengthSqrTimeCub o1, PerMassTimeLengthSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(PerMassTimeLengthSqr o1, PerLengthMassTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(PerLengthMassTimeCub o1, PerMassTimeLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(PerMassTimeLengthSqr o1, TimeCubMassPerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimeCubMassPerLength o1, PerMassTimeLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(PerMassTimeLengthSqr o1, LengthPerMassTimeCub o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthPerMassTimeCub o1, PerMassTimeLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(PerMassTimeLengthSqr o1, TimeCubLengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubLengthMass o1, PerMassTimeLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerMass operator*(PerMassTimeLengthSqr o1, TimeCubLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMass operator*(TimeCubLengthSqr o1, PerMassTimeLengthSqr o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(PerMassTimeLengthSqr o1, LengthSqrMassPerTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthSqrMassPerTimeSqr o1, PerMassTimeLengthSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(PerMassTimeLengthSqr o1, LengthSqrTimeSqrMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthSqrTimeSqrMass o1, PerMassTimeLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeCub operator*(PerMassTimeLengthSqr o1, LengthCubPerTimeSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeCub operator*(LengthCubPerTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator*(PerMassTimeLengthSqr o1, LengthCubTimeSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(LengthCubTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static Acceleration operator*(PerMassTimeLengthSqr o1, LengthCubMassPerTime o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthCubMassPerTime o1, PerMassTimeLengthSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static Length operator*(PerMassTimeLengthSqr o1, LengthCubMassTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthCubMassTime o1, PerMassTimeLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(PerMassTimeLengthSqr o1, PerMassTimeSqrLengthCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(PerMassTimeSqrLengthCub o1, PerMassTimeLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerMassLengthCub o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLength operator/(TimeSqrPerMassLengthCub o1, PerMassTimeLengthSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator/(PerMassTimeLengthSqr o1, PerLengthCubTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeSqr operator/(PerLengthCubTimeCub o1, PerMassTimeLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(PerMassTimeLengthSqr o1, PerMassLengthSqrTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(PerMassLengthSqrTimeCub o1, PerMassTimeLengthSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(PerMassTimeLengthSqr o1, TimeCubLengthSqrMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(TimeCubLengthSqrMass o1, PerMassTimeLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(PerMassTimeLengthSqr o1, LengthCubTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthCubTimeCub o1, PerMassTimeLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		
		public static LengthPerTimeCub operator*(PerMassTimeLengthSqr o1, LengthCubMassPerTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthCubMassPerTimeSqr o1, PerMassTimeLengthSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthTime operator*(PerMassTimeLengthSqr o1, LengthCubTimeSqrMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthCubTimeSqrMass o1, PerMassTimeLengthSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator/(PerMassTimeLengthSqr o1, PerMassLengthCubTimeCub o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerMassLengthCubTimeCub o1, PerMassTimeLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator*(PerMassTimeLengthSqr o1, LengthCubTimeCubMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthCubTimeCubMass o1, PerMassTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerMassTimeLengthSqr permasstimelengthsqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (permasstimelengthsqr.HasMinValue && permasstimelengthsqr.Value_ < permasstimelengthsqr.MinValue)
        {
            fail = true;
        }

        if (permasstimelengthsqr.HasMaxValue && permasstimelengthsqr.Value_ > permasstimelengthsqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerMassTimeLengthSqr is outside its bounds.");
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
    