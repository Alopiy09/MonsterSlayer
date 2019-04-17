using System;


namespace MonsterSlayer
{
    public class Zombie : Creature, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed a zombie");
            }
        }
    }
}