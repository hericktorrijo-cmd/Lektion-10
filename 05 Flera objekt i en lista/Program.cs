
List<Product> products = new List<Product>
{
    new Product {Name = "Padel-Rack"},
    new Product {Name = "Tennis-Rack"},
    new Product {Name = "Fotboll"}
};



foreach (Product product in products )
{
    Console.WriteLine(product.Name);
}



Console.Write("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();


class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

}