using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Order : Receipt
    {
        private List<Product> products = new List<Product>();
        private Receipt receipt = new Receipt();

        public string LastName { get; set; }
        public void AddProduct(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                products.Add(product);
            }
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.price;
            }
            return totalPrice;
        }
        public void readReceipt()
        {
            Console.WriteLine("Podaj imie i nazwisko:");
            LastName = Console.ReadLine();
            receipt.readReceipt();
        }
        public void printReceipt()
        {
            receipt.Print(products, TotalPrice(), LastName);
        }
    }
}
