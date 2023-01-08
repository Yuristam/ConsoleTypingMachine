using MatrixConsole.Billionaire.Game_Logic;

namespace MatrixConsole.Billionaire.Game_Menu
{
    internal class BillionaireMenu
    {
        //THIS PART IS NOT WORKING YET(NEED TO BUILD IT)
        internal static void ShowMenu()
        {
            Console.WriteLine("Welcome to the Billionaire Game!\r\n" +
                "Choose what do you wanna do.\r\n" +
                "Start game(s)\r\n" +
                "Game instructions(i)\r\n" +
                "Quit game(q)\r\n" +
                ">");
            string input=Console.ReadLine();

            //====================================================
            //start game
            if(input=="s"||input == "start")
            {
                Console.Clear();
                GameLevels.StartGame();
            }
            //show instructions
            if(input=="i"||input == "instructions")
            {
                Console.Clear();
                ShowInstructions();
            }
            //quit game and go to the main menu (in class Program)
            else if (input == "quit" || input == "q")
            {
                Console.Clear();
                Program.Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please, write something that is in the list above.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        static void ShowInstructions()
        {
            Console.WriteLine("i need to write here instructions to this game.");
        }
    }
}
