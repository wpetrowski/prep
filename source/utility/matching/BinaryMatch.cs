namespace code.utility.matching
{
  public class BinaryMatch<Item> : IMatchA<Item>
  {
    IMatchA<Item> left;
    IMatchA<Item> right;
    public delegate bool Compare(bool condition1, bool condition2);
    public Compare compare;

    public BinaryMatch(IMatchA<Item> left, IMatchA<Item> right, Compare compare)
    {
      this.left = left;
      this.right = right;
      this.compare = compare;
    }

    public bool matches(Item item)
    {
      return compare(left.matches(item), right.matches(item));
    }
  }
}