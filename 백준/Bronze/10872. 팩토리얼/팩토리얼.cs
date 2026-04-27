int i = int.Parse(Console.ReadLine());
            int b = i;

            for (int a = 1; a < i; a++)
            {
                b = b * a;
            }
            if (i == 0)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine($"{b}");