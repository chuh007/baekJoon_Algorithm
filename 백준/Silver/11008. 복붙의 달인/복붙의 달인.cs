using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int cnt = 0;
                string[] input = sr.ReadLine().Split();
                while(input[0].Contains(input[1]))
                {
                    input[0] = input[0].Remove(input[0].IndexOf(input[1]), input[1].Length);
                    cnt++;
                }
                sw.WriteLine(cnt + input[0].Length);
            }
            sw.Flush();