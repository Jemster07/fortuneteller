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

            string fullPath = "C:\\Users\\Student\\workspace\\personal-projects\\fortune-teller_01\\fortune-teller_01\\stream-files\\About.txt";

            bool isValid = false;

            while (!isValid)
            {
                try
                {
                    using (StreamReader readAbout = new StreamReader(fullPath))
                    {
                        while (!readAbout.EndOfStream)
                        {
                            string line = readAbout.ReadLine();
                            Console.WriteLine(line);
                            isValid = true;
                        }
                    }
                }
                catch (FileLoadException)
                {
                    Console.WriteLine("ERROR: Called file is damaged or in use.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("ERROR: Called file does not exist!");
                }
                catch (Exception readAboutException)
                {
                    Console.WriteLine(readAboutException.Message);
                }
            }

            Console.WriteLine();
            Console.Write("Press any key to return to the Main Menu");
            Console.WriteLine();

            Console.ReadKey(true);
            Console.Clear();

            MainMenu mainMenu = new MainMenu();

            mainMenu.CallMainMenu();
        }
    }
}
