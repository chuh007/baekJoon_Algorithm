using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int a = int.Parse(sR.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int[] arr = Array.ConvertAll(sR.ReadLine().Split(' '),int.Parse);
                int x = arr[0];
                int y = arr[1];
                int stopNum = arr[2];
                int nowNum = 0;
                for(int j = 1; j <= y; j++)
                {
                    for (int k = 1; k <= x; k++)
                    {
                        nowNum++;
                        if (nowNum == stopNum)
                        {
                            if (j > 9)
                            {
                                sW.WriteLine($"{k}{j}");
                            }
                            else
                            {
                                sW.WriteLine($"{k}0{j}");
                            }
                        }
                    }
                }
            }
            sW.Flush();