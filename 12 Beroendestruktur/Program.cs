
using System.ComponentModel.Design;


//Skapar batteriet
var standardBatteri = new Batteri(85);

//Skicka in batteriet till mobiltelefonens konstruktor
var mobilTelefon = new MobilTelefon("Samsung S26", standardBatteri);

//Visa status
mobilTelefon.VisaStatus();


class Batteri
{
    public int KapacitetProcent {  get; set; }

    public Batteri(int kapacitetProcent)
    {
        KapacitetProcent = kapacitetProcent;
    }

}

class MobilTelefon
{
    public string Modell { get; set; }
    public Batteri TelefonBatteri { get; set; }

    public MobilTelefon(string modell, Batteri batteri)
    {
        Modell = modell;
        TelefonBatteri = batteri;
    }

    public void VisaStatus()
    {
        Console.WriteLine($"Mobiltelefon: {Modell}");
        if(TelefonBatteri != null)
        {
            Console.WriteLine($"Batterinivå: {TelefonBatteri.KapacitetProcent}");
        }
        else
        {
            Console.WriteLine("Inget batteri installerat!");
        }
    }
        
}

