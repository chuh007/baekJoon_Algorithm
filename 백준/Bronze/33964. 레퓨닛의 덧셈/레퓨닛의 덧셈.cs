using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = 1, b = 1;
            for(int i = 1; i < input[0]; ++i)
            {
                a *= 10;
                a++;
            }
            for (int i = 1; i < input[1]; ++i)
            {
                b *= 10;
                b++;
            }
            sw.Write(a + b);
            sw.Flush();