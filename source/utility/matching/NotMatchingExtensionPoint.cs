namespace code.utility.matching
{
  public class NotMatchingExtensionPoint<Item, Property>
  {
    public MatchingExtensionPoint<Item, Property> BaseExtensionPoint { get; }

    public NotMatchingExtensionPoint(MatchingExtensionPoint<Item, Property> extension)
    {
      BaseExtensionPoint = extension;
    }
  }
}