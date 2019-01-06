using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("enter a month number:");
            int mno = Convert.ToInt16(Console.ReadLine());
            switch (mno)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("winter season");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("spring season");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("summer season");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("autmn season");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    Console.Write("write Start to start again:");
                    string s = Console.ReadLine().ToUpper();
                    Console.Clear();
                    goto start;
            }
            Console.ReadKey();
        }
    }
}
