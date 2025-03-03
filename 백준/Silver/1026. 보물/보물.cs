using System.Linq;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] inputA = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] inputB = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(inputA);
            inputB = inputB.OrderByDescending((n) => n).ToArray();
            int s = 0;
            for(int i = 0; i < a; i++)
            {
                s += inputA[i] * inputB[i];
            }
            sw.WriteLine(s);
            sw.Flush();