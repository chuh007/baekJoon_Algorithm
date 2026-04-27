using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            while (true)
            {
                int[] a = Array.ConvertAll(sR.ReadLine().Split(' '),int.Parse);
                if (a[0] == 0 && a[1] == 0) break;
                if (a[0] > a[1])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }