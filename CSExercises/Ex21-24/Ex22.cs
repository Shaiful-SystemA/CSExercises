using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter A: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int A = number1;
            int B = number2;
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else if (number2 > number1)
                {
                    number2 = number2 - number1;
                }
            }
            
            
            
            Console.WriteLine("HCF: {0}\nLCM: {1}", number1, (A * B) / number1);


            Console.ReadLine();



        }

        

    }
}
