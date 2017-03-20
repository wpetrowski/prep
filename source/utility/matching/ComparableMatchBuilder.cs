using System;

namespace code.utility.matching
{
  public class ComparableMatchBuilder<Item, Property> where Property : IComparable<Property>
  {
    PropertyAccessor<Item, Property> accessor;

    public ComparableMatchBuilder(PropertyAccessor<Item, Property> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchA<Item> greater_than(Property value)
    {
      return MatchFactory.CreateMatcher<Item>(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchA<Item> between(Property start, Property end)
    {
      return MatchFactory.CreateMatcher<Item>(x =>
      {
        var value = accessor(x);
        return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
      });
    }
  }
}