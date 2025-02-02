namespace Document;

public class SubtitleElement(string text) : IDocumentElement
{
    public string Text { get; } = text;
    
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}