while (true)
            {
                bool isfalind = true;
                string s = Console.ReadLine();
                if (s == "0") break;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(s[i] == s[s.Length - 1-i]))
                    {
                        isfalind = false;
                        break;
                    }
                }
                if (isfalind)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }