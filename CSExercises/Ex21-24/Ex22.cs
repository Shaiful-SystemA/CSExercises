using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int big = Math.Max(a, b);
            int small = Math.Min(a, b);

            while (big != small)
            {
                big = big - small;

                if (big < small)
                {
                    var temp = big;
                    small = big;
                    big = temp;
                }
            }

            int hcf = big;
            int lcm = (a*b)/hcf;

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
        }
    }
}
