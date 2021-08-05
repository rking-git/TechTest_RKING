using System;
using TechTest_RKING;

namespace TechTest_RKING
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.StartInit();
        }
    }
}

/*Notes: BaseLogic.Result Might be overcomplicated, use of ints affects readability. Could move more functionality to base class.
Had to fix Console.Beep warning for platform compatiability, might be better solution. */