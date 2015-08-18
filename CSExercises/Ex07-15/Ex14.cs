using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            string x1,x2,y1;
            double FromX1, FromX2, FromY1,Area,s,a,b,c;
          

            Console.Write("Enter side a : ");
            x1 = Console.ReadLine();
            FromX1 = Convert.ToDouble(x1);

            Console.Write("Enter side b: ");
            x2 = Console.ReadLine();
            FromX2 = Convert.ToDouble(x2);

            Console.Write("Enter side c: ");
            y1 = Console.ReadLine();
            FromY1 = Convert.ToDouble(y1);

            a = FromX1 + FromX2;
            b = FromX1 + FromY1;
            c = FromX2 + FromY1;

            //Area = Math.Sqrt();
            if ((FromX1 > 0) && (FromX2 > 0) && (FromY1 > 0))
            {
                if ((a > FromY1) && (b > FromX2) && (c > FromX1))
                {
                    s = (FromX1 + FromX2 + FromY1) * (0.5);
                    Area = Math.Sqrt((s * (s - FromX1) * (s - FromX2) * (s - FromY1)));
                    //Area = Math.Sqrt(s);
                    Console.WriteLine("Areas of traingle is  : " + Math.Round(Area, 3));
                }

                else
                {
                    Console.WriteLine("Your input is not a triangle : ");
                }

            }

            else
            {
                Console.WriteLine("Your input value is invalid  ");

            }

            Console.ReadKey();

        }
    }
}