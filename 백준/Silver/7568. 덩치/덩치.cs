using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
            int[,] arr = new int[N,2];
            for(int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split();
                arr[i, 0] = int.Parse(s[0]);
                arr[i, 1] = int.Parse(s[1]);
            }
            int count = 0;
            for(int i = 0; i < N; i++)
            {
                count = 1;
                for(int j = 0; j < N; j++)
                {
                    if (arr[i, 0] < arr[j, 0] && arr[i, 1] < arr[j, 1])
                    {
                        count++;
                    }
                }
                sw.Write(count+"\n");
            }
            sw.Flush();