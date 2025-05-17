using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int cnt = 0;
            float[] input;
            for(int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                input = Array.ConvertAll(s.Replace("  ", " ").Split(), float.Parse);
                if (((input[0] <= 56f && input[1] <= 45f && input[2] <= 25f) || (input[0] + input[1] + input[2] <= 125f)) && input[3] <= 7f)
                {
                    sw.WriteLine(1);
                    cnt++;
                }
                else sw.WriteLine(0);
            }
            sw.WriteLine(cnt);
            sw.Flush();