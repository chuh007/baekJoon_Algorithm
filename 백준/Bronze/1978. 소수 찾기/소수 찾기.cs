int a = int.Parse(Console.ReadLine());
            int[] su = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sosuCount = 0;
            for (int i = 0; i < a; i++)
            {
                bool issosu = true;
                if (su[i] == 1) issosu = false;
                for (int j = su[i]-1; j > 1; j--)
                {
                    if (su[i] % j == 0)
                    {
                        issosu = false;
                        break;
                    }
                }
                if (issosu)
                {
                    sosuCount++;
                }
            }
            Console.WriteLine(sosuCount);