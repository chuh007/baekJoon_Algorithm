using System;
using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] arr = new int[10001];
            for(int i = 0; i < a; i++)
            {
                arr[int.Parse(sr.ReadLine())]++;
            }
            for(int i = 0; i <= 10000; i++)
            {
                if (arr[i] != 0)
                {
                    for(int j = 0; j < arr[i]; j++)
                    {
                        sw.Write(i+"\n");
                    }
                }
            }
            sw.Flush();