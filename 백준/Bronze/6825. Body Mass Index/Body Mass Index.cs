using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
float a = float.Parse(sr.ReadLine());
            float b = float.Parse(sr.ReadLine());
            float bmi = a / (b * b);
            if (bmi > 25)
            {
                sw.WriteLine("Overweight");
            }
            else if (bmi < 18.5)
            {
                sw.WriteLine("Underweight");
            }
            else
            {
                sw.WriteLine("Normal weight");
            }
            sw.Flush();