using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int tv1 = 900, dvd1 = 500, mp31 = 700;
            Console.Write("Enter quantity for TV: ");
            int tv = int.Parse(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            int dvd = int.Parse(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            int mp3 = int.Parse(Console.ReadLine());
            int priceTV, priceDVD, priceMP3;
            double price;

            priceTV = (tv1 * tv);
            priceDVD = (dvd * dvd1);
            priceMP3 = (mp3 * mp31);
            price = priceTV + priceDVD;
            if (price > 10000)
            {
                price = price - (price * 0.15);
                price = price + priceMP3;
            }
            else if (price > 5000)
            {
                price = price - (price * 0.1);
                price = price + priceMP3;
            }
            else
            {
                price = price + priceMP3;
            }
            Console.WriteLine("Total price for this order is ${0}", price);
            Console.ReadKey();

        }
    }
}