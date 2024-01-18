/*Write a .NET console application using C# that simulates the rolling of two 6-sided dice. Use an
Array to keep track of the number of times that each combination is thrown. In other words,
keep track of how many times the combination of the two simulated dice is 2, how many times
the combination is 3, and so on, all the way up through 12.*/

/*Allow the user to choose how many times the “dice” will be thrown. Then, once you have the
number of rolls, pass that number to a second class that has a method that simulates the roll of
the dice for the number of times that the user specified. That method in the second class should
return the array containing the results. In the first class, use that array to print a histogram (using
the * character) that shows the total percentage each number was rolled. Each * will represent
1% of the total rolls.*/

using DiceRollMission2;
internal class Program
{
    private static void Main(string[] args)
    {
        DiceActions da = new DiceActions();
        int diceCount = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        diceCount = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        int[] rollTotal = da.RollDice(diceCount);

        for (int i = 2; i < rollTotal.Length; i++)
        {
            int percentage = ((rollTotal[i] * 100) / diceCount);

            // to print histogram as * 

            string output = new string('*', percentage);
            Console.WriteLine($"{i}: {output}");                // similar to f'
        }



    }
}
