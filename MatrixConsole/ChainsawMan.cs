using static MatrixConsole.ChainsawManPeople;
namespace MatrixConsole
{
    internal class ChainsawMan
    {
        //gun devil attack beginning
        internal static void GunDevil()
        {/*
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
            Thread.Sleep(2000);*/

            /*           //----------------------------------------------
                       Console.Clear();
                       Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters

                       string[] peopleArray1 = new string[] { people1, people2, people3, people4, people5 };

                       //for each "people"(string) in peopleArray1. To turn it into charArray(in console)
                       for (int i = 0; i < peopleArray1.Length; i++)
                       {
                           peopleArray1[i].ToCharArray();
                           for (int k = 0; k < peopleArray1[i].Length; k++)
                           {
                               Console.Write(peopleArray1[i][k]);
                               Thread.Sleep(1);
                           }
                           Console.Clear();
                       }
                       Thread.Sleep(1000);*/

            //----------------------------------------------
            /*  Console.Clear();
              Thread.Sleep(1000);

              string[] peopleArray2 = new string[] { people6, people7 };

              for (int i = 0; i < peopleArray2.Length; i++)
              {
                  peopleArray2[i].ToCharArray();
                  for (int k = 0; k < peopleArray2[i].Length; k++)
                  {
                      Console.Write(peopleArray2[i][k]);
                      Thread.Sleep(1);
                  }
                  Console.Clear();
              }
              Thread.Sleep(1000);
              Console.ResetColor();

              //----------------------------------------------
              string date2 = "3:18:22\r\nThe Gun Devil advances toward Makima.";
              date2.ToCharArray();
              for (int i = 0; i < date2.Length; i++)
              {
                  Console.Write(date2[i]);
                  Thread.Sleep(50);
              };
  */
            //----------------------------------------------

            //string peopleArray is in the ChainsawManPeople class
            for (int i = 0; i < peopleArray3.Length; i++)
            {
                Console.Write(peopleArray3[i]);
                Thread.Sleep(50);/*
                for (int j = 27; j < i; j+=27) //this is for after every 27th person in loop(peopleArray3)  //there is AN ERROR
                {*/
                if (i == 27)
                {
                    Console.Clear();
                    /*}*/
                }
                else if (i == 54)
                {
                    Console.Clear();
                }
                else if (i == 81)
                {
                    Console.Clear();
                }
                else if (i == 108)
                {
                    Console.Clear();
                }else if (i == 135)
                {
                    Console.Clear();
                }
                else if (i == 162)
                {
                    Console.Clear();
                }
                else if (i == 189)
                {
                    Console.Clear();
                }
                else if (i == 216)
                {
                    Console.Clear();
                }
                else if (i == 243)
                {
                    Console.Clear();
                }
            };


            //ВАЖНО НА ЗАВТРА: МНЕ НУЖНО ИСПОЛЬЗОВАТЬ ТАБУЛЯЦИЮ ЗДЕСЬ!!! А еще нужно don't open the door сделать вращающимся, например cw(" don't") cw("  don't")cw("don't ")cw("don't  ")


            /*
                        //----------------------------------------------
                        Console.Clear();
                        people2.ToCharArray();
                        for (int i = 0; i < people2.Length; i++)
                        {
                            Console.Write(people2[i]);
                            Thread.Sleep(1);
                        };

                        //----------------------------------------------
                        */
        }
        //gun devil attack ending
    }
}