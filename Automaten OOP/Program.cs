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
            for (; ; )
            {
                Console.WriteLine("===============================================================");
                Console.WriteLine("===                         Automat                         ===");
                Console.WriteLine("===============================================================");
                Console.WriteLine("=== 1. Coca Cola      = 2. Fanta Orange    = 3. Faxe Kondi  ===\n\n=== 4. Haribo Matador = 5. Haribo ClickMix = 6. Skumbananer ===\n\n=== 7. Twix           = 8. Snickers        = 9. Mars        ===\n \n                    === 0. Administration ===\n");
                Logic.Menu();
                Console.Clear();
            }
        }
    }
}
