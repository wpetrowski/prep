using code.web;
using code.web.core;

namespace code.v1.people.list.get
{
  public delegate Data IFetchDataUsingTheRequest<Data>(IProvideDetailsAboutAWebRequest request);
}