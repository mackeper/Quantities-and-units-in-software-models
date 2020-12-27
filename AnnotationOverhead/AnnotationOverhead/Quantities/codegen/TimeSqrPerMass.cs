
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimeSqrPerMass : Quantity, IEquatable<TimeSqrPerMass>, IComparable
    {
    internal TimeSqrPerMass(double value) : base(value, 2)
    {
        TimeSqrPerMass.ImportDisplayUnitFromDatabase_();
    }
    internal TimeSqrPerMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimeSqrPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimeSqrPerMass(TimeSqrPerMass other) : base(other)
    {
        TimeSqrPerMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimeSqrPerMass"))
        {
            switch(FakeDatabase.Units["TimeSqrPerMass"])
            {
				      case "secondsqrperkilogram": displayUnit_ = secondsqrperkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondsqrperkilogram_ = new Unit_("SecondSqrPerKilogram", "s²/kg", 1.0);
	private static Unit_ platformUnit_ = secondsqrperkilogram_;
	private static Unit_ displayUnit_ = secondsqrperkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimeSqrPerMass other) => other is object && Equals((object)other);
    public int CompareTo(TimeSqrPerMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimeSqrPerMass other)) throw new ArgumentException("Object is not a TimeSqrPerMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimeSqrPerMass l1, TimeSqrPerMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimeSqrPerMass l1, TimeSqrPerMass l2) => !(l1 == l2);
    public static bool operator <(TimeSqrPerMass l1, TimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimeSqrPerMass l1, TimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimeSqrPerMass l1, TimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimeSqrPerMass l1, TimeSqrPerMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimeSqrPerMass FromSecondSqrPerKilograms(double value, double minValue, double maxValue) => new TimeSqrPerMass(value * secondsqrperkilogram_.Factor, minValue * secondsqrperkilogram_.Factor, maxValue * secondsqrperkilogram_.Factor);
		public static TimeSqrPerMass FromSecondSqrPerKilograms(double value) => new TimeSqrPerMass(value * secondsqrperkilogram_.Factor);
		public double GetValueInSecondSqrPerKilograms() => Value_ / secondsqrperkilogram_.Factor;

#endregion

#region arithmetic
		public static TimeSqrPerMass operator+(TimeSqrPerMass o1, TimeSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ + o2.Value_);
		public static TimeSqrPerMass operator-(TimeSqrPerMass o1, TimeSqrPerMass o2) => new TimeSqrPerMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimeSqrPerMass o1, TimeSqrPerMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(TimeSqrPerMass o1, PerTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(PerTimeCub o1, TimeSqrPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator/(TimeSqrPerMass o1, TimeCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimeCub o1, TimeSqrPerMass o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimeSqrPerMass o1, MassPerTimeSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(MassPerTimeSqr o1, TimeSqrPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator/(TimeSqrPerMass o1, LengthPerMassTime o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(LengthPerMassTime o1, TimeSqrPerMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(TimeSqrPerMass o1, LengthTimePerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthTimePerMass o1, TimeSqrPerMass o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(TimeSqrPerMass o1, Acceleration o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(Acceleration o1, TimeSqrPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(TimeSqrPerMass o1, TimeSqrLength o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(TimeSqrLength o1, TimeSqrPerMass o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(TimeSqrPerMass o1, LengthMassPerTime o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthMassPerTime o1, TimeSqrPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(TimeSqrPerMass o1, LengthMassTime o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthMassTime o1, TimeSqrPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(TimeSqrPerMass o1, LengthSqrPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthSqrPerMass o1, TimeSqrPerMass o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimePerMass operator*(TimeSqrPerMass o1, LengthSqrPerTime o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(LengthSqrPerTime o1, TimeSqrPerMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimeSqrPerMass o1, LengthSqrPerTime o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(LengthSqrPerTime o1, TimeSqrPerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator*(TimeSqrPerMass o1, LengthSqrTime o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator*(LengthSqrTime o1, TimeSqrPerMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeSqrPerMass o1, LengthSqrTime o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTime operator/(LengthSqrTime o1, TimeSqrPerMass o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator*(TimeSqrPerMass o1, LengthSqrMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthSqrMass o1, TimeSqrPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeSqrPerMass operator*(TimeSqrPerMass o1, Volume o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqrPerMass operator*(Volume o1, TimeSqrPerMass o2) => new LengthCubTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(TimeSqrPerMass o1, Volume o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(Volume o1, TimeSqrPerMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator/(TimeSqrPerMass o1, PerMassLengthCub o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqrLengthCub operator/(PerMassLengthCub o1, TimeSqrPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		
		public static TimePerMassLengthCub operator*(TimeSqrPerMass o1, PerTimeLengthCub o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator*(PerTimeLengthCub o1, TimeSqrPerMass o2) => new TimePerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator/(TimeSqrPerMass o1, PerTimeLengthCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthCubTimeCub operator/(PerTimeLengthCub o1, TimeSqrPerMass o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(TimeSqrPerMass o1, TimePerLengthCub o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimePerLengthCub o1, TimeSqrPerMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator/(TimeSqrPerMass o1, TimePerLengthCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(TimePerLengthCub o1, TimeSqrPerMass o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(TimeSqrPerMass o1, Density o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(Density o1, TimeSqrPerMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator/(TimeSqrPerMass o1, PerMassTimeLengthSqr o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerMassTimeLengthSqr o1, TimeSqrPerMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(TimeSqrPerMass o1, TimePerMassLengthSqr o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(TimePerMassLengthSqr o1, TimeSqrPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(TimeSqrPerMass o1, PerLengthSqrTimeSqr o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(PerLengthSqrTimeSqr o1, TimeSqrPerMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator/(TimeSqrPerMass o1, TimeSqrPerLengthSqr o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(TimeSqrPerLengthSqr o1, TimeSqrPerMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator*(TimeSqrPerMass o1, MassPerTimeLengthSqr o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		public static TimePerLengthSqr operator*(MassPerTimeLengthSqr o1, TimeSqrPerMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(TimeSqrPerMass o1, MassTimePerLengthSqr o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(MassTimePerLengthSqr o1, TimeSqrPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static Length operator/(TimeSqrPerMass o1, TimeSqrPerLengthMass o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimeSqrPerLengthMass o1, TimeSqrPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator*(TimeSqrPerMass o1, PerLengthTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(PerLengthTimeCub o1, TimeSqrPerMass o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator/(TimeSqrPerMass o1, TimeCubPerLength o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(TimeCubPerLength o1, TimeSqrPerMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static PerLength operator*(TimeSqrPerMass o1, MassPerLengthTimeSqr o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(MassPerLengthTimeSqr o1, TimeSqrPerMass o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static PerTime operator/(TimeSqrPerMass o1, TimeCubPerMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeCubPerMass o1, TimeSqrPerMass o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimeSqrPerMass o1, MassPerTimeCub o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(MassPerTimeCub o1, TimeSqrPerMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static PerLength operator/(TimeSqrPerMass o1, TimeSqrLengthPerMass o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(TimeSqrLengthPerMass o1, TimeSqrPerMass o2) => new Length(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(TimeSqrPerMass o1, LengthPerTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthPerTimeCub o1, TimeSqrPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTime operator/(TimeSqrPerMass o1, TimeCubLength o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(TimeCubLength o1, TimeSqrPerMass o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimeSqrPerMass o1, Force o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(Force o1, TimeSqrPerMass o2) => new Length(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(TimeSqrPerMass o1, LengthSqrPerMassTime o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthSqrPerMassTime o1, TimeSqrPerMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthSqr operator/(TimeSqrPerMass o1, LengthSqrTimePerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTime operator/(LengthSqrTimePerMass o1, TimeSqrPerMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(TimeSqrPerMass o1, QDose o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(QDose o1, TimeSqrPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(TimeSqrPerMass o1, LengthSqrTimeSqr o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthSqrTimeSqr o1, TimeSqrPerMass o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(TimeSqrPerMass o1, LengthSqrMassPerTime o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthSqrMassPerTime o1, TimeSqrPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(TimeSqrPerMass o1, LengthSqrMassTime o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthSqrMassTime o1, TimeSqrPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(TimeSqrPerMass o1, LengthCubPerMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthCubPerMass o1, TimeSqrPerMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(TimeSqrPerMass o1, LengthCubPerTime o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(LengthCubPerTime o1, TimeSqrPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimeSqrPerMass o1, LengthCubPerTime o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(LengthCubPerTime o1, TimeSqrPerMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeCubPerMass operator*(TimeSqrPerMass o1, LengthCubTime o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimeCubPerMass operator*(LengthCubTime o1, TimeSqrPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimePerMassLengthCub operator/(TimeSqrPerMass o1, LengthCubTime o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTime operator/(LengthCubTime o1, TimeSqrPerMass o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimeSqr operator*(TimeSqrPerMass o1, LengthCubMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		public static LengthCubTimeSqr operator*(LengthCubMass o1, TimeSqrPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeCub operator/(TimeSqrPerMass o1, PerMassTimeLengthCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		public static PerLengthCubTimeCub operator/(PerMassTimeLengthCub o1, TimeSqrPerMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator/(TimeSqrPerMass o1, TimePerMassLengthCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthCub operator/(TimePerMassLengthCub o1, TimeSqrPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(TimeSqrPerMass o1, PerTimeSqrLengthCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(PerTimeSqrLengthCub o1, TimeSqrPerMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMass operator/(TimeSqrPerMass o1, TimeSqrPerLengthCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		public static Density operator/(TimeSqrPerLengthCub o1, TimeSqrPerMass o2) => new Density(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator*(TimeSqrPerMass o1, MassPerTimeLengthCub o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		public static TimePerLengthCub operator*(MassPerTimeLengthCub o1, TimeSqrPerMass o2) => new TimePerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(TimeSqrPerMass o1, MassTimePerLengthCub o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(MassTimePerLengthCub o1, TimeSqrPerMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static Area operator/(TimeSqrPerMass o1, TimeSqrPerMassLengthSqr o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimeSqrPerMassLengthSqr o1, TimeSqrPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(TimeSqrPerMass o1, PerLengthSqrTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerLengthSqrTimeCub o1, TimeSqrPerMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator/(TimeSqrPerMass o1, TimeCubPerLengthSqr o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(TimeCubPerLengthSqr o1, TimeSqrPerMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(TimeSqrPerMass o1, MassPerLengthSqrTimeSqr o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(MassPerLengthSqrTimeSqr o1, TimeSqrPerMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static Speed operator/(TimeSqrPerMass o1, TimeCubPerLengthMass o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeCubPerLengthMass o1, TimeSqrPerMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimeSqrPerMass o1, MassPerLengthTimeCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(MassPerLengthTimeCub o1, TimeSqrPerMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator/(TimeSqrPerMass o1, TimeCubLengthPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeCubLengthPerMass o1, TimeSqrPerMass o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Speed operator*(TimeSqrPerMass o1, LengthMassPerTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthMassPerTimeCub o1, TimeSqrPerMass o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(TimeSqrPerMass o1, LengthSqrTimeSqrPerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthSqrTimeSqrPerMass o1, TimeSqrPerMass o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator*(TimeSqrPerMass o1, LengthSqrPerTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthSqrPerTimeCub o1, TimeSqrPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthSqr operator/(TimeSqrPerMass o1, TimeCubLengthSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(TimeCubLengthSqr o1, TimeSqrPerMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(TimeSqrPerMass o1, LengthSqrMassPerTimeSqr o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthSqrMassPerTimeSqr o1, TimeSqrPerMass o2) => new Area(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator/(TimeSqrPerMass o1, LengthCubPerMassTime o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthCubPerMassTime o1, TimeSqrPerMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator/(TimeSqrPerMass o1, LengthCubTimePerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthCubTimePerMass o1, TimeSqrPerMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMass operator*(TimeSqrPerMass o1, LengthCubPerTimeSqr o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		public static LengthCubPerMass operator*(LengthCubPerTimeSqr o1, TimeSqrPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(TimeSqrPerMass o1, LengthCubTimeSqr o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthCubTimeSqr o1, TimeSqrPerMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthCubTime operator*(TimeSqrPerMass o1, LengthCubMassPerTime o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		public static LengthCubTime operator*(LengthCubMassPerTime o1, TimeSqrPerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
		
		public static LengthCubTimeCub operator*(TimeSqrPerMass o1, LengthCubMassTime o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		public static LengthCubTimeCub operator*(LengthCubMassTime o1, TimeSqrPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static Volume operator/(TimeSqrPerMass o1, TimeSqrPerMassLengthCub o2) => new Volume(o1.Value_ / o2.Value_);
		public static PerLengthCub operator/(TimeSqrPerMassLengthCub o1, TimeSqrPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(TimeSqrPerMass o1, PerLengthCubTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerLengthCubTimeCub o1, TimeSqrPerMass o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthCubPerMassTime operator/(TimeSqrPerMass o1, TimeCubPerLengthCub o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthCub operator/(TimeCubPerLengthCub o1, TimeSqrPerMass o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(TimeSqrPerMass o1, MassPerTimeSqrLengthCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(MassPerTimeSqrLengthCub o1, TimeSqrPerMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(TimeSqrPerMass o1, TimeCubPerMassLengthSqr o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeCubPerMassLengthSqr o1, TimeSqrPerMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(TimeSqrPerMass o1, MassPerLengthSqrTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(MassPerLengthSqrTimeCub o1, TimeSqrPerMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthSqr operator/(TimeSqrPerMass o1, TimeCubLengthSqrPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(TimeCubLengthSqrPerMass o1, TimeSqrPerMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(TimeSqrPerMass o1, LengthSqrMassPerTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthSqrMassPerTimeCub o1, TimeSqrPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(TimeSqrPerMass o1, LengthCubTimeSqrPerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthCubTimeSqrPerMass o1, TimeSqrPerMass o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthCubPerMassTime operator*(TimeSqrPerMass o1, LengthCubPerTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		public static LengthCubPerMassTime operator*(LengthCubPerTimeCub o1, TimeSqrPerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthCub operator/(TimeSqrPerMass o1, LengthCubTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthCubTimeCub o1, TimeSqrPerMass o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static Volume operator*(TimeSqrPerMass o1, LengthCubMassPerTimeSqr o2) => new Volume(o1.Value_ * o2.Value_);
		public static Volume operator*(LengthCubMassPerTimeSqr o1, TimeSqrPerMass o2) => new Volume(o1.Value_ * o2.Value_);
		
		public static LengthCubPerTime operator/(TimeSqrPerMass o1, TimeCubPerMassLengthCub o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthCub operator/(TimeCubPerMassLengthCub o1, TimeSqrPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(TimeSqrPerMass o1, MassPerLengthCubTimeCub o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(MassPerLengthCubTimeCub o1, TimeSqrPerMass o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(TimeSqrPerMass o1, LengthCubTimeCubPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthCubTimeCubPerMass o1, TimeSqrPerMass o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthCubPerTime operator*(TimeSqrPerMass o1, LengthCubMassPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		public static LengthCubPerTime operator*(LengthCubMassPerTimeCub o1, TimeSqrPerMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimeSqrPerMass timesqrpermass, bool throwOnFail=true)
    {
        bool fail = false;
        if (timesqrpermass.HasMinValue && timesqrpermass.Value_ < timesqrpermass.MinValue)
        {
            fail = true;
        }

        if (timesqrpermass.HasMaxValue && timesqrpermass.Value_ > timesqrpermass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimeSqrPerMass is outside its bounds.");
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
    