
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerElectricCurrent : Quantity, IEquatable<PerElectricCurrent>, IComparable
  {  
    internal PerElectricCurrent(double value) : base(value, 2)
    {
      PerElectricCurrent.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerElectricCurrent(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerElectricCurrent.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerElectricCurrent(PerElectricCurrent other) : base(other)
    {
      PerElectricCurrent.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerElectricCurrent"))
    {
      switch(FakeDatabase.Units["PerElectricCurrent"])
      {
        case "perampere": displayUnit_ = perampere_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perampere_ = new Unit_("PerAmpere", "/A", 1.0, 0);
  private static Unit_ platformUnit_ = perampere_;
  private static Unit_ displayUnit_ = perampere_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerElectricCurrent other && Equals(other);
  public bool Equals(PerElectricCurrent other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerElectricCurrent other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerElectricCurrent other)) throw new ArgumentException("Object is not a PerElectricCurrent.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerElectricCurrent l1, PerElectricCurrent l2) => !(l1 == l2);
  public static bool operator <(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerElectricCurrent l1, PerElectricCurrent l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerElectricCurrent FromPerAmperes(double value, double minValue, double maxValue) => new PerElectricCurrent((value + perampere_.Offset) * perampere_.Factor, minValue * perampere_.Factor, maxValue * perampere_.Factor);
  public static PerElectricCurrent FromPerAmperes(double value) => new PerElectricCurrent((value + perampere_.Offset) * perampere_.Factor);
  public double GetValueInPerAmperes() => (Value_ - perampere_.Offset) / perampere_.Factor;

#endregion

#region arithmetic
  public static PerElectricCurrent operator+(PerElectricCurrent o1, PerElectricCurrent o2) => new PerElectricCurrent(o1.Value_ + o2.Value_);
  public static PerElectricCurrent operator-(PerElectricCurrent o1, PerElectricCurrent o2) => new PerElectricCurrent(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerElectricCurrent o1, PerElectricCurrent o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerElectricCurrent o1, ElectricCurrent o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(ElectricCurrent o1, PerElectricCurrent o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerElectricCurrent is outside its bounds.");
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
    