using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    public class Manager
    {
        List<Automat> wares = new List<Automat>();          
        List<Automat> waresInMachine = new List<Automat>();

        // List with items from the machine.
        Automat cocaCola = new Automat("Coca Cola", 20);
        Automat fantaOrange = new Automat("Fanta Orange", 20);
        Automat faxeKondi = new Automat("Faxe Kondi", 20);
        Automat hariboMatador = new Automat("Haribo Matador", 25);
        Automat hariboClickMix = new Automat("Haribo ClickMix", 25);
        Automat skumbananer = new Automat("Skumbanaer", 15);
        Automat twix = new Automat("Twix", 10);
        Automat snickers = new Automat("Snickers", 10);
        Automat mars = new Automat("Mars", 10);


        public void AddToList()
        {       
            // Items added to the list.
            wares.Add(cocaCola);
            wares.Add(fantaOrange);
            wares.Add(faxeKondi);
            wares.Add(hariboMatador);
            wares.Add(hariboClickMix);
            wares.Add(skumbananer);
            wares.Add(twix);
            wares.Add(snickers);
            wares.Add(mars);
        }

        public List<Automat> GetVarer()
        {
            return wares;
        }


        public void RemoveItem(int choice, string name)
        {
            // Cuts one from the stocks every time an item is bought.
            if (choice == 1)
                waresInMachine.Remove(cocaCola);
            else if (choice == 2)
                waresInMachine.Remove(fantaOrange);
            else if (choice == 3)
                waresInMachine.Remove(faxeKondi);
            else if (choice == 4)
                waresInMachine.Remove(hariboMatador);
            else if (choice == 5)
                waresInMachine.Remove(hariboClickMix);
            else if (choice == 6)
                waresInMachine.Remove(skumbananer);
            else if (choice == 7)
                waresInMachine.Remove(twix);
            else if (choice == 8)
                waresInMachine.Remove(snickers);
            else if (choice == 9)
                waresInMachine.Remove(mars);
        }

        public void Buy(int choice, int moneySave, int userMoney, string name)
        {
            // Adds money to the machine and runs the method "RemoveItem". 
            moneySave = moneySave + userMoney;
            RemoveItem(choice, name);
        }


        public void CollectMoney(int moneySave)
        {
            // Removes the money the "moneysave".
            moneySave = moneySave - moneySave;
        }
        
        public void AdministrationRefillStocks(string administrationItem, int administrationAmount)
        {
            // If statement to find the specific item and refill it.
            if (administrationItem == "coca cola")
                AddCocaCola(administrationAmount);
            else if (administrationItem == "fanta orange")
                AddFantaOrange(administrationAmount);
            else if (administrationItem == "faxe kondi")
                AddFaxeKondi(administrationAmount);
            else if (administrationItem == "haribo matador")
                AddHariboMatador(administrationAmount);
            else if (administrationItem == "haribo clickmix")
                AddHariboClickMix(administrationAmount);
            else if (administrationItem == "skumbananer")
                AddSkumbananer(administrationAmount);
            else if (administrationItem == "twix")
                AddTwix(administrationAmount);
            else if (administrationItem == "snickers")
                AddSnickers(administrationAmount);
            else if (administrationItem == "mars")
                AddMars(administrationAmount);
        }
        
        public void AdministrationChangePrice(string administrationItem, int administrationAmount)
        {
            // If statement to find the specific item and change the price.
            if (administrationItem == "coca cola")
                GetVarer()[0].Price = administrationAmount;
            else if (administrationItem == "fanta orange")
                GetVarer()[1].Price = administrationAmount;
            else if (administrationItem == "faxe kondi")
                GetVarer()[2].Price = administrationAmount;
            else if (administrationItem == "haribo matador")
                GetVarer()[3].Price = administrationAmount;
            else if (administrationItem == "haribo clickmix")
                GetVarer()[4].Price = administrationAmount;
            else if (administrationItem == "skumbananer")
                GetVarer()[5].Price = administrationAmount;
            else if (administrationItem == "twix")
                GetVarer()[6].Price = administrationAmount;
            else if (administrationItem == "snickers")
                GetVarer()[7].Price = administrationAmount;
            else if (administrationItem == "mars")
                GetVarer()[8].Price = administrationAmount;
        }
        
        public int StockOfItem(string name)
        {
            int count = 0;
            for (int i = 0; i < waresInMachine.Count; i++)
            {
                if (waresInMachine[i].Name == name)
                {
                    count++;
                }
            }
            return count;
        }

        public void AddCocaCola(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(cocaCola);
            }
        }
        public void AddFantaOrange(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(fantaOrange);
            }
        }
        public void AddFaxeKondi(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(faxeKondi);
            }
        }
        public void AddHariboMatador(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(hariboMatador);
            }
        }
        public void AddHariboClickMix(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(hariboClickMix);
            }
        }
        public void AddSkumbananer(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(skumbananer);
            }
        }
        public void AddTwix(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(twix);
            }
        }
        public void AddSnickers(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(snickers);
            }
        }
        public void AddMars(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                waresInMachine.Add(mars);
            }
        }
    }
}
