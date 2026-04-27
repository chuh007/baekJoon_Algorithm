string a = Console.ReadLine();
            string[] b = a.Split();
            int i0 = int.Parse(b[0]);
            int i1 = int.Parse(b[1]);
            int i2 = int.Parse(b[2]);
            int i3 = int.Parse(b[3]);
            int i4 = int.Parse(b[4]);
            int z = ((i0*i0)+(i1*i1)+(i2*i2)+(i3*i3)+(i4*i4))%10;
            Console.WriteLine(z);