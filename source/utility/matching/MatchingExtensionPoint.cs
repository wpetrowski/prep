namespace code.utility.matching
{
  public class MatchingExtensionPoint<ItemToMatch, Property> : IProvideAccessToMatchBuilders<ItemToMatch, Property>
  {
    PropertyAccessor<ItemToMatch, Property> accessor { get; }


    public MatchingExtensionPoint(PropertyAccessor<ItemToMatch, Property> accessor)
    {
      this.accessor = accessor;
    }

    public IProvideAccessToMatchBuilders<ItemToMatch, Property> not
    {
      get { return new NegatingMatchingExtensionPoint(this); }
    }

    class NegatingMatchingExtensionPoint : IProvideAccessToMatchBuilders<ItemToMatch, Property>
    {
      IProvideAccessToMatchBuilders<ItemToMatch, Property> original;

      public NegatingMatchingExtensionPoint(IProvideAccessToMatchBuilders<ItemToMatch, Property> original)
      {
        this.original = original;
      }

      public IMatchA<ItemToMatch> create(IMatchA<Property> value_matcher)
      {
        return original.create(value_matcher).not();
      }
    }

    public IMatchA<ItemToMatch> create(IMatchA<Property> value_matcher)
    {
      return new PropertyMatch<ItemToMatch, Property>(accessor, value_matcher);
    }
  }
}