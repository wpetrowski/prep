using System.Data;

namespace code
{
  public interface IRunAQuery<QueryResult>
  {
    void prepare(IDbCommand command);
  }
}