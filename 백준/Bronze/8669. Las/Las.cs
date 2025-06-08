using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (!d.ContainsKey(input[1]) || d[input[1]] < input[0])
                {
                    d[input[1]] = input[0];
                }
            }

            sw.WriteLine(d.Count);
            sw.Flush();