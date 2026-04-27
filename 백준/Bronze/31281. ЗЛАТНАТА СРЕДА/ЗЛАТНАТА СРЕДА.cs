using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
long[] input = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);
            Array.Sort(input);
            sw.Write(input[1]);
            sw.Flush();