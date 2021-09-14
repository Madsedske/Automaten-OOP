using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    public class Data
    {
        public Data()
        {
        }

        public Data(int choice, int moneySave, int userMoney, string administrationItem, int administrationAmount)
        {
            Choice = choice;
            MoneySave = moneySave;
            AdministrationItem = administrationItem;
            AdministrationAmount = administrationAmount;
            UserMoney = userMoney;
        }

        public int Choice { get; set; }

        public int UserMoney { get; set; }

        public int MoneySave { get; set; }


        public string AdministrationItem { get; set; }


        public int AdministrationAmount { get; set; }

    }
}
