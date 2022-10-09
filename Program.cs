using System;
using System.IO;

class Program {
   public static void Main() {

        Random rnd = new Random();
        int randomNumber = rnd.Next(1,11);

        string pointFile = "pointFile.txt";
        int currentPoints = Convert.ToInt32(File.ReadAllText(pointFile));


        Console.WriteLine("Guess the number 1-10");
        var theUser = Convert.ToInt32(Console.ReadLine());

        if (theUser != randomNumber)
        {
            Console.WriteLine("You guessed wrong. It was: " + randomNumber);
            Main();
        }
        else
        {
            Console.WriteLine("You guessed right! It was: " + randomNumber);
            currentPoints++;
            File.WriteAllText(pointFile,Convert.ToString(currentPoints));
            Console.WriteLine("Current points: "+currentPoints);

        }
    }
}





