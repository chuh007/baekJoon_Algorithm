using System.IO;
using System.Collections.Generic;
using System.Linq;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
sw.Write(arr1[0] * 13 + arr1[1] * 7 + arr1[2] * 5 + arr1[3] * 3 + arr1[4] * 3 + arr1[5] * 2 > arr2[0] * 13 + arr2[1] * 7 + arr2[2] * 5 + arr2[3] * 3 + arr2[4] * 3 + arr2[5] * 2 + 1.5 ? "cocjr0208" : "ekwoo");
sw.Flush();