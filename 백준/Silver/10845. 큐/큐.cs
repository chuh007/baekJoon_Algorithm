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
            Queue<int> intq = new Queue<int>();
            for(int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                switch (s[1])
                {
                    case 'u':
                        int n = int.Parse(s.Split(' ')[1]);
                        intq.Enqueue(n);
                        break;
                    case 'o':
                        if (intq.Count == 0) Console.WriteLine("-1");
                        else Console.WriteLine(intq.Dequeue().ToString());
                        break;
                    case 'i':
                        Console.WriteLine(intq.Count.ToString());
                        break;
                    case 'm':
                        Console.WriteLine(intq.Count!=0?"0":"1");
                        break;
                    case 'r':
                        if (intq.Count == 0) Console.WriteLine("-1");
                        else Console.WriteLine(intq.Peek().ToString());
                        break;
                    case 'a':
                        if (intq.Count == 0) Console.WriteLine("-1");
                        else Console.WriteLine(intq.ElementAt(intq.Count-1).ToString());
                        break;
                }
            }