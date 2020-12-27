
// GENERATED FILE! (20/10/2020 20:11:31)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLengthSqrTimeCub : Quantity, IEquatable<PerLengthSqrTimeCub>, IComparable
  {  
    internal PerLengthSqrTimeCub(double value) : base(value, 2)
    {
      PerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLengthSqrTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLengthSqrTimeCub(PerLengthSqrTimeCub other) : base(other)
    {
      PerLengthSqrTimeCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLengthSqrTimeCub"))
    {
      switch(FakeDatabase.Units["PerLengthSqrTimeCub"])
      {
        case "percentimetersqrsecondcub": displayUnit_ = percentimetersqrsecondcub_; break;
        case "permillimetersqrsecondcub": displayUnit_ = permillimetersqrsecondcub_; break;
        case "permetersqrsecondcub": displayUnit_ = permetersqrsecondcub_; break;
        case "perinchsqrsecondcub": displayUnit_ = perinchsqrsecondcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percentimetersqrsecondcub_ = new Unit_("PerCentimeterSqrSecondCub", "/cm² s³", 1.0, 0);
  private static Unit_ permillimetersqrsecondcub_ = new Unit_("PerMillimeterSqrSecondCub", "/mm² s³", 0.010000000000000002, 0);
  private static Unit_ permetersqrsecondcub_ = new Unit_("PerMeterSqrSecondCub", "/m² s³", 10000.0, 0);
  private static Unit_ perinchsqrsecondcub_ = new Unit_("PerInchSqrSecondCub", "/in² s³", 6.5536, 0);
  private static Unit_ platformUnit_ = percentimetersqrsecondcub_;
  private static Unit_ displayUnit_ = percentimetersqrsecondcub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLengthSqrTimeCub other && Equals(other);
  public bool Equals(PerLengthSqrTimeCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLengthSqrTimeCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLengthSqrTimeCub other)) throw new ArgumentException("Object is not a PerLengthSqrTimeCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => !(l1 == l2);
  public static bool operator <(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLengthSqrTimeCub l1, PerLengthSqrTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLengthSqrTimeCub FromPerCentimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerLengthSqrTimeCub((value + percentimetersqrsecondcub_.Offset) * percentimetersqrsecondcub_.Factor, minValue * percentimetersqrsecondcub_.Factor, maxValue * percentimetersqrsecondcub_.Factor);
  public static PerLengthSqrTimeCub FromPerCentimeterSqrSecondCubs(double value) => new PerLengthSqrTimeCub((value + percentimetersqrsecondcub_.Offset) * percentimetersqrsecondcub_.Factor);
  public double GetValueInPerCentimeterSqrSecondCubs() => (Value_ - percentimetersqrsecondcub_.Offset) / percentimetersqrsecondcub_.Factor;
  public static PerLengthSqrTimeCub FromPerMillimeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerLengthSqrTimeCub((value + permillimetersqrsecondcub_.Offset) * permillimetersqrsecondcub_.Factor, minValue * permillimetersqrsecondcub_.Factor, maxValue * permillimetersqrsecondcub_.Factor);
  public static PerLengthSqrTimeCub FromPerMillimeterSqrSecondCubs(double value) => new PerLengthSqrTimeCub((value + permillimetersqrsecondcub_.Offset) * permillimetersqrsecondcub_.Factor);
  public double GetValueInPerMillimeterSqrSecondCubs() => (Value_ - permillimetersqrsecondcub_.Offset) / permillimetersqrsecondcub_.Factor;
  public static PerLengthSqrTimeCub FromPerMeterSqrSecondCubs(double value, double minValue, double maxValue) => new PerLengthSqrTimeCub((value + permetersqrsecondcub_.Offset) * permetersqrsecondcub_.Factor, minValue * permetersqrsecondcub_.Factor, maxValue * permetersqrsecondcub_.Factor);
  public static PerLengthSqrTimeCub FromPerMeterSqrSecondCubs(double value) => new PerLengthSqrTimeCub((value + permetersqrsecondcub_.Offset) * permetersqrsecondcub_.Factor);
  public double GetValueInPerMeterSqrSecondCubs() => (Value_ - permetersqrsecondcub_.Offset) / permetersqrsecondcub_.Factor;
  public static PerLengthSqrTimeCub FromPerInchSqrSecondCubs(double value, double minValue, double maxValue) => new PerLengthSqrTimeCub((value + perinchsqrsecondcub_.Offset) * perinchsqrsecondcub_.Factor, minValue * perinchsqrsecondcub_.Factor, maxValue * perinchsqrsecondcub_.Factor);
  public static PerLengthSqrTimeCub FromPerInchSqrSecondCubs(double value) => new PerLengthSqrTimeCub((value + perinchsqrsecondcub_.Offset) * perinchsqrsecondcub_.Factor);
  public double GetValueInPerInchSqrSecondCubs() => (Value_ - perinchsqrsecondcub_.Offset) / perinchsqrsecondcub_.Factor;

#endregion

#region arithmetic
  public static PerLengthSqrTimeCub operator+(PerLengthSqrTimeCub o1, PerLengthSqrTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ + o2.Value_);
  public static PerLengthSqrTimeCub operator-(PerLengthSqrTimeCub o1, PerLengthSqrTimeCub o2) => new PerLengthSqrTimeCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLengthSqrTimeCub o1, PerLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static PerMassTime operator/(PerLengthSqrTimeCub o1, MassPerLengthSqrTimeSqr o2) => new PerMassTime(o1.Value_ / o2.Value_);
  public static MassTime operator/(MassPerLengthSqrTimeSqr o1, PerLengthSqrTimeCub o2) => new MassTime(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator/(PerLengthSqrTimeCub o1, PerLengthMassTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  public static LengthPerMass operator/(PerLengthMassTimeCub o1, PerLengthSqrTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  
  public static PerMassLengthCub operator*(PerLengthSqrTimeCub o1, TimeCubPerLengthMass o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  public static PerMassLengthCub operator*(TimeCubPerLengthMass o1, PerLengthSqrTimeCub o2) => new PerMassLengthCub(o1.Value_ * o2.Value_);
  
  public static PerLengthMass operator/(PerLengthSqrTimeCub o1, MassPerLengthTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  public static LengthMass operator/(MassPerLengthTimeCub o1, PerLengthSqrTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  
  public static Density operator*(PerLengthSqrTimeCub o1, TimeCubMassPerLength o2) => new Density(o1.Value_ * o2.Value_);
  public static Density operator*(TimeCubMassPerLength o1, PerLengthSqrTimeCub o2) => new Density(o1.Value_ * o2.Value_);
  
  public static Density operator/(PerLengthSqrTimeCub o1, LengthPerMassTimeCub o2) => new Density(o1.Value_ / o2.Value_);
  public static LengthCubPerMass operator/(LengthPerMassTimeCub o1, PerLengthSqrTimeCub o2) => new LengthCubPerMass(o1.Value_ / o2.Value_);
  
  public static PerLengthMass operator*(PerLengthSqrTimeCub o1, TimeCubLengthPerMass o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  public static PerLengthMass operator*(TimeCubLengthPerMass o1, PerLengthSqrTimeCub o2) => new PerLengthMass(o1.Value_ * o2.Value_);
  
  public static PerMassLengthCub operator/(PerLengthSqrTimeCub o1, LengthMassPerTimeCub o2) => new PerMassLengthCub(o1.Value_ / o2.Value_);
  public static LengthCubMass operator/(LengthMassPerTimeCub o1, PerLengthSqrTimeCub o2) => new LengthCubMass(o1.Value_ / o2.Value_);
  
  public static MassPerLength operator*(PerLengthSqrTimeCub o1, TimeCubLengthMass o2) => new MassPerLength(o1.Value_ * o2.Value_);
  public static MassPerLength operator*(TimeCubLengthMass o1, PerLengthSqrTimeCub o2) => new MassPerLength(o1.Value_ * o2.Value_);
  
  public static PerMassTime operator*(PerLengthSqrTimeCub o1, LengthSqrTimeSqrPerMass o2) => new PerMassTime(o1.Value_ * o2.Value_);
  public static PerMassTime operator*(LengthSqrTimeSqrPerMass o1, PerLengthSqrTimeCub o2) => new PerMassTime(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(PerLengthSqrTimeCub o1, TimeCubLengthSqr o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(TimeCubLengthSqr o1, PerLengthSqrTimeCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassPerTime operator*(PerLengthSqrTimeCub o1, LengthSqrTimeSqrMass o2) => new MassPerTime(o1.Value_ * o2.Value_);
  public static MassPerTime operator*(LengthSqrTimeSqrMass o1, PerLengthSqrTimeCub o2) => new MassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTimeSqr operator*(PerLengthSqrTimeCub o1, LengthCubTimePerMass o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  public static LengthPerMassTimeSqr operator*(LengthCubTimePerMass o1, PerLengthSqrTimeCub o2) => new LengthPerMassTimeSqr(o1.Value_ * o2.Value_);
  
  public static Speed operator*(PerLengthSqrTimeCub o1, LengthCubTimeSqr o2) => new Speed(o1.Value_ * o2.Value_);
  public static Speed operator*(LengthCubTimeSqr o1, PerLengthSqrTimeCub o2) => new Speed(o1.Value_ * o2.Value_);
  
  public static Force operator*(PerLengthSqrTimeCub o1, LengthCubMassTime o2) => new Force(o1.Value_ * o2.Value_);
  public static Force operator*(LengthCubMassTime o1, PerLengthSqrTimeCub o2) => new Force(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator/(PerLengthSqrTimeCub o1, PerMassTimeSqrLengthCub o2) => new LengthMassPerTime(o1.Value_ / o2.Value_);
  public static TimePerLengthMass operator/(PerMassTimeSqrLengthCub o1, PerLengthSqrTimeCub o2) => new TimePerLengthMass(o1.Value_ / o2.Value_);
  
  public static Length operator/(PerLengthSqrTimeCub o1, PerLengthCubTimeCub o2) => new Length(o1.Value_ / o2.Value_);
  public static PerLength operator/(PerLengthCubTimeCub o1, PerLengthSqrTimeCub o2) => new PerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMassTime operator/(PerLengthSqrTimeCub o1, MassPerTimeSqrLengthCub o2) => new LengthPerMassTime(o1.Value_ / o2.Value_);
  public static MassTimePerLength operator/(MassPerTimeSqrLengthCub o1, PerLengthSqrTimeCub o2) => new MassTimePerLength(o1.Value_ / o2.Value_);
  
  public static Mass operator/(PerLengthSqrTimeCub o1, PerMassLengthSqrTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  public static PerMass operator/(PerMassLengthSqrTimeCub o1, PerLengthSqrTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  
  public static PerMass operator/(PerLengthSqrTimeCub o1, MassPerLengthSqrTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
  public static Mass operator/(MassPerLengthSqrTimeCub o1, PerLengthSqrTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
  
  public static PerMass operator*(PerLengthSqrTimeCub o1, TimeCubLengthSqrPerMass o2) => new PerMass(o1.Value_ * o2.Value_);
  public static PerMass operator*(TimeCubLengthSqrPerMass o1, PerLengthSqrTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
  
  public static Mass operator*(PerLengthSqrTimeCub o1, TimeCubLengthSqrMass o2) => new Mass(o1.Value_ * o2.Value_);
  public static Mass operator*(TimeCubLengthSqrMass o1, PerLengthSqrTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
  
  public static LengthPerMassTime operator*(PerLengthSqrTimeCub o1, LengthCubTimeSqrPerMass o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  public static LengthPerMassTime operator*(LengthCubTimeSqrPerMass o1, PerLengthSqrTimeCub o2) => new LengthPerMassTime(o1.Value_ * o2.Value_);
  
  public static Length operator*(PerLengthSqrTimeCub o1, LengthCubTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  public static Length operator*(LengthCubTimeCub o1, PerLengthSqrTimeCub o2) => new Length(o1.Value_ * o2.Value_);
  
  public static LengthMassPerTime operator*(PerLengthSqrTimeCub o1, LengthCubTimeSqrMass o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  public static LengthMassPerTime operator*(LengthCubTimeSqrMass o1, PerLengthSqrTimeCub o2) => new LengthMassPerTime(o1.Value_ * o2.Value_);
  
  public static LengthMass operator/(PerLengthSqrTimeCub o1, PerMassLengthCubTimeCub o2) => new LengthMass(o1.Value_ / o2.Value_);
  public static PerLengthMass operator/(PerMassLengthCubTimeCub o1, PerLengthSqrTimeCub o2) => new PerLengthMass(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator/(PerLengthSqrTimeCub o1, MassPerLengthCubTimeCub o2) => new LengthPerMass(o1.Value_ / o2.Value_);
  public static MassPerLength operator/(MassPerLengthCubTimeCub o1, PerLengthSqrTimeCub o2) => new MassPerLength(o1.Value_ / o2.Value_);
  
  public static LengthPerMass operator*(PerLengthSqrTimeCub o1, LengthCubTimeCubPerMass o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  public static LengthPerMass operator*(LengthCubTimeCubPerMass o1, PerLengthSqrTimeCub o2) => new LengthPerMass(o1.Value_ * o2.Value_);
  
  public static LengthMass operator*(PerLengthSqrTimeCub o1, LengthCubTimeCubMass o2) => new LengthMass(o1.Value_ * o2.Value_);
  public static LengthMass operator*(LengthCubTimeCubMass o1, PerLengthSqrTimeCub o2) => new LengthMass(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLengthSqrTimeCub is outside its bounds.");
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
    