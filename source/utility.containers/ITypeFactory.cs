using System;

namespace code.utility.containers
{
    public interface ITypeFactory
    {
        TypeToCreate create<TypeToCreate>();
    }
}