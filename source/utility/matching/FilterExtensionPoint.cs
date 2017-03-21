using System.Collections.Generic;

namespace code.utility.matching
{
    public class FilterExtensionPoint<Item, ItemProperty> : IProvideAccessToFilterBuilders<Item, ItemProperty>
    {
        private readonly IEnumerable<Item> items;
        IGetTheValueOfAProperty<Item, ItemProperty> accessor { get; }


        public FilterExtensionPoint(IEnumerable<Item> items,
            IGetTheValueOfAProperty<Item, ItemProperty> accessor)
        {
            this.items = items;
            this.accessor = accessor;
        }

        public Criteria<Item> create_criteria(Criteria<ItemProperty> value_matcher)
        {
            return x => value_matcher(accessor(x));
        }

        public IEnumerable<Item> filter(Criteria<Item> criteria)
        {
            foreach (var item in items)
            {
                if (criteria(item))
                    yield return item;
            }
        }
    }
}