namespace ReadmeGenerator
{
    internal class HTMLGenerator : IDocumentGenerator
    {
        public string File { get; set; } = "";
        public string Filename { get; set; } = "";

        public void AddCode(string text)
        {
            // add borde black background and green text to the pre
            File += "<pre style='background-color:black; text:green'>\n" + text + "\n</pre>";
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

        public void SaveFile(string savePath)
        {
            string htmlDoc = "<html><head><title>Readme</title></head><body>" + File + "</body></html>";

            string filename = Path.Combine(savePath, Filename + ".html");
            System.IO.File.WriteAllText(filename, htmlDoc);
        }
    }
}
