using developwithpassion.specifications.assertions.core;
using developwithpassion.specifications.assertions.interactions;
using spec = developwithpassion.specifications.use_engine<Machine.Fakes.Adapters.Rhinomocks.RhinoFakeEngine>;
using Machine.Specifications;

namespace code.utility.containers
{  
  [Subject(typeof(TypeFactoryRegistry))]  
  public class TypeFactoryRegistrySpecs
  {

    public abstract class concern : spec.observe<IFindFactoriesForAType,TypeFactoryRegistry>
    {
        
    }

    class SomeOtherItem
    {
      
    }
   
    public class when_getting_a_type_factory : concern
    {
      private Because b = () =>
        sut.get_factory_that_can_create(typeof(SomeOtherItem));

      It looks_in_its_collection_for_it = () =>
        sut.factories.should().received(x => x.GetEnumerator());
    }
  }
}
