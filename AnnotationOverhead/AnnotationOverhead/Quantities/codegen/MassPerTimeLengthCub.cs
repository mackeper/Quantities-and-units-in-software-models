
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerTimeLengthCub : Quantity, IEquatable<MassPerTimeLengthCub>, IComparable
    {
    internal MassPerTimeLengthCub(double value) : base(value, 2)
    {
        MassPerTimeLengthCub.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerTimeLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerTimeLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerTimeLengthCub(MassPerTimeLengthCub other) : base(other)
    {
        MassPerTimeLengthCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerTimeLengthCub"))
        {
            switch(FakeDatabase.Units["MassPerTimeLengthCub"])
            {
				      case "kilogrampersecondcentimetercub": displayUnit_ = kilogrampersecondcentimetercub_; break;
				      case "kilogrampersecondmillimetercub": displayUnit_ = kilogrampersecondmillimetercub_; break;
				      case "kilogrampersecondmetercub": displayUnit_ = kilogrampersecondmetercub_; break;
				      case "kilogrampersecondinchcub": displayUnit_ = kilogrampersecondinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampersecondcentimetercub_ = new Unit_("KilogramPerSecondCentimeterCub", "kg/s cm�", 1.0);
	private static Unit_ kilogrampersecondmillimetercub_ = new Unit_("KilogramPerSecondMillimeterCub", "kg/s mm�", 999.9999999999998);
	private static Unit_ kilogrampersecondmetercub_ = new Unit_("KilogramPerSecondMeterCub", "kg/s m�", 1e-06);
	private static Unit_ kilogrampersecondinchcub_ = new Unit_("KilogramPerSecondInchCub", "kg/s in�", 0.05960464477539062);
	private static Unit_ platformUnit_ = kilogrampersecondcentimetercub_;
	private static Unit_ displayUnit_ = kilogrampersecondcentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerTimeLengthCub other) => other is object && Equals((object)other);
    public int CompareTo(MassPerTimeLengthCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerTimeLengthCub other)) throw new ArgumentException("Object is not a MassPerTimeLengthCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => !(l1 == l2);
    public static bool operator <(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerTimeLengthCub l1, MassPerTimeLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerTimeLengthCub FromKilogramPerSecondCentimeterCubs(double value, double minValue, double maxValue) => new MassPerTimeLengthCub(value * kilogrampersecondcentimetercub_.Factor, minValue * kilogrampersecondcentimetercub_.Factor, maxValue * kilogrampersecondcentimetercub_.Factor);
		public static MassPerTimeLengthCub FromKilogramPerSecondCentimeterCubs(double value) => new MassPerTimeLengthCub(value * kilogrampersecondcentimetercub_.Factor);
		public double GetValueInKilogramPerSecondCentimeterCubs() => Value_ / kilogrampersecondcentimetercub_.Factor;
		public static MassPerTimeLengthCub FromKilogramPerSecondMillimeterCubs(double value, double minValue, double maxValue) => new MassPerTimeLengthCub(value * kilogrampersecondmillimetercub_.Factor, minValue * kilogrampersecondmillimetercub_.Factor, maxValue * kilogrampersecondmillimetercub_.Factor);
		public static MassPerTimeLengthCub FromKilogramPerSecondMillimeterCubs(double value) => new MassPerTimeLengthCub(value * kilogrampersecondmillimetercub_.Factor);
		public double GetValueInKilogramPerSecondMillimeterCubs() => Value_ / kilogrampersecondmillimetercub_.Factor;
		public static MassPerTimeLengthCub FromKilogramPerSecondMeterCubs(double value, double minValue, double maxValue) => new MassPerTimeLengthCub(value * kilogrampersecondmetercub_.Factor, minValue * kilogrampersecondmetercub_.Factor, maxValue * kilogrampersecondmetercub_.Factor);
		public static MassPerTimeLengthCub FromKilogramPerSecondMeterCubs(double value) => new MassPerTimeLengthCub(value * kilogrampersecondmetercub_.Factor);
		public double GetValueInKilogramPerSecondMeterCubs() => Value_ / kilogrampersecondmetercub_.Factor;
		public static MassPerTimeLengthCub FromKilogramPerSecondInchCubs(double value, double minValue, double maxValue) => new MassPerTimeLengthCub(value * kilogrampersecondinchcub_.Factor, minValue * kilogrampersecondinchcub_.Factor, maxValue * kilogrampersecondinchcub_.Factor);
		public static MassPerTimeLengthCub FromKilogramPerSecondInchCubs(double value) => new MassPerTimeLengthCub(value * kilogrampersecondinchcub_.Factor);
		public double GetValueInKilogramPerSecondInchCubs() => Value_ / kilogrampersecondinchcub_.Factor;

#endregion

#region arithmetic
		public static MassPerTimeLengthCub operator+(MassPerTimeLengthCub o1, MassPerTimeLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ + o2.Value_);
		public static MassPerTimeLengthCub operator-(MassPerTimeLengthCub o1, MassPerTimeLengthCub o2) => new MassPerTimeLengthCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerTimeLengthCub o1, MassPerTimeLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(MassPerTimeLengthCub o1, MassTimePerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(MassTimePerLengthCub o1, MassPerTimeLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(MassPerTimeLengthCub o1, PerLengthSqrTimeCub o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerLengthSqrTimeCub o1, MassPerTimeLengthCub o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(MassPerTimeLengthCub o1, MassPerLengthSqrTimeSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(MassPerLengthSqrTimeSqr o1, MassPerTimeLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrMassPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeSqrMassPerLengthSqr o1, MassPerTimeLengthCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(MassPerTimeLengthCub o1, MassPerLengthTimeCub o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(MassPerLengthTimeCub o1, MassPerTimeLengthCub o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(MassPerTimeLengthCub o1, TimeCubLengthPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeCubLengthPerMass o1, MassPerTimeLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeCub operator*(MassPerTimeLengthCub o1, LengthSqrPerMassTimeSqr o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(LengthSqrPerMassTimeSqr o1, MassPerTimeLengthCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(MassPerTimeLengthCub o1, LengthSqrTimeSqrPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(LengthSqrTimeSqrPerMass o1, MassPerTimeLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator*(MassPerTimeLengthCub o1, TimeCubLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(TimeCubLengthSqr o1, MassPerTimeLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(MassPerTimeLengthCub o1, LengthCubPerMassTime o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthCubPerMassTime o1, MassPerTimeLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(MassPerTimeLengthCub o1, LengthCubTimePerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimePerMass o1, MassPerTimeLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(MassPerTimeLengthCub o1, LengthCubPerTimeSqr o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthCubPerTimeSqr o1, MassPerTimeLengthCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(MassPerTimeLengthCub o1, LengthCubTimeSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthCubTimeSqr o1, MassPerTimeLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator/(MassPerTimeLengthCub o1, PerLengthCubTimeCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerLengthCubTimeCub o1, MassPerTimeLengthCub o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static Time operator/(MassPerTimeLengthCub o1, MassPerTimeSqrLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(MassPerTimeSqrLengthCub o1, MassPerTimeLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(MassPerTimeLengthCub o1, TimeSqrMassPerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeSqrMassPerLengthCub o1, MassPerTimeLengthCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(MassPerTimeLengthCub o1, MassPerLengthSqrTimeCub o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(MassPerLengthSqrTimeCub o1, MassPerTimeLengthCub o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator*(MassPerTimeLengthCub o1, TimeCubLengthSqrPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(TimeCubLengthSqrPerMass o1, MassPerTimeLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static PerTimeCub operator*(MassPerTimeLengthCub o1, LengthCubPerMassTimeSqr o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthCubPerMassTimeSqr o1, MassPerTimeLengthCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static Time operator*(MassPerTimeLengthCub o1, LengthCubTimeSqrPerMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubTimeSqrPerMass o1, MassPerTimeLengthCub o2) => new Time(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(MassPerTimeLengthCub o1, LengthCubTimeCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(LengthCubTimeCub o1, MassPerTimeLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator/(MassPerTimeLengthCub o1, MassPerLengthCubTimeCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(MassPerLengthCubTimeCub o1, MassPerTimeLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator*(MassPerTimeLengthCub o1, LengthCubTimeCubPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthCubTimeCubPerMass o1, MassPerTimeLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerTimeLengthCub masspertimelengthcub, bool throwOnFail=true)
    {
        bool fail = false;
        if (masspertimelengthcub.HasMinValue && masspertimelengthcub.Value_ < masspertimelengthcub.MinValue)
        {
            fail = true;
        }

        if (masspertimelengthcub.HasMaxValue && masspertimelengthcub.Value_ > masspertimelengthcub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerTimeLengthCub is outside its bounds.");
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
    