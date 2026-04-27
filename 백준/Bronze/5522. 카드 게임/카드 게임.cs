using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int answer = 0;
            for(int i = 0; i < 5; i++)
            {
                answer += int.Parse(sr.ReadLine());
            }
            sw.WriteLine(answer);
            sw.Flush();