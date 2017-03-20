namespace code.utility.matching
{
  public static class Match<ItemToMatch>
  {
    public static MatchingExtensionPoint<ItemToMatch, Property> with_attribute<Property>(
      PropertyAccessor<ItemToMatch, Property> property_accessor)
    {
      return new MatchingExtensionPoint<ItemToMatch, Property>(property_accessor);
    }
  }
}