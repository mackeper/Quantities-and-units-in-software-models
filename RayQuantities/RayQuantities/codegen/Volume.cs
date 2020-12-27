
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Volume : Quantity, IEquatable<Volume>, IComparable
  {  
    internal Volume(double value) : base(value, 2)
    {
      Volume.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Volume(double value, double minValue, double maxValue) : base(value, 2)
    {
      Volume.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Volume(Volume other) : base(other)
    {
      Volume.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Volume"))
    {
      switch(FakeDatabase.Units["Volume"])
      {
        case "centimetercub": displayUnit_ = centimetercub_; break;
        case "millimetercub": displayUnit_ = millimetercub_; break;
        case "metercub": displayUnit_ = metercub_; break;
        case "inchcub": displayUnit_ = inchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimetercub_ = new Unit_("CentimeterCub", "cm�", 1, 0);
  private static Unit_ millimetercub_ = new Unit_("MillimeterCub", "mm�", 0.0010000000000000002, 0);
  private static Unit_ metercub_ = new Unit_("MeterCub", "m�", 1000000, 0);
  private static Unit_ inchcub_ = new Unit_("InchCub", "in�", 16.777216000000003, 0);
  private static Unit_ platformUnit_ = centimetercub_;
  private static Unit_ displayUnit_ = centimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Volume other && Equals(other);
  public bool Equals(Volume other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Volume other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Volume other)) throw new ArgumentException("Object is not a Volume.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Volume l1, Volume l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Volume l1, Volume l2) => !(l1 == l2);
  public static bool operator <(Volume l1, Volume l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Volume l1, Volume l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Volume l1, Volume l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Volume l1, Volume l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Volume FromCentimeterCubs(double value, double minValue, double maxValue) => new Volume((value + centimetercub_.Offset) * centimetercub_.Factor, minValue * centimetercub_.Factor, maxValue * centimetercub_.Factor);
  public static Volume FromCentimeterCubs(double value) => new Volume((value + centimetercub_.Offset) * centimetercub_.Factor);
  public double GetValueInCentimeterCubs() => (Value_ - centimetercub_.Offset) / centimetercub_.Factor;
  public static Volume FromMillimeterCubs(double value, double minValue, double maxValue) => new Volume((value + millimetercub_.Offset) * millimetercub_.Factor, minValue * millimetercub_.Factor, maxValue * millimetercub_.Factor);
  public static Volume FromMillimeterCubs(double value) => new Volume((value + millimetercub_.Offset) * millimetercub_.Factor);
  public double GetValueInMillimeterCubs() => (Value_ - millimetercub_.Offset) / millimetercub_.Factor;
  public static Volume FromMeterCubs(double value, double minValue, double maxValue) => new Volume((value + metercub_.Offset) * metercub_.Factor, minValue * metercub_.Factor, maxValue * metercub_.Factor);
  public static Volume FromMeterCubs(double value) => new Volume((value + metercub_.Offset) * metercub_.Factor);
  public double GetValueInMeterCubs() => (Value_ - metercub_.Offset) / metercub_.Factor;
  public static Volume FromInchCubs(double value, double minValue, double maxValue) => new Volume((value + inchcub_.Offset) * inchcub_.Factor, minValue * inchcub_.Factor, maxValue * inchcub_.Factor);
  public static Volume FromInchCubs(double value) => new Volume((value + inchcub_.Offset) * inchcub_.Factor);
  public double GetValueInInchCubs() => (Value_ - inchcub_.Offset) / inchcub_.Factor;

#endregion

#region arithmetic
  public static Volume operator+(Volume o1, Volume o2) => new Volume(o1.Value_ + o2.Value_);
  public static Volume operator-(Volume o1, Volume o2) => new Volume(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Volume o1, Volume o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(Volume o1, PerMassLengthCub o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(PerMassLengthCub o1, Volume o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static PerTime operator*(Volume o1, PerTimeLengthCub o2) => new PerTime(o1.Value_ * o2.Value_);
  public static PerTime operator*(PerTimeLengthCub o1, Volume o2) => new PerTime(o1.Value_ * o2.Value_);
  
  public static Time operator*(Volume o1, TimePerLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(TimePerLengthCub o1, Volume o2) => new Time(o1.Value_ * o2.Value_);
  
  public static Mass operator*(Volume o1, Density o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(Density o1, Volume o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(Volume o1, PerMassTimeLengthSqr o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(PerMassTimeLengthSqr o1, Volume o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static LengthTimePerMass operator*(Volume o1, TimePerMassLengthSqr o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  public static LengthTimePerMass operator*(TimePerMassLengthSqr o1, Volume o2) => new LengthTimePerMass(o1.Value_ * o2.Value_);
  
  public static Acceleration operator*(Volume o1, PerLengthSqrTimeSqr o2) => new Acceleration(o1.Value_ * o2.Value_);
  public static Acceleration operator*(PerLengthSqrTimeSqr o1, Volume o2) => new Acceleration(o1.Value_ * o2.Value_);
  
  public static TimeSqrLength operator*(Volume o1, TimeSqrPerLengthSqr o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  public static TimeSqrLength operator*(TimeSqrPerLengthSqr o1, Volume o2) => new TimeSqrLength(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(Volume o1, MassPerTimeLengthSqr o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(MassPerTimeLengthSqr o1, Volume o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthMassTime operator*(Volume o1, MassTimePerLengthSqr o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  public static LengthMassTime operator*(MassTimePerLengthSqr o1, Volume o2) => new LengthMassTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator*(Volume o1, PerLengthMassTimeSqr o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeSqr operator*(PerLengthMassTimeSqr o1, Volume o2) => new LengthSqrPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator*(Volume o1, TimeSqrPerLengthMass o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrPerMass operator*(TimeSqrPerLengthMass o1, Volume o2) => new LengthSqrTimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerTimeCub operator*(Volume o1, PerLengthTimeCub o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerTimeCub operator*(PerLengthTimeCub o1, Volume o2) => new LengthSqrPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqr operator*(Volume o1, TimeCubPerLength o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqr operator*(TimeCubPerLength o1, Volume o2) => new TimeCubLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator*(Volume o1, MassPerLengthTimeSqr o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeSqr operator*(MassPerLengthTimeSqr o1, Volume o2) => new LengthSqrMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthSqrTimeSqrMass operator*(Volume o1, TimeSqrMassPerLength o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrTimeSqrMass operator*(TimeSqrMassPerLength o1, Volume o2) => new LengthSqrTimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTimeCub operator*(Volume o1, PerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator*(PerMassTimeCub o1, Volume o2) => new LengthCubPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator/(Volume o1, PerMassTimeCub o2) => new LengthCubTimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCubTimeCub operator/(PerMassTimeCub o1, Volume o2) => new PerMassLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubPerMass operator*(Volume o1, TimeCubPerMass o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator*(TimeCubPerMass o1, Volume o2) => new LengthCubTimeCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator/(Volume o1, TimeCubPerMass o2) => new LengthCubMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthCub operator/(TimeCubPerMass o1, Volume o2) => new TimeCubPerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeCub operator*(Volume o1, MassPerTimeCub o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeCub operator*(MassPerTimeCub o1, Volume o2) => new LengthCubMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubPerMass operator/(Volume o1, MassPerTimeCub o2) => new LengthCubTimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthCubTimeCub operator/(MassPerTimeCub o1, Volume o2) => new MassPerLengthCubTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthCubTimeCubMass operator*(Volume o1, TimeCubMass o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubTimeCubMass operator*(TimeCubMass o1, Volume o2) => new LengthCubTimeCubMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeCub operator/(Volume o1, TimeCubMass o2) => new LengthCubPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthCub operator/(TimeCubMass o1, Volume o2) => new TimeCubMassPerLengthCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrMass operator/(Volume o1, LengthPerMassTimeSqr o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeSqr operator/(LengthPerMassTimeSqr o1, Volume o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeSqr operator/(Volume o1, TimeSqrLengthPerMass o2) => new LengthSqrMassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMassLengthSqr operator/(TimeSqrLengthPerMass o1, Volume o2) => new TimeSqrPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqr operator/(Volume o1, LengthPerTimeCub o2) => new TimeCubLengthSqr(o1.Value_ / o2.Value_);
  public static PerLengthSqrTimeCub operator/(LengthPerTimeCub o1, Volume o2) => new PerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerTimeCub operator/(Volume o1, TimeCubLength o2) => new LengthSqrPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthSqr operator/(TimeCubLength o1, Volume o2) => new TimeCubPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrTimeSqrPerMass operator/(Volume o1, Force o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeSqr operator/(Force o1, Volume o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeSqr operator/(Volume o1, TimeSqrLengthMass o2) => new LengthSqrPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLengthSqr operator/(TimeSqrLengthMass o1, Volume o2) => new TimeSqrMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static LengthMassTime operator/(Volume o1, LengthSqrPerMassTime o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  public static PerLengthMassTime operator/(LengthSqrPerMassTime o1, Volume o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTime operator/(Volume o1, LengthSqrTimePerMass o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(LengthSqrTimePerMass o1, Volume o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeSqrLength operator/(Volume o1, QDose o2) => new TimeSqrLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeSqr operator/(QDose o1, Volume o2) => new PerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static Acceleration operator/(Volume o1, LengthSqrTimeSqr o2) => new Acceleration(o1.Value_ / o2.Value_);
  public static TimeSqrPerLength operator/(LengthSqrTimeSqr o1, Volume o2) => new TimeSqrPerLength(o1.Value_ / o2.Value_);
  
  public static LengthTimePerMass operator/(Volume o1, LengthSqrMassPerTime o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTime operator/(LengthSqrMassPerTime o1, Volume o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(Volume o1, LengthSqrMassTime o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(LengthSqrMassTime o1, Volume o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(Volume o1, LengthCubPerMass o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthCubPerMass o1, Volume o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static Time operator/(Volume o1, LengthCubPerTime o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(LengthCubPerTime o1, Volume o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static PerTime operator/(Volume o1, LengthCubTime o2) => new PerTime(o1.Value_ / o2.Value_);
  public static Time operator/(LengthCubTime o1, Volume o2) => new Time(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(Volume o1, LengthCubMass o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthCubMass o1, Volume o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator*(Volume o1, PerMassTimeLengthCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(PerMassTimeLengthCub o1, Volume o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static TimePerMass operator*(Volume o1, TimePerMassLengthCub o2) => new TimePerMass(o1.Value_ * o2.Value_);
  public static TimePerMass operator*(TimePerMassLengthCub o1, Volume o2) => new TimePerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeSqr operator*(Volume o1, PerTimeSqrLengthCub o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  public static PerTimeSqr operator*(PerTimeSqrLengthCub o1, Volume o2) => new PerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqr operator*(Volume o1, TimeSqrPerLengthCub o2) => new TimeSqr(o1.Value_ * o2.Value_);
  public static TimeSqr operator*(TimeSqrPerLengthCub o1, Volume o2) => new TimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(Volume o1, MassPerTimeLengthCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(MassPerTimeLengthCub o1, Volume o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(Volume o1, MassTimePerLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(MassTimePerLengthCub o1, Volume o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(Volume o1, PerMassLengthSqrTimeSqr o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(PerMassLengthSqrTimeSqr o1, Volume o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthPerMass operator*(Volume o1, TimeSqrPerMassLengthSqr o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthPerMass operator*(TimeSqrPerMassLengthSqr o1, Volume o2) => new TimeSqrLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthPerTimeCub operator*(Volume o1, PerLengthSqrTimeCub o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerTimeCub operator*(PerLengthSqrTimeCub o1, Volume o2) => new LengthPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLength operator*(Volume o1, TimeCubPerLengthSqr o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  public static TimeCubLength operator*(TimeCubPerLengthSqr o1, Volume o2) => new TimeCubLength(o1.Value_ * o2.Value_);
  
  public static Force operator*(Volume o1, MassPerLengthSqrTimeSqr o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(MassPerLengthSqrTimeSqr o1, Volume o2) => new Force(o1.Value_ * o2.Value_);
  
  public static TimeSqrLengthMass operator*(Volume o1, TimeSqrMassPerLengthSqr o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  public static TimeSqrLengthMass operator*(TimeSqrMassPerLengthSqr o1, Volume o2) => new TimeSqrLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator*(Volume o1, PerLengthMassTimeCub o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrPerMassTimeCub operator*(PerLengthMassTimeCub o1, Volume o2) => new LengthSqrPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator*(Volume o1, TimeCubPerLengthMass o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrPerMass operator*(TimeCubPerLengthMass o1, Volume o2) => new TimeCubLengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator*(Volume o1, MassPerLengthTimeCub o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTimeCub operator*(MassPerLengthTimeCub o1, Volume o2) => new LengthSqrMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator*(Volume o1, TimeCubMassPerLength o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthSqrMass operator*(TimeCubMassPerLength o1, Volume o2) => new TimeCubLengthSqrMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthSqrMass operator/(Volume o1, LengthPerMassTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqrTimeCub operator/(LengthPerMassTimeCub o1, Volume o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTimeCub operator/(Volume o1, TimeCubLengthPerMass o2) => new LengthSqrMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMassLengthSqr operator/(TimeCubLengthPerMass o1, Volume o2) => new TimeCubPerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthSqrPerMass operator/(Volume o1, LengthMassPerTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqrTimeCub operator/(LengthMassPerTimeCub o1, Volume o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMassTimeCub operator/(Volume o1, TimeCubLengthMass o2) => new LengthSqrPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLengthSqr operator/(TimeCubLengthMass o1, Volume o2) => new TimeCubMassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthMass operator/(Volume o1, LengthSqrPerMassTimeSqr o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeSqr operator/(LengthSqrPerMassTimeSqr o1, Volume o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static Force operator/(Volume o1, LengthSqrTimeSqrPerMass o2) => new Force(o1.Value_ / o2.Value_);
  public static TimeSqrPerLengthMass operator/(LengthSqrTimeSqrPerMass o1, Volume o2) => new TimeSqrPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubLength operator/(Volume o1, LengthSqrPerTimeCub o2) => new TimeCubLength(o1.Value_ / o2.Value_);
  public static PerLengthTimeCub operator/(LengthSqrPerTimeCub o1, Volume o2) => new PerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerTimeCub operator/(Volume o1, TimeCubLengthSqr o2) => new LengthPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLength operator/(TimeCubLengthSqr o1, Volume o2) => new TimeCubPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrLengthPerMass operator/(Volume o1, LengthSqrMassPerTimeSqr o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeSqr operator/(LengthSqrMassPerTimeSqr o1, Volume o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeSqr operator/(Volume o1, LengthSqrTimeSqrMass o2) => new LengthPerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMassPerLength operator/(LengthSqrTimeSqrMass o1, Volume o2) => new TimeSqrMassPerLength(o1.Value_ / o2.Value_);
  
  public static MassTime operator/(Volume o1, LengthCubPerMassTime o2) => new MassTime(o1.Value_ / o2.Value_);
  public static PerMassTime operator/(LengthCubPerMassTime o1, Volume o2) => new PerMassTime(o1.Value_ / o2.Value_);
  
  public static MassPerTime operator/(Volume o1, LengthCubTimePerMass o2) => new MassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMass operator/(LengthCubTimePerMass o1, Volume o2) => new TimePerMass(o1.Value_ / o2.Value_);
  
  public static TimeSqr operator/(Volume o1, LengthCubPerTimeSqr o2) => new TimeSqr(o1.Value_ / o2.Value_);
  public static PerTimeSqr operator/(LengthCubPerTimeSqr o1, Volume o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerTimeSqr operator/(Volume o1, LengthCubTimeSqr o2) => new PerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqr operator/(LengthCubTimeSqr o1, Volume o2) => new TimeSqr(o1.Value_ / o2.Value_);
  
  public static TimePerMass operator/(Volume o1, LengthCubMassPerTime o2) => new TimePerMass(o1.Value_ / o2.Value_);
  public static MassPerTime operator/(LengthCubMassPerTime o1, Volume o2) => new MassPerTime(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(Volume o1, LengthCubMassTime o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(LengthCubMassTime o1, Volume o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator*(Volume o1, PerMassTimeSqrLengthCub o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeSqr operator*(PerMassTimeSqrLengthCub o1, Volume o2) => new PerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrPerMass operator*(Volume o1, TimeSqrPerMassLengthCub o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  public static TimeSqrPerMass operator*(TimeSqrPerMassLengthCub o1, Volume o2) => new TimeSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerTimeCub operator*(Volume o1, PerLengthCubTimeCub o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  public static PerTimeCub operator*(PerLengthCubTimeCub o1, Volume o2) => new PerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCub operator*(Volume o1, TimeCubPerLengthCub o2) => new TimeCub(o1.Value_ * o2.Value_);
  public static TimeCub operator*(TimeCubPerLengthCub o1, Volume o2) => new TimeCub(o1.Value_ * o2.Value_);
  
  public static MassPerTimeSqr operator*(Volume o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeSqr operator*(MassPerTimeSqrLengthCub o1, Volume o2) => new MassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static TimeSqrMass operator*(Volume o1, TimeSqrMassPerLengthCub o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  public static TimeSqrMass operator*(TimeSqrMassPerLengthCub o1, Volume o2) => new TimeSqrMass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeCub operator*(Volume o1, PerMassLengthSqrTimeCub o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeCub operator*(PerMassLengthSqrTimeCub o1, Volume o2) => new LengthPerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthPerMass operator*(Volume o1, TimeCubPerMassLengthSqr o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthPerMass operator*(TimeCubPerMassLengthSqr o1, Volume o2) => new TimeCubLengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTimeCub operator*(Volume o1, MassPerLengthSqrTimeCub o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  public static LengthMassPerTimeCub operator*(MassPerLengthSqrTimeCub o1, Volume o2) => new LengthMassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator*(Volume o1, TimeCubMassPerLengthSqr o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  public static TimeCubLengthMass operator*(TimeCubMassPerLengthSqr o1, Volume o2) => new TimeCubLengthMass(o1.Value_ * o2.Value_);
  
  public static TimeCubLengthMass operator/(Volume o1, LengthSqrPerMassTimeCub o2) => new TimeCubLengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMassTimeCub operator/(LengthSqrPerMassTimeCub o1, Volume o2) => new PerLengthMassTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthMassPerTimeCub operator/(Volume o1, TimeCubLengthSqrPerMass o2) => new LengthMassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerLengthMass operator/(TimeCubLengthSqrPerMass o1, Volume o2) => new TimeCubPerLengthMass(o1.Value_ / o2.Value_);
  
  public static TimeCubLengthPerMass operator/(Volume o1, LengthSqrMassPerTimeCub o2) => new TimeCubLengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthTimeCub operator/(LengthSqrMassPerTimeCub o1, Volume o2) => new MassPerLengthTimeCub(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTimeCub operator/(Volume o1, TimeCubLengthSqrMass o2) => new LengthPerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMassPerLength operator/(TimeCubLengthSqrMass o1, Volume o2) => new TimeCubMassPerLength(o1.Value_ / o2.Value_);
  
  public static TimeSqrMass operator/(Volume o1, LengthCubPerMassTimeSqr o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  public static PerMassTimeSqr operator/(LengthCubPerMassTimeSqr o1, Volume o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  
  public static MassPerTimeSqr operator/(Volume o1, LengthCubTimeSqrPerMass o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrPerMass operator/(LengthCubTimeSqrPerMass o1, Volume o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCub operator/(Volume o1, LengthCubPerTimeCub o2) => new TimeCub(o1.Value_ / o2.Value_);
  public static PerTimeCub operator/(LengthCubPerTimeCub o1, Volume o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerTimeCub operator/(Volume o1, LengthCubTimeCub o2) => new PerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCub operator/(LengthCubTimeCub o1, Volume o2) => new TimeCub(o1.Value_ / o2.Value_);
  
  public static TimeSqrPerMass operator/(Volume o1, LengthCubMassPerTimeSqr o2) => new TimeSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeSqr operator/(LengthCubMassPerTimeSqr o1, Volume o2) => new MassPerTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassTimeSqr operator/(Volume o1, LengthCubTimeSqrMass o2) => new PerMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrMass operator/(LengthCubTimeSqrMass o1, Volume o2) => new TimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator*(Volume o1, PerMassLengthCubTimeCub o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  public static PerMassTimeCub operator*(PerMassLengthCubTimeCub o1, Volume o2) => new PerMassTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubPerMass operator*(Volume o1, TimeCubPerMassLengthCub o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  public static TimeCubPerMass operator*(TimeCubPerMassLengthCub o1, Volume o2) => new TimeCubPerMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeCub operator*(Volume o1, MassPerLengthCubTimeCub o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  public static MassPerTimeCub operator*(MassPerLengthCubTimeCub o1, Volume o2) => new MassPerTimeCub(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator*(Volume o1, TimeCubMassPerLengthCub o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  public static TimeCubMass operator*(TimeCubMassPerLengthCub o1, Volume o2) => new TimeCubMass(o1.Value_ * o2.Value_);
  
  public static TimeCubMass operator/(Volume o1, LengthCubPerMassTimeCub o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  public static PerMassTimeCub operator/(LengthCubPerMassTimeCub o1, Volume o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  
  public static MassPerTimeCub operator/(Volume o1, LengthCubTimeCubPerMass o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubPerMass operator/(LengthCubTimeCubPerMass o1, Volume o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  
  public static TimeCubPerMass operator/(Volume o1, LengthCubMassPerTimeCub o2) => new TimeCubPerMass(o1.Value_ / o2.Value_);
  public static MassPerTimeCub operator/(LengthCubMassPerTimeCub o1, Volume o2) => new MassPerTimeCub(o1.Value_ / o2.Value_);
  
  public static PerMassTimeCub operator/(Volume o1, LengthCubTimeCubMass o2) => new PerMassTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubMass operator/(LengthCubTimeCubMass o1, Volume o2) => new TimeCubMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Volume is outside its bounds.");
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
    