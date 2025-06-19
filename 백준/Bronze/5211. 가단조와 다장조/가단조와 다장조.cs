using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int a = 0, c = 0;
            string[] arr = sr.ReadLine().Split('|');
            foreach (string s in arr)
            {
                if (s[0] == 'A' || s[0] == 'D' || s[0] == 'E') a++;
                else if(s[0] == 'C' || s[0] == 'F' || s[0] == 'G') c++;
            }
            if (a == c)
            {
                char ch = arr[arr.Length - 1][arr[arr.Length - 1].Length - 1];
                if (ch == 'A' || ch == 'D' || ch == 'E') sw.Write("A-minor");
                else sw.Write("C-major");
            }
            else sw.Write(a > c ? "A-minor" : "C-major");
            sw.Flush();