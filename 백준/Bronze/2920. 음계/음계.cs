using System.Text;
using System.IO;

StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int[] arr = Array.ConvertAll(sR.ReadLine().Split(' '),int.Parse);
            bool isasc = true;
            bool isdes = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != (i + 1))
                {
                    isasc = false;
                }
                if (arr[i] != (8 - i))
                {
                    isdes = false;
                }
            }
            if (isasc)
            {
                sW.WriteLine("ascending");
            }
            else if (isdes)
            {
                sW.WriteLine("descending");
            }
            else
            {
                sW.WriteLine("mixed");
            }
            sW.Flush();