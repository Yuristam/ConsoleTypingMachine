namespace MatrixConsole;
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
        string[] neo2 = new string[] {
                "The Matrix has you.",
                "Follow the White Rabbit."
            };
        for (int i = 0; i < neo2.Length; i++) //this is the loop for each text. (first array[the texts array])
        {
            Thread.Sleep(1000);
            Console.Clear();
            neo2[i].ToCharArray(); // to turn every character in the text array to char array, so I can use every single symbol in the text separately
            for (int j = 0; j < neo2[i].Length; j++) // this is for the char array. (It takes string(neo2[i]) to use every text in [text array])
            {
                Console.Write(neo2[i][j]); //first, string neo2 gets the first text in the text array[i], then it shows every symbol in char array in array[j]
                Thread.Sleep(50);
            };
            Console.WriteLine();
        }

        //----------------------------------------
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Knock, knock, Neo.");
        Thread.Sleep(1000);
        Console.ResetColor();
        // the end of the program





        //the first variant

        /*//----------------------------------------
        Thread.Sleep(1000);
        Console.Clear();
        neo = "The Matrix has you.";
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
        neo = "Follow the White Rabbit.";
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
        Console.WriteLine("Knock, knock, Neo.");
        Thread.Sleep(1000);
        Console.ResetColor();*/
    }
}