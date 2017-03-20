namespace code.utility.matching
{
  public class PropertyMatch<Item, Property> : IMatchA<Item>
  {
    PropertyAccessor<Item, Property> accessor;
    IMatchA<Property> value_specification;

    public PropertyMatch(PropertyAccessor<Item, Property> accessor,IMatchA<Property> value_specification)
    {
      this.accessor = accessor;
      this.value_specification = value_specification;
    }

    public bool matches(Item item)
    {
      var value = accessor(item);
      return value_specification.matches(value);
    }
  }
}