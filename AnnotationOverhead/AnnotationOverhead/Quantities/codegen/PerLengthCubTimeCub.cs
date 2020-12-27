
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthCubTimeCub : Quantity, IEquatable<PerLengthCubTimeCub>, IComparable
    {
    internal PerLengthCubTimeCub(double value) : base(value, 2)
    {
        PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthCubTimeCub(PerLengthCubTimeCub other) : base(other)
    {
        PerLengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthCubTimeCub"))
        {
            switch(FakeDatabase.Units["PerLengthCubTimeCub"])
            {
				      case "percentimetersecondcub": displayUnit_ = percentimetersecondcub_; break;
				      case "permillimetersecondcub": displayUnit_ = permillimetersecondcub_; break;
				      case "permetersecondcub": displayUnit_ = permetersecondcub_; break;
				      case "perinchsecondcub": displayUnit_ = perinchsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetersecondcub_ = new Unit_("PerCentimeterSecondCub", "/cm s�", 1.0);
	private static Unit_ permillimetersecondcub_ = new Unit_("PerMillimeterSecondCub", "/mm s�", 0.001);
	private static Unit_ permetersecondcub_ = new Unit_("PerMeterSecondCub", "/m s�", 1000000.0);
	private static Unit_ perinchsecondcub_ = new Unit_("PerInchSecondCub", "/in s�", 16.777216000000003);
	private static Unit_ platformUnit_ = percentimetersecondcub_;
	private static Unit_ displayUnit_ = percentimetersecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthCubTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthCubTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthCubTimeCub other)) throw new ArgumentException("Object is not a PerLengthCubTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthCubTimeCub l1, PerLengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthCubTimeCub FromPerCentimeterSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub(value * percentimetersecondcub_.Factor, minValue * percentimetersecondcub_.Factor, maxValue * percentimetersecondcub_.Factor);
		public static PerLengthCubTimeCub FromPerCentimeterSecondCubs(double value) => new PerLengthCubTimeCub(value * percentimetersecondcub_.Factor);
		public double GetValueInPerCentimeterSecondCubs() => Value_ / percentimetersecondcub_.Factor;
		public static PerLengthCubTimeCub FromPerMillimeterSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub(value * permillimetersecondcub_.Factor, minValue * permillimetersecondcub_.Factor, maxValue * permillimetersecondcub_.Factor);
		public static PerLengthCubTimeCub FromPerMillimeterSecondCubs(double value) => new PerLengthCubTimeCub(value * permillimetersecondcub_.Factor);
		public double GetValueInPerMillimeterSecondCubs() => Value_ / permillimetersecondcub_.Factor;
		public static PerLengthCubTimeCub FromPerMeterSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub(value * permetersecondcub_.Factor, minValue * permetersecondcub_.Factor, maxValue * permetersecondcub_.Factor);
		public static PerLengthCubTimeCub FromPerMeterSecondCubs(double value) => new PerLengthCubTimeCub(value * permetersecondcub_.Factor);
		public double GetValueInPerMeterSecondCubs() => Value_ / permetersecondcub_.Factor;
		public static PerLengthCubTimeCub FromPerInchSecondCubs(double value, double minValue, double maxValue) => new PerLengthCubTimeCub(value * perinchsecondcub_.Factor, minValue * perinchsecondcub_.Factor, maxValue * perinchsecondcub_.Factor);
		public static PerLengthCubTimeCub FromPerInchSecondCubs(double value) => new PerLengthCubTimeCub(value * perinchsecondcub_.Factor);
		public double GetValueInPerInchSecondCubs() => Value_ / perinchsecondcub_.Factor;

#endregion

#region arithmetic
		public static PerLengthCubTimeCub operator+(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ + o2.Value_);
		public static PerLengthCubTimeCub operator-(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerLengthCubTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(PerLengthCubTimeCub o1, MassPerTimeSqrLengthCub o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerTimeSqrLengthCub o1, PerLengthCubTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(PerLengthCubTimeCub o1, PerMassLengthSqrTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMassLengthSqrTimeCub o1, PerLengthCubTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(PerLengthCubTimeCub o1, MassPerLengthSqrTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerLengthSqrTimeCub o1, PerLengthCubTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerLengthCubTimeCub o1, TimeCubLengthSqrPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeCubLengthSqrPerMass o1, PerLengthCubTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(PerLengthCubTimeCub o1, TimeCubLengthSqrMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeCubLengthSqrMass o1, PerLengthCubTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator*(PerLengthCubTimeCub o1, LengthCubTimeSqrPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(LengthCubTimeSqrPerMass o1, PerLengthCubTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static Dimensionless operator*(PerLengthCubTimeCub o1, LengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(LengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static MassPerTime operator*(PerLengthCubTimeCub o1, LengthCubTimeSqrMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(LengthCubTimeSqrMass o1, PerLengthCubTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static Mass operator/(PerLengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerMassLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(PerLengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerLengthCubTimeCub o1, PerLengthCubTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerLengthCubTimeCub o1, LengthCubTimeCubPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(LengthCubTimeCubPerMass o1, PerLengthCubTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Mass operator*(PerLengthCubTimeCub o1, LengthCubTimeCubMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(LengthCubTimeCubMass o1, PerLengthCubTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthCubTimeCub perlengthcubtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthcubtimecub.HasMinValue && perlengthcubtimecub.Value_ < perlengthcubtimecub.MinValue)
        {
            fail = true;
        }

        if (perlengthcubtimecub.HasMaxValue && perlengthcubtimecub.Value_ > perlengthcubtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthCubTimeCub is outside its bounds.");
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
    