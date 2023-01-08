namespace MatrixConsole.New_Year
{
    internal class NewYearMenu
    {
        internal static void ShowNewYearMenu()
        {
            while (true)
            {
                //new year menu
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This is New Year Menu");
                for (int i = 0; i < Console.BufferWidth; i++)
                {
                    Console.Write('=');
                }
                Console.ResetColor();

                //----------------------------------------------------------------------
                Console.WriteLine();
                Console.WriteLine("1) Type Christmas Tree (or Tree or just 1) to draw christmas-tree.");
                Console.WriteLine("2) Type Christmas Decorated Tree (or DTree or just 2) to draw christmas-tree at home.");
                Console.WriteLine("3) Type New Year with music (or just 3) to draw christmas-tree with music.");
                Console.WriteLine("4) Type Snow (or Snowing or just s) to see Snowing.");
                Console.WriteLine("5) Type Get Back (or gb) to get back");
                Console.Write('>');

                string input = Console.ReadLine().Trim().ToLower();

                //if you wanna see christmas tree
                if (input == "tree" || input == "christmas tree" || input == "1")
                {
                    ChristmasTree.DrawChristmasTree();
                }

                //if you wanna see decorated tree
                else if (input == "dtree" || input == "christmas decorated tree" || input == "2")
                {
                    ChristmasTree.DrawDecoratedTree();
                }

                //if you wanna see second decorated tree
                else if (input == "3" || input == "new year with music")
                {
                    ChristmasTree.DrawSecondDecoratedTree();
                }

                //if you wanna see snowing console
                else if (input == "snow" || input == "snowing" || input == "s")
                {
                    Snow.Snowing();
                }

                //if you wanna go back
                else if(input == "get back" || input == "gb")
                {
                    Program.Main();
                }

                //wrong type
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
}
