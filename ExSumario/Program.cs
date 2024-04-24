using  ExSumario.entities.enums;
using ExSumario.entities;
using System.Globalization;

Console.WriteLine("Enter cliente data:");

Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string clientEmail = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Client client = new Client(clientName, clientEmail, birthDate);


Console.WriteLine("Enter order data:");

DateTime moment = DateTime.Now;
Console.Write("Satus: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order (moment, status ,client);


Console.Write("How many items to this order? ");
int numOrders = int.Parse(Console.ReadLine());

for(int i = 1; i<=numOrders; i++){
    Console.WriteLine("Enter #"+ i +" item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(quantity, productPrice, product);

    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);