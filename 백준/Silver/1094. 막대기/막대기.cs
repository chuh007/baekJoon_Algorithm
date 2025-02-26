using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            List<int> stick = new List<int>();
            stick.Add(64);
            int sum = 64;
            while (sum > a)
            {
                stick.Sort();
                if (sum - stick[0] >= a)
                {
                    sum -= stick[0];
                    stick.RemoveAt(0);
                }
                else
                {
                    int temp = stick[0];
                    stick.RemoveAt(0);
                    stick.Add(temp / 2);
                    stick.Add(temp / 2);
                }
            }
            sw.Write(stick.Count);
            sw.Flush();