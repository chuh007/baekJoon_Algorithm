
using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int[] answers = new int[10];
            int a = int.Parse(sR.ReadLine());
            int b = int.Parse(sR.ReadLine());
            int c = int.Parse(sR.ReadLine());
            int pro = a * b * c;
            string sPro = pro.ToString();
            foreach(int item in sPro)
            {
                answers[item-48]++;
            }
            foreach(int i in answers)
            {
                sW.WriteLine(i);
            }
            sW.Flush();