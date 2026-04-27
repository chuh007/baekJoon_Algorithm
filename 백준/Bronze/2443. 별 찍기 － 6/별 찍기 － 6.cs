int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <a; i++)
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