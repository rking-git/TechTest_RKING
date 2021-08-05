using System;

namespace TechTest_RKING
{
    class Start
    {
        //Inits the other methods.
        public static void StartInit()
        {
            Start.StartTitle();
            Start.StartBeeps();
            Start.StartText();
        }
        //Displays an ASCII title that plays at the start of the game.
        public static void StartTitle()
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("|    _______                                       _______    |");
            Console.WriteLine("|---'   ____)                                   __(____   '---|");
            Console.WriteLine("|      (_____)              ROCK             (______          |");
            Console.WriteLine("|      (_____)             PAPER            (__________       |");
            Console.WriteLine("|      (____)             SCISSORS                (____)      |");
            Console.WriteLine("|---.__(___)                                       (___)__.---|");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("===============================================================\n");
        }

        //Plays a simple tune that plays at the start of the game.
        public static void StartBeeps()
        {
            Console.Beep(450, 110);

            Console.Beep(500, 110);

            Console.Beep(550, 200);

            Console.Beep(650, 200);

            Console.Beep(475, 300);

            Console.Beep(700, 400);

            Console.Beep(650, 500);
        }

        //Creates the text at the start of the game and inits game logic.
        public static void StartText()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors. You are playing against the \ncomputer to win, best of three rounds! Good luck!\n");
            Logic logic = new Logic();
            logic.NewGame();
        }
    }
}