using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex16
    {
    


        public static void Main(string[] args)
        {
      
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender F for female and M for Male");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M')           
                Console.WriteLine("Good Morning Mr " + name);         
            else if (gender == 'F')           
                Console.WriteLine("Good Morning Mrs " + name);           
            else           
                Console.WriteLine("Invalid input " + gender);         
            Console.ReadKey();

        }

    }
}