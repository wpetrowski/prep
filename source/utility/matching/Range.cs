using System;

namespace code.utility.matching
{
  public static class Range
  {
    public static Criteria<Value> after<Value>(Value value, bool inclusive) where Value : IComparable<Value>
    {
      return x => inclusive ? x.CompareTo(value) >= 0 : x.CompareTo(value) > 0;
    }

    public static Criteria<Value> before<Value>(Value value, bool inclusive) where Value : IComparable<Value>
    {
      return x => inclusive ? x.CompareTo(value) <= 0 : x.CompareTo(value) < 0;
    }

    public static Criteria<Value> between<Value>(Value start, bool inclusive_start, Value end, bool inclusive_end)
      where Value : IComparable<Value>
    {
      return before(end, inclusive_end).and(after(start, inclusive_start));
    }

  }

}