using System;

namespace MonsterSlayer
{
    class Program
    {

        public static void Main()
        {

            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");
            Hunter VanHellsing = new Hunter("Van", "Hellsing");

            Mummy tuts = new Mummy();

            Vampire YuhBoi = new Vampire();


            VanHellsing.Ignite(YuhBoi);
            VonRimmersmark.Ignite(tuts);

            
        }
    }
}

