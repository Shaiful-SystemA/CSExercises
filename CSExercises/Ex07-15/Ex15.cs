using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int num, first, second, third;
            System.Console.Write("Enter 3 digit number from 100 to 999:  ");
            num = int.Parse(System.Console.ReadLine());
            if (99 < num && num < 1000)
            {
                first = num / 100;
                second = (num % 100) / 10;
                third = num % 10;
                if (num == (first * first * first) + (second * second * second) + (third * third * third))
                {
                    System.Console.WriteLine("Armstrong number");
                }
                else
                    System.Console.WriteLine("Not an armstrong number");
            }
            else
                System.Console.Write("Not a valid number from 100 to 999 ");

            Console.ReadKey();

        }


        
    }
}