using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int answer = 0, nownum = 0;
            for(int i = 0; i < 4; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                nownum += input[1] - input[0];
                answer = answer > nownum ? answer : nownum;
            }
            sw.Write(answer);
            sw.Flush();