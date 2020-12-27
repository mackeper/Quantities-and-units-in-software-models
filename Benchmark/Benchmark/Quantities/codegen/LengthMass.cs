
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthMass : Quantity, IEquatable<LengthMass>, IComparable
  {  
    internal LengthMass(double value) : base(value, 2)
    {
      LengthMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthMass(LengthMass other) : base(other)
    {
      LengthMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthMass"))
    {
      switch(FakeDatabase.Units["LengthMass"])
      {
        case "centimeterkilogram": displayUnit_ = centimeterkilogram_; break;
        case "millimeterkilogram": displayUnit_ = millimeterkilogram_; break;
        case "meterkilogram": displayUnit_ = meterkilogram_; break;
        case "inchkilogram": displayUnit_ = inchkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterkilogram_ = new Unit_("CentimeterKilogram", "cm kg", 1, 0);
  private static Unit_ millimeterkilogram_ = new Unit_("MillimeterKilogram", "mm kg", 0.1, 0);
  private static Unit_ meterkilogram_ = new Unit_("MeterKilogram", "m kg", 100, 0);
  private static Unit_ inchkilogram_ = new Unit_("InchKilogram", "in kg", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterkilogram_;
  private static Unit_ displayUnit_ = centimeterkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthMass other && Equals(other);
  public bool Equals(LengthMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthMass other)) throw new ArgumentException("Object is not a LengthMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthMass l1, LengthMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthMass l1, LengthMass l2) => !(l1 == l2);
  public static bool operator <(LengthMass l1, LengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthMass l1, LengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthMass l1, LengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthMass l1, LengthMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthMass FromCentimeterKilograms(double value, double minValue, double maxValue) => new LengthMass((value + centimeterkilogram_.Offset) * centimeterkilogram_.Factor, minValue * centimeterkilogram_.Factor, maxValue * centimeterkilogram_.Factor);
  public static LengthMass FromCentimeterKilograms(double value) => new LengthMass((value + centimeterkilogram_.Offset) * centimeterkilogram_.Factor);
  public double GetValueInCentimeterKilograms() => (Value_ - centimeterkilogram_.Offset) / centimeterkilogram_.Factor;
  public static LengthMass FromMillimeterKilograms(double value, double minValue, double maxValue) => new LengthMass((value + millimeterkilogram_.Offset) * millimeterkilogram_.Factor, minValue * millimeterkilogram_.Factor, maxValue * millimeterkilogram_.Factor);
  public static LengthMass FromMillimeterKilograms(double value) => new LengthMass((value + millimeterkilogram_.Offset) * millimeterkilogram_.Factor);
  public double GetValueInMillimeterKilograms() => (Value_ - millimeterkilogram_.Offset) / millimeterkilogram_.Factor;
  public static LengthMass FromMeterKilograms(double value, double minValue, double maxValue) => new LengthMass((value + meterkilogram_.Offset) * meterkilogram_.Factor, minValue * meterkilogram_.Factor, maxValue * meterkilogram_.Factor);
  public static LengthMass FromMeterKilograms(double value) => new LengthMass((value + meterkilogram_.Offset) * meterkilogram_.Factor);
  public double GetValueInMeterKilograms() => (Value_ - meterkilogram_.Offset) / meterkilogram_.Factor;
  public static LengthMass FromInchKilograms(double value, double minValue, double maxValue) => new LengthMass((value + inchkilogram_.Offset) * inchkilogram_.Factor, minValue * inchkilogram_.Factor, maxValue * inchkilogram_.Factor);
  public static LengthMass FromInchKilograms(double value) => new LengthMass((value + inchkilogram_.Offset) * inchkilogram_.Factor);
  public double GetValueInInchKilograms() => (Value_ - inchkilogram_.Offset) / inchkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthMass operator+(LengthMass o1, LengthMass o2) => new LengthMass(o1.Value_ + o2.Value_);
  public static LengthMass operator-(LengthMass o1, LengthMass o2) => new LengthMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthMass o1, LengthMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(LengthMass o1, Area o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(Area o1, LengthMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static MassPerLength operator/(LengthMass o1, Area o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(Area o1, LengthMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator*(LengthMass o1, PerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(PerLengthCub o1, LengthMass o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLength operator*(LengthMass o1, PerMassLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassLengthSqr o1, LengthMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthMass o1, PerTimeLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerTimeLengthSqr o1, LengthMass o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator/(LengthMass o1, PerTimeLengthSqr o2) => new LengthCubMassTime(o1.Value_ / o2.Value_);
  public static PerMassTimeLengthCub operator/(PerTimeLengthSqr o1, LengthMass o2) => new PerMassTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator*(LengthMass o1, TimePerLengthSqr o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimePerLengthSqr o1, LengthMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator/(LengthMass o1, TimePerLengthSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(TimePerLengthSqr o1, LengthMass o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static Volume operator/(LengthMass o1, MassPerLengthSqr o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(MassPerLengthSqr o1, LengthMass o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTime operator*(LengthMass o1, PerLengthMassTime o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerLengthMassTime o1, LengthMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthMass o1, TimePerLengthMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerLengthMass o1, LengthMass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthMass o1, PerLengthTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(PerLengthTimeSqr o1, LengthMass o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthMass o1, PerLengthTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(PerLengthTimeSqr o1, LengthMass o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator*(LengthMass o1, TimeSqrPerLength o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrPerLength o1, LengthMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator/(LengthMass o1, TimeSqrPerLength o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrPerLength o1, LengthMass o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTime operator/(LengthMass o1, MassPerLengthTime o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthSqr operator/(MassPerLengthTime o1, LengthMass o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator/(LengthMass o1, MassTimePerLength o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthSqr operator/(MassTimePerLength o1, LengthMass o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator*(LengthMass o1, PerMassTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerMassTimeSqr o1, LengthMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthMass o1, TimeSqrPerMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrPerMass o1, LengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(LengthMass o1, PerTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(PerTimeCub o1, LengthMass o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(LengthMass o1, PerTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(PerTimeCub o1, LengthMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(LengthMass o1, TimeCub o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCub o1, LengthMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthMass o1, TimeCub o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCub o1, LengthMass o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(LengthMass o1, MassPerTimeSqr o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(MassPerTimeSqr o1, LengthMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(LengthMass o1, TimeSqrMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrMass o1, LengthMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTime operator*(LengthMass o1, LengthPerMassTime o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrPerTime operator*(LengthPerMassTime o1, LengthMass o2) => new LengthSqrPerTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrTime operator*(LengthMass o1, LengthTimePerMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  public static LengthSqrTime operator*(LengthTimePerMass o1, LengthMass o2) => new LengthSqrTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(LengthMass o1, Acceleration o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(Acceleration o1, LengthMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator/(LengthMass o1, Acceleration o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(Acceleration o1, LengthMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(LengthMass o1, TimeSqrLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeSqrLength o1, LengthMass o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator/(LengthMass o1, TimeSqrLength o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(TimeSqrLength o1, LengthMass o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(LengthMass o1, LengthMassPerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthMassPerTime o1, LengthMass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthMass o1, LengthMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthMassTime o1, LengthMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthMass o1, LengthSqrPerMass o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(LengthSqrPerMass o1, LengthMass o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator*(LengthMass o1, LengthSqrPerTime o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrPerTime o1, LengthMass o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator/(LengthMass o1, LengthSqrPerTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthSqrPerTime o1, LengthMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassTime operator*(LengthMass o1, LengthSqrTime o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static LengthCubMassTime operator*(LengthSqrTime o1, LengthMass o2) => new LengthCubMassTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator/(LengthMass o1, LengthSqrTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrTime o1, LengthMass o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthMass o1, LengthSqrMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrMass o1, LengthMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqr operator/(LengthMass o1, Volume o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(Volume o1, LengthMass o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator*(LengthMass o1, PerMassLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(PerMassLengthCub o1, LengthMass o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(LengthMass o1, PerTimeLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(PerTimeLengthCub o1, LengthMass o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassTimePerLengthSqr operator*(LengthMass o1, TimePerLengthCub o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  public static MassTimePerLengthSqr operator*(TimePerLengthCub o1, LengthMass o2) => new MassTimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator*(LengthMass o1, PerMassTimeLengthSqr o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassTimeLengthSqr o1, LengthMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthMass o1, TimePerMassLengthSqr o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerMassLengthSqr o1, LengthMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthMass o1, PerLengthSqrTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(PerLengthSqrTimeSqr o1, LengthMass o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator/(LengthMass o1, PerLengthSqrTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqrLengthCub operator/(PerLengthSqrTimeSqr o1, LengthMass o2) => new PerMassTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator*(LengthMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrPerLengthSqr o1, LengthMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator/(LengthMass o1, TimeSqrPerLengthSqr o2) => new LengthCubMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthCub operator/(TimeSqrPerLengthSqr o1, LengthMass o2) => new TimeSqrPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTime operator/(LengthMass o1, MassPerTimeLengthSqr o2) => new LengthCubTime(o1.Value_ / o2.Value_);
  public static PerTimeLengthCub operator/(MassPerTimeLengthSqr o1, LengthMass o2) => new PerTimeLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator/(LengthMass o1, MassTimePerLengthSqr o2) => new LengthCubPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthCub operator/(MassTimePerLengthSqr o1, LengthMass o2) => new TimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator*(LengthMass o1, PerLengthMassTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerLengthMassTimeSqr o1, LengthMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthMass o1, TimeSqrPerLengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerLengthMass o1, LengthMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(LengthMass o1, PerLengthTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(PerLengthTimeCub o1, LengthMass o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthMass o1, PerLengthTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(PerLengthTimeCub o1, LengthMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator*(LengthMass o1, TimeCubPerLength o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubPerLength o1, LengthMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator/(LengthMass o1, TimeCubPerLength o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubPerLength o1, LengthMass o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqr operator/(LengthMass o1, MassPerLengthTimeSqr o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeSqr operator/(MassPerLengthTimeSqr o1, LengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static QDose operator/(LengthMass o1, TimeSqrMassPerLength o2) => new QDose(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthSqr operator/(TimeSqrMassPerLength o1, LengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator*(LengthMass o1, PerMassTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(PerMassTimeCub o1, LengthMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(LengthMass o1, TimeCubPerMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubPerMass o1, LengthMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(LengthMass o1, MassPerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(MassPerTimeCub o1, LengthMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(LengthMass o1, TimeCubMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubMass o1, LengthMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static QDose operator*(LengthMass o1, LengthPerMassTimeSqr o2) => new QDose(o1.Value_ * o2.Value_);
  public static QDose operator*(LengthPerMassTimeSqr o1, LengthMass o2) => new QDose(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqr operator*(LengthMass o1, TimeSqrLengthPerMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqr operator*(TimeSqrLengthPerMass o1, LengthMass o2) => new LengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(LengthMass o1, LengthPerTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(LengthPerTimeCub o1, LengthMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMass operator/(LengthMass o1, LengthPerTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthPerTimeCub o1, LengthMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(LengthMass o1, TimeCubLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubLength o1, LengthMass o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator/(LengthMass o1, TimeCubLength o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubLength o1, LengthMass o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(LengthMass o1, Force o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(Force o1, LengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthMass o1, TimeSqrLengthMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(TimeSqrLengthMass o1, LengthMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthMass o1, LengthSqrPerMassTime o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrPerMassTime o1, LengthMass o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static LengthCubTime operator*(LengthMass o1, LengthSqrTimePerMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  public static LengthCubTime operator*(LengthSqrTimePerMass o1, LengthMass o2) => new LengthCubTime(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(LengthMass o1, QDose o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(QDose o1, LengthMass o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator/(LengthMass o1, QDose o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(QDose o1, LengthMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqrMass operator*(LengthMass o1, LengthSqrTimeSqr o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqrMass operator*(LengthSqrTimeSqr o1, LengthMass o2) => new LengthCubTimeSqrMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator/(LengthMass o1, LengthSqrTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthSqrTimeSqr o1, LengthMass o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthMass o1, LengthSqrMassPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthSqrMassPerTime o1, LengthMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthMass o1, LengthSqrMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthSqrMassTime o1, LengthMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static MassTimePerLengthSqr operator/(LengthMass o1, LengthCubPerTime o2) => new MassTimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTime operator/(LengthCubPerTime o1, LengthMass o2) => new LengthSqrPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(LengthMass o1, LengthCubTime o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubTime o1, LengthMass o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(LengthMass o1, LengthCubMass o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubMass o1, LengthMass o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthMass o1, PerMassTimeLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(PerMassTimeLengthCub o1, LengthMass o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimePerLengthSqr operator*(LengthMass o1, TimePerMassLengthCub o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  public static TimePerLengthSqr operator*(TimePerMassLengthCub o1, LengthMass o2) => new TimePerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(LengthMass o1, PerTimeSqrLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(PerTimeSqrLengthCub o1, LengthMass o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator*(LengthMass o1, TimeSqrPerLengthCub o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLengthSqr operator*(TimeSqrPerLengthCub o1, LengthMass o2) => new TimeSqrMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthMass o1, PerMassLengthSqrTimeSqr o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerMassLengthSqrTimeSqr o1, LengthMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthMass o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerMassLengthSqr o1, LengthMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(LengthMass o1, PerLengthSqrTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(PerLengthSqrTimeCub o1, LengthMass o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthMass o1, PerLengthSqrTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthSqrTimeCub o1, LengthMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthMass o1, TimeCubPerLengthSqr o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubPerLengthSqr o1, LengthMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthMass o1, TimeCubPerLengthSqr o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerLengthSqr o1, LengthMass o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthMass o1, MassPerLengthSqrTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassPerLengthSqrTimeSqr o1, LengthMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthMass o1, TimeSqrMassPerLengthSqr o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrMassPerLengthSqr o1, LengthMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator*(LengthMass o1, PerLengthMassTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerLengthMassTimeCub o1, LengthMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthMass o1, TimeCubPerLengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerLengthMass o1, LengthMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthMass o1, MassPerLengthTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(MassPerLengthTimeCub o1, LengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(LengthMass o1, TimeCubMassPerLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubMassPerLength o1, LengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(LengthMass o1, LengthPerMassTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(LengthPerMassTimeCub o1, LengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthMass o1, TimeCubLengthPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubLengthPerMass o1, LengthMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthMass o1, LengthMassPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthMassPerTimeCub o1, LengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthMass o1, TimeCubLengthMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLengthMass o1, LengthMass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthMass o1, LengthSqrPerMassTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthSqrPerMassTimeSqr o1, LengthMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthMass o1, LengthSqrTimeSqrPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(LengthSqrTimeSqrPerMass o1, LengthMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(LengthMass o1, LengthSqrPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthSqrPerTimeCub o1, LengthMass o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator/(LengthMass o1, LengthSqrPerTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthSqrPerTimeCub o1, LengthMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(LengthMass o1, TimeCubLengthSqr o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeCubLengthSqr o1, LengthMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator/(LengthMass o1, TimeCubLengthSqr o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(TimeCubLengthSqr o1, LengthMass o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthMass o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthSqrMassPerTimeSqr o1, LengthMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthMass o1, LengthSqrTimeSqrMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthSqrTimeSqrMass o1, LengthMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLengthSqr operator/(LengthMass o1, LengthCubPerTimeSqr o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeSqr operator/(LengthCubPerTimeSqr o1, LengthMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(LengthMass o1, LengthCubTimeSqr o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubTimeSqr o1, LengthMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLengthSqr operator/(LengthMass o1, LengthCubMassPerTime o2) => new TimePerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTime operator/(LengthCubMassPerTime o1, LengthMass o2) => new LengthSqrPerTime(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthMass o1, LengthCubMassTime o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubMassTime o1, LengthMass o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator*(LengthMass o1, PerMassTimeSqrLengthCub o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeSqr operator*(PerMassTimeSqrLengthCub o1, LengthMass o2) => new PerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLengthSqr operator*(LengthMass o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeSqrPerLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthMass o2) => new TimeSqrPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator*(LengthMass o1, PerLengthCubTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeCub operator*(PerLengthCubTimeCub o1, LengthMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator*(LengthMass o1, TimeCubPerLengthCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLengthSqr operator*(TimeCubPerLengthCub o1, LengthMass o2) => new TimeCubMassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthMass o1, PerMassLengthSqrTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerMassLengthSqrTimeCub o1, LengthMass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthMass o1, TimeCubPerMassLengthSqr o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerMassLengthSqr o1, LengthMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthMass o1, MassPerLengthSqrTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(MassPerLengthSqrTimeCub o1, LengthMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(LengthMass o1, TimeCubMassPerLengthSqr o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubMassPerLengthSqr o1, LengthMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthMass o1, LengthSqrPerMassTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthSqrPerMassTimeCub o1, LengthMass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthMass o1, TimeCubLengthSqrPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLengthSqrPerMass o1, LengthMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(LengthMass o1, LengthSqrMassPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthSqrMassPerTimeCub o1, LengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthMass o1, TimeCubLengthSqrMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(TimeCubLengthSqrMass o1, LengthMass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLengthSqr operator/(LengthMass o1, LengthCubPerTimeCub o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMassTimeCub operator/(LengthCubPerTimeCub o1, LengthMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(LengthMass o1, LengthCubTimeCub o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthCubTimeCub o1, LengthMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLengthSqr operator/(LengthMass o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerLengthSqr(o1.Value_ / o2.Value_);
  public static QDose operator/(LengthCubMassPerTimeSqr o1, LengthMass o2) => new QDose(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthMass o1, LengthCubTimeSqrMass o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubTimeSqrMass o1, LengthMass o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator*(LengthMass o1, PerMassLengthCubTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthSqrTimeCub operator*(PerMassLengthCubTimeCub o1, LengthMass o2) => new PerLengthSqrTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator*(LengthMass o1, TimeCubPerMassLengthCub o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubPerLengthSqr operator*(TimeCubPerMassLengthCub o1, LengthMass o2) => new TimeCubPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLengthSqr operator/(LengthMass o1, LengthCubMassPerTimeCub o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerTimeCub operator/(LengthCubMassPerTimeCub o1, LengthMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeCub operator/(LengthMass o1, LengthCubTimeCubMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqr operator/(LengthCubTimeCubMass o1, LengthMass o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  
#endregion

#region rules

  public double MinValue { get; }
  public double MaxValue { get; }
  public bool HasMinValue { get; }
  public bool HasMaxValue { get; }
  public bool ValidateRules(bool throwOnFail=true)
  {
    bool fail = false;
    if (this.HasMinValue && this.Value_ < this.MinValue)
    {
      fail = true;
    }  
    if (this.HasMaxValue && this.Value_ > this.MaxValue)
    {
      fail = true;
    }  
    if (fail && throwOnFail)
    {
      throw new System.ArgumentException("LengthMass is outside its bounds.");
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
    