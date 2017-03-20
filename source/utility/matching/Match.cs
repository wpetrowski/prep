namespace code.utility.matching
{

  public delegate object SelectProperty<T2>(T2 item);

  public static class Match <T>
  {
    public static PropertyCompare<T> with_attribute(SelectProperty<T> selector)
    {
       return new PropertyCompare<T>(selector);
    }
  }

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