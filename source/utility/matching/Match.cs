namespace code.utility.matching
{
    public static class Match<ItemToMatch>
    {
        public static PropertyMatcher<ItemToMatch, Property> with_attribute<Property>(PropertySelector<ItemToMatch, Property> propertySelector)
        {
            return new PropertyMatcher<ItemToMatch, Property>(propertySelector);
        }
    }
}