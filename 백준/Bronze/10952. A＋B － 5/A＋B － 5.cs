while(true)
            {
                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (array[0] == 0 && array[1] == 0) break;
                Console.WriteLine(array[0]+array[1]);
            }