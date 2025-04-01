using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string input = sr.ReadLine();
            int a = 0, b = 0;
            for (int i = 0; i < input.Length; i += 2)
            {
                char player = input[i];
                int points = input[i + 1] - '0';
                if (player == 'A')
                {
                    a += points;
                }
                else if (player == 'B')
                {
                    b += points;
                }
            }
            if (a > b)
            {
                sw.WriteLine("A");
            }
            else
            {
                sw.WriteLine("B");
            }
            sw.Flush();