using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter  an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime"); /// 2, 3,5,7 
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Prime");
            }

        }
    }
}


//

