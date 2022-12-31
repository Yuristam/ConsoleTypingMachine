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
            Console.Write('>');

            string input = Console.ReadLine().Trim().ToLower();

            //if you wanna see christmas tree
            if(input=="tree"|| input =="christmas tree")
            {
                ChristmasTree.DrawChristmasTree();
            }if(input=="dtree"|| input =="christmas decorated tree")
            {
                ChristmasTree.DrawDecoratedTree();
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
