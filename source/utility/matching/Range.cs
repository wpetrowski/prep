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

  public class RangeEndExtensionPoint<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private RangeStartExtensionPoint<Value> rangeStartExtensionPoint;
    private Value to;
    private bool is_inclusive;

    public RangeEndExtensionPoint(Value to)
    {
      this.to = to;
    }

    public RangeEndExtensionPoint(RangeStartExtensionPoint<Value> rangeStartExtensionPoint, Value to)
    {
      this.rangeStartExtensionPoint = rangeStartExtensionPoint;
      this.to = to;
    }

    public RangeEndExtensionPoint<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeEndExtensionPoint<Value> exclusive()
    {
      this.is_inclusive = false;
      return this;
    }

    public bool is_in_range(Value value)
    {
      return (is_inclusive ? value.CompareTo(to) <= 0 : value.CompareTo(to) < 0) && rangeStartExtensionPoint.is_in_range(value);
    }
  }

  public class RangeStartExtensionPoint<Value> : IKnowHowToRange<Value> where Value : IComparable<Value>
  {
    private Value from;
    private bool is_inclusive;

    public RangeStartExtensionPoint(Value from)
    {
      this.from = from;
    }

    public RangeStartExtensionPoint<Value> inclusive()
    {
      this.is_inclusive = true;
      return this;
    }

    public RangeStartExtensionPoint<Value> exclusive()
    {
      this.is_inclusive = false;
      return this;
    }

    public RangeEndExtensionPoint<Value> upto(Value to)
    {
      return new RangeEndExtensionPoint<Value>(this, to);
    }


    public bool is_in_range(Value value)
    {
      return (is_inclusive ? value.CompareTo(from) >= 0 : value.CompareTo(from) > 0);
    }
  }

  public interface IKnowHowToRange<Value>
  {
    bool is_in_range(Value value);
  }

  public static class RangeExtensions
  {
    public static Criteria<Item> falls_in<Item, Property>(this IProvideAccessToMatchBuilders<Item,Property> extension_point, IKnowHowToRange<Property> range)
    {
      return extension_point.create(range.is_in_range);
    }
  }
}