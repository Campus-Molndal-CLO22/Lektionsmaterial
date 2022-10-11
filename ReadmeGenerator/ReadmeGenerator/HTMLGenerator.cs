namespace ReadmeGenerator
{
    internal class HTMLGenerator : IDocumentGenerator
    {
        public string File { get; set; } = "";
        public string Filename { get; set; } = "";

        public void AddCode(string text)
        {
            File += "<pre>" + text +"</pre>";
        }

        public void AddHeader1(string text)
        {
            File += "<h1>" + text + "</h1>";
        }

        public void AddHeader2(string text)
        {
            File += "<h2>" + text + "</h2>";
        }

        public void AddHeader3(string text)
        {
            File += "<h3>" + text + "</h3>";
        }

        public void AddText(string text)
        {
            File += "<p>" + text.Replace("\n","<br>") + "</p>";
        }
    }
}
