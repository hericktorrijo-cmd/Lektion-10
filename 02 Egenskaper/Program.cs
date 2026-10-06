

User herick = new User();
herick.UserName = "Elmago7";
herick.Email = "HerickT@gmail.com";

Console.WriteLine($"Användarnamn: {herick.UserName}. Email: {herick.Email}");


Console.Write("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();


class User
{
    public string UserName { get; set; }
    public string Email {  get; set; }
}