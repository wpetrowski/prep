using System;
using code.utility.core;

namespace code.utility.iteration
{
	public class MinVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
		where Result : IComparable<Result>
	{
		IGetTheValueOfAProperty<Element, Result> accessor;
		Result result;

		public MinVisitor(IGetTheValueOfAProperty<Element, Result> accessor)
		{
			this.accessor = accessor;
		}

		public void process(Element value)
		{
			var current = accessor(value);
			result = current.CompareTo(result) < 0 ? current : result;
		}

		public Result get_result()
		{
			return result;
		}
	}

	public class MaxVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
		where Result : IComparable<Result>
	{
		IGetTheValueOfAProperty<Element, Result> accessor;
		Result result;

		public MaxVisitor(IGetTheValueOfAProperty<Element, Result> accessor)
		{
			this.accessor = accessor;
		}

		public void process(Element value)
		{
			var current = accessor(value);
			result = current.CompareTo(result) > 0 ? current : result;
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