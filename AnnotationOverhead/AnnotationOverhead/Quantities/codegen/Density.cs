
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class Density : Quantity, IEquatable<Density>, IComparable
    {
    internal Density(double value) : base(value, 2)
    {
        Density.ImportDisplayUnitFromDatabase_();
    }
    internal Density(double value, double minValue, double maxValue) : base(value, 2)
    {
        Density.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public Density(Density other) : base(other)
    {
        Density.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Density"))
        {
            switch(FakeDatabase.Units["Density"])
            {
				      case "kilogrampercentimetercub": displayUnit_ = kilogrampercentimetercub_; break;
				      case "kilogrampermillimetercub": displayUnit_ = kilogrampermillimetercub_; break;
				      case "kilogrampermetercub": displayUnit_ = kilogrampermetercub_; break;
				      case "kilogramperinchcub": displayUnit_ = kilogramperinchcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ kilogrampercentimetercub_ = new Unit_("KilogramPerCentimeterCub", "kg/cm�", 1.0);
	private static Unit_ kilogrampermillimetercub_ = new Unit_("KilogramPerMillimeterCub", "kg/mm�", 999.9999999999998);
	private static Unit_ kilogrampermetercub_ = new Unit_("KilogramPerMeterCub", "kg/m�", 1e-06);
	private static Unit_ kilogramperinchcub_ = new Unit_("KilogramPerInchCub", "kg/in�", 0.05960464477539062);
	private static Unit_ platformUnit_ = kilogrampercentimetercub_;
	private static Unit_ displayUnit_ = kilogrampercentimetercub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(Density other) => other is object && Equals((object)other);
    public int CompareTo(Density other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is Density other)) throw new ArgumentException("Object is not a Density.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(Density l1, Density l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(Density l1, Density l2) => !(l1 == l2);
    public static bool operator <(Density l1, Density l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(Density l1, Density l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(Density l1, Density l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(Density l1, Density l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static Density FromKilogramPerCentimeterCubs(double value, double minValue, double maxValue) => new Density(value * kilogrampercentimetercub_.Factor, minValue * kilogrampercentimetercub_.Factor, maxValue * kilogrampercentimetercub_.Factor);
		public static Density FromKilogramPerCentimeterCubs(double value) => new Density(value * kilogrampercentimetercub_.Factor);
		public double GetValueInKilogramPerCentimeterCubs() => Value_ / kilogrampercentimetercub_.Factor;
		public static Density FromKilogramPerMillimeterCubs(double value, double minValue, double maxValue) => new Density(value * kilogrampermillimetercub_.Factor, minValue * kilogrampermillimetercub_.Factor, maxValue * kilogrampermillimetercub_.Factor);
		public static Density FromKilogramPerMillimeterCubs(double value) => new Density(value * kilogrampermillimetercub_.Factor);
		public double GetValueInKilogramPerMillimeterCubs() => Value_ / kilogrampermillimetercub_.Factor;
		public static Density FromKilogramPerMeterCubs(double value, double minValue, double maxValue) => new Density(value * kilogrampermetercub_.Factor, minValue * kilogrampermetercub_.Factor, maxValue * kilogrampermetercub_.Factor);
		public static Density FromKilogramPerMeterCubs(double value) => new Density(value * kilogrampermetercub_.Factor);
		public double GetValueInKilogramPerMeterCubs() => Value_ / kilogrampermetercub_.Factor;
		public static Density FromKilogramPerInchCubs(double value, double minValue, double maxValue) => new Density(value * kilogramperinchcub_.Factor, minValue * kilogramperinchcub_.Factor, maxValue * kilogramperinchcub_.Factor);
		public static Density FromKilogramPerInchCubs(double value) => new Density(value * kilogramperinchcub_.Factor);
		public double GetValueInKilogramPerInchCubs() => Value_ / kilogramperinchcub_.Factor;

#endregion

#region arithmetic
		public static Density operator+(Density o1, Density o2) => new Density(o1.Value_ + o2.Value_);
		public static Density operator-(Density o1, Density o2) => new Density(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(Density o1, Density o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimeSqrMassPerLength operator/(Density o1, PerLengthSqrTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeSqr operator/(PerLengthSqrTimeSqr o1, Density o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(Density o1, TimeSqrPerLengthSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(TimeSqrPerLengthSqr o1, Density o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(Density o1, MassPerTimeLengthSqr o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(MassPerTimeLengthSqr o1, Density o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(Density o1, MassTimePerLengthSqr o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(MassTimePerLengthSqr o1, Density o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator/(Density o1, PerLengthTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMassTimeCub operator/(PerLengthTimeCub o1, Density o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator/(Density o1, TimeCubPerLength o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqrPerMass operator/(TimeCubPerLength o1, Density o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLengthSqr operator/(Density o1, MassPerLengthTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
		public static QDose operator/(MassPerLengthTimeSqr o1, Density o2) => new QDose(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator/(Density o1, TimeSqrMassPerLength o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimeSqr operator/(TimeSqrMassPerLength o1, Density o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator*(Density o1, PerMassTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthCubTimeCub operator*(PerMassTimeCub o1, Density o2) => new PerLengthCubTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator*(Density o1, TimeCubPerMass o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthCub operator*(TimeCubPerMass o1, Density o2) => new TimeCubPerLengthCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthCub operator/(Density o1, MassPerTimeCub o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubPerTimeCub operator/(MassPerTimeCub o1, Density o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthCubTimeCub operator/(Density o1, TimeCubMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeCub operator/(TimeCubMass o1, Density o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeSqr operator*(Density o1, LengthPerMassTimeSqr o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeSqr operator*(LengthPerMassTimeSqr o1, Density o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLengthSqr operator*(Density o1, TimeSqrLengthPerMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeSqrPerLengthSqr operator*(TimeSqrLengthPerMass o1, Density o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqrTimeCub operator*(Density o1, LengthPerTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthSqrTimeCub operator*(LengthPerTimeCub o1, Density o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubMassPerLengthSqr operator*(Density o1, TimeCubLength o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLengthSqr operator*(TimeCubLength o1, Density o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTime operator*(Density o1, LengthSqrPerMassTime o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		public static PerLengthTime operator*(LengthSqrPerMassTime o1, Density o2) => new PerLengthTime(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(Density o1, LengthSqrTimePerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(LengthSqrTimePerMass o1, Density o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeSqr operator*(Density o1, QDose o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeSqr operator*(QDose o1, Density o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMassPerLength operator*(Density o1, LengthSqrTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrMassPerLength operator*(LengthSqrTimeSqr o1, Density o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(Density o1, LengthCubPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubPerMass o1, Density o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(Density o1, LengthCubPerTime o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthCubPerTime o1, Density o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(Density o1, LengthCubTime o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(LengthCubTime o1, Density o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator/(Density o1, PerTimeSqrLengthCub o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
		public static PerMassTimeSqr operator/(PerTimeSqrLengthCub o1, Density o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
		
		public static MassPerTimeSqr operator/(Density o1, TimeSqrPerLengthCub o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMass operator/(TimeSqrPerLengthCub o1, Density o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(Density o1, MassPerTimeLengthCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(MassPerTimeLengthCub o1, Density o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerTime operator/(Density o1, MassTimePerLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
		public static Time operator/(MassTimePerLengthCub o1, Density o2) => new Time(o1.Value_ / o2.Value_);
		
		public static TimeCubMassPerLength operator/(Density o1, PerLengthSqrTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTimeCub operator/(PerLengthSqrTimeCub o1, Density o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator/(Density o1, TimeCubPerLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(TimeCubPerLengthSqr o1, Density o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqrPerLength operator/(Density o1, MassPerLengthSqrTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
		public static Acceleration operator/(MassPerLengthSqrTimeSqr o1, Density o2) => new Acceleration(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeSqr operator/(Density o1, TimeSqrMassPerLengthSqr o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLength operator/(TimeSqrMassPerLengthSqr o1, Density o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLengthSqr operator/(Density o1, MassPerLengthTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerTimeCub operator/(MassPerLengthTimeCub o1, Density o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator/(Density o1, TimeCubMassPerLength o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthSqr operator/(TimeCubMassPerLength o1, Density o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
		
		public static PerLengthSqrTimeCub operator*(Density o1, LengthPerMassTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthSqrTimeCub operator*(LengthPerMassTimeCub o1, Density o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLengthSqr operator*(Density o1, TimeCubLengthPerMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		public static TimeCubPerLengthSqr operator*(TimeCubLengthPerMass o1, Density o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthTimeSqr operator*(Density o1, LengthSqrPerMassTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		public static PerLengthTimeSqr operator*(LengthSqrPerMassTimeSqr o1, Density o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrPerLength operator*(Density o1, LengthSqrTimeSqrPerMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		public static TimeSqrPerLength operator*(LengthSqrTimeSqrPerMass o1, Density o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(Density o1, LengthSqrPerTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(LengthSqrPerTimeCub o1, Density o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubMassPerLength operator*(Density o1, TimeCubLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		public static TimeCubMassPerLength operator*(TimeCubLengthSqr o1, Density o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
		
		public static PerTime operator*(Density o1, LengthCubPerMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
		public static PerTime operator*(LengthCubPerMassTime o1, Density o2) => new PerTime(o1.Value_ * o2.Value_);
		
		public static Time operator*(Density o1, LengthCubTimePerMass o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(LengthCubTimePerMass o1, Density o2) => new Time(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqr operator*(Density o1, LengthCubPerTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeSqr operator*(LengthCubPerTimeSqr o1, Density o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqrMass operator*(Density o1, LengthCubTimeSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		public static TimeSqrMass operator*(LengthCubTimeSqr o1, Density o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
		
		public static TimeCubMass operator/(Density o1, PerLengthCubTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		public static PerMassTimeCub operator/(PerLengthCubTimeCub o1, Density o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		
		public static MassPerTimeCub operator/(Density o1, TimeCubPerLengthCub o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubPerMass operator/(TimeCubPerLengthCub o1, Density o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
		
		public static TimeSqr operator/(Density o1, MassPerTimeSqrLengthCub o2) => new TimeSqr(o1.Value_ / o2.Value_);
		public static PerTimeSqr operator/(MassPerTimeSqrLengthCub o1, Density o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		
		public static PerTimeSqr operator/(Density o1, TimeSqrMassPerLengthCub o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqr operator/(TimeSqrMassPerLengthCub o1, Density o2) => new TimeSqr(o1.Value_ / o2.Value_);
		
		public static TimeCubPerLength operator/(Density o1, MassPerLengthSqrTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
		public static LengthPerTimeCub operator/(MassPerLengthSqrTimeCub o1, Density o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(Density o1, TimeCubMassPerLengthSqr o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(TimeCubMassPerLengthSqr o1, Density o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator*(Density o1, LengthSqrPerMassTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthTimeCub operator*(LengthSqrPerMassTimeCub o1, Density o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubPerLength operator*(Density o1, TimeCubLengthSqrPerMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		public static TimeCubPerLength operator*(TimeCubLengthSqrPerMass o1, Density o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
		
		public static PerTimeSqr operator*(Density o1, LengthCubPerMassTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		public static PerTimeSqr operator*(LengthCubPerMassTimeSqr o1, Density o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
		
		public static TimeSqr operator*(Density o1, LengthCubTimeSqrPerMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
		public static TimeSqr operator*(LengthCubTimeSqrPerMass o1, Density o2) => new TimeSqr(o1.Value_ * o2.Value_);
		
		public static MassPerTimeCub operator*(Density o1, LengthCubPerTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		public static MassPerTimeCub operator*(LengthCubPerTimeCub o1, Density o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCubMass operator*(Density o1, LengthCubTimeCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		public static TimeCubMass operator*(LengthCubTimeCub o1, Density o2) => new TimeCubMass(o1.Value_ * o2.Value_);
		
		public static TimeCub operator/(Density o1, MassPerLengthCubTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
		public static PerTimeCub operator/(MassPerLengthCubTimeCub o1, Density o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator/(Density o1, TimeCubMassPerLengthCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
		public static TimeCub operator/(TimeCubMassPerLengthCub o1, Density o2) => new TimeCub(o1.Value_ / o2.Value_);
		
		public static PerTimeCub operator*(Density o1, LengthCubPerMassTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		public static PerTimeCub operator*(LengthCubPerMassTimeCub o1, Density o2) => new PerTimeCub(o1.Value_ * o2.Value_);
		
		public static TimeCub operator*(Density o1, LengthCubTimeCubPerMass o2) => new TimeCub(o1.Value_ * o2.Value_);
		public static TimeCub operator*(LengthCubTimeCubPerMass o1, Density o2) => new TimeCub(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(Density density, bool throwOnFail=true)
    {
        bool fail = false;
        if (density.HasMinValue && density.Value_ < density.MinValue)
        {
            fail = true;
        }

        if (density.HasMaxValue && density.Value_ > density.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("Density is outside its bounds.");
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
    