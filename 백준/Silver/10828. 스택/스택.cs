using System.Collections;
using System.Text;
using System.IO;

StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int a = int.Parse(sR.ReadLine());
            Stack stack = new Stack();
            for (int i = 0; i < a;i++)
            {
                string comand = sR.ReadLine();
                if (comand == "top")
                {
                    if (stack.Count == 0)
                    {
                        sW.WriteLine(-1);
                    }
                    else
                    {
                        sW.WriteLine(stack.Peek());
                    }
                }
                if (comand == "empty")
                {
                    if (stack.Count == 0)
                    {
                        sW.WriteLine(1);
                    }
                    else
                    {
                        sW.WriteLine(0);
                    }
                }
                if (comand == "size")
                {
                    sW.WriteLine(stack.Count);
                }
                if (comand == "pop")
                {
                    if (stack.Count == 0)
                    {
                        sW.WriteLine(-1);
                    }
                    else
                    {
                        sW.WriteLine(stack.Pop());
                    }
                }
                else
                {
                    string[] pushCom = comand.Split(' ');
                    if(pushCom[0]=="push")
                        stack.Push(pushCom[1]);
                }

            }
            sW.Flush();