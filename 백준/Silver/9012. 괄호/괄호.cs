using System.Collections;
using System.Text;
using System.IO;

 StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            Stack stack = new Stack();
            int a = int.Parse(sR.ReadLine());
            for (int i = 0; i < a; i++)
            {
                stack.Clear();
                bool isVPS = true;
                string s = sR.ReadLine();
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '(')
                    {
                        stack.Push(s[j]);
                    }
                    else if (s[j] == ')')
                    {
                        if (stack.Count == 0)
                        {
                            isVPS = false;
                            break;
                        }
                        stack.Pop();
                    }
                }
                if (stack.Count != 0) isVPS = false;
                sW.WriteLine(isVPS ? "YES" : "NO");
            }
            sW.Flush();