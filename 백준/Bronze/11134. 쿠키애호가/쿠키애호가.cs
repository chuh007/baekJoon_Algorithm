using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (input[0] % input[1] == 0) sw.WriteLine(input[0] / input[1]);
                else sw.WriteLine(input[0] / input[1] + 1);
            }
            sw.Flush();