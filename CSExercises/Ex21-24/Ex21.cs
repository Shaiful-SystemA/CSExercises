using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Enter an integer: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 88);
            Console.WriteLine("Lucky you...");
            
        }
    }
}
