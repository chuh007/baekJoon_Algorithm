using System.Text;
 StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int r = int.Parse(sr.ReadLine());
            sw.Write(a * 2 + 2 * 3.141592 * r);
            sw.Flush();