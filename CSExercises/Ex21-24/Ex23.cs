using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int A, B, count;
            Random ran = new Random();
            A = ran.Next(0, 10);
            count = 0;
            do
            {
                Console.WriteLine("Enter a guess number (0-9): ");
                B = Convert.ToInt32(Console.ReadLine());
                count++;
            } while (A != B);
            if (count <= 2)
            {
                Console.WriteLine("You are a Wizard! Your attempt number is {0}", count);
            }
            else if (count <= 5)
            {
                Console.WriteLine("You are a good guess! Your attempt number is {0}", count);
            }
            else
            {
                Console.WriteLine("Your are lousy!Your attempt number is {0}", count);
            }

            Console.ReadLine();

        }
    }
}
