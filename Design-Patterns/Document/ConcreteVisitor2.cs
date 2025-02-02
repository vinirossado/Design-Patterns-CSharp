namespace Document;

public class TextDocumentVisitor : IDocumentVisitor
{
    public void Visit(TitleElement element)
    {
        Console.WriteLine(element.Text.ToUpper());
        Console.WriteLine(new string('=', element.Text.Length));
        Console.WriteLine();
    }

    public void Visit(SubtitleElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine(new string('-', element.Text.Length));
        Console.WriteLine();
    }

    public void Visit(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}