using code.utility.matching;

namespace code.utility.iteration
{
  public class ConstrainedValueReturningVisitor<Element, Value> : IProcessAndReturnAValue<Element, Value>
  {
    Criteria<Element> constraint;
    IProcessAndReturnAValue<Element, Value> visitor;

    public ConstrainedValueReturningVisitor(Criteria<Element> constraint, IProcessAndReturnAValue<Element, Value> visitor)
    {
      this.constraint = constraint;
      this.visitor = visitor;
    }

    public void process(Element value)
    {
      if (constraint(value))
        this.visitor.process(value);
    }

    public Value get_result()
    {
      return this.visitor.get_result();
    }
  }
}