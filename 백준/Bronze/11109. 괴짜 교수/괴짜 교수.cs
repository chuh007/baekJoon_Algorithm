using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int bNum, num;
            for(int i = 0;i < a; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                bNum = input[0] + input[1] * input[3];
                num = input[1] * input[2];
                if (bNum == num) sw.Write("does not matter\n");
                else if (bNum > num) sw.Write("do not parallelize\n");
                else sw.Write("parallelize\n");
            }
            sw.Flush();