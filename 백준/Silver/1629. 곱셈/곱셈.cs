using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            long answer = Product(input[0], input[1]) % input[2];
            sw.Write(answer);
            sw.Flush();
            long Product(int a, int b)
            {
                if (b == 1) return a;
                if (b % 2 == 0)
                {
                    long num = Product(a, b / 2) % input[2];
                    return num % input[2] * num % input[2];
                }
                else
                {
                    long num = Product(a, (b - 1) / 2) % input[2];
                    return num % input[2] * num % input[2] * a % input[2];
                }
            }