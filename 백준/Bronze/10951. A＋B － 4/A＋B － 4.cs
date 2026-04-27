while(true)
            {
                string array = Console.ReadLine();
                if (array == null) break;
                string[] z =  array.Split(' ');
                int a = int.Parse(z[0]);
                int b = int.Parse(z[1]);
                Console.WriteLine(a+b);
            }