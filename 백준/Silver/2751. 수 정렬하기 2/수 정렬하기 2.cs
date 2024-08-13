using System;
using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] arr = new int[a];
            for(int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            Array.Sort(arr);
            for(int i = 0; i < a; i++)
            {
                sw.Write(arr[i]+"\n");
            }
            sw.Flush();