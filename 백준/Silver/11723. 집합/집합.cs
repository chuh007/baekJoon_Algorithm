using System.Text;
using System.IO;

StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int a = int.Parse(sR.ReadLine());
            int bit = 0;
            for(int i = 0; i < a; i++)
            {
                string[] s = sR.ReadLine().Split(' ');
                int num = 0;
                if (s.Length > 1)
                {
                    num = int.Parse(s[1]);
                }
                if (s[0] == "add")
                {
                    bit |= (1 << num);
                }
                else if (s[0] == "remove")
                {
                    bit &= ~(1 << num);
                }
                else if (s[0] == "check")
                {
                    sW.WriteLine((bit&(1<<num)) != 0 ? 1:0);
                }
                else if (s[0] == "toggle")
                {
                    bit ^= (1 << num);
                }
                else if (s[0] == "all")
                {
                    bit = (1 << 21) - 1;
                }
                else if (s[0] == "empty")
                {
                    bit = 0;
                }
            }
            sW.Flush();