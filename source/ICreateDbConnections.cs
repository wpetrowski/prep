using System.Data;

namespace code
{
  public interface ICreateDbConnections
  {
    IDbConnection create();
  }
}