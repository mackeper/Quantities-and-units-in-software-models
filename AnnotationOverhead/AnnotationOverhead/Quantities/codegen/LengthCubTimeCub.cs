
// GENERATE FILE! (15/04/2020 13:18:19)
// Changes will be lost!
using System;
using RaySearch.QuantityExjobb4;

namespace RaySearch.CorePlatform.Framework
{
    
    [Serializable]
    public sealed class LengthCubTimeCub : Quantity, IEquatable<LengthCubTimeCub>, IComparable
    {
    internal LengthCubTimeCub(double value) : base(value, 2)
    {
        LengthCubTimeCub.ImportDisplayUnitFromDatabase_();
    }
    internal LengthCubTimeCub(double value, double minValue, double maxValue) : base(value, 2)
    {
        LengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = true;
        HasMaxValue = true;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    public LengthCubTimeCub(LengthCubTimeCub other) : base(other)
    {
        LengthCubTimeCub.ImportDisplayUnitFromDatabase_();
        HasMinValue = other.HasMinValue;
        HasMaxValue = other.HasMaxValue;
        MinValue = other.MinValue;
        MaxValue = other.MaxValue;
    }
    private static bool displayUnitIsImported_ = false;
    private static void ImportDisplayUnitFromDatabase_()
    {
        if (!displayUnitIsImported_ && FakeDatabase.Units.ContainsKey("LengthCubTimeCub"))
        {
            switch(FakeDatabase.Units["LengthCubTimeCub"])
            {
				      case "centimetercubsecondcub": displayUnit_ = centimetercubsecondcub_; break;
				      case "millimetercubsecondcub": displayUnit_ = millimetercubsecondcub_; break;
				      case "metercubsecondcub": displayUnit_ = metercubsecondcub_; break;
				      case "inchcubsecondcub": displayUnit_ = inchcubsecondcub_; break;
				      default: displayUnit_ = platformUnit_; break;
            }
        }
        displayUnitIsImported_ = true;
    }
    public override string ToString() => $"{(Value_ / displayUnit_.Factor).ToString("0." + new String('#', NumberOfDecimalsDisplayed_))} {displayUnit_.Symbol}";
    
#region units
	private static Unit_ centimetercubsecondcub_ = new Unit_("CentimeterCubSecondCub", "cm³ s³", 1);
	private static Unit_ millimetercubsecondcub_ = new Unit_("MillimeterCubSecondCub", "mm³ s³", 0.0010000000000000002);
	private static Unit_ metercubsecondcub_ = new Unit_("MeterCubSecondCub", "m³ s³", 1000000);
	private static Unit_ inchcubsecondcub_ = new Unit_("InchCubSecondCub", "in³ s³", 16.777216000000003);
	private static Unit_ platformUnit_ = centimetercubsecondcub_;
	private static Unit_ displayUnit_ = centimetercubsecondcub_;
#endregion

#region comparisons

    public override int GetHashCode() => base.GetHashCode();
    public override bool Equals(Object obj) => base.Equals(obj);
    public bool Equals(LengthCubTimeCub other) => other is object && Equals((object)other);
    public int CompareTo(LengthCubTimeCub other) => Value_.CompareTo(other?.Value_);
    public int CompareTo(object obj)
    {
        if (obj is null) throw new ArgumentNullException(nameof(obj));
        if (!(obj is LengthCubTimeCub other)) throw new ArgumentException("Object is not a LengthCubTimeCub.", nameof(obj));
        return CompareTo(other);
    }

    public static bool operator ==(LengthCubTimeCub l1, LengthCubTimeCub l2) => l1 is object && l1.Equals(l2);
    public static bool operator !=(LengthCubTimeCub l1, LengthCubTimeCub l2) => !(l1 == l2);
    public static bool operator <(LengthCubTimeCub l1, LengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) < 0;
    public static bool operator >(LengthCubTimeCub l1, LengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) > 0;
    public static bool operator <=(LengthCubTimeCub l1, LengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l1) <= 0;
    public static bool operator >=(LengthCubTimeCub l1, LengthCubTimeCub l2) => l1 is object && l2 is object && l1.CompareTo(l2) >= 0;
    
#endregion

#region conversions
		public static LengthCubTimeCub FromCentimeterCubSecondCubs(double value, double minValue, double maxValue) => new LengthCubTimeCub(value * centimetercubsecondcub_.Factor, minValue * centimetercubsecondcub_.Factor, maxValue * centimetercubsecondcub_.Factor);
		public static LengthCubTimeCub FromCentimeterCubSecondCubs(double value) => new LengthCubTimeCub(value * centimetercubsecondcub_.Factor);
		public double GetValueInCentimeterCubSecondCubs() => Value_ / centimetercubsecondcub_.Factor;
		public static LengthCubTimeCub FromMillimeterCubSecondCubs(double value, double minValue, double maxValue) => new LengthCubTimeCub(value * millimetercubsecondcub_.Factor, minValue * millimetercubsecondcub_.Factor, maxValue * millimetercubsecondcub_.Factor);
		public static LengthCubTimeCub FromMillimeterCubSecondCubs(double value) => new LengthCubTimeCub(value * millimetercubsecondcub_.Factor);
		public double GetValueInMillimeterCubSecondCubs() => Value_ / millimetercubsecondcub_.Factor;
		public static LengthCubTimeCub FromMeterCubSecondCubs(double value, double minValue, double maxValue) => new LengthCubTimeCub(value * metercubsecondcub_.Factor, minValue * metercubsecondcub_.Factor, maxValue * metercubsecondcub_.Factor);
		public static LengthCubTimeCub FromMeterCubSecondCubs(double value) => new LengthCubTimeCub(value * metercubsecondcub_.Factor);
		public double GetValueInMeterCubSecondCubs() => Value_ / metercubsecondcub_.Factor;
		public static LengthCubTimeCub FromInchCubSecondCubs(double value, double minValue, double maxValue) => new LengthCubTimeCub(value * inchcubsecondcub_.Factor, minValue * inchcubsecondcub_.Factor, maxValue * inchcubsecondcub_.Factor);
		public static LengthCubTimeCub FromInchCubSecondCubs(double value) => new LengthCubTimeCub(value * inchcubsecondcub_.Factor);
		public double GetValueInInchCubSecondCubs() => Value_ / inchcubsecondcub_.Factor;

#endregion

#region arithmetic
		public static LengthCubTimeCub operator+(LengthCubTimeCub o1, LengthCubTimeCub o2) => new LengthCubTimeCub(o1.Value_ + o2.Value_);
		public static LengthCubTimeCub operator-(LengthCubTimeCub o1, LengthCubTimeCub o2) => new LengthCubTimeCub(o1.Value_ - o2.Value_);
		public static Dimensionless operator/(LengthCubTimeCub o1, LengthCubTimeCub o2) => new Dimensionless(o1.Value_ / o2.Value_);
		
		public static TimePerMass operator/(LengthCubTimeCub o1, LengthCubTimeSqrMass o2) => new TimePerMass(o1.Value_ / o2.Value_);
		public static MassPerTime operator/(LengthCubTimeSqrMass o1, LengthCubTimeCub o2) => new MassPerTime(o1.Value_ / o2.Value_);
		
		public static PerMass operator*(LengthCubTimeCub o1, PerMassLengthCubTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		public static PerMass operator*(PerMassLengthCubTimeCub o1, LengthCubTimeCub o2) => new PerMass(o1.Value_ * o2.Value_);
		
		public static Mass operator*(LengthCubTimeCub o1, MassPerLengthCubTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		public static Mass operator*(MassPerLengthCubTimeCub o1, LengthCubTimeCub o2) => new Mass(o1.Value_ * o2.Value_);
		
		public static Mass operator/(LengthCubTimeCub o1, LengthCubTimeCubPerMass o2) => new Mass(o1.Value_ / o2.Value_);
		public static PerMass operator/(LengthCubTimeCubPerMass o1, LengthCubTimeCub o2) => new PerMass(o1.Value_ / o2.Value_);
		
		public static PerMass operator/(LengthCubTimeCub o1, LengthCubTimeCubMass o2) => new PerMass(o1.Value_ / o2.Value_);
		public static Mass operator/(LengthCubTimeCubMass o1, LengthCubTimeCub o2) => new Mass(o1.Value_ / o2.Value_);
		
#endregion

#region rules

    public double MinValue { get; }
    public double MaxValue { get; }
    public bool HasMinValue { get; }
    public bool HasMaxValue { get; }
    public static bool ValidateRules(LengthCubTimeCub lengthcubtimecub, bool throwOnFail=true)
    {
        bool fail = false;
        if (lengthcubtimecub.HasMinValue && lengthcubtimecub.Value_ < lengthcubtimecub.MinValue)
        {
            fail = true;
        }

        if (lengthcubtimecub.HasMaxValue && lengthcubtimecub.Value_ > lengthcubtimecub.MaxValue)
        {
            fail = true;
        }

        if (fail && throwOnFail)
        {
            new System.ArgumentException("LengthCubTimeCub is outside its bounds.");
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
    