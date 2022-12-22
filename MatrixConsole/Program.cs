using MatrixConsole;
while (true)
{
    Console.WriteLine("Type Matrix to chose Matrix.");
    Console.Write(">");
    string input = Console.ReadLine().Trim().ToLower();

    if (input == "matrix")
    {
        Console.Clear();
        Matrix.ShowMatrix();
    }
    if (input == "quit" || input == "q")
    {
        MenuCommands.MenuExit();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Please, write something that is in the list above.");
        Thread.Sleep(1000);
        Console.Clear();
    }
}