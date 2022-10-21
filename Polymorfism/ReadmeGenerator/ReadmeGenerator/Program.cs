using ReadmeGenerator;

internal class Program
{
    private static void Main(string[] args)
    {
        IDocumentGenerator md = new MarkdownGenerator();
        IDocumentGenerator html = new HTMLGenerator();
        Createfile(md);
        Createfile(html);
    }

    private static void Createfile(IDocumentGenerator md)
    {
        md.Filename = "readme";
        md.AddHeader1("Readme generator");
        md.AddText("Det här programmet genererar readmefiler");
        md.AddText("vilket är coolt!");
        md.AddHeader2("Hur man använder det");
        md.AddText("Metoder: ");
        md.AddText("- AddHeader1()");
        md.AddText("- AddHeader2()");
        md.AddText("- AddHeader3()");
        md.AddText("- AddText()");
        md.AddHeader3("CLO22 rulez!");
        md.AddCode("Console.WriteLine(\"CLO22 Rulez!!\");");
        md.SaveFile(@"..\..\..\Output");
        Console.WriteLine(md.File);
        Console.WriteLine();
    }
}