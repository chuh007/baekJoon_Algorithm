using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asasdadaatfgse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(Fack(input[0]) / (Fack(input[1]) * (Fack(input[0] - input[1]))));
        }
        private static int Fack(int n)
        {
            int answer = 1;
            for (int i = n; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
        }
    }
}