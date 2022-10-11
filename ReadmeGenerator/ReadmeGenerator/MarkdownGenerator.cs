public class MarkdownGenerator : IDocumentGenerator
{
    public string Filename { get; set; } = "readme";
    public string File { get; set; } = "";
    public void AddHeader1(string text)
    {
        File += "# " + text + Environment.NewLine;
    }
    public void AddHeader2(string text)
    {
        File += "## " + text + Environment.NewLine;
    }
    public void AddHeader3(string text)
    {
        File += "### " + text + Environment.NewLine;
    }

    public void AddText(string text)
    {
        File += text + Environment.NewLine;
    }

    public void AddCode(string text)
    {
        File += "```csharp" + Environment.NewLine + text + Environment.NewLine + "```";
    }

    public void SaveFile(string savePath)
    {
        string filename = Path.Combine(savePath, Filename + ".md");
        System.IO.File.WriteAllText(filename, File);
    }
}