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
            int time = 0;
            int Fly_My_Wing = 1;
            while (n > 0)
            {
                n -= Fly_My_Wing;
                time++;
                Fly_My_Wing++;
                if (n < Fly_My_Wing) Fly_My_Wing = 1;
            }
            sw.WriteLine(time);
            sw.Flush();