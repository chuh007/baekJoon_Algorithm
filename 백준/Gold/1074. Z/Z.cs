using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.Write(Z(input[0], input[1], input[2]));
            sw.Flush();
            int Z(int n, int r, int c)
            {
                if (n == 0) return 0;
                int half = (int)Math.Pow(2, n - 1);
                if (r < half && c < half) return Z(n - 1, r, c);
                else if (r < half && c >= half) return half * half + Z(n - 1, r, c - half);
                else if (r >= half && c < half) return 2 * half * half + Z(n - 1, r - half, c);
                else return 3 * half * half + Z(n - 1, r - half, c - half);
            }