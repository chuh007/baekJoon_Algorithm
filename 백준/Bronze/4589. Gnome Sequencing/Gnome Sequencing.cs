using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            sw.WriteLine("Gnomes:");
            for(int i = 0;i < a; i++)
            {
                int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (arr[0] <= arr[1] && arr[1] <= arr[2]) sw.WriteLine("Ordered");
                else if (arr[0] > arr[1] && arr[1] >= arr[2]) sw.WriteLine("Ordered");
                else sw.WriteLine("Unordered");
            }
            sw.Flush();