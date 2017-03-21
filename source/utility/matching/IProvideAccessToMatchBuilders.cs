namespace code.utility.matching
{
  public interface IProvideAccessToMatchBuilders<in ItemToMatch, out Property>
  {
    IMatchA<ItemToMatch> create(IMatchA<Property> value_matcher);
  }
}