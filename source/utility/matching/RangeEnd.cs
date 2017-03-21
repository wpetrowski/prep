using System;

namespace code.utility.matching
{
  public class RangeEnd<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private IKnowHowToRange<Value> rangeStart;
    private Value to;
    private bool is_inclusive;

    public RangeEnd(Value to) : this(new AlwaysInRange<Value>(), to)
    {
    }

    public RangeEnd(IKnowHowToRange<Value> rangeStart, Value to)
    {
      this.rangeStart = rangeStart;
      this.to = to;
    }

    public RangeEnd<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeEnd<Value> exclusive()
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