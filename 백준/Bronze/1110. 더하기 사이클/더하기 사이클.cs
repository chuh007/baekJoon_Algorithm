using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int input = int.Parse(sr.ReadLine());
            int n = input;
            int answer = 0;
            int a;
            int b;
            while (true)
            {
                answer++;
                a = n / 10;
                b = n % 10;
                n = (b * 10) + (a + b) % 10;
                if (n == input) break;
            }
            sw.Write(answer);
            sw.Flush();