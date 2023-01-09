// "using static System.Console" I can use just "WriteLine" or just "ReadLine"
// without writing "Console" every time. Also I can use "global" like "using static global"
// to write it not only in this class, but in every class in this project
using static System.Console;
namespace MatrixConsole.Dungeon_Adventure
{
    //still in development
    internal class DungeonGameMenu
    {
        internal static void ShowGameMenu()
        {/*
           
            //Battle time start          
            float health;
            float armor;
            float damage;
            float percentConverter = 100; // переводит числа в проценты, для того чтобы перевести урон в проценты

            Write("Enter health points:");
            health = Convert.ToInt32(ReadLine());
            Write("Enter armor points:");
            armor = Convert.ToInt32(ReadLine());
            Write("Enter damage points:");
            damage = Convert.ToInt32(ReadLine());

            health -= damage / percentConverter* armor ;

            WriteLine($"You've taken {damage} damage. You have {health} health.");
            ReadKey();*/
            //battle time end

            //==================================================================================================================


            /*
            //shop time start 
            int money;
            int food;
            int foodUnitPrice = 10; // цена одной еды
            bool isAbleToPay;


            WriteLine("Welcome to the Bakery, Warrior! Today food is for"+ foodUnitPrice+"money.");
            WriteLine("how much money you have?");
            money = Convert.ToInt32(ReadLine());
            WriteLine("how many food do you need ?");
            food = Convert.ToInt32(ReadLine());

            isAbleToPay = money >= food * foodUnitPrice; //переменная isAbleToPay запишет либо true, либо false. True будет если у нас денег будет больше или равно стоимости еды, которую мы хотим получить. False денег меньше чем еды, которую мы хотим получить

            // мы тут ковертируем true(1) или false(0) в toInt32.
            // В результате мы получим
            // 1) если isAbleToPay у нас равно true, она конвертируется в единицу(1), а в food запишется то кол-во еды,
            // которое мы хотим и мы уже от переменной money отнимем, то кол-во еды которые мы хотим.
            // 2) Если же isAbleToPay будет false(0), то мы получим ноль(0).
            // Food * на ноль и в итоге мы от money отнимем ноль, таким образом у нас останутся все деньги.
            food *= Convert.ToInt32(isAbleToPay); 
            money-= food*foodUnitPrice;

            WriteLine($"you have {food} food in bag and {money} monay.");
            ReadKey();
            //shop time end
*/

            // interesting thing
/*            int age;
            Write("Введите свой возраст:");
            age = Convert.ToInt32(ReadLine());
            if (age >= 18)
            {
                WriteLine("Добро пожаловать в наш бар!");
                WriteLine("Что будете пить?");
            }
            else
            {
                WriteLine("Вы слишком юны.");
                WriteLine("Приходите к нам через: " + (18 - age) + " лет.");
            }
*/        }
    }
}
