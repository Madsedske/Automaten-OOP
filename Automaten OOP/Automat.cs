using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten_OOP
{
    class Automat
    {

        public Automat(string name, int price, int lagerstatus)
        {
            Name = name;
            Price = price;
            LagerStatus = lagerstatus;
        }

        public string Name { get; set; }

        public int LagerStatus { get; set; }

        public int Price { get; set; }
    }
}
