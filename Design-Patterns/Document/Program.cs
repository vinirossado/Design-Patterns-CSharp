//Client

using Document;

List<IDocumentElement> elements =
[
    new TitleElement("The visitor Design Pattern"),
    new SubtitleElement("Intent"),
    new ContentElement("Represent an operation to be performed on the elements of an object structure."),
    new SubtitleElement("Is it amazing?"),
    new ContentElement("Yes, it is!"),
];

Console.WriteLine("Text Format");
TextDocumentVisitor textDocumentVisitor = new();

foreach (var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("Markdown Format");
MarkdownDocumentVisitor markdownDocumentVisitor = new();

foreach (var element in elements)
{
    element.Accept(markdownDocumentVisitor);
}