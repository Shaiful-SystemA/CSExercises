using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(" Enter a word ");

            string strInput = Console.ReadLine();
            string strLowered = strInput.ToLower();
            int jay, j, intVowelCount = 0;
            char[] chrArrVowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int[] CountEachVowel = new int[] { 0, 0, 0, 0, 0 };

            for (jay = 0; jay < strLowered.Length; jay++)
            {
                for (j = 0; j < chrArrVowel.Length; j++)
                {
                    if (strLowered[jay] == chrArrVowel[j])
                    {
                        intVowelCount++;
                        CountEachVowel[j]++;
                    }
                }
            }

          
                for (int i = 0; i < chrArrVowel.Length; i++)
                {
                    Console.WriteLine("Number of {0}: {1}", chrArrVowel[i], CountEachVowel[i]);

                }

            Console.ReadKey();
            
        }
    }
}
