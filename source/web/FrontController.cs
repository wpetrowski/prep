namespace code.web
{
  public class FrontController
  {
    private IFindACommandThatCanHandleARequest registry;

    public FrontController(IFindACommandThatCanHandleARequest registry)
    {
      this.registry = registry;
    }

    public void run(IProvideDetailsAboutAWebRequest request)
    {
      registry.get_command_that_can_handle(request);
    }
  }
}