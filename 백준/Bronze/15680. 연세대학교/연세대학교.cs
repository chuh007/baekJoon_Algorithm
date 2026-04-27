using System;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            sw.Write(s == "0" ? "YONSEI" : "Leading the Way to the Future");
            sw.Flush();