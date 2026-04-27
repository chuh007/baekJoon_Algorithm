int a = int.Parse(Console.ReadLine());
            for (int i = a; i >= 1; i--)
            {
                for (int j = i; j <= a; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }