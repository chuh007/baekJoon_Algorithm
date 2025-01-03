using System.Linq;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for(int i = 0; i < arr[0]; i++)
            {
                string s = sr.ReadLine();
                sw.WriteLine(new string(s.Reverse().ToArray()));
            }
            sw.Flush();