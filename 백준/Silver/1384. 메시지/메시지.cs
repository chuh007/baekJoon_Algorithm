using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int count = 0;
            while (true)
            {
                bool wow = true;
                int a = int.Parse(sr.ReadLine());
                if (a == 0) break;
                sb.AppendLine($"Group {++count}");
                string[] sArr = new string[a];
                string[] nameList = new string[a];
                for(int i = 0; i < a; i++)
                {
                    sArr[i] = sr.ReadLine();
                    string[] peaper = sArr[i].Split(' ');
                    nameList[i] = peaper[0];
                }
                for(int i = 0; i < sArr.Length; i++)
                {
                    string s = sArr[i];
                    string[] peaper = s.Split(' ');
                    nameList[i] = peaper[0];
                    for (int j = 1; j < a; j++)
                    {
                        if (peaper[j] == "N")
                        {
                            sb.AppendLine($"{nameList[(i - j + a) % a]} was nasty about {nameList[i]}");
                            wow = false;
                        }
                    }
                }
                if (wow) sb.AppendLine("Nobody was nasty");
                sb.AppendLine();
            }
            sw.Write(sb);
            sw.Flush();