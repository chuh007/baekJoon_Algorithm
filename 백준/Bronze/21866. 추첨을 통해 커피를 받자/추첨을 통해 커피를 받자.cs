using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            bool hacker = false;
            for(int i = 0;i<9;i++)
            {
                if (i / 2 * 100 + 100 < input[i]) hacker = true;
            }
            if (hacker) sw.Write("hacker");
            else if (input.Sum() >= 100) sw.Write("draw");
            else sw.Write("none");
            sw.Flush();