
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerTimeSqr : Quantity, IEquatable<MassPerTimeSqr>, IComparable
    {
    internal MassPerTimeSqr(double value) : base(value, 2)
    {
        MassPerTimeSqr.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerTimeSqr(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerTimeSqr(MassPerTimeSqr other) : base(other)
    {
        MassPerTimeSqr.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerTimeSqr"))
        {
            switch(FakeDatabase.Units["MassPerTimeSqr"])
            {
				      case "kilogrampersecondsqr": displayUnit_ = kilogrampersecondsqr_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampersecondsqr_ = new Unit_("KilogramPerSecondSqr", "kg/s²", 1.0);
	private static Unit_ platformUnit_ = kilogrampersecondsqr_;
	private static Unit_ displayUnit_ = kilogrampersecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerTimeSqr other) => other is object && Equals((object)other);
    public int CompareTo(MassPerTimeSqr other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerTimeSqr other)) throw new ArgumentException("Object is not a MassPerTimeSqr.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerTimeSqr l1, MassPerTimeSqr l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerTimeSqr l1, MassPerTimeSqr l2) => !(l1 == l2);
    public static bool operator <(MassPerTimeSqr l1, MassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerTimeSqr l1, MassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerTimeSqr l1, MassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerTimeSqr l1, MassPerTimeSqr l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerTimeSqr FromKilogramPerSecondSqrs(double value, double minValue, double maxValue) => new MassPerTimeSqr(value * kilogrampersecondsqr_.Factor, minValue * kilogrampersecondsqr_.Factor, maxValue * kilogrampersecondsqr_.Factor);
		public static MassPerTimeSqr FromKilogramPerSecondSqrs(double value) => new MassPerTimeSqr(value * kilogrampersecondsqr_.Factor);
		public double GetValueInKilogramPerSecondSqrs() => Value_ / kilogrampersecondsqr_.Factor;

#endregion

#region arithmetic
		public static MassPerTimeSqr operator+(MassPerTimeSqr o1, MassPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ + o2.Value_);
		public static MassPerTimeSqr operator-(MassPerTimeSqr o1, MassPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerTimeSqr o1, MassPerTimeSqr o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static LengthPerTimeCub operator*(MassPerTimeSqr o1, LengthPerMassTime o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthPerTimeCub operator*(LengthPerMassTime o1, MassPerTimeSqr o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
		
		public static Speed operator*(MassPerTimeSqr o1, LengthTimePerMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthTimePerMass o1, MassPerTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(MassPerTimeSqr o1, Acceleration o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(Acceleration o1, MassPerTimeSqr o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(MassPerTimeSqr o1, TimeSqrLength o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(TimeSqrLength o1, MassPerTimeSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(MassPerTimeSqr o1, LengthMassPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthMassPerTime o1, MassPerTimeSqr o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(MassPerTimeSqr o1, LengthMassTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthMassTime o1, MassPerTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassPerTimeSqr o1, LengthSqrPerMass o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthSqrPerMass o1, MassPerTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(MassPerTimeSqr o1, LengthSqrPerTime o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthSqrPerTime o1, MassPerTimeSqr o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassPerTimeSqr o1, LengthSqrPerTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthSqrPerTime o1, MassPerTimeSqr o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassPerTimeSqr o1, LengthSqrTime o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthSqrTime o1, MassPerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(MassPerTimeSqr o1, LengthSqrTime o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(LengthSqrTime o1, MassPerTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(MassPerTimeSqr o1, LengthSqrMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(LengthSqrMass o1, MassPerTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTimeSqr operator*(MassPerTimeSqr o1, Volume o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeSqr operator*(Volume o1, MassPerTimeSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator/(MassPerTimeSqr o1, Volume o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(Volume o1, MassPerTimeSqr o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(MassPerTimeSqr o1, PerMassLengthCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerMassLengthCub o1, MassPerTimeSqr o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthCubTimeCub operator*(MassPerTimeSqr o1, PerTimeLengthCub o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator*(PerTimeLengthCub o1, MassPerTimeSqr o2) => new MassPerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator/(MassPerTimeSqr o1, PerTimeLengthCub o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthCub operator/(PerTimeLengthCub o1, MassPerTimeSqr o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(MassPerTimeSqr o1, TimePerLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(TimePerLengthCub o1, MassPerTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator/(MassPerTimeSqr o1, TimePerLengthCub o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimePerLengthCub o1, MassPerTimeSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator/(MassPerTimeSqr o1, Density o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthCub operator/(Density o1, MassPerTimeSqr o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(MassPerTimeSqr o1, PerMassTimeLengthSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(PerMassTimeLengthSqr o1, MassPerTimeSqr o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator*(MassPerTimeSqr o1, TimePerMassLengthSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(TimePerMassLengthSqr o1, MassPerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(MassPerTimeSqr o1, PerLengthSqrTimeSqr o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerLengthSqrTimeSqr o1, MassPerTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(MassPerTimeSqr o1, TimeSqrPerLengthSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimeSqrPerLengthSqr o1, MassPerTimeSqr o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(MassPerTimeSqr o1, MassPerTimeLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(MassPerTimeLengthSqr o1, MassPerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator/(MassPerTimeSqr o1, MassTimePerLengthSqr o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthSqr operator/(MassTimePerLengthSqr o1, MassPerTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(MassPerTimeSqr o1, TimeSqrPerLengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimeSqrPerLengthMass o1, MassPerTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(MassPerTimeSqr o1, PerLengthTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(PerLengthTimeCub o1, MassPerTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static MassTimePerLength operator*(MassPerTimeSqr o1, TimeCubPerLength o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeCubPerLength o1, MassPerTimeSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static Length operator/(MassPerTimeSqr o1, MassPerLengthTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassPerLengthTimeSqr o1, MassPerTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Time operator*(MassPerTimeSqr o1, TimeCubPerMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubPerMass o1, MassPerTimeSqr o2) => new Time(o1.Value_ * o2.Value_);
		
		public static Time operator/(MassPerTimeSqr o1, MassPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(MassPerTimeCub o1, MassPerTimeSqr o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(MassPerTimeSqr o1, TimeSqrLengthPerMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeSqrLengthPerMass o1, MassPerTimeSqr o2) => new Length(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator/(MassPerTimeSqr o1, LengthPerTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthPerTimeCub o1, MassPerTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(MassPerTimeSqr o1, TimeCubLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(TimeCubLength o1, MassPerTimeSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(MassPerTimeSqr o1, Force o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(Force o1, MassPerTimeSqr o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTimeCub operator*(MassPerTimeSqr o1, LengthSqrPerMassTime o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerTimeCub operator*(LengthSqrPerMassTime o1, MassPerTimeSqr o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(MassPerTimeSqr o1, LengthSqrTimePerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrTimePerMass o1, MassPerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(MassPerTimeSqr o1, QDose o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(QDose o1, MassPerTimeSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator*(MassPerTimeSqr o1, LengthSqrTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthSqrTimeSqr o1, MassPerTimeSqr o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(MassPerTimeSqr o1, LengthSqrMassPerTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(LengthSqrMassPerTime o1, MassPerTimeSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(MassPerTimeSqr o1, LengthSqrMassTime o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(LengthSqrMassTime o1, MassPerTimeSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeSqr operator*(MassPerTimeSqr o1, LengthCubPerMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeSqr operator*(LengthCubPerMass o1, MassPerTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubMassPerTimeCub operator*(MassPerTimeSqr o1, LengthCubPerTime o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTimeCub operator*(LengthCubPerTime o1, MassPerTimeSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(MassPerTimeSqr o1, LengthCubPerTime o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthCubPerTime o1, MassPerTimeSqr o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMassPerTime operator*(MassPerTimeSqr o1, LengthCubTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static LengthCubMassPerTime operator*(LengthCubTime o1, MassPerTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
		public static MassPerLengthCubTimeCub operator/(MassPerTimeSqr o1, LengthCubTime o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCubPerMass operator/(LengthCubTime o1, MassPerTimeSqr o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(MassPerTimeSqr o1, LengthCubMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(LengthCubMass o1, MassPerTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(MassPerTimeSqr o1, PerMassTimeLengthCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerMassTimeLengthCub o1, MassPerTimeSqr o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator*(MassPerTimeSqr o1, TimePerMassLengthCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(TimePerMassLengthCub o1, MassPerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMass operator/(MassPerTimeSqr o1, PerTimeSqrLengthCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		public static PerMassLengthCub operator/(PerTimeSqrLengthCub o1, MassPerTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		
		public static Density operator*(MassPerTimeSqr o1, TimeSqrPerLengthCub o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(TimeSqrPerLengthCub o1, MassPerTimeSqr o2) => new Density(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTime operator/(MassPerTimeSqr o1, MassPerTimeLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(MassPerTimeLengthCub o1, MassPerTimeSqr o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator/(MassPerTimeSqr o1, MassTimePerLengthCub o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerLengthCub operator/(MassTimePerLengthCub o1, MassPerTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(MassPerTimeSqr o1, TimeSqrPerMassLengthSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeSqrPerMassLengthSqr o1, MassPerTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassTime operator/(MassPerTimeSqr o1, PerLengthSqrTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthSqr operator/(PerLengthSqrTimeCub o1, MassPerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthSqr operator*(MassPerTimeSqr o1, TimeCubPerLengthSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		public static MassTimePerLengthSqr operator*(TimeCubPerLengthSqr o1, MassPerTimeSqr o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static Area operator/(MassPerTimeSqr o1, MassPerLengthSqrTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(MassPerLengthSqrTimeSqr o1, MassPerTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator*(MassPerTimeSqr o1, TimeCubPerLengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubPerLengthMass o1, MassPerTimeSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static LengthTime operator/(MassPerTimeSqr o1, MassPerLengthTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
		public static PerLengthTime operator/(MassPerLengthTimeCub o1, MassPerTimeSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(MassPerTimeSqr o1, TimeCubLengthPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(TimeCubLengthPerMass o1, MassPerTimeSqr o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator/(MassPerTimeSqr o1, LengthMassPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthMassPerTimeCub o1, MassPerTimeSqr o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static Area operator*(MassPerTimeSqr o1, LengthSqrTimeSqrPerMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrTimeSqrPerMass o1, MassPerTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthSqr operator/(MassPerTimeSqr o1, LengthSqrPerTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTime operator/(LengthSqrPerTimeCub o1, MassPerTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(MassPerTimeSqr o1, TimeCubLengthSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(TimeCubLengthSqr o1, MassPerTimeSqr o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(MassPerTimeSqr o1, LengthSqrMassPerTimeSqr o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrMassPerTimeSqr o1, MassPerTimeSqr o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTimeCub operator*(MassPerTimeSqr o1, LengthCubPerMassTime o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubPerTimeCub operator*(LengthCubPerMassTime o1, MassPerTimeSqr o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTime operator*(MassPerTimeSqr o1, LengthCubTimePerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubTimePerMass o1, MassPerTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
		public static Density operator/(MassPerTimeSqr o1, LengthCubPerTimeSqr o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthCubPerTimeSqr o1, MassPerTimeSqr o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthCubMass operator*(MassPerTimeSqr o1, LengthCubTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		public static LengthCubMass operator*(LengthCubTimeSqr o1, MassPerTimeSqr o2) => new LengthCubMass(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(MassPerTimeSqr o1, LengthCubMassPerTime o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubMassPerTime o1, MassPerTimeSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(MassPerTimeSqr o1, LengthCubMassTime o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(LengthCubMassTime o1, MassPerTimeSqr o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(MassPerTimeSqr o1, TimeSqrPerMassLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeSqrPerMassLengthCub o1, MassPerTimeSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubMassTime operator/(MassPerTimeSqr o1, PerLengthCubTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthCubTimeCub o1, MassPerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static MassTimePerLengthCub operator*(MassPerTimeSqr o1, TimeCubPerLengthCub o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		public static MassTimePerLengthCub operator*(TimeCubPerLengthCub o1, MassPerTimeSqr o2) => new MassTimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static Volume operator/(MassPerTimeSqr o1, MassPerTimeSqrLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(MassPerTimeSqrLengthCub o1, MassPerTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(MassPerTimeSqr o1, TimeCubPerMassLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(TimeCubPerMassLengthSqr o1, MassPerTimeSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(MassPerTimeSqr o1, MassPerLengthSqrTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(MassPerLengthSqrTimeCub o1, MassPerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(MassPerTimeSqr o1, TimeCubLengthSqrPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(TimeCubLengthSqrPerMass o1, MassPerTimeSqr o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static TimePerLengthSqr operator/(MassPerTimeSqr o1, LengthSqrMassPerTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrMassPerTimeCub o1, MassPerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(MassPerTimeSqr o1, LengthCubTimeSqrPerMass o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubTimeSqrPerMass o1, MassPerTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static MassTimePerLengthCub operator/(MassPerTimeSqr o1, LengthCubPerTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTime operator/(LengthCubPerTimeCub o1, MassPerTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(MassPerTimeSqr o1, LengthCubTimeCub o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(LengthCubTimeCub o1, MassPerTimeSqr o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(MassPerTimeSqr o1, LengthCubMassPerTimeSqr o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubMassPerTimeSqr o1, MassPerTimeSqr o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(MassPerTimeSqr o1, TimeCubPerMassLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(TimeCubPerMassLengthCub o1, MassPerTimeSqr o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubTime operator/(MassPerTimeSqr o1, MassPerLengthCubTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(MassPerLengthCubTimeCub o1, MassPerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(MassPerTimeSqr o1, LengthCubTimeCubPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubTimeCubPerMass o1, MassPerTimeSqr o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(MassPerTimeSqr o1, LengthCubMassPerTimeCub o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubMassPerTimeCub o1, MassPerTimeSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerTimeSqr masspertimesqr, bool throwOnFail=true)
    {
        bool fail = false;
        if (masspertimesqr.HasMinValue && masspertimesqr.Value_ < masspertimesqr.MinValue)
        {
            fail = true;
        }

        if (masspertimesqr.HasMaxValue && masspertimesqr.Value_ > masspertimesqr.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerTimeSqr is outside its bounds.");
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
    