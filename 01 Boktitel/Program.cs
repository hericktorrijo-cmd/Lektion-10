
Book book = new Book();
book.titel = "Harry Potter";
book.author = "JK Rowlings";

Console.WriteLine($"Bokens titel: {book.titel} och författaren är: {book.author}");


Console.Write("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();

class Book
{
    public string titel;
    public string author; 
}