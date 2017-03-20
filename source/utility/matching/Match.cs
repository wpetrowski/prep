using System;

namespace code.utility.matching
{
  public static class Match<ItemToMatch>
  {
    public static MatchBuilder<ItemToMatch, Property> with_attribute<Property>(
      PropertyAccessor<ItemToMatch, Property> property_accessor)
    {
      return new MatchBuilder<ItemToMatch, Property>(property_accessor);
    }

    public static ComparableMatchBuilder<ItemToMatch, Property> with_comparable_attribute<Property>(
      PropertyAccessor<ItemToMatch, Property> property_accessor) where Property : IComparable<Property>
    {
      return new ComparableMatchBuilder<ItemToMatch, Property>(property_accessor);
    }
  }
}