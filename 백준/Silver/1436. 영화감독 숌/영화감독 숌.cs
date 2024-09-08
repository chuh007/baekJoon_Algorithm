using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            int count = 0;
            int nowNum = 666;
            while (true)
            {
                if (nowNum.ToString().Contains("666"))
                {
                    count++;
                }
                if (count == a)
                {
                    sw.Write(nowNum);
                    break;
                }
                nowNum++;
            }
            sw.Flush();