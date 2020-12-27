
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerTemperature : Quantity, IEquatable<PerTemperature>, IComparable
  {  
    internal PerTemperature(double value) : base(value, 2)
    {
      PerTemperature.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerTemperature(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerTemperature.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerTemperature(PerTemperature other) : base(other)
    {
      PerTemperature.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerTemperature"))
    {
      switch(FakeDatabase.Units["PerTemperature"])
      {
        case "perkelvin": displayUnit_ = perkelvin_; break;
        case "percelsius": displayUnit_ = percelsius_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perkelvin_ = new Unit_("PerKelvin", "/K", 1.0, 0);
  private static Unit_ percelsius_ = new Unit_("PerCelsius", "/°C", 1.0, 273.15);
  private static Unit_ platformUnit_ = perkelvin_;
  private static Unit_ displayUnit_ = perkelvin_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerTemperature other && Equals(other);
  public bool Equals(PerTemperature other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerTemperature other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerTemperature other)) throw new ArgumentException("Object is not a PerTemperature.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerTemperature l1, PerTemperature l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerTemperature l1, PerTemperature l2) => !(l1 == l2);
  public static bool operator <(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerTemperature l1, PerTemperature l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerTemperature FromPerKelvins(double value, double minValue, double maxValue) => new PerTemperature((value + perkelvin_.Offset) * perkelvin_.Factor, minValue * perkelvin_.Factor, maxValue * perkelvin_.Factor);
  public static PerTemperature FromPerKelvins(double value) => new PerTemperature((value + perkelvin_.Offset) * perkelvin_.Factor);
  public double GetValueInPerKelvins() => (Value_ - perkelvin_.Offset) / perkelvin_.Factor;
  public static PerTemperature FromPerCelsiuss(double value, double minValue, double maxValue) => new PerTemperature((value + percelsius_.Offset) * percelsius_.Factor, minValue * percelsius_.Factor, maxValue * percelsius_.Factor);
  public static PerTemperature FromPerCelsiuss(double value) => new PerTemperature((value + percelsius_.Offset) * percelsius_.Factor);
  public double GetValueInPerCelsiuss() => (Value_ - percelsius_.Offset) / percelsius_.Factor;

#endregion

#region arithmetic
  public static PerTemperature operator+(PerTemperature o1, PerTemperature o2) => new PerTemperature(o1.Value_ + o2.Value_);
  public static PerTemperature operator-(PerTemperature o1, PerTemperature o2) => new PerTemperature(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerTemperature o1, PerTemperature o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerTemperature o1, Temperature o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Temperature o1, PerTemperature o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerTemperature is outside its bounds.");
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
    