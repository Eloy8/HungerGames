using hungergames.tributes;
using HungerGames.Tributes;
using System;
using System.Collections.Generic;

namespace HungerGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //.generatePlayers(24);

            PlayerFactory pf = new PlayerFactory();
            pf.GeneratePlayers();


        }
    }
}
