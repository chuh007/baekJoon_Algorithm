using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                float a = float.Parse(sr.ReadLine());
                if (a == -1) break;
                sw.WriteLine($"Objects weighing {a:F2} on Earth will weigh {a * 0.167:F2} on the moon.");
            }
            sw.Flush();