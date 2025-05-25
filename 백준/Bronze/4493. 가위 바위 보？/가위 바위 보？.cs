using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int t = int.Parse(sr.ReadLine());
            for(int q = 0; q < t; q++)
            {
                int p1 = 0, p2 = 0;
                int a = int.Parse(sr.ReadLine());
                for(int i = 0; i < a; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    if ((input[0] == "P" && input[1] == "R") || (input[0] == "S" && input[1] == "P") || (input[0] == "R" && input[1] == "S"))
                        p1++;
                    if ((input[0] == "P" && input[1] == "S") || (input[0] == "S" && input[1] == "R") || (input[0] == "R" && input[1] == "P"))
                        p2++;
                }
                if (p1 > p2) sw.WriteLine("Player 1");
                else if (p1 < p2) sw.WriteLine("Player 2");
                else sw.WriteLine("TIE");
            }
            sw.Flush();