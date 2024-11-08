using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if(input[0]==input[1]&&input[1] == input[2])
                sw.WriteLine(10000 + input[0] * 1000);
            else
            {
                if (input[0] == input[1])
                    sw.Write(1000 + input[0] * 100);
                else if (input[1] == input[2])
                    sw.Write(1000 + input[1] * 100);
                else if(input[0]==input[2])
                    sw.Write(1000 + input[0] * 100);
                else
                {
                    Array.Sort(input);
                    sw.Write(input[2] * 100);
                }
            }
            sw.Flush();