using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
double sum = 0;
            double hakjumSum = 0;
            for (int i = 0; i < 20; i++)
            {
                string[] s = sr.ReadLine().Split();
                if (s[2] == "P") continue;
                double hakjum = double.Parse(s[1]);
                hakjumSum += hakjum;
                if (s[2] == "A+") sum += 4.5 * hakjum;
                else if(s[2] == "A0") sum += 4.0 * hakjum;
                else if(s[2] == "B+") sum += 3.5 * hakjum;
                else if(s[2] == "B0") sum += 3.0 * hakjum;
                else if(s[2] == "C+") sum += 2.5 * hakjum;
                else if(s[2] == "C0") sum += 2.0 * hakjum;
                else if(s[2] == "D+") sum += 1.5 * hakjum;
                else if(s[2] == "D0") sum += 1.0 * hakjum;
            }
            sw.Write(sum / hakjumSum);
            sw.Flush();