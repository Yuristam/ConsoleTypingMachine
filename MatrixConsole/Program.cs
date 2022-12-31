using MatrixConsole;
using MatrixConsole.New_Year;

class Program
{
    internal static void Main()
    {
        //beginning of the program
        while (true)
        {
            // the welcome part of the program
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Welcome to my console app!");
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }
            Console.ResetColor();

            // the Main Menu of the program
            Console.WriteLine("Main menu");
            Console.WriteLine("1) Type New Year to see New Year functions.");
            Console.WriteLine("2) Type Matrix to chose Matrix.");
            Console.WriteLine("3) Type Chainsaw Man (or Chainsaw) to chose Chainsaw Man.");
            Console.Write(">");

            string input = Console.ReadLine().Trim().ToLower();

            //========================================================================================================================

            //if you wanna see New Year
            if (input == "new year" || input =="n")
            {
                Console.Clear();
                NewYearMenu.ShowNewYearMenu();
            }

            // if you wanna see Matrix movie console
            if (input == "matrix")
            {
                Console.Clear();
                Matrix.ShowMatrix();
            }

            //if you wanna see chainsaw man (gun devil attack)
            if (input == "chainsaw man" || input == "chainsaw")
            {
                Console.Clear();
                ChainsawMan.GunDevil();
            }

            //========================================================================================================================

            // if you wanna quit
            if (input == "quit" || input == "q")
            {
                MenuCommands.MenuExit();
            }

            // if you entered the wrong word or key
            else
            {
                Console.Clear();
                Console.WriteLine("Please, write something that is in the list above.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        //end of the program
    }
}
