using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)  // or do while loop
        {


            Random ran = new Random();
            Console.WriteLine("Enter a integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = ran.Next(1, N + 1);
            double G = S;
            if (G * G == N) // correct guess
            {
                Console.WriteLine("The square root is :{0}", G);
            }
            else
            {
                do
                {
                    G = (G + (N / G)) / 2;
                }
                while (Math.Abs(N - G * G) > 0.00001);

                Console.WriteLine("The square root is:{0:0.00000}", G);
            }
            
            Console.ReadKey();
        }
    }
}


