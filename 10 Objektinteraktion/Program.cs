
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

Bil nyBil = new Bil();
Console.WriteLine(nyBil.IsTrasig);
nyBil.IsTrasig = true;
Console.WriteLine(nyBil.IsTrasig);


Mekaniker mek = new Mekaniker();

mek.Reparera(nyBil);

Console.WriteLine(nyBil.IsTrasig);







class Bil
{
    public bool IsTrasig {  get; set; }


}

class Mekaniker
{



    public void Reparera(Bil b)
    {
        b.IsTrasig = false;
    }
    
}