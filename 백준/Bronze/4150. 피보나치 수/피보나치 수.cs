using System.Numerics;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
BigInteger input = BigInteger.Parse(sr.ReadLine());
            Dictionary<BigInteger, BigInteger> fibo = new Dictionary<BigInteger, BigInteger>();
            sw.WriteLine(F(input));
            sw.Flush();
            BigInteger F(BigInteger n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                if (fibo.ContainsKey(n))
                    return fibo[n];
                BigInteger res;
                if (n % 2 == 0)
                {
                    BigInteger a = F(n / 2);
                    res = (a * (2 * F(n / 2 - 1) + a));
                }
                else
                {
                    BigInteger a = F((n + 1) / 2);
                    BigInteger b = F((n - 1) / 2);
                    res = ((a * a) + (b * b));
                }
                fibo[n] = res;
                return res;
            }