using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = int.Parse(sr.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            int counter = 1000;
            foreach(int i in arr)
            {
                counter = Math.Abs(input[1] - i) < counter ? Math.Abs(input[1] - i) : counter;
            }
            sw.Write(counter < Math.Abs(input[0] - input[1]) ? counter + 1 : Math.Abs(input[0] - input[1]));
            sw.Flush();