namespace MatrixConsole
{
    internal class ChainsawMan
    {
        //gun devil attack beginning
        internal static void GunDevil()
        {
            string date = "September 12, 1997 3:18:21 P.M.";
            date.ToCharArray();
            for (int i = 0; i < date.Length; i++)
            {
                Console.Write(date[i]);
                Thread.Sleep(50);
            };

            //----------------------------------------------
            Thread.Sleep(1000);
            Console.Clear();
            string record1 = "The ";
            record1.ToCharArray();
            for (int i = 0; i < record1.Length; i++)
            {
                Console.Write(record1[i]);
                Thread.Sleep(50);
            };
            
            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            string recordRed1 = "GUN DEVIL ";
            recordRed1.ToCharArray();
            for (int i = 0; i < recordRed1.Length; i++)
            {
                Console.Write(recordRed1[i]);
                Thread.Sleep(50);
            };
            Console.ResetColor();
            
            //----------------------------------------------
            string record2 = "hits the city of \r\n" +
                "Nikaho in Akita Prefecture, Japan \r\n" +
                "from off the coast for ";
            record2.ToCharArray();
            for (int i = 0; i < record2.Length; i++)
            {
                Console.Write(record2[i]);
                Thread.Sleep(50);
            };

            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            string recordRed2 = "12 seconds.";
            recordRed2.ToCharArray();
            for (int i = 0; i < recordRed2.Length; i++)
            {
                Console.Write(recordRed2[i]);
                Thread.Sleep(50);
            };
            Thread.Sleep(2000);
            Console.ResetColor();
        }
        //gun devil attack ending
    }
}
