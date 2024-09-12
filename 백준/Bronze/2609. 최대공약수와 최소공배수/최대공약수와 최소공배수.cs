int[] silverGo = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int smailCount = 0;
            int maxCount = 0;
            for(int i=silverGo[0];i>0; i--)
            {
                if (silverGo[0] % i == 0 && silverGo[1] % i == 0)
                {
                    maxCount = i;
                    break;
                }
            }
            for (int i = silverGo[0]; i < 1000000000; i++)
            {
                if (i % silverGo[0] == 0 && i % silverGo[1] == 0)
                {
                    smailCount = i;
                    break;
                }
            }
            Console.WriteLine(maxCount);
            Console.WriteLine(smailCount);