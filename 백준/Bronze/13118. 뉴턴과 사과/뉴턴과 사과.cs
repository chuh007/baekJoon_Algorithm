using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            bool isFind = false;
            for (int i = 0; i < 4; i++)
            {
                if (input[i] == arr[0])
                {
                    sw.Write(i + 1);
                    isFind = true;
                    break;
                }
            }
            if (!isFind) sw.Write(0);
            sw.Flush();