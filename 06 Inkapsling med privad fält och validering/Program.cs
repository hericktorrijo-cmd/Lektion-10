



Konto nyKonto = new Konto();
nyKonto.Epost = "HerickTorrijo";

Console.WriteLine(nyKonto.Epost);


nyKonto.Epost = "Herick@";
Console.WriteLine(nyKonto.Epost);

class Konto
{

    private string epost;
    public string Epost
    {
        get { return epost; }
        set
        {
            if (!value.Contains("@"))
            {
                epost = "Ogiltig";
            }
            else
            {
                epost = value;
            }
        }
    }

}