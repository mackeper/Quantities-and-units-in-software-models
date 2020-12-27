
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class MassPerLengthTimeCub : Quantity, IEquatable<MassPerLengthTimeCub>, IComparable
    {
    internal MassPerLengthTimeCub(double value) : base(value, 2)
    {
        MassPerLengthTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal MassPerLengthTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        MassPerLengthTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public MassPerLengthTimeCub(MassPerLengthTimeCub other) : base(other)
    {
        MassPerLengthTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerLengthTimeCub"))
        {
            switch(FakeDatabase.Units["MassPerLengthTimeCub"])
            {
				      case "kilogrampercentimetersecondcub": displayUnit_ = kilogrampercentimetersecondcub_; break;
				      case "kilogrampermillimetersecondcub": displayUnit_ = kilogrampermillimetersecondcub_; break;
				      case "kilogrampermetersecondcub": displayUnit_ = kilogrampermetersecondcub_; break;
				      case "kilogramperinchsecondcub": displayUnit_ = kilogramperinchsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampercentimetersecondcub_ = new Unit_("KilogramPerCentimeterSecondCub", "kg/cm s�", 1.0);
	private static Unit_ kilogrampermillimetersecondcub_ = new Unit_("KilogramPerMillimeterSecondCub", "kg/mm s�", 10.0);
	private static Unit_ kilogrampermetersecondcub_ = new Unit_("KilogramPerMeterSecondCub", "kg/m s�", 0.01);
	private static Unit_ kilogramperinchsecondcub_ = new Unit_("KilogramPerInchSecondCub", "kg/in s�", 0.390625);
	private static Unit_ platformUnit_ = kilogrampercentimetersecondcub_;
	private static Unit_ displayUnit_ = kilogrampercentimetersecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(MassPerLengthTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(MassPerLengthTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is MassPerLengthTimeCub other)) throw new ArgumentException("Object is not a MassPerLengthTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => !(l1 == l2);
    public static bool operator <(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(MassPerLengthTimeCub l1, MassPerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static MassPerLengthTimeCub FromKilogramPerCentimeterSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthTimeCub(value * kilogrampercentimetersecondcub_.Factor, minValue * kilogrampercentimetersecondcub_.Factor, maxValue * kilogrampercentimetersecondcub_.Factor);
		public static MassPerLengthTimeCub FromKilogramPerCentimeterSecondCubs(double value) => new MassPerLengthTimeCub(value * kilogrampercentimetersecondcub_.Factor);
		public double GetValueInKilogramPerCentimeterSecondCubs() => Value_ / kilogrampercentimetersecondcub_.Factor;
		public static MassPerLengthTimeCub FromKilogramPerMillimeterSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthTimeCub(value * kilogrampermillimetersecondcub_.Factor, minValue * kilogrampermillimetersecondcub_.Factor, maxValue * kilogrampermillimetersecondcub_.Factor);
		public static MassPerLengthTimeCub FromKilogramPerMillimeterSecondCubs(double value) => new MassPerLengthTimeCub(value * kilogrampermillimetersecondcub_.Factor);
		public double GetValueInKilogramPerMillimeterSecondCubs() => Value_ / kilogrampermillimetersecondcub_.Factor;
		public static MassPerLengthTimeCub FromKilogramPerMeterSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthTimeCub(value * kilogrampermetersecondcub_.Factor, minValue * kilogrampermetersecondcub_.Factor, maxValue * kilogrampermetersecondcub_.Factor);
		public static MassPerLengthTimeCub FromKilogramPerMeterSecondCubs(double value) => new MassPerLengthTimeCub(value * kilogrampermetersecondcub_.Factor);
		public double GetValueInKilogramPerMeterSecondCubs() => Value_ / kilogrampermetersecondcub_.Factor;
		public static MassPerLengthTimeCub FromKilogramPerInchSecondCubs(double value, double minValue, double maxValue) => new MassPerLengthTimeCub(value * kilogramperinchsecondcub_.Factor, minValue * kilogramperinchsecondcub_.Factor, maxValue * kilogramperinchsecondcub_.Factor);
		public static MassPerLengthTimeCub FromKilogramPerInchSecondCubs(double value) => new MassPerLengthTimeCub(value * kilogramperinchsecondcub_.Factor);
		public double GetValueInKilogramPerInchSecondCubs() => Value_ / kilogramperinchsecondcub_.Factor;

#endregion

#region arithmetic
		public static MassPerLengthTimeCub operator+(MassPerLengthTimeCub o1, MassPerLengthTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ + o2.Value_);
		public static MassPerLengthTimeCub operator-(MassPerLengthTimeCub o1, MassPerLengthTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(MassPerLengthTimeCub o1, MassPerLengthTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(MassPerLengthTimeCub o1, TimeCubLengthPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeCubLengthPerMass o1, MassPerLengthTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(MassPerLengthTimeCub o1, LengthMassPerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthMassPerTimeCub o1, MassPerLengthTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Speed operator*(MassPerLengthTimeCub o1, LengthSqrTimeSqrPerMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrTimeSqrPerMass o1, MassPerLengthTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static Density operator/(MassPerLengthTimeCub o1, LengthSqrPerTimeCub o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrPerTimeCub o1, MassPerLengthTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(MassPerLengthTimeCub o1, TimeCubLengthSqr o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(TimeCubLengthSqr o1, MassPerLengthTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(MassPerLengthTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrMassPerTimeSqr o1, MassPerLengthTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static QDose operator*(MassPerLengthTimeCub o1, LengthCubTimePerMass o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubTimePerMass o1, MassPerLengthTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(MassPerLengthTimeCub o1, LengthCubTimeSqr o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubTimeSqr o1, MassPerLengthTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(MassPerLengthTimeCub o1, PerLengthCubTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerLengthCubTimeCub o1, MassPerLengthTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(MassPerLengthTimeCub o1, MassPerTimeSqrLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(MassPerTimeSqrLengthCub o1, MassPerLengthTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(MassPerLengthTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeCubPerMassLengthSqr o1, MassPerLengthTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static Length operator/(MassPerLengthTimeCub o1, MassPerLengthSqrTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(MassPerLengthSqrTimeCub o1, MassPerLengthTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static Length operator*(MassPerLengthTimeCub o1, TimeCubLengthSqrPerMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeCubLengthSqrPerMass o1, MassPerLengthTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(MassPerLengthTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrMassPerTimeCub o1, MassPerLengthTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator*(MassPerLengthTimeCub o1, LengthCubTimeSqrPerMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubTimeSqrPerMass o1, MassPerLengthTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(MassPerLengthTimeCub o1, LengthCubTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubTimeCub o1, MassPerLengthTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
		public static Area operator/(MassPerLengthTimeCub o1, MassPerLengthCubTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(MassPerLengthCubTimeCub o1, MassPerLengthTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator*(MassPerLengthTimeCub o1, LengthCubTimeCubPerMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimeCubPerMass o1, MassPerLengthTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(MassPerLengthTimeCub massperlengthtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (massperlengthtimecub.HasMinValue && massperlengthtimecub.Value_ < massperlengthtimecub.MinValue)
        {
            fail = true;
        }

        if (massperlengthtimecub.HasMaxValue && massperlengthtimecub.Value_ > massperlengthtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("MassPerLengthTimeCub is outside its bounds.");
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
    