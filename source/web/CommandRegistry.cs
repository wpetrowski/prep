using System;
using System.Collections.Generic;
using System.Linq;

namespace code.web
{
  public class CommandRegistry :IFindACommandThatCanHandleARequest
  {
      private readonly IEnumerable<IHandleOneWebRequest> commands;

      public CommandRegistry(IEnumerable<IHandleOneWebRequest> commands)
      {
          this.commands = commands;
      }

     public IHandleOneWebRequest get_command_that_can_handle(IProvideDetailsAboutAWebRequest request)
     {
         return commands.First(command => command.can_process(request));
     }
  }
}