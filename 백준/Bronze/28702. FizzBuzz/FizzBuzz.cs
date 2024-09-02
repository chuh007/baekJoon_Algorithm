using System.Linq;
            using System.Threading.Tasks;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
string s1 = sr.ReadLine();
            string s2 = sr.ReadLine();
            string s3 = sr.ReadLine();
            try
            {
                int i = int.Parse(s1)+3;
                if (i % 15 == 0) sw.WriteLine("FizzBuzz");
                else if (i % 5 == 0) sw.WriteLine("Buzz");
                else if (i % 3 == 0) sw.WriteLine("Fizz");
                else sw.WriteLine(i);
            }
            catch
            {
                try
                {
                    int i = int.Parse(s2)+2;
                    if (i % 15 == 0) sw.WriteLine("FizzBuzz");
                    else if (i % 5 == 0) sw.WriteLine("Buzz");
                    else if (i % 3 == 0) sw.WriteLine("Fizz");
                    else sw.WriteLine(i);
                }
                catch
                {
                    int i = int.Parse(s3)+1;
                    if (i % 15 == 0) sw.WriteLine("FizzBuzz");
                    else if (i % 5 == 0) sw.WriteLine("Buzz");
                    else if (i % 3 == 0) sw.WriteLine("Fizz");
                    else sw.WriteLine(i);
                }
            }
            sw.Flush();