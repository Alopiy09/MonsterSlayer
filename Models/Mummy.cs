using System;


namespace MonsterSlayer
{
    public class Mummy : Creature, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Mummy");
            }
        }
    }
}