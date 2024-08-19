using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            string[] a = sR.ReadLine().Split(' ');
            int l = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == "")
                {
                    l--;
                }
            }
            sW.WriteLine(l);
            sW.Flush();