namespace code.utility.matching
{
  public class NeverMatches<Item> : IMatchA<Item>
  {
    public bool matches(Item item)
    {
      return false;
    }
  }
}