using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Random random = new Random();
            double g = random.NextDouble()*(n - 1) + 1;

            while (Math.Abs(g*g - n) > 0.00001)
            {
                g = (g + n/g)/2;
            }

            Console.WriteLine(g);
        }
    }
}
