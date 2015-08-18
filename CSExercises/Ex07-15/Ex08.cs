using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            string salary;
            double housing;
            double jay;

            Console.Write("Enter temperature in Centigrade: ");
            salary = Console.ReadLine();
            jay = Convert.ToDouble(salary);
            housing = (1.8 * jay) + 32;
            Console.Write("Temperature in Fahrenheit is : " + "F" + housing);
            Console.ReadKey();

        }
    }
}
