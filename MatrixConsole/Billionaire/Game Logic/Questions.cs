namespace MatrixConsole.Billionaire.Game_Logic
{
    internal class Questions
    {
        internal static void ShowQuestion(List<string> questions) 
        {
            questions = new List<string> {};
            /*foreach (var question in questions)
            {
                questions.Add(question);
            }*/
            string question1 = "The capital city of UK?\r\n" +
                "Answers:\r\n1. London\r\n2. Madrid\r\n3. Washington\r\n4. Moscow";
            questions.Add(question1);
        }
    }
}
