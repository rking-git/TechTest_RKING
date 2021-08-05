using System;

namespace TechTest_RKING
{
    class BaseLogic
    {
        protected static void Output(int num)
        {
            BaseLogic baseLogic = new BaseLogic();

            switch (num)
            {
                case 0:
                    Console.WriteLine("You chose Rock.");
                    break;
                case 1:
                    Console.WriteLine("You chose Paper.");

                    break;
                case 2:
                    Console.WriteLine("You chose Scissors.");

                    break;
                case 3:
                    Console.WriteLine("You chose Spock.");

                    break;
                case 4:
                    Console.WriteLine("You chose Lizard.");

                    break;
                case 5:
                    Console.WriteLine("Computer chose Rock.");

                    break;
                case 6:
                    Console.WriteLine("Computer chose Paper.");

                    break;
                case 7:
                    Console.WriteLine("Computer chose Scissors.");

                    break;
                case 8:
                    Console.WriteLine("Computer chose Spock.");

                    break;
                case 9:
                    Console.WriteLine("Computer chose Lizard.");

                    break;
                case 10:
                    Console.WriteLine("It's a draw!");
                    break;
                case 11:
                    Console.WriteLine("Computer wins the round!");
                    break;
                case 12:
                    Console.WriteLine("You win the round!");
                    break;
            }
        }

        //Determines who won the round and returns an int, 0 for draw, 1 for user win, 2 for computer win and 3 for error.
        protected static Tuple<int, int, int> Result(string input, int rounds)
        {
            int compRandom = Random(rounds);
            int.TryParse(input, out int resultNum);

            switch (resultNum, compRandom)
            {
                //User chooses Rock.
                case (1, 1):
                    Output(0);
                    Output(5);
                    Output(10);
                    return Tuple.Create(0, 0, 0);
                case (1, 2):
                    Output(0);
                    Output(6);
                    Output(11);
                    return Tuple.Create(2, 0, 1);
                case (1, 3):
                    Output(0);
                    Output(7);
                    Output(12);
                    return Tuple.Create(1, 0, 2);
                case (1, 4):
                    Output(0);
                    Output(8);
                    Output(11);
                    return Tuple.Create(2, 0, 3);
                case (1, 5):
                    Output(0);
                    Output(9);
                    Output(12);
                    return Tuple.Create(1, 0, 4);
                //User chooses Paper.
                case (2, 1):
                    Output(1);
                    Output(5);
                    Output(12);
                    return Tuple.Create(1, 1, 0);
                case (2, 2):
                    Output(1);
                    Output(6);
                    Output(10);
                    return Tuple.Create(0, 1, 1);
                case (2, 3):
                    Output(1);
                    Output(7);
                    Output(11);
                    return Tuple.Create(2, 1, 2);
                case (2, 4):
                    Output(1);
                    Output(8);
                    Output(12);
                    return Tuple.Create(1, 1, 3);
                case (2, 5):
                    Output(1);
                    Output(9);
                    Output(11);
                    return Tuple.Create(2, 1, 4);
                //User chooses Scissors.
                case (3, 1):
                    Output(2);
                    Output(5);
                    Output(11);
                    return Tuple.Create(2, 2, 0);
                case (3, 2):
                    Output(2);
                    Output(6);
                    Output(12);
                    return Tuple.Create(1, 2, 1);
                case (3, 3):
                    Output(2);
                    Output(7);
                    Output(10);
                    return Tuple.Create(0, 2, 2);
                case (3, 4):
                    Output(2);
                    Output(8);
                    Output(11);
                    return Tuple.Create(2, 2, 3);
                case (3, 5):
                    Output(2);
                    Output(9);
                    Output(12);
                    return Tuple.Create(1, 2, 4);
                //User chooses Spock.
                case (4, 1):
                    Output(3);
                    Output(5);
                    Output(12);
                    return Tuple.Create(1, 3, 0);
                case (4, 2):
                    Output(3);
                    Output(6);
                    Output(11);
                    return Tuple.Create(2, 3, 1);
                case (4, 3):
                    Output(3);
                    Output(7);
                    Output(12);
                    return Tuple.Create(1, 3, 2);
                case (4, 4):
                    Output(3);
                    Output(8);
                    Output(10);
                    return Tuple.Create(0, 3, 3);
                case (4, 5):
                    Output(3);
                    Output(9);
                    Output(11);
                    return Tuple.Create(2, 3, 4);
                //User chooses Lizard.
                case (5, 1):
                    Output(4);
                    Output(5);
                    Output(11);
                    return Tuple.Create(2, 4, 0);
                case (5, 2):
                    Output(4);
                    Output(6);
                    Output(12);
                    return Tuple.Create(1, 4, 1);
                case (5, 3):
                    Output(4);
                    Output(7);
                    Output(11);
                    return Tuple.Create(2, 4, 2);
                case (5, 4):
                    Output(4);
                    Output(8);
                    Output(12);
                    return Tuple.Create(1, 4, 3);
                case (5, 5):
                    Output(4);
                    Output(9);
                    Output(10);
                    return Tuple.Create(0, 4, 4);
                //Error.
                default:
                    return Tuple.Create(0, 5, 5);
            }
        }

        //Creates a random number between one and three.
        protected static int Random(int rounds)
        {
            Random r = new Random();
            return r.Next(1, (rounds + 1));
        }

        //Checks if a Y/N choice was entered correctly.
        protected static bool CheckYN(string newGame)
        {
            return (newGame == "Y" || newGame == "N" || newGame == "y" || newGame == "n" || newGame == "RPSSL" || newGame == "rpssl");
        }

        //Checks if the input is an integer and of the right size.
        protected static bool CheckInt(string input, int rounds)
        {
            bool inputResult = int.TryParse(input, out int inputNum);

            return (inputResult && inputNum > 0 && inputNum <= rounds);
        }

        //Handles the user choosing a new game or not.
        protected static void NewGameYN()
        {
            var newGame = Console.ReadLine();
            bool newGameCheck = CheckYN(newGame);

            if (newGameCheck && (newGame == "Y" || newGame == "y"))
            {
                Logic logic = new Logic();
                logic.NewGame();
            }
            else if (newGameCheck && (newGame == "RPSSL" || newGame == "rpsll"))
            {
                LogicRPSSL logicRPSSL = new LogicRPSSL();
                logicRPSSL.NewGame();
            }
            else if (!newGameCheck)
            {
                Console.WriteLine("Your input was not recognised. Please enter a single character,\nY or N then press ENTER.");
                NewGameYN();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        //Handles the win/lose message at the end of the game.
        protected void WinOrLoseHandler(int userScore, int compScore)
        {
            if (userScore > compScore)
            {
                Console.WriteLine("\nYou won this game! Would you like to play again (Y/N)? (You can also type 'RPSSL' for a bonus mode!)\n");
                NewGameYN();
            }
            else if (userScore < compScore)
            {
                Console.WriteLine("\nSorry, you lost this game! Would you like to play again (Y/N)? (You can also type 'RPSSL' for a bonus mode!)\n");
                NewGameYN();
            }
            else
            {
                Console.WriteLine("\nThe game was a tie! Would you like to play again (Y/N)? (You can also type 'RPSSL' for a bonus mode!)\n");
                NewGameYN();
            }
        }

        //Calculates and displays the most used move during the game.
        protected void MostUsedMove(int mostUsed)
        {
            switch (mostUsed)
            {
                case 0:
                    Console.WriteLine("\nRock was one of the most used moves during this game!");
                    break;
                case 1:
                    Console.WriteLine("\nPaper was one of the most used moves during this game!");
                    break;
                case 2:
                    Console.WriteLine("\nScissors was one of the most used moves during this game!");
                    break;
                case 3:
                    Console.WriteLine("\nSpock was one of the most used moves during this game!");
                    break;
                case 4:
                    Console.WriteLine("\nLizard was one of the most used moves during this game!");
                    break;
            }
        }
    }
}