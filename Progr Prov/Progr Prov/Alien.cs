using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_Prov
{
    class Alien : SuperHero
    {
        public Alien()
        {
            hp = Klasser.RandInt(50, 60);
            ability = raceAbilityDataBase[1];
        }

        public override void TakeDamage(int damage, string Race)
        {
            int extraDamage = 0;
            if (race == raceDataBase[2])
            {
                extraDamage = 10;
            }
            Hp -= damage + extraDamage;
        }

    }
}
