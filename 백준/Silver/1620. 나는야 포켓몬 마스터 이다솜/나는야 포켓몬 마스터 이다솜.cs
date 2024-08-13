using System.Collections.Generic;
using System.Text;
using System.IO;
StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            int[] a = Array.ConvertAll(sR.ReadLine().Split(' '), int.Parse);
            int inputCount = a[0];
            int outputCount = a[1];
            for(int i = 0; i < inputCount; i++)
            {
                string input = sR.ReadLine();
                dic.Add(i+1,input);
                dic2.Add(input,i+1);
            }
            for(int i = 0; i < outputCount; i++)
            {
                string input = sR.ReadLine();
                if(Int32.TryParse(input,out int intInput))
                {
                    sW.WriteLine(dic[intInput]);
                }
                else
                {
                    sW.WriteLine(dic2[input]);
                }
            }
            sW.Flush();