using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            int[] arr = input.Distinct().ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                dict[arr[i]] = i;
            }
            for(int i = 0; i < input.Length; i++)
            {
                sw.Write(dict[input[i]] + " ");
            }
            sw.Flush();