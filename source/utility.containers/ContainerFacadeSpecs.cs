using System;
using code.web.core;
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
        factory_registry = depends.on<IFindFactoriesForAType>();
          the_type_factory = fake.an<ITypeFactory>();
          factory_registry.setup(registry => registry.get_factory<IProcessWebRequests>()).Return(the_type_factory);
      };

      Because b = () => 
        sut.an<IProcessWebRequests>();

        private It tells_the_factory_to_resolve_the_dependency = () =>
            the_type_factory.should().received(x => x.create<IProcessWebRequests>());
        

      static IFindFactoriesForAType factory_registry;
        static ITypeFactory the_type_factory;
    }
  }
}