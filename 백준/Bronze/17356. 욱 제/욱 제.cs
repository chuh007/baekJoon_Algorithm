using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
float[] input = Array.ConvertAll(sr.ReadLine().Split(),float.Parse);
float m = (input[1] - input[0]) / 400;
sw.WriteLine(1 / (1 + Math.Pow(10, m)));
sw.Close();