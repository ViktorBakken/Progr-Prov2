using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_Prov
{
    class Ritch : SuperHero
    {
        public Ritch()
        {
            hp = Klasser.RandInt(50, 60);
            ability = raceAbilityDataBase[0];
        }

        public override void TakeDamage(int damage, string Race)
        {
            int extraDamage = 0;
            if (race == raceDataBase[0])
            {
                extraDamage = 10;
            }
            Hp -= damage + extraDamage;
        }
    }
}
