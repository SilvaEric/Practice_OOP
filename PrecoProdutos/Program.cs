using System.Diagnostics;
using System.Globalization;
using PrecoProdutos.entities;

List<Product> listProducts = new List<Product>();

Console.Write("Enter the number of products: ");
int num = int.Parse(Console.ReadLine());
for(int i = 1; i <= num; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string type = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(type == "c")
    {
        Product product = new Product(name, price);

        listProducts.Add(product);
    }
    else if(type == "u")
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Product product = new UsedProduct(name, price, date);

        listProducts.Add(product);
    }
    else
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Product product = new ImportedProduct(name, price, customsFee);

        listProducts.Add(product);
    }
}
Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach(Product item in listProducts)
{
    Console.WriteLine(item.PriceTag());
}
