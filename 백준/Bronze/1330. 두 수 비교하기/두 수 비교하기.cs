string a = Console.ReadLine();
            string[] b = a.Split();
            int i = int.Parse(b[0]);
            int z = int.Parse(b[1]);
            if (i < z)
            {
                Console.WriteLine('<');
            }
            else if (i > z)
            {
                Console.WriteLine('>');
            }
            else
                Console.WriteLine("==");