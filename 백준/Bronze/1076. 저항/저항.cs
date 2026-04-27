using System;
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
long a = 0;
            string s1 = sr.ReadLine();
            string s2 = sr.ReadLine();
            string s3 = sr.ReadLine();
            switch (s1)
            {
                case "black":
                    a = 0;
                    break;
                case "brown":
                    a = 10;
                    break;
                case "red":
                    a = 20;
                    break;
                case "orange":
                    a = 30;
                    break;
                case "yellow":
                    a = 40;
                    break;
                case "green":
                    a = 50;
                    break;
                case "blue":
                    a = 60;
                    break;
                case "violet":
                    a = 70;
                    break;
                case "grey":
                    a = 80;
                    break;
                default:
                    a = 90;
                    break;
            }
            switch (s2)
            {
                case "black":
                    a += 0;
                    break;
                case "brown":
                    a += 1;
                    break;
                case "red":
                    a += 2;
                    break;
                case "orange":
                    a += 3;
                    break;
                case "yellow":
                    a += 4;
                    break;
                case "green":
                    a += 5;
                    break;
                case "blue":
                    a += 6;
                    break;
                case "violet":
                    a += 7;
                    break;
                case "grey":
                    a += 8;
                    break;
                default:
                    a += 9;
                    break;
            }
            switch (s3)
            {
                case "black":
                    a *= 1;
                    break;
                case "brown":
                    a *= 10;
                    break;
                case "red":
                    a *= 100;
                    break;
                case "orange":
                    a *= 1000;
                    break;
                case "yellow":
                    a *= 10000;
                    break;
                case "green":
                    a *= 100000;
                    break;
                case "blue":
                    a *= 1000000;
                    break;
                case "violet":
                    a *= 10000000;
                    break;
                case "grey":
                    a *= 100000000;
                    break;
                default:
                    a *= 1000000000;
                    break;
            }
            sw.WriteLine(a);
            sw.Flush();