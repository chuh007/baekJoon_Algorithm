            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int M = a[1];
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int max = 0;
            for (int i = 0; i < a[0]; i++)
            {
                for(int j = i + 1; j < a[0]; j++)
                {
                    for(int k = j + 1; k < a[0]; k++)
                    {
                        int now = input[i] + input[j] + input[k];
                        if (max < now && now <= M) max = now;
                    }
                }
            }
            sw.Write(max);
            sw.Flush();