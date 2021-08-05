using System;

namespace TechTest_RKING
{
    interface ILogic
    {
        //Starts a new game.
        void NewGame();

        //Handles scores for each round.
        void ScoreHandler(bool inputCheck, string input, int rounds);

        //Takes the result of the user and computer's move and adds it to total moves used.
        void MoveUsed(int move);
    }
}