using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int answer;
            if (input[0] < input[1])
                answer = input[1];
            else if (input[0] > input[2])
                answer = input[2];
            else
                answer = input[0];
            sw.WriteLine(answer);
            sw.Flush();