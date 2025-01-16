using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            foreach (int i in input)
            {
                if (i < 250) sw.Write(4 + " ");
                else if (i < 275) sw.Write(3 + " ");
                else if (i < 300) sw.Write(2 + " ");
                else sw.Write(1 + " ");
            }
            sw.Flush();