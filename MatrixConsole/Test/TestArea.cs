using System.Text;

namespace MatrixConsole.Test
{
    internal class TestArea
    {
        static internal void ShowTestArea()
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("This is the Test Area.\r\n" +
                "Here you can try new learned things.");

            Console.WriteLine("приключения");
            string name = Console.ReadLine();
            Console.WriteLine($"Список имен: matrix {name}");
            Console.ReadKey();
        }
    }
}
