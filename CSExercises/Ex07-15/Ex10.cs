using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            string x1,x2,y1,y2;
            double FromX1,FromX2,FromY1,FromY2,distance;
          

            Console.Write("Type in the value of x1: ");
            x1 = Console.ReadLine();
            FromX1 = Convert.ToDouble(x1);
            Console.Write("Type in the value of x2: ");
            x2 = Console.ReadLine();
            FromX2 = Convert.ToDouble(x2);
            Console.Write("Type in the value of y1: ");
            y1 = Console.ReadLine();
            FromY1 = Convert.ToDouble(y1);
            Console.Write("Type in the value of y2: ");
            y2 = Console.ReadLine();
            FromY2 = Convert.ToDouble(y2);

            distance = Math.Sqrt((Math.Pow((FromX2 - FromX1), 2)) + (Math.Pow((FromY2 - FromY1), 2)));
            Console.Write("Distance between two points is : " + distance);
            Console.ReadKey();


        }
    }
}
