int a = int.Parse(Console.ReadLine());
            List<string> s = new List<string>();
            for (int i = 0; i < a; i++)
            {
                s.Add(Console.ReadLine());
            }
            s = s.Distinct().ToList();
            var solt = from w in s
                       orderby w.Length, w
                       select w;
            foreach(string cw in solt)
            {
                Console.WriteLine(cw);
            }