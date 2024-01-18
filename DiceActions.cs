using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollMission2
{
    internal class DiceActions
    {
        public int[] RollDice(int rollCount) 
        {
            int[] rollTotal = new int[13];      // defaults to start with zero

            for (int i = 0; i < rollCount; i++) 
            {
                // roll dice - random number
               
                Random rnd = new Random();

                int dice1Roll = rnd.Next(1,7);
                int dice2Roll = rnd.Next(1,7);
                int diceTotal = dice1Roll + dice2Roll;

                // increment count in array for every value rolled
                rollTotal[diceTotal]++;           
            }

            // return array
            return rollTotal;


        }
    }
}


// for every spot in the array (2-12)
// calculate the percentage of times that number was rolled
// print number of percentage
// for the number of percentage calcuated
// print one *


// int num1 = 13
