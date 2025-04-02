using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int num;
            for(int i = 0; i < a; i++)
            {
                string[] s = sr.ReadLine().Split();
                for(int j = 0; j < s.Length; j++)
                {
                    num = 0;
                    for(int k = 0; k < s[j].Length; k++)
                    {
                        num += s[j][k] - 'a';
                    }
                    num %= 27;
                    if (num == 26) sw.Write(" ");
                    else sw.Write((char)(num + 'a'));
                }
                sw.WriteLine();
            }
            sw.Flush();