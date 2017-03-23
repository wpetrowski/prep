using System;
using Machine.Specifications;
using developwithpassion.specifications.assertions.core;
using developwithpassion.specifications.assertions.interactions;
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
            private Establish c = () =>
            {
                registry = fake.an<IProvideResolverForAType>();
                the_type = typeof(object);
            };
            private Because b = () => sut.resolve(the_type);

            private It tells_the_dependency_registry_to_get_the_resolver_for_that_type = () =>
                registry.should().received(x => x.get_resolver_for_type(the_type));
            
            static Type the_type;
            static IProvideResolverForAType registry;
        }
    }
}
