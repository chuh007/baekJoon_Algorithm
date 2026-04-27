using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int[] a = Array.ConvertAll(sR.ReadLine().Split(' '),int.Parse);
            if (a[0] * 100 < a[1])
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }