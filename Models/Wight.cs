using System;


namespace MonsterSlayer
{
    public class Wight : Creature, ISilverCut
    {
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed a wight");
            }
        }
    }
}