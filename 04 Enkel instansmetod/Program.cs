

Dog myDog = new Dog();
myDog.Name = "Smiley";

myDog.Yell();



Console.Write("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();




class Dog
{
    public string Name {  get; set; }

    public void Yell()
    {
        Console.WriteLine($"{Name} skäller: Voff voff!");
    }
}