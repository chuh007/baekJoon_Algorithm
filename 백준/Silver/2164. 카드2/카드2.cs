using System.Collections;
using System.Text;
using System.IO;

StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            Queue intQ = new Queue();
            int a = int.Parse(sR.ReadLine());
            for (int i = 1; i < a+1; i++)
            {
                intQ.Enqueue(i);
            }
            while (intQ.Count != 1)
            {
                intQ.Dequeue();
                object v = intQ.Dequeue();
                intQ.Enqueue(v);
            }
            sW.WriteLine(intQ.Dequeue());
            sW.Flush();