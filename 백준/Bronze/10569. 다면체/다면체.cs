using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine(input[1] - input[0] + 2);
            }
            sw.Flush();