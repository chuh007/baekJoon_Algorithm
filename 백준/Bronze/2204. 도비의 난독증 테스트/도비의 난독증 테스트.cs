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

List<string> sList = new List<string>();
            while(true)
            {
                int a = int.Parse(sr.ReadLine());
                if (a == 0) break;
                for(int i = 0; i < a; i++)
                {
                    sList.Add(sr.ReadLine());
                }
                sList.Sort((x, y) => x.ToUpper().CompareTo(y.ToUpper()));
                sw.WriteLine(sList[0]);
                sList.Clear();
            }
            sw.Flush();