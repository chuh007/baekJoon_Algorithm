int i = int.Parse(Console.ReadLine());
            if (i % 4 == 0 && i % 100 != 0)
            {
                Console.WriteLine(1);
            }
            else if (i % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }