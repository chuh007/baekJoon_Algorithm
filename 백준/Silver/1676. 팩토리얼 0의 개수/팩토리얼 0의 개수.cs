using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int a = int.Parse(sR.ReadLine());
            int answer = 0;
            while (a >=5)
            {
                answer+=a/5;
                a /= 5;
            }
            sW.WriteLine(answer);
            sW.Flush();