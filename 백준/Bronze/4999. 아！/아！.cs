using System.Text;
using System.IO;

StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            string can = sR.ReadLine();
            string want = sR.ReadLine();
            sW.WriteLine(can.Length < want.Length ? "no": "go");
            sW.Flush();