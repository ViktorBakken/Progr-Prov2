using System;

namespace Progr_Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero player = new SuperHero(); //Creates the player

            Console.WriteLine("Vad vad för ras vill du vara? (Jag är medveten att det låter fel)\nDu kan välja mellan Alien, Mutant eller Ritch!");
            player = ChooseRace(player); //Lets the player choose race

            player.NameCharacter(); //Lets the player name their character

            player.PrintStats(); //Prints the characters stats
        }

        static SuperHero ChooseRace(SuperHero player) 
        {
            string[] raceDataBase = { "mutant", "alien", "ritch" }; //The Race database 

            string Choice = Console.ReadLine(); //Players

            Klasser.IsTrueString(raceDataBase, Choice, "fel ras"); //Checks if the playes choice is one of the options

            if (Choice.Equals(raceDataBase[0])) //Player chose mutant
            {
                player = new Mutant();
            }
            else if (Choice.Equals(raceDataBase[1])) //Player chose Alien
            {
                player = new Alien();
            }
            else if (Choice.Equals(raceDataBase[2])) //Player chose Ritch
            {
                player = new Ritch();
            }
            return player;
        } //Lets the player choose race
    }
}
