using System;
using System.Collections.Generic;
using System.Text;

namespace Progr_Prov
{

    class SuperHero
    {
        //This is the database for the various races, character ability, race abilitys and character ability string to int converter
        protected string[] raceDataBase = { "mutant", "alien", "ritch" };
        protected string[] charactDataBase = { "stronger", "strong", "weak defense" };
        protected string[] raceAbilityDataBase = { "Strong against ritch", "strong against mutant", "Strong against alien" };
        protected Dictionary<string, int> charactDataBaseDictionary = new Dictionary<string, int>();

        private string name; //The characters name
        private string charact; //The characters "ability"
        protected string race; //The characters race
        protected string ability; //The characters race ability
        protected int hp; //The charactrers health points
        public int Hp
        {
            get
            {
                return hp;
            }
        }  //A construktor to capsule the "true" hp value
        public string Name
        {
            get
            {
                return name;
            }
        } // Using a construktor instead of creating a method to get the value

        public void NameCharacter()
        {
            Console.WriteLine("Name your character");
            string newName = Console.ReadLine();

            name = newName;
        } //Using a method that can be called that containt all thats necesary to change the characters name
        public virtual void TakeDamage(int damage, string Race)
        {

        } //Every TakeDamage method will be special for each subclass because different races are weak and strong towards other races
        public void DealDamage(SuperHero enemy)
        {
            int attack = Klasser.RandInt(1, 6) * charactDataBaseDictionary[charact];

            enemy.TakeDamage(attack, race);
        } //A method to deal damage to enemies
        public void PrintStats()
        {
            Klasser.WriteLine("Name: " + name + "\nHp: " + hp +"\nRace: " + race + "\nRace Ability: " + ability + "\nAbility: " + charact, false);
        } //A method that prints the characters stats
    }
}
