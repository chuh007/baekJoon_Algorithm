using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long a = long.Parse(sr.ReadLine());
            double sqrta = Math.Sqrt(a);
            if ((long)sqrta * (long)sqrta == a) sw.Write((long)sqrta);
            else
            {
                if (((long)sqrta) * ((long)sqrta) > a) sw.Write((long)sqrta);
                else sw.Write((long)sqrta + 1);
            }
            sw.Flush();