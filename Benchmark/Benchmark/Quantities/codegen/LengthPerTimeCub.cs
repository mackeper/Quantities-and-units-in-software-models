
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class LengthPerTimeCub : Quantity, IEquatable<LengthPerTimeCub>, IComparable
  {  
    internal LengthPerTimeCub(double value) : base(value, 2)
    {
      LengthPerTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal LengthPerTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      LengthPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public LengthPerTimeCub(LengthPerTimeCub other) : base(other)
    {
      LengthPerTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthPerTimeCub"))
    {
      switch(FakeDatabase.Units["LengthPerTimeCub"])
      {
        case "centimeterpersecondcub": displayUnit_ = centimeterpersecondcub_; break;
        case "millimeterpersecondcub": displayUnit_ = millimeterpersecondcub_; break;
        case "meterpersecondcub": displayUnit_ = meterpersecondcub_; break;
        case "inchpersecondcub": displayUnit_ = inchpersecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ centimeterpersecondcub_ = new Unit_("CentimeterPerSecondCub", "cm/s�", 1.0, 0);
  private static Unit_ millimeterpersecondcub_ = new Unit_("MillimeterPerSecondCub", "mm/s�", 0.1, 0);
  private static Unit_ meterpersecondcub_ = new Unit_("MeterPerSecondCub", "m/s�", 100.0, 0);
  private static Unit_ inchpersecondcub_ = new Unit_("InchPerSecondCub", "in/s�", 2.56, 0);
  private static Unit_ platformUnit_ = centimeterpersecondcub_;
  private static Unit_ displayUnit_ = centimeterpersecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is LengthPerTimeCub other && Equals(other);
  public bool Equals(LengthPerTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(LengthPerTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is LengthPerTimeCub other)) throw new ArgumentException("Object is not a LengthPerTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(LengthPerTimeCub l1, LengthPerTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(LengthPerTimeCub l1, LengthPerTimeCub l2) => !(l1 == l2);
  public static bool operator <(LengthPerTimeCub l1, LengthPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(LengthPerTimeCub l1, LengthPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(LengthPerTimeCub l1, LengthPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(LengthPerTimeCub l1, LengthPerTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static LengthPerTimeCub FromCentimeterPerSecondCubs(double value, double minValue, double maxValue) => new LengthPerTimeCub((value + centimeterpersecondcub_.Offset) * centimeterpersecondcub_.Factor, minValue * centimeterpersecondcub_.Factor, maxValue * centimeterpersecondcub_.Factor);
  public static LengthPerTimeCub FromCentimeterPerSecondCubs(double value) => new LengthPerTimeCub((value + centimeterpersecondcub_.Offset) * centimeterpersecondcub_.Factor);
  public double GetValueInCentimeterPerSecondCubs() => (Value_ - centimeterpersecondcub_.Offset) / centimeterpersecondcub_.Factor;
  public static LengthPerTimeCub FromMillimeterPerSecondCubs(double value, double minValue, double maxValue) => new LengthPerTimeCub((value + millimeterpersecondcub_.Offset) * millimeterpersecondcub_.Factor, minValue * millimeterpersecondcub_.Factor, maxValue * millimeterpersecondcub_.Factor);
  public static LengthPerTimeCub FromMillimeterPerSecondCubs(double value) => new LengthPerTimeCub((value + millimeterpersecondcub_.Offset) * millimeterpersecondcub_.Factor);
  public double GetValueInMillimeterPerSecondCubs() => (Value_ - millimeterpersecondcub_.Offset) / millimeterpersecondcub_.Factor;
  public static LengthPerTimeCub FromMeterPerSecondCubs(double value, double minValue, double maxValue) => new LengthPerTimeCub((value + meterpersecondcub_.Offset) * meterpersecondcub_.Factor, minValue * meterpersecondcub_.Factor, maxValue * meterpersecondcub_.Factor);
  public static LengthPerTimeCub FromMeterPerSecondCubs(double value) => new LengthPerTimeCub((value + meterpersecondcub_.Offset) * meterpersecondcub_.Factor);
  public double GetValueInMeterPerSecondCubs() => (Value_ - meterpersecondcub_.Offset) / meterpersecondcub_.Factor;
  public static LengthPerTimeCub FromInchPerSecondCubs(double value, double minValue, double maxValue) => new LengthPerTimeCub((value + inchpersecondcub_.Offset) * inchpersecondcub_.Factor, minValue * inchpersecondcub_.Factor, maxValue * inchpersecondcub_.Factor);
  public static LengthPerTimeCub FromInchPerSecondCubs(double value) => new LengthPerTimeCub((value + inchpersecondcub_.Offset) * inchpersecondcub_.Factor);
  public double GetValueInInchPerSecondCubs() => (Value_ - inchpersecondcub_.Offset) / inchpersecondcub_.Factor;

#endregion

#region arithmetic
  public static LengthPerTimeCub operator+(LengthPerTimeCub o1, LengthPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ + o2.Value_);
  public static LengthPerTimeCub operator-(LengthPerTimeCub o1, LengthPerTimeCub o2) => new LengthPerTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(LengthPerTimeCub o1, LengthPerTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Area operator*(LengthPerTimeCub o1, TimeCubLength o2) => new Area(o1.Value_ * o2.Value_);
  public static Area operator*(TimeCubLength o1, LengthPerTimeCub o2) => new Area(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator/(LengthPerTimeCub o1, Force o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(Force o1, LengthPerTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static LengthSqrMassPerTime operator*(LengthPerTimeCub o1, TimeSqrLengthMass o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  public static LengthSqrMassPerTime operator*(TimeSqrLengthMass o1, LengthPerTimeCub o2) => new LengthSqrMassPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTimeSqr operator/(LengthPerTimeCub o1, LengthSqrPerMassTime o2) => new MassPerLengthTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthPerMass operator/(LengthSqrPerMassTime o1, LengthPerTimeCub o2) => new TimeSqrLengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTimeSqr operator*(LengthPerTimeCub o1, LengthSqrTimePerMass o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTimeSqr operator*(LengthSqrTimePerMass o1, LengthPerTimeCub o2) => new LengthCubPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthTime operator/(LengthPerTimeCub o1, QDose o2) => new PerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTime operator/(QDose o1, LengthPerTimeCub o2) => new LengthTime(o1.Value_ / o2.Value_);
  
  public static LengthCubPerTime operator*(LengthPerTimeCub o1, LengthSqrTimeSqr o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  public static LengthCubPerTime operator*(LengthSqrTimeSqr o1, LengthPerTimeCub o2) => new LengthCubPerTime(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTimeSqr operator/(LengthPerTimeCub o1, LengthSqrMassPerTime o2) => new PerLengthMassTimeSqr(o1.Value_ / o2.Value_);
  public static TimeSqrLengthMass operator/(LengthSqrMassPerTime o1, LengthPerTimeCub o2) => new TimeSqrLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTimeSqr operator*(LengthPerTimeCub o1, LengthSqrMassTime o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTimeSqr operator*(LengthSqrMassTime o1, LengthPerTimeCub o2) => new LengthCubMassPerTimeSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeCub operator/(LengthPerTimeCub o1, LengthCubPerMass o2) => new MassPerLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrPerMass operator/(LengthCubPerMass o1, LengthPerTimeCub o2) => new TimeCubLengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqrTimeSqr operator/(LengthPerTimeCub o1, LengthCubPerTime o2) => new PerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqr operator/(LengthCubPerTime o1, LengthPerTimeCub o2) => new LengthSqrTimeSqr(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeCub operator/(LengthPerTimeCub o1, LengthCubMass o2) => new PerMassLengthSqrTimeCub(o1.Value_ / o2.Value_);
  public static TimeCubLengthSqrMass operator/(LengthCubMass o1, LengthPerTimeCub o2) => new TimeCubLengthSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator*(LengthPerTimeCub o1, TimePerMassLengthCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqrTimeSqr operator*(TimePerMassLengthCub o1, LengthPerTimeCub o2) => new PerMassLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static PerTimeLengthSqr operator*(LengthPerTimeCub o1, TimeSqrPerLengthCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerTimeLengthSqr operator*(TimeSqrPerLengthCub o1, LengthPerTimeCub o2) => new PerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator*(LengthPerTimeCub o1, MassTimePerLengthCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqrTimeSqr operator*(MassTimePerLengthCub o1, LengthPerTimeCub o2) => new MassPerLengthSqrTimeSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMassPerTime operator/(LengthPerTimeCub o1, PerMassLengthSqrTimeSqr o2) => new LengthCubMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerMassLengthCub operator/(PerMassLengthSqrTimeSqr o1, LengthPerTimeCub o2) => new TimePerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMassTime operator*(LengthPerTimeCub o1, TimeSqrPerMassLengthSqr o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  public static PerLengthMassTime operator*(TimeSqrPerMassLengthSqr o1, LengthPerTimeCub o2) => new PerLengthMassTime(o1.Value_ * o2.Value_);
  
  public static Volume operator/(LengthPerTimeCub o1, PerLengthSqrTimeCub o2) => new Volume(o1.Value_ / o2.Value_);
  public static PerLengthCub operator/(PerLengthSqrTimeCub o1, LengthPerTimeCub o2) => new PerLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLength operator*(LengthPerTimeCub o1, TimeCubPerLengthSqr o2) => new PerLength(o1.Value_ * o2.Value_);
  public static PerLength operator*(TimeCubPerLengthSqr o1, LengthPerTimeCub o2) => new PerLength(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMassTime operator/(LengthPerTimeCub o1, MassPerLengthSqrTimeSqr o2) => new LengthCubPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLengthCub operator/(MassPerLengthSqrTimeSqr o1, LengthPerTimeCub o2) => new MassTimePerLengthCub(o1.Value_ / o2.Value_);
  
  public static MassPerLengthTime operator*(LengthPerTimeCub o1, TimeSqrMassPerLengthSqr o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  public static MassPerLengthTime operator*(TimeSqrMassPerLengthSqr o1, LengthPerTimeCub o2) => new MassPerLengthTime(o1.Value_ * o2.Value_);
  
  public static LengthSqrMass operator/(LengthPerTimeCub o1, PerLengthMassTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  public static PerMassLengthSqr operator/(PerLengthMassTimeCub o1, LengthPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(LengthPerTimeCub o1, TimeCubPerLengthMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimeCubPerLengthMass o1, LengthPerTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static LengthSqrPerMass operator/(LengthPerTimeCub o1, MassPerLengthTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  public static MassPerLengthSqr operator/(MassPerLengthTimeCub o1, LengthPerTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  
  public static Mass operator*(LengthPerTimeCub o1, TimeCubMassPerLength o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(TimeCubMassPerLength o1, LengthPerTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static Mass operator/(LengthPerTimeCub o1, LengthPerMassTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(LengthPerMassTimeCub o1, LengthPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static LengthSqrPerMass operator*(LengthPerTimeCub o1, TimeCubLengthPerMass o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  public static LengthSqrPerMass operator*(TimeCubLengthPerMass o1, LengthPerTimeCub o2) => new LengthSqrPerMass(o1.Value_ * o2.Value_);
  
  public static PerMass operator/(LengthPerTimeCub o1, LengthMassPerTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(LengthMassPerTimeCub o1, LengthPerTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static LengthSqrMass operator*(LengthPerTimeCub o1, TimeCubLengthMass o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  public static LengthSqrMass operator*(TimeCubLengthMass o1, LengthPerTimeCub o2) => new LengthSqrMass(o1.Value_ * o2.Value_);
  
  public static MassPerLengthTime operator/(LengthPerTimeCub o1, LengthSqrPerMassTimeSqr o2) => new MassPerLengthTime(o1.Value_ / o2.Value_);
  public static LengthTimePerMass operator/(LengthSqrPerMassTimeSqr o1, LengthPerTimeCub o2) => new LengthTimePerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMassTime operator*(LengthPerTimeCub o1, LengthSqrTimeSqrPerMass o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  public static LengthCubPerMassTime operator*(LengthSqrTimeSqrPerMass o1, LengthPerTimeCub o2) => new LengthCubPerMassTime(o1.Value_ * o2.Value_);
  
  public static PerLength operator/(LengthPerTimeCub o1, LengthSqrPerTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  public static Length operator/(LengthSqrPerTimeCub o1, LengthPerTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  
  public static Volume operator*(LengthPerTimeCub o1, TimeCubLengthSqr o2) => new Volume(o1.Value_ * o2.Value_);
  public static Volume operator*(TimeCubLengthSqr o1, LengthPerTimeCub o2) => new Volume(o1.Value_ * o2.Value_);
  
  public static PerLengthMassTime operator/(LengthPerTimeCub o1, LengthSqrMassPerTimeSqr o2) => new PerLengthMassTime(o1.Value_ / o2.Value_);
  public static LengthMassTime operator/(LengthSqrMassPerTimeSqr o1, LengthPerTimeCub o2) => new LengthMassTime(o1.Value_ / o2.Value_);
  
  public static LengthCubMassPerTime operator*(LengthPerTimeCub o1, LengthSqrTimeSqrMass o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  public static LengthCubMassPerTime operator*(LengthSqrTimeSqrMass o1, LengthPerTimeCub o2) => new LengthCubMassPerTime(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqrTimeSqr operator/(LengthPerTimeCub o1, LengthCubPerMassTime o2) => new MassPerLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrPerMass operator/(LengthCubPerMassTime o1, LengthPerTimeCub o2) => new LengthSqrTimeSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerTimeLengthSqr operator/(LengthPerTimeCub o1, LengthCubPerTimeSqr o2) => new PerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTime operator/(LengthCubPerTimeSqr o1, LengthPerTimeCub o2) => new LengthSqrTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqrTimeSqr operator/(LengthPerTimeCub o1, LengthCubMassPerTime o2) => new PerMassLengthSqrTimeSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimeSqrMass operator/(LengthCubMassPerTime o1, LengthPerTimeCub o2) => new LengthSqrTimeSqrMass(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator*(LengthPerTimeCub o1, TimeSqrPerMassLengthCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassTimeLengthSqr operator*(TimeSqrPerMassLengthCub o1, LengthPerTimeCub o2) => new PerMassTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static PerLengthSqr operator*(LengthPerTimeCub o1, TimeCubPerLengthCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  public static PerLengthSqr operator*(TimeCubPerLengthCub o1, LengthPerTimeCub o2) => new PerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator*(LengthPerTimeCub o1, TimeSqrMassPerLengthCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerTimeLengthSqr operator*(TimeSqrMassPerLengthCub o1, LengthPerTimeCub o2) => new MassPerTimeLengthSqr(o1.Value_ * o2.Value_);
  
  public static LengthCubMass operator/(LengthPerTimeCub o1, PerMassLengthSqrTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  public static PerMassLengthCub operator/(PerMassLengthSqrTimeCub o1, LengthPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(LengthPerTimeCub o1, TimeCubPerMassLengthSqr o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeCubPerMassLengthSqr o1, LengthPerTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static LengthCubPerMass operator/(LengthPerTimeCub o1, MassPerLengthSqrTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  public static Density operator/(MassPerLengthSqrTimeCub o1, LengthPerTimeCub o2) => new Density(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(LengthPerTimeCub o1, TimeCubMassPerLengthSqr o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeCubMassPerLengthSqr o1, LengthPerTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static MassPerLength operator/(LengthPerTimeCub o1, LengthSqrPerMassTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(LengthSqrPerMassTimeCub o1, LengthPerTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static LengthCubPerMass operator*(LengthPerTimeCub o1, TimeCubLengthSqrPerMass o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  public static LengthCubPerMass operator*(TimeCubLengthSqrPerMass o1, LengthPerTimeCub o2) => new LengthCubPerMass(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(LengthPerTimeCub o1, LengthSqrMassPerTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(LengthSqrMassPerTimeCub o1, LengthPerTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static LengthCubMass operator*(LengthPerTimeCub o1, TimeCubLengthSqrMass o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  public static LengthCubMass operator*(TimeCubLengthSqrMass o1, LengthPerTimeCub o2) => new LengthCubMass(o1.Value_ * o2.Value_);
  
  public static MassPerTimeLengthSqr operator/(LengthPerTimeCub o1, LengthCubPerMassTimeSqr o2) => new MassPerTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrTimePerMass operator/(LengthCubPerMassTimeSqr o1, LengthPerTimeCub o2) => new LengthSqrTimePerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthSqr operator/(LengthPerTimeCub o1, LengthCubPerTimeCub o2) => new PerLengthSqr(o1.Value_ / o2.Value_);
  public static Area operator/(LengthCubPerTimeCub o1, LengthPerTimeCub o2) => new Area(o1.Value_ / o2.Value_);
  
  public static PerMassTimeLengthSqr operator/(LengthPerTimeCub o1, LengthCubMassPerTimeSqr o2) => new PerMassTimeLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMassTime operator/(LengthCubMassPerTimeSqr o1, LengthPerTimeCub o2) => new LengthSqrMassTime(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator*(LengthPerTimeCub o1, TimeCubPerMassLengthCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  public static PerMassLengthSqr operator*(TimeCubPerMassLengthCub o1, LengthPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator*(LengthPerTimeCub o1, TimeCubMassPerLengthCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  public static MassPerLengthSqr operator*(TimeCubMassPerLengthCub o1, LengthPerTimeCub o2) => new MassPerLengthSqr(o1.Value_ * o2.Value_);
  
  public static MassPerLengthSqr operator/(LengthPerTimeCub o1, LengthCubPerMassTimeCub o2) => new MassPerLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrPerMass operator/(LengthCubPerMassTimeCub o1, LengthPerTimeCub o2) => new LengthSqrPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthSqr operator/(LengthPerTimeCub o1, LengthCubMassPerTimeCub o2) => new PerMassLengthSqr(o1.Value_ / o2.Value_);
  public static LengthSqrMass operator/(LengthCubMassPerTimeCub o1, LengthPerTimeCub o2) => new LengthSqrMass(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("LengthPerTimeCub is outside its bounds.");
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
    