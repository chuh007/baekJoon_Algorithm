using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 1;
            for (int i = 1; i < a; i++)
            {
                int max = 1;
                for(int j = 0; j < i; j++)
                {
                    if(input[j] < input[i])
                    {
                        max = max > dict[j] ? max : dict[j] + 1;
                    }
                }
                dict[i] = max;
            }
            sw.Write(dict.Values.Max());
            sw.Flush();