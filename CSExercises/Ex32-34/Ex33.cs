using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {

            int[] num = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for (int Jay = 0; Jay < num.Length - 1; Jay++)
            {
                for (int red = Jay + 1; red < num.Length; red++)
                {
                    if (num[red] > num[Jay])
                    {
                        int temp = num[red];            // swap from left to right
                        num[red] = num[Jay];
                        num[Jay] = temp;
                    }
                }
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write("{0} ", num[i]);  // print from each pass
                }

                Console.WriteLine(" ");
            }


            Console.ReadKey();



        }
    }


}
