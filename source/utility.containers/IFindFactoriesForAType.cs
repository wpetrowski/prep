using System;

namespace code.utility.containers
{
    public interface IFindFactoriesForAType
    {
        ITypeFactory get_resolver<ItemToFetch>();
    }
}