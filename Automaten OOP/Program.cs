using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager logic = new Manager();
            Data manager = new Data();
            Automat wares = new Automat();
            logic.AddToList();
            for (; ; )
            {
                Console.WriteLine("===============================================================");
                Console.WriteLine("===                         Automat                         ===");
                Console.WriteLine("===============================================================");
                Console.WriteLine("=== 1. Coca Cola      = 2. Fanta Orange    = 3. Faxe Kondi  ===\n\n=== 4. Haribo Matador = 5. Haribo ClickMix = 6. Skumbananer ===\n\n=== 7. Twix           = 8. Snickers        = 9. Mars        ===\n \n                    === 0. Administration ===\n");

                // Choose an item or administration menu with a if statement.
                manager.Choice = Convert.ToInt32(Console.ReadLine());
                if (manager.Choice > 0)
                {
                    Console.WriteLine($"Selected is: {logic.GetVarer()[manager.Choice - 1].Name }\nPrice is: {logic.GetVarer()[manager.Choice - 1].Price } Kr.");

                    // Go further with a item or go back to menu.
                    Console.WriteLine("Go further with this item? Yes Or No.");
                    string chooseItem = Console.ReadLine().ToLower();
                    if (chooseItem == "yes")
                    {
                        Console.WriteLine("\nPlease insert the right amount of money.");
                        int userMoney = Convert.ToInt32(Console.ReadLine());
                        if (userMoney == logic.GetVarer()[manager.Choice - 1].Price)
                        {
                            Console.WriteLine("You got a " + logic.GetVarer()[manager.Choice - 1].Name);
                            logic.Buy(manager.Choice, manager.MoneySave, manager.UserMoney, wares.Name);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("It ain't the right amount of money.. Try again.");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }
                    else
                        Console.Clear();
                }

                else if (manager.Choice == 0)
                {
                    Console.Clear();
                    // Visual menu for the administration for the machine.
                    Console.WriteLine("===============================================================");
                    Console.WriteLine("===                     Administration                      ===");
                    Console.WriteLine("===============================================================");
                    Console.WriteLine("1. Collect Money");
                    Console.WriteLine("2. Check Amount Of An Item");
                    Console.WriteLine("3. Change A Price\n");
                    Console.WriteLine("Choose An Option");
                    int administrationOption = Convert.ToInt32(Console.ReadLine());
                    if (administrationOption == 1)
                    {
                        Console.WriteLine("There is: " + manager.MoneySave + " kr. in this machine");
                        Console.WriteLine("Collect? Yes or no;");
                        string collectAnswer = Console.ReadLine().ToLower();
                        if (collectAnswer == "yes")
                        {
                            logic.CollectMoney(manager.MoneySave);
                            Console.WriteLine("You collected all the money!");
                        }
                        else
                            Console.Clear();
                    }
                    else if (administrationOption == 2)
                    {
                        Console.WriteLine(logic.GetVarer()[0].Name + logic.StockOfItem("Coca Cola") + "\n" + 
                        logic.GetVarer()[1].Name + logic.StockOfItem("Fanta Orange") + "\n" + 
                        logic.GetVarer()[2].Name + logic.StockOfItem("Faxe Kondi") + "\n" + 
                        logic.GetVarer()[3].Name + logic.StockOfItem("Haribo Matador") + "\n" + 
                        logic.GetVarer()[4].Name + logic.StockOfItem("Haribo ClickMix") + "\n" + 
                        logic.GetVarer()[5].Name + logic.StockOfItem("Skumbananer") + "\n" + 
                        logic.GetVarer()[6].Name + logic.StockOfItem("Twix") + "\n" + 
                        logic.GetVarer()[7].Name + logic.StockOfItem("Snickers") + "\n" + 
                        logic.GetVarer()[8].Name + logic.StockOfItem("Mars") + "\n");

                        Console.WriteLine("Refill one? Yes or No.");
                        string refillAnswer = Console.ReadLine().ToLower();
                        if (refillAnswer == "yes")
                        {
                            Console.WriteLine("What item?");
                            manager.AdministrationItem = Console.ReadLine().ToLower();
                            Console.WriteLine("How many?");
                            manager.AdministrationAmount = Convert.ToInt32(Console.ReadLine());
                            logic.AdministrationRefillStocks(manager.AdministrationItem, manager.AdministrationAmount);
                            Console.WriteLine("Item refilled!");
                        }
                        else if (refillAnswer == "no")
                            Console.Clear();
                        Console.ReadKey();
                    }
                    else if (administrationOption == 3)
                    {
                        // Change a price for an item.
                        Console.WriteLine("What item?");
                        manager.AdministrationItem = Console.ReadLine().ToLower();
                        Console.WriteLine("Choose the new price.");
                        manager.AdministrationAmount = Convert.ToInt32(Console.ReadLine());
                        logic.AdministrationChangePrice(manager.AdministrationItem, manager.AdministrationAmount);
                        Console.WriteLine("Price changed!");
                    }
                    else
                    {
                        Console.WriteLine("Option Doesn't Exist");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    Console.Clear();
            }
        }
    }
}