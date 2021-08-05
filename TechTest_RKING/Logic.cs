using System;
using System.Linq;

namespace TechTest_RKING
{
    class Logic : BaseLogic, ILogic
    {
        private int userScore = 0;
        private int compScore = 0;
        private int gameTurns = 0;

        //Used to find the most used move at the end of the game.
        private int[] rockPaperScissors = new int[3] { 0, 0, 0 };

        //Starts a new game.
        public void NewGame()
        {
            bool newRound = true;
            int rounds = 3;

            while (newRound)
            {
                Console.WriteLine("\nPlease choose your move by typing a number then pressing ENTER:\nRock (1), Paper (2) or Scissors (3)?\n");

                var input = Console.ReadLine();
                bool inputCheck = CheckInt(input, rounds);

                ScoreHandler(inputCheck, input, rounds);

                if (gameTurns >= rounds)
                {
                    newRound = false;
                    int maxValue = rockPaperScissors.Max();
                    int mostUsed = rockPaperScissors.ToList().IndexOf(maxValue);
                    MostUsedMove(mostUsed);
                    WinOrLoseHandler(userScore, compScore);
                }
            }
        }

        //Handles scores for each round.
        public void ScoreHandler(bool inputCheck, string input, int rounds)
        {
            if (inputCheck)
            {
                Tuple<int, int, int> resultCheck = Result(input, rounds);

                switch (resultCheck.Item1)
                {
                    case 0:
                        gameTurns++;
                        break;
                    case 1:
                        userScore++;
                        gameTurns++;
                        break;
                    case 2:
                        compScore++;
                        gameTurns++;
                        break;
                    case 3:
                        Console.WriteLine("An error has occured (result outside of response range).");
                        break;
                }

                MoveUsed(resultCheck.Item2);
                MoveUsed(resultCheck.Item3);
            }
            else
            {
                Console.WriteLine($"Your input was not recognised. Please enter a single number\nof 1, 2 or 3 for Rock, Paper or Scissors.");
            }
        }

        //Takes the result of the user and computer's move and adds it to total moves used.
        public void MoveUsed(int move)
        {
            switch (move)
            {
                case 0:
                    rockPaperScissors[0]++;
                    break;
                case 1:
                    rockPaperScissors[1]++;
                    break;
                case 2:
                    rockPaperScissors[2]++;
                    break;
            }
        }
    }
}