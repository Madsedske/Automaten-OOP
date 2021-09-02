using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    public class Logic
    {
        static int choice;
        static int moneySave = 0;
        static string itemGot;
        static List<Automat> automat = new List<Automat>();
        static Automat cocaCola = new Automat("Coca Cola", 20, 10);
        static Automat fantaOrange = new Automat("Fanta Orange", 20, 10);
        static Automat faxeKondi = new Automat("Faxe Kondi", 20, 10);
        static Automat hariboMatador = new Automat("Haribo Matador", 25, 20);
        static Automat hariboClickMix = new Automat("Haribo ClickMix", 25, 20);
        static Automat skumbananer = new Automat("Skumbanaer", 15, 20);
        static Automat twix = new Automat("Twix", 10, 30);
        static Automat snickers = new Automat("Snickers", 10, 30);
        static Automat mars = new Automat("Mars", 10, 30);

        private static void AddToList()
        {
            automat.Add(cocaCola);
            automat.Add(fantaOrange);
            automat.Add(faxeKondi);
            automat.Add(hariboMatador);
            automat.Add(hariboClickMix);
            automat.Add(skumbananer);
            automat.Add(twix);
            automat.Add(snickers);
            automat.Add(mars);
        }

        public static void Menu()
        {
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Selected is: " + cocaCola.Name + "\nPrice is: " + cocaCola.Price + " Kr.");
                itemGot = "Coca Cola";
                GoFurtherWithItem();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Selected is: " + fantaOrange.Name + "\nPrice is: " + fantaOrange.Price + " Kr.");
                itemGot = "Fanta Orange";
                GoFurtherWithItem();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Selected is: " + faxeKondi.Name + "\nPrice is: " + faxeKondi.Price + " Kr.");
                itemGot = "Faxe Kondi";
                GoFurtherWithItem();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Selected is: " + hariboMatador.Name + "\nPrice is: " + hariboMatador.Price + " Kr.");
                itemGot = "Haribo Matador";
                GoFurtherWithItem();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Selected is: " + hariboClickMix.Name + "\nPrice is: " + hariboClickMix.Price + " Kr.");
                itemGot = "Haribo ClickMix";
                GoFurtherWithItem();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Selected is: " + skumbananer.Name + "\nPrice is: " + skumbananer.Price + " Kr.");
                itemGot = "Skumbanan";
                GoFurtherWithItem();
            }
            else if (choice == 7)
            {
                Console.WriteLine("Selected is: " + twix.Name + "\nPrice is: " + twix.Price + " Kr.");
                itemGot = "Twix";
                GoFurtherWithItem();
            }
            else if (choice == 8)
            {
                Console.WriteLine("Selected is: " + snickers.Name + "\nPrice is: " + snickers.Price + " Kr.");
                itemGot = "Snickers";
                GoFurtherWithItem();
            }
            else if (choice == 9)
            {
                Console.WriteLine("Selected is: " + mars.Name + "\nPrice is: " + mars.Price + " Kr.");
                itemGot = "Mars";
                GoFurtherWithItem();
            }
            else if (choice == 0)
            {
                Console.Clear();
                AdministrationMenu();
                AdministrationManage();
            }
            else
                Console.Clear();
        }

        private static void GoFurtherWithItem()
        {
            Console.WriteLine("Go Further With this Item? Yes Or No.");
            string chooseItem = Console.ReadLine().ToLower();
            if (chooseItem == "yes")
            {
                Buy();
            }
            else
                Console.Clear();
        }

        private static void ItemRemove()
        {
            if (choice == 1)
                cocaCola.LagerStatus--;
            else if (choice == 2)
                fantaOrange.LagerStatus--;
            else if (choice == 3)
                faxeKondi.LagerStatus--;
            else if (choice == 4)
                hariboMatador.LagerStatus--;
            else if (choice == 5)
                hariboClickMix.LagerStatus--;
            else if (choice == 6)
                skumbananer.LagerStatus--;
            else if (choice == 7)
                twix.LagerStatus--;
            else if (choice == 8)
                snickers.LagerStatus--;
            else if (choice == 9)
                mars.LagerStatus--;
        }

        public static void Buy()
        {
            Console.WriteLine("\nPlease insert the right amount of money.");
            int money = Convert.ToInt32(Console.ReadLine());
            if (money == cocaCola.Price || money == fantaOrange.Price || money == faxeKondi.Price || money == hariboMatador.Price || money == hariboClickMix.Price || money == skumbananer.Price || money == twix.Price || money == snickers.Price || money == mars.Price)
            {
                moneySave = moneySave + money;
                Console.WriteLine("You Got A " + itemGot);
                ItemRemove();
            }
            else
                Console.WriteLine("It ain't the right amount of money..");
        }

        private static void AdministrationMenu()
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("===                     Administration                      ===");
            Console.WriteLine("===============================================================");
            Console.WriteLine("1. Collect Money");
            Console.WriteLine("2. Check Amount Of An Item");
            Console.WriteLine("3. Change A Price\n");
            Console.WriteLine("Choose An Option");
        }

        private static void AdministrationManage()
        {
            int administrationOption = Convert.ToInt32(Console.ReadLine());
            if (administrationOption == 1)
            {
                Console.WriteLine("There is: " + moneySave + " kr. in this machine");
                Console.WriteLine("Collect? Yes or no;");
                string collectAnswer = Console.ReadLine().ToLower();
                if (collectAnswer == "yes")
                {
                    Console.WriteLine("You collected all the money!");
                    moneySave = moneySave - moneySave;
                }
                else
                    Console.Clear();
            }
            else if (administrationOption == 2)
            {
                Console.WriteLine(cocaCola.Name + cocaCola.LagerStatus + "\n" + fantaOrange.Name + fantaOrange.LagerStatus + "\n" + faxeKondi.Name + faxeKondi.LagerStatus + "\n" + hariboMatador.Name + hariboMatador.LagerStatus + "\n" + hariboClickMix.Name + hariboClickMix.LagerStatus + "\n" + skumbananer.Name + skumbananer.LagerStatus + "\n" + twix.Name + twix.LagerStatus + "\n" + snickers.Name + snickers.LagerStatus + "\n" + mars.Name + mars.LagerStatus + "\n");
                Console.WriteLine("Refill one? Yes or No.");
                string refillAnswer = Console.ReadLine().ToLower();
                if (refillAnswer == "yes")
                {
                    Console.WriteLine("Write Item and Amount");
                    //string refillItem = Console.ReadLine();
                    //int refillAmount = Convert.ToInt32(Console.ReadLine());

                    //automat[].LagerStatus = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();
                }
                else if (refillAnswer == "no")
                    Console.Clear();

            }
            else if (administrationOption == 3)
            {

            }
            else
                Console.WriteLine("Option Doesn't Exist");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
