int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                if (s.Length > 5 && s.Length < 10)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }