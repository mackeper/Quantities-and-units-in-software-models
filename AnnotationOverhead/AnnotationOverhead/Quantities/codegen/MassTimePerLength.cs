
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassTimePerLength : Quantity, IEquatable<MassTimePerLength>, IComparable
    {
    internal MassTimePerLength(double value) : base(value, 2)
    {
        MassTimePerLength.ImportDisplayUnitFromDatabase_();
    }
    internal MassTimePerLength(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassTimePerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassTimePerLength(MassTimePerLength other) : base(other)
    {
        MassTimePerLength.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassTimePerLength"))
        {
            switch(FakeDatabase.Units["MassTimePerLength"])
            {
				      case "kilogramsecondpercentimeter": displayUnit_ = kilogramsecondpercentimeter_; break;
				      case "kilogramsecondpermillimeter": displayUnit_ = kilogramsecondpermillimeter_; break;
				      case "kilogramsecondpermeter": displayUnit_ = kilogramsecondpermeter_; break;
				      case "kilogramsecondperinch": displayUnit_ = kilogramsecondperinch_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogramsecondpercentimeter_ = new Unit_("KilogramSecondPerCentimeter", "kg s/cm", 1.0);
	private static Unit_ kilogramsecondpermillimeter_ = new Unit_("KilogramSecondPerMillimeter", "kg s/mm", 10.0);
	private static Unit_ kilogramsecondpermeter_ = new Unit_("KilogramSecondPerMeter", "kg s/m", 0.01);
	private static Unit_ kilogramsecondperinch_ = new Unit_("KilogramSecondPerInch", "kg s/in", 0.390625);
	private static Unit_ platformUnit_ = kilogramsecondpercentimeter_;
	private static Unit_ displayUnit_ = kilogramsecondpercentimeter_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassTimePerLength other) => other is object && Equals((object)other);
    public int CompareTo(MassTimePerLength other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassTimePerLength other)) throw new ArgumentException("Object is not a MassTimePerLength.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassTimePerLength l1, MassTimePerLength l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassTimePerLength l1, MassTimePerLength l2) => !(l1 == l2);
    public static bool operator <(MassTimePerLength l1, MassTimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassTimePerLength l1, MassTimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassTimePerLength l1, MassTimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassTimePerLength l1, MassTimePerLength l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassTimePerLength FromKilogramSecondPerCentimeters(double value, double minValue, double maxValue) => new MassTimePerLength(value * kilogramsecondpercentimeter_.Factor, minValue * kilogramsecondpercentimeter_.Factor, maxValue * kilogramsecondpercentimeter_.Factor);
		public static MassTimePerLength FromKilogramSecondPerCentimeters(double value) => new MassTimePerLength(value * kilogramsecondpercentimeter_.Factor);
		public double GetValueInKilogramSecondPerCentimeters() => Value_ / kilogramsecondpercentimeter_.Factor;
		public static MassTimePerLength FromKilogramSecondPerMillimeters(double value, double minValue, double maxValue) => new MassTimePerLength(value * kilogramsecondpermillimeter_.Factor, minValue * kilogramsecondpermillimeter_.Factor, maxValue * kilogramsecondpermillimeter_.Factor);
		public static MassTimePerLength FromKilogramSecondPerMillimeters(double value) => new MassTimePerLength(value * kilogramsecondpermillimeter_.Factor);
		public double GetValueInKilogramSecondPerMillimeters() => Value_ / kilogramsecondpermillimeter_.Factor;
		public static MassTimePerLength FromKilogramSecondPerMeters(double value, double minValue, double maxValue) => new MassTimePerLength(value * kilogramsecondpermeter_.Factor, minValue * kilogramsecondpermeter_.Factor, maxValue * kilogramsecondpermeter_.Factor);
		public static MassTimePerLength FromKilogramSecondPerMeters(double value) => new MassTimePerLength(value * kilogramsecondpermeter_.Factor);
		public double GetValueInKilogramSecondPerMeters() => Value_ / kilogramsecondpermeter_.Factor;
		public static MassTimePerLength FromKilogramSecondPerInchs(double value, double minValue, double maxValue) => new MassTimePerLength(value * kilogramsecondperinch_.Factor, minValue * kilogramsecondperinch_.Factor, maxValue * kilogramsecondperinch_.Factor);
		public static MassTimePerLength FromKilogramSecondPerInchs(double value) => new MassTimePerLength(value * kilogramsecondperinch_.Factor);
		public double GetValueInKilogramSecondPerInchs() => Value_ / kilogramsecondperinch_.Factor;

#endregion

#region arithmetic
		public static MassTimePerLength operator+(MassTimePerLength o1, MassTimePerLength o2) => new MassTimePerLength(o1.Value_ + o2.Value_);
		public static MassTimePerLength operator-(MassTimePerLength o1, MassTimePerLength o2) => new MassTimePerLength(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassTimePerLength o1, MassTimePerLength o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator*(MassTimePerLength o1, PerMassTimeSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(PerMassTimeSqr o1, MassTimePerLength o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(MassTimePerLength o1, TimeSqrPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeSqrPerMass o1, MassTimePerLength o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(MassTimePerLength o1, PerTimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(PerTimeCub o1, MassTimePerLength o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(MassTimePerLength o1, TimeCub o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeCub o1, MassTimePerLength o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator/(MassTimePerLength o1, MassPerTimeSqr o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(MassPerTimeSqr o1, MassTimePerLength o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(MassTimePerLength o1, TimeSqrMass o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(TimeSqrMass o1, MassTimePerLength o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(MassTimePerLength o1, LengthPerMassTime o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthPerMassTime o1, MassTimePerLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(MassTimePerLength o1, LengthTimePerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthTimePerMass o1, MassTimePerLength o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(MassTimePerLength o1, Acceleration o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(Acceleration o1, MassTimePerLength o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator/(MassTimePerLength o1, Acceleration o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(Acceleration o1, MassTimePerLength o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMass operator*(MassTimePerLength o1, TimeSqrLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(TimeSqrLength o1, MassTimePerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator/(MassTimePerLength o1, TimeSqrLength o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(TimeSqrLength o1, MassTimePerLength o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(MassTimePerLength o1, LengthMassPerTime o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(LengthMassPerTime o1, MassTimePerLength o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator/(MassTimePerLength o1, LengthMassTime o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthMassTime o1, MassTimePerLength o2) => new Area(o1.Value_ / o2.Value_);
		
		public static LengthTime operator*(MassTimePerLength o1, LengthSqrPerMass o2) => new LengthTime(o1.Value_ * o2.Value_);
		public static LengthTime operator*(LengthSqrPerMass o1, MassTimePerLength o2) => new LengthTime(o1.Value_ * o2.Value_);
		
		public static LengthMass operator*(MassTimePerLength o1, LengthSqrPerTime o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(LengthSqrPerTime o1, MassTimePerLength o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLengthCub operator/(MassTimePerLength o1, LengthSqrPerTime o2) => new TimeSqrMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeSqr operator/(LengthSqrPerTime o1, MassTimePerLength o2) => new LengthCubPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrLengthMass operator*(MassTimePerLength o1, LengthSqrTime o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static TimeSqrLengthMass operator*(LengthSqrTime o1, MassTimePerLength o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
		public static Density operator/(MassTimePerLength o1, LengthSqrTime o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrTime o1, MassTimePerLength o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthCub operator/(MassTimePerLength o1, LengthSqrMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTime operator/(LengthSqrMass o1, MassTimePerLength o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassTime operator*(MassTimePerLength o1, Volume o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassTime operator*(Volume o1, MassTimePerLength o2) => new LengthSqrMassTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator/(MassTimePerLength o1, PerTimeLengthCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeSqr operator/(PerTimeLengthCub o1, MassTimePerLength o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrMass operator/(MassTimePerLength o1, TimePerLengthCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(TimePerLengthCub o1, MassTimePerLength o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator/(MassTimePerLength o1, Density o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		public static PerTimeLengthSqr operator/(Density o1, MassTimePerLength o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(MassTimePerLength o1, PerMassTimeLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(PerMassTimeLengthSqr o1, MassTimePerLength o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthCub operator*(MassTimePerLength o1, TimePerMassLengthSqr o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthCub operator*(TimePerMassLengthSqr o1, MassTimePerLength o2) => new TimeSqrPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator*(MassTimePerLength o1, PerLengthSqrTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(PerLengthSqrTimeSqr o1, MassTimePerLength o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator/(MassTimePerLength o1, PerLengthSqrTimeSqr o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMassTimeCub operator/(PerLengthSqrTimeSqr o1, MassTimePerLength o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthCub operator*(MassTimePerLength o1, TimeSqrPerLengthSqr o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator*(TimeSqrPerLengthSqr o1, MassTimePerLength o2) => new TimeCubMassPerLengthCub(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator/(MassTimePerLength o1, TimeSqrPerLengthSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(TimeSqrPerLengthSqr o1, MassTimePerLength o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrLength operator/(MassTimePerLength o1, MassPerTimeLengthSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeSqr operator/(MassPerTimeLengthSqr o1, MassTimePerLength o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(MassTimePerLength o1, MassTimePerLengthSqr o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassTimePerLengthSqr o1, MassTimePerLength o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator*(MassTimePerLength o1, PerLengthMassTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static PerTimeLengthSqr operator*(PerLengthMassTimeSqr o1, MassTimePerLength o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(MassTimePerLength o1, TimeSqrPerLengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeSqrPerLengthMass o1, MassTimePerLength o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator*(MassTimePerLength o1, PerLengthTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeSqr operator*(PerLengthTimeCub o1, MassTimePerLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator/(MassTimePerLength o1, TimeCubPerLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeCubPerLength o1, MassTimePerLength o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCub operator/(MassTimePerLength o1, MassPerLengthTimeSqr o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(MassPerLengthTimeSqr o1, MassTimePerLength o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(MassTimePerLength o1, TimeSqrMassPerLength o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(TimeSqrMassPerLength o1, MassTimePerLength o2) => new Time(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator*(MassTimePerLength o1, PerMassTimeCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(PerMassTimeCub o1, MassTimePerLength o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator/(MassTimePerLength o1, TimeCubMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeCubMass o1, MassTimePerLength o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static PerTime operator*(MassTimePerLength o1, LengthPerMassTimeSqr o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthPerMassTimeSqr o1, MassTimePerLength o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(MassTimePerLength o1, TimeSqrLengthPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(TimeSqrLengthPerMass o1, MassTimePerLength o2) => new TimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(MassTimePerLength o1, LengthPerTimeCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(LengthPerTimeCub o1, MassTimePerLength o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeSqr operator/(MassTimePerLength o1, TimeCubLength o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqrPerMass operator/(TimeCubLength o1, MassTimePerLength o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(MassTimePerLength o1, Force o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(Force o1, MassTimePerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthSqr operator/(MassTimePerLength o1, TimeSqrLengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTime operator/(TimeSqrLengthMass o1, MassTimePerLength o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
		
		public static Length operator*(MassTimePerLength o1, LengthSqrPerMassTime o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(LengthSqrPerMassTime o1, MassTimePerLength o2) => new Length(o1.Value_ * o2.Value_);
		
		public static TimeSqrLength operator*(MassTimePerLength o1, LengthSqrTimePerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		public static TimeSqrLength operator*(LengthSqrTimePerMass o1, MassTimePerLength o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
		
		public static LengthMassPerTime operator*(MassTimePerLength o1, QDose o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(QDose o1, MassTimePerLength o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthCub operator/(MassTimePerLength o1, QDose o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerMassTimeCub operator/(QDose o1, MassTimePerLength o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthMass operator*(MassTimePerLength o1, LengthSqrTimeSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthMass operator*(LengthSqrTimeSqr o1, MassTimePerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator/(MassTimePerLength o1, LengthSqrTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthSqrTimeSqr o1, MassTimePerLength o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthCub operator/(MassTimePerLength o1, LengthSqrMassPerTime o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeSqr operator/(LengthSqrMassPerTime o1, MassTimePerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator/(MassTimePerLength o1, LengthSqrMassTime o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrMassTime o1, MassTimePerLength o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthSqrTime operator*(MassTimePerLength o1, LengthCubPerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		public static LengthSqrTime operator*(LengthCubPerMass o1, MassTimePerLength o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(MassTimePerLength o1, LengthCubPerTime o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubPerTime o1, MassTimePerLength o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqrMass operator*(MassTimePerLength o1, LengthCubTime o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqrMass operator*(LengthCubTime o1, MassTimePerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator/(MassTimePerLength o1, PerTimeSqrLengthCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqrTimeCub operator/(PerTimeSqrLengthCub o1, MassTimePerLength o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrMassPerTime operator/(MassTimePerLength o1, TimeSqrPerLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(TimeSqrPerLengthCub o1, MassTimePerLength o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrTimeSqr operator/(MassTimePerLength o1, MassPerTimeLengthCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeSqr operator/(MassPerTimeLengthCub o1, MassTimePerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(MassTimePerLength o1, MassTimePerLengthCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(MassTimePerLengthCub o1, MassTimePerLength o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator*(MassTimePerLength o1, PerMassLengthSqrTimeSqr o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeLengthCub operator*(PerMassLengthSqrTimeSqr o1, MassTimePerLength o2) => new PerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(MassTimePerLength o1, TimeSqrPerMassLengthSqr o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeSqrPerMassLengthSqr o1, MassTimePerLength o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator*(MassTimePerLength o1, PerLengthSqrTimeCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeSqrLengthCub operator*(PerLengthSqrTimeCub o1, MassTimePerLength o2) => new MassPerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static Force operator/(MassTimePerLength o1, TimeCubPerLengthSqr o2) => new Force(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthMass operator/(TimeCubPerLengthSqr o1, MassTimePerLength o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
		
		public static TimeCubLength operator/(MassTimePerLength o1, MassPerLengthSqrTimeSqr o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		public static PerLengthTimeCub operator/(MassPerLengthSqrTimeSqr o1, MassTimePerLength o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		
		public static Speed operator/(MassTimePerLength o1, TimeSqrMassPerLengthSqr o2) => new Speed(o1.Value_ / o2.Value_);
		public static TimePerLength operator/(TimeSqrMassPerLengthSqr o1, MassTimePerLength o2) => new TimePerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(MassTimePerLength o1, PerLengthMassTimeCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(PerLengthMassTimeCub o1, MassTimePerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator/(MassTimePerLength o1, TimeCubMassPerLength o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeCubMassPerLength o1, MassTimePerLength o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator*(MassTimePerLength o1, LengthPerMassTimeCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthPerMassTimeCub o1, MassTimePerLength o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(MassTimePerLength o1, TimeCubLengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeCubLengthMass o1, MassTimePerLength o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static Speed operator*(MassTimePerLength o1, LengthSqrPerMassTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrPerMassTimeSqr o1, MassTimePerLength o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static TimeCubLength operator*(MassTimePerLength o1, LengthSqrTimeSqrPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		public static TimeCubLength operator*(LengthSqrTimeSqrPerMass o1, MassTimePerLength o2) => new TimeCubLength(o1.Value_ * o2.Value_);
		
		public static Force operator*(MassTimePerLength o1, LengthSqrPerTimeCub o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthSqrPerTimeCub o1, MassTimePerLength o2) => new Force(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator/(MassTimePerLength o1, TimeCubLengthSqr o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(TimeCubLengthSqr o1, MassTimePerLength o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthCub operator/(MassTimePerLength o1, LengthSqrMassPerTimeSqr o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(LengthSqrMassPerTimeSqr o1, MassTimePerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeLengthCub operator/(MassTimePerLength o1, LengthSqrTimeSqrMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrTimeSqrMass o1, MassTimePerLength o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Area operator*(MassTimePerLength o1, LengthCubPerMassTime o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubPerMassTime o1, MassTimePerLength o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrTimeSqr operator*(MassTimePerLength o1, LengthCubTimePerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrTimeSqr operator*(LengthCubTimePerMass o1, MassTimePerLength o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassTimePerLength o1, LengthCubPerTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubPerTimeSqr o1, MassTimePerLength o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqrMass operator*(MassTimePerLength o1, LengthCubTimeSqr o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqrMass operator*(LengthCubTimeSqr o1, MassTimePerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(MassTimePerLength o1, TimeCubPerLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(TimeCubPerLengthCub o1, MassTimePerLength o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubLengthSqr operator/(MassTimePerLength o1, MassPerTimeSqrLengthCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		public static PerLengthSqrTimeCub operator/(MassPerTimeSqrLengthCub o1, MassTimePerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(MassTimePerLength o1, TimeSqrMassPerLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(TimeSqrMassPerLengthCub o1, MassTimePerLength o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqrLengthCub operator*(MassTimePerLength o1, PerMassLengthSqrTimeCub o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		public static PerTimeSqrLengthCub operator*(PerMassLengthSqrTimeCub o1, MassTimePerLength o2) => new PerTimeSqrLengthCub(o1.Value_ * o2.Value_);
		
		public static Acceleration operator/(MassTimePerLength o1, TimeCubMassPerLengthSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
		public static TimeSqrPerLength operator/(TimeCubMassPerLengthSqr o1, MassTimePerLength o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		
		public static Acceleration operator*(MassTimePerLength o1, LengthSqrPerMassTimeCub o2) => new Acceleration(o1.Value_ * o2.Value_);
		public static Acceleration operator*(LengthSqrPerMassTimeCub o1, MassTimePerLength o2) => new Acceleration(o1.Value_ * o2.Value_);
		
		public static PerTimeSqrLengthCub operator/(MassTimePerLength o1, TimeCubLengthSqrMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqr operator/(TimeCubLengthSqrMass o1, MassTimePerLength o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(MassTimePerLength o1, LengthCubPerMassTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubPerMassTimeSqr o1, MassTimePerLength o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static TimeCubLengthSqr operator*(MassTimePerLength o1, LengthCubTimeSqrPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubLengthSqr operator*(LengthCubTimeSqrPerMass o1, MassTimePerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(MassTimePerLength o1, LengthCubPerTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubPerTimeCub o1, MassTimePerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static QDose operator/(MassTimePerLength o1, TimeCubMassPerLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		public static TimeSqrPerLengthSqr operator/(TimeCubMassPerLengthCub o1, MassTimePerLength o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassTimePerLength o1, LengthCubPerMassTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubPerMassTimeCub o1, MassTimePerLength o2) => new QDose(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassTimePerLength masstimeperlength, bool throwOnFail=true)
    {
        bool fail = false;
        if (masstimeperlength.HasMinValue && masstimeperlength.Value_ < masstimeperlength.MinValue)
        {
            fail = true;
        }

        if (masstimeperlength.HasMaxValue && masstimeperlength.Value_ > masstimeperlength.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassTimePerLength is outside its bounds.");
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
    