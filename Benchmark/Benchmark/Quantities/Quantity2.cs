using System;

namespace RaySearch.QuantityExjobb4
{
  [Serializable]
  public abstract class Quantity
  {

    protected const double epsilon = 1e-9;
    protected int NumberOfDecimalsDisplayed_ { get; }

    protected internal double Value_ { get; }

    protected Quantity(double value, int numberOfDecimalsDisplayed)
    {
      Value_ = value;
      NumberOfDecimalsDisplayed_ = numberOfDecimalsDisplayed;
    }

    protected Quantity(Quantity other)
    {
      Value_ = other.Value_;
      NumberOfDecimalsDisplayed_ = other.NumberOfDecimalsDisplayed_;
    }

    public override int GetHashCode() => Value_.GetHashCode();
    public bool Equals(Quantity other) => other is object && GetType() == other.GetType() && Math.Abs(Value_ - other.Value_) <= epsilon;
    public override bool Equals(object obj)
    {
      if (obj is null) return false;
      if (!(obj is Quantity typedObj)) return false;
      return Equals(typedObj);
    }
    public int CompareTo(Quantity other) => Math.Abs(Value_ - other.Value_) <= epsilon ? 0 : Value_.CompareTo(other.Value_);
    public int CompareTo(object obj)
    {
      if (obj is null) throw new ArgumentNullException(nameof(obj));
      if (!(obj is Quantity other)) throw new ArgumentException("Object is not a Quantity.", nameof(obj));
      return CompareTo(other);
    }

    protected struct Unit_
    {
      public string Name { get; }
      public string Symbol { get; }
      public double Factor { get; }
      public double Offset { get; }
      public Unit_(string name, string symbol, double factor, double offset)
      {
        Name = name;
        Symbol = symbol;
        Factor = factor;
        Offset = offset;
      }

    }

  }
}
