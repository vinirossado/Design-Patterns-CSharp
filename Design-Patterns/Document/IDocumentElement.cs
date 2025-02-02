namespace Document;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor visitor);
}