
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerAmountOfSubstance : Quantity, IEquatable<PerAmountOfSubstance>, IComparable
  {  
    internal PerAmountOfSubstance(double value) : base(value, 2)
    {
      PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerAmountOfSubstance(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerAmountOfSubstance(PerAmountOfSubstance other) : base(other)
    {
      PerAmountOfSubstance.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerAmountOfSubstance"))
    {
      switch(FakeDatabase.Units["PerAmountOfSubstance"])
      {
        case "permole": displayUnit_ = permole_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ permole_ = new Unit_("PerMole", "/mol", 1.0, 0);
  private static Unit_ platformUnit_ = permole_;
  private static Unit_ displayUnit_ = permole_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerAmountOfSubstance other && Equals(other);
  public bool Equals(PerAmountOfSubstance other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerAmountOfSubstance other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerAmountOfSubstance other)) throw new ArgumentException("Object is not a PerAmountOfSubstance.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => !(l1 == l2);
  public static bool operator <(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerAmountOfSubstance l1, PerAmountOfSubstance l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerAmountOfSubstance FromPerMoles(double value, double minValue, double maxValue) => new PerAmountOfSubstance((value + permole_.Offset) * permole_.Factor, minValue * permole_.Factor, maxValue * permole_.Factor);
  public static PerAmountOfSubstance FromPerMoles(double value) => new PerAmountOfSubstance((value + permole_.Offset) * permole_.Factor);
  public double GetValueInPerMoles() => (Value_ - permole_.Offset) / permole_.Factor;

#endregion

#region arithmetic
  public static PerAmountOfSubstance operator+(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new PerAmountOfSubstance(o1.Value_ + o2.Value_);
  public static PerAmountOfSubstance operator-(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new PerAmountOfSubstance(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerAmountOfSubstance o1, PerAmountOfSubstance o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerAmountOfSubstance o1, AmountOfSubstance o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(AmountOfSubstance o1, PerAmountOfSubstance o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerAmountOfSubstance is outside its bounds.");
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
    