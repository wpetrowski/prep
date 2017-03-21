using System;

namespace code.utility.matching
{
  public class RangeStart<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private Value from;
    private bool is_inclusive;

    public RangeStart(Value from)
    {
      this.from = from;
    }

    public RangeStart<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeStart<Value> exclusive()
    {
      this.is_inclusive = false;
      return this;
    }

    public RangeEnd<Value> upto(Value to)
    {
      return new RangeEnd<Value>(this, to);
    }


    public bool is_in_range(Value value)
    {
      return (is_inclusive ? value.CompareTo(from) >= 0 : value.CompareTo(from) > 0);
    }
  }
}