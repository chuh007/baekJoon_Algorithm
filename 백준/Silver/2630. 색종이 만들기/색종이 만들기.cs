using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int[][] map = new int[n][];
            for (int i = 0; i < n; i++)
            {
                map[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            }
            int wCount = 0;
            int bCount = 0;
            MakeColorPapper(map, n);
            sw.WriteLine(wCount);
            sw.WriteLine(bCount);
            sw.Flush();

            void MakeColorPapper(int[][] array2, int num)
            {
                bool isSame = true;
                int baseValue = array2[0][0];
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (array2[i][j] != baseValue)
                        {
                            isSame = false;
                            break;
                        }
                    }
                    if (!isSame) break;
                }
                if (isSame)
                {
                    if (baseValue == 0) wCount++;
                    else bCount++;
                    return;
                }

                int half = num / 2;
                int[][] topLeft = new int[half][];
                for (int i = 0; i < half; i++)
                {
                    topLeft[i] = new int[half];
                    for (int j = 0; j < half; j++)
                    {
                        topLeft[i][j] = array2[i][j];
                    }
                }
                MakeColorPapper(topLeft, half);
                int[][] topRight = new int[half][];
                for (int i = 0; i < half; i++)
                {
                    topRight[i] = new int[half];
                    for (int j = 0; j < half; j++)
                    {
                        topRight[i][j] = array2[i][j + half];
                    }
                }
                MakeColorPapper(topRight, half);
                int[][] bottomLeft = new int[half][];
                for (int i = 0; i < half; i++)
                {
                    bottomLeft[i] = new int[half];
                    for (int j = 0; j < half; j++)
                    {
                        bottomLeft[i][j] = array2[i + half][j];
                    }
                }
                MakeColorPapper(bottomLeft, half);
                int[][] bottomRight = new int[half][];
                for (int i = 0; i < half; i++)
                {
                    bottomRight[i] = new int[half];
                    for (int j = 0; j < half; j++)
                    {
                        bottomRight[i][j] = array2[i + half][j + half];
                    }
                }
                MakeColorPapper(bottomRight, half);
            }