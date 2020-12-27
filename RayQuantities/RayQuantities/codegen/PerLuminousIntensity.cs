
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerLuminousIntensity : Quantity, IEquatable<PerLuminousIntensity>, IComparable
  {  
    internal PerLuminousIntensity(double value) : base(value, 2)
    {
      PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerLuminousIntensity(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerLuminousIntensity(PerLuminousIntensity other) : base(other)
    {
      PerLuminousIntensity.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerLuminousIntensity"))
    {
      switch(FakeDatabase.Units["PerLuminousIntensity"])
      {
        case "percandela": displayUnit_ = percandela_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ percandela_ = new Unit_("PerCandela", "/cd", 1.0, 0);
  private static Unit_ platformUnit_ = percandela_;
  private static Unit_ displayUnit_ = percandela_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerLuminousIntensity other && Equals(other);
  public bool Equals(PerLuminousIntensity other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerLuminousIntensity other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerLuminousIntensity other)) throw new ArgumentException("Object is not a PerLuminousIntensity.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerLuminousIntensity l1, PerLuminousIntensity l2) => !(l1 == l2);
  public static bool operator <(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerLuminousIntensity l1, PerLuminousIntensity l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerLuminousIntensity FromPerCandelas(double value, double minValue, double maxValue) => new PerLuminousIntensity((value + percandela_.Offset) * percandela_.Factor, minValue * percandela_.Factor, maxValue * percandela_.Factor);
  public static PerLuminousIntensity FromPerCandelas(double value) => new PerLuminousIntensity((value + percandela_.Offset) * percandela_.Factor);
  public double GetValueInPerCandelas() => (Value_ - percandela_.Offset) / percandela_.Factor;

#endregion

#region arithmetic
  public static PerLuminousIntensity operator+(PerLuminousIntensity o1, PerLuminousIntensity o2) => new PerLuminousIntensity(o1.Value_ + o2.Value_);
  public static PerLuminousIntensity operator-(PerLuminousIntensity o1, PerLuminousIntensity o2) => new PerLuminousIntensity(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerLuminousIntensity o1, PerLuminousIntensity o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerLuminousIntensity o1, LuminousIntensity o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LuminousIntensity o1, PerLuminousIntensity o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerLuminousIntensity is outside its bounds.");
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
    