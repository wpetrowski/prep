using System;

namespace code.utility.containers
{
    public class ContainerFacade : IFetchDependencies
    {
        private IFindFactoriesForAType factory_registry;

        public ContainerFacade(IFindFactoriesForAType factory_registry)
        {
            this.factory_registry = factory_registry;
        }

        public ItemToFetch an<ItemToFetch>()
        {
            var factory = factory_registry.get_resolver<ItemToFetch>();

            return factory.create<ItemToFetch>();
        }
    }
}