namespace code.utility.matching
{
  public interface IKnowHowToRange<Value>
  {
    bool is_in_range(Value value);
  }
}