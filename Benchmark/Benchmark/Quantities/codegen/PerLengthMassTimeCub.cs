
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthMassTimeCub : Quantity, IEquatable<PerLengthMassTimeCub>, IComparable
  {  
    internal PerLengthMassTimeCub(double value) : base(value, 2)
    {
      PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthMassTimeCub(PerLengthMassTimeCub other) : base(other)
    {
      PerLengthMassTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthMassTimeCub"))
    {
      switch(FakeDatabase.Units["PerLengthMassTimeCub"])
      {
        case "percentimeterkilogramsecondcub": displayUnit_ = percentimeterkilogramsecondcub_; break;
        case "permillimeterkilogramsecondcub": displayUnit_ = permillimeterkilogramsecondcub_; break;
        case "permeterkilogramsecondcub": displayUnit_ = permeterkilogramsecondcub_; break;
        case "perinchkilogramsecondcub": displayUnit_ = perinchkilogramsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimeterkilogramsecondcub_ = new Unit_("PerCentimeterKilogramSecondCub", "/cm kg s�", 1.0, 0);
  private static Unit_ permillimeterkilogramsecondcub_ = new Unit_("PerMillimeterKilogramSecondCub", "/mm kg s�", 0.1, 0);
  private static Unit_ permeterkilogramsecondcub_ = new Unit_("PerMeterKilogramSecondCub", "/m kg s�", 100.0, 0);
  private static Unit_ perinchkilogramsecondcub_ = new Unit_("PerInchKilogramSecondCub", "/in kg s�", 2.56, 0);
  private static Unit_ platformUnit_ = percentimeterkilogramsecondcub_;
  private static Unit_ displayUnit_ = percentimeterkilogramsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthMassTimeCub other && Equals(other);
  public bool Equals(PerLengthMassTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthMassTimeCub other) => Value_.CompareTo(other.Value_);
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
  public static PerLengthMassTimeCub FromPerCentimeterKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub((value + percentimeterkilogramsecondcub_.Offset) * percentimeterkilogramsecondcub_.Factor, minValue * percentimeterkilogramsecondcub_.Factor, maxValue * percentimeterkilogramsecondcub_.Factor);
  public static PerLengthMassTimeCub FromPerCentimeterKilogramSecondCubs(double value) => new PerLengthMassTimeCub((value + percentimeterkilogramsecondcub_.Offset) * percentimeterkilogramsecondcub_.Factor);
  public double GetValueInPerCentimeterKilogramSecondCubs() => (Value_ - percentimeterkilogramsecondcub_.Offset) / percentimeterkilogramsecondcub_.Factor;
  public static PerLengthMassTimeCub FromPerMillimeterKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub((value + permillimeterkilogramsecondcub_.Offset) * permillimeterkilogramsecondcub_.Factor, minValue * permillimeterkilogramsecondcub_.Factor, maxValue * permillimeterkilogramsecondcub_.Factor);
  public static PerLengthMassTimeCub FromPerMillimeterKilogramSecondCubs(double value) => new PerLengthMassTimeCub((value + permillimeterkilogramsecondcub_.Offset) * permillimeterkilogramsecondcub_.Factor);
  public double GetValueInPerMillimeterKilogramSecondCubs() => (Value_ - permillimeterkilogramsecondcub_.Offset) / permillimeterkilogramsecondcub_.Factor;
  public static PerLengthMassTimeCub FromPerMeterKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub((value + permeterkilogramsecondcub_.Offset) * permeterkilogramsecondcub_.Factor, minValue * permeterkilogramsecondcub_.Factor, maxValue * permeterkilogramsecondcub_.Factor);
  public static PerLengthMassTimeCub FromPerMeterKilogramSecondCubs(double value) => new PerLengthMassTimeCub((value + permeterkilogramsecondcub_.Offset) * permeterkilogramsecondcub_.Factor);
  public double GetValueInPerMeterKilogramSecondCubs() => (Value_ - permeterkilogramsecondcub_.Offset) / permeterkilogramsecondcub_.Factor;
  public static PerLengthMassTimeCub FromPerInchKilogramSecondCubs(double value, double minValue, double maxValue) => new PerLengthMassTimeCub((value + perinchkilogramsecondcub_.Offset) * perinchkilogramsecondcub_.Factor, minValue * perinchkilogramsecondcub_.Factor, maxValue * perinchkilogramsecondcub_.Factor);
  public static PerLengthMassTimeCub FromPerInchKilogramSecondCubs(double value) => new PerLengthMassTimeCub((value + perinchkilogramsecondcub_.Offset) * perinchkilogramsecondcub_.Factor);
  public double GetValueInPerInchKilogramSecondCubs() => (Value_ - perinchkilogramsecondcub_.Offset) / perinchkilogramsecondcub_.Factor;

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
      throw new System.ArgumentException("PerLengthMassTimeCub is outside its bounds.");
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
    