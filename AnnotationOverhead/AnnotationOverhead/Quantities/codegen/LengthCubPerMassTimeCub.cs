
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubPerMassTimeCub : Quantity, IEquatable<LengthCubPerMassTimeCub>, IComparable
    {
    internal LengthCubPerMassTimeCub(double value) : base(value, 2)
    {
        LengthCubPerMassTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubPerMassTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubPerMassTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubPerMassTimeCub(LengthCubPerMassTimeCub other) : base(other)
    {
        LengthCubPerMassTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubPerMassTimeCub"))
        {
            switch(FakeDatabase.Units["LengthCubPerMassTimeCub"])
            {
				      case "centimetercubperkilogramsecondcub": displayUnit_ = centimetercubperkilogramsecondcub_; break;
				      case "millimetercubperkilogramsecondcub": displayUnit_ = millimetercubperkilogramsecondcub_; break;
				      case "metercubperkilogramsecondcub": displayUnit_ = metercubperkilogramsecondcub_; break;
				      case "inchcubperkilogramsecondcub": displayUnit_ = inchcubperkilogramsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubperkilogramsecondcub_ = new Unit_("CentimeterCubPerKilogramSecondCub", "cm³/kg s³", 1.0);
	private static Unit_ millimetercubperkilogramsecondcub_ = new Unit_("MillimeterCubPerKilogramSecondCub", "mm³/kg s³", 0.0010000000000000002);
	private static Unit_ metercubperkilogramsecondcub_ = new Unit_("MeterCubPerKilogramSecondCub", "m³/kg s³", 1000000.0);
	private static Unit_ inchcubperkilogramsecondcub_ = new Unit_("InchCubPerKilogramSecondCub", "in³/kg s³", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubperkilogramsecondcub_;
	private static Unit_ displayUnit_ = centimetercubperkilogramsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubPerMassTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubPerMassTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubPerMassTimeCub other)) throw new ArgumentException("Object is not a LengthCubPerMassTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => !(l1 == l2);
    public static bool operator <(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubPerMassTimeCub l1, LengthCubPerMassTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubPerMassTimeCub FromCentimeterCubPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeCub(value * centimetercubperkilogramsecondcub_.Factor, minValue * centimetercubperkilogramsecondcub_.Factor, maxValue * centimetercubperkilogramsecondcub_.Factor);
		public static LengthCubPerMassTimeCub FromCentimeterCubPerKilogramSecondCubs(double value) => new LengthCubPerMassTimeCub(value * centimetercubperkilogramsecondcub_.Factor);
		public double GetValueInCentimeterCubPerKilogramSecondCubs() => Value_ / centimetercubperkilogramsecondcub_.Factor;
		public static LengthCubPerMassTimeCub FromMillimeterCubPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeCub(value * millimetercubperkilogramsecondcub_.Factor, minValue * millimetercubperkilogramsecondcub_.Factor, maxValue * millimetercubperkilogramsecondcub_.Factor);
		public static LengthCubPerMassTimeCub FromMillimeterCubPerKilogramSecondCubs(double value) => new LengthCubPerMassTimeCub(value * millimetercubperkilogramsecondcub_.Factor);
		public double GetValueInMillimeterCubPerKilogramSecondCubs() => Value_ / millimetercubperkilogramsecondcub_.Factor;
		public static LengthCubPerMassTimeCub FromMeterCubPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeCub(value * metercubperkilogramsecondcub_.Factor, minValue * metercubperkilogramsecondcub_.Factor, maxValue * metercubperkilogramsecondcub_.Factor);
		public static LengthCubPerMassTimeCub FromMeterCubPerKilogramSecondCubs(double value) => new LengthCubPerMassTimeCub(value * metercubperkilogramsecondcub_.Factor);
		public double GetValueInMeterCubPerKilogramSecondCubs() => Value_ / metercubperkilogramsecondcub_.Factor;
		public static LengthCubPerMassTimeCub FromInchCubPerKilogramSecondCubs(double value, double minValue, double maxValue) => new LengthCubPerMassTimeCub(value * inchcubperkilogramsecondcub_.Factor, minValue * inchcubperkilogramsecondcub_.Factor, maxValue * inchcubperkilogramsecondcub_.Factor);
		public static LengthCubPerMassTimeCub FromInchCubPerKilogramSecondCubs(double value) => new LengthCubPerMassTimeCub(value * inchcubperkilogramsecondcub_.Factor);
		public double GetValueInInchCubPerKilogramSecondCubs() => Value_ / inchcubperkilogramsecondcub_.Factor;

#endregion

#region arithmetic
		public static LengthCubPerMassTimeCub operator+(LengthCubPerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ + o2.Value_);
		public static LengthCubPerMassTimeCub operator-(LengthCubPerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new LengthCubPerMassTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubPerMassTimeCub o1, LengthCubPerMassTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubPerMassTimeCub lengthcubpermasstimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubpermasstimecub.HasMinValue && lengthcubpermasstimecub.Value_ < lengthcubpermasstimecub.MinValue)
        {
            fail = true;
        }

        if (lengthcubpermasstimecub.HasMaxValue && lengthcubpermasstimecub.Value_ > lengthcubpermasstimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubPerMassTimeCub is outside its bounds.");
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
    