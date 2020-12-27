
// GENERATE FILE! (15/04/2020 13:18:18)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class QDose : Quantity, IEquatable<QDose>, IComparable
    {
    internal QDose(double value) : base(value, 2)
    {
        QDose.ImportDisplayUnitFromDatabase_();
    }
    internal QDose(double value, double minValue, double maxValue) : base(value, 2)
    {
        QDose.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public QDose(QDose other) : base(other)
    {
        QDose.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("QDose"))
        {
            switch(FakeDatabase.Units["QDose"])
            {
				      case "centimetersqrpersecondsqr": displayUnit_ = centimetersqrpersecondsqr_; break;
				      case "millimetersqrpersecondsqr": displayUnit_ = millimetersqrpersecondsqr_; break;
				      case "metersqrpersecondsqr": displayUnit_ = metersqrpersecondsqr_; break;
				      case "inchsqrpersecondsqr": displayUnit_ = inchsqrpersecondsqr_; break;
				      case "gray": displayUnit_ = gray_; break;
				      case "centigray": displayUnit_ = centigray_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetersqrpersecondsqr_ = new Unit_("CentimeterSqrPerSecondSqr", "cm²/s²", 1.0);
	private static Unit_ millimetersqrpersecondsqr_ = new Unit_("MillimeterSqrPerSecondSqr", "mm²/s²", 0.010000000000000002);
	private static Unit_ metersqrpersecondsqr_ = new Unit_("MeterSqrPerSecondSqr", "m²/s²", 10000.0);
	private static Unit_ inchsqrpersecondsqr_ = new Unit_("InchSqrPerSecondSqr", "in²/s²", 6.5536);
	private static Unit_ gray_ = new Unit_("Gray", "Gy", 10000);
	private static Unit_ centigray_ = new Unit_("Centigray", "cGy", 100);
	private static Unit_ platformUnit_ = centimetersqrpersecondsqr_;
	private static Unit_ displayUnit_ = centimetersqrpersecondsqr_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(QDose other) => other is object && Equals((object)other);
    public int CompareTo(QDose other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is QDose other)) throw new ArgumentException("Object is not a QDose.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(QDose l1, QDose l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(QDose l1, QDose l2) => !(l1 == l2);
    public static bool operator <(QDose l1, QDose l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(QDose l1, QDose l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(QDose l1, QDose l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(QDose l1, QDose l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static QDose FromCentimeterSqrPerSecondSqrs(double value, double minValue, double maxValue) => new QDose(value * centimetersqrpersecondsqr_.Factor, minValue * centimetersqrpersecondsqr_.Factor, maxValue * centimetersqrpersecondsqr_.Factor);
		public static QDose FromCentimeterSqrPerSecondSqrs(double value) => new QDose(value * centimetersqrpersecondsqr_.Factor);
		public double GetValueInCentimeterSqrPerSecondSqrs() => Value_ / centimetersqrpersecondsqr_.Factor;
		public static QDose FromMillimeterSqrPerSecondSqrs(double value, double minValue, double maxValue) => new QDose(value * millimetersqrpersecondsqr_.Factor, minValue * millimetersqrpersecondsqr_.Factor, maxValue * millimetersqrpersecondsqr_.Factor);
		public static QDose FromMillimeterSqrPerSecondSqrs(double value) => new QDose(value * millimetersqrpersecondsqr_.Factor);
		public double GetValueInMillimeterSqrPerSecondSqrs() => Value_ / millimetersqrpersecondsqr_.Factor;
		public static QDose FromMeterSqrPerSecondSqrs(double value, double minValue, double maxValue) => new QDose(value * metersqrpersecondsqr_.Factor, minValue * metersqrpersecondsqr_.Factor, maxValue * metersqrpersecondsqr_.Factor);
		public static QDose FromMeterSqrPerSecondSqrs(double value) => new QDose(value * metersqrpersecondsqr_.Factor);
		public double GetValueInMeterSqrPerSecondSqrs() => Value_ / metersqrpersecondsqr_.Factor;
		public static QDose FromInchSqrPerSecondSqrs(double value, double minValue, double maxValue) => new QDose(value * inchsqrpersecondsqr_.Factor, minValue * inchsqrpersecondsqr_.Factor, maxValue * inchsqrpersecondsqr_.Factor);
		public static QDose FromInchSqrPerSecondSqrs(double value) => new QDose(value * inchsqrpersecondsqr_.Factor);
		public double GetValueInInchSqrPerSecondSqrs() => Value_ / inchsqrpersecondsqr_.Factor;
		public static QDose FromGrays(double value, double minValue, double maxValue) => new QDose(value * gray_.Factor, minValue * gray_.Factor, maxValue * gray_.Factor);
		public static QDose FromGrays(double value) => new QDose(value * gray_.Factor);
		public double GetValueInGrays() => Value_ / gray_.Factor;
		public static QDose FromCentigrays(double value, double minValue, double maxValue) => new QDose(value * centigray_.Factor, minValue * centigray_.Factor, maxValue * centigray_.Factor);
		public static QDose FromCentigrays(double value) => new QDose(value * centigray_.Factor);
		public double GetValueInCentigrays() => Value_ / centigray_.Factor;

#endregion

#region arithmetic
		public static QDose operator+(QDose o1, QDose o2) => new QDose(o1.Value_ + o2.Value_);
		public static QDose operator-(QDose o1, QDose o2) => new QDose(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(QDose o1, QDose o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static PerMassTime operator/(QDose o1, LengthSqrMassPerTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
		public static MassTime operator/(LengthSqrMassPerTime o1, QDose o2) => new MassTime(o1.Value_ / o2.Value_);
		
		public static PerMassTimeCub operator/(QDose o1, LengthSqrMassTime o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubMass operator/(LengthSqrMassTime o1, QDose o2) => new TimeCubMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeSqr operator/(QDose o1, LengthCubPerMass o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthPerMass operator/(LengthCubPerMass o1, QDose o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLengthTime operator/(QDose o1, LengthCubPerTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTime operator/(LengthCubPerTime o1, QDose o2) => new LengthTime(o1.Value_ / o2.Value_);
		
		public static PerLengthTimeCub operator/(QDose o1, LengthCubTime o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLength operator/(LengthCubTime o1, QDose o2) => new TimeCubLength(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeSqr operator/(QDose o1, LengthCubMass o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
		public static TimeSqrLengthMass operator/(LengthCubMass o1, QDose o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator*(QDose o1, PerMassTimeLengthCub o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		public static PerLengthMassTimeCub operator*(PerMassTimeLengthCub o1, QDose o2) => new PerLengthMassTimeCub(o1.Value_ * o2.Value_);
		
		public static PerLengthMassTime operator*(QDose o1, TimePerMassLengthCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		public static PerLengthMassTime operator*(TimePerMassLengthCub o1, QDose o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
		
		public static PerLength operator*(QDose o1, TimeSqrPerLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
		public static PerLength operator*(TimeSqrPerLengthCub o1, QDose o2) => new PerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTimeCub operator*(QDose o1, MassPerTimeLengthCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		public static MassPerLengthTimeCub operator*(MassPerTimeLengthCub o1, QDose o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
		
		public static MassPerLengthTime operator*(QDose o1, MassTimePerLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		public static MassPerLengthTime operator*(MassTimePerLengthCub o1, QDose o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
		
		public static PerMass operator*(QDose o1, TimeSqrPerMassLengthSqr o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(TimeSqrPerMassLengthSqr o1, QDose o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Time operator*(QDose o1, TimeCubPerLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
		public static Time operator*(TimeCubPerLengthSqr o1, QDose o2) => new Time(o1.Value_ * o2.Value_);
		
		public static Mass operator*(QDose o1, TimeSqrMassPerLengthSqr o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(TimeSqrMassPerLengthSqr o1, QDose o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static LengthCubMassTime operator/(QDose o1, PerLengthMassTimeCub o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
		public static PerMassTimeLengthCub operator/(PerLengthMassTimeCub o1, QDose o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthTimePerMass operator*(QDose o1, TimeCubPerLengthMass o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		public static LengthTimePerMass operator*(TimeCubPerLengthMass o1, QDose o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthCubTimePerMass operator/(QDose o1, MassPerLengthTimeCub o2) => new LengthCubTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTimeLengthCub operator/(MassPerLengthTimeCub o1, QDose o2) => new MassPerTimeLengthCub(o1.Value_ / o2.Value_);
		
		public static LengthMassTime operator*(QDose o1, TimeCubMassPerLength o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		public static LengthMassTime operator*(TimeCubMassPerLength o1, QDose o2) => new LengthMassTime(o1.Value_ * o2.Value_);
		
		public static LengthMassTime operator/(QDose o1, LengthPerMassTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		public static PerLengthMassTime operator/(LengthPerMassTimeCub o1, QDose o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		
		public static LengthCubTimePerMass operator*(QDose o1, TimeCubLengthPerMass o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		public static LengthCubTimePerMass operator*(TimeCubLengthPerMass o1, QDose o2) => new LengthCubTimePerMass(o1.Value_ * o2.Value_);
		
		public static LengthTimePerMass operator/(QDose o1, LengthMassPerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		public static MassPerLengthTime operator/(LengthMassPerTimeCub o1, QDose o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		
		public static LengthCubMassTime operator*(QDose o1, TimeCubLengthMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		public static LengthCubMassTime operator*(TimeCubLengthMass o1, QDose o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
		
		public static Mass operator/(QDose o1, LengthSqrPerMassTimeSqr o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(LengthSqrPerMassTimeSqr o1, QDose o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static Time operator/(QDose o1, LengthSqrPerTimeCub o2) => new Time(o1.Value_ / o2.Value_);
		public static PerTime operator/(LengthSqrPerTimeCub o1, QDose o2) => new PerTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(QDose o1, LengthSqrMassPerTimeSqr o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(LengthSqrMassPerTimeSqr o1, QDose o2) => new Mass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTime operator/(QDose o1, LengthCubPerMassTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
		public static LengthTimePerMass operator/(LengthCubPerMassTime o1, QDose o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
		
		public static MassPerLengthTimeCub operator/(QDose o1, LengthCubTimePerMass o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthPerMass operator/(LengthCubTimePerMass o1, QDose o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
		
		public static PerLength operator/(QDose o1, LengthCubPerTimeSqr o2) => new PerLength(o1.Value_ / o2.Value_);
		public static Length operator/(LengthCubPerTimeSqr o1, QDose o2) => new Length(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTime operator/(QDose o1, LengthCubMassPerTime o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
		public static LengthMassTime operator/(LengthCubMassPerTime o1, QDose o2) => new LengthMassTime(o1.Value_ / o2.Value_);
		
		public static PerLengthMassTimeCub operator/(QDose o1, LengthCubMassTime o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
		public static TimeCubLengthMass operator/(LengthCubMassTime o1, QDose o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator*(QDose o1, TimeSqrPerMassLengthCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		public static PerLengthMass operator*(TimeSqrPerMassLengthCub o1, QDose o2) => new PerLengthMass(o1.Value_ * o2.Value_);
		
		public static TimePerLength operator*(QDose o1, TimeCubPerLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
		public static TimePerLength operator*(TimeCubPerLengthCub o1, QDose o2) => new TimePerLength(o1.Value_ * o2.Value_);
		
		public static MassPerLength operator*(QDose o1, TimeSqrMassPerLengthCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
		public static MassPerLength operator*(TimeSqrMassPerLengthCub o1, QDose o2) => new MassPerLength(o1.Value_ * o2.Value_);
		
		public static TimePerMass operator*(QDose o1, TimeCubPerMassLengthSqr o2) => new TimePerMass(o1.Value_ * o2.Value_);
		public static TimePerMass operator*(TimeCubPerMassLengthSqr o1, QDose o2) => new TimePerMass(o1.Value_ * o2.Value_);
		
		public static MassTime operator*(QDose o1, TimeCubMassPerLengthSqr o2) => new MassTime(o1.Value_ * o2.Value_);
		public static MassTime operator*(TimeCubMassPerLengthSqr o1, QDose o2) => new MassTime(o1.Value_ * o2.Value_);
		
		public static MassTime operator/(QDose o1, LengthSqrPerMassTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
		public static PerMassTime operator/(LengthSqrPerMassTimeCub o1, QDose o2) => new PerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(QDose o1, LengthSqrMassPerTimeCub o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthSqrMassPerTimeCub o1, QDose o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static MassPerLength operator/(QDose o1, LengthCubPerMassTimeSqr o2) => new MassPerLength(o1.Value_ / o2.Value_);
		public static LengthPerMass operator/(LengthCubPerMassTimeSqr o1, QDose o2) => new LengthPerMass(o1.Value_ / o2.Value_);
		
		public static TimePerLength operator/(QDose o1, LengthCubPerTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
		public static Speed operator/(LengthCubPerTimeCub o1, QDose o2) => new Speed(o1.Value_ / o2.Value_);
		
		public static PerLengthMass operator/(QDose o1, LengthCubMassPerTimeSqr o2) => new PerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMass operator/(LengthCubMassPerTimeSqr o1, QDose o2) => new LengthMass(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator*(QDose o1, TimeCubPerMassLengthCub o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		public static TimePerLengthMass operator*(TimeCubPerMassLengthCub o1, QDose o2) => new TimePerLengthMass(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator*(QDose o1, TimeCubMassPerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		public static MassTimePerLength operator*(TimeCubMassPerLengthCub o1, QDose o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
		
		public static MassTimePerLength operator/(QDose o1, LengthCubPerMassTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
		public static LengthPerMassTime operator/(LengthCubPerMassTimeCub o1, QDose o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
		
		public static TimePerLengthMass operator/(QDose o1, LengthCubMassPerTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
		public static LengthMassPerTime operator/(LengthCubMassPerTimeCub o1, QDose o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(QDose qdose, bool throwOnFail=true)
    {
        bool fail = false;
        if (qdose.HasMinValue && qdose.Value_ < qdose.MinValue)
        {
            fail = true;
        }

        if (qdose.HasMaxValue && qdose.Value_ > qdose.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("QDose is outside its bounds.");
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
    