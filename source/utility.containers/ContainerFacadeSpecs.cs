using System;
using developwithpassion.specifications.assertions.core;
using developwithpassion.specifications.assertions.interactions;
using Machine.Specifications;
using spec = developwithpassion.specifications.use_engine<Machine.Fakes.Adapters.Rhinomocks.RhinoFakeEngine>;

namespace code.utility.containers
{
  [Subject(typeof(ContainerFacade))]
  public class ContainerFacadeSpecs
  {
    public abstract class concern : spec.observe<IFetchDependencies, ContainerFacade>
    {
    }

    public class when_fetching_a_dependency : concern
    {
      Establish c = () =>
      {
        registry = depends.on<ICreateAType>();
      };

      Because b = () => 
        sut.an<Object>();

      It tells_the_dependency_registry_to_get_the_factory_for_that_type = () =>
        registry.should().received(x => x.get_resolver_for_type(typeof(Object)));

      static ICreateAType registry;
    }
  }
}