int a = int.Parse(Console.ReadLine());
            for (int i = a - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = a - i - 1; k > 0; k--)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < a; i++)
            {
                for (int j = a; j > a - i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = a - i; k > 1; k--)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }