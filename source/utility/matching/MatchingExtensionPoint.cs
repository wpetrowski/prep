namespace code.utility.matching
{
  public class MatchingExtensionPoint<ItemToMatch, Property>
  {
    public PropertyAccessor<ItemToMatch, Property> accessor { get; }

    public MatchingExtensionPoint(PropertyAccessor<ItemToMatch, Property> accessor)
    {
      this.accessor = accessor;
    }

    public NotMatchingExtensionPoint<ItemToMatch, Property> not => new NotMatchingExtensionPoint<ItemToMatch, Property>(this);
  }
}