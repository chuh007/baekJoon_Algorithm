using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = input[0];
            int next = input[0] % input[1];
            for(int i = 1; i < input[2]; i++)
            {
                next = next * 10 % input[1];
            }
            int answer = next * 10 / input[1];
            sw.WriteLine(answer);
            sw.Flush();