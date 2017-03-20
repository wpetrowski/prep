using System.Collections.Generic;

namespace code.utility.matching
{
  public class EqualToAny<Value> : IMatchA<Value>
  {
    IList<Value> values;

    public EqualToAny(IEnumerable<Value> values)
    {
      this.values = new List<Value>(values);
    }

    public bool matches(Value item)
    {
      return values.Contains(item);
    }
  }
}