using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            string salary;
            double Total;
            double jay;
            string dollar;
            Console.Write("Enter your salary: ");
            salary = Console.ReadLine();
            jay = Convert.ToDouble(salary);
            Total = ((0.1*jay) + (0.03*jay) + jay);
            dollar = Total.ToString("C");
            Console.Write("Your total in come is : "  + dollar +Total);
            Console.ReadKey();

        }
    }
}
