using System;

namespace MonsterSlayer
{
    public class Ghast : Creature, ICombustable, IDouseInWater
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed a ghast");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed a ghast");
            }
        }
    }
}