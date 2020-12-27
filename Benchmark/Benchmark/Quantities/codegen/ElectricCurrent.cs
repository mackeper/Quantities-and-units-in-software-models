
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class ElectricCurrent : Quantity, IEquatable<ElectricCurrent>, IComparable
  {  
    internal ElectricCurrent(double value) : base(value, 2)
    {
      ElectricCurrent.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal ElectricCurrent(double value, double minValue, double maxValue) : base(value, 2)
    {
      ElectricCurrent.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public ElectricCurrent(ElectricCurrent other) : base(other)
    {
      ElectricCurrent.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("ElectricCurrent"))
    {
      switch(FakeDatabase.Units["ElectricCurrent"])
      {
        case "ampere": displayUnit_ = ampere_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ ampere_ = new Unit_("Ampere", "A", 1, 0);
  private static Unit_ platformUnit_ = ampere_;
  private static Unit_ displayUnit_ = ampere_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is ElectricCurrent other && Equals(other);
  public bool Equals(ElectricCurrent other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(ElectricCurrent other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is ElectricCurrent other)) throw new ArgumentException("Object is not a ElectricCurrent.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(ElectricCurrent l1, ElectricCurrent l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(ElectricCurrent l1, ElectricCurrent l2) => !(l1 == l2);
  public static bool operator <(ElectricCurrent l1, ElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(ElectricCurrent l1, ElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(ElectricCurrent l1, ElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(ElectricCurrent l1, ElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static ElectricCurrent FromAmperes(double value, double minValue, double maxValue) => new ElectricCurrent((value + ampere_.Offset) * ampere_.Factor, minValue * ampere_.Factor, maxValue * ampere_.Factor);
  public static ElectricCurrent FromAmperes(double value) => new ElectricCurrent((value + ampere_.Offset) * ampere_.Factor);
  public double GetValueInAmperes() => (Value_ - ampere_.Offset) / ampere_.Factor;

#endregion

#region arithmetic
  public static ElectricCurrent operator+(ElectricCurrent o1, ElectricCurrent o2) => new ElectricCurrent(o1.Value_ + o2.Value_);
  public static ElectricCurrent operator-(ElectricCurrent o1, ElectricCurrent o2) => new ElectricCurrent(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(ElectricCurrent o1, ElectricCurrent o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("ElectricCurrent is outside its bounds.");
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
    