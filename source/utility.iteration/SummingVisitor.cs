using System;
using code.utility.core;

namespace code.utility.iteration
{
	public class CondensingVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
		where Result : IComparable<Result>
	{
		IGetTheValueOfAProperty<Element, Result> accessor;
		Result result;
		private Func<Result, Result, Result> selector;

		public CondensingVisitor(IGetTheValueOfAProperty<Element, Result> accessor, Func<Result, Result, Result> selector)
		{
			this.selector = selector;
			this.accessor = accessor;
		}

		public void process(Element value)
		{
			var current = accessor(value);
			result = selector(current, result);
		}

		public Result get_result()
		{
			return result;
		}
	}

	public class SummingVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
  {
    IGetTheValueOfAProperty<Element, Result> accessor;
    Func<Result, Result, Result> accumulator;
    Result result;

    public SummingVisitor(IGetTheValueOfAProperty<Element, Result> accessor, Func<Result, Result, Result> accumulator)
    {
      this.accessor = accessor;
      this.accumulator = accumulator;
    }

    public void process(Element value)
    {
      result = accumulator(result, accessor(value));
    }

    public Result get_result()
    {
      return result;
    }
  }
}