using System.Numerics;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int t = int.Parse(sr.ReadLine());
            BigInteger[] FackArr = new BigInteger[30];
            for(int i = 0; i < t; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine(Fack(input[1]) / Fack(input[1] - input[0]) / Fack(input[0]));
            }
            sw.Flush();
            BigInteger Fack(int num)
            {
                if (num <= 1) return 1;
                if (FackArr[num] != 0) return FackArr[num];
                FackArr[num] = Fack(num - 1) * num;
                return FackArr[num];
            }