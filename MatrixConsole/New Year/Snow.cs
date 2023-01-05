namespace MatrixConsole.New_Year
{
    internal class Snow
    {
        //THIS PART IS NOT WORKING YET(NEED TO BUILD IT)
        internal static void Snowing()
        {
            Console.Clear();
            Random random = new Random();
            int r1 = random.Next(1, 121);
            for (int i = 0; i < 10; i++)
            {
                for(int j =0;j< Console.BufferWidth; j++)
                {
                    Console.Write('*');
                }
                for(int k=0;k< 25;k++)
                {
                    Random randomFalling= new Random();
                    randomFalling.Next(1,10);
                }
                Console.Clear();

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