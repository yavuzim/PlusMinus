using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            double positive = 0, negative = 0, zero = 0;
            for (int i = 0; i < arr.Count; i++)
            { // -4 , 3 , -9 , 0 , 4 , 1
                if (arr[i] > 0)
                {
                    positive++;
                }
                if (arr[i] == 0)
                {
                    zero++;
                }
                if (arr[i] < 0)
                {
                    negative++;
                }
            }
            double pRate = 1, nRate = 1, zRate = 1;
            pRate = positive / arr.Count;
            nRate = negative / arr.Count;
            zRate = zero / arr.Count;
            Console.WriteLine(pRate + "\n" + nRate + "\n" + zRate);
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
            Console.Read();
        }
    }
}
