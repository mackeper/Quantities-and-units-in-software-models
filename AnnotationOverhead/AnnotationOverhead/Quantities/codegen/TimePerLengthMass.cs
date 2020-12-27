
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class TimePerLengthMass : Quantity, IEquatable<TimePerLengthMass>, IComparable
    {
    internal TimePerLengthMass(double value) : base(value, 2)
    {
        TimePerLengthMass.ImportDisplayUnitFromDatabase_();
    }
    internal TimePerLengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
        TimePerLengthMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public TimePerLengthMass(TimePerLengthMass other) : base(other)
    {
        TimePerLengthMass.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("TimePerLengthMass"))
        {
            switch(FakeDatabase.Units["TimePerLengthMass"])
            {
				      case "secondpercentimeterkilogram": displayUnit_ = secondpercentimeterkilogram_; break;
				      case "secondpermillimeterkilogram": displayUnit_ = secondpermillimeterkilogram_; break;
				      case "secondpermeterkilogram": displayUnit_ = secondpermeterkilogram_; break;
				      case "secondperinchkilogram": displayUnit_ = secondperinchkilogram_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ secondpercentimeterkilogram_ = new Unit_("SecondPerCentimeterKilogram", "s/cm kg", 1.0);
	private static Unit_ secondpermillimeterkilogram_ = new Unit_("SecondPerMillimeterKilogram", "s/mm kg", 10.0);
	private static Unit_ secondpermeterkilogram_ = new Unit_("SecondPerMeterKilogram", "s/m kg", 0.01);
	private static Unit_ secondperinchkilogram_ = new Unit_("SecondPerInchKilogram", "s/in kg", 0.390625);
	private static Unit_ platformUnit_ = secondpercentimeterkilogram_;
	private static Unit_ displayUnit_ = secondpercentimeterkilogram_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(TimePerLengthMass other) => other is object && Equals((object)other);
    public int CompareTo(TimePerLengthMass other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is TimePerLengthMass other)) throw new ArgumentException("Object is not a TimePerLengthMass.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(TimePerLengthMass l1, TimePerLengthMass l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(TimePerLengthMass l1, TimePerLengthMass l2) => !(l1 == l2);
    public static bool operator <(TimePerLengthMass l1, TimePerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(TimePerLengthMass l1, TimePerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(TimePerLengthMass l1, TimePerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(TimePerLengthMass l1, TimePerLengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static TimePerLengthMass FromSecondPerCentimeterKilograms(double value, double minValue, double maxValue) => new TimePerLengthMass(value * secondpercentimeterkilogram_.Factor, minValue * secondpercentimeterkilogram_.Factor, maxValue * secondpercentimeterkilogram_.Factor);
		public static TimePerLengthMass FromSecondPerCentimeterKilograms(double value) => new TimePerLengthMass(value * secondpercentimeterkilogram_.Factor);
		public double GetValueInSecondPerCentimeterKilograms() => Value_ / secondpercentimeterkilogram_.Factor;
		public static TimePerLengthMass FromSecondPerMillimeterKilograms(double value, double minValue, double maxValue) => new TimePerLengthMass(value * secondpermillimeterkilogram_.Factor, minValue * secondpermillimeterkilogram_.Factor, maxValue * secondpermillimeterkilogram_.Factor);
		public static TimePerLengthMass FromSecondPerMillimeterKilograms(double value) => new TimePerLengthMass(value * secondpermillimeterkilogram_.Factor);
		public double GetValueInSecondPerMillimeterKilograms() => Value_ / secondpermillimeterkilogram_.Factor;
		public static TimePerLengthMass FromSecondPerMeterKilograms(double value, double minValue, double maxValue) => new TimePerLengthMass(value * secondpermeterkilogram_.Factor, minValue * secondpermeterkilogram_.Factor, maxValue * secondpermeterkilogram_.Factor);
		public static TimePerLengthMass FromSecondPerMeterKilograms(double value) => new TimePerLengthMass(value * secondpermeterkilogram_.Factor);
		public double GetValueInSecondPerMeterKilograms() => Value_ / secondpermeterkilogram_.Factor;
		public static TimePerLengthMass FromSecondPerInchKilograms(double value, double minValue, double maxValue) => new TimePerLengthMass(value * secondperinchkilogram_.Factor, minValue * secondperinchkilogram_.Factor, maxValue * secondperinchkilogram_.Factor);
		public static TimePerLengthMass FromSecondPerInchKilograms(double value) => new TimePerLengthMass(value * secondperinchkilogram_.Factor);
		public double GetValueInSecondPerInchKilograms() => Value_ / secondperinchkilogram_.Factor;

#endregion

#region arithmetic
		public static TimePerLengthMass operator+(TimePerLengthMass o1, TimePerLengthMass o2) => new TimePerLengthMass(o1.Value_ + o2.Value_);
		public static TimePerLengthMass operator-(TimePerLengthMass o1, TimePerLengthMass o2) => new TimePerLengthMass(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(TimePerLengthMass o1, TimePerLengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthSqr operator*(TimePerLengthMass o1, PerLengthTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator*(PerLengthTimeSqr o1, TimePerLengthMass o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator/(TimePerLengthMass o1, PerLengthTimeSqr o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeCub operator/(PerLengthTimeSqr o1, TimePerLengthMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthSqr operator*(TimePerLengthMass o1, TimeSqrPerLength o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator*(TimeSqrPerLength o1, TimePerLengthMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassTime operator/(TimePerLengthMass o1, TimeSqrPerLength o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(TimeSqrPerLength o1, TimePerLengthMass o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(TimePerLengthMass o1, MassPerLengthTime o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(MassPerLengthTime o1, TimePerLengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(TimePerLengthMass o1, MassTimePerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(MassTimePerLength o1, TimePerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator/(TimePerLengthMass o1, PerMassTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(PerMassTimeSqr o1, TimePerLengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(TimePerLengthMass o1, TimeSqrPerMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeSqrPerMass o1, TimePerLengthMass o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator*(TimePerLengthMass o1, PerTimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeSqr operator*(PerTimeCub o1, TimePerLengthMass o2) => new PerLengthMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(TimePerLengthMass o1, TimeCub o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(TimeCub o1, TimePerLengthMass o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(TimePerLengthMass o1, MassPerTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(MassPerTimeSqr o1, TimePerLengthMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(TimePerLengthMass o1, TimeSqrMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeSqrMass o1, TimePerLengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(TimePerLengthMass o1, LengthPerMassTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthPerMassTime o1, TimePerLengthMass o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(TimePerLengthMass o1, LengthTimePerMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthTimePerMass o1, TimePerLengthMass o2) => new Area(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(TimePerLengthMass o1, Acceleration o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(Acceleration o1, TimePerLengthMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthSqr operator/(TimePerLengthMass o1, Acceleration o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassPerTimeCub operator/(Acceleration o1, TimePerLengthMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMass operator*(TimePerLengthMass o1, TimeSqrLength o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static TimeCubPerMass operator*(TimeSqrLength o1, TimePerLengthMass o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthSqr operator/(TimePerLengthMass o1, TimeSqrLength o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(TimeSqrLength o1, TimePerLengthMass o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(TimePerLengthMass o1, LengthMassPerTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthMassPerTime o1, TimePerLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(TimePerLengthMass o1, LengthMassTime o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthMassTime o1, TimePerLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static TimePerLengthCub operator/(TimePerLengthMass o1, LengthSqrPerMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrPerMass o1, TimePerLengthMass o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(TimePerLengthMass o1, LengthSqrPerTime o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(LengthSqrPerTime o1, TimePerLengthMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrPerMassLengthCub operator/(TimePerLengthMass o1, LengthSqrPerTime o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeSqr operator/(LengthSqrPerTime o1, TimePerLengthMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthPerMass operator*(TimePerLengthMass o1, LengthSqrTime o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthPerMass operator*(LengthSqrTime o1, TimePerLengthMass o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator/(TimePerLengthMass o1, LengthSqrTime o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthSqrTime o1, TimePerLengthMass o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(TimePerLengthMass o1, LengthSqrMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrMass o1, TimePerLengthMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimePerMass operator*(TimePerLengthMass o1, Volume o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimePerMass operator*(Volume o1, TimePerLengthMass o2) => new LengthSqrTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator/(TimePerLengthMass o1, PerMassLengthCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(PerMassLengthCub o1, TimePerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator/(TimePerLengthMass o1, PerTimeLengthCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeSqr operator/(PerTimeLengthCub o1, TimePerLengthMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(TimePerLengthMass o1, TimePerLengthCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(TimePerLengthCub o1, TimePerLengthMass o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(TimePerLengthMass o1, PerMassTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(PerMassTimeLengthSqr o1, TimePerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(TimePerLengthMass o1, TimePerMassLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(TimePerMassLengthSqr o1, TimePerLengthMass o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(TimePerLengthMass o1, PerLengthSqrTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(PerLengthSqrTimeSqr o1, TimePerLengthMass o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator/(TimePerLengthMass o1, PerLengthSqrTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTimeCub operator/(PerLengthSqrTimeSqr o1, TimePerLengthMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubPerMassLengthCub operator*(TimePerLengthMass o1, TimeSqrPerLengthSqr o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator*(TimeSqrPerLengthSqr o1, TimePerLengthMass o2) => new TimeCubPerMassLengthCub(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator/(TimePerLengthMass o1, TimeSqrPerLengthSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(TimeSqrPerLengthSqr o1, TimePerLengthMass o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(TimePerLengthMass o1, MassPerTimeLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(MassPerTimeLengthSqr o1, TimePerLengthMass o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(TimePerLengthMass o1, MassTimePerLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(MassTimePerLengthSqr o1, TimePerLengthMass o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(TimePerLengthMass o1, PerLengthMassTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(PerLengthMassTimeSqr o1, TimePerLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(TimePerLengthMass o1, TimeSqrPerLengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeSqrPerLengthMass o1, TimePerLengthMass o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator*(TimePerLengthMass o1, PerLengthTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqrTimeSqr operator*(PerLengthTimeCub o1, TimePerLengthMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqr operator/(TimePerLengthMass o1, TimeCubPerLength o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMass operator/(TimeCubPerLength o1, TimePerLengthMass o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(TimePerLengthMass o1, MassPerLengthTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(MassPerLengthTimeSqr o1, TimePerLengthMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(TimePerLengthMass o1, TimeSqrMassPerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeSqrMassPerLength o1, TimePerLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator/(TimePerLengthMass o1, TimeCubPerMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeCubPerMass o1, TimePerLengthMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(TimePerLengthMass o1, MassPerTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(MassPerTimeCub o1, TimePerLengthMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(TimePerLengthMass o1, LengthPerMassTimeSqr o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(LengthPerMassTimeSqr o1, TimePerLengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator/(TimePerLengthMass o1, TimeSqrLengthPerMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(TimeSqrLengthPerMass o1, TimePerLengthMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqr operator*(TimePerLengthMass o1, LengthPerTimeCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		public static PerMassTimeSqr operator*(LengthPerTimeCub o1, TimePerLengthMass o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqrTimeSqr operator/(TimePerLengthMass o1, TimeCubLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrMass operator/(TimeCubLength o1, TimePerLengthMass o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(TimePerLengthMass o1, Force o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(Force o1, TimePerLengthMass o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(TimePerLengthMass o1, TimeSqrLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqrLengthMass o1, TimePerLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(TimePerLengthMass o1, LengthSqrPerMassTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthSqrPerMassTime o1, TimePerLengthMass o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(TimePerLengthMass o1, LengthSqrTimePerMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrTimePerMass o1, TimePerLengthMass o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(TimePerLengthMass o1, QDose o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(QDose o1, TimePerLengthMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static TimeCubPerMassLengthCub operator/(TimePerLengthMass o1, QDose o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassPerTimeCub operator/(QDose o1, TimePerLengthMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthPerMass operator*(TimePerLengthMass o1, LengthSqrTimeSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthPerMass operator*(LengthSqrTimeSqr o1, TimePerLengthMass o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator/(TimePerLengthMass o1, LengthSqrTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthSqrTimeSqr o1, TimePerLengthMass o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(TimePerLengthMass o1, LengthSqrMassPerTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrMassPerTime o1, TimePerLengthMass o2) => new Length(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(TimePerLengthMass o1, LengthSqrMassTime o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthSqrMassTime o1, TimePerLengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator*(TimePerLengthMass o1, LengthCubPerTime o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubPerTime o1, TimePerLengthMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrPerMass operator*(TimePerLengthMass o1, LengthCubTime o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrPerMass operator*(LengthCubTime o1, TimePerLengthMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTime operator*(TimePerLengthMass o1, LengthCubMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubMass o1, TimePerLengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator/(TimePerLengthMass o1, PerMassTimeLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(PerMassTimeLengthCub o1, TimePerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(TimePerLengthMass o1, TimePerMassLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(TimePerMassLengthCub o1, TimePerLengthMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator/(TimePerLengthMass o1, PerTimeSqrLengthCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqrTimeCub operator/(PerTimeSqrLengthCub o1, TimePerLengthMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator/(TimePerLengthMass o1, TimeSqrPerLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(TimeSqrPerLengthCub o1, TimePerLengthMass o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator/(TimePerLengthMass o1, PerMassLengthSqrTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(PerMassLengthSqrTimeSqr o1, TimePerLengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static Speed operator/(TimePerLengthMass o1, TimeSqrPerMassLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeSqrPerMassLengthSqr o1, TimePerLengthMass o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator*(TimePerLengthMass o1, PerLengthSqrTimeCub o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeSqrLengthCub operator*(PerLengthSqrTimeCub o1, TimePerLengthMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTimeSqr operator/(TimePerLengthMass o1, TimeCubPerLengthSqr o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLength operator/(TimeCubPerLengthSqr o1, TimePerLengthMass o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(TimePerLengthMass o1, MassPerLengthSqrTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(MassPerLengthSqrTimeSqr o1, TimePerLengthMass o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(TimePerLengthMass o1, TimeSqrMassPerLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeSqrMassPerLengthSqr o1, TimePerLengthMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(TimePerLengthMass o1, TimeCubPerLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeCubPerLengthMass o1, TimePerLengthMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(TimePerLengthMass o1, MassPerLengthTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(MassPerLengthTimeCub o1, TimePerLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(TimePerLengthMass o1, TimeCubLengthPerMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeCubLengthPerMass o1, TimePerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(TimePerLengthMass o1, LengthMassPerTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthMassPerTimeCub o1, TimePerLengthMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator/(TimePerLengthMass o1, LengthSqrPerMassTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthSqrPerMassTimeSqr o1, TimePerLengthMass o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator/(TimePerLengthMass o1, LengthSqrTimeSqrPerMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrTimeSqrPerMass o1, TimePerLengthMass o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(TimePerLengthMass o1, LengthSqrPerTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthSqrPerTimeCub o1, TimePerLengthMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator/(TimePerLengthMass o1, TimeCubLengthSqr o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(TimeCubLengthSqr o1, TimePerLengthMass o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static Speed operator*(TimePerLengthMass o1, LengthSqrMassPerTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrMassPerTimeSqr o1, TimePerLengthMass o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(TimePerLengthMass o1, LengthSqrTimeSqrMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthSqrTimeSqrMass o1, TimePerLengthMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(TimePerLengthMass o1, LengthCubPerTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubPerTimeSqr o1, TimePerLengthMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrPerMass operator*(TimePerLengthMass o1, LengthCubTimeSqr o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrPerMass operator*(LengthCubTimeSqr o1, TimePerLengthMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static Area operator*(TimePerLengthMass o1, LengthCubMassPerTime o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubMassPerTime o1, TimePerLengthMass o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(TimePerLengthMass o1, LengthCubMassTime o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubMassTime o1, TimePerLengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator/(TimePerLengthMass o1, PerMassTimeSqrLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(PerMassTimeSqrLengthCub o1, TimePerLengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(TimePerLengthMass o1, TimeSqrPerMassLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeSqrPerMassLengthCub o1, TimePerLengthMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(TimePerLengthMass o1, TimeCubPerLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(TimeCubPerLengthCub o1, TimePerLengthMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator/(TimePerLengthMass o1, TimeCubPerMassLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubPerMassLengthSqr o1, TimePerLengthMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(TimePerLengthMass o1, MassPerLengthSqrTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(MassPerLengthSqrTimeCub o1, TimePerLengthMass o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(TimePerLengthMass o1, TimeCubLengthSqrPerMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(TimeCubLengthSqrPerMass o1, TimePerLengthMass o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(TimePerLengthMass o1, LengthSqrMassPerTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthSqrMassPerTimeCub o1, TimePerLengthMass o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(TimePerLengthMass o1, LengthCubPerTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthCubPerTimeCub o1, TimePerLengthMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(TimePerLengthMass o1, LengthCubMassPerTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubMassPerTimeSqr o1, TimePerLengthMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(TimePerLengthMass o1, LengthCubTimeSqrMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthCubTimeSqrMass o1, TimePerLengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static QDose operator/(TimePerLengthMass o1, TimeCubPerMassLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeCubPerMassLengthCub o1, TimePerLengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator*(TimePerLengthMass o1, LengthCubMassPerTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubMassPerTimeCub o1, TimePerLengthMass o2) => new QDose(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(TimePerLengthMass timeperlengthmass, bool throwOnFail=true)
    {
        bool fail = false;
        if (timeperlengthmass.HasMinValue && timeperlengthmass.Value_ < timeperlengthmass.MinValue)
        {
            fail = true;
        }

        if (timeperlengthmass.HasMaxValue && timeperlengthmass.Value_ > timeperlengthmass.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("TimePerLengthMass is outside its bounds.");
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
    