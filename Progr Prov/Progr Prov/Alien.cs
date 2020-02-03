using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_Prov
{
    class Alien : SuperHero
    {
        public Alien()
        {
            hp = Klasser.RandInt(50, 60); //Randomises the health points
            ability = raceAbilityDataBase[1]; //Applies the race ability
            race = raceDataBase[1]; //Applies the race
        }

        public override void TakeDamage(int damage, string Race)
        {
            int extraDamage = 0; // Potential extra damage
            if (race == raceDataBase[2]) 
            {
                extraDamage = 10;
            } //If the enemy is of the race Ritch
            hp -= damage + extraDamage; //Now the character takes damage
            hp = (int)MathF.Max(hp, 0); //Just makes sure the hp always will be 0 or higher
        } //The method used when the character takes damage

    }
}
