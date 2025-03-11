
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine($"Case #{i+1}: {arr.Max()}");
            }
            sw.Flush();