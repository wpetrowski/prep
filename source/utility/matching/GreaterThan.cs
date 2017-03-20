using System;

namespace code.utility.matching
{
  public class GreaterThan<Value> : IMatchA<Value> where Value : IComparable<Value>
  {
    Value start;

    public GreaterThan(Value start)
    {
      this.start = start;
    }

    public bool matches(Value item)
    {
      return item.CompareTo(start) > 0;
    }
  }

  public class Between<Value> : IMatchA<Value> where Value : IComparable<Value>
  {
    Value start;
    Value end;

    public Between(Value start, Value end)
    {
      this.start = start;
      this.end = end;
    }

    public bool matches(Value item)
    {
      return item.CompareTo(start) >= 0 && item.CompareTo(end) <= 0;
    }
  }
}