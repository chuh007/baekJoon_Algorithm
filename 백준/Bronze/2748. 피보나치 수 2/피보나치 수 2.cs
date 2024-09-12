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
long fn = 0;
            long fn1 = 1;
            long fn2 = 0;
            int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                fn = fn1 + fn2;
                fn2 = fn1;
                fn1 = fn;
            }
            sw.Write(fn2);
            sw.Flush();