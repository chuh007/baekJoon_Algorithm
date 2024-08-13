using System.Text;
using System.IO;
            StreamReader sR = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sW = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sB = new StringBuilder();
            int a = int.Parse(sR.ReadLine());
            int[] arr1 = new int[a];
            arr1 = Array.ConvertAll(sR.ReadLine().Split(' '), int.Parse);
            int b = int.Parse(sR.ReadLine());
            int[] arr2 = new int[b];
            arr2 = Array.ConvertAll(sR.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr1);
            for (int i = 0; i < b; i++)
            {
                int low = 0;
                int high = arr1.Length - 1;
                bool end = false;
                while (!end && low <= high)
                {
                    int middle = (low + high) / 2;
                    if (arr1[middle] == arr2[i])
                    {
                        end = true;
                    }
                    else if (arr1[middle] > arr2[i])
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }
                sW.WriteLine(end ? 1 : 0);
            }
            sW.Flush();