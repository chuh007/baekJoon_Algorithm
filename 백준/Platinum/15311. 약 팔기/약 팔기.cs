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
            sw.WriteLine(2000);
            for(int i = 0; i < 1000; i++)
            {
                sw.Write(1 + " ");
            }
            for (int i = 0; i < 1000; i++)
            {
                sw.Write(1000 + " ");
            }
            sw.Flush();