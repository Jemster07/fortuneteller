using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune_teller_01.Classes
{
    public class MainMenu
    {
        public void CallMainMenu()
        {
            Console.WriteLine("*** Paper Fortune Teller vers. 0.0.1 ***");
            Console.WriteLine();
            Console.WriteLine("--- Main Menu ---");
            Console.WriteLine("[1] About");
            Console.WriteLine("[2] Play");
            Console.WriteLine();
            Console.Write("Select an option: ");

            string userInput = Console.ReadLine();

            while (userInput == null)
            {
                Console.WriteLine();
                Console.WriteLine("[UNIT TYPE INVALID]");
                Console.WriteLine();
                Console.WriteLine("Please Select Again");
                Console.WriteLine("[1] About");
                Console.WriteLine("[2] Play");
                Console.WriteLine();
                Console.Write("Select an option: ");

                userInput = Console.ReadLine();
            }

            string userInputLower = userInput.ToLower();

            while (userInputLower != "about" && userInputLower != "play"
                && userInputLower != "1" && userInputLower != "2"
                && userInputLower != "[1]" && userInputLower != "[2]")
            {
                Console.WriteLine();
                Console.WriteLine("[UNIT TYPE INVALID]");
                Console.WriteLine();
                Console.WriteLine("Please Select Again");
                Console.WriteLine("[1] About");
                Console.WriteLine("[2] Play");
                Console.WriteLine();
                Console.Write("Select an option: ");

                userInput = Console.ReadLine();
                userInputLower = userInput.ToLower();
            }

            if (userInputLower == "about" || userInputLower == "1" || userInputLower == "[1]")
            {
                AboutMenu aboutMenu = new AboutMenu();

                aboutMenu.CallAboutMenu();
            }
        }
    }
}
