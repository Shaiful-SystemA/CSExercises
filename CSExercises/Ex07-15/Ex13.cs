using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double FromX1, fare;

            Console.Write("Enter distance travel: ");
            FromX1 = Convert.ToDouble(Console.ReadLine());

            fare = Math.Ceiling((2.40 + (0.4 * FromX1))*10);
            Console.Write("Your total fare is  : {0:0.00} ", fare/10);
            Console.ReadKey();
        }
    }
}
