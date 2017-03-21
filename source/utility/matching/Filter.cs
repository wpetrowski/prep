using System.Collections.Generic;

namespace code.utility.matching
{
    public static class Filter
    {
        public static FilterExtensionPoint<Item, ItemProperty> filter<Item, ItemProperty>(
            this IEnumerable<Item> enumerable,
            IGetTheValueOfAProperty<Item, ItemProperty> get_the_value_of_a_property)
        {
            return new FilterExtensionPoint<Item, ItemProperty>(enumerable, get_the_value_of_a_property);
        }
    }
}