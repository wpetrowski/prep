using System;
using developwithpassion.specifications.assertions.core;
using developwithpassion.specifications.assertions.interactions;
using Machine.Specifications;
using Rhino.Mocks;
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
        registry = depends.on<IFindFactoriesForAType>();
        factory = fake.an<ICreateInstances>();
        registry.setup(x => x.get_resolver_for_type(Arg<Type>.Is.Anything)).Return(factory);
      };

      Because b = () => 
        sut.an<Object>();

      private It tells_the_correct_factory_to_create_that_type = () =>
        factory.should().received(x => x.create(typeof(Object)));

      static IFindFactoriesForAType registry;
      static ICreateInstances factory;
    }
  }
}