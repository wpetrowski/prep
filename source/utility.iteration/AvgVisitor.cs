using System;
using code.utility.core;

namespace code.utility.iteration
{
  public class AvgVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
  {
    private readonly SummingVisitor<Element,Result> summer;

    private int count;

    public AvgVisitor(IGetTheValueOfAProperty<Element, Result> accessor, Func<Result, Result, Result> accumulator)
    {
      summer = new SummingVisitor<Element, Result>(accessor, accumulator);
    }

    public void process(Element value)
    {
      summer.process(value);

      count++;
    }

    public Result get_result()
    {
      return (dynamic)summer.get_result() / count;
    }
  }
}