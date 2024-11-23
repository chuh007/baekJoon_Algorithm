using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int count0 = 0;
            int count1 = 0;
            foreach (int item in input)
            {
                if (item % 2 == 0) count0++;
                else count1++;
            }
            sw.Write(count0 > count1 ? "Happy" : "Sad");
            sw.Flush();