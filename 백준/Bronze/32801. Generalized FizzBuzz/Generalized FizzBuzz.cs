using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = 0, b = 0, c = 0;
            for(int i = 1; i <= arr[0]; i++)
            {
                if (i % arr[1] == 0 && i % arr[2] == 0) c++;
                else if (i % arr[1] == 0) a++;
                else if (i % arr[2] == 0) b++;
            }
            sw.Write($"{a} {b} {c}");
            sw.Flush();