using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                long[] arr = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
                if (arr[0] * arr[1] > arr[2] * arr[3]) sw.WriteLine("TelecomParisTech");
                else if (arr[0] * arr[1] < arr[2] * arr[3]) sw.WriteLine("Eurecom");
                else sw.WriteLine("Tie");
            }
            sw.Flush();