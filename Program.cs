using myApp.Semana3.Orders;

Console.WriteLine("Bienvenido al Sistema");

Product keyboard = new Product(1, "Keyboard", 80);
Product mouse = new Product(1, "Mouse", 40);

Order order = new Order(1);

order.AddItem(keyboard, 2);
order.AddItem(mouse, 1);

decimal total = order.CalculateTotal();

Console.WriteLine($"El total de la orden es: {total}");