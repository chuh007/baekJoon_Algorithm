while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(arr);
                if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0)
                {
                    break;
                }
                else if (((arr[0]*arr[0])+(arr[1]*arr[1]))==arr[2]*arr[2])
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }