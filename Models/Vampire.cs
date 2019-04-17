using System;


namespace MonsterSlayer
{

    public class Vampire : Creature, ICombustable, ISilverCut
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Vampire");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed the Vampire");
            }
        }
    }
}
