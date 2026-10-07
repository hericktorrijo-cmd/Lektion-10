//using System.ComponentModel.DataAnnotations;

////MIN EGNA LÖSNING
////using System.ComponentModel.Design;

////List<HotellRum> hotelRooms = new List<HotellRum>
////{
////    new HotellRum {RumNummer = 1, GastNamn = "LEDIG", isOckuperat = false},
////    new HotellRum {RumNummer = 2, GastNamn = "LEDIG", isOckuperat = false},
////    new HotellRum {RumNummer = 3, GastNamn = "LEDIG", isOckuperat = false}
////};


////bool avsluta = true;
////Console.WriteLine("--- HOTELL-MENY ---");
////while (avsluta)
////{
////    Console.WriteLine("1: Visa status för alla rum\n");
////    Console.WriteLine("2: Checka in gäst valfri rum\n");
////    Console.WriteLine("0: AVSLUTA");
////    bool input = int.TryParse(Console.ReadLine(), out int choice);

////    switch (choice)
////    {
////        case 1:
////            foreach (var hotel in hotelRooms)
////            {
////                if (!hotel.isOckuperat)
////                {
////                    Console.WriteLine($"Rum {hotel.RumNummer}: Ledig".ToUpper());
////                }
////                else
////                {
////                    Console.WriteLine($"Rum {hotel.RumNummer}: Upptagen. Upptagen av: {hotel.GastNamn}".ToUpper());

////                }
////            }
////            break;

////        case 2:
////            Console.Write("Gäst namn: ");
////            string guestName = Console.ReadLine();

////            Console.Write("Vilken rum vill du tilldela: ");
////            bool inputBool = int.TryParse(Console.ReadLine(), out int rum);

////            for (int i = 0; i < hotelRooms.Count; i++)
////            {
////                if (hotelRooms[i].RumNummer == rum)   
////                {
////                    if (hotelRooms[i].isOckuperat)   
////                    {
////                        Console.WriteLine("Det går ej då rummet är upptaget!");
////                    }
////                    else
////                    {
////                        hotelRooms[i].isOckuperat = true;   
////                        hotelRooms[i].GastNamn = guestName; 
////                        Console.WriteLine("Gästen är nu incheckad!");
////                    }

////                    break; 
////                }
////            }

////            break;
////        case 0:
////            avsluta = false;
////            break;

////        default:
////            Console.WriteLine("Felaktigt val!");
////            break;
////    }


////}

////class HotellRum
////{
////    public int RumNummer { get; set; }
////    public string GastNamn { get; set; }
////    public bool isOckuperat { get; set; }


////}

//// LÖSNING I LEKTION:


using System.ComponentModel.Design;
using System.Xml.Serialization;

List<HotellRoom> hotelRooms = new List<HotellRoom>
{
    new HotellRoom(101),
    new HotellRoom(102),
    new HotellRoom(103),
    new HotellRoom(104),
    new HotellRoom(105),
};

while(true)
{
   
    Console.WriteLine("\n---HOTELLRECEPTION---");
    Console.WriteLine("1. Visa alla rum");
    Console.WriteLine("2. Checka in gäst");
    Console.WriteLine("3. Avsluta");
    Console.Write("Ange val: ");
    

    string val = Console.ReadLine();
    Console.WriteLine();

    if (val == "1")
    {
        foreach (var hotelRoom in hotelRooms)
        {
            string status = hotelRoom.isOckuperat ? $"Upptaget av {hotelRoom.GastNamn}" : "Ledig";
            Console.WriteLine($"Rum {hotelRoom.RumNummer}: {status}");
        }
    }
    else if (val == "2")
    {
        Console.Write("Ange rumsnummer (101 - 105): ");
        int nr = int.Parse(Console.ReadLine());
        HotellRoom valtRum = hotelRooms.Find(r => r.RumNummer == nr);
        if (valtRum != null && !valtRum.isOckuperat)
        {
            Console.Write("Ange gästens namn: ");
            string namn = Console.ReadLine();
            valtRum.CheckaIn(namn);
            Console.WriteLine("Inchecking gick bra.");
        }
        else
        {
            Console.WriteLine("Rummet är inte ledig.");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("\n\nAvslutar programmet!");
        break;
    }

}



class HotellRoom
{
    public int RumNummer {  get; set; }
    public string GastNamn { get; set; }
    public bool isOckuperat { get; set; }
    //Konstruktor
    public HotellRoom(int rumNummer)
    {
        RumNummer = rumNummer;
        GastNamn = "Ingen";
        isOckuperat = false;
    }
    //Metod
    public void CheckaIn(string gäst)
    {
        GastNamn = gäst;
        isOckuperat = true;
    }
}


