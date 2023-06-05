using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_01.Classes
{
    public class AboutMenu
    {
        public void CallAboutMenu()
        {
            Console.Clear();

            Console.WriteLine("*** Paper Fortune Teller vers. 0.0.1 ***");
            Console.WriteLine();
            Console.WriteLine("--- About ---");
            Console.WriteLine();

            // About section text body goes here
            Console.WriteLine("Hello World!");

            Console.WriteLine();
            Console.Write("Press any key to return to the Main Menu");
            Console.WriteLine();

            string userInput = Console.ReadLine();    
        }
    }
}
