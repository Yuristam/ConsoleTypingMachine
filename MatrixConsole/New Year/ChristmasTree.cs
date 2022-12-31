namespace MatrixConsole.New_Year
{
    internal class ChristmasTree
    {
        internal static void DrawChristmasTree()
        {
            while (true)
            {  
                Console.WriteLine("Enter the level of Christmas Tree:");
                Console.Write(">");  
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    for (int i = 0; i < a; i++)
                    {
                        for (int k = i + 1; k < a; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = a - 1; j < a + i + i; j++)
                        {
                            Console.ForegroundColor= ConsoleColor.DarkGreen; //for the green color of tree
                            Console.Write("*");
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < a - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("|");
                    Console.ResetColor();
                    Console.WriteLine("\r\nPress any key to get back.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("You entered a wrong symbol, please enter number.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
    }
}
