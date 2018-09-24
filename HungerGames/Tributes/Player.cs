using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.Tributes;

namespace HungerGames.Tributes
{
    class Player
    {
        private int id{ get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private Gender gender { get; set; }

        Player() { }

        public Player(int id, string name, int age, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
              
        public override string ToString()
        {
            if (gender == Gender.FEMALE)
            {
                return $"Contstant #{id} {name} is a {age} year old female!";
            } else if(gender == Gender.MALE)
            {
                return $"Contstant #{id} {name} is a {age} year old male!";
            } else {
                return null;
            }
        }
    }
}
