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
string s = sr.ReadLine();
            int c = s.Length % 3;
            if (c != 0)
            {
                s = "0" + s;
            }
            c = s.Length % 3;
            if (c != 0)
            {
                s = "0" + s;
            }
            for(int i = 0; i < s.Length; i += 3)
            {
                sw.Write((s[i]-'0')*4+(s[i+1]-'0')*2+(s[i+2])-'0');
            }
            sw.Flush();