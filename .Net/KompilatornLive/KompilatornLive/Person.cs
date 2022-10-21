namespace KompilatornLive;

using System.Diagnostics;

[DebuggerDisplay("{Name} is {Alias}")]
internal class Person
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    public Person() // tom constructor
    {
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get;  set; }
    
    /// <summary>
    /// Gets or sets the alias.
    /// </summary>
    /// <value>
    /// The alias.
    /// </value>
    public string Alias { get;  set; }

    public override string ToString() => base.ToString();
}