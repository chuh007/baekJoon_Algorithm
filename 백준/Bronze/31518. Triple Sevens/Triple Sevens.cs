using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            bool isSafe = false;
            for (int i = 0; i < 3; i++)
            {
                isSafe = false;
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                foreach(int item in input)
                {
                    if (item == 7) isSafe = true;
                }
                if (!isSafe) break;
            }
            if (isSafe) sw.Write(777);
            else sw.Write(0);
            sw.Flush();