using System;
using System.Collections.Generic;
using System.Linq;

namespace code.web
{
  public class CommandRegistry :IFindACommandThatCanHandleARequest
  {
      private readonly IEnumerable<IHandleOneWebRequest> commands;
      private ICreateAMissingCommandWhenOneCantBeFound missingCommandCreator;

      public CommandRegistry(IEnumerable<IHandleOneWebRequest> commands,
                             ICreateAMissingCommandWhenOneCantBeFound missingCommandCreator)
      {
          this.commands = commands;
          this.missingCommandCreator = missingCommandCreator;
      }

     public IHandleOneWebRequest get_command_that_can_handle(IProvideDetailsAboutAWebRequest request)
     {
         var matchingCommand = commands.FirstOrDefault(command => command.can_process(request));

         return matchingCommand ?? missingCommandCreator(request);
     }
  }
}