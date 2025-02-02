namespace Visitor;

public interface IVisitor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}