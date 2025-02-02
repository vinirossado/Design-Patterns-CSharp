namespace Document;

public class TitleElement(string text) : IDocumentElement
{
    public string Text { get; } = text;
    
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}