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
while (true)
            {
                BigInteger a = BigInteger.Parse(sr.ReadLine());
                if (a == 0) break;
                sw.WriteLine(a%42==0? "PREMIADO": "TENTE NOVAMENTE");
            }
            sw.Flush();