namespace fortune_teller_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            // MAIN MENU

            Console.WriteLine("*** Paper Fortune Teller vers. 0.0.1 ***");
            Console.WriteLine();
            Console.WriteLine("--- Main Menu ---");
            Console.WriteLine("[1] About");
            Console.WriteLine("[2] Play");
            Console.WriteLine();
            Console.Write("Select an option: ");

            string userInput = Console.ReadLine();
            
            while(userInput == null)
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

            // ABOUT MENU

            if(userInputLower == "about" || userInputLower == "1" || userInputLower == "[1]")
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

                userInput = Console.ReadLine();
            }
        }
    }
}