using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(sr.ReadLine());
            if (a < 425)
            {
                sw.WriteLine("Violet");
            }
            else if (a < 450)
            {
                sw.WriteLine("Indigo");
            }
            else if (a < 495)
            {
                sw.WriteLine("Blue");
            }
            else if (a < 570)
            {
                sw.WriteLine("Green");
            }
            else if (a < 590)
            {
                sw.WriteLine("Yellow");
            }
            else if (a < 620)
            {
                sw.WriteLine("Orange");
            }
            else
            {
                sw.WriteLine("Red");
            }
            sw.Flush();