
// GENERATED FILE! (20/10/2020 20:11:30)
// Changes will be lost!
using System;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class Angle : Quantity, IEquatable<Angle>, IComparable
  {  
    internal Angle(double value) : base(value, 2)
    {
      Angle.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal Angle(double value, double minValue, double maxValue) : base(value, 2)
    {
      Angle.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public Angle(Angle other) : base(other)
    {
      Angle.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("Angle"))
    {
      switch(FakeDatabase.Units["Angle"])
      {
        case "radian": displayUnit_ = radian_; break;
        case "degree": displayUnit_ = degree_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ radian_ = new Unit_("Radian", "rad", 1, 0);
  private static Unit_ degree_ = new Unit_("Degree", "°", 0.017453292519943295, 0);
  private static Unit_ platformUnit_ = radian_;
  private static Unit_ displayUnit_ = radian_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is Angle other && Equals(other);
  public bool Equals(Angle other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(Angle other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is Angle other)) throw new ArgumentException("Object is not a Angle.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(Angle l1, Angle l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(Angle l1, Angle l2) => !(l1 == l2);
  public static bool operator <(Angle l1, Angle l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(Angle l1, Angle l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(Angle l1, Angle l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(Angle l1, Angle l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static Angle FromRadians(double value, double minValue, double maxValue) => new Angle((value + radian_.Offset) * radian_.Factor, minValue * radian_.Factor, maxValue * radian_.Factor);
  public static Angle FromRadians(double value) => new Angle((value + radian_.Offset) * radian_.Factor);
  public double GetValueInRadians() => (Value_ - radian_.Offset) / radian_.Factor;
  public static Angle FromDegrees(double value, double minValue, double maxValue) => new Angle((value + degree_.Offset) * degree_.Factor, minValue * degree_.Factor, maxValue * degree_.Factor);
  public static Angle FromDegrees(double value) => new Angle((value + degree_.Offset) * degree_.Factor);
  public double GetValueInDegrees() => (Value_ - degree_.Offset) / degree_.Factor;

#endregion

#region arithmetic
  public static Angle operator+(Angle o1, Angle o2) => new Angle(o1.Value_ + o2.Value_);
  public static Angle operator-(Angle o1, Angle o2) => new Angle(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(Angle o1, Angle o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
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
      throw new System.ArgumentException("Angle is outside its bounds.");
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
    