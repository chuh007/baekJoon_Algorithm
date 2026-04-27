long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            Console.WriteLine((a[0] + a[1]) * (a[0] -a[1]));