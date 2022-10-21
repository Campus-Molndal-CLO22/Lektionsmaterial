public interface IDocumentGenerator
{
    string File { get; set; }
    string Filename { get; set; }

    void AddCode(string text);
    void AddHeader1(string text);
    void AddHeader2(string text);
    void AddHeader3(string text);
    void AddText(string text);
    void SaveFile(string v);
}