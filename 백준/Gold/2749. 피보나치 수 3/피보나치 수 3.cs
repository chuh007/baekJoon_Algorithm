using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long input = long.Parse(sr.ReadLine());
            Dictionary<long, long> fibo = new Dictionary<long, long>();
            sw.WriteLine(F(input));
            sw.Flush();
            long F(long n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                if (fibo.ContainsKey(n))
                    return fibo[n];
                long res;
                if (n % 2 == 0)
                {
                    long a = F(n / 2);
                    res = (a % 1000000 * (2 * F(n / 2 - 1) % 1000000 + a) % 1000000) % 1000000;
                }
                else
                {
                    long a = F((n + 1) / 2);
                    long b = F((n - 1) / 2);
                    res = ((a % 1000000 * a % 1000000) % 1000000 + (b % 1000000 * b % 1000000) % 1000000) % 1000000;
                }
                fibo[n] = res;
                return res;
            }