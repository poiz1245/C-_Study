using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 80, 70, 60, 90, 100 };
            int sum = CalculateSum(scores); //int타입의 배열 전달

            Console.WriteLine(sum);   
        }

        static int CalculateSum(int[] scoresArray) //int타입의 배열을 매개로 받음
        {
            int sum = 0;
            for(int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }

            return sum;
        }
    }
}
