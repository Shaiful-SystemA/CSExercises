using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("-------------------------------------------------------");
            for (double No = 1, inv, sqrt, sq; No <= 10; No++)
            {
                inv = 1 / No;
                sqrt = Math.Sqrt(No);
                sq = No * No;
                Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}", No, inv, sqrt, sq);

            }

            Console.ReadKey();
        }
    }
}
