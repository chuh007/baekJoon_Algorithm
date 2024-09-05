using System.Linq;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int n = int.Parse(sr.ReadLine());
            while (true)
            {
                int a = int.Parse(sr.ReadLine());
                if (a == 0) break;
                if (a % n == 0) sw.WriteLine($"{a} is a multiple of {n}.");
                else sw.WriteLine($"{a} is NOT a multiple of {n}.");
            }
            sw.Flush();