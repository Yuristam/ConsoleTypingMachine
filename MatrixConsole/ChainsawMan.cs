using static MatrixConsole.ChainsawManPeople;
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

            //----------------------------------------------
            Console.Clear();
            string ability = "Immediately upon appearance: ability activation. Ability to fire a bullet through the head \r\n" +
                "of every adult male within approximately 1,000 meters of the Gun Devil \r\n" +
                "confirmed." +
                "\r\n\r\nAbility to fire a bullet through the head of every child (ages 0-12) within approximately \r\n" +
                "1,500 meters of the Gun Devil confirmed.";
            ability.ToCharArray();
            for (int i = 0; i < ability.Length; i++)
            {
                Console.Write(ability[i]);
                Thread.Sleep(50);
            };
            Thread.Sleep(2000);

            //----------------------------------------------
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            /*ChainsawManPeople*/people1.ToCharArray();
            for (int i = 0; i < people1.Length; i++)
            {
                Console.Write(people1[i]);
                Thread.Sleep(10);
            };/*
            Console.WriteLine(ChainsawManPeople.people1);*/
            Console.ResetColor();
        }
        //gun devil attack ending
    }
}
