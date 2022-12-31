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
            Thread.Sleep(1000);

            //----------------------------------------------
            Console.Clear();
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

            //----------------------------------------------

            //string peopleArray is in the ChainsawManPeople class

            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            for (int i = 0; i < peopleArray3.Length; i++)
            {
                Console.Write(peopleArray3[i]);
                Thread.Sleep(50);


                //for (int j = 27; j < i; j+=27) //this is for after every 27th person in loop(peopleArray3)  //there is AN ERROR(it's not working like I want)

                // i need to fix this bad code to  the right code (with loop like above)
                if (i == 27)
                {
                    Console.Clear();
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
                }
                else if (i == 135)
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
            Console.Clear();
            Console.ResetColor();

            //----------------------------------------------
            string date3 = "3:18:23 Makima\r\n\r\nsights the Gun Devil\r\n\r\nat a distance of 500 kilometers.";
            date3.ToCharArray();
            for (int i = 0; i < date3.Length; i++)
            {
                Console.Write(date3[i]);
                Thread.Sleep(50);
            };
            Thread.Sleep(1000);
            Console.Clear();

            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters

            string[] peopleArray4 = new string[] { people8, people9 };

            for (int i = 0; i < peopleArray4.Length; i++)
            {
                peopleArray4[i].ToCharArray();
                for (int k = 0; k < peopleArray4[i].Length; k++)
                {
                    Console.Write(peopleArray4[i][k]);
                    Thread.Sleep(10);
                }
                Console.Clear();
            }
            Thread.Sleep(1000);
            Console.ResetColor();

            //----------------------------------------------
            string date4 = "3:18:24\r\n\r\nGun Devil ability activation:\r\n" +
                "Ability to fire a bullet through the heart\r\n" +
                "of every living thing born in the months of\r\n" +
                "January, February, March, May, June, August, September, November or\r\n" +
                "December within approximately one kilometer confirmed.";
            date4.ToCharArray();
            for (int i = 0; i < date4.Length; i++)
            {
                Console.Write(date4[i]);
                Thread.Sleep(50);
            };
            Thread.Sleep(1000);
            
            //----------------------------------------------
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters

            string[] peopleArray5 = new string[] { people10, people11 };

            for (int i = 0; i < peopleArray5.Length; i++)
            {
                peopleArray5[i].ToCharArray();
                for (int k = 0; k < peopleArray5[i].Length; k++)
                {
                    Console.Write(peopleArray5[i][k]);
                    Thread.Sleep(1);
                }
                Console.Clear();
            }
            Thread.Sleep(1000);
            Console.ResetColor();

            //----------------------------------------------
            string date5 = "3:18:25\r\n\r\nThe Gun Devil stops.\r\nGun Devil ability activation: gunfire toward Makima begins.";
            date5.ToCharArray();
            for (int i = 0; i < date5.Length; i++)
            {
                Console.Write(date5[i]);
                Thread.Sleep(50);
            };
            Console.Clear();

            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            for (int i = 0; i < peopleArray6.Length; i++)
            {
                Console.Write(peopleArray6[i]);
                Thread.Sleep(5);
                for (int j = 0; j < i; j++)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            
            //----------------------------------------------
            string date6 = "3:18:26\r\n\r\nMakima prepares for ability activation.";
            date6.ToCharArray();
            for (int i = 0; i < date6.Length; i++)
            {
                Console.Write(date6[i]);
                Thread.Sleep(50);
            };
            Console.Clear();

            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            for (int i = 0; i < peopleArray7.Length; i++)
            {
                Console.Write(peopleArray7[i]);
                Thread.Sleep(5);
                for (int j = 0; j < i; j++)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            
            //----------------------------------------------
            string date7 = "Makima's 29th recorded death.\r\n\r\n3:18:27";
            date7.ToCharArray();
            for (int i = 0; i < date7.Length; i++)
            {
                Console.Write(date7[i]);
                Thread.Sleep(50);
            };
            Console.Clear();

            //----------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            for (int i = 0; i < peopleArray8.Length; i++)
            {
                Console.Write(peopleArray8[i]);
                Thread.Sleep(5);
                for (int j = 0; j < i; j++)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();

            //--------------------------------------------------------------------------------------------------

            string[] date8 = new string[] {
                         "Makima ability activation:",
                         "Use of the following's abilities.",
                         "Yutaro Kurose and Michiko Tendo's antemortem Devil contract, Punishment Devil",
                         "Akane Sawatari's antemortem Devil contract, Snake Devil",
                         "Aki Hayakawa's antemortem Devil contract, Future Devil",
                         "Angel Devil",
                         "Spider Devil",
                         "3:18:28"
                     };
            for (int i = 0; i < date8.Length; i++) //this is the loop for each text. (first array[the texts array])
            {
                Thread.Sleep(1000);
                Console.Clear();
                date8[i].ToCharArray(); // to turn every character in the text array to char array, so I can use every single symbol in the text separately
                for (int j = 0; j < date8[i].Length; j++) // this is for the char array. (It takes string(neo2[i]) to use every text in [text array])
                {
                    Console.Write(date8[i][j]); //first, string neo2 gets the first text in the text array[i], then it shows every symbol in char array in array[j]
                    Thread.Sleep(50);
                };
                Console.WriteLine();
            }

            //--------------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Red; //for the red color of letters
            string door = @"  _____              _ _                              _   _                _                  
 |█████\            (█)█|                            |█| |█|              |█|                 
 |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
 |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
 |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
 |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                  |█|                                                         
                                  |█|  ";
            string door2 = @"   _____              _ _                              _   _                _                  
  |█████\            (█)█|                            |█| |█|              |█|                 
  |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
  |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
  |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
  |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                   |█|                                                         
                                   |█|  ";
            string door3 = @"    _____              _ _                              _   _                _                  
   |█████\            (█)█|                            |█| |█|              |█|                 
   |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
   |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
   |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
   |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                    |█|                                                         
                                    |█|  ";
            string door4 = @"
   _____              _ _                              _   _                _                  
  |█████\            (█)█|                            |█| |█|              |█|                 
  |█|  |█| ___  _ __ |/|█|_    ___  _ __   ___ _ __   |█|_|█|__   ___    __|█| ___   ___  _ __ 
  |█|  |█|/███\|████\  |███|  /███\|████\ ▄▀▀▄\█'██\  |███|█'██\ ▄▀▀▄\  /██`█|/███\ /███\|█'█▄|
  |█|__|█|█(_)█|█| |█| |█|_  |█(_)█|█|_)█|█▀▀▀/█| |█| |█|_|█| |█|█▀▀▀/ |█(_|█|█(_)█|█(_)█|█|   
  |█████/ \███/|█| |█|  \██|  \███/|████/ ▀▄▄▀|█| |█|  \██|█| |█|▀▄▄▀|  \██,█|\███/ \███/|█|   
                                   |█|                                                         
                                   |█|  ";

            string[] doorArray = new string[] {
                door, door2, door3, door2, door4, door2
            };
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < doorArray.Length; i++)
                {
                    Console.WriteLine(doorArray[i]);
                    Thread.Sleep(20);
                    Console.Clear();
                }
                Thread.Sleep(20);
            }
            Console.ResetColor();
        }
        //gun devil attack ending
    }
}