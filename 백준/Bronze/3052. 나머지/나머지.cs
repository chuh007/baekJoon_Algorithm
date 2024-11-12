using System;
            using System.Linq;
            using System.Threading.Tasks;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int[] answer = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(sr.ReadLine());
                answer[i] = a % 42;
            }
            answer = answer.Distinct().ToArray();
            sw.Write(answer.Length);
            sw.Flush();