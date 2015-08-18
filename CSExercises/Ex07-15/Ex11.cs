using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double FromX1,fare;    

            Console.Write("Enter distance travel: ");
            FromX1 = Convert.ToDouble(Console.ReadLine());

            fare = 2.40 + (0.4 * FromX1);    
            Console.Write("Your total fare is  : " + Math.Round(fare, 1));
            Console.ReadKey();


        }
    }
}
