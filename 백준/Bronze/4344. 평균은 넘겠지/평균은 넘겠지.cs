using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            int sum = 0;
            int wow = 0;

            for (int i = 0; i < a; i++)
            {
                sum = 0;
                wow = 0;
                int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                for (int j = 1; j <= input[0]; j++)
                {
                    sum += input[j];
                }
                float ave = (float)sum / input[0];
                for (int j = 1; j <= input[0]; j++)
                {
                    if (input[j] > ave)
                    {
                        wow++;
                    }
                }
                float per = (float)wow / input[0];
                sb.AppendLine(Math.Round(per * 100, 3).ToString() + '%');
            }
            sw.Write(sb);
            sw.Flush();