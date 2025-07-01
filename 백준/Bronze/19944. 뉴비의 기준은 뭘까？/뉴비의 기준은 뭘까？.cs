using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (input[1] < 3) sw.Write("NEWBIE!");
            else if (input[1] <= input[0]) sw.Write("OLDBIE!");
            else sw.Write("TLE!");
            sw.Flush();