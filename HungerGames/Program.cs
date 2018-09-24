using HungerGames.Tributes;
using System;

namespace HungerGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It was a bright day in April, and the clocks were striking thirteen.");

            PlayerFactory pf = new PlayerFactory();
            pf.GeneratePlayers();
        }
    }
}
