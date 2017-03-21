using System;
using code.utility;
using code.utility.matching;

namespace code.prep.movies
{
  public class Sort<Item>
  {
    public static ICompareTwoItems<Item> by<Property>(IGetTheValueOfAProperty<Item, Property> accessor, SortStrategy sort_order) where Property : IComparable<Property>
    {
      return (a, b) => sort_order(accessor(a).CompareTo(accessor(b)));
    }

    public static ICompareTwoItems<Item> by<Property>(IGetTheValueOfAProperty<Item, Property> accessor, params Property[] sort_order)
    {
      return (a, b) => Array.IndexOf(sort_order, accessor(a)) - Array.IndexOf(sort_order, accessor(b));
    }
  }

  public class SortOrder
  {
    public static SortStrategy ascending = a => a;
    public static SortStrategy descending = a => -a;
  }

  public delegate int SortStrategy(int value);

  public static class SortExtensions
  {
    public static ICompareTwoItems<Item> then_by<Item, Property>(this ICompareTwoItems<Item> previous_comparer, IGetTheValueOfAProperty<Item, Property> accessor, SortStrategy sort_order) where Property : IComparable<Property>
    {
      return (a, b) =>
      {
        var previous_result = previous_comparer(a, b);
        return previous_result == 0 ? Sort<Item>.by(accessor, sort_order)(a, b) : previous_result;
      };
    }

  }
}