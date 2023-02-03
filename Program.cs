using Program;
//using Program.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            #region Products
            products.Add(new HairProduct(1, 894098, "Szampon do włosów", 22.99, 23, 644.72, 173.42, 5, 35));
            products.Add(new HairProduct(2, 708653, "Odżywka do włosów", 17.99, 23, 583.07, 659.13, 6, 60));
            products.Add(new HairProduct(3, 541906, "Peeling do skóry głowy", 17.79, 23, 469.06, 190.99, 5, 73));
            products.Add(new HairProduct(4, 379608, "Suchy szampon", 13.99, 23, 291.32, 506.18, 7, 97));
            products.Add(new HairProduct(5, 672847, "Olejek do włosów", 15.49, 23, 202.27, 78.13, 8, 87));
            products.Add(new BodyProduct(6, 219519, "Żel pod prysznic", 8.99, 23, 777.16, 487.77, 5, 2));
            products.Add(new BodyProduct(7, 844581, "Płyn do kąpieli", 11.99, 23, 477.56, 392.54, 4, 45));
            products.Add(new BodyProduct(8, 376002, "Balsam do ciała", 13.49, 23, 288.45, 449.71, 4, 53));
            products.Add(new BodyProduct(9, 919371, "Dezodorant w sprayu", 7.29, 23, 182.20, 658.94, 6, 7));
            products.Add(new BodyProduct(10, 383088, "Dezodorant w kulce", 11.99, 23, 104.56, 198.67, 8, 90));
            products.Add(new FaceProduct(11, 927815, "Żel oczyszczający do twarzy", 23.99, 23, 201.96, 332.91, 9, 68));
            products.Add(new FaceProduct(12, 150839, "Peeling enzymatyczny do twarzy", 22.9, 23, 94.02, 331.34, 5, 29));
            products.Add(new FaceProduct(13, 943365, "Płyn micelarny", 26.49, 23, 125.81, 120.73, 2, 85));
            products.Add(new FaceProduct(14, 377150, "Krem nawilżający", 34.99, 23, 213.68, 270.66, 4, 11));
            products.Add(new FaceProduct(15, 445240, "Krem pod oczy", 33.99, 23, 72.02, 624.98, 7, 14));
            products.Add(new OralProduct(16, 594956, "Miętowa pasta do zębów", 7.99, 23, 193.29, 201.21, 8, 51));
            products.Add(new OralProduct(17, 129017, "Płyn do płukania ust", 11.49, 23, 365.57, 559.08, 10, 52));
            products.Add(new OralProduct(18, 604603, "Szczoteczka do zębów. średnia", 4.99, 23, 50.01, 682.31, 5, 5));
            products.Add(new OralProduct(19, 750902, "Szczoteczka do zębów. miękka", 4.99, 23, 50.01, 627.18, 23, 39));
            products.Add(new OralProduct(20, 259684, "Nić dentystyczna", 8.49, 23, 36.68, 70.95, 14, 17));
            products.Add(new SoapProduct(21, 873843, "Hipoalergiczne mydło w kostce", 4.49, 23, 50.93, 229.49, 12, 80));
            products.Add(new SoapProduct(22, 659768, "Mydło w kostce", 3.29, 23, 50.41, 126.81, 17, 18));
            products.Add(new SoapProduct(23, 233922, "Multipak mydła w kostce", 10.99, 23, 200.56, 674.26, 3, 37));
            products.Add(new SoapProduct(24, 339774, "Mydło w płynie", 8.29, 23, 259.51, 381.41, 5, 70));
            products.Add(new SoapProduct(25, 476836, "Zapas mydła w płynie", 3.49, 23, 370.28, 142.24, 3, 77));
            products.Add(new IntimateProduct(26, 995209, "Podpaski na dzień", 9.79, 5, 236.01, 653.99, 6, 10));
            products.Add(new IntimateProduct(27, 285701, "Podpaski na noc", 9.79, 5, 155.55, 587.13, 5, 62));
            products.Add(new IntimateProduct(28, 696783, "Wkładki", 8.49, 5, 167.36, 116.98, 4, 99));
            products.Add(new IntimateProduct(29, 371816, "Tampony", 15.49, 5, 79.22, 330.46, 8, 98));
            products.Add(new IntimateProduct(30, 111956, "Kubeczek menstruacyjny", 44.99, 5, 258.27, 584.33, 3, 38));
            products.Add(new MakeupProduct(31, 804829, "Podkład", 64.99, 23, 63.52, 191.64, 11, 23));
            products.Add(new MakeupProduct(32, 990434, "Korektor", 27.99, 23, 33.13, 159.59, 10, 81));
            products.Add(new MakeupProduct(33, 619144, "Maskara", 32.99, 23, 74.72, 195.33, 15, 48));
            products.Add(new MakeupProduct(34, 435472, "Eyeliner", 18.99, 23, 24.90, 367.21, 10, 89));
            products.Add(new MakeupProduct(35, 303055, "Szminka", 36.99, 23, 41.80, 116.20, 7, 94));
            products.Add(new FoodProduct(36, 898615, "Herbata", 4.79, 5, 60.52, 413.65, 5, 79));
            products.Add(new FoodProduct(37, 661961, "Batonik", 3.99, 5, 15.89, 478.54, 22, 0));
            products.Add(new FoodProduct(38, 861254, "Ciasteczka", 6.49, 5, 247.87, 543.42, 4, 4));
            products.Add(new FoodProduct(39, 107737, "Chrupki", 4.99, 5, 100.42, 169.62, 4, 64));
            products.Add(new FoodProduct(40, 634752, "Guma do żucia", 3.29, 5, 11.01, 180.35, 30, 36));
            products.Add(new DrinkProduct(41, 532575, "Woda niegazowana", 2.49, 5, 694.34, 219.79, 6, 96));
            products.Add(new DrinkProduct(42, 246169, "Woda gazowana", 2.49, 5, 306.91, 423.58, 6, 34));
            products.Add(new DrinkProduct(43, 951568, "Sok owocowy", 4.79, 5, 640.82, 355.92, 1, 93));
            products.Add(new DrinkProduct(44, 543565, "Napój gazowany", 4.99, 5, 699.37, 581.09, 4, 88));
            products.Add(new DrinkProduct(45, 256980, "Energetyk", 5.99, 5, 676.12, 475.35, 2, 71));
            #endregion

            #region Definitions
            Product product = new Product();
            Inventory inventory = new Inventory();
            Order cart = new Order();
            Manager worker = new Manager();
            Receipt receipt = new Receipt();
            Customer customer = new Customer();
            Manager manager = new Manager();
            #endregion


            while (true)
            {
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1. Złóż nowe zamówienie");
                Console.WriteLine("2. Wyświetl ostatnie zamówienie");
                Console.WriteLine("3. Wyjście");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        customer.CustomerVi(cart,products,product,inventory);
                        break;
                    case 2:
                        Console.Clear();
                        receipt.readReceipt();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Zapraszamy ponownie!");
                        Thread.Sleep(2000);
                        return;
                        case 4:

                        Console.Clear() ;
                        Console.WriteLine("Podaj Login :");
                        
                        string login = Console.ReadLine();
                        if (login == "manager");
                        {
                            Console.Clear();
                            manager.managerView(cart, products, product, inventory, receipt);
                        }
                        break;
                        
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybierz numer od 1 do 3\n");
                        break;
                }
            }
        }
    }
}