using ConsoleAppProduct.Models;
using ConsoleAppProduct.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct.Business
{
    class ProductBusiness
    {
        public void start()
        {
            Console.WriteLine("Enter client data: ");
            string name = "Alex Green";
            string email = "alex@gmail.com";
            DateTime birthDate = DateTime.Parse("03/15/1985 00:00:00");
            OrderStatus status = OrderStatus.Processing;

            Client client = new Client(name, email, birthDate);
            Order order = new Order(status,client, DateTime.Now);

            Console.Write("How many items to this order?");
            int ammountProduct = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ammountProduct; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine().ToString();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.AddItem(orderItem);
            }  

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.Read();
        }
    }
}
