
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Temperature : Quantity, IEquatable<Temperature>, IComparable
  {  
    internal Temperature(double value) : base(value, 2)
    {
      Temperature.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Temperature(double value, double minValue, double maxValue) : base(value, 2)
    {
      Temperature.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Temperature(Temperature other) : base(other)
    {
      Temperature.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Temperature"))
    {
      switch(FakeDatabase.Units["Temperature"])
      {
        case "kelvin": displayUnit_ = kelvin_; break;
        case "celsius": displayUnit_ = celsius_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kelvin_ = new Unit_("Kelvin", "K", 1, 0);
  private static Unit_ celsius_ = new Unit_("Celsius", "°C", 1, 273.15);
  private static Unit_ platformUnit_ = kelvin_;
  private static Unit_ displayUnit_ = kelvin_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Temperature other && Equals(other);
  public bool Equals(Temperature other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Temperature other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Temperature other)) throw new ArgumentException("Object is not a Temperature.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Temperature l1, Temperature l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Temperature l1, Temperature l2) => !(l1 == l2);
  public static bool operator <(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Temperature l1, Temperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Temperature FromKelvins(double value, double minValue, double maxValue) => new Temperature((value + kelvin_.Offset) * kelvin_.Factor, minValue * kelvin_.Factor, maxValue * kelvin_.Factor);
  public static Temperature FromKelvins(double value) => new Temperature((value + kelvin_.Offset) * kelvin_.Factor);
  public double GetValueInKelvins() => (Value_ - kelvin_.Offset) / kelvin_.Factor;
  public static Temperature FromCelsiuss(double value, double minValue, double maxValue) => new Temperature((value + celsius_.Offset) * celsius_.Factor, minValue * celsius_.Factor, maxValue * celsius_.Factor);
  public static Temperature FromCelsiuss(double value) => new Temperature((value + celsius_.Offset) * celsius_.Factor);
  public double GetValueInCelsiuss() => (Value_ - celsius_.Offset) / celsius_.Factor;

#endregion

#region arithmetic
  public static Temperature operator+(Temperature o1, Temperature o2) => new Temperature(o1.Value_ + o2.Value_);
  public static Temperature operator-(Temperature o1, Temperature o2) => new Temperature(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Temperature o1, Temperature o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Temperature is outside its bounds.");
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
    