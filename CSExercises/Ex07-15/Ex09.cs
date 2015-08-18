using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            string salary;
            double housing;    
            double jay;
         

            Console.Write("Type in the value of x: ");
            salary = Console.ReadLine();
            jay = Convert.ToDouble(salary);
            housing = (2 * (jay * jay)) - (4 * jay) + 3;
            Console.Write("The value of Y is : " + housing);
            Console.ReadKey();


        }
    }
}
