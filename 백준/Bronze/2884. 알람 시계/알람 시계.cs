using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int[] a = Array.ConvertAll(sR.ReadLine().Split(' '),int.Parse);
            int hour = a[0];
            int minute = a[1];
            minute -= 45;
            if (minute < 0)
            {
                minute += 60;
                if (hour == 0)
                {
                    hour = 24;
                }
                hour--;
            }
            
            sW.WriteLine($"{hour} {minute}");
            sW.Flush();