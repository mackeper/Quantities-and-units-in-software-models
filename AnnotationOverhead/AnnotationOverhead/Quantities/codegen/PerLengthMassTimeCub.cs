
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthMassTimeCub : Quantity, IEquatable<PerLengthMassTimeCub>, IComparable
    {
    internal PerLengthMassTimeCub(double value) : base(value, 2)
    {
        PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthMassTimeCub(PerLengthMassTimeCub other) : base(other)
    {
        PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMassTimeCub"))
        {
            switch(FakeDatabase.Units["PerLengthMassTimeCub"])
            {
				      case "percentimetercubkilogramsecondcub": displayUnit_ = percentimetercubkilogramsecondcub_; break;
				      case "permillimetercubkilogramsecondcub": displayUnit_ = permillimetercubkilogramsecondcub_; break;
				      case "permetercubkilogramsecondcub": displayUnit_ = permetercubkilogramsecondcub_; break;
				      case "perinchcubkilogramsecondcub": displayUnit_ = perinchcubkilogramsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetercubkilogramsecondcub_ = new Unit_("PerCentimeterCubKilogramSecondCub", "/cm³ kg s³", 1.0);
	private static Unit_ permillimetercubkilogramsecondcub_ = new Unit_("PerMillimeterCubKilogramSecondCub", "/mm³ kg s³", 0.1);
	private static Unit_ permetercubkilogramsecondcub_ = new Unit_("PerMeterCubKilogramSecondCub", "/m³ kg s³", 100.0);
	private static Unit_ perinchcubkilogramsecondcub_ = new Unit_("PerInchCubKilogramSecondCub", "/in³ kg s³", 2.56);
	private static Unit_ platformUnit_ = percentimetercubkilogramsecondcub_;
	private static Unit_ displayUnit_ = percentimetercubkilogramsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthMassTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthMassTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthMassTimeCub other)) throw new ArgumentException("Object is not a PerLengthMassTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthMassTimeCub l1, PerLengthMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthMassTimeCub FromPerCentimeterCubKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub(value * percentimetercubkilogramsecondcub_.Factor, minValue * percentimetercubkilogramsecondcub_.Factor, maxValue * percentimetercubkilogramsecondcub_.Factor);
		public static PerLengthMassTimeCub FromPerCentimeterCubKilogramSecondCubs(double value) => new PerLengthMassTimeCub(value * percentimetercubkilogramsecondcub_.Factor);
		public double GetValueInPerCentimeterCubKilogramSecondCubs() => Value_ / percentimetercubkilogramsecondcub_.Factor;
		public static PerLengthMassTimeCub FromPerMillimeterCubKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub(value * permillimetercubkilogramsecondcub_.Factor, minValue * permillimetercubkilogramsecondcub_.Factor, maxValue * permillimetercubkilogramsecondcub_.Factor);
		public static PerLengthMassTimeCub FromPerMillimeterCubKilogramSecondCubs(double value) => new PerLengthMassTimeCub(value * permillimetercubkilogramsecondcub_.Factor);
		public double GetValueInPerMillimeterCubKilogramSecondCubs() => Value_ / permillimetercubkilogramsecondcub_.Factor;
		public static PerLengthMassTimeCub FromPerMeterCubKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub(value * permetercubkilogramsecondcub_.Factor, minValue * permetercubkilogramsecondcub_.Factor, maxValue * permetercubkilogramsecondcub_.Factor);
		public static PerLengthMassTimeCub FromPerMeterCubKilogramSecondCubs(double value) => new PerLengthMassTimeCub(value * permetercubkilogramsecondcub_.Factor);
		public double GetValueInPerMeterCubKilogramSecondCubs() => Value_ / permetercubkilogramsecondcub_.Factor;
		public static PerLengthMassTimeCub FromPerInchCubKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub(value * perinchcubkilogramsecondcub_.Factor, minValue * perinchcubkilogramsecondcub_.Factor, maxValue * perinchcubkilogramsecondcub_.Factor);
		public static PerLengthMassTimeCub FromPerInchCubKilogramSecondCubs(double value) => new PerLengthMassTimeCub(value * perinchcubkilogramsecondcub_.Factor);
		public double GetValueInPerInchCubKilogramSecondCubs() => Value_ / perinchcubkilogramsecondcub_.Factor;

#endregion

#region arithmetic
		public static PerLengthMassTimeCub operator+(PerLengthMassTimeCub o1, PerLengthMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ + o2.Value_);
		public static PerLengthMassTimeCub operator-(PerLengthMassTimeCub o1, PerLengthMassTimeCub o2) => new PerLengthMassTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthMassTimeCub o1, PerLengthMassTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(PerLengthMassTimeCub o1, TimeCubMassPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthMassTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(PerLengthMassTimeCub o1, LengthPerMassTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthPerMassTimeCub o1, PerLengthMassTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLengthMassTimeCub o1, TimeCubLengthMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeCubLengthMass o1, PerLengthMassTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(PerLengthMassTimeCub o1, LengthSqrPerMassTimeSqr o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(LengthSqrPerMassTimeSqr o1, PerLengthMassTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator/(PerLengthMassTimeCub o1, LengthSqrPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthSqrPerTimeCub o1, PerLengthMassTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerLengthMassTimeCub o1, TimeCubLengthSqr o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(TimeCubLengthSqr o1, PerLengthMassTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static Speed operator*(PerLengthMassTimeCub o1, LengthSqrTimeSqrMass o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrTimeSqrMass o1, PerLengthMassTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerLengthMassTimeCub o1, LengthCubTimeSqr o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubTimeSqr o1, PerLengthMassTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static QDose operator*(PerLengthMassTimeCub o1, LengthCubMassTime o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubMassTime o1, PerLengthMassTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator/(PerLengthMassTimeCub o1, PerMassTimeSqrLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthMassTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(PerLengthMassTimeCub o1, PerLengthCubTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(PerLengthCubTimeCub o1, PerLengthMassTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Length operator/(PerLengthMassTimeCub o1, PerMassLengthSqrTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerMassLengthSqrTimeCub o1, PerLengthMassTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerLengthMassTimeCub o1, TimeCubMassPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeCubMassPerLengthSqr o1, PerLengthMassTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(PerLengthMassTimeCub o1, LengthSqrPerMassTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrPerMassTimeCub o1, PerLengthMassTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerLengthMassTimeCub o1, TimeCubLengthSqrMass o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeCubLengthSqrMass o1, PerLengthMassTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMass operator*(PerLengthMassTimeCub o1, LengthCubTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubTimeCub o1, PerLengthMassTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(PerLengthMassTimeCub o1, LengthCubTimeSqrMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubTimeSqrMass o1, PerLengthMassTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static Area operator/(PerLengthMassTimeCub o1, PerMassLengthCubTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerMassLengthCubTimeCub o1, PerLengthMassTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator*(PerLengthMassTimeCub o1, LengthCubTimeCubMass o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimeCubMass o1, PerLengthMassTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthMassTimeCub perlengthmasstimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthmasstimecub.HasMinValue && perlengthmasstimecub.Value_ < perlengthmasstimecub.MinValue)
        {
            fail = true;
        }

        if (perlengthmasstimecub.HasMaxValue && perlengthmasstimecub.Value_ > perlengthmasstimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthMassTimeCub is outside its bounds.");
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
    