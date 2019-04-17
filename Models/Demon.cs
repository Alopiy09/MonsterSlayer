using System;

namespace MonsterSlayer
{
    public class Demon : Creature, ICombustable, IDouseInWater, ISilverCut
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed a demon");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed a demon");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("you just killed a demon");
            }
        }
    }
}