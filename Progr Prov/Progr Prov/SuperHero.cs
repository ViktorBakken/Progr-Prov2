using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_Prov
{

    class SuperHero
    {
        protected string[] raceDataBase = { "mutant", "alien", "ritch" };
        protected string[] charactDataBase = { "stronger", "strong", "weak defense" };
        protected string[] raceAbilityDataBase = { "Strong against ritch", "strong against mutant", "Strong against alien" };
        protected Dictionary<string, int> charactDataBaseDictionary = new Dictionary<string, int>();

        protected string name;
        protected string race;
        protected string ability;
        protected string charact;
        protected int hp;

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp -= value;

                hp = (int)MathF.Max(hp, 0);
            }


        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }
        public string Race
        {
            get
            {
                return race;
            }

            set
            {
                Klasser.IsTrueString(raceDataBase, value, "You misspelled or wrote an non existing race");

                race = value;

            }
        }

        public SuperHero()
        {
            charact = Klasser.RandString(charactDataBase);
        }

        public virtual void TakeDamage(int damage, string Race)
        {

        }
        public int DealDamage()
        {
            return Klasser.RandInt(1, 6) * charactDataBaseDictionary[charact];
        }
    }
}
