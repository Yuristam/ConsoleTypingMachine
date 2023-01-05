namespace MatrixConsole.New_Year
{
    internal class NewYearMenu
    {
        internal static void ShowNewYearMenu()
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
            Console.WriteLine("1) Type Christmas Tree or Tree to draw christmas-tree.");
            Console.WriteLine("2) Type Christmas Decorated Tree or DTree to draw christmas-tree at home.");
            Console.WriteLine("3) Type 2 to draw second christmas-tree at home.");
            Console.WriteLine("4) Type Snow or Snowing to see Snowing.");
            Console.Write('>');

            string input = Console.ReadLine().Trim().ToLower();

            //if you wanna see christmas tree
            if(input=="tree"|| input =="christmas tree")
            {
                ChristmasTree.DrawChristmasTree();
            }

            //if you wanna see decorated tree
            if (input=="dtree"|| input =="christmas decorated tree")
            {
                ChristmasTree.DrawDecoratedTree();
            }

            //if you wanna see second decorated tree
            if(input == "2")
            {
                ChristmasTree.DrawSecondDecoratedTree();
            }

            //if you wanna see snowing console
            if (input == "snow" || input == "snowing" || input =="s")
            {
                Snow.Snowing();
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
