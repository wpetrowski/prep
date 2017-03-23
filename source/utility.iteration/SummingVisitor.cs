using System;
using code.utility.core;

namespace code.utility.iteration
{
	public class CondensingVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
		where Result : IComparable<Result>
	{
		IGetTheValueOfAProperty<Element, Result> accessor;
		private bool firstResult;
		Result result;
		private Func<Result, Result, Result> selector;

		public CondensingVisitor(IGetTheValueOfAProperty<Element, Result> accessor, Func<Result, Result, Result> selector)
		{
			this.selector = selector;
			this.accessor = accessor;
			firstResult = true;
		}

		public void process(Element value)
		{
			var current = accessor(value);
			if (firstResult)
			{
				firstResult = false;
				result = current;
				return;
			}
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