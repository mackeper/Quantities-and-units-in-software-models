
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class PerLengthTimeCub : Quantity, IEquatable<PerLengthTimeCub>, IComparable
    {
    internal PerLengthTimeCub(double value) : base(value, 2)
    {
        PerLengthTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal PerLengthTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        PerLengthTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public PerLengthTimeCub(PerLengthTimeCub other) : base(other)
    {
        PerLengthTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthTimeCub"))
        {
            switch(FakeDatabase.Units["PerLengthTimeCub"])
            {
				      case "percentimetercubsecondcub": displayUnit_ = percentimetercubsecondcub_; break;
				      case "permillimetercubsecondcub": displayUnit_ = permillimetercubsecondcub_; break;
				      case "permetercubsecondcub": displayUnit_ = permetercubsecondcub_; break;
				      case "perinchcubsecondcub": displayUnit_ = perinchcubsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ percentimetercubsecondcub_ = new Unit_("PerCentimeterCubSecondCub", "/cm³ s³", 1.0);
	private static Unit_ permillimetercubsecondcub_ = new Unit_("PerMillimeterCubSecondCub", "/mm³ s³", 0.1);
	private static Unit_ permetercubsecondcub_ = new Unit_("PerMeterCubSecondCub", "/m³ s³", 100.0);
	private static Unit_ perinchcubsecondcub_ = new Unit_("PerInchCubSecondCub", "/in³ s³", 2.56);
	private static Unit_ platformUnit_ = percentimetercubsecondcub_;
	private static Unit_ displayUnit_ = percentimetercubsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(PerLengthTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(PerLengthTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is PerLengthTimeCub other)) throw new ArgumentException("Object is not a PerLengthTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(PerLengthTimeCub l1, PerLengthTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(PerLengthTimeCub l1, PerLengthTimeCub l2) => !(l1 == l2);
    public static bool operator <(PerLengthTimeCub l1, PerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(PerLengthTimeCub l1, PerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(PerLengthTimeCub l1, PerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(PerLengthTimeCub l1, PerLengthTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static PerLengthTimeCub FromPerCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthTimeCub(value * percentimetercubsecondcub_.Factor, minValue * percentimetercubsecondcub_.Factor, maxValue * percentimetercubsecondcub_.Factor);
		public static PerLengthTimeCub FromPerCentimeterCubSecondCubs(double value) => new PerLengthTimeCub(value * percentimetercubsecondcub_.Factor);
		public double GetValueInPerCentimeterCubSecondCubs() => Value_ / percentimetercubsecondcub_.Factor;
		public static PerLengthTimeCub FromPerMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthTimeCub(value * permillimetercubsecondcub_.Factor, minValue * permillimetercubsecondcub_.Factor, maxValue * permillimetercubsecondcub_.Factor);
		public static PerLengthTimeCub FromPerMillimeterCubSecondCubs(double value) => new PerLengthTimeCub(value * permillimetercubsecondcub_.Factor);
		public double GetValueInPerMillimeterCubSecondCubs() => Value_ / permillimetercubsecondcub_.Factor;
		public static PerLengthTimeCub FromPerMeterCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthTimeCub(value * permetercubsecondcub_.Factor, minValue * permetercubsecondcub_.Factor, maxValue * permetercubsecondcub_.Factor);
		public static PerLengthTimeCub FromPerMeterCubSecondCubs(double value) => new PerLengthTimeCub(value * permetercubsecondcub_.Factor);
		public double GetValueInPerMeterCubSecondCubs() => Value_ / permetercubsecondcub_.Factor;
		public static PerLengthTimeCub FromPerInchCubSecondCubs(double value, double minValue, double maxValue) => new PerLengthTimeCub(value * perinchcubsecondcub_.Factor, minValue * perinchcubsecondcub_.Factor, maxValue * perinchcubsecondcub_.Factor);
		public static PerLengthTimeCub FromPerInchCubSecondCubs(double value) => new PerLengthTimeCub(value * perinchcubsecondcub_.Factor);
		public double GetValueInPerInchCubSecondCubs() => Value_ / perinchcubsecondcub_.Factor;

#endregion

#region arithmetic
		public static PerLengthTimeCub operator+(PerLengthTimeCub o1, PerLengthTimeCub o2) => new PerLengthTimeCub(o1.Value_ + o2.Value_);
		public static PerLengthTimeCub operator-(PerLengthTimeCub o1, PerLengthTimeCub o2) => new PerLengthTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(PerLengthTimeCub o1, PerLengthTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerLengthSqr operator*(PerLengthTimeCub o1, TimeCubPerLength o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		public static PerLengthSqr operator*(TimeCubPerLength o1, PerLengthTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerMassTime operator/(PerLengthTimeCub o1, MassPerLengthTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(MassPerLengthTimeSqr o1, PerLengthTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthSqr operator*(PerLengthTimeCub o1, TimeSqrMassPerLength o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthSqr operator*(TimeSqrMassPerLength o1, PerLengthTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator/(PerLengthTimeCub o1, PerMassTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(PerMassTimeCub o1, PerLengthTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(PerLengthTimeCub o1, TimeCubPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeCubPerMass o1, PerLengthTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static PerLengthMass operator/(PerLengthTimeCub o1, MassPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(MassPerTimeCub o1, PerLengthTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator*(PerLengthTimeCub o1, TimeCubMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeCubMass o1, PerLengthTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthSqr operator/(PerLengthTimeCub o1, LengthPerMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrTimePerMass operator/(LengthPerMassTimeSqr o1, PerLengthTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator*(PerLengthTimeCub o1, TimeSqrLengthPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
		public static PerMassTime operator*(TimeSqrLengthPerMass o1, PerLengthTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthSqr operator/(PerLengthTimeCub o1, LengthPerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		public static Area operator/(LengthPerTimeCub o1, PerLengthTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		
		public static Dimensionless operator*(PerLengthTimeCub o1, TimeCubLength o2) => new Dimensionless(o1.Value_ * o2.Value_);
		public static Dimensionless operator*(TimeCubLength o1, PerLengthTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthSqr operator/(PerLengthTimeCub o1, Force o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMassTime operator/(Force o1, PerLengthTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
		
		public static MassPerTime operator*(PerLengthTimeCub o1, TimeSqrLengthMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
		public static MassPerTime operator*(TimeSqrLengthMass o1, PerLengthTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
		
		public static MassPerTimeSqrLengthCub operator/(PerLengthTimeCub o1, LengthSqrPerMassTime o2) => new MassPerTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrPerMass operator/(LengthSqrPerMassTime o1, PerLengthTimeCub o2) => new LengthCubTimeSqrPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTimeSqr operator*(PerLengthTimeCub o1, LengthSqrTimePerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthPerMassTimeSqr operator*(LengthSqrTimePerMass o1, PerLengthTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static PerTimeLengthCub operator/(PerLengthTimeCub o1, QDose o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTime operator/(QDose o1, PerLengthTimeCub o2) => new LengthCubTime(o1.Value_ / o2.Value_);
		
		public static Speed operator*(PerLengthTimeCub o1, LengthSqrTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
		public static Speed operator*(LengthSqrTimeSqr o1, PerLengthTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
		
		public static PerMassTimeSqrLengthCub operator/(PerLengthTimeCub o1, LengthSqrMassPerTime o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimeSqrMass operator/(LengthSqrMassPerTime o1, PerLengthTimeCub o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
		
		public static Force operator*(PerLengthTimeCub o1, LengthSqrMassTime o2) => new Force(o1.Value_ * o2.Value_);
		public static Force operator*(LengthSqrMassTime o1, PerLengthTimeCub o2) => new Force(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeCub operator*(PerLengthTimeCub o1, LengthCubPerMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeCub operator*(LengthCubPerMass o1, PerLengthTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
		
		public static QDose operator*(PerLengthTimeCub o1, LengthCubTime o2) => new QDose(o1.Value_ * o2.Value_);
		public static QDose operator*(LengthCubTime o1, PerLengthTimeCub o2) => new QDose(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeCub operator*(PerLengthTimeCub o1, LengthCubMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeCub operator*(LengthCubMass o1, PerLengthTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator/(PerLengthTimeCub o1, PerMassTimeLengthCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrPerMassLengthSqr operator/(PerMassTimeLengthCub o1, PerLengthTimeCub o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerTime operator/(PerLengthTimeCub o1, PerTimeSqrLengthCub o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthSqr operator/(PerTimeSqrLengthCub o1, PerLengthTimeCub o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator/(PerLengthTimeCub o1, MassPerTimeLengthCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrMassPerLengthSqr operator/(MassPerTimeLengthCub o1, PerLengthTimeCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator/(PerLengthTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerLengthMass operator/(PerMassLengthSqrTimeSqr o1, PerLengthTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassTimeLengthCub operator*(PerLengthTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		public static PerMassTimeLengthCub operator*(TimeSqrPerMassLengthSqr o1, PerLengthTimeCub o2) => new PerMassTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static Length operator/(PerLengthTimeCub o1, PerLengthSqrTimeCub o2) => new Length(o1.Value_ / o2.Value_);
		public static PerLength operator/(PerLengthSqrTimeCub o1, PerLengthTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
		
		public static PerLengthCub operator*(PerLengthTimeCub o1, TimeCubPerLengthSqr o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		public static PerLengthCub operator*(TimeCubPerLengthSqr o1, PerLengthTimeCub o2) => new PerLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthPerMassTime operator/(PerLengthTimeCub o1, MassPerLengthSqrTimeSqr o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLength operator/(MassPerLengthSqrTimeSqr o1, PerLengthTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		
		public static MassPerTimeLengthCub operator*(PerLengthTimeCub o1, TimeSqrMassPerLengthSqr o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		public static MassPerTimeLengthCub operator*(TimeSqrMassPerLengthSqr o1, PerLengthTimeCub o2) => new MassPerTimeLengthCub(o1.Value_ * o2.Value_);
		
		public static Mass operator/(PerLengthTimeCub o1, PerLengthMassTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(PerLengthMassTimeCub o1, PerLengthTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthSqr operator*(PerLengthTimeCub o1, TimeCubPerLengthMass o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		public static PerMassLengthSqr operator*(TimeCubPerLengthMass o1, PerLengthTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
		
		public static PerMass operator/(PerLengthTimeCub o1, MassPerLengthTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(MassPerLengthTimeCub o1, PerLengthTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthSqr operator*(PerLengthTimeCub o1, TimeCubMassPerLength o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		public static MassPerLengthSqr operator*(TimeCubMassPerLength o1, PerLengthTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
		
		public static MassPerLengthSqr operator/(PerLengthTimeCub o1, LengthPerMassTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrPerMass operator/(LengthPerMassTimeCub o1, PerLengthTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(PerLengthTimeCub o1, TimeCubLengthPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeCubLengthPerMass o1, PerLengthTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthSqr operator/(PerLengthTimeCub o1, LengthMassPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		public static LengthSqrMass operator/(LengthMassPerTimeCub o1, PerLengthTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		
		public static Mass operator*(PerLengthTimeCub o1, TimeCubLengthMass o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeCubLengthMass o1, PerLengthTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static MassPerTimeLengthCub operator/(PerLengthTimeCub o1, LengthSqrPerMassTimeSqr o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubTimePerMass operator/(LengthSqrPerMassTimeSqr o1, PerLengthTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMassTime operator*(PerLengthTimeCub o1, LengthSqrTimeSqrPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		public static LengthPerMassTime operator*(LengthSqrTimeSqrPerMass o1, PerLengthTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
		
		public static PerLengthCub operator/(PerLengthTimeCub o1, LengthSqrPerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
		public static Volume operator/(LengthSqrPerTimeCub o1, PerLengthTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
		
		public static Length operator*(PerLengthTimeCub o1, TimeCubLengthSqr o2) => new Length(o1.Value_ * o2.Value_);
		public static Length operator*(TimeCubLengthSqr o1, PerLengthTimeCub o2) => new Length(o1.Value_ * o2.Value_);
		
		public static PerMassTimeLengthCub operator/(PerLengthTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMassTime operator/(LengthSqrMassPerTimeSqr o1, PerLengthTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		
		public static LengthMassPerTime operator*(PerLengthTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		public static LengthMassPerTime operator*(LengthSqrTimeSqrMass o1, PerLengthTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTimeSqr operator*(PerLengthTimeCub o1, LengthCubTimePerMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTimeSqr operator*(LengthCubTimePerMass o1, PerLengthTimeCub o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerTime operator*(PerLengthTimeCub o1, LengthCubTimeSqr o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerTime operator*(LengthCubTimeSqr o1, PerLengthTimeCub o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTimeSqr operator*(PerLengthTimeCub o1, LengthCubMassTime o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTimeSqr operator*(LengthCubMassTime o1, PerLengthTimeCub o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator/(PerLengthTimeCub o1, PerMassTimeSqrLengthCub o2) => new LengthSqrMassPerTime(o1.Value_ / o2.Value_);
		public static TimePerMassLengthSqr operator/(PerMassTimeSqrLengthCub o1, PerLengthTimeCub o2) => new TimePerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static Area operator/(PerLengthTimeCub o1, PerLengthCubTimeCub o2) => new Area(o1.Value_ / o2.Value_);
		public static PerLengthSqr operator/(PerLengthCubTimeCub o1, PerLengthTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMassTime operator/(PerLengthTimeCub o1, MassPerTimeSqrLengthCub o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
		public static MassTimePerLengthSqr operator/(MassPerTimeSqrLengthCub o1, PerLengthTimeCub o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthMass operator/(PerLengthTimeCub o1, PerMassLengthSqrTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
		public static PerLengthMass operator/(PerMassLengthSqrTimeCub o1, PerLengthTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		
		public static PerMassLengthCub operator*(PerLengthTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		public static PerMassLengthCub operator*(TimeCubPerMassLengthSqr o1, PerLengthTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
		
		public static LengthPerMass operator/(PerLengthTimeCub o1, MassPerLengthSqrTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		public static MassPerLength operator/(MassPerLengthSqrTimeCub o1, PerLengthTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
		
		public static Density operator*(PerLengthTimeCub o1, TimeCubMassPerLengthSqr o2) => new Density(o1.Value_ * o2.Value_);
		public static Density operator*(TimeCubMassPerLengthSqr o1, PerLengthTimeCub o2) => new Density(o1.Value_ * o2.Value_);
		
		public static Density operator/(PerLengthTimeCub o1, LengthSqrPerMassTimeCub o2) => new Density(o1.Value_ / o2.Value_);
		public static LengthCubPerMass operator/(LengthSqrPerMassTimeCub o1, PerLengthTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
		
		public static LengthPerMass operator*(PerLengthTimeCub o1, TimeCubLengthSqrPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		public static LengthPerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
		
		public static PerMassLengthCub operator/(PerLengthTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
		public static LengthCubMass operator/(LengthSqrMassPerTimeCub o1, PerLengthTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
		
		public static LengthMass operator*(PerLengthTimeCub o1, TimeCubLengthSqrMass o2) => new LengthMass(o1.Value_ * o2.Value_);
		public static LengthMass operator*(TimeCubLengthSqrMass o1, PerLengthTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrPerMassTime operator*(PerLengthTimeCub o1, LengthCubTimeSqrPerMass o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		public static LengthSqrPerMassTime operator*(LengthCubTimeSqrPerMass o1, PerLengthTimeCub o2) => new LengthSqrPerMassTime(o1.Value_ * o2.Value_);
		
		public static Area operator*(PerLengthTimeCub o1, LengthCubTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		public static Area operator*(LengthCubTimeCub o1, PerLengthTimeCub o2) => new Area(o1.Value_ * o2.Value_);
		
		public static LengthSqrMassPerTime operator*(PerLengthTimeCub o1, LengthCubTimeSqrMass o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		public static LengthSqrMassPerTime operator*(LengthCubTimeSqrMass o1, PerLengthTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator/(PerLengthTimeCub o1, PerMassLengthCubTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
		public static PerMassLengthSqr operator/(PerMassLengthCubTimeCub o1, PerLengthTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator/(PerLengthTimeCub o1, MassPerLengthCubTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthSqr operator/(MassPerLengthCubTimeCub o1, PerLengthTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
		
		public static LengthSqrPerMass operator*(PerLengthTimeCub o1, LengthCubTimeCubPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		public static LengthSqrPerMass operator*(LengthCubTimeCubPerMass o1, PerLengthTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
		
		public static LengthSqrMass operator*(PerLengthTimeCub o1, LengthCubTimeCubMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		public static LengthSqrMass operator*(LengthCubTimeCubMass o1, PerLengthTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(PerLengthTimeCub perlengthtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (perlengthtimecub.HasMinValue && perlengthtimecub.Value_ < perlengthtimecub.MinValue)
        {
            fail = true;
        }

        if (perlengthtimecub.HasMaxValue && perlengthtimecub.Value_ > perlengthtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("PerLengthTimeCub is outside its bounds.");
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
    