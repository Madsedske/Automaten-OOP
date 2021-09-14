using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    public class AutomatManager
    {

        public AutomatManager(int choice, int moneySave, string itemGot, string administrationItem, int administrationAmount)
        {
            Choice = choice;
            MoneySave = moneySave;
            ItemGot = itemGot;
            AdministrationItem = administrationItem;
            AdministrationAmount = administrationAmount;
        }

        public int Choice { get; set; }


        public int MoneySave { get; set; }


        public string ItemGot { get; set; }


        public string AdministrationItem { get; set; }


        public int AdministrationAmount { get; set; }


    }
}
