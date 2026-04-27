int[] arr = new int[30];
            for (int i = 0; i < 28; i++)
            {
                int q = int.Parse(Console.ReadLine());
                arr[q-1] = q;
            }
            for (int i = 0; i < 30; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine(i+1);
                }
            }