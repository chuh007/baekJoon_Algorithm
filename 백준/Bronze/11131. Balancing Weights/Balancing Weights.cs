using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int n = int.Parse(sr.ReadLine());
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int balancing = 0;
                for (int j = 0; j < n; j++)
                    balancing += input[j];

                if (balancing == 0)
                    sw.WriteLine("Equilibrium");
                else if (balancing > 0)
                    sw.WriteLine("Right");
                else
                    sw.WriteLine("Left");
            }
            sw.Flush();