/*Kimberly Hunter
 * Jan 17, 2024
 * Program rolls two dice, tracks their total in an array, and prints the array of totals as an * histogram
 */

using DiceRollMission2;
internal class Program
{
    private static void Main(string[] args)
    {
        DiceActions da = new DiceActions();                         // brings in an instance of the DiceAction class to use
      
        // ask user how many dice to roll
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int diceCount = int.Parse(Console.ReadLine());

        // adds a space for printing (just visual)
        Console.WriteLine("");      

        // call class, pass user input, and receive array in return
        int[] rollTotal = da.RollDice(diceCount);

        // loop to calculate % and print histogram
        for (int i = 2; i < rollTotal.Length; i++)                  // starts at two because we used 13 as array size in other class, it could be 0 if I used 11 in diceActions class and -2 
        {
            int percentage = ((rollTotal[i] * 100) / diceCount);    // have to * by 100 first to avoid having a decimal and needing to change datatype to double

            // to print histogram as * 
            string output = new string('*', percentage);
            Console.WriteLine($"{i}: {output}");                     // similar to f'
        }



    }
}
