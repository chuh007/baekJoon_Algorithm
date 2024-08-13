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
Queue intQ = new Queue();
            int a = int.Parse(sr.ReadLine());
            for (int i = 1; i < a + 1; i++)
            {
                intQ.Enqueue(i);
            }
            for (int i = 0; i < a + 1; i++)
            {
                if (intQ.Count == 1) break;
                sb.Append(intQ.Dequeue() + " ");
                intQ.Enqueue(intQ.Dequeue());

            }
            sb.AppendLine(intQ.Dequeue().ToString());
            sw.Write(sb);
            sw.Flush();