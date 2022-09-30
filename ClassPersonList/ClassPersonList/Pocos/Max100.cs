namespace ClassPersonList.Pocos;

using System;

/// <summary>
/// Värdet får inte vara mindre än 0
/// och den får inte vara större än 100
/// </summary>
internal class Max100
{
    private int value;

    public int Value
    {
        get
        {
            return value;
        }

        set
        {
            this.value = CheckValue(value);
        }
    }

    private int CheckValue(int value)
    {
        if(value < 0) return 0;
        if (value> 100) return 100;

        return value;
    }

    public override string ToString()
    {
        return "Värdet är :"+value.ToString();
    }
}
