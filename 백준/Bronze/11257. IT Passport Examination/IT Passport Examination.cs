using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            bool isPass;
            for(int i = 0; i < a; i++)
            {
                isPass = true;
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (input[1] + input[2] + input[3] < 55) isPass = false;
                if (11 > input[1] || 8 > input[2] || 12 > input[3]) isPass = false;
                if (isPass) sw.WriteLine($"{input[0]} {input[1] + input[2] + input[3]} PASS");
                else sw.WriteLine($"{input[0]} {input[1] + input[2] + input[3]} FAIL");
            }
            sw.Flush();