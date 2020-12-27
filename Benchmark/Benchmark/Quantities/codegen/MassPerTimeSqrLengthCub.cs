
// GENERATE FILE! (27/05/2020 08:55:48)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RayQuantities
{
    
  [Serializable]
  public sealed class MassPerTimeSqrLengthCub : Quantity, IEquatable<MassPerTimeSqrLengthCub>, IComparable
  {  
    internal MassPerTimeSqrLengthCub(double value) : base(value, 2)
    {
      MassPerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      this.ValidateRules();
    }
    internal MassPerTimeSqrLengthCub(double value, double minValue, double maxValue) : base(value, 2)
    {
      MassPerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = true;
      HasMaxValue = true;
      MinValue = minValue;
      MaxValue = maxValue;
      this.ValidateRules();
    }
    public MassPerTimeSqrLengthCub(MassPerTimeSqrLengthCub other) : base(other)
    {
      MassPerTimeSqrLengthCub.ImportDisplayUnitFromDatabase_();
      HasMinValue = other.HasMinValue;
      HasMaxValue = other.HasMaxValue;
      MinValue = other.MinValue;
      MaxValue = other.MaxValue;
      this.ValidateRules();
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
    if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("MassPerTimeSqrLengthCub"))
    {
      switch(FakeDatabase.Units["MassPerTimeSqrLengthCub"])
      {
        case "kilogrampersecondsqrcentimetercub": displayUnit_ = kilogrampersecondsqrcentimetercub_; break;
        case "kilogrampersecondsqrmillimetercub": displayUnit_ = kilogrampersecondsqrmillimetercub_; break;
        case "kilogrampersecondsqrmetercub": displayUnit_ = kilogrampersecondsqrmetercub_; break;
        case "kilogrampersecondsqrinchcub": displayUnit_ = kilogrampersecondsqrinchcub_; break;
        default: displayUnit_ = platformUnit_; break;
      }
    }
    displayUnitIsImported_ = true;
  }
  public override string ToString() => $"{((Value_ - displayUnit_.Offset) / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
  
#region units
  private static Unit_ kilogrampersecondsqrcentimetercub_ = new Unit_("KilogramPerSecondSqrCentimeterCub", "kg/s² cm³", 1.0, 0);
  private static Unit_ kilogrampersecondsqrmillimetercub_ = new Unit_("KilogramPerSecondSqrMillimeterCub", "kg/s² mm³", 999.9999999999998, 0);
  private static Unit_ kilogrampersecondsqrmetercub_ = new Unit_("KilogramPerSecondSqrMeterCub", "kg/s² m³", 1e-06, 0);
  private static Unit_ kilogrampersecondsqrinchcub_ = new Unit_("KilogramPerSecondSqrInchCub", "kg/s² in³", 0.05960464477539062, 0);
  private static Unit_ platformUnit_ = kilogrampersecondsqrcentimetercub_;
  private static Unit_ displayUnit_ = kilogrampersecondsqrcentimetercub_;
#endregion

#region comparisons

  public override int GetHashCode() => base.GetHashCode();
  public override bool Equals(Object obj) => obj is MassPerTimeSqrLengthCub other && Equals(other);
  public bool Equals(MassPerTimeSqrLengthCub other) => other is object && Math.Abs(Value_ - other.Value_) <= epsilon;
  public int CompareTo(MassPerTimeSqrLengthCub other) => Value_.CompareTo(other.Value_);
  public int CompareTo(object obj)
  {
    if (obj is null) throw new ArgumentNullException(nameof(obj));
    if (!(obj is MassPerTimeSqrLengthCub other)) throw new ArgumentException("Object is not a MassPerTimeSqrLengthCub.", nameof(obj));
    return CompareTo(other);
  }

  public static bool operator ==(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => l1 is object && l1.Equals(l2);
  public static bool operator !=(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => !(l1 == l2);
  public static bool operator <(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
  public static bool operator >(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
  public static bool operator <=(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
  public static bool operator >=(MassPerTimeSqrLengthCub l1, MassPerTimeSqrLengthCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrCentimeterCubs(double value, double minValue, double maxValue) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrcentimetercub_.Offset) * kilogrampersecondsqrcentimetercub_.Factor, minValue * kilogrampersecondsqrcentimetercub_.Factor, maxValue * kilogrampersecondsqrcentimetercub_.Factor);
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrCentimeterCubs(double value) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrcentimetercub_.Offset) * kilogrampersecondsqrcentimetercub_.Factor);
  public double GetValueInKilogramPerSecondSqrCentimeterCubs() => (Value_ - kilogrampersecondsqrcentimetercub_.Offset) / kilogrampersecondsqrcentimetercub_.Factor;
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrMillimeterCubs(double value, double minValue, double maxValue) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrmillimetercub_.Offset) * kilogrampersecondsqrmillimetercub_.Factor, minValue * kilogrampersecondsqrmillimetercub_.Factor, maxValue * kilogrampersecondsqrmillimetercub_.Factor);
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrMillimeterCubs(double value) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrmillimetercub_.Offset) * kilogrampersecondsqrmillimetercub_.Factor);
  public double GetValueInKilogramPerSecondSqrMillimeterCubs() => (Value_ - kilogrampersecondsqrmillimetercub_.Offset) / kilogrampersecondsqrmillimetercub_.Factor;
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrMeterCubs(double value, double minValue, double maxValue) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrmetercub_.Offset) * kilogrampersecondsqrmetercub_.Factor, minValue * kilogrampersecondsqrmetercub_.Factor, maxValue * kilogrampersecondsqrmetercub_.Factor);
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrMeterCubs(double value) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrmetercub_.Offset) * kilogrampersecondsqrmetercub_.Factor);
  public double GetValueInKilogramPerSecondSqrMeterCubs() => (Value_ - kilogrampersecondsqrmetercub_.Offset) / kilogrampersecondsqrmetercub_.Factor;
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrInchCubs(double value, double minValue, double maxValue) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrinchcub_.Offset) * kilogrampersecondsqrinchcub_.Factor, minValue * kilogrampersecondsqrinchcub_.Factor, maxValue * kilogrampersecondsqrinchcub_.Factor);
  public static MassPerTimeSqrLengthCub FromKilogramPerSecondSqrInchCubs(double value) => new MassPerTimeSqrLengthCub((value + kilogrampersecondsqrinchcub_.Offset) * kilogrampersecondsqrinchcub_.Factor);
  public double GetValueInKilogramPerSecondSqrInchCubs() => (Value_ - kilogrampersecondsqrinchcub_.Offset) / kilogrampersecondsqrinchcub_.Factor;

#endregion

#region arithmetic
  public static MassPerTimeSqrLengthCub operator+(MassPerTimeSqrLengthCub o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ + o2.Value_);
  public static MassPerTimeSqrLengthCub operator-(MassPerTimeSqrLengthCub o1, MassPerTimeSqrLengthCub o2) => new MassPerTimeSqrLengthCub(o1.Value_ - o2.Value_);
  public static Dimensionless operator/(MassPerTimeSqrLengthCub o1, MassPerTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator/(MassPerTimeSqrLengthCub o1, MassPerLengthSqrTimeCub o2) => new TimePerLength(o1.Value_ / o2.Value_);
  public static Speed operator/(MassPerLengthSqrTimeCub o1, MassPerTimeSqrLengthCub o2) => new Speed(o1.Value_ / o2.Value_);
  
  public static TimePerLength operator*(MassPerTimeSqrLengthCub o1, TimeCubLengthSqrPerMass o2) => new TimePerLength(o1.Value_ * o2.Value_);
  public static TimePerLength operator*(TimeCubLengthSqrPerMass o1, MassPerTimeSqrLengthCub o2) => new TimePerLength(o1.Value_ * o2.Value_);
  
  public static Dimensionless operator*(MassPerTimeSqrLengthCub o1, LengthCubTimeSqrPerMass o2) => new Dimensionless(o1.Value_ * o2.Value_);
  public static Dimensionless operator*(LengthCubTimeSqrPerMass o1, MassPerTimeSqrLengthCub o2) => new Dimensionless(o1.Value_ * o2.Value_);
  
  public static MassTime operator*(MassPerTimeSqrLengthCub o1, LengthCubTimeCub o2) => new MassTime(o1.Value_ * o2.Value_);
  public static MassTime operator*(LengthCubTimeCub o1, MassPerTimeSqrLengthCub o2) => new MassTime(o1.Value_ * o2.Value_);
  
  public static Time operator/(MassPerTimeSqrLengthCub o1, MassPerLengthCubTimeCub o2) => new Time(o1.Value_ / o2.Value_);
  public static PerTime operator/(MassPerLengthCubTimeCub o1, MassPerTimeSqrLengthCub o2) => new PerTime(o1.Value_ / o2.Value_);
  
  public static Time operator*(MassPerTimeSqrLengthCub o1, LengthCubTimeCubPerMass o2) => new Time(o1.Value_ * o2.Value_);
  public static Time operator*(LengthCubTimeCubPerMass o1, MassPerTimeSqrLengthCub o2) => new Time(o1.Value_ * o2.Value_);
  
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
      throw new System.ArgumentException("MassPerTimeSqrLengthCub is outside its bounds.");
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
    