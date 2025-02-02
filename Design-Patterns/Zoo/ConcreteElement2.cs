namespace Visitor;

public class ConcreteElement2 : IElement //Zebra
{
    public void Accept(IVisitor visitor) // Receiving a visitor (vet) 
    {
        visitor.Visit(this);
    }

    public string Operation2()
    {
        return "Zebra is eating grass";
    }
}