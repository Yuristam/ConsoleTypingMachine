using MatrixConsole;
class Program
{
    internal static void Main()
    {
        //beginning of the program
        while (true)
        {
            // the welcome part of the program

            // the Main Menu of the program
            Console.WriteLine("Type Matrix to chose Matrix.");
            Console.WriteLine("Type Chainsaw Man to chose Chainsaw Man.");
            Console.Write(">");

            string input = Console.ReadLine().Trim().ToLower();


            // if you wanna see Matrix movie console
            if (input == "matrix")
            {
                Console.Clear();
                Matrix.ShowMatrix();
            }

            //if you wanna see chainsaw man (gun devil attack)
            if (input == "chainsaw man" || input == "chainsaw")
            {
                Console.Clear();
                ChainsawMan.GunDevil();
            }












            /*

                if (input == "man")
                {
                    Console.WriteLine("Ichika Nito\tMasasi Kisimoto\r\nEren\tAndrew Garfield\r\n");
                    Console.ReadKey();
                }*/

            //========================================================================================================================

            // if you wanna quit
            if (input == "quit" || input == "q")
            {
                MenuCommands.MenuExit();
            }

            // if you entered the wrong word or key
            else
            {
                Console.Clear();
                Console.WriteLine("Please, write something that is in the list above.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        //end of the program
    }
}
