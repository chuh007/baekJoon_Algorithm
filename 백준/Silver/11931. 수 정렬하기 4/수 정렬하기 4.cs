using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            int[] arr = new int[a];
            for(int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            arr = arr.OrderByDescending(x => x).ToArray();
            foreach(int n in arr)
            {
                sb.AppendLine(n.ToString());
            }
            sw.WriteLine(sb);
            sw.Flush();