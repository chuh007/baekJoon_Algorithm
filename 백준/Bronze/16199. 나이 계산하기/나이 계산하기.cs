using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            int[] input2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int age = input2[0] - input[0];
            if (input2[1] < input[1] || (input2[1] == input[1] && input2[2] < input[2]))
            {
                age--;
            }
            sw.WriteLine(age);
            int k = input2[0] - input[0] + 1;
            sw.WriteLine(k);
            int a = input2[0] - input[0];
            sw.WriteLine(a);
            sw.Flush();