using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int answer = 0;
            foreach(int i in input)
            {
                if (i == a)
                {
                    answer++;
                }
            }
            sw.WriteLine(answer);
            sw.Flush();