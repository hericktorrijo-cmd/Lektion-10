


Kurs ny = new Kurs("OOP");

Console.WriteLine(ny.KursNamn + " " + ny.KursKod);

Kurs ny1 = new Kurs("OOP", "19");

Console.WriteLine(ny1.KursNamn + " " + ny1.KursKod);


class Kurs
{
    public string KursNamn { get; set; }
    public string KursKod { get; set; }



    public Kurs(string kursNamn, string kursKod)
    {
        KursNamn = kursNamn;

        KursKod = kursKod;
    }

    public Kurs (string kursNamn)
    {
        KursNamn = kursNamn;

        KursKod = "TBD";
    }
   
}