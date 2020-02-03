using System;
using System.Collections.Generic;
using System.Text;


class Klasser
{
    private static Random randGen = new Random(); // Slump generatorn

    public static int IsInt(string intake)
    {
        intake = intake.Trim();
        int amount;
        bool isInt = int.TryParse(intake, out amount);

        while (isInt == false)
        {
            WriteLine("Write a number!", false);
            Console.ReadLine().Trim();
            isInt = int.TryParse(intake, out amount);
        }

        return amount;
    }

    public static void WriteLine(string text, bool ignoreReadLine)
    {
        Console.WriteLine(text);

        if (ignoreReadLine == true)
        {
            Console.ReadLine();
        }
    } //Skriver ut en string


    public static void Write(string text, bool ignoreReadLine)
    {
        Console.Write(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Skriver ut med "Console.Write();" och denna metod ger chansen att ignorera "ReadLine"


    public static int RandInt(int num1, int num2)
    {
        int retVal; // retVal = return value

        retVal = randGen.Next(num1, num2 + 1);

        return retVal;
    }//Slumpar mellan två ints


    public static string RandString(string[] total)
    {
        int retVal; //retVal = return value

        retVal = randGen.Next(0, total.Length);

        return total[retVal];
    } //Slumpar en string från en string array

    public static void IsTrueString(string[] correct, string choice, string felMedelande)
    {
        bool x = true;
        while (x.Equals(true)) //Går tills spelaren skrivit rätt
        {
            for (int i = 0; i < correct.Length; i++) //Kollar igenom alla rätta svar
            {
                if (choice.ToLower().Trim() == correct[i]) //Kollar igenom om spealrens svar passar med en av 
                {
                    x = false;
                    break;
                }
            }
            if (x == true) //Spelaren har skrivit ett falskt svar
            {
                Console.WriteLine(felMedelande);

                choice = Console.ReadLine();
            }
        }
    } //Failsaif, kollar om det spelaren svarat med är ett av de rätta alternativen
}

