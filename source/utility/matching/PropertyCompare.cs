namespace code.utility.matching
{
  public class PropertyCompare<T>
  {
    private readonly SelectProperty<T> _selector;

    public PropertyCompare(SelectProperty<T> selector)
    {
      _selector = selector;
    }

    public IMatchA<T> equal_to(object value)
    {
      return new CriteriaMatch<T>(x => _selector(x) == value);
    }
  }
}