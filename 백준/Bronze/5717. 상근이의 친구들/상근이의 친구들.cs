using System;
            using System.Linq;
            using System.Threading.Tasks;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
while (true)
            {
                int[] n = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                if (n[0] == 0 && n[0] == 0) break;
                sb.AppendLine((n[0] + n[1]).ToString());
            }
            sw.Write(sb);
            sw.Flush();