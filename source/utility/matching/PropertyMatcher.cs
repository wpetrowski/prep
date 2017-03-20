namespace code.utility.matching
{
    public class PropertyMatcher<ItemToMatch, Property>
    {
        private readonly PropertySelector<ItemToMatch, Property> _propertySelector;

        public PropertyMatcher(PropertySelector<ItemToMatch, Property> propertySelector)
        {
            _propertySelector = propertySelector;
        }

        public IMatchA<ItemToMatch> equal_to(Property property)
        {
            return new CriteriaMatch<ItemToMatch>(item => _propertySelector(item).Equals(property));
        }
    }
}