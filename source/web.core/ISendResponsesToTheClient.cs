using System.Collections.Generic;
using code.prep.people;

namespace code.web.core
{
  public interface ISendResponsesToTheClient
  {
    void send(IEnumerable<Person> data);
  }
}