using System;

namespace code.utility.matching
{
  public class RangeStartExtensionPoint<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private Value from;
    private bool is_inclusive;

    public RangeStartExtensionPoint(Value from)
    {
      this.from = from;
    }

    public RangeStartExtensionPoint<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeStartExtensionPoint<Value> exclusive()
    {
      this.is_inclusive = false;
      return this;
    }

    public RangeEndExtensionPoint<Value> upto(Value to)
    {
      return new RangeEndExtensionPoint<Value>(this, to);
    }


    public bool is_in_range(Value value)
    {
      return (is_inclusive ? value.CompareTo(from) >= 0 : value.CompareTo(from) > 0);
    }
  }
}