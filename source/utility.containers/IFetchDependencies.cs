using System;

namespace code.utility.containers
{
  public interface IFetchDependencies
  {
      void resolve(Type type);
  }
}