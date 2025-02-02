namespace Document;

public class MarkdownDocumentVisitor : IDocumentVisitor
{
    public void Visit(TitleElement element)
    {
        Console.WriteLine($"# {element.Text}");
    }

    public void Visit(SubtitleElement element)
    {
        Console.WriteLine($"## {element.Text}");
        Console.WriteLine();
    }

    public void Visit(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}