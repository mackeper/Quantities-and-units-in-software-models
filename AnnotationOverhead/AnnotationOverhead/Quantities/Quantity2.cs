using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaySearch.QuantityExjobb4
{
  [Serializable]
  public abstract class Quantity
  {
    protected int NumberOfDecimalsDisplayed_ { get; }

    protected internal double Value_ { get; }

    protected Quantity(double value, int numberOfDecimalsDisplayed)
    {
      Value_ = value;
      NumberOfDecimalsDisplayed_ = numberOfDecimalsDisplayed;
    }

    protected Quantity(Quantity other)// : base(other.Value_)
    {
      Value_ = other.Value_;
      NumberOfDecimalsDisplayed_ = other.NumberOfDecimalsDisplayed_;
    }

    public bool Equals(Quantity other) => other is object && GetType() == other.GetType() && Value_.Equals(other.Value_);
    public override bool Equals(object obj)
    {
      if (obj is null)
        return false;

      if (!(obj is Quantity typedObj))
        return false;

      return Equals(typedObj);
    }
    public override int GetHashCode() => Value_.GetHashCode();

    protected struct Unit_
    {
      public string Name { get; }
      public string Symbol { get; }
      public double Factor { get; }
      public Unit_(string name, string symbol, double factor)
      {
        Name = name;
        Symbol = symbol;
        Factor = factor;
      }

    }

  }
}
