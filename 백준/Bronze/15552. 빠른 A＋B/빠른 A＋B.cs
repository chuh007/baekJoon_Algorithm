using System.Text;
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                sb.Append(int.Parse(z[0]) + int.Parse(z[1])+"\n");
            }
            Console.WriteLine(sb.ToString());