int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] z = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            foreach(int a in z)
            {
                if (a < ar[1])
                {
                    Console.Write(a+" ");
                }
            }