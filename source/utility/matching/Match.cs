namespace code.utility.matching
{
  public static class Match<ItemToMatch>
  {
    public static MatchBuilder<ItemToMatch, Property> with_attribute<Property>(
      PropertyAccessor<ItemToMatch, Property> property_accessor)
    {
      return new MatchBuilder<ItemToMatch, Property>(property_accessor);
    }
  }
}