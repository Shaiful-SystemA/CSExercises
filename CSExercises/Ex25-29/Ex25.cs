using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int intNumber = Convert.ToInt32(Console.ReadLine());
            int intFactorial = 1;

     
            if (intNumber == 0)
            {
                intFactorial = 0;
            }
            else
            {
                for (int j = intNumber; j > 0; j=j-1)
                {
                    intFactorial = intFactorial * j;
                }
            }

            //  Console.WriteLine("The factorial for {0} is {1}", intNumber, intFactorial);
            Console.WriteLine(intFactorial);
            Console.ReadKey();
        }
    }
}


/*
     // Code using increment counter
     if(intNumber == 0)
     {
         intFactorial = 0;
     }
     else
     {
         for (int i = 1; i <= intNumber; i++)
         {
             intFactorial = intFactorial * i;
         }
     }
     */

// Code using decrement counter