using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            bool s = true;
            foreach (int item in input)
            {
                if (item == 9) s = false;
            }
            sw.Write(s ? "S" : "F");
            sw.Flush();