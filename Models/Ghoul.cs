using System;

namespace MonsterSlayer
{
    public class Ghoul : Creature, IDouseInWater, ISilverCut
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed a ghoul");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed a ghoul");
            }
        }
    }
}