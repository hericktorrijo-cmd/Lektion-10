
Console.WriteLine("---BANKOMAT---");

BankKonto userOne = new BankKonto();


bool bankomatÖppen = true;

while(bankomatÖppen)
{
    Console.WriteLine("1: Sätt in pengar");
    Console.WriteLine("2: Ta ut pengar");
    Console.WriteLine("3: Visa saldo");
    Console.WriteLine("4: Avsluta");
    Console.Write("Val: ");
    string menyVal = Console.ReadLine();
    Console.WriteLine();

    if(menyVal == "1")
    {
        Console.Write("\nHur mycket vill du sätta in: ");
        bool insättningBool = double.TryParse(Console.ReadLine(), out double ins);
        userOne.SättIn(ins);

    }
    else if (menyVal == "2")
    {
        Console.Write("\nHur mycket vill du ta ut: ");
        bool uttagBool = double.TryParse(Console.ReadLine(),out double uttag);
        userOne.TaUt(uttag);
    }
    else if (menyVal == "3")
    {
        userOne.VisaSaldo();
    }

    else if(menyVal == "4")
    {
        Console.WriteLine("\nProgrammet stängs av...");
        bankomatÖppen = false;
    }
    else
    {
        Console.WriteLine("\nFelaktig inmatning");
    }

}

class BankKonto
{
    private double saldo;

    public BankKonto()
    {
        saldo = 200.00;
    }

    public void SättIn(double insättning)
    {

        if(insättning <= 0)
        {
            Console.WriteLine("\nFelaktig insättning, måste vara högre än 0");
        }
        else
        {
            saldo = saldo + insättning;
        }
        
    }

    public void TaUt(double uttag)
    {
        if(uttag > saldo)
        {
            Console.WriteLine($"Felaktigt uttag, uttaget får inte vara större en saldot, du har {saldo} kr i kontot");
        }
        else
        {
            saldo = saldo - uttag;
            Console.WriteLine("Uttag lyckades!");
        }
        
    }

    public void VisaSaldo()
    {
        Console.WriteLine($"\nDitt saldo är: {saldo}");
    }



    
}