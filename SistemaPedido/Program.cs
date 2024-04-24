using SistemaPedido.entities;
using SistemaPedido.entities.enums;

Order order = new Order{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);