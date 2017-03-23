using System;

namespace code.utility.containers
{
    internal interface IProvideResolverForAType
    {
        void get_resolver_for_type(Type the_type);
    }
}