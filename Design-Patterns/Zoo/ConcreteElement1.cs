namespace Visitor;

public class ConcreteElement1 : IElement //Lion
{
    public void Accept(IVisitor visitor) // Receiving a visitor (vet)
    {
        visitor.Visit(this);
    }

    public string Operation1()
    {
        return "Lion is roaring";
    }
}