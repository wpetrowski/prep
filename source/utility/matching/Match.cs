namespace code.utility.matching
{
  public static class Match <T>
  {
    public static PropertyCompare<T> with_attribute(SelectProperty<T> selector)
    {
       return new PropertyCompare<T>(selector);
    }
  }
}