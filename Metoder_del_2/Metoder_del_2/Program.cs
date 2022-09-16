class Program
{
    static void Main()
    {
        int antal_katter = 3;

        if (antal_katter > 1)
        {
            int antal_hundar = 2;
        }

        int tal = MultipliceraInparameterMedTvå(10); // 20

        Console.WriteLine(tal);
        Console.WriteLine(antal_katter);

        // Skapar en ny variabel kallad inparameter och ger den värdet 10
        int MultipliceraInparameterMedTvå(int inparameter)
        {
            int antal_hundar = 3;
            antal_katter = 5;
            return inparameter * 2; // Beräknar
        }
    }



}