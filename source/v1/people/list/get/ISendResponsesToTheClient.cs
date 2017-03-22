using System.Collections.Generic;
using code.prep.people;

namespace code.v1.people.list.get
{
  public interface ISendResponsesToTheClient
  {
    void send(IEnumerable<Person> data);
  }
}