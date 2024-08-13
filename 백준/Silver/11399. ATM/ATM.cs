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
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            Array.Sort(input);
            int answer = 0;
            int plusTime = 0;
            foreach(int item in input)
            {
                plusTime += item;
                answer += plusTime;
            }
            sw.Write(answer);
            sw.Flush();