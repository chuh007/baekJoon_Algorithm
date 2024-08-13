using System.Text;
using System.IO;
using System;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                switch (s)
                {
                    case "1":
                        sb.AppendLine("1");
                        break;
                    case "2":
                        sb.AppendLine("2");
                        break;
                    case "3":
                        sb.AppendLine("4");
                        break;
                    case "4":
                        sb.AppendLine("7");
                        break;
                    case "5":
                        sb.AppendLine("13");
                        break;
                    case "6":
                        sb.AppendLine("24");
                        break;
                    case "7":
                        sb.AppendLine("44");
                        break;
                    case "8":
                        sb.AppendLine("81");
                        break;
                    case "9":
                        sb.AppendLine("149");
                        break;
                    case "10":
                        sb.AppendLine("274");
                        break;
                }
            }
            sw.Write(sb);
            sw.Flush();