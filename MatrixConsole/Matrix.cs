namespace MatrixConsole
{
    internal class Matrix
    {
        internal static void ShowMatrix()
        {
            //Home Work in CodeBlog Lesson #1

            Console.ForegroundColor = ConsoleColor.Green;

            string neo = "Wake up, Neo.";
            neo.ToCharArray();
            for (int i = 0; i < neo.Length; i++)
            {
                Console.Write(neo[i]);
                Thread.Sleep(50);
            };
            Console.WriteLine();

            //----------------------------------------
            Thread.Sleep(1000);
            Console.Clear();
            string neo2 = "The Matrix has you.";
            neo2.ToCharArray();
            for (int i = 0; i < neo2.Length; i++)
            {
                Console.Write(neo2[i]);
                Thread.Sleep(50);
            };
            Console.WriteLine();

            //----------------------------------------
            Thread.Sleep(1000);
            Console.Clear();
            string neo3 = "Follow the White Rabbit.";
            neo3.ToCharArray();
            for (int i = 0; i < neo3.Length; i++)
            {
                Console.Write(neo3[i]);
                Thread.Sleep(50);
            };
            Console.WriteLine();

            //----------------------------------------
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Knock, knock, Neo.");
            Thread.Sleep(1000);
            Console.ResetColor();
        }
    }
}