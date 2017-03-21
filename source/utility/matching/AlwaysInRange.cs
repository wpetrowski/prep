namespace code.utility.matching
{
  public class AlwaysInRange<Value> : IKnowHowToRange<Value>
  {
    public bool is_in_range(Value value)
    {
      return true;
    }
  }
}