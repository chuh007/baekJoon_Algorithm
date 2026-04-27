using System;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            string s = sR.ReadLine();
            int[] a = new int[s.Length];
            int i = 0;
            foreach(char item in s)
            {
                a[i] = Convert.ToInt32(item-48);
                i++;
            }
            var nums = from num in a
                       orderby num descending
                       select num;
            foreach(int n in nums)
            {
                sW.Write(n);
            }
            sW.Flush();