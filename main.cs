using System;

public class Jogo {
    public static void Main(){ 
        // Shows a message to user
        Console.Out.WriteLine("Input a number, please");

        // Reads the input and converts it to number
        int number = int.Parse(Console.In.ReadLine());

        // Iterate through every number between 1 and 100
        for(int i = 1; i <= 100; i++) {

            // Checks if "i" is divisible by the number hte user
            // had input
            if(i % number == 0) {
                Console.Out.WriteLine(i + " is divisible by " + number);
            }
        }
    }
}