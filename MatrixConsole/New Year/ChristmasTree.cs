namespace MatrixConsole.New_Year
{
    internal class ChristmasTree
    {
        internal static void DrawChristmasTree()
        {
            while (true)
            {  
                Console.Clear();
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
                    Console.ForegroundColor= ConsoleColor.DarkYellow; //for tree root
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
        internal static void DrawDecoratedTree()
        {
            while (true)
            {
                Console.Clear();
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
                            char c = '*';
                            Random random = new();
                            int r = random.Next(1, 5);
                            if (r == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(c);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(c);
                            }
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < a - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow; //for tree root
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
