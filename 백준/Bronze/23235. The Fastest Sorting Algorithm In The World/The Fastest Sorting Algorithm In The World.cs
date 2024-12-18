using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));    
int count = 1;
            while (true)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (input.Length == 1 && input[0] == 0) break;
                sw.WriteLine($"Case {count++}: Sorting... done!");
            }
            sw.Flush();