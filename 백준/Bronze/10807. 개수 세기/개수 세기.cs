int um = int.Parse(Console.ReadLine());
            int[] z = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int lok = int.Parse(Console.ReadLine());
            int c = 0;
            foreach (int a in z)
            {
                if (lok==a)
                {
                    c++;
                }
            }
            Console.WriteLine(c);