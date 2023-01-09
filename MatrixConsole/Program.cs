using MatrixConsole;
using MatrixConsole.Billionaire.Game_Menu;
using MatrixConsole.Dungeon_Adventure;
using MatrixConsole.New_Year;
using MatrixConsole.Test;

class Program
{
    internal static void Main()
    {
        //beginning of the program
        while (true)
        {
            Console.Clear();
            // the welcome part of the program
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Welcome to my console app!");
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }
            Console.ResetColor();

            // the Main Menu of the program
            Console.WriteLine("Main menu\r\n" +
                              "1) Type New Year (or just n) to see New Year functions.\r\n" +
                              "2) Type Matrix to chose Matrix.\r\n" +
                              "3) Type Chainsaw Man (or Chainsaw or just c) to chose Chainsaw Man.\r\n" +
                              "4) Type Billionaire (or Billion or just b) to chose Billionaire Game.\r\n" +
                              "5) Type Dungeon (or just d) to play Dungeon Game.\r\n" +
                              "6) Type Test (or just t) to view C# Console Test Area.");
            Console.Write(">");

            string input = Console.ReadLine().Trim().ToLower();

            //========================================================================================================================

            //if you wanna see New Year
            if (input == "new year" || input =="n")
            {
                NewYearMenu.ShowNewYearMenu();
            }

            // if you wanna see Matrix movie console
            else if (input == "matrix")
            {
                Console.Clear();
                Matrix.ShowMatrix();
            }

            //if you wanna see chainsaw man (gun devil attack)
            else if (input == "chainsaw man" || input == "chainsaw" || input == "c")
            {
                Console.Clear();
                ChainsawMan.GunDevil();
            }

            //if you wanna play billion game
            else if (input == "billion" || input == "billionaire" || input == "b")
            {
                BillionaireMenu.ShowMenu();
            }

            //if you wanna play dungeon game
            else if (input == "dungeon" || input == "d")
            {
                DungeonGameMenu.ShowGameMenu();
            }

            //if i want to test smth new in console
            else if (input =="test" || input == "t")
            {
                TestArea.ShowTestArea();
            }

            //========================================================================================================================

            // if you wanna quit
            else if (input == "quit" || input == "q")
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
