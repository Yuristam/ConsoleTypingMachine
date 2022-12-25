namespace MatrixConsole;
internal class MenuCommands
{
    internal static void MenuExit()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Are you sure?\r\nWrite 'yes' or 'y' for YES or 'no' or 'n' for NO.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "yes" || input == "y")
            {
                Console.Clear();
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
            }
            else if (input == "no" || input == "n")
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
    }
}
