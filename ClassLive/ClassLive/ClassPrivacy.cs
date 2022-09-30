namespace ClassLive;
internal class ClassPrivacy
{
    // Fält 
    // Deklarera variabler först
    
    // Tillgänglig för alla
    public string PublicField = "Public";
    // Tillgänglig för alla i samma projekt
    internal string InternalField = "Internal";

    public string Name = "";

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    // Tillgänglig för alla i samma klass
    private string PrivateField = "Private";
    
    // Tillgänglig för subklasser :)
    protected string ProtectedField = "Protected";

}

