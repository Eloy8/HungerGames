using hungergames.tributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HungerGames.Tributes
{
    class PlayerFactory
    {
        int AmountOfPlayers = 0;
        RandomStats rs = new RandomStats();
        public void GeneratePlayers() {
            while (AmountOfPlayers < 24)
            {
                Gender gender = rs.GetGender(24);
                int age = rs.GetAge();
                string name = rs.GetName(gender);
                
                Player player = new Player(AmountOfPlayers+1, name, age, gender);
                Console.WriteLine(player);
                AmountOfPlayers++;
            }
        }
    }
}
