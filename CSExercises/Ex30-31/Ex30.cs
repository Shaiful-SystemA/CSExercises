using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {

            string strResult;
            int i, j;

            for (i = 5; i <= 10000; i++)
            {
                strResult = "Prime";
                j = 2;
             
                while ((strResult == "Prime") && (j <= (i / 2)))
                {
                   

                    if ((i % j) == 0)
                    {
                        strResult = "Not Prime";  
                    }
                    j++;
                }
                
                if (strResult == "Prime")
                    Console.WriteLine(i);
            }

            Console.ReadKey();


        }
    }
}



