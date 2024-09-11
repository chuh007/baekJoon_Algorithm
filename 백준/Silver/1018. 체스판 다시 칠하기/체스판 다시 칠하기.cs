using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = NM[0];
            int m = NM[1];
            int min = 65;
            string[] arr = new string[n];
            for(int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                arr[i] = line;
            }
            for(int i = 0; i <= n - 8; i++)
            {
                for(int j = 0; j <= m - 8; j++)
                {
                    int case1 = 64, case2 = 64;
                    for(int a = 0; a < 8; a++)
                    {
                        for(int b = 0; b < 8; b++)
                        {
                            if ((i+a+j+b) % 2 == 0)
                            {
                                if (arr[i + a][j + b] != 'W') case1--;
                                else if (arr[i + a][j + b] != 'B') case2--;
                            }
                            else
                            {
                                if (arr[i + a][j + b] != 'W') case2--;
                                else if (arr[i + a][j + b] != 'B') case1--;
                            }
                        }
                    }
                    case1 = case1 < case2 ? case1 : case2;
                    if (min > case1) min = case1;
                }
            }
            sw.WriteLine(min);
            sw.Flush();