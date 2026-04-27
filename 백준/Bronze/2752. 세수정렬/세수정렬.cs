using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            Array.Sort(input);
            foreach(int i in input)
            {
                sw.Write($"{i} ");
            }
            sw.Flush();