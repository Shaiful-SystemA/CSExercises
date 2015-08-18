using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender F for female and M for Male");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            string controller = "undefined";

            if (gender == 'M')
            {
                if (age >= 40)
                    controller = "Uncle";
                else if (age <40)
                    controller = "Mr.";


            }

            else if (gender == 'F')
            {
                if (age >=40)
                    controller = "Aunty";
                else if (age<40)
                    controller = "Ms.";

            }

            if(controller =="undefined")
                Console.WriteLine("Invalid gender {0} or age {1} ", gender, age );
            else
                Console.WriteLine("Good Morning {0} {1}",controller, name );
            Console.ReadKey();



        }
    }
}