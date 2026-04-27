int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
                Console.WriteLine($"Case #{i+1}: {ab[0]} + {ab[1]} = {ab[0]+ab[1]}");
            }