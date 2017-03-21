using System;
using code.utility;
using code.utility.matching;

namespace code.prep.movies
{
  public class Sort<Item>
  {
    public static ICompareTwoItems<Item> by_descending<Property>(IGetTheValueOfAProperty<Item, Property> accessor) where Property : IComparable<Property>
    {
      return (a, b) => accessor(b).CompareTo(accessor(a));
    }

    public static ICompareTwoItems<Item> by_ascending<Property>(IGetTheValueOfAProperty<Item, Property> accessor) where Property : IComparable<Property>
    {
      return (a, b) => accessor(a).CompareTo(accessor(b));
    }

  }
}