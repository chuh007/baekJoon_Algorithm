using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            a = 0;
            int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            foreach(int i in input)
            {
                if (i == 1) a++;
                else if (i == -1) a--;
            }
            if (a > 0) sw.Write("Right");
            else if (a < 0) sw.Write("Left");
            else sw.Write("Stay");
            sw.Flush();