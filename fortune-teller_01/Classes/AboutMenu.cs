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

            string pathToFile = ".\\Data\\About.txt";

            try
            {
                using (StreamReader readAbout = new StreamReader(pathToFile))
                {
                    while (!readAbout.EndOfStream)
                    {
                        string line = readAbout.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileLoadException)
            {
                Console.WriteLine("ERROR: Called file is damaged or in use.");
                Console.WriteLine("Please close the file or restore it and try again.");
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ERROR: Called file does not exist!");
                Console.WriteLine("Please restore the file and try again.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: Something went wrong.");
                Console.WriteLine("Please verify the program file structure is complete and try again.");
                return;
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
