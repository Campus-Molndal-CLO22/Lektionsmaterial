public class MarkdownGenerator : IDocumentGenerator
{
    public string Filename { get; set; } = "readme";
    private string file = "";
    public string File
    {
        get { return file; }
        set { file = value; }
    }
    public void AddHeader1(string text)
    {
        file += "# " + text + Environment.NewLine;
    }
    public void AddHeader2(string text)
    {
        file += "## " + text + Environment.NewLine;
    }
    public void AddHeader3(string text)
    {
        file += "### " + text + Environment.NewLine;
    }

    public void AddText(string text)
    {
        file += text + Environment.NewLine;
    }

    public void AddCode(string text)
    {
        file += "```csharp" + text + Environment.NewLine + "```";
    }

}