using System.Text;

namespace MatrixConsole.Test
{
    internal class TestArea
    {
        static internal void ShowTestArea()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This is the Test Area.\r\n" +
                "Here you can try new learned things.\r\n" +
                "Type 1 if you wanna test Cyrillic script");
                Console.Write(">");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    //the code below is the one for a Console to show sybols in different writing system (script)
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.InputEncoding = Encoding.Unicode;
                    //for example if there is a Cyrillic (кирилица) script
                    Console.WriteLine("Какая-то надпись!!!");
                    Console.ReadKey();
                    //===========================================================================
                }
                else if (input == "get back" || input == "gb")
                {
                    Program.Main();
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
}
