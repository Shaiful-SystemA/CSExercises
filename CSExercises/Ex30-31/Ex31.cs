using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            for (int n = 1; n < 1000; n++)
            {
                int sum = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == n)
                {
                    Console.WriteLine(n);
                }
            }


        }
    }
}
