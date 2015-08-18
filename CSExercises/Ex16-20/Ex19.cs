using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance travel in Km: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            distance = Math.Ceiling(distance * 10); // multiply by 10 for rounding up distance
            double fare = 0.0;

            if (distance < 0.0)
                Console.WriteLine("Invalid distance");
            else if (distance <= 5.0) // for distance travel less than 0.5 km
                Console.WriteLine("Your fare is $ {0}", 2.4);
            else if (distance <= 90.0) // for distance travel less than or equal to 9.0 km
            {
                fare = 2.4 + (distance - 5) * 0.04;
                Console.WriteLine("Your fare is $ {0}", fare);
            }
            else if (distance > 90.0) // distance above 9km, 3 conditions for charges
            {
                double X1 = distance;

                X1 = X1 - 5.0;
                fare = 2.4;

                X1 = X1 - 85.0;
                fare = fare + (85 * 0.04);

                fare = fare + (X1 * 0.05);

                Console.WriteLine("Your fare is $ {0}", fare);
            }

            Console.ReadKey();

        }
    }
}