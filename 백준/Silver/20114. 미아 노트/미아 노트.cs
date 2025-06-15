using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            char[] answer = new char[input[0]];
            for(int i = 0; i < input[0]; i++)
            {
                answer[i] = '?';
            }
            for (int i = 0; i < input[1]; i++)
            {
                string s = sr.ReadLine();
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] != '?') answer[j / input[2]] = s[j];
                }
            }
            foreach(char c in answer)
            {
                sw.Write(c);
            }
            sw.Flush();