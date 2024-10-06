using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = new int[1000];
            int count = 1;
            int nowcount = 0;
            for(int i = 0; i < 1000; i++)
            {
                if (nowcount < count)
                {
                    arr[i] = count;
                    nowcount++;
                }
                else
                {
                    count++;
                    arr[i] = count;
                    nowcount = 1;
                }
            }
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int answer = 0;
            for(int i = input[0]-1; i <= input[1]-1; i++)
            {
                answer += arr[i];
            }
            sw.Write(answer);
            sw.Flush();