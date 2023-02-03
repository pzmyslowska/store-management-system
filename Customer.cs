using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Customer : Order
    {
        public void CustomerVi(Order cart, List<Product> products, Product product, Inventory inventory)
        {
            Order oredr = new Order();

            Console.WriteLine("--Wybierz opcję--");
            Console.WriteLine("L - Lista wszystkich produktów \nF - Kategorie produktów \nS - Wyszukaj produkt\nC - Przejdz do kasy \nR - Powrót");

            while (true)
            {
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "L":
                        product.customerShowAll(products);
                        Console.WriteLine("Wybierz produkt podając jego numer z listy");
                        break;
                    case "F":
                        product.categoryFilter(products);
                        break;
                    case "S":
                        product.Search(products);
                        break;
                    case "R":
                        Console.Clear();
                        return;
                    case "C":
                        Console.Clear();
                        oredr.printReceipt();
                        oredr.readReceipt();
                        break;

                    default:
                        int productId;
                        if (int.TryParse(input, out productId))
                        {
                            Product selectedProduct = products.FirstOrDefault(p => p.productID == productId);
                            if (selectedProduct != null)
                            {
                                Console.WriteLine("Podaj ilość:");
                                int quantity = int.Parse(Console.ReadLine());
                                oredr.AddProduct(selectedProduct, quantity);
                                Console.WriteLine($"{selectedProduct.name} x {quantity} dodano do koszyka. SUMA: {oredr.TotalPrice()}");
                            }
                            else
                            {
                                Console.WriteLine("Niewłaściwy kod produktu");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niewłaściwe dane");
                        }
                        break;
                }
            } 
        }
    }
}
