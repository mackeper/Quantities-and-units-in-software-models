
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthSqrMass : Quantity, IEquatable<LengthSqrMass>, IComparable
  {  
    internal LengthSqrMass(double value) : base(value, 2)
    {
      LengthSqrMass.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthSqrMass(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthSqrMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthSqrMass(LengthSqrMass other) : base(other)
    {
      LengthSqrMass.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthSqrMass"))
    {
      switch(FakeDatabase.Units["LengthSqrMass"])
      {
        case "centimetersqrkilogram": displayUnit_ = centimetersqrkilogram_; break;
        case "millimetersqrkilogram": displayUnit_ = millimetersqrkilogram_; break;
        case "metersqrkilogram": displayUnit_ = metersqrkilogram_; break;
        case "inchsqrkilogram": displayUnit_ = inchsqrkilogram_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetersqrkilogram_ = new Unit_("CentimeterSqrKilogram", "cm� kg", 1, 0);
  private static Unit_ millimetersqrkilogram_ = new Unit_("MillimeterSqrKilogram", "mm� kg", 0.010000000000000002, 0);
  private static Unit_ metersqrkilogram_ = new Unit_("MeterSqrKilogram", "m� kg", 10000, 0);
  private static Unit_ inchsqrkilogram_ = new Unit_("InchSqrKilogram", "in� kg", 6.5536, 0);
  private static Unit_ platformUnit_ = centimetersqrkilogram_;
  private static Unit_ displayUnit_ = centimetersqrkilogram_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthSqrMass other && Equals(other);
  public bool Equals(LengthSqrMass other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthSqrMass other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthSqrMass other)) throw new ArgumentException("Object is not a LengthSqrMass.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthSqrMass l1, LengthSqrMass l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthSqrMass l1, LengthSqrMass l2) => !(l1 == l2);
  public static bool operator <(LengthSqrMass l1, LengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthSqrMass l1, LengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthSqrMass l1, LengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthSqrMass l1, LengthSqrMass l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthSqrMass FromCentimeterSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrMass((value + centimetersqrkilogram_.Offset) * centimetersqrkilogram_.Factor, minValue * centimetersqrkilogram_.Factor, maxValue * centimetersqrkilogram_.Factor);
  public static LengthSqrMass FromCentimeterSqrKilograms(double value) => new LengthSqrMass((value + centimetersqrkilogram_.Offset) * centimetersqrkilogram_.Factor);
  public double GetValueInCentimeterSqrKilograms() => (Value_ - centimetersqrkilogram_.Offset) / centimetersqrkilogram_.Factor;
  public static LengthSqrMass FromMillimeterSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrMass((value + millimetersqrkilogram_.Offset) * millimetersqrkilogram_.Factor, minValue * millimetersqrkilogram_.Factor, maxValue * millimetersqrkilogram_.Factor);
  public static LengthSqrMass FromMillimeterSqrKilograms(double value) => new LengthSqrMass((value + millimetersqrkilogram_.Offset) * millimetersqrkilogram_.Factor);
  public double GetValueInMillimeterSqrKilograms() => (Value_ - millimetersqrkilogram_.Offset) / millimetersqrkilogram_.Factor;
  public static LengthSqrMass FromMeterSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrMass((value + metersqrkilogram_.Offset) * metersqrkilogram_.Factor, minValue * metersqrkilogram_.Factor, maxValue * metersqrkilogram_.Factor);
  public static LengthSqrMass FromMeterSqrKilograms(double value) => new LengthSqrMass((value + metersqrkilogram_.Offset) * metersqrkilogram_.Factor);
  public double GetValueInMeterSqrKilograms() => (Value_ - metersqrkilogram_.Offset) / metersqrkilogram_.Factor;
  public static LengthSqrMass FromInchSqrKilograms(double value, double minValue, double maxValue) => new LengthSqrMass((value + inchsqrkilogram_.Offset) * inchsqrkilogram_.Factor, minValue * inchsqrkilogram_.Factor, maxValue * inchsqrkilogram_.Factor);
  public static LengthSqrMass FromInchSqrKilograms(double value) => new LengthSqrMass((value + inchsqrkilogram_.Offset) * inchsqrkilogram_.Factor);
  public double GetValueInInchSqrKilograms() => (Value_ - inchsqrkilogram_.Offset) / inchsqrkilogram_.Factor;

#endregion

#region arithmetic
  public static LengthSqrMass operator+(LengthSqrMass o1, LengthSqrMass o2) => new LengthSqrMass(o1.Value_ + o2.Value_);
  public static LengthSqrMass operator-(LengthSqrMass o1, LengthSqrMass o2) => new LengthSqrMass(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthSqrMass o1, LengthSqrMass o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(LengthSqrMass o1, Volume o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(Volume o1, LengthSqrMass o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthSqrMass o1, PerMassLengthCub o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(PerMassLengthCub o1, LengthSqrMass o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator*(LengthSqrMass o1, PerTimeLengthCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(PerTimeLengthCub o1, LengthSqrMass o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static MassTimePerLength operator*(LengthSqrMass o1, TimePerLengthCub o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  public static MassTimePerLength operator*(TimePerLengthCub o1, LengthSqrMass o2) => new MassTimePerLength(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(LengthSqrMass o1, PerMassTimeLengthSqr o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerMassTimeLengthSqr o1, LengthSqrMass o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(LengthSqrMass o1, TimePerMassLengthSqr o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerMassLengthSqr o1, LengthSqrMass o2) => new Time(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(LengthSqrMass o1, PerLengthSqrTimeSqr o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(PerLengthSqrTimeSqr o1, LengthSqrMass o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(LengthSqrMass o1, TimeSqrPerLengthSqr o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrPerLengthSqr o1, LengthSqrMass o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(LengthSqrMass o1, PerLengthMassTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthMassTimeSqr o1, LengthSqrMass o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(LengthSqrMass o1, TimeSqrPerLengthMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrPerLengthMass o1, LengthSqrMass o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(LengthSqrMass o1, PerLengthTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(PerLengthTimeCub o1, LengthSqrMass o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(LengthSqrMass o1, PerLengthTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerLengthTimeCub o1, LengthSqrMass o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthMass operator*(LengthSqrMass o1, TimeCubPerLength o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubPerLength o1, LengthSqrMass o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(LengthSqrMass o1, TimeCubPerLength o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerLength o1, LengthSqrMass o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeSqr operator/(LengthSqrMass o1, MassPerLengthTimeSqr o2) => new LengthCubTimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqrLengthCub operator/(MassPerLengthTimeSqr o1, LengthSqrMass o2) => new PerTimeSqrLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator/(LengthSqrMass o1, TimeSqrMassPerLength o2) => new LengthCubPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthCub operator/(TimeSqrMassPerLength o1, LengthSqrMass o2) => new TimeSqrPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(LengthSqrMass o1, PerMassTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(PerMassTimeCub o1, LengthSqrMass o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(LengthSqrMass o1, TimeCubPerMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubPerMass o1, LengthSqrMass o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator/(LengthSqrMass o1, MassPerTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(MassPerTimeCub o1, LengthSqrMass o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(LengthSqrMass o1, TimeCubMass o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubMass o1, LengthSqrMass o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeSqr operator*(LengthSqrMass o1, LengthPerMassTimeSqr o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeSqr operator*(LengthPerMassTimeSqr o1, LengthSqrMass o2) => new LengthCubPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeSqr operator*(LengthSqrMass o1, TimeSqrLengthPerMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubTimeSqr operator*(TimeSqrLengthPerMass o1, LengthSqrMass o2) => new LengthCubTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(LengthSqrMass o1, LengthPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(LengthPerTimeCub o1, LengthSqrMass o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator/(LengthSqrMass o1, LengthPerTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthPerTimeCub o1, LengthSqrMass o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(LengthSqrMass o1, TimeCubLength o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeCubLength o1, LengthSqrMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator/(LengthSqrMass o1, TimeCubLength o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubLength o1, LengthSqrMass o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(LengthSqrMass o1, Force o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(Force o1, LengthSqrMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(LengthSqrMass o1, TimeSqrLengthMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(TimeSqrLengthMass o1, LengthSqrMass o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(LengthSqrMass o1, QDose o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(QDose o1, LengthSqrMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(LengthSqrMass o1, LengthSqrTimeSqr o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthSqrTimeSqr o1, LengthSqrMass o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(LengthSqrMass o1, LengthSqrMassPerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthSqrMassPerTime o1, LengthSqrMass o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(LengthSqrMass o1, LengthSqrMassTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthSqrMassTime o1, LengthSqrMass o2) => new Time(o1.Value_ / o2.Value_);
  
  public static MassTimePerLength operator/(LengthSqrMass o1, LengthCubPerTime o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTime operator/(LengthCubPerTime o1, LengthSqrMass o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator/(LengthSqrMass o1, LengthCubTime o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthCubTime o1, LengthSqrMass o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLength operator/(LengthSqrMass o1, LengthCubMass o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthCubMass o1, LengthSqrMass o2) => new Length(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator*(LengthSqrMass o1, PerMassTimeLengthCub o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  public static PerLengthTime operator*(PerMassTimeLengthCub o1, LengthSqrMass o2) => new PerLengthTime(o1.Value_ * o2.Value_);
  
  public static TimePerLength operator*(LengthSqrMass o1, TimePerMassLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimePerMassLengthCub o1, LengthSqrMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator*(LengthSqrMass o1, PerTimeSqrLengthCub o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeSqr operator*(PerTimeSqrLengthCub o1, LengthSqrMass o2) => new MassPerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMassPerLength operator*(LengthSqrMass o1, TimeSqrPerLengthCub o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrMassPerLength operator*(TimeSqrPerLengthCub o1, LengthSqrMass o2) => new TimeSqrMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(LengthSqrMass o1, PerMassLengthSqrTimeSqr o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerMassLengthSqrTimeSqr o1, LengthSqrMass o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(LengthSqrMass o1, TimeSqrPerMassLengthSqr o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerMassLengthSqr o1, LengthSqrMass o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(LengthSqrMass o1, PerLengthSqrTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(PerLengthSqrTimeCub o1, LengthSqrMass o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(LengthSqrMass o1, TimeCubPerLengthSqr o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubPerLengthSqr o1, LengthSqrMass o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(LengthSqrMass o1, PerLengthMassTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(PerLengthMassTimeCub o1, LengthSqrMass o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(LengthSqrMass o1, TimeCubPerLengthMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubPerLengthMass o1, LengthSqrMass o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator/(LengthSqrMass o1, MassPerLengthTimeCub o2) => new LengthCubTimeCub(o1.Value_ / o2.Value_);
  public static PerLengthCubTimeCub operator/(MassPerLengthTimeCub o1, LengthSqrMass o2) => new PerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator/(LengthSqrMass o1, TimeCubMassPerLength o2) => new LengthCubPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthCub operator/(TimeCubMassPerLength o1, LengthSqrMass o2) => new TimeCubPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTimeCub operator*(LengthSqrMass o1, LengthPerMassTimeCub o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerTimeCub operator*(LengthPerMassTimeCub o1, LengthSqrMass o2) => new LengthCubPerTimeCub(o1.Value_ * o2.Value_);
  
  public static LengthCubTimeCub operator*(LengthSqrMass o1, TimeCubLengthPerMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCub operator*(TimeCubLengthPerMass o1, LengthSqrMass o2) => new LengthCubTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator/(LengthSqrMass o1, LengthMassPerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(LengthMassPerTimeCub o1, LengthSqrMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(LengthSqrMass o1, TimeCubLengthMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubLengthMass o1, LengthSqrMass o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static TimeCubMass operator/(LengthSqrMass o1, LengthSqrPerTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthSqrPerTimeCub o1, LengthSqrMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(LengthSqrMass o1, TimeCubLengthSqr o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(TimeCubLengthSqr o1, LengthSqrMass o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(LengthSqrMass o1, LengthSqrMassPerTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthSqrMassPerTimeSqr o1, LengthSqrMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(LengthSqrMass o1, LengthSqrTimeSqrMass o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthSqrTimeSqrMass o1, LengthSqrMass o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrMassPerLength operator/(LengthSqrMass o1, LengthCubPerTimeSqr o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeSqr operator/(LengthCubPerTimeSqr o1, LengthSqrMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthSqrMass o1, LengthCubTimeSqr o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthCubTimeSqr o1, LengthSqrMass o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(LengthSqrMass o1, LengthCubMassPerTime o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(LengthCubMassPerTime o1, LengthSqrMass o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static PerLengthTime operator/(LengthSqrMass o1, LengthCubMassTime o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(LengthCubMassTime o1, LengthSqrMass o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator*(LengthSqrMass o1, PerMassTimeSqrLengthCub o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  public static PerLengthTimeSqr operator*(PerMassTimeSqrLengthCub o1, LengthSqrMass o2) => new PerLengthTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerLength operator*(LengthSqrMass o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  public static TimeSqrPerLength operator*(TimeSqrPerMassLengthCub o1, LengthSqrMass o2) => new TimeSqrPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeCub operator*(LengthSqrMass o1, PerLengthCubTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  public static MassPerLengthTimeCub operator*(PerLengthCubTimeCub o1, LengthSqrMass o2) => new MassPerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMassPerLength operator*(LengthSqrMass o1, TimeCubPerLengthCub o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  public static TimeCubMassPerLength operator*(TimeCubPerLengthCub o1, LengthSqrMass o2) => new TimeCubMassPerLength(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(LengthSqrMass o1, PerMassLengthSqrTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerMassLengthSqrTimeCub o1, LengthSqrMass o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(LengthSqrMass o1, TimeCubPerMassLengthSqr o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerMassLengthSqr o1, LengthSqrMass o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator/(LengthSqrMass o1, LengthSqrMassPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthSqrMassPerTimeCub o1, LengthSqrMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(LengthSqrMass o1, TimeCubLengthSqrMass o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(TimeCubLengthSqrMass o1, LengthSqrMass o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeCubMassPerLength operator/(LengthSqrMass o1, LengthCubPerTimeCub o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMassTimeCub operator/(LengthCubPerTimeCub o1, LengthSqrMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTimeCub operator/(LengthSqrMass o1, LengthCubTimeCub o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthPerMass operator/(LengthCubTimeCub o1, LengthSqrMass o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerLength operator/(LengthSqrMass o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  public static Acceleration operator/(LengthCubMassPerTimeSqr o1, LengthSqrMass o2) => new Acceleration(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeSqr operator/(LengthSqrMass o1, LengthCubTimeSqrMass o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLength operator/(LengthCubTimeSqrMass o1, LengthSqrMass o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator*(LengthSqrMass o1, PerMassLengthCubTimeCub o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  public static PerLengthTimeCub operator*(PerMassLengthCubTimeCub o1, LengthSqrMass o2) => new PerLengthTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator*(LengthSqrMass o1, TimeCubPerMassLengthCub o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  public static TimeCubPerLength operator*(TimeCubPerMassLengthCub o1, LengthSqrMass o2) => new TimeCubPerLength(o1.Value_ * o2.Value_);
  
  public static TimeCubPerLength operator/(LengthSqrMass o1, LengthCubMassPerTimeCub o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  public static LengthPerTimeCub operator/(LengthCubMassPerTimeCub o1, LengthSqrMass o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerLengthTimeCub operator/(LengthSqrMass o1, LengthCubTimeCubMass o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLength operator/(LengthCubTimeCubMass o1, LengthSqrMass o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthSqrMass is outside its bounds.");
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
    