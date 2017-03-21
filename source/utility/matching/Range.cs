using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    
    public static Criteria<Value> between<Value>(Value start, bool inclusiveStart, Value end, bool inclusiveEnd) where Value : IComparable<Value>
    {
      //return x => inclusive ? x.CompareTo(start) >= 0 && x.CompareTo(end) <= 0 : x.CompareTo(start) > 0 && x.CompareTo(end) < 0;
      return before(end, inclusiveEnd).and(after(start, inclusiveStart));
    }
  }
}
