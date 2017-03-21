namespace code.utility.matching
{
  public static class NotMatchingExtensions
  {
    public static IMatchA<Item> equal_to<Item, Property>(this NotMatchingExtensionPoint<Item, Property> extension_point, Property property)
    {
      return extension_point.BaseExtensionPoint.equal_to(property).not();
    }
  }
}