using System;

namespace code.utility.containers
{
  public class ContainerFacade : IFetchDependencies
  {
    private IFindFactoriesForAType type_factories;

    public ContainerFacade(IFindFactoriesForAType type_factories)
    {
      this.type_factories = type_factories;
    }

    public ItemToFetch an<ItemToFetch>()
    {
      throw new NotImplementedException();
    }
  }
}