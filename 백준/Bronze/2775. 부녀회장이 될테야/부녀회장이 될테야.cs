using System.Linq;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int[,] apartment = new int[15, 14];
            for(int i = 1; i < 15; i++)
            {
                apartment[0, i-1] = i;
            }
            for (int i = 0; i < 15; i++)
            {
                apartment[i, 0] = 1;
            }
            for (int i = 1; i < 15; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    apartment[i,j] = apartment[i - 1, j] + apartment[i, j - 1];
                }
            }
            int t = int.Parse(sr.ReadLine());
            for(int i = 0; i < t; i++)
            {
                int k = int.Parse(sr.ReadLine());
                int n = int.Parse(sr.ReadLine());
                sw.WriteLine(apartment[k,n-1]);
            }
            sw.Flush();