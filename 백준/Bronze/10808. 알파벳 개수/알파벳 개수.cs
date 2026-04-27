using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            string s = sr.ReadLine();
            int[] answer = new int[26];
            foreach(int item in s)
            {
                answer[item - 97]++;
            }
            foreach(int i in answer)
            {
                sw.Write($"{i} ");
            }
            sw.Flush();