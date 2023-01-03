namespace MatrixConsole.New_Year
{
    internal class Snow
    {
        internal static void Snowing()
        {
            Random random = new Random();
            int r1 = random.Next(1, 121);
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                for(int j =0;j< Console.BufferHeight; j++)
                {
                    Thread.Sleep(10);
                    Console.Write('*');
                    Console.Clear();
                }

              /*  Random randomColor = new Random();
                int r = randomColor.Next(1, 4);
                char s = '*';
                if (r == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(s);
                }
                else if (r == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(s);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(s);
                }*/
            }
        }
    }
}