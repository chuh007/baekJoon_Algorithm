using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = input[1] / input[0];
            a = a * input[2] * 3;
            sw.WriteLine(a);
            sw.Flush();