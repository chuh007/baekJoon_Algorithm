string str = Console.ReadLine();
            bool m = false;
            bool o = false;
            bool b = false;
            bool i = false;
            bool s = false;
            foreach(char c in str)
            {
                if (c == 'M')
                {
                    m = true;
                }
                if(c == 'O')
                {
                    o = true;
                }
                if(c == 'B')
                {
                    b = true;
                }
                if(c == 'I')
                {
                    i = true;
                }
                if(c == 'S')
                {
                    s = true;
                }
            }
            if (m == true && o == true && b == true && i == true && s == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }