
// GENERATE FILE! (27/05/2020 08:55:47)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class PerAngle : Quantity, IEquatable<PerAngle>, IComparable
  {  
    internal PerAngle(double value) : base(value, 2)
    {
      PerAngle.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal PerAngle(double value, double minValue, double maxValue) : base(value, 2)
    {
      PerAngle.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public PerAngle(PerAngle other) : base(other)
    {
      PerAngle.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("PerAngle"))
    {
      switch(FakeDatabase.Units["PerAngle"])
      {
        case "perradian": displayUnit_ = perradian_; break;
        case "perdegree": displayUnit_ = perdegree_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ perradian_ = new Unit_("PerRadian", "/rad", 1.0, 0);
  private static Unit_ perdegree_ = new Unit_("PerDegree", "/°", 0.017453292519943295, 0);
  private static Unit_ platformUnit_ = perradian_;
  private static Unit_ displayUnit_ = perradian_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is PerAngle other && Equals(other);
  public bool Equals(PerAngle other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(PerAngle other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is PerAngle other)) throw new ArgumentException("Object is not a PerAngle.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(PerAngle l1, PerAngle l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(PerAngle l1, PerAngle l2) => !(l1 == l2);
  public static bool operator <(PerAngle l1, PerAngle l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(PerAngle l1, PerAngle l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(PerAngle l1, PerAngle l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(PerAngle l1, PerAngle l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static PerAngle FromPerRadians(double value, double minValue, double maxValue) => new PerAngle((value + perradian_.Offset) * perradian_.Factor, minValue * perradian_.Factor, maxValue * perradian_.Factor);
  public static PerAngle FromPerRadians(double value) => new PerAngle((value + perradian_.Offset) * perradian_.Factor);
  public double GetValueInPerRadians() => (Value_ - perradian_.Offset) / perradian_.Factor;
  public static PerAngle FromPerDegrees(double value, double minValue, double maxValue) => new PerAngle((value + perdegree_.Offset) * perdegree_.Factor, minValue * perdegree_.Factor, maxValue * perdegree_.Factor);
  public static PerAngle FromPerDegrees(double value) => new PerAngle((value + perdegree_.Offset) * perdegree_.Factor);
  public double GetValueInPerDegrees() => (Value_ - perdegree_.Offset) / perdegree_.Factor;

#endregion

#region arithmetic
  public static PerAngle operator+(PerAngle o1, PerAngle o2) => new PerAngle(o1.Value_ + o2.Value_);
  public static PerAngle operator-(PerAngle o1, PerAngle o2) => new PerAngle(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(PerAngle o1, PerAngle o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static Dimensionless operator*(PerAngle o1, Angle o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(Angle o1, PerAngle o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("PerAngle is outside its bounds.");
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
    