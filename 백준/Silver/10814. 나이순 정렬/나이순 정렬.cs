List<(int, string)> listIS = new List<(int, string)>();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                listIS.Add((int.Parse(s[0]), s[1]));
            }
            var sort = listIS.OrderBy(x => x.Item1);
            foreach (var wow in sort)
            {
                Console.WriteLine($"{wow.Item1} {wow.Item2}");
            }