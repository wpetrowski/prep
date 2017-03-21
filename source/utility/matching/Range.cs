using System;
using code.prep.movies;

namespace code.utility.matching
{
  public class Range
  {
    public static RangeStartExtensionPoint<Value> from<Value>(Value from) where Value : IComparable<Value>
    {
      return new RangeStartExtensionPoint<Value>(from);
    }

    public static RangeEndExtensionPoint<Value> upto<Value>(Value to) where Value : IComparable<Value>
    {
      return new RangeEndExtensionPoint<Value>(to);
    }
  }

  public static class RangeExtensions
  {
    public static Criteria<Item> falls_in<Item, Property>(this IProvideAccessToMatchBuilders<Item,Property> extension_point, IKnowHowToRange<Property> range)
    {
      return extension_point.create(range.is_in_range);
    }
  }
}