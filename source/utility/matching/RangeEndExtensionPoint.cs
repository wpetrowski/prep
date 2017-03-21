using System;

namespace code.utility.matching
{
  public class RangeEndExtensionPoint<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private IKnowHowToRange<Value> rangeStart;
    private Value to;
    private bool is_inclusive;

    public RangeEndExtensionPoint(Value to) : this(new AlwaysInStartRange<Value>(), to)
    {
    }

    public RangeEndExtensionPoint(IKnowHowToRange<Value> rangeStart, Value to)
    {
      this.rangeStart = rangeStart;
      this.to = to;
    }

    public RangeEndExtensionPoint<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeEndExtensionPoint<Value> exclusive()
    {
      this.is_inclusive = false;
      return this;
    }

    public bool is_in_range(Value value)
    {
      return (is_inclusive ? value.CompareTo(to) <= 0 : value.CompareTo(to) < 0) && rangeStart.is_in_range(value);
    }
  }
}