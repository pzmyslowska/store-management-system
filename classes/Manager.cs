using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Manager : Product
    {
        public void substracting(List<Product> products)
        {
            Console.WriteLine("Podaj numer ID produktu do usunięcia:");
            int productID = int.Parse(Console.ReadLine());

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].productID == productID)
                {
                    products.RemoveAt(i);
                    Console.WriteLine("Produkt został usunięty");
                    break;
                }
            }
        }

        public void addObject(List<Product> products)
        {
            Console.WriteLine("Podaj id produktu: ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj nazwę produktu: ");
            string name = string.Format(Console.ReadLine());
            Console.WriteLine("Podaj cenę produktu: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wagę produktu [g]: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj objętość produktu [cm^3]: ");
            double volume = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kod produktu: ");
            long code = long.Parse(Console.ReadLine());
            Console.WriteLine("Podaj podatek produktu: ");
            byte tax = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość produktu na sklepie: ");
            short shopQuantity = short.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość produktu na magazynie: ");
            short warehouseQuantity = short.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz kategorię, do której chcesz przypisać produkt:" +
                "\n1 - Produkty do włosów \n2 - Produkty do ciała \n3 - Produkty do twarzy \n4 - Higiena jamy ustnej \n5 - Mydła" +
                "\n6 - Higiena intymna \n7 - Makijaż \n8 - Produkty spożywcze \n9 - Napoje");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    products.Add(new HairProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "2":
                    products.Add(new BodyProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "3":
                    products.Add(new FaceProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "4":
                    products.Add(new OralProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "5":
                    products.Add(new SoapProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "6":
                    products.Add(new IntimateProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "7":
                    products.Add(new MakeupProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "8":
                    products.Add(new FoodProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
                case "9":
                    products.Add(new DrinkProduct(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity));
                    break;
            }


        }

        public void managerSearch(List<Product> products)
        {
            Console.WriteLine("Wprowadź ID produktu:");
            string inputID = Console.ReadLine();
            int valueID = int.Parse(inputID);
            products[valueID - 1].managerInfo();
        }
        public void stockSearch(List<Product> products, Inventory inventory)
        {
            Console.WriteLine("Wprowadź ID produktu:");
            string inputID = Console.ReadLine();
            int valueID = int.Parse(inputID);
            Console.WriteLine($"Stan produktu o ID " + valueID + ": " + inventory.stockLevel(products[valueID]));
        }

        public void managerView(Order cart, List<Product> products, Product product, Inventory inventory, Receipt receipt)
        {
            while(true)
            {
                Console.WriteLine("1 - Wyświetl ostatnie zamówienie \n2 - Informacje o produkcie \n" +
                    "3 - Informacje o wszystkich produktach \n4 - Stan wszystkich produktów \n" +
                    "5 - Sprawdź stan produktu \n6 - Dodaj produkt \n7 - Usuń produkt \n8 - Wyjście");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        receipt.readReceipt();
                        break;
                    case "2":
                        Console.Clear();
                        managerSearch(products);
                        break;
                    case "3":
                        Console.Clear();
                        product.managerShowAll(products); 
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Suma stanów wszystkich produktów: " + inventory.allStock(products));
                        break;
                    case "5":
                        stockSearch(products, inventory);
                        break;
                    case "6":
                        {
                            Console.Clear();
                            while (true)
                            {
                                addObject(products);
                                Console.WriteLine("Czy chcesz dodać kolejny produkt? (T/N)");
                                string decision = Console.ReadLine().ToUpper();
                                if (decision == "N") ; break;
                            }
                        }
                        break;
                    case "7":
                        Console.Clear();
                        substracting(products);
                        break;
                    case "8":
                        Console.Clear();
                        return;
                        break;

                    default: Console.WriteLine("Podano zły numer"); break;
                }
            } 
        }
    }
}