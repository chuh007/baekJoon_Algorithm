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
            for(int i = 0; i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine(input[0] + input[1]);
            }
            sw.Flush();