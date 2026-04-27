using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            if (input[0] >= 1000)
            {
                if (input[1] >= 8000 || input[2] >= 260)
                {
                    sw.WriteLine("Very Good");
                }
                else
                {
                    sw.WriteLine("Good");
                }
            }
            else
            {
                sw.WriteLine("Bad");
            }
sw.Flush();