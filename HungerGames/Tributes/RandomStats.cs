using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.Tributes;

namespace hungergames.tributes
{
    public class RandomStats
    {
        private int genderToggle = 0;
        Random rng = new Random();
        List<string> maleNames = new List<string> { "Beaufort", "Idannis", "Ivo", "Lartius", "Nimmo", "Scorpii", "Caldwell", "Venture", "Gunnar", "Thorburn", "Corbinus", "Jago", "Wolfmark", "Libo", "Leonis", "Atlas", "Whytt", "Fluh", "Raff", "Horatius", "Galahad", "Eero", "Huck", "Fir", "Leporis", "Libo", "Peeta" };
        List<string> femaleNames = new List<string> { "Terra", "Auriculá", "Lickprivick", "Domitia", "Fannia", "Soren", "Silver", "Valeria", "Katri", "Nitya", "Librae", "Orchid", "Merope", "Lillybird", "Vibia", "Fawn", "Gliese", "Plinky", "Hanneldre", "Tressa", "Blye", "Persei", "Charm", "Otillie", "Prine", "Zenobia", "Katniss" };

        public string GetName(Gender gender)
        {
            
            string name = null;
            
            switch (gender)
            {
                case Gender.MALE:
                    int mCount = rng.Next(0, (maleNames.Count-1));
                    name = maleNames[mCount];
                    maleNames.RemoveAt(mCount);
                    return name;
                case Gender.FEMALE:
                    int fCount = rng.Next(0, (femaleNames.Count-1));
                    name = femaleNames[fCount];
                    femaleNames.RemoveAt(fCount);
                    return name;
                default:
                    return name;

            }
        }

        public int GetAge()
        {
            int age = rng.Next(12, 18);
            return age;
        }

        public Gender GetGender(int amountofplayers)
        {
            if (genderToggle % 2 == 1)
            {
                genderToggle++;
                return Gender.FEMALE;
            }
            else
            {
                genderToggle++;
                return Gender.MALE;
            }
        }
    }
}
