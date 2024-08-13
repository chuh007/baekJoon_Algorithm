int answer1 = 0;
            int answer2 = 0;
            int answer3 = 0;
            int a = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            foreach(int item in b)
            {
                if (item == 0)
                {
                    continue;
                }
                else if (item%c[0]==0)
                {
                    answer1+=item/c[0];
                }
                else
                {
                    answer1 += item/c[0]+1;
                }
            }
            answer2 = a / c[1];
            answer3 = a % c[1];
            Console.WriteLine(answer1);
            Console.WriteLine($"{answer2} {answer3}");