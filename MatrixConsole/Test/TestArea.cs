using System.Text;

namespace MatrixConsole.Test
{
    internal class TestArea
    {
        static internal void ShowTestArea()
        {/*
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
            }*/



            /*string dayOfWeek;
            dayOfWeek=Console.ReadLine();

            switch(dayOfWeek)
            {
                case "Monday":
                    Console.WriteLine("go to the cinema.");
                    Console.WriteLine("Eat popcorn.");
                    break;
                case "Tuesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Study Lesson");
                    break;
                case "Wednesday":
                    Console.WriteLine("Project smth");
                    break;
                default:
                    Console.WriteLine("I don't know this day");
                    break;
            }*/


            /*
                        string password = "123qwe";
                        string userInput;
                        Console.Write("Enter password: ");
                        userInput = Console.ReadLine();

                        if (userInput == password)
                        {
                            Console.WriteLine("Password accepted. Access to DataBase confirmed");
                        }
                        else
                        {
                            Console.WriteLine("Wrong password. Access denied.");
                        }
                       // Console.ReadKey();*/






            /*
                        decimal MyRubles;
                        decimal MyDollars;

                        int rubToUsd = 64, UsdToRub = 66; // actually i need a decimal here

                        decimal exchangeCurrencyCount;

                        string desiredOperation;

                        Console.WriteLine("Weelcome my friend, give me your money, they will be safe!");

                        Console.Write("Enter rubbles:");
                        MyRubles = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter dollars:");
                        MyDollars= Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Choose option:");
                        Console.WriteLine("1 - rub to dol");
                        Console.WriteLine("2 - dol to rub"); // 3 variant show me my money
                        Console.WriteLine("Your Choice: ");
                        desiredOperation= Console.ReadLine();

                        switch(desiredOperation)
                        {
                            case "1":
                                Console.WriteLine("change rub to dol. obmen rubley na dollars");
                                Console.WriteLine("how much do you wanna give me, babe?");
                                exchangeCurrencyCount=Convert.ToDecimal(Console.ReadLine());
                                if(MyRubles>= exchangeCurrencyCount)
                                {
                                    MyRubles -= exchangeCurrencyCount;
                                    MyDollars += exchangeCurrencyCount / rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("you don't have so much money lil shit!");
                                }
                                break;
                                case "2":
                                Console.WriteLine("change dol to rub");
                                Console.WriteLine("how much do you wanna give me, babe?");
                                exchangeCurrencyCount = Convert.ToDecimal(Console.ReadLine());
                                if (MyDollars >= exchangeCurrencyCount)
                                {
                                    MyDollars -= exchangeCurrencyCount;
                                    MyRubles += exchangeCurrencyCount * UsdToRub;
                                }
                                else
                                {
                                    Console.WriteLine("you don't have so much money lil shit!");
                                }
                                break;
                            default:
                                Console.WriteLine("are you stupid,man?");
                                break;
                        }

                        Console.WriteLine($"Your balance: {MyDollars} dolllars and {MyRubles} rubbles.");
                        Console.ReadKey();*/
            /*
                        int triesCount = 5;
                        string password = "123";
                        string userInput;

                        for(int i=0; i<triesCount; i++)
                        {
                            Console.Write("Enter password: ");
                            userInput = Console.ReadLine();
                            if(userInput == password)
                            {
                                Console.WriteLine("Secret materials.");
                               break; // go to smwhere. or just break just like here
                            }
                            else
                            {
                                Console.WriteLine("yuo entered wrong pass. ");
                                Console.WriteLine($"only {triesCount - (i+1)} left.");
                            }
                        }
            if(triesCount < 0){
                        Console.WriteLine("you died");
                        }Console.ReadKey();*/

            /*
                        Console.InputEncoding= Encoding.UTF8;
                        Console.OutputEncoding= Encoding.UTF8;


                        decimal money;
                        int years;
                        int percent;

                        Console.Write("Введите кол-во денег, внесенных на вклад:");
                        money =Convert.ToDecimal(Console.ReadLine());
                        Console.Write("на сколько лет открыть вклад? ");
                        years= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Под какой процент? ");
                        percent = Convert.ToInt32(Console.ReadLine());

                        for (int i=0; i < years; i++)
                        {
                            money += money / 100 * percent;
                            Console.WriteLine("в этом году у вас "+ money);
                            Console.ReadKey();
                        }*/


            /*int playerHealth = 100;
            int playerDamage = 50;
            int enemyHealth = 50;
            int enemyDamage = 10;

            while(playerHealth> 0 && enemyHealth> 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " player.");
                Console.WriteLine(enemyHealth + " enemy.");
            }

            if (playerHealth <= 0 && enemyHealth <= 0) {
                Console.WriteLine("draw");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("win");

            }
            else if (playerHealth<=0)
            {
                Console.WriteLine("lose");

            }

*/
            /*
                        Random random= new Random();
                        float health1 = random.Next(90,100);
                        int damage1 = random.Next(5, 20);
                        int armor1 = random.Next(25, 65); 

                        float health2 = random.Next(80, 150);
                        int damage2 = random.Next(20, 40);
                        int armor2 = random.Next(65, 100);

                        Console.WriteLine($"warrior1 - {health1} health , {damage1} damage , {armor1} armor");
                        Console.WriteLine($"warrior2 - {health2} health , {damage2} damage , {armor2} armor");
                        Console.ReadKey();

                        while (health1> 0 && health2 > 0)
                        {
                            health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
                            health2 -= Convert.ToSingle(random.Next(0, damage1 + 1)) / 100 * armor2;

                            Console.WriteLine("health  of the first warrior: "+ health1);
                            Console.WriteLine("health  of the second warrior: "+ health2);
                        }

                        if(health1 <= 0 && health2 <=0)
                        {
                            Console.WriteLine("draw.");
                        }
                        else if(health1 <= 0)
                        {
                            Console.WriteLine("warrior one dead.");
                        }
                        else if(health2 <= 0)
                        {
                            Console.WriteLine("warrior two dead.");
                        }

                        Console.ReadKey();*/

            /*
                        // i need this to chainsaw man
                        Console.SetCursorPosition(5, 10);
                    */
            /*

                        //чтобы получить максимальное число в массиве
                        int[] array = { 1, 3, 24, 4, 14, -63, -62, 63, 97, 3, 24 };
                        int maxElement = int.MinValue;

                        for(int i =0; i < array.Length; i++)
                        {
                            if(maxElement < array[i])
                            {
                                maxElement = array[i];
                            }
                        }

                        Console.WriteLine(maxElement);
                    */

/*
            // cause i love you for infinty
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Double.PositiveInfinity);
            Console.WriteLine(Double.NegativeInfinity);

*/




/*
            // рейсы самолета

            Console.Clear();

            Console.InputEncoding= Encoding.UTF8;
            Console.OutputEncoding= Encoding.UTF8;



            int[] sectors = { 6, 28, 42, 25, 25, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"в секторе {i + 1} свободно {sectors[i]} мест"); // здесь мы прибавили +1 для удобства отображения(типа чтобы при отображении начиналось не с 0, а с 1.)
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("registeer рейс");
                Console.WriteLine("\n\n1-забронь место \n\n2-выход из проги.\n\n");
                Console.Write("Выберите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("в каком секторе вы хотите лететь?");
                        userSector= Convert.ToInt32(Console.ReadLine()) -1; // здесь минус один потому, что для удобства пользования мы прибавляли +1 отображении сектора.(там сверху)
                        if(sectors.Length <=userSector || userSector < 0)
                        {
                            Console.WriteLine("такого сектора нет ");
                            break;
                        }
                        Console.Write("сколько мест вы хотите забронить? ");
                        userPlaceAmount= Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("неверное число мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест." +
                                $" остаток {sectors[userSector]}");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("бронирование успешно");
                        break;
                  case 2:
                        isOpen = false;
                        break;
                }
            }*/



        }
    }
}
