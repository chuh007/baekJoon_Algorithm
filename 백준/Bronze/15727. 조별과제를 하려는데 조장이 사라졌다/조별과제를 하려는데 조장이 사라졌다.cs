using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int wow = Convert.ToInt32(sR.ReadLine());
            int wow2 = wow / 5;
            if (wow % 5 != 0)
            {
                wow2++;
            }
            Console.WriteLine(wow2);