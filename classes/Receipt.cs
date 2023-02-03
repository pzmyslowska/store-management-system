using Program;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Receipt
    {
        public void Print(List<Product> products, double totalPrice, string lastName)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Patrycja\\Desktop\\Program\\receipt.txt"))
            {
                sw.WriteLine("PARAGON");
                foreach (var product in products)
                {
                    sw.WriteLine($"{product.name} - {product.price}");
                }
                sw.WriteLine($"Suma PLN: {totalPrice}");
            }
        }     
        public void readReceipt()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("C:\\Users\\Patrycja\\Desktop\\Program\\receipt.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line + "\n");
                }
            }
        }
    }
}
