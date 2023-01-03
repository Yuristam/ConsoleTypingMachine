using static MatrixConsole.Billionaire.Game_Logic.Questions;
namespace MatrixConsole.Billionaire.Game_Logic
{
    internal class GameLevels
    {
        internal static void StartGame()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Random randomQuestion=new Random();
                i = randomQuestion.Next(0, 10);
                Console.WriteLine(i);
            }
        }
    }
}
