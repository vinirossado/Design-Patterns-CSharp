namespace Visitor;

public class ConcreteVisitor2 : IVisitor
{
    public void Visit(ConcreteElement1 element)
    {
        var operation = element.Operation1();
        Console.WriteLine($"ConcreteVisitor2 visited ConcreteElement1: {operation}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var operation = element.Operation2();
        Console.WriteLine($"ConcreteVisitor2 visited ConcreteElement2: {operation}");
    }
}