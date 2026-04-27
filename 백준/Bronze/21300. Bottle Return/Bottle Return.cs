int sum = 0;
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            foreach(int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum*5);