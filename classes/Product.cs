using Program;
//using Program.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Product
{
    #region Initializers
    public int productID { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public double weight { get; set; }
    public double volume { get; set; }
    public long code { get; set; }
    public byte tax { get; set; }
    public short shopQuantity { get; set; }
    public short warehouseQuantity { get; set; }
    public Product() { }
    public Product(int productID, long code, string name, double price, byte tax, double weight, double volume, short shopQuantity, short warehouseQuantity)
    {
        this.productID = productID;
        this.name = name;
        this.price = price;
        this.weight = weight;
        this.volume = volume;
        this.code = code;
        this.tax = tax;
        this.shopQuantity = shopQuantity;
        this.warehouseQuantity = warehouseQuantity;
    }
    #endregion

    public void customerInfo()
    {
        Console.WriteLine("ID: " + productID + ", " + name + ", cena: " + price);
    }

    public void managerInfo()
    {
        Console.WriteLine("ID: " + productID + ", " + name + ", cena: " + price + ", stan na sklepie: " +
            shopQuantity + ", stan na magazynie " + warehouseQuantity + ", waga: " + weight +
            ", objętość: " + volume + ", kod: " + code + "");
    }

    public void customerShowAll(List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
                Console.WriteLine($"{products[i].productID} - {products[i].name} - {products[i].price}");
            }
    }

    public void managerShowAll(List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("ID: " + products[i].productID + ", " + products[i].name + ", cena: " + products[i].price + ", stan na sklepie: " +
            products[i].shopQuantity + ", stan na magazynie " + products[i].warehouseQuantity + ", waga: " + products[i].weight +
            ", objętość: " + products[i].volume + ", kod: " + products[i].code + "");
        }
    }

    public void Search(List<Product> products)
    {
        Console.WriteLine("Wpisz szukaną frazę:");
        string search = Console.ReadLine();

        bool result = false;
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].name.Contains(search, StringComparison.CurrentCultureIgnoreCase))
            {
                result = true;
                if (result == true)
                {
                    products[i].customerInfo();
                }
            }

        }
        if (result == false)
        {
            Console.WriteLine("Brak wyników");
        }
    }

    public void categoryFilter(List<Product> products)
    {
        Console.WriteLine("Wybierz numer kategorii, aby wyświetlić jej zawartość:");
        Console.WriteLine("1 - Produkty do włosów \n2 - Produkty do ciała \n3 - Produkty do twarzy \n4 - Higiena jamy ustnej \n" +
            "5 - Mydła \n6 - Higiena intymna \n7 - Makijaż \n8 - Produkty spożywcze \n9 - Napoje");
        string category = Console.ReadLine();

        switch (category) 
        {
            case "1":
                int i = 0;
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is HairProduct) { products[i].customerInfo(); }
                }
                break;
            case "2":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is BodyProduct) { products[i].customerInfo(); }
                }
                break;
            case "3":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is FaceProduct) { products[i].customerInfo(); }
                }
                break;
            case "4":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is OralProduct) { products[i].customerInfo(); }
                }
                break;
            case "5":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is SoapProduct) { products[i].customerInfo(); }
                }
                break;
            case "6":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is IntimateProduct) { products[i].customerInfo(); }
                }
                break;
            case "7":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is MakeupProduct) { products[i].customerInfo(); }
                }
                break;
            case "8":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is FoodProduct) { products[i].customerInfo(); }
                }
                break;
            case "9":
                for (i = 0; i < products.Count; i++)
                {
                    if (products[i] is DrinkProduct) { products[i].customerInfo(); }
                }
                break;
            default: Console.WriteLine("Podano zły numer"); break;

        }
    }
}
}
