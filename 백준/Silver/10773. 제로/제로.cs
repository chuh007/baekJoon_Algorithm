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
            Stack<int> stack = new Stack<int>();
            int a = Convert.ToInt32(sR.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int input = Convert.ToInt32(sR.ReadLine());
                if (input == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(input);
                }
            }
            int answer = 0;
            foreach(int item in stack)
            {
                answer += item;
            }
            sW.WriteLine(answer);
            sW.Flush();