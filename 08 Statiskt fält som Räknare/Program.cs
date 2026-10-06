


Medlem tor = new Medlem();
Medlem pra = new Medlem();


Medlem pro = new Medlem();


Medlem pri = new Medlem();

Console.WriteLine(Medlem.antalMedlemmar);




class Medlem
{
    public static int antalMedlemmar; 

    public Medlem()
    {
        antalMedlemmar++;
        
    }
}