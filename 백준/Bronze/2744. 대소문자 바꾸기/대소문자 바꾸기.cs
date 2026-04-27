string s = Console.ReadLine();
            string a = "";
            for (int i=0; i < s.Length; i++)
            {
                char c = s[i];
                a += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
            }
            Console.WriteLine(a);