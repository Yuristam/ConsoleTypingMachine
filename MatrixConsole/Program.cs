﻿using MatrixConsole;
using MatrixConsole.Matrix;

class Program
{
    internal static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to my console app!");
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write('=');
            }
            Console.ResetColor();

            // the Main Menu of the program
            Console.WriteLine("Main menu\r\n" +
                              "1) Type Matrix to choose Matrix.\r\n" +
                              "2) Type Chainsaw Man (or Chainsaw) to choose Chainsaw Man.\r\n" +
                              "4) Exit.");
            Console.Write(">");

            string input = Console.ReadLine().Trim().ToLower();

            //========================================================================================================================
            if (input == "matrix")
            {
                Console.Clear();
                Matrix.ShowMatrix();
            }
            else if (input == "chainsaw man" || input == "chainsaw")
            {
                Console.Clear();
                ChainsawMan.GunDevil();
            }
            else if (input == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please, write something that is in the list above.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
