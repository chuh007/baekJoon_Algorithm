using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string[] arr = { " @@@   @@@  ", "@   @ @   @ ", "@    @    @ ", "@         @ ", " @       @  ", "  @     @   ", "   @   @    ", "    @ @     ", "     @      " };
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    sw.Write(arr[i]);
                }
                sw.WriteLine();
            }
            sw.Flush();